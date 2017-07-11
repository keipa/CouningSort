VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Сортировка числовых данных методом подсчёта"
   ClientHeight    =   5640
   ClientLeft      =   4995
   ClientTop       =   1590
   ClientWidth     =   5625
   LinkTopic       =   "Form1"
   ScaleHeight     =   5299.02
   ScaleMode       =   0  'User
   ScaleWidth      =   4707.969
   Begin VB.CommandButton Command7 
      Caption         =   "Exit"
      Height          =   1215
      Left            =   4320
      Picture         =   "Form1.frx":0000
      Style           =   1  'Graphical
      TabIndex        =   14
      Top             =   4200
      Width           =   1215
   End
   Begin VB.CommandButton Command6 
      Caption         =   "В файл"
      Height          =   1215
      Left            =   2880
      Picture         =   "Form1.frx":0456
      Style           =   1  'Graphical
      TabIndex        =   13
      Top             =   4200
      Width           =   1335
   End
   Begin VB.CommandButton Command5 
      Caption         =   "Об авторе"
      Height          =   1215
      Left            =   1440
      Picture         =   "Form1.frx":0898
      Style           =   1  'Graphical
      TabIndex        =   12
      Top             =   4200
      Width           =   1335
   End
   Begin VB.CommandButton Command4 
      Caption         =   "О программе"
      Height          =   1215
      Left            =   120
      Picture         =   "Form1.frx":0D01
      Style           =   1  'Graphical
      TabIndex        =   11
      Top             =   4200
      Width           =   1215
   End
   Begin VB.TextBox ElapsedTime 
      Height          =   285
      Left            =   2160
      TabIndex        =   10
      Top             =   3720
      Width           =   1335
   End
   Begin VB.TextBox NumberCount 
      Height          =   285
      Left            =   2520
      TabIndex        =   9
      Top             =   480
      Width           =   975
   End
   Begin VB.OptionButton DownDimension 
      Caption         =   "По убыванию"
      Height          =   255
      Left            =   2040
      TabIndex        =   8
      Top             =   2640
      Width           =   1575
   End
   Begin VB.OptionButton UpDimension 
      Caption         =   "По возрастанию"
      Height          =   255
      Left            =   2040
      TabIndex        =   7
      Top             =   2280
      Value           =   -1  'True
      Width           =   1575
   End
   Begin VB.CommandButton Command3 
      Caption         =   "Сортировать"
      Height          =   495
      Left            =   2160
      TabIndex        =   6
      Top             =   3120
      Width           =   1335
   End
   Begin VB.CommandButton Command2 
      Caption         =   "Исходные"
      Height          =   495
      Left            =   2160
      TabIndex        =   5
      Top             =   960
      Width           =   1335
   End
   Begin VB.ListBox SortedList 
      Height          =   3570
      Left            =   3840
      TabIndex        =   4
      Top             =   480
      Width           =   1695
   End
   Begin VB.ListBox GeneratedList 
      Height          =   3570
      Left            =   120
      TabIndex        =   3
      Top             =   480
      Width           =   1695
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Очистить"
      Height          =   495
      Left            =   2160
      TabIndex        =   0
      Top             =   1560
      Width           =   1335
   End
   Begin VB.PictureBox CommonDialogBox 
      Height          =   480
      Left            =   360
      ScaleHeight     =   420
      ScaleWidth      =   1140
      TabIndex        =   15
      Top             =   840
      Width           =   1200
   End
   Begin VB.Frame Frame1 
      Height          =   3855
      Left            =   1920
      TabIndex        =   16
      Top             =   240
      Width           =   1815
      Begin VB.Label Label4 
         Caption         =   "N="
         Height          =   375
         Left            =   240
         TabIndex        =   17
         Top             =   240
         Width           =   735
      End
   End
   Begin VB.Label Label1 
      Caption         =   "Исходные данные"
      Height          =   255
      Left            =   120
      TabIndex        =   1
      Top             =   120
      Width           =   1575
   End
   Begin VB.Label Label2 
      Caption         =   "Данные с сортировкой"
      Height          =   255
      Left            =   3720
      TabIndex        =   2
      Top             =   120
      Width           =   1815
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Declare Function QueryPerformanceFrequency Lib "kernel32" _
            (lpFrequency As Currency) As Long
            
Private Declare Function QueryPerformanceCounter Lib "kernel32" _
            (lpPerformanceCount As Currency) As Long


