﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class productsform
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
        DataGridView1 = New DataGridView()
        Button1 = New Button()
        Panel1 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Button2 = New Button()
        Button3 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ButtonFace
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(29, 106)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 33
        DataGridView1.Size = New Size(543, 364)
        DataGridView1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaption
        Button1.Location = New Point(35, 361)
        Button1.Name = "Button1"
        Button1.Size = New Size(101, 60)
        Button1.TabIndex = 1
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveBorder
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(DataGridView1)
        Panel1.Location = New Point(508, 26)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(592, 488)
        Panel1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(159, 11)
        Label2.Name = "Label2"
        Label2.Size = New Size(105, 25)
        Label2.TabIndex = 3
        Label2.Text = "Product List"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(58, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(146, 25)
        Label1.TabIndex = 2
        Label1.Text = "Search Items--->"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(210, 53)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(234, 31)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(170, 44)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 31)
        TextBox2.TabIndex = 3
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(170, 93)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 31)
        TextBox3.TabIndex = 3
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(170, 141)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 31)
        TextBox4.TabIndex = 3
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(170, 188)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(100, 31)
        TextBox5.TabIndex = 3
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(170, 234)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(100, 31)
        TextBox6.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(61, 50)
        Label3.Name = "Label3"
        Label3.Size = New Size(48, 25)
        Label3.TabIndex = 4
        Label3.Text = "Item"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(56, 99)
        Label4.Name = "Label4"
        Label4.Size = New Size(84, 25)
        Label4.TabIndex = 4
        Label4.Text = "Category"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(61, 147)
        Label5.Name = "Label5"
        Label5.Size = New Size(49, 25)
        Label5.TabIndex = 4
        Label5.Text = "Price"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(56, 191)
        Label6.Name = "Label6"
        Label6.Size = New Size(80, 25)
        Label6.TabIndex = 4
        Label6.Text = "Quantity"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(56, 240)
        Label7.Name = "Label7"
        Label7.Size = New Size(89, 25)
        Label7.TabIndex = 4
        Label7.Text = "Company"
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ActiveCaption
        Button2.Location = New Point(192, 361)
        Button2.Name = "Button2"
        Button2.Size = New Size(101, 60)
        Button2.TabIndex = 1
        Button2.Text = "Update"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.ActiveCaption
        Button3.Location = New Point(353, 361)
        Button3.Name = "Button3"
        Button3.Size = New Size(101, 60)
        Button3.TabIndex = 1
        Button3.Text = "Delete"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' productsform
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1289, 675)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(Panel1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "productsform"
        Text = "productsform"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
