Public Class frm_insertproducts_a160841

    Dim defaultpicture As String = Application.StartupPath & "\pictures\nophoto.png"

    Dim current_id As String

    Private Sub frm_insertproducts_a160841_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        refresh_grid()

        up_pic.Text = defaultpicture
        pic_up.BackgroundImage = Image.FromFile(defaultpicture)

        get_current_code()

    End Sub
    Private Function generate_id() As String

        Dim lastid As String = run_sql_query("SELECT MAX(FLD_PRODUCT_ID) AS LASTID FROM TBL_PRODUCTS_A160841").Rows(0).Item("LASTID")

        'MsgBox(lastid)

        Dim newid As String = "P" & Format((Mid(lastid, 3) + 1), "000")

        Return newid

    End Function

    Private Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A160841"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        Try
            myreader.Fill(mydatatable)
        Catch ex As Exception

            Beep()
            MsgBox("There is an error:" & vbCrLf & vbCrLf & ex.Message)
        End Try

        grd_products.DataSource = mydatatable

        grd_products.Columns(0).HeaderText = "Product ID"
        grd_products.Columns(1).HeaderText = "Product Name"
        grd_products.Columns(2).HeaderText = "Price"
        grd_products.Columns(3).HeaderText = "Product Brand"
        grd_products.Columns(4).HeaderText = "Product Type"
        grd_products.Columns(5).HeaderText = "Product Colour"
        grd_products.Columns(6).HeaderText = "Production Country"

    End Sub

    Private Sub clear_fields2()

        up_id.Text = ""
        up_name.Text = ""
        up_price.Text = ""
        up_brand.Text = ""
        up_type.Text = ""
        up_colour.Text = ""
        up_production_country.Text = ""

        up_pic.Text = defaultpicture
        pic_up.BackgroundImage = Image.FromFile(defaultpicture)

    End Sub

    Private Sub btn_insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_insert.Click

        Dim mysql As String = "INSERT INTO TBL_PRODUCTS_A160841 VALUES('" & up_id.Text & "','" & up_name.Text & "','" & up_price.Text & "','" & up_brand.Text & "','" & up_type.Text & "','" & up_colour.Text & "','" & up_production_country.Text & "')"

        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try

            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            My.Computer.FileSystem.CopyFile(up_pic.Text, "pictures\" & up_id.Text & ".png")

            refresh_grid()
            'clear_fields()
            clear_fields2()

        Catch ex As Exception

            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)

            mywriter.Connection.Close()

        End Try

    End Sub

    Private Sub get_current_code()

        Dim current_row As Integer = grd_products.CurrentRow.Index

        current_id = grd_products(0, current_row).Value

        up_id.Text = current_id
        up_name.Text = grd_products(1, current_row).Value
        up_price.Text = Format((grd_products(2, current_row).Value), "0.00")
        up_brand.Text = grd_products(3, current_row).Value
        up_type.Text = grd_products(4, current_row).Value
        up_colour.Text = grd_products(5, current_row).Value
        up_production_country.Text = grd_products(6, current_row).Value

    End Sub

    Private Sub grd_products_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd_products.CellClick

        get_current_code()
        up_id.ReadOnly = True

    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click

            If (current_id = "Not Allowed") = True Then

                Beep()
                MsgBox("Nooooooo !!!!!!!!!! You are not allowed to update after click 'Add New' button. If you want update an existing data please click a cell from grd then edit the data. After that click 'Update' button to update the new data to that existing product.")

            End If

            If (current_id = "Not Allowed") = False Then

                'run_sql_command("UPDATE TBL_PRODUCTS_A160841 SET FLD_PRODUCT_NAME = '" & up_name.Text & "' WHERE FLD_PRODUCT_ID = '" & current_id & "'")
                'run_sql_command("UPDATE TBL_PRODUCTS_A160841 SET FLD_PRICE = '" & up_price.Text & "' WHERE FLD_PRODUCT_ID = '" & current_id & "'")
                'run_sql_command("UPDATE TBL_PRODUCTS_A160841 SET FLD_BRAND = '" & up_brand.Text & "' WHERE FLD_PRODUCT_ID = '" & current_id & "'")
                'run_sql_command("UPDATE TBL_PRODUCTS_A160841 SET FLD_TYPE = '" & up_type.Text & "' WHERE FLD_PRODUCT_ID = '" & current_id & "'")
                'run_sql_command("UPDATE TBL_PRODUCTS_A160841 SET FLD_COLOUR = '" & up_colour.Text & "' WHERE FLD_PRODUCT_ID = '" & current_id & "'")
                'run_sql_command("UPDATE TBL_PRODUCTS_A160841 SET FLD_PRODUCTION_COUNTRY = '" & up_production_country.Text & "' WHERE FLD_PRODUCT_ID = '" & current_id & "'")

            run_sql_command2("UPDATE TBL_PRODUCTS_A160841 SET FLD_PRODUCT_NAME = '" & up_name.Text & "' , FLD_PRICE = '" & up_price.Text & "' , FLD_BRAND = '" & up_brand.Text & "' , FLD_TYPE = '" & up_type.Text & "' , FLD_COLOUR = '" & up_colour.Text & "' , FLD_PRODUCTION_COUNTRY = '" & up_production_country.Text & "' WHERE FLD_PRODUCT_ID = '" & current_id & "'")

            If check2 = True Then

                If up_pic.Text <> "" Then
                    Dim FileToCopy As String
                    Dim OldCopy As String

                    FileToCopy = up_pic.Text
                    OldCopy = "pictures/" & current_id & ".png"

                    If System.IO.File.Exists(OldCopy) = True Then
                        System.IO.File.Delete(OldCopy)
                        My.Computer.FileSystem.CopyFile(FileToCopy, OldCopy)
                    End If

                End If

            End If

            'START OF MEANINGLESS PART
            Dim mysql As String = "UPDATE TBL_PRODUCTS_A160841 SET FLD_PRODUCT_NAME = '" & up_name.Text & "' , FLD_PRICE = '" & up_price.Text & "' , FLD_BRAND = '" & up_brand.Text & "' , FLD_TYPE = '" & up_type.Text & "' , FLD_COLOUR = '" & up_colour.Text & "' , FLD_PRODUCTION_COUNTRY = '" & up_production_country.Text & "' WHERE FLD_PRODUCT_ID = '" & current_id & "'"

            Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

            Try

                mywriter.Connection.Open()
                mywriter.ExecuteNonQuery()
                mywriter.Connection.Close()

                refresh_grid()
                clear_fields2()

                Beep()
                MsgBox("You have successfully updated the product """ & current_id & """.")

            Catch ex As Exception

                'Beep()
                'MsgBox("You type the wrong format for certain value. Please try again. (Noted that price is in numeric format)")

                mywriter.Connection.Close()

            End Try

            'END OF MEANINGLESS PART
        End If

        refresh_grid()
        clear_fields2()
        get_current_code()

    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click

        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the product """ & current_id & """?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then

            Dim delCopy = "pictures/" & current_id & ".png"

            System.IO.File.Delete(delCopy)

            run_sql_command("DELETE FROM TBL_PRODUCTS_A160841 WHERE FLD_PRODUCT_ID = '" & current_id & "'")

            Beep()
            MsgBox("The product """ & current_id & """has been successfully deleted.")

            refresh_grid()
            clear_fields2()
            get_current_code()

        End If

    End Sub

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click

        frm_mainmenu2_a160841.Show()
        Me.Close()

    End Sub

    Private Sub btn_picture2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_picture2.Click

        Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop

        Try
            OpenFileDialog1.InitialDirectory = mydesktop
            OpenFileDialog1.FileName = ""
            OpenFileDialog1.Filter = "PNG files (*.png)|*.png"
            OpenFileDialog1.ShowDialog()

            pic_up.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
            up_pic.Text = OpenFileDialog1.FileName
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click

        clear_fields2()
        up_id.Text = generate_id()
        up_id.ReadOnly = False
        current_id = "Not Allowed"

    End Sub
End Class