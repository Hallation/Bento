<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.cmbMeat = New System.Windows.Forms.ComboBox()
        Me.lstBento = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.lblMeatHeading = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblDelivery = New System.Windows.Forms.Label()
        Me.lblGST = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.cmbVegeta = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbSauce = New System.Windows.Forms.ComboBox()
        Me.cmbBase = New System.Windows.Forms.ComboBox()
        Me.cmbDessert = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.numBase = New System.Windows.Forms.NumericUpDown()
        Me.numDessert = New System.Windows.Forms.NumericUpDown()
        Me.numSauce = New System.Windows.Forms.NumericUpDown()
        Me.numMeat = New System.Windows.Forms.NumericUpDown()
        Me.numVegetable = New System.Windows.Forms.NumericUpDown()
        Me.chk2Box = New System.Windows.Forms.CheckBox()
        Me.btnReceipt = New System.Windows.Forms.Button()
        Me.tt = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.numBase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numDessert, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numSauce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMeat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numVegetable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbMeat
        '
        Me.cmbMeat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMeat.FormattingEnabled = True
        Me.cmbMeat.Location = New System.Drawing.Point(12, 26)
        Me.cmbMeat.Name = "cmbMeat"
        Me.cmbMeat.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbMeat.Size = New System.Drawing.Size(139, 21)
        Me.cmbMeat.TabIndex = 0
        '
        'lstBento
        '
        Me.lstBento.FormattingEnabled = True
        Me.lstBento.Location = New System.Drawing.Point(11, 161)
        Me.lstBento.Name = "lstBento"
        Me.lstBento.Size = New System.Drawing.Size(280, 95)
        Me.lstBento.TabIndex = 5
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(205, 300)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 30)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(205, 336)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 30)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(205, 372)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 30)
        Me.btnEdit.TabIndex = 8
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'lblMeatHeading
        '
        Me.lblMeatHeading.AutoSize = True
        Me.lblMeatHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMeatHeading.Location = New System.Drawing.Point(13, 7)
        Me.lblMeatHeading.Name = "lblMeatHeading"
        Me.lblMeatHeading.Size = New System.Drawing.Size(42, 16)
        Me.lblMeatHeading.TabIndex = 9
        Me.lblMeatHeading.Text = "Meat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 16)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Bento Box "
        '
        'lblWeight
        '
        Me.lblWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.Location = New System.Drawing.Point(216, 267)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(64, 28)
        Me.lblWeight.TabIndex = 31
        Me.lblWeight.Text = "0g"
        Me.lblWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(154, 272)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 16)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Weight: "
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(205, 408)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 30)
        Me.btnClear.TabIndex = 33
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 310)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Delivery: "
        '
        'lblDelivery
        '
        Me.lblDelivery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDelivery.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDelivery.Location = New System.Drawing.Point(83, 304)
        Me.lblDelivery.Name = "lblDelivery"
        Me.lblDelivery.Size = New System.Drawing.Size(64, 28)
        Me.lblDelivery.TabIndex = 35
        Me.lblDelivery.Text = "$0.00"
        Me.lblDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGST
        '
        Me.lblGST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGST.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGST.Location = New System.Drawing.Point(83, 376)
        Me.lblGST.Name = "lblGST"
        Me.lblGST.Size = New System.Drawing.Size(64, 28)
        Me.lblGST.TabIndex = 41
        Me.lblGST.Text = "$0.00"
        Me.lblGST.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 382)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 16)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "GST: "
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(83, 410)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(64, 28)
        Me.lblTotal.TabIndex = 43
        Me.lblTotal.Text = "$0.00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(13, 416)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 16)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "Total: "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(13, 346)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 16)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Sub-Total: "
        '
        'lblSubtotal
        '
        Me.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotal.Location = New System.Drawing.Point(83, 340)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(64, 28)
        Me.lblSubtotal.TabIndex = 39
        Me.lblSubtotal.Text = "$0.00"
        Me.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbVegeta
        '
        Me.cmbVegeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVegeta.FormattingEnabled = True
        Me.cmbVegeta.Location = New System.Drawing.Point(157, 26)
        Me.cmbVegeta.Name = "cmbVegeta"
        Me.cmbVegeta.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbVegeta.Size = New System.Drawing.Size(139, 21)
        Me.cmbVegeta.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(154, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Vegetable"
        '
        'cmbSauce
        '
        Me.cmbSauce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSauce.FormattingEnabled = True
        Me.cmbSauce.Location = New System.Drawing.Point(157, 67)
        Me.cmbSauce.Name = "cmbSauce"
        Me.cmbSauce.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbSauce.Size = New System.Drawing.Size(139, 21)
        Me.cmbSauce.TabIndex = 1
        '
        'cmbBase
        '
        Me.cmbBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBase.FormattingEnabled = True
        Me.cmbBase.Location = New System.Drawing.Point(12, 67)
        Me.cmbBase.Name = "cmbBase"
        Me.cmbBase.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbBase.Size = New System.Drawing.Size(139, 21)
        Me.cmbBase.TabIndex = 2
        '
        'cmbDessert
        '
        Me.cmbDessert.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDessert.FormattingEnabled = True
        Me.cmbDessert.Location = New System.Drawing.Point(85, 113)
        Me.cmbDessert.Name = "cmbDessert"
        Me.cmbDessert.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbDessert.Size = New System.Drawing.Size(139, 21)
        Me.cmbDessert.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Base"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(154, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 16)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Sauce"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(82, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 16)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Desserts"
        '
        'Timer1
        '
        '
        'numBase
        '
        Me.numBase.Location = New System.Drawing.Point(60, 48)
        Me.numBase.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numBase.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numBase.Name = "numBase"
        Me.numBase.Size = New System.Drawing.Size(45, 20)
        Me.numBase.TabIndex = 44
        Me.numBase.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'numDessert
        '
        Me.numDessert.Location = New System.Drawing.Point(157, 94)
        Me.numDessert.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numDessert.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numDessert.Name = "numDessert"
        Me.numDessert.Size = New System.Drawing.Size(45, 20)
        Me.numDessert.TabIndex = 45
        Me.numDessert.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'numSauce
        '
        Me.numSauce.Location = New System.Drawing.Point(212, 48)
        Me.numSauce.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numSauce.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numSauce.Name = "numSauce"
        Me.numSauce.Size = New System.Drawing.Size(45, 20)
        Me.numSauce.TabIndex = 46
        Me.numSauce.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'numMeat
        '
        Me.numMeat.Location = New System.Drawing.Point(60, 7)
        Me.numMeat.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numMeat.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numMeat.Name = "numMeat"
        Me.numMeat.Size = New System.Drawing.Size(45, 20)
        Me.numMeat.TabIndex = 47
        Me.numMeat.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'numVegetable
        '
        Me.numVegetable.Location = New System.Drawing.Point(238, 7)
        Me.numVegetable.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numVegetable.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numVegetable.Name = "numVegetable"
        Me.numVegetable.Size = New System.Drawing.Size(45, 20)
        Me.numVegetable.TabIndex = 48
        Me.numVegetable.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'chk2Box
        '
        Me.chk2Box.AutoSize = True
        Me.chk2Box.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk2Box.Location = New System.Drawing.Point(16, 270)
        Me.chk2Box.Name = "chk2Box"
        Me.chk2Box.Size = New System.Drawing.Size(89, 22)
        Me.chk2Box.TabIndex = 49
        Me.chk2Box.Text = "2 Boxes?"
        Me.chk2Box.UseVisualStyleBackColor = True
        '
        'btnReceipt
        '
        Me.btnReceipt.Location = New System.Drawing.Point(224, 136)
        Me.btnReceipt.Name = "btnReceipt"
        Me.btnReceipt.Size = New System.Drawing.Size(67, 22)
        Me.btnReceipt.TabIndex = 50
        Me.btnReceipt.Text = "Receipt"
        Me.btnReceipt.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 441)
        Me.Controls.Add(Me.btnReceipt)
        Me.Controls.Add(Me.chk2Box)
        Me.Controls.Add(Me.numVegetable)
        Me.Controls.Add(Me.numMeat)
        Me.Controls.Add(Me.numSauce)
        Me.Controls.Add(Me.numDessert)
        Me.Controls.Add(Me.numBase)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblGST)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblDelivery)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblMeatHeading)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lstBento)
        Me.Controls.Add(Me.cmbDessert)
        Me.Controls.Add(Me.cmbVegeta)
        Me.Controls.Add(Me.cmbBase)
        Me.Controls.Add(Me.cmbSauce)
        Me.Controls.Add(Me.cmbMeat)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Bento"
        CType(Me.numBase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numDessert, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numSauce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMeat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numVegetable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbMeat As System.Windows.Forms.ComboBox
    Friend WithEvents lstBento As System.Windows.Forms.ListBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents lblMeatHeading As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblWeight As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblDelivery As System.Windows.Forms.Label
    Friend WithEvents lblGST As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents cmbVegeta As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbSauce As System.Windows.Forms.ComboBox
    Friend WithEvents cmbBase As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDessert As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents numBase As System.Windows.Forms.NumericUpDown
    Friend WithEvents numDessert As System.Windows.Forms.NumericUpDown
    Friend WithEvents numSauce As System.Windows.Forms.NumericUpDown
    Friend WithEvents numMeat As System.Windows.Forms.NumericUpDown
    Friend WithEvents numVegetable As System.Windows.Forms.NumericUpDown
    Friend WithEvents chk2Box As System.Windows.Forms.CheckBox
    Friend WithEvents btnReceipt As System.Windows.Forms.Button
    Friend WithEvents tt As System.Windows.Forms.ToolTip

End Class
