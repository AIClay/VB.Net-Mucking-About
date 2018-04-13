Imports System.Text
Imports System.Collections


Public Class genTenCSV

#Region "Constants"
    Private Const header As String = "ID,Name,Value1,Value2"
#End Region

#Region "Props"

    Private hdr As String = header
    Public ReadOnly Property CSV_Header As String
        Get
            Return hdr
        End Get
    End Property

    Private bdy As String
    Public ReadOnly Property CSV_Body As String
        Get
            Return bdy
        End Get
    End Property

    Private fullSTR As String
    Public ReadOnly Property CSV_FullString As String
        Get
            Return fullSTR
        End Get
    End Property

#End Region


#Region "Constructor"

    Public Sub New()
        Dim strBDY As String = ""
        For i = 0 To 10 Step 1
            Select Case i
                Case 0
                    strBDY += (i.ToString & ",Name:" & i.ToString & ",Value1_" & i.ToString & ",Value2_" & i.ToString & ",") & vbCrLf
                    Exit Select
                Case 10
                    strBDY += (i.ToString & ",Name:" & i.ToString & ",Value1_" & i.ToString & ",Value2_" & i.ToString)
                    Exit Select
                Case Else
                    strBDY += (i.ToString & ",Name:" & i.ToString & ",Value1_" & i.ToString & ",Value2_" & i.ToString & ",") & vbCrLf
                    Exit Select
            End Select
        Next
        bdy = strBDY
        fullSTR = (hdr & vbCrLf & bdy)
        strBDY = Nothing
    End Sub

#End Region


End Class
