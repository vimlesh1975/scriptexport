<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.dgvContents = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.cmbRO = New System.Windows.Forms.ComboBox()
        Me.cmdGetRo = New System.Windows.Forms.Button()
        Me.txtSlugSeparator = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtScriptSeparator = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNewsServerIP = New System.Windows.Forms.TextBox()
        CType(Me.dgvContents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvContents
        '
        Me.dgvContents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvContents.Location = New System.Drawing.Point(8, 30)
        Me.dgvContents.Name = "dgvContents"
        Me.dgvContents.Size = New System.Drawing.Size(621, 213)
        Me.dgvContents.TabIndex = 18
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(413, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 23)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Get Script"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(517, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 23)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Make Text File"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'cmbRO
        '
        Me.cmbRO.FormattingEnabled = True
        Me.cmbRO.Location = New System.Drawing.Point(112, 3)
        Me.cmbRO.Name = "cmbRO"
        Me.cmbRO.Size = New System.Drawing.Size(295, 21)
        Me.cmbRO.TabIndex = 22
        '
        'cmdGetRo
        '
        Me.cmdGetRo.Location = New System.Drawing.Point(8, 3)
        Me.cmdGetRo.Name = "cmdGetRo"
        Me.cmdGetRo.Size = New System.Drawing.Size(98, 23)
        Me.cmdGetRo.TabIndex = 23
        Me.cmdGetRo.Text = "Get Run Orders"
        Me.cmdGetRo.UseVisualStyleBackColor = True
        '
        'txtSlugSeparator
        '
        Me.txtSlugSeparator.Location = New System.Drawing.Point(650, 30)
        Me.txtSlugSeparator.Name = "txtSlugSeparator"
        Me.txtSlugSeparator.Size = New System.Drawing.Size(92, 20)
        Me.txtSlugSeparator.TabIndex = 24
        Me.txtSlugSeparator.Text = "ZXZX"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(647, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Slug Sepeartor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(647, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Script Separator"
        '
        'txtScriptSeparator
        '
        Me.txtScriptSeparator.Location = New System.Drawing.Point(650, 83)
        Me.txtScriptSeparator.Name = "txtScriptSeparator"
        Me.txtScriptSeparator.Size = New System.Drawing.Size(92, 20)
        Me.txtScriptSeparator.TabIndex = 26
        Me.txtScriptSeparator.Text = "ZCZC"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(633, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "News Server IP"
        '
        'txtNewsServerIP
        '
        Me.txtNewsServerIP.Location = New System.Drawing.Point(635, 145)
        Me.txtNewsServerIP.Name = "txtNewsServerIP"
        Me.txtNewsServerIP.Size = New System.Drawing.Size(92, 20)
        Me.txtNewsServerIP.TabIndex = 28
        Me.txtNewsServerIP.Text = "192.168.15.111"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 249)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNewsServerIP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtScriptSeparator)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSlugSeparator)
        Me.Controls.Add(Me.cmdGetRo)
        Me.Controls.Add(Me.cmbRO)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.dgvContents)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvContents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvContents As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents cmbRO As ComboBox
    Friend WithEvents cmdGetRo As Button
    Friend WithEvents txtSlugSeparator As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtScriptSeparator As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNewsServerIP As TextBox
End Class
