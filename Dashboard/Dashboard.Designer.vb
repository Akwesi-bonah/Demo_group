<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.topBar = New System.Windows.Forms.Panel()
        Me.sidePanel = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnSales = New System.Windows.Forms.Button()
        Me.BtnSocks = New System.Windows.Forms.Button()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.PanelContainer = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.sidePanel.SuspendLayout()
        Me.PanelContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'topBar
        '
        Me.topBar.BackColor = System.Drawing.Color.Red
        Me.topBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.topBar.Location = New System.Drawing.Point(0, 0)
        Me.topBar.Name = "topBar"
        Me.topBar.Size = New System.Drawing.Size(910, 17)
        Me.topBar.TabIndex = 0
        '
        'sidePanel
        '
        Me.sidePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.sidePanel.Controls.Add(Me.Button1)
        Me.sidePanel.Controls.Add(Me.btnHome)
        Me.sidePanel.Controls.Add(Me.btnSales)
        Me.sidePanel.Controls.Add(Me.BtnSocks)
        Me.sidePanel.Controls.Add(Me.btnAdmin)
        Me.sidePanel.Controls.Add(Me.btnReport)
        Me.sidePanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.sidePanel.Location = New System.Drawing.Point(0, 17)
        Me.sidePanel.Name = "sidePanel"
        Me.sidePanel.Size = New System.Drawing.Size(172, 517)
        Me.sidePanel.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button1.Location = New System.Drawing.Point(0, 494)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(172, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Back to Dashboard"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnHome.ForeColor = System.Drawing.Color.White
        Me.btnHome.Location = New System.Drawing.Point(-1, 0)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(170, 57)
        Me.btnHome.TabIndex = 3
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnSales
        '
        Me.btnSales.FlatAppearance.BorderSize = 0
        Me.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSales.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSales.ForeColor = System.Drawing.Color.White
        Me.btnSales.Location = New System.Drawing.Point(-1, 55)
        Me.btnSales.Name = "btnSales"
        Me.btnSales.Size = New System.Drawing.Size(170, 57)
        Me.btnSales.TabIndex = 3
        Me.btnSales.Text = "Sales"
        Me.btnSales.UseVisualStyleBackColor = True
        '
        'BtnSocks
        '
        Me.BtnSocks.FlatAppearance.BorderSize = 0
        Me.BtnSocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSocks.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnSocks.ForeColor = System.Drawing.Color.White
        Me.BtnSocks.Location = New System.Drawing.Point(-1, 118)
        Me.BtnSocks.Name = "BtnSocks"
        Me.BtnSocks.Size = New System.Drawing.Size(170, 57)
        Me.BtnSocks.TabIndex = 2
        Me.BtnSocks.Text = "Stocks"
        Me.BtnSocks.UseVisualStyleBackColor = True
        '
        'btnAdmin
        '
        Me.btnAdmin.FlatAppearance.BorderSize = 0
        Me.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdmin.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAdmin.ForeColor = System.Drawing.Color.White
        Me.btnAdmin.Location = New System.Drawing.Point(-1, 244)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(170, 57)
        Me.btnAdmin.TabIndex = 1
        Me.btnAdmin.Text = "Admin"
        Me.btnAdmin.UseVisualStyleBackColor = True
        '
        'btnReport
        '
        Me.btnReport.FlatAppearance.BorderSize = 0
        Me.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReport.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnReport.ForeColor = System.Drawing.Color.White
        Me.btnReport.Location = New System.Drawing.Point(3, 181)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(170, 57)
        Me.btnReport.TabIndex = 1
        Me.btnReport.Text = "Report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'PanelContainer
        '
        Me.PanelContainer.Controls.Add(Me.Label1)
        Me.PanelContainer.Location = New System.Drawing.Point(178, 72)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(705, 450)
        Me.PanelContainer.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(227, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dash board"
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 534)
        Me.Controls.Add(Me.PanelContainer)
        Me.Controls.Add(Me.sidePanel)
        Me.Controls.Add(Me.topBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.sidePanel.ResumeLayout(False)
        Me.PanelContainer.ResumeLayout(False)
        Me.PanelContainer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents topBar As Panel
    Friend WithEvents sidePanel As Panel
    Friend WithEvents PanelContainer As Panel
    Friend WithEvents btnSales As Button
    Friend WithEvents BtnSocks As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents btnAdmin As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
