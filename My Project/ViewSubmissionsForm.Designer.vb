Imports Newtonsoft.Json.Linq
Imports System.Net

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewSubmissionsForm
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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhoneNum = New System.Windows.Forms.TextBox()
        Me.txtGithubLink = New System.Windows.Forms.TextBox()
        Me.txtStopwatchTime = New System.Windows.Forms.TextBox()
        Me.btnPrevious = New RoundedButton()
        Me.btnNext = New RoundedButton()
        Me.btnDelete = New RoundedButton()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPhoneNum = New System.Windows.Forms.Label()
        Me.lblGithubLink = New System.Windows.Forms.Label()
        Me.lblStopwatchTime = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        ' lblName
        '
        Me.lblName.Location = New System.Drawing.Point(50, 50)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(100, 20)
        Me.lblName.TabIndex = 7
        Me.lblName.Text = "Name:"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        ' txtName
        '
        Me.txtName.Location = New System.Drawing.Point(150, 50)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(200, 20)
        Me.txtName.TabIndex = 0
        '
        ' lblEmail
        '
        Me.lblEmail.Location = New System.Drawing.Point(50, 100)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(100, 20)
        Me.lblEmail.TabIndex = 8
        Me.lblEmail.Text = "Email:"
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        ' txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(150, 100)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(200, 20)
        Me.txtEmail.TabIndex = 1
        '
        ' lblPhoneNum
        '
        Me.lblPhoneNum.Location = New System.Drawing.Point(50, 150)
        Me.lblPhoneNum.Name = "lblPhoneNum"
        Me.lblPhoneNum.Size = New System.Drawing.Size(100, 20)
        Me.lblPhoneNum.TabIndex = 9
        Me.lblPhoneNum.Text = "Phone Number:"
        Me.lblPhoneNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        ' txtPhoneNum
        '
        Me.txtPhoneNum.Location = New System.Drawing.Point(150, 150)
        Me.txtPhoneNum.Name = "txtPhoneNum"
        Me.txtPhoneNum.ReadOnly = True
        Me.txtPhoneNum.Size = New System.Drawing.Size(200, 20)
        Me.txtPhoneNum.TabIndex = 2
        '
        ' lblGithubLink
        '
        Me.lblGithubLink.Location = New System.Drawing.Point(50, 200)
        Me.lblGithubLink.Name = "lblGithubLink"
        Me.lblGithubLink.Size = New System.Drawing.Size(100, 20)
        Me.lblGithubLink.TabIndex = 10
        Me.lblGithubLink.Text = "GitHub Link:"
        Me.lblGithubLink.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        ' txtGithubLink
        '
        Me.txtGithubLink.Location = New System.Drawing.Point(150, 200)
        Me.txtGithubLink.Name = "txtGithubLink"
        Me.txtGithubLink.ReadOnly = True
        Me.txtGithubLink.Size = New System.Drawing.Size(200, 20)
        Me.txtGithubLink.TabIndex = 3
        '
        ' lblStopwatchTime
        '
        Me.lblStopwatchTime.Location = New System.Drawing.Point(50, 250)
        Me.lblStopwatchTime.Name = "lblStopwatchTime"
        Me.lblStopwatchTime.Size = New System.Drawing.Size(100, 20)
        Me.lblStopwatchTime.TabIndex = 11
        Me.lblStopwatchTime.Text = "Stopwatch Time:"
        Me.lblStopwatchTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        ' txtStopwatchTime
        '
        Me.txtStopwatchTime.Location = New System.Drawing.Point(150, 250)
        Me.txtStopwatchTime.Name = "txtStopwatchTime"
        Me.txtStopwatchTime.ReadOnly = True
        Me.txtStopwatchTime.Size = New System.Drawing.Size(200, 20)
        Me.txtStopwatchTime.TabIndex = 4
        '
        ' btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(50, 300)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(120, 23)
        Me.btnPrevious.TabIndex = 5
        Me.btnPrevious.Text = "Previous (CTRL + P)"
        Me.btnPrevious.UseVisualStyleBackColor = True
        Me.btnPrevious.BackColor = System.Drawing.Color.Yellow
        AddHandler Me.btnPrevious.Click, AddressOf Me.btnPrevious_Click
        '
        ' btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(350, 300)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(120, 23)
        Me.btnNext.TabIndex = 6
        Me.btnNext.Text = "Next (CTRL + N)"
        Me.btnNext.UseVisualStyleBackColor = True
        Me.btnNext.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnNext.ForeColor = System.Drawing.Color.White
        AddHandler Me.btnNext.Click, AddressOf Me.btnNext_Click
        '
        ' btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(200, 300)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(120, 23)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "Delete (CTRL + D)"
        Me.btnDelete.UseVisualStyleBackColor = True
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        AddHandler Me.btnDelete.Click, AddressOf Me.btnDelete_Click
        '
        'ViewSubmissionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 350)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.txtStopwatchTime)
        Me.Controls.Add(Me.lblStopwatchTime)
        Me.Controls.Add(Me.txtGithubLink)
        Me.Controls.Add(Me.lblGithubLink)
        Me.Controls.Add(Me.txtPhoneNum)
        Me.Controls.Add(Me.lblPhoneNum)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.KeyPreview = True
        Me.Name = "ViewSubmissionsForm"
        Me.Text = "View Submissions"
        AddHandler Me.KeyDown, AddressOf Me.ViewSubmissionsForm_KeyDown
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtName As TextBox
    Private WithEvents txtEmail As TextBox
    Private WithEvents txtPhoneNum As TextBox
    Private WithEvents txtGithubLink As TextBox
    Private WithEvents txtStopwatchTime As TextBox
    Private WithEvents btnPrevious As RoundedButton
    Private WithEvents btnNext As RoundedButton
    Private WithEvents btnDelete As RoundedButton
    Private WithEvents lblName As Label
    Private WithEvents lblEmail As Label
    Private WithEvents lblPhoneNum As Label
    Private WithEvents lblGithubLink As Label
    Private WithEvents lblStopwatchTime As Label

    Private currentIndex As Integer = 0

    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSubmission(currentIndex)
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs)
        If currentIndex > 0 Then
            currentIndex -= 1
            LoadSubmission(currentIndex)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs)
        currentIndex += 1
        LoadSubmission(currentIndex)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs)
        DeleteSubmission(currentIndex)
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs)
        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.D Then
            btnDelete.PerformClick()
        End If
    End Sub

    Private Sub LoadSubmission(index As Integer)
        Dim url As String = "http://localhost:3000/read?index=" & index.ToString()

        ' Create a WebClient to make the HTTP request
        Dim client As New System.Net.WebClient()

        Try
            ' Send the GET request and get the response
            Dim responseString As String = client.DownloadString(url)

            ' Parse the JSON response
            Dim submission As JObject = JObject.Parse(responseString)

            ' Populate the form fields
            txtName.Text = submission("name").ToString()
            txtEmail.Text = submission("email").ToString()
            txtPhoneNum.Text = submission("phone").ToString()
            txtGithubLink.Text = submission("github_link").ToString()
            txtStopwatchTime.Text = submission("stopwatch_time").ToString()

        Catch ex As Exception
            ' Handle any errors that occur during the request
            MessageBox.Show("Error loading submission: " & ex.Message)
        End Try
    End Sub

    Private Sub DeleteSubmission(index As Integer)
        Dim url As String = "http://localhost:3000/delete?index=" & index.ToString()

        ' Create a WebClient to make the HTTP request
        Dim client As New System.Net.WebClient()

        Try
            ' Send the GET request to delete the submission
            Dim responseString As String = client.UploadString(url, "DELETE", "")

            ' Reload the current submission after deletion
            LoadSubmission(currentIndex)
        Catch ex As Exception
            ' Handle any errors that occur during the request
            MessageBox.Show("Error deleting submission: " & ex.Message)
        End Try
    End Sub
End Class
