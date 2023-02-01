<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class QLNongTrai
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QLNongTrai))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvCayTrong = New System.Windows.Forms.DataGridView()
        Me.IMG = New System.Windows.Forms.DataGridViewImageColumn()
        Me.QL_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TEN_CAY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TG_TRONG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DU_KIEN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mDsCayTrong = New System.Data.DataSet()
        Me.DataTable1 = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.DataColumn6 = New System.Data.DataColumn()
        Me.DataColumn7 = New System.Data.DataColumn()
        Me.DataColumn8 = New System.Data.DataColumn()
        Me.DataColumn9 = New System.Data.DataColumn()
        Me.DataColumn10 = New System.Data.DataColumn()
        Me.DataColumn11 = New System.Data.DataColumn()
        Me.DataColumn12 = New System.Data.DataColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTgTrong = New System.Windows.Forms.Label()
        Me.pgbThoiGian = New RubyProgressBar()
        Me.lblConLai = New System.Windows.Forms.Label()
        Me.lblNgayThu = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblNgayTrong = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblMaQL = New System.Windows.Forms.Label()
        Me.lblTenCay = New System.Windows.Forms.Label()
        Me.picIcon = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.btnNhanVien = New System.Windows.Forms.Button()
        Me.btnNCC = New System.Windows.Forms.Button()
        Me.btnKhachHang = New System.Windows.Forms.Button()
        Me.btnQLHangHoa = New System.Windows.Forms.Button()
        Me.btnXuatKho = New System.Windows.Forms.Button()
        Me.btnBaoCao = New System.Windows.Forms.Button()
        Me.btnNhapKho = New System.Windows.Forms.Button()
        Me.mDs = New System.Data.DataSet()
        Me.DataTable2 = New System.Data.DataTable()
        Me.DataColumn13 = New System.Data.DataColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvCayTrong, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mDsCayTrong, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mDs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Controls.Add(Me.dgvCayTrong)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'dgvCayTrong
        '
        Me.dgvCayTrong.AllowUserToAddRows = False
        Me.dgvCayTrong.AllowUserToDeleteRows = False
        resources.ApplyResources(Me.dgvCayTrong, "dgvCayTrong")
        Me.dgvCayTrong.AutoGenerateColumns = False
        Me.dgvCayTrong.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvCayTrong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCayTrong.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCayTrong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCayTrong.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IMG, Me.QL_ID, Me.TEN_CAY, Me.TG_TRONG, Me.DU_KIEN})
        Me.dgvCayTrong.DataSource = Me.mDsCayTrong
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCayTrong.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvCayTrong.EnableHeadersVisualStyles = False
        Me.dgvCayTrong.MultiSelect = False
        Me.dgvCayTrong.Name = "dgvCayTrong"
        Me.dgvCayTrong.ReadOnly = True
        Me.dgvCayTrong.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCayTrong.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvCayTrong.RowHeadersVisible = False
        Me.dgvCayTrong.RowTemplate.Height = 38
        Me.dgvCayTrong.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCayTrong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'IMG
        '
        resources.ApplyResources(Me.IMG, "IMG")
        Me.IMG.Name = "IMG"
        Me.IMG.ReadOnly = True
        Me.IMG.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'QL_ID
        '
        Me.QL_ID.DataPropertyName = "QL_ID"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.QL_ID.DefaultCellStyle = DataGridViewCellStyle2
        resources.ApplyResources(Me.QL_ID, "QL_ID")
        Me.QL_ID.Name = "QL_ID"
        Me.QL_ID.ReadOnly = True
        Me.QL_ID.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.QL_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'TEN_CAY
        '
        Me.TEN_CAY.DataPropertyName = "TEN_CAY"
        resources.ApplyResources(Me.TEN_CAY, "TEN_CAY")
        Me.TEN_CAY.Name = "TEN_CAY"
        Me.TEN_CAY.ReadOnly = True
        Me.TEN_CAY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'TG_TRONG
        '
        Me.TG_TRONG.DataPropertyName = "TG_TRONG"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.TG_TRONG.DefaultCellStyle = DataGridViewCellStyle3
        resources.ApplyResources(Me.TG_TRONG, "TG_TRONG")
        Me.TG_TRONG.Name = "TG_TRONG"
        Me.TG_TRONG.ReadOnly = True
        Me.TG_TRONG.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TG_TRONG.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DU_KIEN
        '
        Me.DU_KIEN.DataPropertyName = "DU_KIEN"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DU_KIEN.DefaultCellStyle = DataGridViewCellStyle4
        resources.ApplyResources(Me.DU_KIEN, "DU_KIEN")
        Me.DU_KIEN.Name = "DU_KIEN"
        Me.DU_KIEN.ReadOnly = True
        Me.DU_KIEN.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DU_KIEN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'mDsCayTrong
        '
        Me.mDsCayTrong.DataSetName = "NewDataSet"
        Me.mDsCayTrong.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.Caption = "CAY_ID"
        Me.DataColumn1.ColumnName = "CAY_ID"
        '
        'DataColumn2
        '
        Me.DataColumn2.Caption = "TEN_CAY"
        Me.DataColumn2.ColumnName = "TEN_CAY"
        '
        'DataColumn3
        '
        Me.DataColumn3.Caption = "ICON_PATH"
        Me.DataColumn3.ColumnName = "ICON_PATH"
        '
        'DataColumn4
        '
        Me.DataColumn4.Caption = "QL_ID"
        Me.DataColumn4.ColumnName = "QL_ID"
        '
        'DataColumn5
        '
        Me.DataColumn5.Caption = "TG_TRONG"
        Me.DataColumn5.ColumnName = "TG_TRONG"
        '
        'DataColumn6
        '
        Me.DataColumn6.Caption = "DU_KIEN"
        Me.DataColumn6.ColumnName = "DU_KIEN"
        '
        'DataColumn7
        '
        Me.DataColumn7.Caption = "ICON"
        Me.DataColumn7.ColumnName = "ICON"
        '
        'DataColumn8
        '
        Me.DataColumn8.Caption = "TT_CHAM_SOC"
        Me.DataColumn8.ColumnName = "TT_CHAM_SOC"
        '
        'DataColumn9
        '
        Me.DataColumn9.Caption = "TG_SINH_TRUONG"
        Me.DataColumn9.ColumnName = "TG_SINH_TRUONG"
        '
        'DataColumn10
        '
        Me.DataColumn10.Caption = "GHI_CHU_1"
        Me.DataColumn10.ColumnName = "GHI_CHU_1"
        '
        'DataColumn11
        '
        Me.DataColumn11.Caption = "GHI_CHU_2"
        Me.DataColumn11.ColumnName = "GHI_CHU_2"
        '
        'DataColumn12
        '
        Me.DataColumn12.Caption = "TG_THU_HOACH"
        Me.DataColumn12.ColumnName = "TG_THU_HOACH"
        '
        'GroupBox2
        '
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Controls.Add(Me.lblTgTrong)
        Me.GroupBox2.Controls.Add(Me.pgbThoiGian)
        Me.GroupBox2.Controls.Add(Me.lblConLai)
        Me.GroupBox2.Controls.Add(Me.lblNgayThu)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.lblNgayTrong)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.lblMaQL)
        Me.GroupBox2.Controls.Add(Me.lblTenCay)
        Me.GroupBox2.Controls.Add(Me.picIcon)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'lblTgTrong
        '
        resources.ApplyResources(Me.lblTgTrong, "lblTgTrong")
        Me.lblTgTrong.Name = "lblTgTrong"
        '
        'pgbThoiGian
        '
        Me.pgbThoiGian.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pgbThoiGian.ForeColor = System.Drawing.Color.ForestGreen
        resources.ApplyResources(Me.pgbThoiGian, "pgbThoiGian")
        Me.pgbThoiGian.Name = "pgbThoiGian"
        '
        'lblConLai
        '
        resources.ApplyResources(Me.lblConLai, "lblConLai")
        Me.lblConLai.Name = "lblConLai"
        '
        'lblNgayThu
        '
        resources.ApplyResources(Me.lblNgayThu, "lblNgayThu")
        Me.lblNgayThu.Name = "lblNgayThu"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'lblNgayTrong
        '
        resources.ApplyResources(Me.lblNgayTrong, "lblNgayTrong")
        Me.lblNgayTrong.Name = "lblNgayTrong"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'lblMaQL
        '
        resources.ApplyResources(Me.lblMaQL, "lblMaQL")
        Me.lblMaQL.Name = "lblMaQL"
        '
        'lblTenCay
        '
        resources.ApplyResources(Me.lblTenCay, "lblTenCay")
        Me.lblTenCay.Name = "lblTenCay"
        '
        'picIcon
        '
        Me.picIcon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        resources.ApplyResources(Me.picIcon, "picIcon")
        Me.picIcon.Name = "picIcon"
        Me.picIcon.TabStop = False
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Name = "Label1"
        '
        'picLogo
        '
        Me.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.picLogo, "picLogo")
        Me.picLogo.Name = "picLogo"
        Me.picLogo.TabStop = False
        '
        'btnNhanVien
        '
        resources.ApplyResources(Me.btnNhanVien, "btnNhanVien")
        Me.btnNhanVien.Name = "btnNhanVien"
        Me.btnNhanVien.UseVisualStyleBackColor = True
        '
        'btnNCC
        '
        resources.ApplyResources(Me.btnNCC, "btnNCC")
        Me.btnNCC.Name = "btnNCC"
        Me.btnNCC.UseVisualStyleBackColor = True
        '
        'btnKhachHang
        '
        resources.ApplyResources(Me.btnKhachHang, "btnKhachHang")
        Me.btnKhachHang.Name = "btnKhachHang"
        Me.btnKhachHang.UseVisualStyleBackColor = True
        '
        'btnQLHangHoa
        '
        resources.ApplyResources(Me.btnQLHangHoa, "btnQLHangHoa")
        Me.btnQLHangHoa.Name = "btnQLHangHoa"
        Me.btnQLHangHoa.UseVisualStyleBackColor = True
        '
        'btnXuatKho
        '
        resources.ApplyResources(Me.btnXuatKho, "btnXuatKho")
        Me.btnXuatKho.Name = "btnXuatKho"
        Me.btnXuatKho.UseVisualStyleBackColor = True
        '
        'btnBaoCao
        '
        resources.ApplyResources(Me.btnBaoCao, "btnBaoCao")
        Me.btnBaoCao.Name = "btnBaoCao"
        Me.btnBaoCao.UseVisualStyleBackColor = True
        '
        'btnNhapKho
        '
        resources.ApplyResources(Me.btnNhapKho, "btnNhapKho")
        Me.btnNhapKho.Name = "btnNhapKho"
        Me.btnNhapKho.UseVisualStyleBackColor = True
        '
        'mDs
        '
        Me.mDs.DataSetName = "NewDataSet"
        Me.mDs.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn13})
        Me.DataTable2.TableName = "Table1"
        '
        'DataColumn13
        '
        Me.DataColumn13.Caption = "CAY_ID"
        Me.DataColumn13.ColumnName = "CAY_ID"
        '
        'QLNongTrai
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.btnNhanVien)
        Me.Controls.Add(Me.btnNCC)
        Me.Controls.Add(Me.btnKhachHang)
        Me.Controls.Add(Me.btnQLHangHoa)
        Me.Controls.Add(Me.btnXuatKho)
        Me.Controls.Add(Me.btnBaoCao)
        Me.Controls.Add(Me.btnNhapKho)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "QLNongTrai"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvCayTrong, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mDsCayTrong, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mDs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents btnNhanVien As Button
    Friend WithEvents btnNCC As Button
    Friend WithEvents btnKhachHang As Button
    Friend WithEvents btnQLHangHoa As Button
    Friend WithEvents btnXuatKho As Button
    Friend WithEvents btnBaoCao As Button
    Friend WithEvents btnNhapKho As Button
    Friend WithEvents dgvCayTrong As DataGridView
    Friend WithEvents mDsCayTrong As DataSet
    Friend WithEvents DataTable1 As DataTable
    Friend WithEvents DataColumn1 As DataColumn
    Friend WithEvents DataColumn2 As DataColumn
    Friend WithEvents DataColumn3 As DataColumn
    Friend WithEvents DataColumn4 As DataColumn
    Friend WithEvents DataColumn5 As DataColumn
    Friend WithEvents DataColumn6 As DataColumn
    Friend WithEvents DataColumn7 As DataColumn
    Friend WithEvents DataColumn8 As DataColumn
    Friend WithEvents DataColumn9 As DataColumn
    Friend WithEvents DataColumn10 As DataColumn
    Friend WithEvents DataColumn11 As DataColumn
    Friend WithEvents DataColumn12 As DataColumn
    Friend WithEvents IMG As DataGridViewImageColumn
    Friend WithEvents QL_ID As DataGridViewTextBoxColumn
    Friend WithEvents TEN_CAY As DataGridViewTextBoxColumn
    Friend WithEvents TG_TRONG As DataGridViewTextBoxColumn
    Friend WithEvents DU_KIEN As DataGridViewTextBoxColumn
    Friend WithEvents picIcon As PictureBox
    Friend WithEvents lblTenCay As Label
    Friend WithEvents lblMaQL As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblNgayThu As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblNgayTrong As Label
    Friend WithEvents lblConLai As Label
    Friend WithEvents mDs As DataSet
    Friend WithEvents DataTable2 As DataTable
    Friend WithEvents DataColumn13 As DataColumn
    Friend WithEvents pgbThoiGian As RubyProgressBar
    Friend WithEvents lblTgTrong As Label
End Class
