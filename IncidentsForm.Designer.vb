<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IncidentsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Descripution = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtIncidentID = New TextBox()
        txtDescription = New TextBox()
        dtpIncidentDate = New DateTimePicker()
        cmbAccount = New ComboBox()
        btnAdd = New Button()
        btnResolve = New Button()
        btnUpdate = New Button()
        DataGridView1 = New DataGridView()
        txtIncidentType = New TextBox()
        IncidentType = New Label()
        Label2 = New Label()
        cmbSeverityLevel = New ComboBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 20)
        Label1.TabIndex = 0
        Label1.Text = "Incident ID"
        ' 
        ' Descripution
        ' 
        Descripution.AutoSize = True
        Descripution.Location = New Point(12, 110)
        Descripution.Name = "Descripution"
        Descripution.Size = New Size(85, 20)
        Descripution.TabIndex = 1
        Descripution.Text = "Description"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 213)
        Label3.Name = "Label3"
        Label3.Size = New Size(107, 20)
        Label3.TabIndex = 2
        Label3.Text = "Date Reported"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 301)
        Label4.Name = "Label4"
        Label4.Size = New Size(63, 20)
        Label4.TabIndex = 3
        Label4.Text = "Account"
        ' 
        ' txtIncidentID
        ' 
        txtIncidentID.Location = New Point(347, 12)
        txtIncidentID.Name = "txtIncidentID"
        txtIncidentID.Size = New Size(125, 27)
        txtIncidentID.TabIndex = 4
        ' 
        ' txtDescription
        ' 
        txtDescription.Location = New Point(347, 110)
        txtDescription.Multiline = True
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(151, 49)
        txtDescription.TabIndex = 5
        ' 
        ' dtpIncidentDate
        ' 
        dtpIncidentDate.Location = New Point(347, 206)
        dtpIncidentDate.Name = "dtpIncidentDate"
        dtpIncidentDate.Size = New Size(250, 27)
        dtpIncidentDate.TabIndex = 6
        ' 
        ' cmbAccount
        ' 
        cmbAccount.FormattingEnabled = True
        cmbAccount.Location = New Point(376, 293)
        cmbAccount.Name = "cmbAccount"
        cmbAccount.Size = New Size(151, 28)
        cmbAccount.TabIndex = 7
        cmbAccount.Text = "Account"
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(12, 389)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(94, 29)
        btnAdd.TabIndex = 8
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnResolve
        ' 
        btnResolve.Location = New Point(347, 389)
        btnResolve.Name = "btnResolve"
        btnResolve.Size = New Size(94, 29)
        btnResolve.TabIndex = 9
        btnResolve.Text = "Resolve"
        btnResolve.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(167, 389)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(94, 29)
        btnUpdate.TabIndex = 10
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 459)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(628, 125)
        DataGridView1.TabIndex = 11
        ' 
        ' txtIncidentType
        ' 
        txtIncidentType.Location = New Point(347, 58)
        txtIncidentType.Name = "txtIncidentType"
        txtIncidentType.Size = New Size(125, 27)
        txtIncidentType.TabIndex = 12
        ' 
        ' IncidentType
        ' 
        IncidentType.AutoSize = True
        IncidentType.Location = New Point(12, 65)
        IncidentType.Name = "IncidentType"
        IncidentType.Size = New Size(97, 20)
        IncidentType.TabIndex = 13
        IncidentType.Text = "Incident Type"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 339)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 20)
        Label2.TabIndex = 14
        Label2.Text = "Serverity Level"
        ' 
        ' cmbSeverityLevel
        ' 
        cmbSeverityLevel.FormattingEnabled = True
        cmbSeverityLevel.Location = New Point(376, 339)
        cmbSeverityLevel.Name = "cmbSeverityLevel"
        cmbSeverityLevel.Size = New Size(151, 28)
        cmbSeverityLevel.TabIndex = 15
        ' 
        ' IncidentsForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 605)
        Controls.Add(cmbSeverityLevel)
        Controls.Add(Label2)
        Controls.Add(IncidentType)
        Controls.Add(txtIncidentType)
        Controls.Add(DataGridView1)
        Controls.Add(btnUpdate)
        Controls.Add(btnResolve)
        Controls.Add(btnAdd)
        Controls.Add(cmbAccount)
        Controls.Add(dtpIncidentDate)
        Controls.Add(txtDescription)
        Controls.Add(txtIncidentID)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Descripution)
        Controls.Add(Label1)
        Name = "IncidentsForm"
        Text = "Incidents Management"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Descripution As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtIncidentID As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents dtpIncidentDate As DateTimePicker
    Friend WithEvents cmbAccount As ComboBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnResolve As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtIncidentType As TextBox
    Friend WithEvents IncidentType As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbSeverityLevel As ComboBox
End Class
