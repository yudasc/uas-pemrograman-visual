Public Class Form1

    Private products As New List(Of ProductClass)



    Private Sub InitDummyProductForDebug()
        products.Add(New ProductClass With {.Id = "1", .Name = "Pencil", .Price = 1500, .Stock = 20})
        products.Add(New ProductClass With {.Id = "2", .Name = "Book", .Price = 5000, .Stock = 12})
        products.Add(New ProductClass With {.Id = "3", .Name = "Eraser", .Price = 1000, .Stock = 30})

    End Sub

    Private Sub LoadProducts(Optional list As List(Of ProductClass) = Nothing)
        dataGridProduct.Rows.Clear()

        Dim source = If(list Is Nothing, products, list)

        For Each p In source
            dataGridProduct.Rows.Add(p.Id, p.Name, p.Price, p.Stock)
        Next
    End Sub



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridProduct.CellContentClick

    End Sub

    Private Sub buttonAdd_Click(sender As Object, e As EventArgs) Handles buttonAdd.Click
        Dim f As New ProductMutationForm()

        If f.ShowDialog() = DialogResult.OK Then
            If f.ResultProduct IsNot Nothing Then
                products.Add(f.ResultProduct)
                LoadProducts()

            End If
        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitDummyProductForDebug()
        LoadProducts()

    End Sub

    Private Sub buttonDelete_Click(sender As Object, e As EventArgs) Handles buttonDelete.Click
        If dataGridProduct.CurrentRow Is Nothing Then
            MessageBox.Show("Pilih produk terlebih dahulu di tabel")
            Return
        End If


        Dim selectedId As String = dataGridProduct.CurrentRow.Cells("tableProductId").Value.ToString()
        Dim productName As String = dataGridProduct.CurrentRow.Cells("tableProductName").Value.ToString()

        Dim result = MessageBox.Show(
        $"Hapus '{productName}'?",
        "Hapus",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning
    )

        If result = DialogResult.No Then
            Return
        End If


        Dim itemToRemove = products.FirstOrDefault(Function(p) p.Id = selectedId)
        If itemToRemove IsNot Nothing Then
            products.Remove(itemToRemove)
            LoadProducts()
        End If
    End Sub

    Private Sub buttonEdit_Click(sender As Object, e As EventArgs) Handles buttonEdit.Click
        Dim row = dataGridProduct.CurrentRow
        If row Is Nothing Then
            MessageBox.Show("Pilih produk dulu")
            Return
        End If

        Dim selectedId As String = row.Cells(0).Value.ToString()

        Dim selectedProduct = products.FirstOrDefault(Function(p) p.Id = selectedId)
        If selectedProduct Is Nothing Then
            MessageBox.Show("Produk tidak ditemukan.")
            Return
        End If

        Dim f As New ProductMutationForm(selectedProduct)
        If f.ShowDialog() = DialogResult.OK Then
            LoadProducts()
        End If
    End Sub

    Private Sub textBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles textBoxSearch.TextChanged
        Dim q = textBoxSearch.Text.Trim().ToLower()

        If q = "" Then
            LoadProducts()
            Return
        End If

        Dim filtered = products.Where(Function(p)
                                          Return p.Id.ToLower().Contains(q) _
                                              Or p.Name.ToLower().Contains(q)
                                      End Function).ToList()

        LoadProducts(filtered)
    End Sub

    Private Sub buttonTransaction_Click(sender As Object, e As EventArgs) Handles buttonTransaction.Click
        Dim f As New TransactionForm()
        f.Products = Me.products
        f.ShowDialog()
    End Sub

    Private Sub ButtonImportCSV_Click(sender As Object, e As EventArgs) Handles ButtonImportCSV.Click
        Using ofd As New OpenFileDialog()
            ofd.Title = "Pilih file CSV"
            ofd.Filter = "CSV Files (*.csv)|*.csv" 'ini utk filter
            ofd.Multiselect = False

            If ofd.ShowDialog() = DialogResult.OK Then
                Dim selectedFile As String = ofd.FileName
                MessageBox.Show("File terpilih: " & selectedFile)


                Dim tempProducts As New List(Of ProductClass)

                Dim lines = IO.File.ReadAllLines(selectedFile)


                ' skip headernya
                For i As Integer = 1 To lines.Length - 1
                    Dim parts = lines(i).Split(","c)

                    Dim p As New ProductClass With {
                        .Id = parts(0),
                        .Name = parts(1),
                        .Price = Decimal.Parse(parts(2)),
                        .Stock = Integer.Parse(parts(3))
                    }

                    tempProducts.Add(p)
                Next


                For Each newProduct In tempProducts
                    Dim existing = products.FirstOrDefault(Function(x) x.Id = newProduct.Id)

                    If existing IsNot Nothing Then
                        existing.Name = newProduct.Name
                        existing.Price = newProduct.Price
                        existing.Stock = newProduct.Stock
                    Else
                        products.Add(newProduct)
                    End If
                Next


                LoadProducts()


            End If
        End Using


    End Sub
End Class
