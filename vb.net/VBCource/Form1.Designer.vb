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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GeneratedList = New System.Windows.Forms.ListBox()
        Me.SortedList = New System.Windows.Forms.ListBox()
        Me.GenerateButton = New System.Windows.Forms.Button()
        Me.NumberCount = New System.Windows.Forms.TextBox()
        Me.SortButton = New System.Windows.Forms.Button()
        Me.UpDimension = New System.Windows.Forms.RadioButton()
        Me.DownDimension = New System.Windows.Forms.RadioButton()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ElapsedTime = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ProgrammAbout = New System.Windows.Forms.Button()
        Me.AuthorAbout = New System.Windows.Forms.Button()
        Me.SaveToFile = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout
        Me.SuspendLayout
        '
        'GeneratedList
        '
        Me.GeneratedList.FormattingEnabled = true
        Me.GeneratedList.ItemHeight = 16
        Me.GeneratedList.Location = New System.Drawing.Point(12, 31)
        Me.GeneratedList.Name = "GeneratedList"
        Me.GeneratedList.Size = New System.Drawing.Size(170, 404)
        Me.GeneratedList.TabIndex = 0
        '
        'SortedList
        '
        Me.SortedList.FormattingEnabled = true
        Me.SortedList.ItemHeight = 16
        Me.SortedList.Location = New System.Drawing.Point(374, 31)
        Me.SortedList.Name = "SortedList"
        Me.SortedList.Size = New System.Drawing.Size(170, 404)
        Me.SortedList.TabIndex = 1
        '
        'GenerateButton
        '
        Me.GenerateButton.Location = New System.Drawing.Point(22, 70)
        Me.GenerateButton.Name = "GenerateButton"
        Me.GenerateButton.Size = New System.Drawing.Size(137, 50)
        Me.GenerateButton.TabIndex = 2
        Me.GenerateButton.Text = "Исходные"
        Me.GenerateButton.UseVisualStyleBackColor = true
        '
        'NumberCount
        '
        Me.NumberCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14!)
        Me.NumberCount.Location = New System.Drawing.Point(73, 21)
        Me.NumberCount.Name = "NumberCount"
        Me.NumberCount.Size = New System.Drawing.Size(86, 34)
        Me.NumberCount.TabIndex = 3
        '
        'SortButton
        '
        Me.SortButton.Location = New System.Drawing.Point(22, 271)
        Me.SortButton.Name = "SortButton"
        Me.SortButton.Size = New System.Drawing.Size(137, 50)
        Me.SortButton.TabIndex = 5
        Me.SortButton.Text = "Сортировать"
        Me.SortButton.UseVisualStyleBackColor = true
        '
        'UpDimension
        '
        Me.UpDimension.AutoSize = true
        Me.UpDimension.Checked = true
        Me.UpDimension.Location = New System.Drawing.Point(22, 205)
        Me.UpDimension.Name = "UpDimension"
        Me.UpDimension.Size = New System.Drawing.Size(137, 21)
        Me.UpDimension.TabIndex = 6
        Me.UpDimension.TabStop = true
        Me.UpDimension.Text = "По возрастанию"
        Me.UpDimension.UseVisualStyleBackColor = true
        '
        'DownDimension
        '
        Me.DownDimension.AutoSize = true
        Me.DownDimension.Location = New System.Drawing.Point(22, 232)
        Me.DownDimension.Name = "DownDimension"
        Me.DownDimension.Size = New System.Drawing.Size(117, 21)
        Me.DownDimension.TabIndex = 7
        Me.DownDimension.Text = "По убыванию"
        Me.DownDimension.UseVisualStyleBackColor = true
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(22, 136)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(137, 50)
        Me.ClearButton.TabIndex = 8
        Me.ClearButton.Text = "Очистить"
        Me.ClearButton.UseVisualStyleBackColor = true
        '
        'ElapsedTime
        '
        Me.ElapsedTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 14!)
        Me.ElapsedTime.Location = New System.Drawing.Point(22, 343)
        Me.ElapsedTime.Name = "ElapsedTime"
        Me.ElapsedTime.Size = New System.Drawing.Size(137, 34)
        Me.ElapsedTime.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11!)
        Me.Label1.Location = New System.Drawing.Point(22, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "N = "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NumberCount)
        Me.GroupBox1.Controls.Add(Me.ElapsedTime)
        Me.GroupBox1.Controls.Add(Me.GenerateButton)
        Me.GroupBox1.Controls.Add(Me.ClearButton)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DownDimension)
        Me.GroupBox1.Controls.Add(Me.SortButton)
        Me.GroupBox1.Controls.Add(Me.UpDimension)
        Me.GroupBox1.Location = New System.Drawing.Point(188, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(180, 400)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = false
        '
        'ProgrammAbout
        '
        Me.ProgrammAbout.Image = CType(resources.GetObject("ProgrammAbout.Image"),System.Drawing.Image)
        Me.ProgrammAbout.Location = New System.Drawing.Point(12, 441)
        Me.ProgrammAbout.Name = "ProgrammAbout"
        Me.ProgrammAbout.Size = New System.Drawing.Size(128, 100)
        Me.ProgrammAbout.TabIndex = 11
        Me.ProgrammAbout.Text = "О программе"
        Me.ProgrammAbout.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ProgrammAbout.UseVisualStyleBackColor = true
        '
        'AuthorAbout
        '
        Me.AuthorAbout.Image = CType(resources.GetObject("AuthorAbout.Image"),System.Drawing.Image)
        Me.AuthorAbout.Location = New System.Drawing.Point(146, 441)
        Me.AuthorAbout.Name = "AuthorAbout"
        Me.AuthorAbout.Size = New System.Drawing.Size(128, 100)
        Me.AuthorAbout.TabIndex = 12
        Me.AuthorAbout.Text = "Об авторе"
        Me.AuthorAbout.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AuthorAbout.UseVisualStyleBackColor = true
        '
        'SaveToFile
        '
        Me.SaveToFile.Image = CType(resources.GetObject("SaveToFile.Image"),System.Drawing.Image)
        Me.SaveToFile.Location = New System.Drawing.Point(280, 441)
        Me.SaveToFile.Name = "SaveToFile"
        Me.SaveToFile.Size = New System.Drawing.Size(128, 100)
        Me.SaveToFile.TabIndex = 13
        Me.SaveToFile.Text = "В файл"
        Me.SaveToFile.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SaveToFile.UseVisualStyleBackColor = true
        '
        'ExitButton
        '
        Me.ExitButton.Image = CType(resources.GetObject("ExitButton.Image"),System.Drawing.Image)
        Me.ExitButton.Location = New System.Drawing.Point(414, 441)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(128, 100)
        Me.ExitButton.TabIndex = 14
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ExitButton.UseVisualStyleBackColor = true
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(9, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Исходные данные"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(371, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 17)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Данные с сортировкой"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 563)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.SaveToFile)
        Me.Controls.Add(Me.AuthorAbout)
        Me.Controls.Add(Me.ProgrammAbout)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SortedList)
        Me.Controls.Add(Me.GeneratedList)
        Me.Name = "Form1"
        Me.Text = "Сортировка числовых данных методом подсчета"
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents GeneratedList As ListBox
    Friend WithEvents SortedList As ListBox
    Friend WithEvents GenerateButton As Button
    Friend WithEvents NumberCount As TextBox
    Friend WithEvents SortButton As Button
    Friend WithEvents UpDimension As RadioButton
    Friend WithEvents DownDimension As RadioButton
    Friend WithEvents ClearButton As Button
    Friend WithEvents ElapsedTime As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ProgrammAbout As Button
    Friend WithEvents AuthorAbout As Button
    Friend WithEvents SaveToFile As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
