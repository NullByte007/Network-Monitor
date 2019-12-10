<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class openportscanner
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(openportscanner))
        Me.outputText = New System.Windows.Forms.RichTextBox()
        Me.scan = New System.Windows.Forms.Button()
        Me.ip = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.localhost = New System.Windows.Forms.RadioButton()
        Me.portbox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'outputText
        '
        Me.outputText.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.outputText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputText.Location = New System.Drawing.Point(455, 174)
        Me.outputText.Name = "outputText"
        Me.outputText.ReadOnly = True
        Me.outputText.Size = New System.Drawing.Size(518, 295)
        Me.outputText.TabIndex = 1
        Me.outputText.Text = ""
        '
        'scan
        '
        Me.scan.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.scan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.scan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.scan.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scan.ForeColor = System.Drawing.Color.Black
        Me.scan.Location = New System.Drawing.Point(211, 281)
        Me.scan.Name = "scan"
        Me.scan.Size = New System.Drawing.Size(226, 61)
        Me.scan.TabIndex = 2
        Me.scan.Text = "Scan"
        Me.scan.UseVisualStyleBackColor = False
        '
        'ip
        '
        Me.ip.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ip.Location = New System.Drawing.Point(211, 387)
        Me.ip.Name = "ip"
        Me.ip.Size = New System.Drawing.Size(226, 20)
        Me.ip.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 187)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 29)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Choose Option"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.localhost)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(19, 245)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(170, 107)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(7, 72)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(153, 29)
        Me.RadioButton1.TabIndex = 6
        Me.RadioButton1.Text = "Remote Host"
        Me.RadioButton1.UseVisualStyleBackColor = True
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
        'portbox
        '
        Me.portbox.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.portbox.Location = New System.Drawing.Point(211, 449)
        Me.portbox.Name = "portbox"
        Me.portbox.Size = New System.Drawing.Size(226, 20)
        Me.portbox.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 444)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 24)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Port Range"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 382)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 24)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "IP Address"
        '
        'openportscanner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(985, 481)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.portbox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ip)
        Me.Controls.Add(Me.scan)
        Me.Controls.Add(Me.outputText)
        Me.KeyPreview = True
        Me.Name = "openportscanner"
        Me.Text = "Open Port Scanner"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents outputText As RichTextBox
    Friend WithEvents ip As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents localhost As RadioButton
    Friend WithEvents portbox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents scan As Button
End Class
