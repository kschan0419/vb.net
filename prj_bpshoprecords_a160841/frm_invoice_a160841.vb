Public Class frm_invoice_a160841

    Dim orderid As String

    Private Sub frm_invoice_a160841_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cb_order.DataSource = run_sql_query("SELECT [Order ID] FROM TBL_ORDER_A160841")
        cb_order.DisplayMember = "Order ID"

        grd_invoice.Columns(3).HeaderText = "Price (RM)"

    End Sub

    Private Sub cb_order_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_order.SelectedIndexChanged

        Dim mydatatable = run_sql_query("SELECT * FROM TBL_ORDER_A160841")
        orderid = mydatatable.Rows(cb_order.SelectedIndex).Item("Order ID")

        If check = False Then
            cb_order.Visible = False
            lbl_order.Text = "Order ID : " & tempoid

            grd_invoice.DataSource = run_sql_query("SELECT * FROM TBL_ORDER_PRODUCT_A160841 WHERE [Order ID] = '" & tempoid & "'")

            lbl_staff.Text += "SELECT [Staff ID] FROM TBL_ORDER_A160841 WHERE [Order ID] = '" & tempoid & "'"
            lbl_customer.Text += "SELECT [Customer ID] FROM TBL_ORDER_A160841 WHERE [Order ID] = '" & tempoid & "'"

            Dim orderdatatable = run_sql_query("SELECT * FROM TBL_ORDER_A160841 WHERE [Order ID] = '" & tempoid & "'")

            lbl_customer.Text = "Customer ID : " & orderdatatable.Rows(0).Item("Customer ID")
            lbl_staff.Text = "Staff ID : " & orderdatatable.Rows(0).Item("Staff ID")
            Dim t As Decimal = orderdatatable.Rows(0).Item("Total")
            lbl_total.Text = "Total : " & FormatCurrency(t)

        Else
            cb_order.Visible = True

            grd_invoice.DataSource = run_sql_query("SELECT * FROM TBL_ORDER_PRODUCT_A160841 WHERE [Order ID] = '" & orderid & "'")

            Dim orderdatatable = run_sql_query("SELECT * FROM TBL_ORDER_A160841 WHERE [Order ID] = '" & orderid & "'")

            lbl_customer.Text = "Customer ID : " & orderdatatable.Rows(0).Item("Customer ID")
            lbl_staff.Text = "Staff ID : " & orderdatatable.Rows(0).Item("Staff ID")
            Dim t As Decimal = orderdatatable.Rows(0).Item("Total")
            lbl_total.Text = "Total : " & FormatCurrency(t)

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        frm_splashscreen_a160841.Show()
        Me.Close()

    End Sub
End Class