Public Class frm_mainmenu_a160841

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click

        frm_splashscreen_a160841.Show()
        Me.Hide()

    End Sub

    Private Sub frm_mainmenu_a160841_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim current_date As String = Date.Now

        lbl_date.Text = current_date

    End Sub

    Private Sub btn_productlist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_productlist.Click

        frm_productlist_a160841.Show()

        Me.Hide()

    End Sub

    Private Sub btn_studentlist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_studentlist.Click

        frm_customerlist_a160841.Show()

        Me.Hide()

    End Sub

    Private Sub btn_stafflist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_stafflist.Click

        frm_stafflist_a160841.Show()

        Me.Hide()

    End Sub

    Private Sub btn_orderlist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_orderlist.Click

        frm_orderlist_a160841.Show()

        Me.Hide()

    End Sub
End Class