Imports Microsoft.Data.SqlClient
Imports System.Data

Public Class IncidentsForm

    Private Sub IncidentsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAccounts()
        LoadIncidents()
    End Sub

    Private Sub LoadAccounts()

        Try

            Dim dt As New DataTable()

            Using con As New SqlConnection(DBConnection.Conn.ConnectionString)

                Using da As New SqlDataAdapter(
                    "SELECT AccountID, AccountName FROM dbo.Account",
                    con)

                    da.Fill(dt)

                End Using

            End Using

            cmbAccount.DataSource = dt
            cmbAccount.DisplayMember = "AccountName"
            cmbAccount.ValueMember = "AccountID"

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub LoadIncidents()

        Try

            Dim dt As New DataTable()

            Using con As New SqlConnection(DBConnection.Conn.ConnectionString)

                Using da As New SqlDataAdapter(
                    "SELECT * FROM dbo.CybersecurityIncidents",
                    con)

                    da.Fill(dt)

                End Using

            End Using

            DataGridView1.DataSource = dt

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub DataGridView1_CellClick(
        sender As Object,
        e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        If e.RowIndex >= 0 Then

            Dim row As DataGridViewRow =
                DataGridView1.Rows(e.RowIndex)

            txtIncidentID.Text =
                row.Cells("IncidentID").Value.ToString()

            cmbAccount.SelectedValue =
                row.Cells("AccountID").Value

            dtpIncidentDate.Value =
                Convert.ToDateTime(
                    row.Cells("IncidentDate").Value)

            txtIncidentType.Text =
                row.Cells("IncidentType").Value.ToString()

            cmbSeverityLevel.Text =
                row.Cells("SeverityLevel").Value.ToString()

            txtDescription.Text =
                row.Cells("Description").Value.ToString()

        End If

    End Sub

    Private Sub btnAdd_Click(
        sender As Object,
        e As EventArgs) Handles btnAdd.Click

        Try

            Using con As New SqlConnection(
                DBConnection.Conn.ConnectionString)

                Using cmd As New SqlCommand(
                    "dbo.usp_InsertCybersecurityIncident",
                    con)

                    cmd.CommandType =
                        CommandType.StoredProcedure

                    cmd.Parameters.AddWithValue(
                        "@AccountID",
                        cmbAccount.SelectedValue)

                    cmd.Parameters.AddWithValue(
                        "@IncidentDate",
                        dtpIncidentDate.Value.Date)

                    cmd.Parameters.AddWithValue(
                        "@IncidentType",
                        txtIncidentType.Text)

                    cmd.Parameters.AddWithValue(
                        "@SeverityLevel",
                        cmbSeverityLevel.Text)

                    cmd.Parameters.AddWithValue(
                        "@Description",
                        txtDescription.Text)

                    con.Open()

                    cmd.ExecuteNonQuery()

                End Using

            End Using

            MessageBox.Show(
                "Incident added successfully.")

            LoadIncidents()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnUpdate_Click(
        sender As Object,
        e As EventArgs) Handles btnUpdate.Click

        Try

            Using con As New SqlConnection(
                DBConnection.Conn.ConnectionString)

                Using cmd As New SqlCommand(
                    "dbo.usp_UpdateCybersecurityIncident",
                    con)

                    cmd.CommandType =
                        CommandType.StoredProcedure

                    cmd.Parameters.AddWithValue(
                        "@IncidentID",
                        txtIncidentID.Text)

                    cmd.Parameters.AddWithValue(
                        "@AccountID",
                        cmbAccount.SelectedValue)

                    cmd.Parameters.AddWithValue(
                        "@IncidentDate",
                        dtpIncidentDate.Value.Date)

                    cmd.Parameters.AddWithValue(
                        "@IncidentType",
                        txtIncidentType.Text)

                    cmd.Parameters.AddWithValue(
                        "@SeverityLevel",
                        cmbSeverityLevel.Text)

                    cmd.Parameters.AddWithValue(
                        "@Description",
                        txtDescription.Text)

                    con.Open()

                    cmd.ExecuteNonQuery()

                End Using

            End Using

            MessageBox.Show(
                "Incident updated successfully.")

            LoadIncidents()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnResolve_Click(
        sender As Object,
        e As EventArgs) Handles btnResolve.Click

        Try

            Using con As New SqlConnection(
                DBConnection.Conn.ConnectionString)

                Using cmd As New SqlCommand(
                    "dbo.usp_ResolveCybersecurityIncident",
                    con)

                    cmd.CommandType =
                        CommandType.StoredProcedure

                    cmd.Parameters.AddWithValue(
                        "@IncidentID",
                        txtIncidentID.Text)

                    con.Open()

                    cmd.ExecuteNonQuery()

                End Using

            End Using

            MessageBox.Show(
                "Incident resolved successfully.")

            LoadIncidents()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

End Class