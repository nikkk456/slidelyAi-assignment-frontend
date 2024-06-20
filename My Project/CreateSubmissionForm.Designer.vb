<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateSubmissionForm
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
        Me.btnToggleStopwatch = New RoundedButton()
        Me.btnSubmit = New RoundedButton()
        Me.Timer1 = New System.Windows.Forms.Timer()
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
        ' btnToggleStopwatch
        '
        Me.btnToggleStopwatch.Location = New System.Drawing.Point(150, 300)
        Me.btnToggleStopwatch.Name = "btnToggleStopwatch"
        Me.btnToggleStopwatch.Size = New System.Drawing.Size(200, 23)
        Me.btnToggleStopwatch.TabIndex = 5
        Me.btnToggleStopwatch.Text = "Toggle Stopwatch (CTRL + T)"
        Me.btnToggleStopwatch.UseVisualStyleBackColor = True
        Me.btnToggleStopwatch.BackColor = System.Drawing.Color.Yellow
        Me.btnToggleStopwatch.BorderColor = Color.Black
        Me.btnToggleStopwatch.BorderThickness = 2
        AddHandler Me.btnToggleStopwatch.Click, AddressOf Me.btnToggleStopwatch_Click
        '
        ' btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(150, 350)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(200, 23)
        Me.btnSubmit.TabIndex = 6
        Me.btnSubmit.Text = "Submit (CTRL + S)"
        Me.btnSubmit.UseVisualStyleBackColor = True
        Me.btnSubmit.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnSubmit.BorderColor = Color.Black
        Me.btnSubmit.BorderThickness = 2
        AddHandler Me.btnSubmit.Click, AddressOf Me.btnSubmit_Click
        '
        ' Timer1
        '
        Me.Timer1.Interval = 1000
        AddHandler Me.Timer1.Tick, AddressOf Me.Timer1_Tick
        '
        ' CreateSubmissionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 400)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnToggleStopwatch)
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
        Me.Name = "CreateSubmissionForm"
        Me.Text = "Create Submission"
        AddHandler Me.KeyDown, AddressOf Me.CreateSubmissionForm_KeyDown
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Private WithEvents txtName As TextBox
    Private WithEvents txtEmail As TextBox
    Private WithEvents txtPhoneNum As TextBox
    Private WithEvents txtGithubLink As TextBox
    Private WithEvents txtStopwatchTime As TextBox
    Private WithEvents btnToggleStopwatch As RoundedButton
    Private WithEvents btnSubmit As RoundedButton
    Private WithEvents Timer1 As Timer
    Private WithEvents lblName As Label
    Private WithEvents lblEmail As Label
    Private WithEvents lblPhoneNum As Label
    Private WithEvents lblGithubLink As Label
    Private WithEvents lblStopwatchTime As Label

    ' Variables to manage stopwatch state
    Private stopwatchRunning As Boolean = False
    Private startTime As DateTime

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs)
        If stopwatchRunning Then
            ' Stop the stopwatch
            Timer1.Stop()
            stopwatchRunning = False
            btnToggleStopwatch.Text = "Start Stopwatch (CTRL + T)"
        Else
            ' Start the stopwatch
            startTime = DateTime.Now
            Timer1.Start()
            stopwatchRunning = True
            btnToggleStopwatch.Text = "Stop Stopwatch (CTRL + T)"
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        ' Calculate the elapsed time and update the textbox
        Dim elapsedTime As TimeSpan = DateTime.Now.Subtract(startTime)
        txtStopwatchTime.Text = elapsedTime.ToString("hh\:mm\:ss")
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs)
        ' Define the URL of your Express server endpoint for form submission
        Dim url As String = "http://localhost:3000/submit"

        ' Prepare the data to send by getting values from the input fields
        Dim name As String = txtName.Text
        Dim email As String = txtEmail.Text
        Dim phone As String = txtPhoneNum.Text
        Dim githubLink As String = txtGithubLink.Text
        Dim stopwatchTime As String = txtStopwatchTime.Text

        ' Construct the JSON string with the input data
        Dim formData As String = "{" &
                             """name"":""" & name & """," &
                             """email"":""" & email & """," &
                             """phone"":""" & phone & """," &
                             """github_link"":""" & githubLink & """," &
                             """stopwatch_time"":""" & stopwatchTime & """" &
                             "}"

        ' Create a WebClient to make the HTTP request
        Dim client As New System.Net.WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/json")

        Try
            ' Send the POST request and get the response
            Dim responseBytes As Byte() = client.UploadData(url, "POST", System.Text.Encoding.UTF8.GetBytes(formData))

            ' Convert the response to a string
            Dim responseString As String = System.Text.Encoding.UTF8.GetString(responseBytes)

            ' Handle the response as needed (e.g., display a message or update UI)
            MessageBox.Show("Form submitted successfully!" & vbCrLf & "Response: " & responseString)

        Catch ex As Exception
            ' Handle any errors that occur during the request
            MessageBox.Show("Error submitting form: " & ex.Message)
        End Try
    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs)
        If e.Control AndAlso e.KeyCode = Keys.T Then
            btnToggleStopwatch.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        End If
    End Sub
End Class
