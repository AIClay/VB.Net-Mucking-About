Imports System.Collections
Imports System.Text
Imports System.Threading


Public Class extras

    Structure test1
        Public val1 As String
        Public val2 As Double
        Public val3 As ArrayList
    End Structure

    Private setItem As test1

    Public ReadOnly Property Gen_Struct As test1
        Get
            Return setItem
        End Get
    End Property

    Public Sub New(ByVal val1 As String, ByVal val2 As Double, ByVal val3 As ArrayList)
        Dim c As New test1
        Dim bb As New Random
        Dim dd = bb.NextDouble
        c.val1 = val1
        c.val2 = dd
        c.val3 = val3
        setItem = c
        c = Nothing
    End Sub
End Class
