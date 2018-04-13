Imports System.Text
Imports System.Collections

Public Class genTenXML

#Region "Constants"
    Public hdr As String = "<root>" & vbCrLf
    Public closer As String = vbCrLf & "</root>"
#End Region

#Region "Vars"
    Private full_XML_string As String = ""
#End Region

#Region "Props - Non Mutable"
    Public ReadOnly Property Full_XML_String_Returned As String
        Get
            Return full_XML_string
        End Get
    End Property
#End Region

#Region "Constructor"
    Public Sub New()
        Dim strXMLBody As String = ""
        strXMLBody += hdr & vbCrLf

        For i = 0 To 10 Step 1
            Select Case i
                Case 1
                    strXMLBody += "     <record>" & vbCrLf
                    strXMLBody += "     <recID>" & i.ToString & "</recID>" & vbCrLf
                    strXMLBody += "     <recName>Name_" & i.ToString & "</recName>" & vbCrLf
                    strXMLBody += "     <recVAL1>Val1_" & i.ToString & "</recVAL1>" & vbCrLf
                    strXMLBody += "     <recVAL2>Val2_" & i.ToString & "</recVAL2>" & vbCrLf
                    strXMLBody += "     </record>" & vbCrLf & vbCrLf
                    Exit Select
                Case 10
                    strXMLBody += "     <record>" & vbCrLf
                    strXMLBody += "     <recID>" & i.ToString & "</recID>" & vbCrLf
                    strXMLBody += "     <recName>Name_" & i.ToString & "</recName>" & vbCrLf
                    strXMLBody += "     <recVAL1>Val1_" & i.ToString & "</recVAL1>" & vbCrLf
                    strXMLBody += "     <recVAL2>Val2_" & i.ToString & "</recVAL2>" & vbCrLf
                    strXMLBody += "     </record>" & vbCrLf & closer
                    Exit Select
                Case Else
                    strXMLBody += "     <record>" & vbCrLf
                    strXMLBody += "     <recID>" & i.ToString & "</recID>" & vbCrLf
                    strXMLBody += "     <recName>Name_" & i.ToString & "</recName>" & vbCrLf
                    strXMLBody += "     <recVAL1>Val1_" & i.ToString & "</recVAL1>" & vbCrLf
                    strXMLBody += "     <recVAL2>Val2_" & i.ToString & "</recVAL2>" & vbCrLf
                    strXMLBody += "     </record>" & vbCrLf & vbCrLf
                    Exit Select
            End Select
        Next
        full_XML_string = strXMLBody
        strXMLBody = Nothing

    End Sub
#End Region

End Class
