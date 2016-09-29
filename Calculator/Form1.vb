Public Class Form1

 
    
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim c = Sumar()
        txtResult.Text = c.ToString()


    End Sub
    Private Function Sumar() As Integer
        Return Convert.ToInt32(txtNum1.Text) + Convert.ToInt32(txtNum2.Text)

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim c = Restar()
        txtResult.Text = c.ToString()
    End Sub
    Private Function Restar() As Integer
        Return Convert.ToInt32(txtNum1.Text) - Convert.ToInt32(txtNum2.Text)

    End Function
End Class
