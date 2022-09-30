<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Product
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtprodid = New System.Windows.Forms.TextBox()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtprodname = New System.Windows.Forms.TextBox()
        Me.txtquantity = New System.Windows.Forms.TextBox()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.cmbcatagory = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Indigo
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 693)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1032, 10)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Indigo
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1032, 66)
        Me.Panel2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(410, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 28)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Manage Products"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(289, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(430, 38)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Inventory Management System"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(193, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "prodID"
        '
        'txtprodid
        '
        Me.txtprodid.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtprodid.Location = New System.Drawing.Point(311, 137)
        Me.txtprodid.Name = "txtprodid"
        Me.txtprodid.Size = New System.Drawing.Size(72, 30)
        Me.txtprodid.TabIndex = 3
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.Coral
        Me.btnadd.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnadd.ForeColor = System.Drawing.SystemColors.Control
        Me.btnadd.Location = New System.Drawing.Point(808, 107)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(94, 33)
        Me.btnadd.TabIndex = 4
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.Coral
        Me.btnedit.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnedit.ForeColor = System.Drawing.SystemColors.Control
        Me.btnedit.Location = New System.Drawing.Point(808, 162)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(94, 33)
        Me.btnedit.TabIndex = 5
        Me.btnedit.Text = "EDIT"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.Coral
        Me.btndelete.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btndelete.ForeColor = System.Drawing.SystemColors.Control
        Me.btndelete.Location = New System.Drawing.Point(808, 213)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(94, 33)
        Me.btndelete.TabIndex = 6
        Me.btndelete.Text = "DELETE"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.Color.Coral
        Me.btnclear.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnclear.ForeColor = System.Drawing.SystemColors.Control
        Me.btnclear.Location = New System.Drawing.Point(808, 262)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(94, 33)
        Me.btnclear.TabIndex = 7
        Me.btnclear.Text = "CLEAR"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(410, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "prodName"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(193, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 25)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Quantity"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(193, 240)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 25)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Price"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(410, 189)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 25)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Catagory"
        '
        'txtprodname
        '
        Me.txtprodname.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtprodname.Location = New System.Drawing.Point(546, 133)
        Me.txtprodname.Name = "txtprodname"
        Me.txtprodname.Size = New System.Drawing.Size(144, 30)
        Me.txtprodname.TabIndex = 12
        '
        'txtquantity
        '
        Me.txtquantity.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtquantity.Location = New System.Drawing.Point(311, 189)
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.Size = New System.Drawing.Size(72, 30)
        Me.txtquantity.TabIndex = 13
        '
        'txtprice
        '
        Me.txtprice.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtprice.Location = New System.Drawing.Point(311, 240)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(72, 30)
        Me.txtprice.TabIndex = 14
        '
        'cmbcatagory
        '
        Me.cmbcatagory.FormattingEnabled = True
        Me.cmbcatagory.Items.AddRange(New Object() {"Electronics", "Garments", "Sports "})
        Me.cmbcatagory.Location = New System.Drawing.Point(546, 186)
        Me.cmbcatagory.Name = "cmbcatagory"
        Me.cmbcatagory.Size = New System.Drawing.Size(144, 28)
        Me.cmbcatagory.TabIndex = 16
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Blue
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button4.ForeColor = System.Drawing.SystemColors.Control
        Me.Button4.Location = New System.Drawing.Point(483, 654)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(94, 33)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "Home"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(433, 369)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 28)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Products List"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(54, 400)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(898, 238)
        Me.DataGridView1.TabIndex = 19
        '
        'Product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1032, 703)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.cmbcatagory)
        Me.Controls.Add(Me.txtprice)
        Me.Controls.Add(Me.txtquantity)
        Me.Controls.Add(Me.txtprodname)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.txtprodid)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Product"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtprodid As TextBox
    Friend WithEvents btnadd As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtprodname As TextBox
    Friend WithEvents txtquantity As TextBox
    Friend WithEvents txtprice As TextBox
    Friend WithEvents cmbcatagory As ComboBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
