Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class RoundedButton
    Inherits Button

    Public Property BorderColor As Color = Color.Black
    Public Property BorderThickness As Integer = 2

    Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
        Dim graphics As Graphics = pevent.Graphics
        graphics.SmoothingMode = SmoothingMode.AntiAlias
        Dim rect As New Rectangle(0, 0, Me.Width, Me.Height)
        Dim rectPath As GraphicsPath = GetRoundRectPath(rect, 20)

        Me.Region = New Region(rectPath)
        Dim brush As New SolidBrush(Me.BackColor)
        graphics.FillPath(brush, rectPath)

        Dim sf As New StringFormat()
        sf.Alignment = StringAlignment.Center
        sf.LineAlignment = StringAlignment.Center
        graphics.DrawString(Me.Text, Me.Font, New SolidBrush(Me.ForeColor), rect, sf)

        ' Draw border
        Using pen As New Pen(BorderColor, BorderThickness)
            pen.Alignment = PenAlignment.Inset
            graphics.DrawPath(pen, rectPath)
        End Using
    End Sub

    Private Function GetRoundRectPath(rect As Rectangle, radius As Integer) As GraphicsPath
        Dim arcRect As New Rectangle(rect.Location, New Size(radius, radius))
        Dim path As New GraphicsPath()

        ' top left arc
        path.AddArc(arcRect, 180, 90)

        ' top right arc
        arcRect.X = rect.Right - radius
        path.AddArc(arcRect, 270, 90)

        ' bottom right arc
        arcRect.Y = rect.Bottom - radius
        path.AddArc(arcRect, 0, 90)

        ' bottom left arc
        arcRect.X = rect.Left
        path.AddArc(arcRect, 90, 90)

        path.CloseFigure()
        Return path
    End Function
End Class
