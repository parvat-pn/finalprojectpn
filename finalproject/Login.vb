Imports System.Data.SqlClient
Imports System.Windows

Public Class login
    Dim connectionstring As String = "Data Source=NABIN\SQLEXPRESS;Initial Catalog=login_db;Integrated Security=True"


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection(connectionstring)
        Dim cmd As New SqlCommand("select *from login_tb where username =@user and password = @pass", con)
        cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = TextBox1.Text
        cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = TextBox2.Text
        Dim adaptor As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        adaptor.Fill(dt)
        If dt.Rows.Count() <= 0 Then
            MsgBox("error login")

        Else
            MsgBox("sucessfully login")

            product.Show()
            Me.Visible = False
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class