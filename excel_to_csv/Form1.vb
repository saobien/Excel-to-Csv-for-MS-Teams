
Imports System.IO
Imports System.Data
Imports System.Xml
Imports System.Xml.XPath
Imports Microsoft.Office.Interop.Excel
Public Class Form1


    Private Sub BT_THOAT_Click(sender As Object, e As EventArgs) Handles BT_THOAT.Click
        Me.Close()
    End Sub

    Private Sub BT_LUU_Click(sender As Object, e As EventArgs) Handles BT_LUU.Click
        If dlgFolderSelect.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            TXT_LUU.Text = dlgFolderSelect.SelectedPath
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With DataGridView1
            .Columns.Clear()
            .Columns.Add("", "Stt")
            .Columns.Add("", "Lớp")
            .Columns.Add("", "Tên người dùng")
            .Columns.Add("", "Mẫu file Excel")
            .Columns.Add("", "Bước 1")
            .Columns.Add("", "Bước 2")
            .Columns.Add("", "Bước 3")
            .Columns.Add("", "Bước 4")
            .Columns.Add("", "Bước 5")
            .Columns.Add("", "Bước 6")
        End With
        DataGridView1.Rows.Add("1", "10A1", "Trần Quốc Minh", "File excel chỉ cần 3 cột thông tin như mẫu", "Nhập mã tài khoản", "Nhập phần đuôi tài khoản", "Nhập chức danh", "Chọn nơi lưu", "Mở file Excel cần chuyển", "Chuyển")
        DataGridView1.Rows.Add("2", "10A1", "Trần Minh Hải")
        DataGridView1.Rows.Add("3", "10A1", "Nguyễn Minh Anh")
        DataGridView1.Rows.Add("4", "10A1", "Bùi Minh Nhật")
        'THUOC TINH DATAGRIDVIEW
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.ReadOnly = True
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGreen
        DataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.Snow

        TXT_LUU.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
    End Sub

    Private Sub BT_CHONTEP_Click(sender As Object, e As EventArgs) Handles BT_CHONTEP.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        OpenFileDialog1.Filter = "Excel files (*.xls; *.xlsx)|*.xls;*.xlsx"

        If (OpenFileDialog1.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            DataGridView1.Columns.Clear()
            On Error Resume Next
            Dim oExcel As New Microsoft.Office.Interop.Excel.Application
            Dim oBook As Microsoft.Office.Interop.Excel.Workbook = oExcel.Workbooks.Open(OpenFileDialog1.FileName)
            Dim oSheet As Microsoft.Office.Interop.Excel.Worksheet = CType(oBook.Sheets(1), Microsoft.Office.Interop.Excel.Worksheet)
            Dim xlrange As Microsoft.Office.Interop.Excel.Range = oSheet.UsedRange
            Dim rowcount As Integer = xlrange.Rows.Count
            Dim colcount As Integer = xlrange.Columns.Count
            Dim stt, UserAccount, lop As String
            Dim hoten, ten, ho As String
            'THEM DU LIEU COT VAO DATAGRIDVIEW
            DataGridView1.Columns.Clear()
            If DataGridView1.Columns.Count = 0 Then
                With DataGridView1
                    .Columns.Clear()
                    .Columns.Add("tenmail", "Tên người dùng")
                    .Columns.Add("ten", "Tên")
                    .Columns.Add("ho", "Họ")
                    .Columns.Add("tenhienthi", "Tên hiển thị")
                    .Columns.Add("", "Chức danh công việc")
                    .Columns.Add("", "Phòng ban")
                    .Columns.Add("", "Số văn phòng")
                    .Columns.Add("", "Điện thoại văn phòng")
                    .Columns.Add("", "Điện thoại di động")
                    .Columns.Add("", "Fax")
                    .Columns.Add("", "Địa chỉ email thay thế")
                    .Columns.Add("", "Địa chỉ")
                    .Columns.Add("", "Thành phố")
                    .Columns.Add("", "Tiểu bang hoặc tỉnh thành")
                    .Columns.Add("", "Mã ZIP hoặc mã bưu điện")
                    .Columns.Add("", "Quốc gia hoặc vùng lãnh thổ")
                End With
            End If
            For i = 2 To rowcount
                DataGridView1.DataSource = Nothing
                stt = oSheet.Cells(i, 1).value.ToString
                lop = oSheet.Cells(i, 2).value.ToString
                hoten = oSheet.Cells(i, 3).value.ToString
                'ten = InStrRev(hoten, " ")
                ten = Mid(hoten, InStrRev(hoten, " ") + 1, Len(hoten) - InStr(hoten, " ") + 1)
                ho = Mid(hoten, 1, InStrRev(hoten, " ") - 1)
                Select Case Len(lop)
                    Case 4
                        lop = "0" & Mid(lop, 4, 1)
                    Case 5
                        lop = Mid(lop, 4, 2)
                End Select

                Select Case Len(stt)
                    Case 1
                        stt = "00" & stt
                    Case 2
                        stt = "0" & stt
                End Select
                UserAccount = TXT_ID.Text & lop & stt & TXT_DUOITK.Text
                'DataGridView1.Rows.Add(oSheet.Cells(i, 1).value.ToString & TXT_DUOITK.Text, oSheet.Cells(i, 3).value.ToString, oSheet.Cells(i, 2).value.ToString, oSheet.Cells(i, 2).value.ToString & " " & oSheet.Cells(i, 3).value.ToString, TXT_CHUCDANH.Text)
                DataGridView1.Rows.Add(UserAccount, ten, ho, oSheet.Cells(i, 3).value.ToString, TXT_CHUCDANH.Text)
                ProgressBar1.Value = i / (rowcount) * 100
            Next
            For Each col As DataGridViewColumn In DataGridView1.Columns
                col.SortMode = DataGridViewColumnSortMode.NotSortable
            Next
            oBook.Close()
            oExcel.Quit()
        End If
    End Sub

    Private Sub BT_CHUYEN_Click(sender As Object, e As EventArgs) Handles BT_CHUYEN.Click
        On Error Resume Next
        Dim TIME As String ' = Replace(Now.ToLongTimeString, ":", "_")
        Dim oExcel As New Microsoft.Office.Interop.Excel.Application
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim oBook As Microsoft.Office.Interop.Excel.Workbook = oExcel.Workbooks.Add(misValue)
        Dim oSheet As Microsoft.Office.Interop.Excel.Worksheet = CType(oBook.Sheets(1), Microsoft.Office.Interop.Excel.Worksheet)
        'test
        Dim nlan As Integer = DataGridView1.RowCount \ 240
        Dim n As Integer = 0
        'end
        For k = 0 To nlan
            'test
            n = 0
            oBook = oExcel.Workbooks.Add(misValue)
            oSheet = Nothing
            oSheet = CType(oBook.Sheets(1), Microsoft.Office.Interop.Excel.Worksheet)
            TIME = Replace(Now.ToLongTimeString, ":", "_")
            For j = 0 To DataGridView1.ColumnCount - 1
                oSheet.Cells(1, j + 1) = DataGridView1.Columns(j).HeaderText
                ' oSheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString()

                ' oSheet.Cells(n + 2, j + 1) = DataGridView1(j, i).Value.ToString()
            Next
            'end test
            'For i = 0 To DataGridView1.RowCount - 1
            For i = 0 + 240 * k To 240 * (k + 1) - 1
                If i > DataGridView1.RowCount - 1 Then Exit For

                'test
                For j = 0 To DataGridView1.ColumnCount - 1
                    ' oSheet.Cells(1, j + 1) = DataGridView1.Columns(j).HeaderText
                    ' oSheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString()

                    oSheet.Cells(n + 2, j + 1) = DataGridView1(j, i).Value.ToString()
                Next
                'end test
                n += 1
                ProgressBar1.Value = (i + 1) / (DataGridView1.RowCount - 1) * 100
            Next
            oExcel.DisplayAlerts = False
            oBook.SaveAs(TXT_LUU.Text & "\Excel2Csv_" & TIME & ".csv", Microsoft.Office.Interop.Excel.XlFileFormat.xlUnicodeText)
            oBook.Close()
            oExcel.Quit()
            Dim text As String = System.IO.File.ReadAllText(TXT_LUU.Text & "\Excel2Csv_" & TIME & ".csv")
            text = text.Replace(Chr(9), ",")
            System.IO.File.WriteAllText(TXT_LUU.Text & "\Excel2Csv_" & TIME & ".csv", text)

        Next
        'test
        oBook.Close()
        oExcel.Quit()
        'end test
        ' hoi xem co muon mo thu muc chua file da tao hay ko
        If MsgBox("Đã chuyển xong. Bạn có muốn mở thư mục đã lưu không?", MsgBoxStyle.OkCancel, "Thông báo") = MsgBoxResult.Ok Then Process.Start("explorer.exe", TXT_LUU.Text)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TXT_CHUCDANH.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
