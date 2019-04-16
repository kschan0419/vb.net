Public Class frm_orderlist_a160841

    Private Sub frm_orderlist_a160841_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_BP_A160841.accdb;Persist Security Info=False;"

        Dim mysql As String = "SELECT * FROM TBL_ORDER_A160841"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_order.DataSource = mydatatable

    End Sub

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click

        frm_mainmenu_a160841.Show()
        Me.Close()

    End Sub
End Class