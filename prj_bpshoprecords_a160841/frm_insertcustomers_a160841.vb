Public Class frm_insertcustomers_a160841

    Dim current_id As String

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click

        frm_mainmenu2_a160841.Show()
        Me.Close()

    End Sub

    Private Sub frm_insertcustomers_a160841_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        grd_customer.DataSource = run_sql_query("SELECT * FROM TBL_CUSTOMER_A160841")

        txt_id.Text = generate_id()

        get_current_id()

    End Sub

    Private Function generate_id() As String

        Dim lastid As String = run_sql_query("SELECT MAX([Customer ID])AS LASTID FROM TBL_CUSTOMER_A160841").Rows(0).Item("LASTID")

        'MsgBox(lastid)

        Dim newid As String = "C" & Format((Mid(lastid, 3) + 1), "000")

        Return newid

    End Function

    Private Sub btn_insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_insert.Click

        Dim mysql As String = "INSERT INTO TBL_CUSTOMER_A160841 VALUES('" & txt_id.Text & "','" & txt_name.Text & "')"

        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try

            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            grd_customer.DataSource = run_sql_query("SELECT * FROM TBL_CUSTOMER_A160841")

            txt_id.Text = generate_id()
            txt_name.Text = ""

        Catch ex As Exception

            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)

            mywriter.Connection.Close()

        End Try

    End Sub

    Private Sub clear_fields()

        up_id.Text = ""
        up_name.Text = ""

    End Sub

    Private Sub get_current_id()

        Dim current_row As Integer = grd_customer.CurrentRow.Index

        current_id = grd_customer(0, current_row).Value

        up_id.Text = current_id
        up_name.Text = grd_customer(1, current_row).Value

    End Sub

    Private Sub grd_customer_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd_customer.CellClick

        get_current_id()

    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click

        run_sql_command("UPDATE TBL_CUSTOMER_A160841 SET [Customer Name]='" & up_name.Text & "' WHERE [Customer ID]='" & current_id & "'")

        Dim mysql As String = "UPDATE TBL_CUSTOMER_A160841 SET [Customer Name] = '" & up_name.Text & "'  WHERE [Customer ID] = '" & current_id & "'"

        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try

            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            refresh_grid()
            clear_fields()

            Beep()
            MsgBox("You have successfully updated the customer """ & current_id & """.")

        Catch ex As Exception

            mywriter.Connection.Close()

        End Try

        refresh_grid()
        clear_fields()
        get_current_id()

    End Sub

    Private Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM TBL_CUSTOMER_A160841"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_customer.DataSource = mydatatable

    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click

        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the customer """ & current_id & """?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then

            run_sql_command("DELETE FROM TBL_CUSTOMER_A160841 WHERE [Customer ID]='" & current_id & "'")

            Beep()
            MsgBox("The customer """ & current_id & """has been successfully deleted.")

            refresh_grid()
            clear_fields()
            get_current_id()

        End If

    End Sub
End Class