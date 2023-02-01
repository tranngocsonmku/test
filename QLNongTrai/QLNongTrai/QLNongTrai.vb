' RubyFunc.vb  Copyright SOTRA LIMITED 2021
' Ten he thong: Quan ly Nong trai
' Tong quan:

' Lich su chinh sua
'      0    2021.09.30 V202109300      Sotra)NgocSon          Tao moi

Imports Com.Sotra.Common

Public Class QLNongTrai
    ' Event KeyCode
    Private Const EV_KEY_ONLOAD As Integer = 0
    Private Const EV_KEY_GRID_ONCLICK As Integer = 1
    Private Const EV_KEY_BTN_BAOCAO_ONCLICK As Integer = 2

    ' Duong dan hinh anh
    Private Const IMG_PATH As String = "D:\Sotra\Wins\IMG\"
    ' Phan mo rong
    Private Const PNG As String = ".png"

    ' formData
    Private formData As New Hashtable

    ' initFlg
    Private initFlg As Boolean = False

    ' Xu ly chung
    Private xRuFunc As New RubyFunc

#Region "Hien thi lan dau"
    Private Sub QLNongTrai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Logger.debug("QLNongTrai_Load START")

        Try
            ' Khoi tao
            init()

            ' Xu ly su kien
            excEvent(EV_KEY_ONLOAD)

            ' OnLoad_SetFromData
            OnLoad_SetFromData()
        Catch ex As Exception
            Logger.errorLog(ex.Message)
        End Try

        Logger.debug("QLNongTrai_Load END")
    End Sub

    Private Sub OnLoad_SetFromData()
        ' Hien thi Ds cay trong
        setLsvChiTiet()

        ' Hien thi chi tiet
        dgvCayTrong_OnCellClick_SetFormData(0)
    End Sub

#Region "Khoi tao"
    Private Sub init()
        ' Tieu de
        Me.Text = "Quản lý Nông trại"

        ' Thiet lap ban dau
        clearData()

        ' Khoi tao formData
        initFormData(formData)

        ' Khoi tao Danh sach cay trong
        setInitLv()

        initFlg = True
    End Sub

    Private Sub clearData()
        mDsCayTrong.Tables(0).Rows.Clear()

    End Sub

    Private Sub initFormData(ByRef formData As Hashtable)
        formData.Add("xDs", Nothing)
    End Sub
#End Region

#Region "LsvChiTiet"
    Private Sub setInitLv()
        'lsvChiTiet.View = View.Details
        'lsvChiTiet.FullRowSelect = True
        'lsvChiTiet.ShowItemToolTips = True

        'lsvChiTiet.Columns.Add(" ", 38, HorizontalAlignment.Left)
        'lsvChiTiet.Columns.Add("Tên Cây trồng", 200, HorizontalAlignment.Left)
    End Sub

    Private Sub setLsvChiTiet()
        'Dim imgList As New ImageList With {.ImageSize = New Size(35, 35)}
        Dim xDs As DataSet = DirectCast(formData.Item("xDs"), DataSet)

        'lsvChiTiet.SmallImageList = imgList
        'lsvChiTiet.Items.Clear()

        mDsCayTrong.Tables(0).Rows.Clear()
        For Each xDr As DataRow In xDs.Tables("TT_CAY_TRONG").Rows
            'imgList.Images.Add(Image.FromFile(IMG_PATH & xDr.Item("ICON").ToString & PNG))
            'Dim xLvi As New ListViewItem("", imgList.Images.Count - 1)

            'xLvi.SubItems.Add(xDr.Item("TEN_CAY").ToString)

            'lsvChiTiet.Items.Add(xLvi)

            Dim xNewRow As DataRow = mDsCayTrong.Tables(0).NewRow
            xNewRow("CAY_ID") = xDr.Item("TEN_CAY")
            xNewRow("TEN_CAY") = xDr.Item("TEN_CAY")
            xNewRow("ICON") = xDr.Item("ICON")
            xNewRow("ICON_PATH") = IMG_PATH & xDr.Item("ICON").ToString & PNG
            xNewRow("QL_ID") = xDr.Item("QL_ID")
            xNewRow("TG_TRONG") = xRuFunc.GetFormatDateStr(xDr.Item("TG_TRONG"), "yyyy/MM/dd")
            xNewRow("DU_KIEN") = xRuFunc.GetFormatDateStr(xDr.Item("TG_THU_HOACH_DU_KIEN"), "yyyy/MM/dd")

            xNewRow("TG_SINH_TRUONG") = xDr.Item("TG_SINH_TRUONG")
            xNewRow("TT_CHAM_SOC") = xDr.Item("TT_CHAM_SOC")
            xNewRow("GHI_CHU_1") = xDr.Item("GHI_CHU_1")
            xNewRow("TG_THU_HOACH") = xDr.Item("TG_THU_HOACH")
            xNewRow("GHI_CHU_2") = xDr.Item("GHI_CHU_2")

            mDsCayTrong.Tables(0).Rows.Add(xNewRow)
        Next
        dgvCayTrong.DataSource = mDsCayTrong.Tables(0)

        ' Hien thi icon len grid
        setImgGrid()

        ' Giai phong
        formData.Item("xDs") = Nothing
    End Sub

    Private Sub setImgGrid()
        ' Danh sach trong
        If mDsCayTrong.Tables(0).Rows.Count = 0 Then
            Exit Sub
        End If

        For i As Integer = 0 To mDsCayTrong.Tables(0).Rows.Count - 1
            dgvCayTrong(0, i).Value = New Bitmap(mDsCayTrong.Tables(0).Rows(i).Item("ICON_PATH").ToString)
        Next
    End Sub
