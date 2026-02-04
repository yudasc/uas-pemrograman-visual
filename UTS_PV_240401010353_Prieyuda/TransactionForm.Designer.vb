<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransactionForm
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
        Panel1 = New Panel()
        labelTotalPrice = New Label()
        Label2 = New Label()
        DataGridView1 = New DataGridView()
        tableId = New DataGridViewTextBoxColumn()
        tableName = New DataGridViewTextBoxColumn()
        tablePrice = New DataGridViewTextBoxColumn()
        tableQty = New DataGridViewTextBoxColumn()
        tableTotal = New DataGridViewTextBoxColumn()
        buttonSave = New Button()
        buttonReset = New Button()
        buttonAddItem = New Button()
        comboBoxProduct = New ComboBox()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Info
        Panel1.Controls.Add(labelTotalPrice)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(406, 23)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(382, 100)
        Panel1.TabIndex = 2
        ' 
        ' labelTotalPrice
        ' 
        labelTotalPrice.AutoSize = True
        labelTotalPrice.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelTotalPrice.Location = New Point(3, 54)
        labelTotalPrice.Name = "labelTotalPrice"
        labelTotalPrice.Size = New Size(156, 30)
        labelTotalPrice.TabIndex = 1
        labelTotalPrice.Text = "labelTotalPrice"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(3, 6)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 25)
        Label2.TabIndex = 0
        Label2.Text = "TOTAL"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {tableId, tableName, tablePrice, tableQty, tableTotal})
        DataGridView1.Location = New Point(17, 129)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(771, 252)
        DataGridView1.TabIndex = 3
        ' 
        ' tableId
        ' 
        tableId.HeaderText = "ID"
        tableId.Name = "tableId"
        tableId.ReadOnly = True
        ' 
        ' tableName
        ' 
        tableName.HeaderText = "Nama produk"
        tableName.Name = "tableName"
        tableName.ReadOnly = True
        ' 
        ' tablePrice
        ' 
        tablePrice.HeaderText = "Harga"
        tablePrice.Name = "tablePrice"
        tablePrice.ReadOnly = True
        ' 
        ' tableQty
        ' 
        tableQty.HeaderText = "Qty"
        tableQty.Name = "tableQty"
        ' 
        ' tableTotal
        ' 
        tableTotal.HeaderText = "Total"
        tableTotal.Name = "tableTotal"
        tableTotal.ReadOnly = True
        ' 
        ' buttonSave
        ' 
        buttonSave.Location = New Point(713, 387)
        buttonSave.Name = "buttonSave"
        buttonSave.Size = New Size(75, 23)
        buttonSave.TabIndex = 4
        buttonSave.Text = "Simpan"
        buttonSave.UseVisualStyleBackColor = True
        ' 
        ' buttonReset
        ' 
        buttonReset.Location = New Point(632, 387)
        buttonReset.Name = "buttonReset"
        buttonReset.Size = New Size(75, 23)
        buttonReset.TabIndex = 5
        buttonReset.Text = "Reset"
        buttonReset.UseVisualStyleBackColor = True
        ' 
        ' buttonAddItem
        ' 
        buttonAddItem.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        buttonAddItem.Location = New Point(308, 97)
        buttonAddItem.Name = "buttonAddItem"
        buttonAddItem.Size = New Size(75, 24)
        buttonAddItem.TabIndex = 7
        buttonAddItem.Text = "+"
        buttonAddItem.UseVisualStyleBackColor = True
        ' 
        ' comboBoxProduct
        ' 
        comboBoxProduct.FormattingEnabled = True
        comboBoxProduct.Location = New Point(17, 99)
        comboBoxProduct.Name = "comboBoxProduct"
        comboBoxProduct.Size = New Size(285, 23)
        comboBoxProduct.TabIndex = 8
        ' 
        ' TransactionForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(comboBoxProduct)
        Controls.Add(buttonAddItem)
        Controls.Add(buttonReset)
        Controls.Add(buttonSave)
        Controls.Add(DataGridView1)
        Controls.Add(Panel1)
        Name = "TransactionForm"
        Text = "TransactionForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents labelTotalPrice As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents buttonSave As Button
    Friend WithEvents buttonReset As Button
    Friend WithEvents buttonAddItem As Button
    Friend WithEvents comboBoxProduct As ComboBox
    Friend WithEvents tableId As DataGridViewTextBoxColumn
    Friend WithEvents tableName As DataGridViewTextBoxColumn
    Friend WithEvents tablePrice As DataGridViewTextBoxColumn
    Friend WithEvents tableQty As DataGridViewTextBoxColumn
    Friend WithEvents tableTotal As DataGridViewTextBoxColumn
End Class
