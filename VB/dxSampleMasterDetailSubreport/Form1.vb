Imports System.ComponentModel
Imports System.Text


Partial Public Class Form1
    Public Sub New()
        InitializeComponent()
        Me.DocumentViewer1.DocumentSource = New MasterReport()
    End Sub
End Class
