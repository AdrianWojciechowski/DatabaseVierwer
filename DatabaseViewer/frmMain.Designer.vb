<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tbMain = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblConnect = New System.Windows.Forms.Label()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.tbUser = New System.Windows.Forms.TextBox()
        Me.lblDatabaseName = New System.Windows.Forms.Label()
        Me.tbDatabaseName = New System.Windows.Forms.TextBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.tbServerName = New System.Windows.Forms.TextBox()
        Me.lblServerName = New System.Windows.Forms.Label()
        Me.lblIp = New System.Windows.Forms.Label()
        Me.tbIp = New System.Windows.Forms.TextBox()
        Me.pkConnect = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.scViewer = New System.Windows.Forms.SplitContainer()
        Me.tvTables = New System.Windows.Forms.TreeView()
        Me.dgvDataRows = New System.Windows.Forms.DataGridView()
        Me.tbMain.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.scViewer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scViewer.Panel1.SuspendLayout()
        Me.scViewer.Panel2.SuspendLayout()
        Me.scViewer.SuspendLayout()
        CType(Me.dgvDataRows, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbMain
        '
        Me.tbMain.Controls.Add(Me.TabPage1)
        Me.tbMain.Controls.Add(Me.TabPage2)
        Me.tbMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbMain.Location = New System.Drawing.Point(0, 0)
        Me.tbMain.Name = "tbMain"
        Me.tbMain.SelectedIndex = 0
        Me.tbMain.Size = New System.Drawing.Size(1264, 561)
        Me.tbMain.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblConnect)
        Me.TabPage1.Controls.Add(Me.tbPassword)
        Me.TabPage1.Controls.Add(Me.lblPass)
        Me.TabPage1.Controls.Add(Me.tbUser)
        Me.TabPage1.Controls.Add(Me.lblDatabaseName)
        Me.TabPage1.Controls.Add(Me.tbDatabaseName)
        Me.TabPage1.Controls.Add(Me.lblUser)
        Me.TabPage1.Controls.Add(Me.tbServerName)
        Me.TabPage1.Controls.Add(Me.lblServerName)
        Me.TabPage1.Controls.Add(Me.lblIp)
        Me.TabPage1.Controls.Add(Me.tbIp)
        Me.TabPage1.Controls.Add(Me.pkConnect)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1256, 535)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Connection"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lblConnect
        '
        Me.lblConnect.AutoSize = True
        Me.lblConnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblConnect.ForeColor = System.Drawing.Color.Green
        Me.lblConnect.Location = New System.Drawing.Point(426, 15)
        Me.lblConnect.Name = "lblConnect"
        Me.lblConnect.Size = New System.Drawing.Size(117, 26)
        Me.lblConnect.TabIndex = 11
        Me.lblConnect.Text = "Connected"
        Me.lblConnect.Visible = False
        '
        'tbPassword
        '
        Me.tbPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbPassword.Location = New System.Drawing.Point(431, 130)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPassword.Size = New System.Drawing.Size(147, 26)
        Me.tbPassword.TabIndex = 10
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblPass.Location = New System.Drawing.Point(343, 133)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(82, 20)
        Me.lblPass.TabIndex = 9
        Me.lblPass.Text = "Password:"
        '
        'tbUser
        '
        Me.tbUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbUser.Location = New System.Drawing.Point(161, 130)
        Me.tbUser.Name = "tbUser"
        Me.tbUser.Size = New System.Drawing.Size(154, 26)
        Me.tbUser.TabIndex = 8
        '
        'lblDatabaseName
        '
        Me.lblDatabaseName.AutoSize = True
        Me.lblDatabaseName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblDatabaseName.Location = New System.Drawing.Point(8, 86)
        Me.lblDatabaseName.Name = "lblDatabaseName"
        Me.lblDatabaseName.Size = New System.Drawing.Size(127, 20)
        Me.lblDatabaseName.TabIndex = 7
        Me.lblDatabaseName.Text = "Database name:"
        '
        'tbDatabaseName
        '
        Me.tbDatabaseName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbDatabaseName.Location = New System.Drawing.Point(161, 83)
        Me.tbDatabaseName.Name = "tbDatabaseName"
        Me.tbDatabaseName.Size = New System.Drawing.Size(154, 26)
        Me.tbDatabaseName.TabIndex = 6
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblUser.Location = New System.Drawing.Point(88, 133)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(47, 20)
        Me.lblUser.TabIndex = 5
        Me.lblUser.Text = "User:"
        '
        'tbServerName
        '
        Me.tbServerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbServerName.Location = New System.Drawing.Point(161, 45)
        Me.tbServerName.Name = "tbServerName"
        Me.tbServerName.Size = New System.Drawing.Size(154, 26)
        Me.tbServerName.TabIndex = 4
        '
        'lblServerName
        '
        Me.lblServerName.AutoSize = True
        Me.lblServerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblServerName.Location = New System.Drawing.Point(32, 48)
        Me.lblServerName.Name = "lblServerName"
        Me.lblServerName.Size = New System.Drawing.Size(103, 20)
        Me.lblServerName.TabIndex = 3
        Me.lblServerName.Text = "Server name:"
        '
        'lblIp
        '
        Me.lblIp.AutoSize = True
        Me.lblIp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblIp.Location = New System.Drawing.Point(107, 19)
        Me.lblIp.Name = "lblIp"
        Me.lblIp.Size = New System.Drawing.Size(28, 20)
        Me.lblIp.TabIndex = 2
        Me.lblIp.Text = "IP:"
        '
        'tbIp
        '
        Me.tbIp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbIp.Location = New System.Drawing.Point(161, 16)
        Me.tbIp.Name = "tbIp"
        Me.tbIp.Size = New System.Drawing.Size(154, 26)
        Me.tbIp.TabIndex = 1
        '
        'pkConnect
        '
        Me.pkConnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.pkConnect.Location = New System.Drawing.Point(285, 292)
        Me.pkConnect.Name = "pkConnect"
        Me.pkConnect.Size = New System.Drawing.Size(120, 33)
        Me.pkConnect.TabIndex = 0
        Me.pkConnect.Text = "Connect"
        Me.pkConnect.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.scViewer)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1256, 535)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Viewer"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'scViewer
        '
        Me.scViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scViewer.Location = New System.Drawing.Point(3, 3)
        Me.scViewer.Name = "scViewer"
        '
        'scViewer.Panel1
        '
        Me.scViewer.Panel1.Controls.Add(Me.tvTables)
        '
        'scViewer.Panel2
        '
        Me.scViewer.Panel2.Controls.Add(Me.dgvDataRows)
        Me.scViewer.Size = New System.Drawing.Size(1250, 529)
        Me.scViewer.SplitterDistance = 248
        Me.scViewer.TabIndex = 0
        '
        'tvTables
        '
        Me.tvTables.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvTables.Location = New System.Drawing.Point(0, 0)
        Me.tvTables.Name = "tvTables"
        Me.tvTables.Size = New System.Drawing.Size(248, 529)
        Me.tvTables.TabIndex = 0
        '
        'dgvDataRows
        '
        Me.dgvDataRows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDataRows.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDataRows.Location = New System.Drawing.Point(0, 0)
        Me.dgvDataRows.Name = "dgvDataRows"
        Me.dgvDataRows.Size = New System.Drawing.Size(998, 529)
        Me.dgvDataRows.TabIndex = 0
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 561)
        Me.Controls.Add(Me.tbMain)
        Me.Name = "frmMain"
        Me.Text = "Database Viewer"
        Me.tbMain.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.scViewer.Panel1.ResumeLayout(False)
        Me.scViewer.Panel2.ResumeLayout(False)
        CType(Me.scViewer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scViewer.ResumeLayout(False)
        CType(Me.dgvDataRows, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbMain As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lblConnect As Label
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents lblPass As Label
    Friend WithEvents tbUser As TextBox
    Friend WithEvents lblDatabaseName As Label
    Friend WithEvents tbDatabaseName As TextBox
    Friend WithEvents lblUser As Label
    Friend WithEvents tbServerName As TextBox
    Friend WithEvents lblServerName As Label
    Friend WithEvents lblIp As Label
    Friend WithEvents tbIp As TextBox
    Friend WithEvents pkConnect As Button
    Friend WithEvents scViewer As SplitContainer
    Friend WithEvents tvTables As TreeView
    Friend WithEvents dgvDataRows As DataGridView
End Class
