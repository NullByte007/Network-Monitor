<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VulnerabiltyAnalysis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VulnerabiltyAnalysis))
        Me.outputText = New System.Windows.Forms.RichTextBox()
        Me.ip = New System.Windows.Forms.TextBox()
        Me.vulnerabilityscan = New System.Windows.Forms.Button()
        Me.ipvulnerability = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.remotehost = New System.Windows.Forms.RadioButton()
        Me.localhost = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'outputText
        '
        Me.outputText.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.outputText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputText.Location = New System.Drawing.Point(481, 181)
        Me.outputText.Name = "outputText"
        Me.outputText.ReadOnly = True
        Me.outputText.Size = New System.Drawing.Size(483, 284)
        Me.outputText.TabIndex = 0
        Me.outputText.Text = ""
        '
        'ip
        '
        Me.ip.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ip.Location = New System.Drawing.Point(214, 418)
        Me.ip.Name = "ip"
        Me.ip.Size = New System.Drawing.Size(248, 20)
        Me.ip.TabIndex = 1
        '
        'vulnerabilityscan
        '
        Me.vulnerabilityscan.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.vulnerabilityscan.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vulnerabilityscan.Location = New System.Drawing.Point(213, 290)
        Me.vulnerabilityscan.Name = "vulnerabilityscan"
        Me.vulnerabilityscan.Size = New System.Drawing.Size(249, 70)
        Me.vulnerabilityscan.TabIndex = 2
        Me.vulnerabilityscan.Text = " Scan"
        Me.vulnerabilityscan.UseVisualStyleBackColor = False
        '
        'ipvulnerability
        '
        Me.ipvulnerability.AutoSize = True
        Me.ipvulnerability.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ipvulnerability.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ipvulnerability.Location = New System.Drawing.Point(44, 418)
        Me.ipvulnerability.Name = "ipvulnerability"
        Me.ipvulnerability.Size = New System.Drawing.Size(101, 24)
        Me.ipvulnerability.TabIndex = 11
        Me.ipvulnerability.Text = "IP Address"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.remotehost)
        Me.GroupBox1.Controls.Add(Me.localhost)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(17, 271)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(170, 107)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'remotehost
        '
        Me.remotehost.AutoSize = True
        Me.remotehost.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.remotehost.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.remotehost.Location = New System.Drawing.Point(7, 72)
        Me.remotehost.Name = "remotehost"
        Me.remotehost.Size = New System.Drawing.Size(153, 29)
        Me.remotehost.TabIndex = 6
        Me.remotehost.Text = "Remote Host"
        Me.remotehost.UseVisualStyleBackColor = True
        '
        'localhost
        '
        Me.localhost.AutoSize = True
        Me.localhost.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.localhost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.localhost.Checked = True
        Me.localhost.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.localhost.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.localhost.ForeColor = System.Drawing.SystemColors.MenuText
        Me.localhost.Location = New System.Drawing.Point(6, 12)
        Me.localhost.Name = "localhost"
        Me.localhost.Size = New System.Drawing.Size(131, 29)
        Me.localhost.TabIndex = 7
        Me.localhost.TabStop = True
        Me.localhost.Text = "Local Host"
        Me.localhost.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 197)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 29)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Choose Option"
        '
        'VulnerabiltyAnalysis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(985, 481)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ipvulnerability)
        Me.Controls.Add(Me.vulnerabilityscan)
        Me.Controls.Add(Me.ip)
        Me.Controls.Add(Me.outputText)
        Me.Name = "VulnerabiltyAnalysis"
        Me.Text = "Vulnerabilty Analysis"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents outputText As RichTextBox
    Friend WithEvents ip As TextBox
    Friend WithEvents vulnerabilityscan As Button
    Friend WithEvents ipvulnerability As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents remotehost As RadioButton
    Friend WithEvents localhost As RadioButton
    Friend WithEvents Label1 As Label
End Class
