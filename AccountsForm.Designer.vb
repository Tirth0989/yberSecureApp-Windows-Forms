<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountsForm
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
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtAccountID = New TextBox()
        txtAccountName = New TextBox()
        txtAccountStatus = New TextBox()
        cmbClient = New ComboBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        AccountDataGridView = New DataGridView()
        dptSubscriptionDate = New DateTimePicker()
        dgvAccountServices = New DataGridView()
        CType(AccountDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvAccountServices, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 34)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 20)
        Label2.TabIndex = 1
        Label2.Text = "Account ID"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 77)
        Label3.Name = "Label3"
        Label3.Size = New Size(107, 20)
        Label3.TabIndex = 2
        Label3.Text = "Account Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 110)
        Label4.Name = "Label4"
        Label4.Size = New Size(127, 20)
        Label4.TabIndex = 3
        Label4.Text = "Subscription Date"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 157)
        Label5.Name = "Label5"
        Label5.Size = New Size(47, 20)
        Label5.TabIndex = 4
        Label5.Text = "Client"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 202)
        Label6.Name = "Label6"
        Label6.Size = New Size(107, 20)
        Label6.TabIndex = 5
        Label6.Text = "Account Status"
        ' 
        ' txtAccountID
        ' 
        txtAccountID.Location = New Point(195, 27)
        txtAccountID.Name = "txtAccountID"
        txtAccountID.Size = New Size(263, 27)
        txtAccountID.TabIndex = 8
        ' 
        ' txtAccountName
        ' 
        txtAccountName.Location = New Point(195, 60)
        txtAccountName.Name = "txtAccountName"
        txtAccountName.Size = New Size(263, 27)
        txtAccountName.TabIndex = 9
        ' 
        ' txtAccountStatus
        ' 
        txtAccountStatus.Location = New Point(195, 202)
        txtAccountStatus.Name = "txtAccountStatus"
        txtAccountStatus.Size = New Size(263, 27)
        txtAccountStatus.TabIndex = 10
        ' 
        ' cmbClient
        ' 
        cmbClient.FormattingEnabled = True
        cmbClient.Location = New Point(195, 149)
        cmbClient.Name = "cmbClient"
        cmbClient.Size = New Size(263, 28)
        cmbClient.TabIndex = 11
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(582, 34)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 12
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(582, 110)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 13
        Button2.Text = "Update"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(582, 202)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 14
        Button3.Text = "Delete"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' AccountDataGridView
        ' 
        AccountDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        AccountDataGridView.Location = New Point(12, 272)
        AccountDataGridView.Name = "AccountDataGridView"
        AccountDataGridView.RowHeadersWidth = 51
        AccountDataGridView.Size = New Size(664, 124)
        AccountDataGridView.TabIndex = 15
        ' 
        ' dptSubscriptionDate
        ' 
        dptSubscriptionDate.Location = New Point(195, 105)
        dptSubscriptionDate.Name = "dptSubscriptionDate"
        dptSubscriptionDate.Size = New Size(263, 27)
        dptSubscriptionDate.TabIndex = 16
        ' 
        ' dgvAccountServices
        ' 
        dgvAccountServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAccountServices.Location = New Point(12, 432)
        dgvAccountServices.Name = "dgvAccountServices"
        dgvAccountServices.RowHeadersWidth = 51
        dgvAccountServices.Size = New Size(664, 114)
        dgvAccountServices.TabIndex = 17
        ' 
        ' AccountsForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1053, 572)
        Controls.Add(dgvAccountServices)
        Controls.Add(dptSubscriptionDate)
        Controls.Add(AccountDataGridView)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(cmbClient)
        Controls.Add(txtAccountStatus)
        Controls.Add(txtAccountName)
        Controls.Add(txtAccountID)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Name = "AccountsForm"
        Text = "Account Management"
        CType(AccountDataGridView, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvAccountServices, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAccountID As TextBox
    Friend WithEvents txtAccountName As TextBox
    Friend WithEvents txtAccountStatus As TextBox
    Friend WithEvents cmbClient As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents AccountDataGridView As DataGridView
    Friend WithEvents dptSubscriptionDate As DateTimePicker
    Friend WithEvents dgvAccountServices As DataGridView
End Class
