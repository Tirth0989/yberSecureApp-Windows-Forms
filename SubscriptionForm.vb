Imports Microsoft.Data.SqlClient
Imports System.Data

Public Class SubscriptionForm

    Private Sub SubscriptionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAccountData()
        LoadServiceData()
        LoadSubscriptionData()
    End Sub

    Private Sub LoadAccountData()
        Try
            Dim dt As New DataTable()

            Using con As New SqlConnection(DBConnection.Conn.ConnectionString)
                Using da As New SqlDataAdapter("SELECT AccountID, AccountName FROM dbo.Account ORDER BY AccountName", con)
                    da.Fill(dt)
                End Using
            End Using

            CmbAccount.DataSource = Nothing
            CmbAccount.DataSource = dt
            CmbAccount.DisplayMember = "AccountName"
            CmbAccount.ValueMember = "AccountID"
            CmbAccount.SelectedIndex = -1

        Catch ex As Exception
            MessageBox.Show("LoadAccountData: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadServiceData()
        Try
            Dim dt As New DataTable()

            Using con As New SqlConnection(DBConnection.Conn.ConnectionString)
                Using da As New SqlDataAdapter("SELECT ServiceID, ServiceName FROM dbo.Services ORDER BY ServiceName", con)
                    da.Fill(dt)
                End Using
            End Using

            cmbService.DataSource = Nothing
            cmbService.DataSource = dt
            cmbService.DisplayMember = "ServiceName"
            cmbService.ValueMember = "ServiceID"
            cmbService.SelectedIndex = -1

        Catch ex As Exception
            MessageBox.Show("LoadServiceData: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadSubscriptionData()
        Try
            Dim dt As New DataTable()

            Using con As New SqlConnection(DBConnection.Conn.ConnectionString)
                Using da As New SqlDataAdapter("SELECT * FROM dbo.Subscriptions", con)
                    da.Fill(dt)
                End Using
            End Using

            DataGridView1.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("LoadSubscriptionData: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Using con As New SqlConnection(DBConnection.Conn.ConnectionString)
                Using cmd As New SqlCommand("dbo.usp_InsertSubscription", con)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@AccountID", CmbAccount.SelectedValue)
                    cmd.Parameters.AddWithValue("@ServiceID", cmbService.SelectedValue)

                    con.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Subscription added successfully.")
            LoadSubscriptionData()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class