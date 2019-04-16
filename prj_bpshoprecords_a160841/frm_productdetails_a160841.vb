Public Class frm_productdetails_a160841

    Private Sub frm_productdetails_a160841_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim mysql As String = "SELECT FLD_PRODUCT_ID FROM TBL_PRODUCTS_A160841"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        lst_id.DataSource = mydatatable
        lst_id.DisplayMember = "FLD_PRODUCT_ID"

        refresh_text(lst_id.Text)

    End Sub

    Private Sub refresh_text(ByVal id As String)

        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A160841 WHERE FLD_PRODUCT_ID='" & id & "'"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        lbl_id.Text = "Product ID : " & mydatatable.Rows(0).Item("FLD_PRODUCT_ID")
        lbl_name.Text = "Product Name : " & mydatatable.Rows(0).Item("FLD_PRODUCT_NAME")
        lbl_price.Text = "Price : RM" & Format(mydatatable.Rows(0).Item("FLD_PRICE"), "0.00")
        lbl_brand.Text = "Brand : " & mydatatable.Rows(0).Item("FLD_BRAND")
        lbl_type.Text = "Type : " & mydatatable.Rows(0).Item("FLD_TYPE")
        lbl_colour.Text = "Colour : " & mydatatable.Rows(0).Item("FLD_COLOUR")
        lbl_production_country.Text = "Production Country : " & mydatatable.Rows(0).Item("FLD_PRODUCTION_COUNTRY")

        Try
            pic_product.BackgroundImage = Image.FromFile("pictures/" & mydatatable.Rows(0).Item("FLD_PRODUCT_ID") & ".png")
        Catch ex As Exception
            pic_product.BackgroundImage = Image.FromFile("pictures/nophoto.png")
        End Try

    End Sub

    Private Sub lst_id_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lst_id.MouseClick

        refresh_text(lst_id.Text)

    End Sub

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click

        pic_product.BackgroundImage = Image.FromFile("pictures/nophoto.png")
        frm_splashscreen_a160841.Show()
        Me.Close()

    End Sub
End Class