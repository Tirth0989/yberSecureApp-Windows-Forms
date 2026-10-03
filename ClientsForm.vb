Imports Microsoft.Data.SqlClient
Imports System.Data

Public Class ClientsForm

    Private Sub ClientsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadClients()
    End Sub

    Private Sub LoadClients()
        Try
            Dim dt As New DataTable()

            Using con As New SqlConnection(DBConnection.Conn.ConnectionString)
                con.Open()

                Dim sql As String = "SELECT * FROM dbo.vw_ClientsAccounts"

                Using da As New SqlDataAdapter(sql, con)
                    da.Fill(dt)
                End Using
            End Using

            DataGridView1.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            Using con As New SqlConnection(DBConnection.Conn.ConnectionString)
                Using cmd As New SqlCommand("dbo.usp_InsertClient", con)

                    cmd.CommandType = CommandType.StoredProcedure

                    cmd.Parameters.AddWithValue("@Name", TextBox2.Text)
                    cmd.Parameters.AddWithValue("@ContactEmail", TextBox3.Text)
                    cmd.Parameters.AddWithValue("@ContactPhone", TextBox4.Text)
                    cmd.Parameters.AddWithValue("@Address", TextBox5.Text)

                    con.Open()
                    cmd.ExecuteNonQuery()

                End Using
            End Using

            MessageBox.Show("Client added successfully.")
            LoadClients()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try

            Using con As New SqlConnection(DBConnection.Conn.ConnectionString)

                Using cmd As New SqlCommand("dbo.usp_UpdateClient", con)

                    cmd.CommandType = CommandType.StoredProcedure

                    cmd.Parameters.AddWithValue("@ClientID", TextBox1.Text)
                    cmd.Parameters.AddWithValue("@Name", TextBox2.Text)
                    cmd.Parameters.AddWithValue("@ContactEmail", TextBox3.Text)
                    cmd.Parameters.AddWithValue("@ContactPhone", TextBox4.Text)
                    cmd.Parameters.AddWithValue("@Address", TextBox5.Text)

                    con.Open()
                    cmd.ExecuteNonQuery()

                End Using

            End Using

            MessageBox.Show("Client updated successfully.")
            LoadClients()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Using con As New SqlConnection(DBConnection.Conn.ConnectionString)
                Using cmd As New SqlCommand("dbo.usp_DeleteClient", con)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@ClientID", TextBox1.Text)

                    con.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Client deleted successfully.")
            LoadClients()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class