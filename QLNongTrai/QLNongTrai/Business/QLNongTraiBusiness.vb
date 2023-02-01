' RubyFunc.vb  Copyright SOTRA LIMITED 2021
' Ten he thong: Quan ly Nong trai
' Tong quan:

' Lich su chinh sua
'      0    2021.09.30 V202109300      Sotra)NgocSon          Tao moi

Imports Com.Sotra.Common
Imports Microsoft.Office.Interop
Imports System.IO

Public Class QLNongTraiBusiness
    Private Const CONNECTION_STR_QL_NONG_TRAI As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Sotra\Wins\DB\QLNongTrai.mdf;Integrated Security=True;Connect Timeout=30;MultipleActiveResultSets=True"

    Private dam As RubyDataManager
    Private xDs As New DataSet
    Private xParams(0) As String
    Private xMsgParams(0) As String

    Private xRuFunc As New RubyFunc

#Region "New"
    Public Sub New(Optional ByVal connectStr As String = "")
        ' Khoi tao
        If Not String.IsNullOrEmpty(connectStr) Then
            dam = New RubyDataManager(connectStr)
        Else
            dam = New RubyDataManager(CONNECTION_STR_QL_NONG_TRAI)
        End If
    End Sub
#End Region

#Region "Execute_OnLoad"
    ''' <summary>
    ''' Lay du lieu lan dau formOnload
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub executeOnLoad(ByRef formData As Hashtable)

        ReDim xParams(4)
        xParams(0) = String.Empty
        xParams(1) = String.Empty
        xParams(2) = String.Empty
        xParams(3) = "NULL"
        xParams(4) = String.Empty

        dam.executeData(xDs, "TT_CAY_TRONG", "TT_CAY_TRONG_01", xParams)

        formData.Item("xDs") = xDs
    End Sub
#End Region

#Region "Execute_Grid_OnCellClick"
    ''' <summary>
    ''' Xu ly du lieu Grid_OnCellClick
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub executeGridOnCellClick(ByRef formData As Hashtable)


    End Sub
#End Region

#Region "Execute_btnBaoCao_OnClick"
    ''' <summary>
    ''' Xu ly du lieu btnBaoCao_OnClick
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub executebtnBaoCaoOnClick(ByRef formData As Hashtable)
        ' 日時とっとく
        Dim nowYMDHMS As String = Now().ToString().Replace("/", "_").Replace(" ", "_")
        ' 第一引数にExcelファイル名をフルパスでもらう予定
        Dim oldDir As String = "D:\Sotra\Wins\EXCEL\Temp\"
        Dim newDir As String = "D:\Sotra\Wins\EXCEL\Wrk\"
        Dim xlsxFileName As String = "Temp_001.xlsx"
        Dim pdfFileName As String = xlsxFileName.Substring(0, xlsxFileName.LastIndexOf(".")) & ".pdf"
        Dim zipFileName As String = xlsxFileName.Substring(0, xlsxFileName.LastIndexOf(".")) & ".zip"
        ' 新しい出力先を作っておく
        System.IO.Directory.CreateDirectory(newDir)

        Dim xlWorkBooks As Excel.Workbook = Nothing
        Dim xlWorkSheet As Excel.Worksheet = Nothing
        Dim xlApp As New Excel.Application
        Try
            ' xlWorkBook = xlApp.Workbooks.Add(temptPathCopy)
            xlWorkBooks = xlApp.Workbooks.Open(oldDir & xlsxFileName)
            xlWorkSheet = xlWorkBooks.Sheets(1)

            xlApp.ScreenUpdating = False
            xlApp.EnableEvents = False
            xlApp.DisplayAlerts = False

            With xlWorkBooks.Sheets(1)
                .Cells(1, 1) = "abc"
                .Range("G8").value = "ahihi"

                '.Range("1:1").Insert()
                '.Cells(1, 1) = nowYMDHMS
                '.Cells(1, 2) = "abc"
                '.Columns("A:B").AutoFit()
            End With

            'xlApp.Visible = True
            'xlWorkBooks.PrintPreview()

            'xlsxBook.Save()
            xlWorkBooks.SaveAs(newDir & xlsxFileName)

            ' PDF
            xlWorkBooks.ExportAsFixedFormat(Type:=Excel.XlFixedFormatType.xlTypePDF, Filename:=newDir & pdfFileName)

            xlApp.ScreenUpdating = True
            xlApp.EnableEvents = True
            xlApp.DisplayAlerts = True

            ' ZIP
            'Compression.GZipStream.CreateFromDirectory(newDir, oldDir & zipFileName)

            xlWorkBooks.Close()
            xlApp.Quit()
            releaseObject(xlApp)
            releaseObject(xlWorkBooks)
            releaseObject(xlWorkSheet)

            If File.Exists(newDir & pdfFileName) Then
                Process.Start(newDir & pdfFileName)
            End If
        Catch ex As Exception
            Logger.errorLog(ex.Message)
        Finally
            'If Not xlWorkBooks Is Nothing Then
            '    xlWorkBooks.Close()
            'End If
        End Try
    End Sub
#End Region

#Region "Xu ly chung"
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
#End Region

End Class
