<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NetworkTraffic
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NetworkTraffic))
        Me.outputText = New System.Windows.Forms.RichTextBox()
        Me.networktrafficscan = New System.Windows.Forms.Button()
        Me.filter = New System.Windows.Forms.ComboBox()
        Me.interfacecombobox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'outputText
        '
        Me.outputText.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.outputText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputText.Location = New System.Drawing.Point(384, 197)
        Me.outputText.Name = "outputText"
        Me.outputText.ReadOnly = True
        Me.outputText.Size = New System.Drawing.Size(589, 286)
        Me.outputText.TabIndex = 1
        Me.outputText.Text = ""
        '
        'networktrafficscan
        '
        Me.networktrafficscan.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.networktrafficscan.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.networktrafficscan.Location = New System.Drawing.Point(54, 358)
        Me.networktrafficscan.Name = "networktrafficscan"
        Me.networktrafficscan.Size = New System.Drawing.Size(247, 75)
        Me.networktrafficscan.TabIndex = 2
        Me.networktrafficscan.Text = " Scan"
        Me.networktrafficscan.UseVisualStyleBackColor = False
        '
        'filter
        '
        Me.filter.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.filter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filter.FormattingEnabled = True
        Me.filter.Items.AddRange(New Object() {"ALL", "HTTP", "HTTPS", "ARP", "ICMP"})
        Me.filter.Location = New System.Drawing.Point(26, 197)
        Me.filter.Name = "filter"
        Me.filter.Size = New System.Drawing.Size(140, 28)
        Me.filter.TabIndex = 3
        Me.filter.Text = "Filter"
        '
        'interfacecombobox
        '
        Me.interfacecombobox.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.interfacecombobox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.interfacecombobox.FormattingEnabled = True
        Me.interfacecombobox.Items.AddRange(New Object() {"Wlan0", "Eth0"})
        Me.interfacecombobox.Location = New System.Drawing.Point(200, 197)
        Me.interfacecombobox.Name = "interfacecombobox"
        Me.interfacecombobox.Size = New System.Drawing.Size(138, 28)
        Me.interfacecombobox.TabIndex = 4
        Me.interfacecombobox.Text = "Interface"
        '
        'NetworkTraffic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(985, 495)
        Me.Controls.Add(Me.interfacecombobox)
        Me.Controls.Add(Me.filter)
        Me.Controls.Add(Me.networktrafficscan)
        Me.Controls.Add(Me.outputText)
        Me.Name = "NetworkTraffic"
        Me.Text = "Network Traffic Scanner"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents outputText As RichTextBox
    Friend WithEvents networktrafficscan As Button
    Friend WithEvents filter As ComboBox
    Friend WithEvents interfacecombobox As ComboBox
End Class
