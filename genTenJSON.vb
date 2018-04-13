Imports System.Text
Imports System.Collections


Public Class genTenJSON

#Region "notes"

    '' Reference: SINGLE *VALID* OBJ
    '    {
    '       "name": "name1",
    '        "id": "id_1",
    '        "Val1": "Value_1",
    '       "Val2": "Value_2"
    '   }
    '' 
#End Region

#Region "Vars"
    Private Const hdr As String = "{" & Chr(34) & "items" & Chr(34) & ":[{" & vbCrLf
    Private json_close As String = "]}"
#End Region

#Region "Props - non mutable"

    Private json_full_str As String
    Public ReadOnly Property JSON_STRING As String
        Get
            Return json_full_str
        End Get
    End Property

#End Region

#Region "Constructor"

    Public Sub New()

        Dim strRecords As String = ""
        For i = 0 To 10 Step 1
            Select Case i
                Case 1
                    strRecords += (Chr(34) & "name" & Chr(34) & ":" & Chr(34) & "name_" & i.ToString & Chr(34) & ",") & vbCrLf
                    strRecords += (Chr(34) & "id" & Chr(34) & ":" & Chr(34) & "id_" & i.ToString & Chr(34) & "," & vbCrLf)
                    strRecords += (Chr(34) & "Value1" & Chr(34) & ":" & Chr(34) & "Val1_" & i.ToString & Chr(34) & "," & vbCrLf)
                    strRecords += (Chr(34) & "Value2" & Chr(34) & ":" & Chr(34) & "Val2_" & i.ToString & Chr(34) & "}," & vbCrLf & "{" & vbCrLf)
                    Exit Select
                Case 10
                    strRecords += (Chr(34) & "name" & Chr(34) & ":" & Chr(34) & "name_" & i.ToString & Chr(34) & ",") & vbCrLf
                    strRecords += (Chr(34) & "id" & Chr(34) & ":" & Chr(34) & "id_" & i.ToString & Chr(34) & "," & vbCrLf)
                    strRecords += (Chr(34) & "Value1" & Chr(34) & ":" & Chr(34) & "Val1_" & i.ToString & Chr(34) & "," & vbCrLf)
                    strRecords += (Chr(34) & "Value2" & Chr(34) & ":" & Chr(34) & "Val2_" & i.ToString & Chr(34) & vbCrLf & "}" & vbCrLf)
                    Exit Select
                Case Else
                    strRecords += (Chr(34) & "name" & Chr(34) & ":" & Chr(34) & "name_" & i.ToString & Chr(34) & ",") & vbCrLf
                    strRecords += (Chr(34) & "id" & Chr(34) & ":" & Chr(34) & "id_" & i.ToString & Chr(34) & "," & vbCrLf)
                    strRecords += (Chr(34) & "Value1" & Chr(34) & ":" & Chr(34) & "Val1_" & i.ToString & Chr(34) & "," & vbCrLf)
                    strRecords += (Chr(34) & "Value2" & Chr(34) & ":" & Chr(34) & "Val2_" & i.ToString & Chr(34) & "}," & vbCrLf & "{" & vbCrLf)
                    Exit Select
            End Select
        Next
        json_full_str = (hdr & strRecords & json_close)
        strRecords = Nothing

    End Sub

#End Region

End Class
