Imports Microsoft.Data.SqlClient
Imports System.Data

Public Class AccountsForm

    Private Sub AccountsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAccounts()
        LoadClients()
    End Sub

    Private Sub LoadAccounts()
        Try
            Dim dt As New DataTable()

            Using con As New SqlConnection(DBConnection.Conn.ConnectionString)
                Using da As New SqlDataAdapter("SELECT * FROM dbo.Account", con)
                    da.Fill(dt)
                End Using
            End Using

            AccountDataGridView.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub LoadClients()
        Try
            Dim dt As New DataTable()

            Using con As New SqlConnection(DBConnection.Conn.ConnectionString)
                Using da As New SqlDataAdapter("SELECT ClientID, Name FROM dbo.Client", con)
                    da.Fill(dt)
                End Using
            End Using

            cmbClient.DataSource = dt
            cmbClient.DisplayMember = "Name"
            cmbClient.ValueMember = "ClientID"
            cmbClient.SelectedIndex = -1

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub LoadAccountServices(accountId As Integer)
        Try
            Dim dt As New DataTable()

            Using con As New SqlConnection(DBConnection.Conn.ConnectionString)
                Using da As New SqlDataAdapter(
                    "SELECT * FROM dbo.vw_AccountsServices WHERE AccountID = @AccountID", con)

                    da.SelectCommand.Parameters.AddWithValue("@AccountID", accountId)
                    da.Fill(dt)
                End Using
            End Using

            dgvAccountServices.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub AccountDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles AccountDataGridView.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = AccountDataGridView.Rows(e.RowIndex)

            If row.Cells("AccountID").Value IsNot Nothing Then
                txtAccountID.Text = row.Cells("AccountID").Value.ToString()
            End If

            If row.Cells("AccountName").Value IsNot Nothing Then
                txtAccountName.Text = row.Cells("AccountName").Value.ToString()
            End If

            If row.Cells("AccountStatus").Value IsNot Nothing Then
                txtAccountStatus.Text = row.Cells("AccountStatus").Value.ToString()
            End If

            If row.Cells("SubscriptionDate").Value IsNot Nothing AndAlso row.Cells("SubscriptionDate").Value IsNot DBNull.Value Then
                dptSubscriptionDate.Value = Convert.ToDateTime(row.Cells("SubscriptionDate").Value)
            End If

            If row.Cells("ClientID").Value IsNot Nothing AndAlso row.Cells("ClientID").Value IsNot DBNull.Value Then
                cmbClient.SelectedValue = row.Cells("ClientID").Value
            End If

            If row.Cells("AccountID").Value IsNot Nothing AndAlso row.Cells("AccountID").Value IsNot DBNull.Value Then
                Dim accountId As Integer
                If Integer.TryParse(row.Cells("AccountID").Value.ToString(), accountId) Then
                    LoadAccountServices(accountId)
                End If
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Using con As New SqlConnection(DBConnection.Conn.ConnectionString)
                Using cmd As New SqlCommand("dbo.usp_InsertAccount", con)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@AccountName", txtAccountName.Text.Trim())
                    cmd.Parameters.AddWithValue("@ClientID", cmbClient.SelectedValue)
                    cmd.Parameters.AddWithValue("@SubscriptionDate", dptSubscriptionDate.Value.Date)
                    cmd.Parameters.AddWithValue("@AccountStatus", txtAccountStatus.Text.Trim())

                    con.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Account added successfully.")
            LoadAccounts()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Using con As New SqlConnection(DBConnection.Conn.ConnectionString)
                Using cmd As New SqlCommand("dbo.usp_UpdateAccount", con)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@AccountID", txtAccountID.Text.Trim())
                    cmd.Parameters.AddWithValue("@AccountName", txtAccountName.Text.Trim())
                    cmd.Parameters.AddWithValue("@AccountStatus", txtAccountStatus.Text.Trim())

                    con.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Account updated successfully.")
            LoadAccounts()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Using con As New SqlConnection(DBConnection.Conn.ConnectionString)
                Using cmd As New SqlCommand("DELETE FROM dbo.Account WHERE AccountID=@AccountID", con)
                    cmd.Parameters.AddWithValue("@AccountID", txtAccountID.Text.Trim())

                    con.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Account deleted successfully.")
            LoadAccounts()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class