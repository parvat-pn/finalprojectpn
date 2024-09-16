Imports System.Data.SqlClient
Public Class product
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Show()
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
        order.Show()
        Me.Visible = False
    End Sub
    Dim con As New SqlConnection()
    Dim cmd As New SqlCommand


    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into itemstb values('" + TextBox7.Text + "','" + TextBox2.Text + "','" + ComboBox1.SelectedItem + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "')"
        cmd.ExecuteNonQuery()
        disp()
        MsgBox("insert sucessfully")


    End Sub



    Private Sub product_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBox1.Items.Add("Electronic")
        ComboBox1.Items.Add("Furniture")
        ComboBox1.Items.Add("Food")
        ComboBox1.Items.Add("Clothing")

        con.ConnectionString = "Data Source = NABIN \ SQLEXPRESS;Initial Catalog=login_db;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        disp()
    End Sub
    Public Sub disp()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from itemstb"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim adaptor As New SqlDataAdapter(cmd)
        adaptor.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "update itemstb set ('" + TextBox7.Text + "','" + TextBox2.Text + "','" + ComboBox1.SelectedItem + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "')"
        cmd.ExecuteNonQuery()
        disp()
        MsgBox("update sucessfully")
    End Sub


End Class
