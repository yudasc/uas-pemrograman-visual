<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        buttonAdd = New Button()
        buttonEdit = New Button()
        buttonDelete = New Button()
        buttonTransaction = New Button()
        textBoxSearch = New TextBox()
        dataGridProduct = New DataGridView()
        tableProductId = New DataGridViewTextBoxColumn()
        tableProductName = New DataGridViewTextBoxColumn()
        tableProductPrice = New DataGridViewTextBoxColumn()
        tableProductStock = New DataGridViewTextBoxColumn()
        ButtonImportCSV = New Button()
        CType(dataGridProduct, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' buttonAdd
        ' 
        buttonAdd.Location = New Point(12, 537)
        buttonAdd.Name = "buttonAdd"
        buttonAdd.Size = New Size(124, 23)
        buttonAdd.TabIndex = 0
        buttonAdd.Text = "Tambah produk"
        buttonAdd.UseVisualStyleBackColor = True
        ' 
        ' buttonEdit
        ' 
        buttonEdit.Location = New Point(142, 537)
        buttonEdit.Name = "buttonEdit"
        buttonEdit.Size = New Size(126, 23)
        buttonEdit.TabIndex = 1
        buttonEdit.Text = "Edit produk"
        buttonEdit.UseVisualStyleBackColor = True
        ' 
        ' buttonDelete
        ' 
        buttonDelete.Location = New Point(274, 537)
        buttonDelete.Name = "buttonDelete"
        buttonDelete.Size = New Size(75, 23)
        buttonDelete.TabIndex = 2
        buttonDelete.Text = "Hapus produk"
        buttonDelete.UseVisualStyleBackColor = True
        ' 
        ' buttonTransaction
        ' 
        buttonTransaction.Location = New Point(768, 537)
        buttonTransaction.Name = "buttonTransaction"
        buttonTransaction.Size = New Size(75, 23)
        buttonTransaction.TabIndex = 3
        buttonTransaction.Text = "Transaksi"
        buttonTransaction.UseVisualStyleBackColor = True
        ' 
        ' textBoxSearch
        ' 
        textBoxSearch.Location = New Point(12, 24)
        textBoxSearch.Name = "textBoxSearch"
        textBoxSearch.PlaceholderText = "Cari produk..."
        textBoxSearch.Size = New Size(363, 23)
        textBoxSearch.TabIndex = 4
        ' 
        ' dataGridProduct
        ' 
        dataGridProduct.AllowUserToAddRows = False
        dataGridProduct.AllowUserToDeleteRows = False
        dataGridProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataGridProduct.Columns.AddRange(New DataGridViewColumn() {tableProductId, tableProductName, tableProductPrice, tableProductStock})
        dataGridProduct.Location = New Point(12, 64)
        dataGridProduct.Name = "dataGridProduct"
        dataGridProduct.ReadOnly = True
        dataGridProduct.Size = New Size(831, 452)
        dataGridProduct.TabIndex = 5
        ' 
        ' tableProductId
        ' 
        tableProductId.HeaderText = "No."
        tableProductId.Name = "tableProductId"
        tableProductId.ReadOnly = True
        ' 
        ' tableProductName
        ' 
        tableProductName.HeaderText = "Nama produk"
        tableProductName.Name = "tableProductName"
        tableProductName.ReadOnly = True
        ' 
        ' tableProductPrice
        ' 
        tableProductPrice.HeaderText = "Harga produk"
        tableProductPrice.Name = "tableProductPrice"
        tableProductPrice.ReadOnly = True
        ' 
        ' tableProductStock
        ' 
        tableProductStock.HeaderText = "Stok"
        tableProductStock.Name = "tableProductStock"
        tableProductStock.ReadOnly = True
        ' 
        ' ButtonImportCSV
        ' 
        ButtonImportCSV.Location = New Point(768, 24)
        ButtonImportCSV.Name = "ButtonImportCSV"
        ButtonImportCSV.Size = New Size(75, 23)
        ButtonImportCSV.TabIndex = 6
        ButtonImportCSV.Text = "Import CSV"
        ButtonImportCSV.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(855, 572)
        Controls.Add(ButtonImportCSV)
        Controls.Add(dataGridProduct)
        Controls.Add(textBoxSearch)
        Controls.Add(buttonTransaction)
        Controls.Add(buttonDelete)
        Controls.Add(buttonEdit)
        Controls.Add(buttonAdd)
        Name = "Form1"
        Text = "Form1"
        CType(dataGridProduct, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents buttonAdd As Button
    Friend WithEvents buttonEdit As Button
    Friend WithEvents buttonDelete As Button
    Friend WithEvents buttonTransaction As Button
    Friend WithEvents textBoxSearch As TextBox
    Friend WithEvents dataGridProduct As DataGridView
    Friend WithEvents tableProductId As DataGridViewTextBoxColumn
    Friend WithEvents tableProductName As DataGridViewTextBoxColumn
    Friend WithEvents tableProductPrice As DataGridViewTextBoxColumn
    Friend WithEvents tableProductStock As DataGridViewTextBoxColumn
    Friend WithEvents ButtonImportCSV As Button

End Class
