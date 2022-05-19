Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Module modDb

#Region " DECLARATIONS "

#Region " VARIABLES "
    Private vStructConnectionString As StructConnectionString
    Private sqlConnection As SqlConnection

#End Region

#Region " STRUCTURES "
    'EXAMPLE: Provider=SQLOLEDB;Data Source=SERVER\SERVERNAME;Persist Security Info=True;Password=PASSWORD;User ID=USER;Initial Catalog=CATALOG
    Private Structure StructConnectionString
        Dim ipAddress As String
        Dim serverName As String
        Dim password As String
        Dim user As String
        Dim database As String
    End Structure
#End Region

#Region " ENUMENATORS "

#End Region

#End Region

#Region " FUNCTIONS PUBLIC "
    Public Function getConnectionString() As String
        Dim result As String = "Data Source=" & vStructConnectionString.ipAddress & "\" & vStructConnectionString.serverName & ";Persist Security Info=True;" _
                             & "Password=" & vStructConnectionString.password & ";User ID=" & vStructConnectionString.user & ";Initial Catalog=" & vStructConnectionString.database
        Return result
    End Function

    Public Sub setConnectionString(ByVal _ipAddress As String, ByVal _serverName As String, ByVal _password As String, ByVal _user As String, ByVal _database As String)
        vStructConnectionString.ipAddress = _ipAddress
        vStructConnectionString.serverName = _serverName
        vStructConnectionString.password = _password
        vStructConnectionString.user = _user
        vStructConnectionString.database = _database
    End Sub

    Public Function connect(ByVal _ipAddress As String, ByVal _serverName As String, ByVal _password As String, ByVal _user As String, ByVal _database As String) As Boolean
        vStructConnectionString.ipAddress = _ipAddress
        vStructConnectionString.serverName = _serverName
        vStructConnectionString.password = _password
        vStructConnectionString.user = _user
        vStructConnectionString.database = _database

        Return connect()
    End Function

    Public Function connect() As Boolean
        sqlConnection = New SqlConnection(getConnectionString())
        Try
            sqlConnection.Open()
        Catch ex As Exception
            MsgBox("Cannot connect to database. Inner Exception: " & ex.InnerException.Message, MsgBoxStyle.Critical, "Database connection error")
            Return False
        End Try
        Return True
    End Function

    Public Sub disconnect()
        sqlConnection.Close()
    End Sub

    Public Function getDataRowsSql(ByVal _sqlTxt As String) As DataRow()
        Dim result As DataRow() = Nothing
        Dim tempDataTable As DataTable

        tempDataTable = getDataTableSql(_sqlTxt)

        If tempDataTable IsNot Nothing Then result = tempDataTable.Select()

        Return result
    End Function

    Public Function getDataTableSql(ByVal _sqlTxt As String) As DataTable
        Dim sqlCommand As SqlCommand
        Dim sqlReader As SqlDataReader
        Dim sqlTxt As String = _sqlTxt
        Dim result As New DataTable

        Try
            sqlCommand = New SqlCommand(sqlTxt, sqlConnection)
            sqlReader = sqlCommand.ExecuteReader()
            result.Load(sqlReader)
        Catch ex As Exception
            MsgBox("Cannot execute query. Inner Exception: " & ex.InnerException.Message, MsgBoxStyle.Critical, "Database query error")
            Return Nothing
        End Try

        Return result
    End Function

    Public Function executeSqlNonQuery(ByVal _sqlTxt As String) As Boolean
        Dim sqlCommand As SqlCommand

        Try
            sqlCommand = New SqlCommand(_sqlTxt)
            sqlCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Cannot execute query. Inner Exception: " & ex.InnerException.Message, MsgBoxStyle.Critical, "Database query error")
            Return False
        End Try

        Return True
    End Function

#End Region

#Region " FUNCTIONS PRIVATE "

#End Region

End Module
