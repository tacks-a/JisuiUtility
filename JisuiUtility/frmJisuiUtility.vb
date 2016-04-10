Imports iTextSharp.text.pdf
Imports iTextSharp.text.pdf.parser
Imports iTextSharp.text
Imports System.IO

''' <summary>
''' 自炊ユーティリティ
''' </summary>
''' <remarks></remarks>
Public Class frmJisuiUtility

#Region "Property"
    ''' <summary>
    ''' テンポラリディレクトリ
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private ReadOnly Property TmpDir As String
        Get
            Return System.IO.Path.Combine(My.Application.Info.DirectoryPath, "tmp")
        End Get
    End Property
#End Region

#Region "Event"
    ''' <summary>
    ''' ロード
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmJisuiUtility_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Text &= " ver" & My.Application.Info.Version.ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace)
        End Try
    End Sub

    ''' <summary>
    ''' ISBNリネーム
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCreateRenameIsbnBatch_Click(sender As Object, e As EventArgs) Handles btnCreateRenameIsbnBatch.Click
        Try
            tbc.Enabled = False
            txtIsbn.Clear()
            txtIsbnCmd.Clear()

            'テンポラリを削除
            If Directory.Exists(Me.TmpDir) Then
                Directory.Delete(Me.TmpDir, True)
            End If
            Directory.CreateDirectory(Me.TmpDir)

            Dim files As String() = System.IO.Directory.GetFiles(Me.txtPdfDir.Text, Me.txtFilter.Text)
            Dim pdfFile As String
            For i As Integer = 0 To files.Length - 1
                pdfFile = files(i)
                '表示
                Me.lblCount.Text = String.Format("{0}/{1}", (i + 1), files.Length)
                Me.lblInfo.Text = pdfFile
                Me.Refresh()
                Application.DoEvents()
                GC.Collect()

                'ISBNを取得
                Dim isbn As String = String.Empty
                Dim cmd As String = String.Empty
                Me.SetIsbnAndRenameCommand(pdfFile, isbn, cmd)

                Me.txtIsbn.AppendText(isbn & vbCrLf)
                Me.txtIsbnCmd.AppendText(cmd & vbCrLf)
            Next

            'バッチファイル作成
            Me.WriteBatch(Me.txtRenameIsbnBatchPath.Text, Me.txtIsbnCmd.Text, Me.chkDoRenameIsbnBatach.Checked)

            '設定の保存
            My.Settings.Save()
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace)
        Finally
            tbc.Enabled = True
        End Try

    End Sub

    ''' <summary>
    ''' 本リネーム
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCreateRenameBookBatch_Click(sender As Object, e As EventArgs) Handles btnCreateRenameBookBatch.Click
        Try
            Me.txtRenameBookCmd.Clear()

            'CSV読込
            Dim dt As DataTable = ReadCsv()

            For Each row As DataRow In dt.Rows
                'リネームコマンド作成
                Dim stbCommand As New System.Text.StringBuilder
                Dim srcFile As String = Me.FormatFileName(Me.txtFileNameOriginal.Text, row, Me.txtFileNameReplaceEtc.Text)
                Dim dstFile As String = Me.FormatFileName(Me.txtFileNameReplace.Text, row, Me.txtFileNameReplaceEtc.Text)
                stbCommand.Append("rename """)
                stbCommand.Append(txtPdfDir.Text.TrimEnd("\") & "\")
                stbCommand.Append(srcFile)
                stbCommand.Append(""" """)
                stbCommand.Append(dstFile)
                stbCommand.Append("""")
                Me.txtRenameBookCmd.AppendText(stbCommand.ToString() & vbCrLf)

                '元ファイルが存在する場合、変更先ファイルを保存場所に設定
                For Each srcPath As String In System.IO.Directory.GetFiles(Me.txtPdfDir.Text, srcFile)
                    Dim dstPath As String = System.IO.Path.Combine(Me.txtPdfDir.Text, dstFile.ToString())
                    '保管場所を上書き
                    For Each col As DataColumn In dt.Columns
                        If col.ColumnName.EndsWith("保管場所") Then
                            row(col) = dstPath
                            Exit For
                        End If
                    Next
                    Exit For
                Next
            Next

            'CSVを出力
            WriteCsv(dt)

            'バッチファイル作成
            Me.WriteBatch(Me.txtRenameBookBatchPath.Text, Me.txtRenameBookCmd.Text, Me.chkDoRenameBookBatach.Checked)

            '設定の保存
            My.Settings.Save()
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace)
        End Try
    End Sub

    ''' <summary>
    ''' CSV項目設定
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCsvItems_Click(sender As Object, e As EventArgs) Handles btnCsvItems.Click
        Try
            Me.txtCsvItems.Clear()

            'CSV読込
            Dim dt As DataTable = ReadCsv()

            For Each col As DataColumn In dt.Columns
                Me.txtCsvItems.AppendText(String.Format("[{0}]", col.ColumnName))
                If dt.Rows.Count > 0 Then
                    Me.txtCsvItems.AppendText(dt.Rows(0)(col))
                End If
                Me.txtCsvItems.AppendText(vbCrLf)
            Next

            '設定の保存
            My.Settings.Save()
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.StackTrace)
        End Try
    End Sub

#End Region

#Region "Method"

    ''' <summary>
    ''' PDFファイルからISBNを取得する
    ''' </summary>
    ''' <param name="pdfFile"></param>
    ''' <param name="isbn"></param>
    ''' <param name="command"></param>
    ''' <remarks></remarks>
    Public Sub SetIsbnAndRenameCommand(ByVal pdfFile As String, ByRef isbn As String, ByRef command As String)
        Try
            isbn = String.Empty
            command = String.Empty

            'PDFを読み込んで、最初と最後のページのバーコード読み取り
            Dim imageList As List(Of System.Drawing.Image) = ExtractImages(pdfFile)
            Dim targetPageIndexList As New List(Of Integer)
            Dim stbIsbn As New System.Text.StringBuilder()
            If imageList.Count > 0 Then
                targetPageIndexList.Add(0)
                targetPageIndexList.Add(imageList.Count - 1)
            End If
            For Each pageIndex As Integer In targetPageIndexList
                'テンポラリファイル作成
                Dim savePath As String = System.IO.Path.Combine(Me.TmpDir, System.IO.Path.GetFileNameWithoutExtension(pdfFile) & pageIndex & ".jpg")
                imageList(pageIndex).Save(savePath, Imaging.ImageFormat.Jpeg)

                'イメージを表示
                Me.picBarcode.Image = imageList(pageIndex)
                Me.Refresh()
                Application.DoEvents()

                'バーコード読み取り
                Dim barcode As String = ExecZBar(savePath)
                For Each readText As String In barcode.Split(vbLf)
                    If readText.StartsWith("EAN-13:") Then
                        Dim isbnWk As String = readText.Replace("EAN-13:", "").Trim()
                        If System.Text.RegularExpressions.Regex.IsMatch(isbnWk, Me.txtIsbnRegex.Text) Then
                            stbIsbn.Append(isbnWk & ".")
                        End If
                    End If
                Next
            Next
            isbn = stbIsbn.ToString().TrimEnd(".")

            'コマンド作成
            If isbn.Length <> 0 Then
                'リネーム用のコマンド
                command = String.Format("rename ""{0}"" ""{1}.pdf""", _
                                                    pdfFile, _
                                                    isbn)
            Else
                'ISBNを取得できない場合は、コメントを追加
                command = Me.StringToCommandComment(String.Format("""{0}""", pdfFile))
                command &= Me.StringToCommandComment(Me.GetPdfText(pdfFile, 6, 1))
            End If

        Catch ex As Exception
            command = Me.StringToCommandComment(String.Format("""{0}""", pdfFile))
            command &= vbCrLf & Me.StringToCommandComment(ex.Message & vbCrLf & ex.StackTrace)
        End Try

    End Sub

    ''' <summary>
    '''  Extract Image from PDF file and Store in Image Object
    ''' </summary>
    ''' <param name="PDFSourcePath">Specify PDF Source Path</param>
    ''' <returns>List</returns>
    ''' <remarks>
    ''' 下記のページを参考にした
    ''' http://kishor-naik-dotnet.blogspot.jp/2011/01/cnet-extract-image-from-pdf-file.html
    ''' </remarks>
    Public Function ExtractImages(ByVal PDFSourcePath As String) As List(Of System.Drawing.Image)
        Dim ImgList As List(Of System.Drawing.Image) = New List(Of System.Drawing.Image)
        Dim RAFObj As iTextSharp.text.pdf.RandomAccessFileOrArray = Nothing
        Dim PDFReaderObj As iTextSharp.text.pdf.PdfReader = Nothing
        Dim PDFObj As iTextSharp.text.pdf.PdfObject = Nothing
        Dim PDFStremObj As iTextSharp.text.pdf.PdfStream = Nothing
        Try
            RAFObj = New iTextSharp.text.pdf.RandomAccessFileOrArray(PDFSourcePath)
            PDFReaderObj = New iTextSharp.text.pdf.PdfReader(RAFObj, Nothing)
            Dim i As Integer = 0
            Do While (i _
                        <= (PDFReaderObj.XrefSize - 1))
                PDFObj = PDFReaderObj.GetPdfObject(i)
                If ((Not (PDFObj) Is Nothing) _
                            AndAlso PDFObj.IsStream) Then
                    PDFStremObj = CType(PDFObj, iTextSharp.text.pdf.PdfStream)
                    Dim subtype As iTextSharp.text.pdf.PdfObject = PDFStremObj.Get(iTextSharp.text.pdf.PdfName.SUBTYPE)
                    If ((Not (subtype) Is Nothing) _
                                AndAlso (subtype.ToString = iTextSharp.text.pdf.PdfName.IMAGE.ToString)) Then
                        Try
                            Dim PdfImageObj As iTextSharp.text.pdf.parser.PdfImageObject = New iTextSharp.text.pdf.parser.PdfImageObject(CType(PDFStremObj, iTextSharp.text.pdf.PRStream))
                            Dim ImgPDF As System.Drawing.Image = PdfImageObj.GetDrawingImage
                            ImgList.Add(ImgPDF)
                        Catch e As Exception

                        End Try

                    End If

                End If

                i = (i + 1)
            Loop

            PDFReaderObj.Close()
        Catch ex As Exception
            Throw
        End Try

        Return ImgList
    End Function

    ''' <summary>
    '''  Extract Text from PDF file and Store in Image Object
    ''' </summary>
    ''' <param name="PDFSourcePath">Specify PDF Source Path</param>
    ''' <returns>List</returns>
    ''' <remarks>
    ''' 下記のページを参考にした
    ''' http://monobook.org/wiki/Mono/PDF%E3%81%8B%E3%82%89%E3%83%86%E3%82%AD%E3%82%B9%E3%83%88%E3%82%92%E6%8A%BD%E5%87%BA%E3%81%99%E3%82%8B
    ''' </remarks>
    Public Function GetPdfText(ByVal PDFSourcePath As String, ByVal FirstPageCount As Integer, ByVal LastPageCount As Integer) As String
        Dim rtn As New System.Text.StringBuilder()

        Using pdfReader = New PdfReader(PDFSourcePath)
            For pageNum As Integer = 1 To pdfReader.NumberOfPages
                If pageNum <= FirstPageCount OrElse pdfReader.NumberOfPages - pageNum < LastPageCount Then
                    ' １ページまるごとテキスト化
                    Dim text = PdfTextExtractor.GetTextFromPage(pdfReader, pageNum)

                    rtn.Append(pageNum & "ページ目" & vbTab)
                    rtn.AppendLine(Mid(text.Replace(vbCr, " ").Replace(vbLf, " "), 1, 800))
                End If
            Next

        End Using

        Return rtn.ToString()
    End Function

    ''' <summary>
    ''' ZBarを呼び出してISBNを取得
    ''' </summary>
    ''' <param name="pFile"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ExecZBar(pFile As String) As String
        Dim command As String = txtZbar.Text

        Dim psInfo As New ProcessStartInfo()

        psInfo.FileName = command ' 実行するファイル
        psInfo.CreateNoWindow = True ' コンソール・ウィンドウを開かない
        psInfo.UseShellExecute = False ' シェル機能を使用しない

        psInfo.RedirectStandardOutput = True ' 標準出力をリダイレクト
        psInfo.Arguments = """" & pFile & """"


        Dim p As Process = Process.Start(psInfo) ' アプリの実行開始
        Dim output As String = p.StandardOutput.ReadToEnd() ' 標準出力の読み取り

        output = output.Replace(vbCr + vbCrLf, vbLf) ' 改行コードの修正
        Debug.Write(output) ' ［出力］ウィンドウに出力
        Return output
    End Function

    ''' <summary>
    ''' バッチファイルを書き込む
    ''' </summary>
    ''' <param name="batchPath"></param>
    ''' <param name="batchText"></param>
    ''' <param name="doBatch"></param>
    ''' <remarks></remarks>
    Private Sub WriteBatch(ByVal batchPath As String, batchText As String, ByVal doBatch As Boolean)
        Try
            'バッチファイル作成
            Using sw As New StreamWriter(batchPath, False, System.Text.Encoding.GetEncoding("shift_jis"))
                sw.WriteLine(batchText)
                sw.WriteLine("pause")
            End Using

            If doBatch Then
                Process.Start(batchPath)
            End If
        Catch ex As Exception
            MessageBox.Show("バッチファイルの作成に失敗しました" & vbCrLf & batchPath & vbCrLf & ex.Message & vbCrLf & ex.StackTrace)
        End Try
    End Sub

    ''' <summary>
    ''' CSVを読み込んでDataTableを返却
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function ReadCsv() As DataTable
        Dim dt As DataTable = Nothing

        'CSV読込
        Using swText As New FileIO.TextFieldParser(Me.txtImportCsv.Text, System.Text.Encoding.UTF8)
            swText.TextFieldType = FileIO.FieldType.Delimited
            swText.Delimiters = New String() {","}
            swText.HasFieldsEnclosedInQuotes = True
            swText.TrimWhiteSpace = True
            While Not swText.EndOfData
                'CSVファイルのフィールドを読み込みます。
                Dim fields As String() = swText.ReadFields()
                If dt Is Nothing Then
                    dt = New DataTable
                    For Each colName As String In fields
                        Dim col As New DataColumn()
                        col.Caption = colName
                        If String.IsNullOrWhiteSpace(colName) OrElse _
                           dt.Columns.Contains(colName) Then
                            col.ColumnName = (dt.Columns.Count + 1).ToString("00") & colName
                        Else
                            col.ColumnName = colName
                        End If
                        dt.Columns.Add(col)
                    Next
                Else
                    dt.Rows.Add(fields)
                End If
            End While
        End Using

        Return dt
    End Function

    ''' <summary>
    ''' DataTableをCSVに書き込む
    ''' </summary>
    ''' <param name="dt"></param>
    ''' <remarks></remarks>
    Private Sub WriteCsv(ByVal dt As DataTable)

        'CSVを保存
        Using sw As New System.IO.StreamWriter(Me.txtExportCsv.Text, False, System.Text.Encoding.UTF8)
            'ヘッダ行
            For Each col As DataColumn In dt.Columns
                If dt.Columns.IndexOf(col) <> 0 Then
                    sw.Write(",")
                End If
                sw.Write("""" & col.ColumnName & """")
            Next
            sw.WriteLine()

            '明細
            For Each row As DataRow In dt.Rows
                For Each col As DataColumn In dt.Columns
                    If dt.Columns.IndexOf(col) <> 0 Then
                        sw.Write(",")
                    End If
                    sw.Write("""" & row(col).ToString() & """")
                Next
                sw.WriteLine()
            Next
        End Using
    End Sub

    ''' <summary>
    ''' 文字列からコマンドプロンプトのコメントに変換
    ''' </summary>
    ''' <remarks></remarks>
    Public Function StringToCommandComment(ByVal source As String) As String
        Dim rtn As New System.Text.StringBuilder
        Dim maxLength As Integer = 1000
        For Each strLine As String In source.Split(vbLf)
            For i As Integer = 0 To strLine.Length - 1 Step maxLength
                rtn.Append("rem ")
                Dim wk As String = strLine.Trim.Replace(vbCr, "").Replace(vbLf, "")
                wk = wk.Substring(i, Math.Min(wk.Length - i, maxLength))
                rtn.AppendLine(wk)

            Next
        Next
        Return rtn.ToString()
    End Function

    ''' <summary>
    ''' ファイル名をフォーマット
    ''' </summary>
    ''' <param name="originalFileName"></param>
    ''' <param name="row"></param>
    ''' <param name="repLines"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function FormatFileName(ByVal originalFileName As String, _
                                ByVal row As DataRow, _
                                ByVal repLines As String) As String
        Dim editFileName As New System.Text.StringBuilder()
        editFileName.Append(originalFileName)
        With editFileName
            For Each col As DataColumn In row.Table.Columns
                .Replace("[" & col.ColumnName & "]", row(col))
            Next
            For Each strRep As String In repLines.Split(vbCrLf)
                Dim aryRep As String() = strRep.Split(vbTab)
                If aryRep.Length = 2 Then
                    .Replace(aryRep(0).Trim(), aryRep(1).Trim())
                End If
            Next
        End With
        Return editFileName.ToString()
    End Function

#End Region

End Class
