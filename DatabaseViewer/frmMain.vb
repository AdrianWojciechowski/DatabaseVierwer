Public Class frmMain
#Region " CONNECTION "
    Private Sub pkConnect_Click(sender As Object, e As EventArgs) Handles pkConnect.Click
        Select Case pkConnect.Text
            Case "Connect"
                If modDb.connect(tbIp.Text, tbServerName.Text, tbPassword.Text, tbUser.Text, tbDatabaseName.Text) Then
                    pkConnect.Text = "Disconnect"
                    lblConnect.Visible = True
                    fill_tvTables()
                End If
            Case "Disconnect"
                modDb.disconnect()
                pkConnect.Text = "Connect"
                lblConnect.Visible = False
        End Select
    End Sub
#End Region

#Region " VIEWER "
    Private Sub fill_tvTables()
        tvTables.Nodes.Clear()
        Dim sqlTxt As String = "SELECT TABLE_NAME FROM information_schema.tables WHERE TABLE_TYPE = 'BASE TABLE' ORDER BY TABLE_NAME ASC"
        Dim dataSource As DataTable = modDb.getDataTableSql(sqlTxt)
        For Each r As DataRow In dataSource.Rows
            Dim node As TreeNode = New TreeNode()
            node.Text = r("TABLE_NAME").ToString()
            tvTables.Nodes.Add(node)
        Next
    End Sub

    Private Sub tvTables_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles tvTables.NodeMouseClick
        Dim sqlTxt As String = "SELECT * FROM " & e.Node.Text
        Dim dataSource As DataTable = modDb.getDataTableSql(sqlTxt)
        dgvDataRows.DataSource = dataSource
    End Sub

#End Region

End Class
