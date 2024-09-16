Public Class customerform
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        product.Show()
        Me.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        category.Show()
        Me.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        order.Show()
        Me.Visible = False
    End Sub
End Class