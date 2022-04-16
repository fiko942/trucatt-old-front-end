Imports MySql.Data.MySqlClient
Public Class DTConnection
    Dim server As String = "ip_database"
    Dim user As String = "user_database"
    Dim password As String = "pass_database"
    Dim db As String = "db_name"
    Dim conect As New MySqlConnection("server='" & server & "';user='" & user & "';password='" & password & "';database='" & db & "'")
    Public Function open() As MySqlConnection
        Try
            conect.Open()
        Catch ex As Exception
        End Try
        Return conect
    End Function
    Public Function close() As MySqlConnection
        Try
            conect.Close()
        Catch ex As Exception
        End Try
        Return conect
    End Function
End Class
