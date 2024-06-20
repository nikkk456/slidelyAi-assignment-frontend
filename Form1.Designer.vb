<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnViewSubmissions = New RoundedButton()
        Me.btnCreateSubmission = New RoundedButton()
        Me.SuspendLayout()
        '
        'btnViewSubmissions
        '
        Me.btnViewSubmissions.Location = New System.Drawing.Point(150, 50)
        Me.btnViewSubmissions.Name = "btnViewSubmissions"
        Me.btnViewSubmissions.Size = New System.Drawing.Size(200, 50)
        Me.btnViewSubmissions.TabIndex = 0
        Me.btnViewSubmissions.Text = "View Submissions (CTRL + V)"
        Me.btnViewSubmissions.UseVisualStyleBackColor = True
        Me.btnViewSubmissions.BackColor = System.Drawing.Color.Yellow
        AddHandler Me.btnViewSubmissions.Click, AddressOf Me.btnViewSubmissions_Click
        '
        'btnCreateSubmission
        '
        Me.btnCreateSubmission.Location = New System.Drawing.Point(150, 150)
        Me.btnCreateSubmission.Name = "btnCreateSubmission"
        Me.btnCreateSubmission.Size = New System.Drawing.Size(200, 50)
        Me.btnCreateSubmission.TabIndex = 1
        Me.btnCreateSubmission.Text = "Create New Submission (CTRL + N)"
        Me.btnCreateSubmission.UseVisualStyleBackColor = True
        Me.btnCreateSubmission.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnCreateSubmission.ForeColor = System.Drawing.Color.White
        AddHandler Me.btnCreateSubmission.Click, AddressOf Me.btnCreateSubmission_Click
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 250)
        Me.Controls.Add(Me.btnCreateSubmission)
        Me.Controls.Add(Me.btnViewSubmissions)
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.Text = "Slidely Form App"
        AddHandler Me.KeyDown, AddressOf Me.Form1_KeyDown
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents btnViewSubmissions As RoundedButton
    Private WithEvents btnCreateSubmission As RoundedButton

    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs)
        Dim viewForm As New ViewSubmissionsForm()
        viewForm.ShowDialog()
    End Sub

    Private Sub btnCreateSubmission_Click(sender As Object, e As EventArgs)
        Dim createForm As New CreateSubmissionForm()
        createForm.ShowDialog()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs)
        If e.Control AndAlso e.KeyCode = Keys.V Then
            btnViewSubmissions.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnCreateSubmission.PerformClick()
        End If
    End Sub
End Class
