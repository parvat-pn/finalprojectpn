Public Class order
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        product.Show()
        Me.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        category.Show()
        Me.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        customerform.Show()
        Me.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Show()
    End Sub
End Class