<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NetworkScanner
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NetworkScanner))
        Me.outputText = New System.Windows.Forms.RichTextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ip = New System.Windows.Forms.TextBox()
        Me.networkscan = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'outputText
        '
        Me.outputText.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.outputText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputText.Location = New System.Drawing.Point(314, 183)
        Me.outputText.Name = "outputText"
        Me.outputText.ReadOnly = True
        Me.outputText.Size = New System.Drawing.Size(649, 277)
        Me.outputText.TabIndex = 0
        Me.outputText.Text = ""
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'ip
        '
        Me.ip.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ip.Location = New System.Drawing.Point(23, 220)
        Me.ip.Name = "ip"
        Me.ip.Size = New System.Drawing.Size(266, 20)
        Me.ip.TabIndex = 2
        '
        'networkscan
        '
        Me.networkscan.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.networkscan.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.networkscan.Location = New System.Drawing.Point(23, 349)
        Me.networkscan.Name = "networkscan"
        Me.networkscan.Size = New System.Drawing.Size(266, 88)
        Me.networkscan.TabIndex = 3
        Me.networkscan.Text = "Network Scan"
        Me.networkscan.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(113, 181)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "IP Address"
        '
        'NetworkScanner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(985, 481)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.networkscan)
        Me.Controls.Add(Me.ip)
        Me.Controls.Add(Me.outputText)
        Me.Name = "NetworkScanner"
        Me.Text = "Scan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents outputText As RichTextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ip As TextBox
    Friend WithEvents networkscan As Button
    Friend WithEvents Label1 As Label
End Class
