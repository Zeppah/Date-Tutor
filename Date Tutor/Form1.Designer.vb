<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DateTimePicker1.CustomFormat = "MM yyyy dd HH:mm"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(2, 31)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.ShowUpDown = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(771, 26)
        Me.DateTimePicker1.TabIndex = 0
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Items.AddRange(New Object() {"d", "dd", "ddd", "dddd", "h", "hh", "H", "HH", "m", "mm", "M", "MM", "MMM", "MMMM", "s", "ss", "t", "tt", "y", "yy", "yyyy"})
        Me.ListBox1.Location = New System.Drawing.Point(779, 33)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(89, 24)
        Me.ListBox1.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(2, 1)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(866, 26)
        Me.TextBox1.TabIndex = 2
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(279, 151)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(263, 20)
        Me.MaskedTextBox1.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 450)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
End Class
