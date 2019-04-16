Public Class frm_productlist_a160841

    Private Sub frm_productlist_a160841_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        refresh_grid()

    End Sub

    Private Sub refresh_grid()

        'Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_BP_A160841.accdb;Persist Security Info=False;"

        'Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A160841"

        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A160841 WHERE FLD_PRODUCT_NAME like '%" & txt_search.Text & "%'"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_product.DataSource = mydatatable

        grd_product.Columns(0).HeaderText = "Product ID"
        grd_product.Columns(1).HeaderText = "Product Name"
        grd_product.Columns(2).HeaderText = "Price"
        grd_product.Columns(3).HeaderText = "Product Brand"
        grd_product.Columns(4).HeaderText = "Product Type"
        grd_product.Columns(5).HeaderText = "Product Colour"
        grd_product.Columns(6).HeaderText = "Production Country"

    End Sub

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click

        frm_mainmenu_a160841.Show()
        Me.Close()

    End Sub

    Private Sub txt_search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_search.TextChanged

        refresh_grid()

    End Sub
End Class