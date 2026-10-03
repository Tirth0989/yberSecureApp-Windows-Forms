Imports Microsoft.Data.SqlClient

Module DBConnection
    Private Function GetConnectionString() As String
        Dim configuredConnection =
            Environment.GetEnvironmentVariable("CYBERSECURE_DB_CONNECTION")

        If Not String.IsNullOrWhiteSpace(configuredConnection) Then
            Return configuredConnection
        End If

        Return "Data Source=localhost\SQLEXPRESS;" &
               "Initial Catalog=CyberSecureCloudSolutionsDB;" &
               "Integrated Security=True;" &
               "TrustServerCertificate=True;"
    End Function

    Public ReadOnly Conn As New SqlConnection(GetConnectionString())
End Module