Private Sub Command1_Click()
GeneratedList.Clear
SortedList.Clear
End Sub

Private Sub Command2_Click()
Dim count, i As Integer
i = 0
count = 100
GeneratedList.Clear
Randomize
If Len(NumberCount.Text) = 0 Then
    MsgBox "Enter N!"
ElseIf IsNumeric(NumberCount.Text) = False Then
    MsgBox "Enter valid number to N!"
ElseIf Int(NumberCount.Text) >= 30000 Then
    MsgBox "N is very big!"
Else

    Dim arrayLength As Integer
    arrayLength = Int(NumberCount.Text)
    For i = 0 To arrayLength - 1
        GeneratedList.AddItem Str(Int((Rnd * Int(count)) + 1))
    Next
End If
End Sub

Private Sub Command3_Click()
Dim generatedArray() As Integer
Dim i As Integer
ReDim Preserve generatedArray(0 To Int(GeneratedList.ListCount)) As Integer
For i = 0 To GeneratedList.ListCount - 1
    generatedArray(i) = GeneratedList.List(i)
Next
Dim dimension As Boolean
dimension = UpDimension.Value = True
StartSorting generatedArray, dimension
SortedList.Clear
For i = 0 To GeneratedList.ListCount - 1
    SortedList.AddItem Str(generatedArray(i))
Next
End Sub

Private Sub StartSorting(dataset() As Integer, flag As Boolean)
    Dim lngReturn, lngI, lngX As Long
    Dim curFreq, curStart, curEnd As Currency
    Dim sngTime As Single
    lngReturn = QueryPerformanceFrequency(curFreq)
    If lngReturn <> 0 Then
        lngReturn = QueryPerformanceCounter(curStart)
        SelectionSort dataset, flag
        lngReturn = QueryPerformanceCounter(curEnd)
        sngTime = (curEnd - curStart) / curFreq
        ElapsedTime.Text = sngTime & " sec"
    Else
        MsgBox "Your Hardware does not support a high-resolution timer"
End If
End Sub

Private Sub SelectionSort(dataset() As Integer, flag As Boolean)
        Dim max As Integer
        max = FindMax(dataset)
        Dim zerolist() As Integer
        ReDim Preserve zerolist(0 To max - 1) As Integer
        
        Dim index As Integer
        Dim k As Integer
        For k = 0 To UBound(dataset) - 1
            zerolist(dataset(k) - 1) = zerolist(dataset(k) - 1) + 1
        Next
        Dim b As Integer
        Dim j As Integer
        Dim i As Integer
        For j = 0 To max - 1
            For i = 0 To zerolist(j) - 1
                dataset(b) = j + 1
                b = b + 1
            Next
        Next
        If Not flag Then
            For i = 0 To UBound(dataset) \ 2 - 1
                k = dataset(i): dataset(i) = dataset(UBound(dataset) - i - 1): dataset(UBound(dataset) - i - 1) = k
            Next i
        End If
End Sub


Public Function FindMax(arr() As Integer) As Integer
  Dim myMax As Long
  Dim i As Long
  
  For i = LBound(arr) To UBound(arr)
    If arr(i) > myMax Then
      myMax = arr(i)
      FindMax = myMax
    End If
  Next i
End Function

Private Function GetBoolean(index As Integer, newIndex As Integer, flag As Boolean) As Boolean
    If (flag) Then
        GetBoolean = index <= newIndex
    Else
        GetBoolean = index > newIndex
    End If
End Function

Private Sub Command4_Click()
    ProjectAbout.Show
End Sub

Private Sub Command5_Click()
    AuthorAbout.Show
End Sub

Private Sub Command6_Click()
    If SortedList.ListCount = 0 Then
        MsgBox "Sort something to save results!"
        Exit Sub
    End If
    On Error GoTo ErrorHandler
    Dim fileName As String
    CommonDialogBox.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*"
    CommonDialogBox.ShowSave
    fileName = CommonDialogBox.fileName
    Dim file, i As Integer
    file = FreeFile
    Open fileName For Output As #file
    For i = 0 To SortedList.ListCount - 1
        Print #file, SortedList.List(i)
    Next
    Close #file
ErrorHandler:
    Exit Sub
End Sub

Private Sub Command7_Click()
    Dim Form As VB.Form
    For Each Form In VB.Forms
        Unload Form
    Next
End Sub

