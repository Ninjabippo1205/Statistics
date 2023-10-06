Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox1.Paint
        Dim g = e.Graphics
        Dim pen As New Pen(Color.GreenYellow) ' Specifica il colore del cerchio
        pen.Width = 4
        Dim centerX As Integer = PictureBox1.Width / 2 ' Calcola il centro X del PictureBox
        Dim centerY As Integer = PictureBox1.Height / 2 ' Calcola il centro Y del PictureBox
        Dim radius = 200 ' Imposta il raggio del cerchio

        g.DrawEllipse(pen, centerX - radius, centerY - radius, 2 * radius, 2 * radius)
    End Sub

    Private Sub PictureBox2_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox2.Paint
        Dim g = e.Graphics
        Dim pen As New Pen(Color.GreenYellow) ' Specifica il colore del cerchio
        pen.Color = Color.GreenYellow ' Specifica il colore del segmento
        pen.Width = 4
        Dim centerX As Integer = PictureBox2.Width / 2 ' Calcola il centro X del PictureBox
        Dim centerY As Integer = PictureBox2.Height / 8 ' Calcola il centro Y del PictureBox
        Dim startPoint As New Point(centerX, centerY) ' Punto di inizio del segmento (centro del cerchio)
        Dim endPoint As New Point(centerX, centerY + 400) ' Punto di fine del segmento

        g.DrawLine(Pen, startPoint, endPoint)
    End Sub

    Private Sub PictureBox3_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox3.Paint
        Dim g As Graphics = e.Graphics
        Dim brush As New SolidBrush(Color.GreenYellow) ' Specifica il colore del pallino
        Dim centerX As Integer = PictureBox3.Width / 2 ' Calcola il centro X del PictureBox
        Dim centerY As Integer = PictureBox3.Height / 2 ' Calcola il centro Y del PictureBox
        Dim radius As Integer = 20 ' Imposta il raggio del pallino

        ' Disegna il pallino pieno
        g.FillEllipse(brush, centerX - radius, centerY - radius, 2 * radius, 2 * radius)
    End Sub

    Private Sub PictureBox4_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox4.Paint
        Dim g As Graphics = e.Graphics
        Dim pen As New Pen(Color.GreenYellow) ' Specifica il colore del rettangolo
        pen.Width = 4
        Dim x As Integer = PictureBox4.Width / 8 ' Coordinata X dell'angolo in alto a sinistra del rettangolo
        Dim y As Integer = PictureBox4.Height / 4 ' Coordinata Y dell'angolo in alto a sinistra del rettangolo
        Dim width As Integer = 300 ' Larghezza del rettangolo
        Dim height As Integer = 250 ' Altezza del rettangolo

        ' Disegna il rettangolo
        g.DrawRectangle(pen, x, y, width, height)
    End Sub
End Class
