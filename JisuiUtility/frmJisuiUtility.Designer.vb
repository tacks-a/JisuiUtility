<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJisuiUtility
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCreateRenameIsbnBatch = New System.Windows.Forms.Button()
        Me.txtIsbnCmd = New System.Windows.Forms.TextBox()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbc = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.chkDoRenameIsbnBatach = New System.Windows.Forms.CheckBox()
        Me.txtRenameIsbnBatchPath = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtIsbnRegex = New System.Windows.Forms.TextBox()
        Me.lblIsbnRegex = New System.Windows.Forms.Label()
        Me.picBarcode = New System.Windows.Forms.PictureBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.txtIsbn = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtZbar = New System.Windows.Forms.TextBox()
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.chkDoRenameBookBatach = New System.Windows.Forms.CheckBox()
        Me.txtRenameBookBatchPath = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnCreateRenameBookBatch = New System.Windows.Forms.Button()
        Me.txtCsvItems = New System.Windows.Forms.TextBox()
        Me.btnCsvItems = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRenameBookCmd = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFileNameOriginal = New System.Windows.Forms.TextBox()
        Me.txtFileNameReplaceEtc = New System.Windows.Forms.TextBox()
        Me.txtFileNameReplace = New System.Windows.Forms.TextBox()
        Me.txtExportCsv = New System.Windows.Forms.TextBox()
        Me.txtImportCsv = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtPdfDir = New System.Windows.Forms.TextBox()
        Me.tbc.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.picBarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCreateRenameIsbnBatch
        '
        Me.btnCreateRenameIsbnBatch.Location = New System.Drawing.Point(453, 94)
        Me.btnCreateRenameIsbnBatch.Name = "btnCreateRenameIsbnBatch"
        Me.btnCreateRenameIsbnBatch.Size = New System.Drawing.Size(111, 23)
        Me.btnCreateRenameIsbnBatch.TabIndex = 5
        Me.btnCreateRenameIsbnBatch.Text = "バッチファイル作成"
        Me.btnCreateRenameIsbnBatch.UseVisualStyleBackColor = True
        '
        'txtIsbnCmd
        '
        Me.txtIsbnCmd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtIsbnCmd.Location = New System.Drawing.Point(0, 0)
        Me.txtIsbnCmd.Multiline = True
        Me.txtIsbnCmd.Name = "txtIsbnCmd"
        Me.txtIsbnCmd.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtIsbnCmd.Size = New System.Drawing.Size(603, 360)
        Me.txtIsbnCmd.TabIndex = 0
        Me.txtIsbnCmd.WordWrap = False
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Location = New System.Drawing.Point(11, 76)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(29, 12)
        Me.lblCount.TabIndex = 3
        Me.lblCount.Text = "件数"
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(60, 76)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(75, 12)
        Me.lblInfo.TabIndex = 5
        Me.lblInfo.Text = "処理中ファイル"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 12)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "PDFフォルダ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 12)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "ZBarのパス"
        '
        'tbc
        '
        Me.tbc.Controls.Add(Me.TabPage1)
        Me.tbc.Controls.Add(Me.TabPage2)
        Me.tbc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbc.Location = New System.Drawing.Point(3, 43)
        Me.tbc.Name = "tbc"
        Me.tbc.SelectedIndex = 0
        Me.tbc.Size = New System.Drawing.Size(778, 515)
        Me.tbc.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.chkDoRenameIsbnBatach)
        Me.TabPage1.Controls.Add(Me.txtRenameIsbnBatchPath)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.txtIsbnRegex)
        Me.TabPage1.Controls.Add(Me.lblIsbnRegex)
        Me.TabPage1.Controls.Add(Me.picBarcode)
        Me.TabPage1.Controls.Add(Me.SplitContainer1)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.btnCreateRenameIsbnBatch)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtZbar)
        Me.TabPage1.Controls.Add(Me.lblCount)
        Me.TabPage1.Controls.Add(Me.txtFilter)
        Me.TabPage1.Controls.Add(Me.lblInfo)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(770, 489)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "PDFのバーコードからISBNにリネーム"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'chkDoRenameIsbnBatach
        '
        Me.chkDoRenameIsbnBatach.AutoSize = True
        Me.chkDoRenameIsbnBatach.Checked = Global.JisuiUtility.My.MySettings.Default.chkDoRenameIsbnBatch
        Me.chkDoRenameIsbnBatach.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDoRenameIsbnBatach.Location = New System.Drawing.Point(570, 100)
        Me.chkDoRenameIsbnBatach.Name = "chkDoRenameIsbnBatach"
        Me.chkDoRenameIsbnBatach.Size = New System.Drawing.Size(67, 16)
        Me.chkDoRenameIsbnBatach.TabIndex = 4
        Me.chkDoRenameIsbnBatach.Text = "実行する"
        Me.chkDoRenameIsbnBatach.UseVisualStyleBackColor = True
        '
        'txtRenameIsbnBatchPath
        '
        Me.txtRenameIsbnBatchPath.Location = New System.Drawing.Point(125, 96)
        Me.txtRenameIsbnBatchPath.Name = "txtRenameIsbnBatchPath"
        Me.txtRenameIsbnBatchPath.Size = New System.Drawing.Size(322, 19)
        Me.txtRenameIsbnBatchPath.TabIndex = 3
        Me.txtRenameIsbnBatchPath.Text = Global.JisuiUtility.My.MySettings.Default.RenameIsbnBatchPath
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 99)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 12)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "作成するバッチファイル"
        '
        'txtIsbnRegex
        '
        Me.txtIsbnRegex.Location = New System.Drawing.Point(203, 30)
        Me.txtIsbnRegex.Name = "txtIsbnRegex"
        Me.txtIsbnRegex.Size = New System.Drawing.Size(244, 19)
        Me.txtIsbnRegex.TabIndex = 1
        Me.txtIsbnRegex.Text = Global.JisuiUtility.My.MySettings.Default.IsbnRegex
        '
        'lblIsbnRegex
        '
        Me.lblIsbnRegex.AutoSize = True
        Me.lblIsbnRegex.Location = New System.Drawing.Point(11, 33)
        Me.lblIsbnRegex.Name = "lblIsbnRegex"
        Me.lblIsbnRegex.Size = New System.Drawing.Size(111, 12)
        Me.lblIsbnRegex.TabIndex = 13
        Me.lblIsbnRegex.Text = "ISBN判定(正規表現)"
        '
        'picBarcode
        '
        Me.picBarcode.Location = New System.Drawing.Point(638, 10)
        Me.picBarcode.Name = "picBarcode"
        Me.picBarcode.Size = New System.Drawing.Size(120, 101)
        Me.picBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBarcode.TabIndex = 12
        Me.picBarcode.TabStop = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(11, 123)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtIsbn)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtIsbnCmd)
        Me.SplitContainer1.Size = New System.Drawing.Size(747, 360)
        Me.SplitContainer1.SplitterDistance = 140
        Me.SplitContainer1.TabIndex = 10
        '
        'txtIsbn
        '
        Me.txtIsbn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtIsbn.Location = New System.Drawing.Point(0, 0)
        Me.txtIsbn.Multiline = True
        Me.txtIsbn.Name = "txtIsbn"
        Me.txtIsbn.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtIsbn.Size = New System.Drawing.Size(140, 360)
        Me.txtIsbn.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(186, 12)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "ISBN取得対象ファイル(ワイルドカード)"
        '
        'txtZbar
        '
        Me.txtZbar.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.JisuiUtility.My.MySettings.Default, "ZBarPath", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtZbar.Location = New System.Drawing.Point(76, 10)
        Me.txtZbar.Name = "txtZbar"
        Me.txtZbar.Size = New System.Drawing.Size(371, 19)
        Me.txtZbar.TabIndex = 0
        Me.txtZbar.Text = Global.JisuiUtility.My.MySettings.Default.ZBarPath
        '
        'txtFilter
        '
        Me.txtFilter.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.JisuiUtility.My.MySettings.Default, "PdfFilter", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtFilter.Location = New System.Drawing.Point(203, 50)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(244, 19)
        Me.txtFilter.TabIndex = 2
        Me.txtFilter.Text = Global.JisuiUtility.My.MySettings.Default.PdfFilter
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.chkDoRenameBookBatach)
        Me.TabPage2.Controls.Add(Me.txtRenameBookBatchPath)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.btnCreateRenameBookBatch)
        Me.TabPage2.Controls.Add(Me.txtCsvItems)
        Me.TabPage2.Controls.Add(Me.btnCsvItems)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.txtRenameBookCmd)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.txtFileNameOriginal)
        Me.TabPage2.Controls.Add(Me.txtFileNameReplaceEtc)
        Me.TabPage2.Controls.Add(Me.txtFileNameReplace)
        Me.TabPage2.Controls.Add(Me.txtExportCsv)
        Me.TabPage2.Controls.Add(Me.txtImportCsv)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(770, 489)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "私本管理のバックアップから書籍名にリネーム"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'chkDoRenameBookBatach
        '
        Me.chkDoRenameBookBatach.AutoSize = True
        Me.chkDoRenameBookBatach.Checked = Global.JisuiUtility.My.MySettings.Default.DoRenameBookBatach
        Me.chkDoRenameBookBatach.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDoRenameBookBatach.Location = New System.Drawing.Point(571, 165)
        Me.chkDoRenameBookBatach.Name = "chkDoRenameBookBatach"
        Me.chkDoRenameBookBatach.Size = New System.Drawing.Size(67, 16)
        Me.chkDoRenameBookBatach.TabIndex = 6
        Me.chkDoRenameBookBatach.Text = "実行する"
        Me.chkDoRenameBookBatach.UseVisualStyleBackColor = True
        '
        'txtRenameBookBatchPath
        '
        Me.txtRenameBookBatchPath.Location = New System.Drawing.Point(126, 161)
        Me.txtRenameBookBatchPath.Name = "txtRenameBookBatchPath"
        Me.txtRenameBookBatchPath.Size = New System.Drawing.Size(322, 19)
        Me.txtRenameBookBatchPath.TabIndex = 5
        Me.txtRenameBookBatchPath.Text = Global.JisuiUtility.My.MySettings.Default.RenameBookBatchPath
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 164)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 12)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "作成するバッチファイル"
        '
        'btnCreateRenameBookBatch
        '
        Me.btnCreateRenameBookBatch.Location = New System.Drawing.Point(454, 159)
        Me.btnCreateRenameBookBatch.Name = "btnCreateRenameBookBatch"
        Me.btnCreateRenameBookBatch.Size = New System.Drawing.Size(111, 23)
        Me.btnCreateRenameBookBatch.TabIndex = 23
        Me.btnCreateRenameBookBatch.Text = "バッチファイル作成"
        Me.btnCreateRenameBookBatch.UseVisualStyleBackColor = True
        '
        'txtCsvItems
        '
        Me.txtCsvItems.Location = New System.Drawing.Point(544, 35)
        Me.txtCsvItems.Multiline = True
        Me.txtCsvItems.Name = "txtCsvItems"
        Me.txtCsvItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCsvItems.Size = New System.Drawing.Size(223, 118)
        Me.txtCsvItems.TabIndex = 8
        Me.txtCsvItems.WordWrap = False
        '
        'btnCsvItems
        '
        Me.btnCsvItems.Location = New System.Drawing.Point(544, 8)
        Me.btnCsvItems.Name = "btnCsvItems"
        Me.btnCsvItems.Size = New System.Drawing.Size(223, 23)
        Me.btnCsvItems.TabIndex = 7
        Me.btnCsvItems.Text = "CSV項目取得"
        Me.btnCsvItems.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 12)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "置換元ファイル名"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 12)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "置換文字(タブ区切り)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 12)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "置換先ファイル名"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(217, 12)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "出力CSVファイル(保管場所を設定して出力)"
        '
        'txtRenameBookCmd
        '
        Me.txtRenameBookCmd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRenameBookCmd.Location = New System.Drawing.Point(3, 188)
        Me.txtRenameBookCmd.Multiline = True
        Me.txtRenameBookCmd.Name = "txtRenameBookCmd"
        Me.txtRenameBookCmd.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtRenameBookCmd.Size = New System.Drawing.Size(764, 298)
        Me.txtRenameBookCmd.TabIndex = 9
        Me.txtRenameBookCmd.WordWrap = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(210, 12)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "入力CSVファイル(utf8でバックアップしたcsv)"
        '
        'txtFileNameOriginal
        '
        Me.txtFileNameOriginal.Location = New System.Drawing.Point(126, 59)
        Me.txtFileNameOriginal.Name = "txtFileNameOriginal"
        Me.txtFileNameOriginal.Size = New System.Drawing.Size(403, 19)
        Me.txtFileNameOriginal.TabIndex = 2
        Me.txtFileNameOriginal.Text = Global.JisuiUtility.My.MySettings.Default.FileNameOriginal
        '
        'txtFileNameReplaceEtc
        '
        Me.txtFileNameReplaceEtc.Location = New System.Drawing.Point(126, 108)
        Me.txtFileNameReplaceEtc.Multiline = True
        Me.txtFileNameReplaceEtc.Name = "txtFileNameReplaceEtc"
        Me.txtFileNameReplaceEtc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtFileNameReplaceEtc.Size = New System.Drawing.Size(124, 47)
        Me.txtFileNameReplaceEtc.TabIndex = 4
        Me.txtFileNameReplaceEtc.Text = Global.JisuiUtility.My.MySettings.Default.FileNameReplaceEtc
        Me.txtFileNameReplaceEtc.WordWrap = False
        '
        'txtFileNameReplace
        '
        Me.txtFileNameReplace.Location = New System.Drawing.Point(126, 84)
        Me.txtFileNameReplace.Name = "txtFileNameReplace"
        Me.txtFileNameReplace.Size = New System.Drawing.Size(403, 19)
        Me.txtFileNameReplace.TabIndex = 3
        Me.txtFileNameReplace.Text = Global.JisuiUtility.My.MySettings.Default.FileNameReplace
        '
        'txtExportCsv
        '
        Me.txtExportCsv.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.JisuiUtility.My.MySettings.Default, "ExportCsvPath", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtExportCsv.Location = New System.Drawing.Point(227, 35)
        Me.txtExportCsv.Name = "txtExportCsv"
        Me.txtExportCsv.Size = New System.Drawing.Size(302, 19)
        Me.txtExportCsv.TabIndex = 1
        Me.txtExportCsv.Text = Global.JisuiUtility.My.MySettings.Default.ExportCsvPath
        '
        'txtImportCsv
        '
        Me.txtImportCsv.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.JisuiUtility.My.MySettings.Default, "ImportCsvPath", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtImportCsv.Location = New System.Drawing.Point(227, 10)
        Me.txtImportCsv.Name = "txtImportCsv"
        Me.txtImportCsv.Size = New System.Drawing.Size(302, 19)
        Me.txtImportCsv.TabIndex = 0
        Me.txtImportCsv.Text = Global.JisuiUtility.My.MySettings.Default.ImportCsvPath
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.tbc, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(784, 561)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtPdfDir)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(778, 34)
        Me.Panel1.TabIndex = 0
        '
        'txtPdfDir
        '
        Me.txtPdfDir.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.JisuiUtility.My.MySettings.Default, "PdfDir", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtPdfDir.Location = New System.Drawing.Point(78, 9)
        Me.txtPdfDir.Name = "txtPdfDir"
        Me.txtPdfDir.Size = New System.Drawing.Size(684, 19)
        Me.txtPdfDir.TabIndex = 0
        Me.txtPdfDir.Text = Global.JisuiUtility.My.MySettings.Default.PdfDir
        '
        'frmJisuiUtility
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "frmJisuiUtility"
        Me.Text = "自炊ユーティリティ"
        Me.tbc.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.picBarcode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCreateRenameIsbnBatch As System.Windows.Forms.Button
    Friend WithEvents txtIsbnCmd As System.Windows.Forms.TextBox
    Friend WithEvents txtPdfDir As System.Windows.Forms.TextBox
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents txtFilter As System.Windows.Forms.TextBox
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtZbar As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbc As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtImportCsv As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRenameBookCmd As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents txtIsbn As System.Windows.Forms.TextBox
    Friend WithEvents picBarcode As System.Windows.Forms.PictureBox
    Friend WithEvents txtIsbnRegex As System.Windows.Forms.TextBox
    Friend WithEvents lblIsbnRegex As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtExportCsv As System.Windows.Forms.TextBox
    Friend WithEvents txtFileNameReplace As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtFileNameReplaceEtc As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtFileNameOriginal As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCsvItems As System.Windows.Forms.TextBox
    Friend WithEvents btnCsvItems As System.Windows.Forms.Button
    Friend WithEvents txtRenameIsbnBatchPath As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents chkDoRenameIsbnBatach As System.Windows.Forms.CheckBox
    Friend WithEvents chkDoRenameBookBatach As System.Windows.Forms.CheckBox
    Friend WithEvents txtRenameBookBatchPath As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnCreateRenameBookBatch As System.Windows.Forms.Button

End Class
