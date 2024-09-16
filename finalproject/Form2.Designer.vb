<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form2))
        Panel1 = New Panel()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(188, 779)
        Panel1.TabIndex = 0
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(25, 489)
        Button5.Name = "Button5"
        Button5.Size = New Size(147, 45)
        Button5.TabIndex = 3
        Button5.Text = "Report"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(25, 406)
        Button4.Name = "Button4"
        Button4.Size = New Size(147, 45)
        Button4.TabIndex = 3
        Button4.Text = "Order"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(25, 327)
        Button3.Name = "Button3"
        Button3.Size = New Size(147, 45)
        Button3.TabIndex = 3
        Button3.Text = "Customer"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(25, 243)
        Button2.Name = "Button2"
        Button2.Size = New Size(147, 45)
        Button2.TabIndex = 3
        Button2.Text = "Category"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(25, 159)
        Button1.Name = "Button1"
        Button1.Size = New Size(147, 45)
        Button1.TabIndex = 3
        Button1.Text = "Products"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.White
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.Location = New Point(16, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(156, 125)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Silver
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(188, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1190, 60)
        Panel2.TabIndex = 1
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Gray
        Panel3.Location = New Point(194, 66)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1137, 578)
        Panel3.TabIndex = 2
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1378, 779)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form2"
        Text = "Form2"
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
End Class
