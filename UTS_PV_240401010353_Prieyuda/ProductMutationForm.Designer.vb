<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductMutationForm
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        textBoxProductName = New TextBox()
        textBoxProductPrice = New TextBox()
        textBoxProductStock = New TextBox()
        buttonProductSave = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(34, 60)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 15)
        Label1.TabIndex = 0
        Label1.Text = "Nama produk"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(34, 98)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 15)
        Label2.TabIndex = 1
        Label2.Text = "Harga produk"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(34, 132)
        Label3.Name = "Label3"
        Label3.Size = New Size(30, 15)
        Label3.TabIndex = 2
        Label3.Text = "Stok"
        ' 
        ' textBoxProductName
        ' 
        textBoxProductName.Location = New Point(129, 57)
        textBoxProductName.Name = "textBoxProductName"
        textBoxProductName.Size = New Size(407, 23)
        textBoxProductName.TabIndex = 3
        ' 
        ' textBoxProductPrice
        ' 
        textBoxProductPrice.Location = New Point(129, 95)
        textBoxProductPrice.Name = "textBoxProductPrice"
        textBoxProductPrice.Size = New Size(407, 23)
        textBoxProductPrice.TabIndex = 4
        ' 
        ' textBoxProductStock
        ' 
        textBoxProductStock.Location = New Point(129, 129)
        textBoxProductStock.Name = "textBoxProductStock"
        textBoxProductStock.Size = New Size(407, 23)
        textBoxProductStock.TabIndex = 5
        ' 
        ' buttonProductSave
        ' 
        buttonProductSave.Location = New Point(461, 202)
        buttonProductSave.Name = "buttonProductSave"
        buttonProductSave.Size = New Size(75, 23)
        buttonProductSave.TabIndex = 6
        buttonProductSave.Text = "Simpan"
        buttonProductSave.UseVisualStyleBackColor = True
        ' 
        ' ProductMutationForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(574, 237)
        Controls.Add(buttonProductSave)
        Controls.Add(textBoxProductStock)
        Controls.Add(textBoxProductPrice)
        Controls.Add(textBoxProductName)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "ProductMutationForm"
        Text = "ProductMutationForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents textBoxProductName As TextBox
    Friend WithEvents textBoxProductPrice As TextBox
    Friend WithEvents textBoxProductStock As TextBox
    Friend WithEvents buttonProductSave As Button
End Class
