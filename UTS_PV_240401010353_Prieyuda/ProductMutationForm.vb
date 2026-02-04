Public Class ProductMutationForm
    Public Property ResultProduct As ProductClass = Nothing

    Public Sub New(Optional product As ProductClass = Nothing)
        InitializeComponent()
        ResultProduct = product
    End Sub

    Private Sub ProductMutationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ResultProduct IsNot Nothing Then
            textBoxProductName.Text = ResultProduct.Name
            textBoxProductPrice.Text = ResultProduct.Price.ToString()
            textBoxProductStock.Text = ResultProduct.Stock.ToString()
        End If
    End Sub

    Private Sub buttonProductSave_Click(sender As Object, e As EventArgs) Handles buttonProductSave.Click

        Dim name = textBoxProductName.Text.Trim()
        Dim price = Decimal.Parse(textBoxProductPrice.Text.Trim())
        Dim stock = Integer.Parse(textBoxProductStock.Text.Trim())

        If ResultProduct Is Nothing Then
            ResultProduct = New ProductClass With {
            .Id = RandomUtil.GenerateId(),
            .Name = name,
            .Price = price,
            .Stock = stock
        }
        Else
            ResultProduct.Name = name
            ResultProduct.Price = price
            ResultProduct.Stock = stock
        End If

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class