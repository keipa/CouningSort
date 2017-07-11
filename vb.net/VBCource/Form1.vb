Imports System.IO

Public Class Form1

    Public Count = 1000

    Private Sub GenerateArray(sender As Object, e As EventArgs) Handles GenerateButton.Click
        GeneratedList.Items.Clear()
        Dim random = New Random()
        Dim arrayLength = 0
        If NumberCount.Text.Length = 0 Then
            MsgBox("Введите N!")
        ElseIf Integer.TryParse(NumberCount.Text, arrayLength) = False Then
            MsgBox("Неверный формат ввода числа!")
        ElseIf Integer.Parse(NumberCount.Text) > 100000 Then
            MsgBox("Слишком большое значение N!")
        Else
            For i = 0 To arrayLength - 1
                GeneratedList.Items.Add(random.Next(1, Count))
            Next
        End If
    End Sub

    Private Sub SortArray(sender As Object, e As EventArgs) Handles SortButton.Click
        Dim array = New List(Of Integer)
        For Each item In GeneratedList.Items
            array.Add(Integer.Parse(item))
        Next
        Dim dimension = UpDimension.Checked = True
        StartSorting(array, dimension)
        SortedList.Items.Clear()
        For Each i In array
            SortedList.Items.Add(i)
        Next
    End Sub

    Private Sub StartSorting(dataset As List(Of Integer), flag As Boolean)
        Dim stopWatch = New Stopwatch()
        stopWatch.Start()
        CountingSort(dataset, flag)
        stopWatch.Stop()
        WriteSortResults(Double.Parse(stopWatch.Elapsed.TotalMilliseconds))
    End Sub

    Private Sub WriteSortResults(milliseconds As Double)
        ElapsedTime.Text = [String].Format("t = {0} s", milliseconds)
    End Sub

    Private Shared Sub CountingSort(dataset As List(Of Integer), flag As Boolean)
        Dim max As Integer
        max = dataset.Max
        Dim zerolist As New List(Of Integer)
        For index = 1 To max
            zerolist.Add(0)
        Next
        For i = 0 To dataset.Count - 1
            zerolist(dataset(i) - 1) += 1
        Next
        Dim b As Integer
        For j = 0 To max - 1
            For i = 0 To zerolist(j) - 1
                dataset(b) = j + 1
                b += 1
            Next
        Next
        If Not flag Then
            dataset.Reverse()
        End If
    End Sub

    Private Shared Function GetBoolean(index As Integer, newIndex As Integer, flag As Boolean) As Boolean
        If (flag) Then
            Return index <= newIndex
        Else
            Return index > newIndex
        End If
    End Function

    Private Sub ClearAll(sender As Object, e As EventArgs) Handles ClearButton.Click
        GeneratedList.Items.Clear()
        SortedList.Items.Clear()
    End Sub

    Private Shared Sub ExitProgram(sender As Object, e As EventArgs) Handles ExitButton.Click
        Application.Exit()
    End Sub

    Private Sub SaveResultsToFile(sender As Object, e As EventArgs) Handles SaveToFile.Click
        If SortedList.Items.Count = 0 Then
            MsgBox("Отсортируйте массив для сохранения данных!")
            Return
        End If
        Dim saveFileDialog = New SaveFileDialog()
        saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            SaveFileByStream(saveFileDialog)
        End If
    End Sub

    Private Sub SaveFileByStream(saveFileDialog As SaveFileDialog)
        Dim stream = saveFileDialog.OpenFile()
        If Not IsNothing(stream) Then
            Using streamWriter As New StreamWriter(stream)
                For Each item In SortedList.Items
                    streamWriter.WriteLine(item)
                    streamWriter.Flush()
                Next
            End Using
        End If
    End Sub

    Private Shared Sub ProgrammAboutDialog(sender As Object, e As EventArgs) Handles ProgrammAbout.Click
        Dim dialog = New AboutProgram()
        dialog.ShowDialog()
    End Sub

    Private Shared Sub AuthorAboutDialog(sender As Object, e As EventArgs) Handles AuthorAbout.Click
        Dim dialog = New AboutAuthor()
        dialog.ShowDialog()
    End Sub
End Class
