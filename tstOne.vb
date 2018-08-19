Imports System.Text
Imports System.IO
Imports System.Collections
Imports System

Public Class tstOne
    Public Structure tstThisOne
        Public id As String
        Public name As String
        Public stamp As DateTime
        Public url As String
        Public htmlDESC As String
        Public fileName As String
    End Structure


    Public ReadOnly Property newItem As tstThisOne
        Get
            Return tstOneThis
        End Get
    End Property

    Private tstOneThis As tstThisOne


    Public Sub New()
        Dim v As New tstThisOne
        v.id = Guid.NewGuid.ToString
        v.name = 'tstName'
        v.stamp = Date.Now.ToString
        v.url = "www.google.com"
        v.htmlDESC = "<!DOCTYPE html><head><meta charset='UTF-8'><title>testing dyn</title></head><body><span><mark>Test</mark></span></body></html>"
        v.fileName = "C:\Users\john\Desktop\HTML\vbDyn.htm"
        tstOneThis = v

        createIt(v)


    End Sub


    Public Sub createIt(ByVal itm As tstThisOne)
        Select Case System.IO.File.Exists(itm.fileName)
            Case True
                System.IO.File.Delete(itm.fileName)
                Dim writer As New System.IO.StreamWriter(itm.fileName)
                writer.Write(itm.htmlDESC)
                writer.Flush()
                writer.Close()
                writer = Nothing
                Exit Select
            Case False
                Dim writer As New System.IO.StreamWriter(itm.fileName)
                writer.Write(itm.htmlDESC)
                writer.Flush()
                writer.Close()
                writer = Nothing
                Exit Select
        End Select
        System.Diagnostics.Process.Start(itm.fileName)
    End Sub

End Class
