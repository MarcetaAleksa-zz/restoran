Imports System.Data.SqlClient

Public Class Baza
    Public Shared connection As New SqlConnection("server=tcp:ROMMEL,1433; database=Kafic;user id=sa;password=12345")
End Class
