Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim bitmap As New Bitmap(PictureBox1.Width, PictureBox1.Height)
        Dim g As Graphics = Graphics.FromImage(bitmap)

        Dim penColor As New Pen(Color.YellowGreen)
        penColor.Width = 2

        Dim x As Integer = 0
        Dim y As Integer = 0
        Dim width As Integer = PictureBox1.Width - 500
        Dim height As Integer = PictureBox1.Height - 500
        g.DrawEllipse(penColor, x, y, width, height)

        Dim brushColor As New SolidBrush(Color.YellowGreen)
        Dim xPoint As Integer = 500
        Dim yPoint As Integer = 150
        Dim widthPoint As Integer = PictureBox1.Width - 770
        Dim heightPoint As Integer = PictureBox1.Height - 770
        g.FillEllipse(brushColor, xPoint, yPoint, widthPoint, heightPoint)

        Dim xRectangle As Integer = 50
        Dim yRectangle As Integer = 500
        Dim widthRectangle As Integer = 250
        Dim heightRectangle As Integer = 200
        g.DrawRectangle(penColor, xRectangle, yRectangle, widthRectangle, heightRectangle)


        Dim xLine As Integer = 500
        Dim y1Line As Integer = 500
        Dim y2Line As Integer = 700
        g.DrawLine(penColor, xLine, y1Line, xLine, y2Line)

        PictureBox1.Image = bitmap
    End Sub
End Class
