﻿Imports System.Globalization
Imports System.Threading
Imports Microsoft.Office.Interop

Public Class frmReportStockCount

    Public dt As New List(Of V_PhyCount)

    Private Sub frmReportStockCount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
        Dim Wh = (From c In stWarehouse.Instance.WH Order By c.Code, c.Name Select New With {c.Id, .Name = c.Code & "-" & c.Name}).ToList
        ComboBox1.DataSource = Wh
        ComboBox1.DisplayMember = "Name"
        ComboBox1.ValueMember = "Id"
        ComboBox1.SelectedIndex = -1
    End Sub

    Private Sub dgvUserDetails_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles DataGridView1.RowPostPaint
        Using b As New SolidBrush(DataGridView1.RowHeadersDefaultCellStyle.ForeColor)
            e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4)
        End Using
    End Sub

    Private Sub tbSearch_TextChanged(sender As System.Object, e As System.EventArgs) Handles tbSearch.TextChanged
        Try
            Dim dtGrid2 = (From c In dt Order By c.Id Where c.WHCode.Contains(tbSearch.Text) Or c.OwnCode.Contains(tbSearch.Text) Or c.DocNo.Contains(tbSearch.Text) Or c.ProdCode.Contains(tbSearch.Text) Or c.ProdName.Contains(tbSearch.Text) Or c.BaseBarcode.Contains(tbSearch.Text) Or c.BaseUnitCode.Contains(tbSearch.Text) Or c.ItmCode.Contains(tbSearch.Text) Select New With {.Owner = c.OwnCode, .คลัง = c.WHCode, .เลขที่ใบตรวจนับ = c.DocNo, .วันที่ตรวจนับ = Format(c.DocDate, "dd/MM/yyyy HH:mm"), .รายละเอียด = c.Description, .รหัสสินค้า = c.ProdCode, .ชื่อสินค้า = c.ProdName, .Barcode = c.BaseBarcode, .สถานะ = c.ItmCode, .จำนวน = Format(c.Qty, "#,##0"), .นับได้ = Format(c.QtyCount, "#,##0"), .ผลต่าง = Format(c.QtyDiff, "#,##0"), .หน่วย = c.BaseUnitCode, c.Remark, .วันที่บันทึก = Format(c.CreateDate, "dd/MM/yyyy HH:mm"), .ผู้บันทึก = c.CreateBy}).ToList
            With DataGridView1
                .DataSource = dtGrid2
                .AutoResizeColumns()
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Exception Error !!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub SelData()
        Try
            Cursor = Cursors.WaitCursor
            Using db = New PTGwmsEntities
                Dim strDate As String = Format(dtDate.Value, "yyyyMMdd")
                Dim strDateTo As String = Format(dtDateTo.Value, "yyyyMMdd")
                Dim intWh As Integer = ComboBox1.SelectedValue
                If RoleID = 1 Then
                    dt = db.V_PhyCount.Where(Function(x) x.FKWarehouse = intWh And x.CDate >= strDate And x.CDate <= strDateTo).ToList
                Else
                    dt = db.V_PhyCount.Where(Function(x) x.FKWarehouse = intWh And x.CDate >= strDate And x.CDate <= strDateTo And frmMain.ow.Contains(x.OwnCode.ToString) And frmMain.wh.Contains(x.WHCode.ToString)).ToList
                End If
                Dim dtGrid2 = (From c In dt Order By c.Id Select New With {.Owner = c.OwnCode, .คลัง = c.WHCode, .เลขที่ใบตรวจนับ = c.DocNo, .วันที่ตรวจนับ = Format(c.DocDate, "dd/MM/yyyy HH:mm"), .รายละเอียด = c.Description, .รหัสสินค้า = c.ProdCode, .ชื่อสินค้า = c.ProdName, .Barcode = c.BaseBarcode, .สถานะ = c.ItmCode, .จำนวน = Format(c.Qty, "#,##0"), .นับได้ = Format(c.QtyCount, "#,##0"), .ผลต่าง = Format(c.QtyDiff, "#,##0"), .หน่วย = c.BaseUnitCode, c.Remark, .วันที่บันทึก = Format(c.CreateDate, "dd/MM/yyyy HH:mm"), .ผู้บันทึก = c.CreateBy}).ToList
                With DataGridView1
                    .DataSource = dtGrid2
                    .AutoResizeColumns()
                    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    .Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    .Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    .Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                End With
            End Using
            Cursor = Cursors.Default
        Catch ex As Exception
            Cursor = Cursors.Default
            MessageBox.Show(ex.Message, "Exception Error !!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub btExcel_Click(sender As System.Object, e As System.EventArgs) Handles btExcel.Click
        If DataGridView1.RowCount = 0 Then Exit Sub
        Cursor = Cursors.WaitCursor

        Dim strDg As String = "Q"

        Dim xlApp As New Excel.Application
        Dim xlSheet As Excel.Worksheet
        Dim xlBook As Excel.Workbook

        xlBook = xlApp.Workbooks.Add()
        xlSheet = xlBook.Worksheets(1)
        xlApp.ActiveSheet.Cells(1, 1) = "รายงานการตรวจนับสต็อก"
        xlApp.ActiveSheet.Range("A1:" & strDg & "1").Merge()
        xlApp.ActiveSheet.Range("A1").HorizontalAlignment = Excel.Constants.xlCenter

        xlApp.ActiveSheet.Cells(2, 1) = "ค้นหาโดย : " & tbSearch.Text
        xlApp.ActiveSheet.Range("A2:" & strDg & "2").Merge()
        xlApp.ActiveSheet.Range("A2").HorizontalAlignment = Excel.Constants.xlCenter

        xlApp.ActiveSheet.Cells(3, 1) = "วันที่ออกรายงาน : " & Now.ToString("dd/MM/yyyy HH:mm") & ""
        xlSheet.Range("A3:" & strDg & "3").Merge()
        xlApp.ActiveSheet.Range("A3").HorizontalAlignment = Excel.Constants.xlCenter

        xlApp.ActiveSheet.Range("A1:" & strDg & "3").Interior.ColorIndex = 15
        xlApp.ActiveSheet.Range("A4:" & strDg & "4").Interior.ColorIndex = 6

        xlApp.ActiveSheet.Cells(4, 1).Value = "No."
        For k = 0 To DataGridView1.Columns.Count - 1 Step 1
            xlApp.ActiveSheet.Cells(4, k + 2).Value = DataGridView1.Columns(k).HeaderText
        Next

        For i = 0 To DataGridView1.Rows.Count - 1 Step 1
            xlApp.ActiveSheet.Cells(i + 5, 1).Value = "'" & i + 1
            For j = 0 To DataGridView1.Columns.Count - 1 Step 1
                xlApp.ActiveSheet.Cells(i + 5, j + 2).Value = "'" & DataGridView1.Rows(i).Cells(j).Value & ""
            Next
        Next
        xlApp.ActiveSheet.Range("A1:" & strDg & "1").FONT.Bold = True
        xlApp.ActiveSheet.Range("A1:" & strDg & "" & DataGridView1.Rows.Count + 4).BORDERS.Weight = 2
        xlApp.ActiveSheet.Columns("A:" & strDg & "").AutoFit()
        MessageBox.Show("ออกรายงานเรียบร้อย", "Report Finish", MessageBoxButtons.OK, MessageBoxIcon.Information)
        xlApp.Application.Visible = True
        xlSheet = Nothing
        xlBook = Nothing
        xlApp = Nothing
        tbSearch_TextChanged(sender, e)
        Cursor = Cursors.Default
    End Sub

    Private Sub btRefresh1_Click(sender As Object, e As EventArgs) Handles btRefresh1.Click
        If ComboBox1.SelectedIndex = -1 Then
            MessageBox.Show("กรุณาเลือก คลัง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ComboBox1.Focus()
            Exit Sub
        Else
            SelData()
        End If
    End Sub

End Class