Imports System.ComponentModel

Public Class TransactionForm
    <Browsable(False),
     DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property Products As List(Of ProductClass)


    Private Sub LoadComboBoxProducts()
        If Products Is Nothing Then Return

        comboBoxProduct.DisplayMember = "Name"   ' what user sees
        comboBoxProduct.ValueMember = "Id"       ' hidden internal value

        comboBoxProduct.DataSource = Products
    End Sub



    Private Sub TransactionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadComboBoxProducts()
    End Sub


    Private Sub UpdateGrandTotal()
        Dim sum As Decimal = 0D

        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(4).Value IsNot Nothing Then
                sum += Convert.ToDecimal(row.Cells(4).Value)
            End If
        Next

        labelTotalPrice.Text = sum.ToString("N0") ' formatted with thousands separator
    End Sub

    Private Sub dataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        If e.RowIndex < 0 Then Return

        ' If user edits the Qty column, update Total
        If DataGridView1.Columns(e.ColumnIndex).Name = "tableQty" Then
            Dim qty As Integer = Convert.ToInt32(DataGridView1.Rows(e.RowIndex).Cells("tableQty").Value)
            Dim price As Decimal = Convert.ToDecimal(DataGridView1.Rows(e.RowIndex).Cells("tablePrice").Value)

            DataGridView1.Rows(e.RowIndex).Cells(4).Value = qty * price
        End If

        UpdateGrandTotal()
    End Sub

    Private Sub dataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        UpdateGrandTotal()
    End Sub

    Private Sub dataGridView1_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles DataGridView1.RowsRemoved
        UpdateGrandTotal()
    End Sub



    Private Sub buttonAddItem_Click(sender As Object, e As EventArgs) Handles buttonAddItem.Click
        If comboBoxProduct.SelectedItem Is Nothing Then
            MessageBox.Show("Pilih produk terlebih dahulu.")
            Return
        End If

        Dim p As ProductClass = CType(comboBoxProduct.SelectedItem, ProductClass)

        ' Check if product already exists in datagrid
        Dim existingRow As DataGridViewRow = Nothing

        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells("tableId").Value?.ToString() = p.Id Then
                existingRow = row
                Exit For
            End If
        Next

        If existingRow IsNot Nothing Then
            ' Product already in grid → increase qty
            Dim currentQty As Integer = Convert.ToInt32(existingRow.Cells("tableQty").Value)
            Dim newQty As Integer = currentQty + 1

            existingRow.Cells("tableQty").Value = newQty
            existingRow.Cells("tableTotal").Value = p.Price * newQty
        Else
            ' Add new product row
            Dim qty As Integer = 1
            Dim total As Decimal = p.Price * qty

            DataGridView1.Rows.Add(
            p.Id,
            p.Name,
            p.Price,
            qty,
            total
        )
        End If
    End Sub

    Private Sub buttonReset_Click(sender As Object, e As EventArgs) Handles buttonReset.Click
        DataGridView1.Rows.Clear()
        labelTotalPrice.Text = "0"
    End Sub

    Private Sub buttonSave_Click(sender As Object, e As EventArgs) Handles buttonSave.Click
        Me.Close()

    End Sub
End Class