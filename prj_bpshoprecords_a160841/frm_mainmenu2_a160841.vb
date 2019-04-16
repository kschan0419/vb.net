Public Class frm_mainmenu2_a160841

    Private Sub btn_productlist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_productlist.Click

        frm_insertproducts_a160841.Show()
        Me.Hide()

    End Sub

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click

        frm_splashscreen_a160841.Show()
        Me.Hide()

    End Sub

    Private Sub btn_stafflist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_stafflist.Click

        frm_insertstaffs_a160841.Show()
        Me.Hide()

    End Sub

    Private Sub btn_customerlist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_customerlist.Click

        frm_insertcustomers_a160841.Show()
        Me.Hide()

    End Sub

    Private Sub frm_mainmenu2_a160841_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class