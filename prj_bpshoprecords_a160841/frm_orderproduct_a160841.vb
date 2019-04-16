Public Class frm_orderproduct_a160841

    Dim i As Integer = 0
    Dim current_row As Integer
    Dim Total As Decimal

    Dim staffid As String
    Dim customerid As String
    Dim oid As String

    Private Sub frm_orderproduct_a160841_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        refresh_grid()

        get_current_code()

    End Sub

    Private Sub refresh_grid()

        grd_product.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCTS_A160841")

        grd_product.Columns(0).HeaderText = "Product ID"
        grd_product.Columns(1).HeaderText = "Product Name"
        grd_product.Columns(2).HeaderText = "Price (RM)"
        grd_product.Columns(3).HeaderText = "Product Brand"
        grd_product.Columns(4).HeaderText = "Product Type"
        grd_product.Columns(5).HeaderText = "Product Colour"
        grd_product.Columns(6).HeaderText = "Production Country"

        oid = generate_id()
        lbl_orderid.Text = "Order ID : " & oid

        cb_customerid.DataSource = run_sql_query("SELECT [Customer ID] FROM TBL_CUSTOMER_A160841")
        cb_customerid.DisplayMember = "Customer ID"

        cb_staffid.DataSource = run_sql_query("SELECT [Staff ID] FROM TBL_STAFF_A160841")
        cb_staffid.DisplayMember = "Staff ID"

        grd_cart.ColumnCount = 5
        grd_cart.RowCount = 0

        grd_cart.Columns(0).HeaderText = "Product ID"
        grd_cart.Columns(1).HeaderText = "Product Name"
        grd_cart.Columns(2).HeaderText = "Quantity"
        grd_cart.Columns(3).HeaderText = "Unit Price (RM)"
        grd_cart.Columns(4).HeaderText = "Subtotal (RM)"

        Total = 0
        lbl_total.Text = "Total : " & FormatCurrency(Total)

        grd_cart.Rows.Clear()

    End Sub

    Private Sub get_current_code()

        Dim current_row As Integer = grd_product.CurrentRow.Index

        Dim current_id As String = grd_product(0, current_row).Value

        Try
            pic_product.BackgroundImage = Image.FromFile("pictures/" & current_id & ".png")
        Catch ex As Exception
            pic_product.BackgroundImage = Image.FromFile("pictures/nophoto.png")
        End Try

    End Sub

    Private Sub grd_product_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd_product.CellClick

        get_current_code()

    End Sub

    Private Function generate_id() As String

        Dim newid As String

        Dim mydatatable As DataTable = run_sql_query("SELECT * FROM TBL_ORDER_A160841")

        If mydatatable.Rows.Count = 0 Then

            newid = "O001"

        Else

            Dim lastid As String = run_sql_query("SELECT MAX([Order ID]) AS LASTID FROM TBL_ORDER_A160841").Rows(0).Item("LASTID")

            newid = "O" & Format((Mid(lastid, 3) + 1), "000")

        End If

        Return newid

    End Function

    Private Sub cb_staffid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_staffid.SelectedIndexChanged

        Dim mydatatable = run_sql_query("SELECT * FROM TBL_STAFF_A160841")
        staffid = mydatatable.Rows(cb_staffid.SelectedIndex).Item("Staff ID")

    End Sub

    Private Sub cb_customerid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_customerid.SelectedIndexChanged

        Dim mydatatable = run_sql_query("SELECT * FROM TBL_CUSTOMER_A160841")
        customerid = mydatatable.Rows(cb_customerid.SelectedIndex).Item("Customer ID")

    End Sub

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click

        pic_product.BackgroundImage = Image.FromFile("pictures/nophoto.png")
        frm_splashscreen_a160841.Show()
        Me.Close()

    End Sub

    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click

        Dim count As Integer = 0
        Dim temp As Integer

        For x As Integer = 0 To grd_cart.RowCount - 1
            If grd_product(0, get_current_row).Value = grd_cart(0, x).Value Then
                count = count + 1
                temp = x
            End If
        Next

        If count > 0 Then
            grd_cart(2, temp).Value = grd_cart(2, temp).Value + nud_quantity.Value
            Dim temptotal As Decimal = nud_quantity.Value * grd_cart(3, temp).Value
            grd_cart(4, temp).Value = grd_cart(4, temp).Value + temptotal

            Total = Total + temptotal
        Else

            grd_cart.RowCount = grd_cart.RowCount + 1
            grd_cart(0, i).Value = grd_product(0, get_current_row).Value
            grd_cart(1, i).Value = grd_product(1, get_current_row).Value
            grd_cart(2, i).Value = nud_quantity.Value
            grd_cart(3, i).Value = grd_product(2, get_current_row).Value
            grd_cart(4, i).Value = nud_quantity.Value * grd_product(2, current_row).Value

            Total = Total + grd_cart(4, i).Value

            i += 1
        End If

        lbl_total.Text = "Total : " & FormatCurrency(Total)

    End Sub

    Private Function get_current_row() As Integer

        current_row = grd_product.CurrentRow.Index

        Return current_row

    End Function

    Private Sub btn_remove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_remove.Click

        If grd_cart.RowCount > 0 Then
            Dim current As Integer = grd_cart.CurrentRow.Index

            Dim value As Decimal = grd_cart(4, current).Value

            Total = Total - value

            lbl_total.Text = "Total : " & FormatCurrency(Total)

            grd_cart.Rows.RemoveAt(current)

            i = i - 1
        Else
            MsgBox("The cart is empty so there is nothing to delete , thank you")
        End If

    End Sub

    Private Sub btn_confirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_confirm.Click

        If grd_cart.RowCount > 0 Then

            Dim mytransaction As OleDb.OleDbTransaction

            myconnection2.Open()
            mytransaction = myconnection2.BeginTransaction

            'Dim orderID As String = oid

            Try

                Dim ordersql As String = "INSERT INTO TBL_ORDER_A160841 VALUES ('" & oid & "', '" & staffid & "', '" & customerid & "', " & Total & ")"

                Dim orderwritter As New OleDb.OleDbCommand(ordersql, myconnection2, mytransaction)

                orderwritter.ExecuteNonQuery()

                For y As Integer = 0 To grd_cart.RowCount - 1

                    Dim productID As String = grd_cart(0, y).Value
                    Dim quantity As Integer = grd_cart(2, y).Value
                    Dim subtotal As Decimal = grd_cart(4, y).Value

                    Dim mysql As String = "INSERT INTO TBL_ORDER_PRODUCT_A160841 VALUES ('" & oid & "','" & productID & "', " & quantity & ", " & subtotal & ")"

                    Dim mywritter As New OleDb.OleDbCommand(mysql, myconnection2, mytransaction)

                    mywritter.ExecuteNonQuery()

                Next

                mytransaction.Commit()
                myconnection2.Close()

                Beep()
                MsgBox("Transaction Successful!")

                tempoid = oid

                refresh_grid()

                '' extra feature

                Dim confirmation = MsgBox("Would you like to view the invoice you made just now ?", MsgBoxStyle.YesNo)

                If confirmation = MsgBoxResult.Yes Then

                    check = False
                    pic_product.BackgroundImage = Image.FromFile("pictures/nophoto.png")
                    frm_invoice_a160841.Show()
                    Me.Close()

                Else
                    pic_product.BackgroundImage = Image.FromFile("pictures/nophoto.png")
                    frm_splashscreen_a160841.Show()
                    Me.Close()

                End If

            Catch ex As Exception

                Beep()
                MsgBox("An error occured while confirming order: " & vbCrLf & vbCrLf & ex.Message)

                mytransaction.Rollback()
                myconnection2.Close()

                refresh_grid()

            End Try

            i = 0

        Else
            MsgBox("Please add product")
        End If

    End Sub
End Class