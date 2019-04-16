Public Class frm_splashscreen_a160841

    Private Sub btn_start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_start.Click

        username = txt_name.Text

        MsgBox("Welcome " & username & " to the BP Shop Record System")

        frm_mainmenu_a160841.Show()
        Me.Hide()

    End Sub

    Private Sub btn_details_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_details.Click

        frm_productdetails_a160841.Show()
        Me.Hide()

    End Sub

    Private Sub btn_manage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_manage.Click

        frm_mainmenu2_a160841.Show()
        Me.Hide()

    End Sub

    Private Sub btn_makeorder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_makeorder.Click

        frm_orderproduct_a160841.Show()
        Me.Hide()

    End Sub

    Private Sub btn_allinvoices_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_allinvoices.Click

        Dim mydatatable As DataTable = run_sql_query("SELECT * FROM TBL_ORDER_A160841")

        If mydatatable.Rows.Count = 0 Then

            MsgBox("Sorry, there are not any orders yet.")

        Else

            check = True
            frm_invoice_a160841.Show()
            Me.Close()

        End If



    End Sub
End Class