#End Region
#End Region

#Region "Xu ly su kien Business"
    Private Sub excEvent(ByVal key As Integer)
        Dim bus As New QLNongTraiBusiness

        Select Case key
            Case EV_KEY_ONLOAD
                bus.executeOnLoad(formData)
            Case EV_KEY_GRID_ONCLICK
                bus.executeGridOnCellClick(formData)
            Case EV_KEY_BTN_BAOCAO_ONCLICK
                bus.executebtnBaoCaoOnClick(formData)

        End Select

        ' Giai phong
        bus = Nothing
    End Sub
#End Region

#Region "Xu ly su kien Grid_OnCellClick"
    Private Sub dgvCayTrong_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCayTrong.CellClick
        Logger.debug("dgvCayTrong_CellClick START")
        Logger.debug("RowIndex: " & e.RowIndex.ToString)

        If e.RowIndex >= 0 Then
            Try
                ' Kiem tra du lieu
                If dgvCayTrong_OnCellClick_CheckInput() Then
                    ' Xu ly su kien
                    excEvent(EV_KEY_GRID_ONCLICK)

                    ' Xu ly hien thi
                    dgvCayTrong_OnCellClick_SetFormData(e.RowIndex)
                End If
            Catch ex As Exception
                Logger.errorLog(ex.Message)
            End Try
        End If

        Logger.debug("dgvCayTrong_CellClick END")
    End Sub

    Private Function dgvCayTrong_OnCellClick_CheckInput() As Boolean
        ' Du lieu khong ton tai
        If mDsCayTrong Is Nothing OrElse mDsCayTrong.Tables.Count = 0 OrElse mDsCayTrong.Tables(0).Rows.Count = 0 Then
            Return False
        End If

        Return True
    End Function

    Private Sub dgvCayTrong_OnCellClick_SetFormData(ByVal xIndex As Integer)
        ' Hang duoc chon
        Dim xDr As DataRow

        ' Ngay trong
        Dim xNgayTrongYMD As New Date
        Dim xSoNgayTrong As Long = 0

        ' Khoi tao
        ' Icon
        picIcon.ImageLocation = String.Empty
        ' Ten cay
        lblTenCay.Text = String.Empty
        ' Ma quan ly
        lblMaQL.Text = String.Empty
        ' Ngay trong
        lblNgayTrong.Text = String.Empty
        ' Ngay thu hoach du kien
        lblNgayThu.Text = String.Empty

        ' Thoi gian sinh truong
        pgbThoiGian.Maximum = 100
        pgbThoiGian.Minimum = 0
        pgbThoiGian.Value = 0

        lblTgTrong.Text = String.Empty
        lblConLai.Text = String.Empty

        ' Vi tri khong hop le
        If mDsCayTrong.Tables(0).Rows.Count = 0 OrElse xIndex < 0 OrElse xIndex >= mDsCayTrong.Tables(0).Rows.Count Then
            Exit Sub
        End If

        ' Hang duoc chon
        xDr = mDsCayTrong.Tables(0).Rows(xIndex)

        ' Ngay trong
        xNgayTrongYMD = CType(xDr.Item("TG_TRONG"), Date)
        xSoNgayTrong = DateDiff("d", xNgayTrongYMD, Now)

        ' Hien thi
        ' Icon
        If Not String.IsNullOrEmpty(xDr.Item("ICON").ToString) Then
            picIcon.ImageLocation = IMG_PATH & xDr.Item("ICON").ToString & "_100" & PNG
        End If
        ' Ten cay
        lblTenCay.Text = xDr.Item("TEN_CAY").ToString
        ' Ma quan ly
        lblMaQL.Text = "Mã: " & xDr.Item("QL_ID").ToString
        ' Ngay trong
        lblNgayTrong.Text = xDr.Item("TG_TRONG").ToString
        ' Ngay thu hoach du kien
        lblNgayThu.Text = xDr.Item("DU_KIEN").ToString

        ' Thoi gian sinh truong
        pgbThoiGian.Maximum = CType(xRuFunc.nvlZero(xDr("TG_SINH_TRUONG")), Integer)
        pgbThoiGian.Minimum = 0
        pgbThoiGian.Value = CType(xSoNgayTrong, Integer)

        lblTgTrong.Text = pgbThoiGian.Value.ToString & "/" & pgbThoiGian.Maximum.ToString
        If pgbThoiGian.Maximum - pgbThoiGian.Value > 0 Then
            lblConLai.Text = "Còn " & (pgbThoiGian.Maximum - pgbThoiGian.Value).ToString & " ngày"
        Else
            lblConLai.Text = "Đã có thể thu hoạch"
        End If

    End Sub
#End Region

#Region "Xuat bao cao"
    Private Sub btnBaoCao_Click(sender As Object, e As EventArgs) Handles btnBaoCao.Click
        Logger.debug("btnBaoCao_Click START")

        Try
            ' Kiem tra du lieu
            If btnBaoCao_OnClick_CheckInput() Then
                ' Xu ly su kien
                excEvent(EV_KEY_BTN_BAOCAO_ONCLICK)

                ' Xu ly hien thi
                btnBaoCao_OnClick_SetFormData()
            End If
        Catch ex As Exception
            Logger.errorLog(ex.Message)
        End Try

        Logger.debug("btnBaoCao_Click END")
    End Sub

    Private Function btnBaoCao_OnClick_CheckInput() As Boolean


        Return True
    End Function

    Private Sub btnBaoCao_OnClick_SetFormData()

    End Sub
#End Region

End Class
