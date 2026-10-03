Imports Microsoft.Data.SqlClient
Imports System.Data

Public Class ServicesForm

    Private Sub ServicesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadServiceData()
    End Sub

    Private Sub LoadServiceData()

        Try

            Dim dt As New DataTable()

            Using con As New SqlConnection(DBConnection.Conn.ConnectionString)

                Using da As New SqlDataAdapter(
                    "SELECT * FROM dbo.Services", con)

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

                Using cmd As New SqlCommand("dbo.usp_InsertService", con)

                    cmd.CommandType = CommandType.StoredProcedure

                    cmd.Parameters.AddWithValue("@ServiceName", TextBox2.Text)
                    cmd.Parameters.AddWithValue("@ServiceDescription", TextBox3.Text)

                    con.Open()
                    cmd.ExecuteNonQuery()

                End Using

            End Using

            MessageBox.Show("Service added successfully.")
            LoadServiceData()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try

            Using con As New SqlConnection(DBConnection.Conn.ConnectionString)

                Using cmd As New SqlCommand("dbo.usp_UpdateService", con)

                    cmd.CommandType = CommandType.StoredProcedure

                    cmd.Parameters.AddWithValue("@ServiceID", TextBox1.Text)
                    cmd.Parameters.AddWithValue("@ServiceName", TextBox2.Text)
                    cmd.Parameters.AddWithValue("@ServiceDescription", TextBox3.Text)

                    con.Open()
                    cmd.ExecuteNonQuery()

                End Using

            End Using

            MessageBox.Show("Service updated successfully.")
            LoadServiceData()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Try

            Using con As New SqlConnection(DBConnection.Conn.ConnectionString)

                Using cmd As New SqlCommand("dbo.usp_DeleteService", con)

                    cmd.CommandType = CommandType.StoredProcedure

                    cmd.Parameters.AddWithValue("@ServiceID", TextBox1.Text)

                    con.Open()
                    cmd.ExecuteNonQuery()

                End Using

            End Using

            MessageBox.Show("Service deleted successfully.")
            LoadServiceData()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

End Class