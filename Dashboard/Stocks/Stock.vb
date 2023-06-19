Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Public Class Stock
    Dim sql_connet As New MySqlConnection
    Dim sql_command As New MySqlCommand
    Dim sql_Reader As MySqlDataReader
    Dim Sql_DataTable As DataTable
    Dim sql_Adapter As MySqlDataAdapter

    Dim server As String = "localhost"
    Dim username As String = "root"
    Dim password As String = "Nightwolf@0321"
    Dim DBName As String = "group_project"


    Private Sub updateTable()
        ' sql_connet.ConnectionString = "server = " + server + ";" + "user id=" + username + ";" _
        '    + "password=" + password + ";" + "database=" + DBName
        'sql_connet.Open()
        'sql_command.Connection = sql_connet
        'sql_command.CommandText = "SELECT * FROM stocks"
        'sql_Reader = sql_command.ExecuteReader
        'Sql_DataTable.Load(sql_Reader)
        'sql_Reader.Close()
        'sql_connet.Close()
        'daView.DataSource = Sql_DataTable

    End Sub
    Private Sub Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateTable()
    End Sub




End Class