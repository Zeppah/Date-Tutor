Public Class Form1

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        DateTimePicker1.CustomFormat = ListBox1.SelectedItem.ToString
        TextBox1.Text = DateTimePicker1.Text
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        TextBox1.Text = CDate(DateTimePicker1.Text).ToString
    End Sub

End Class
