<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dos_Acticity_Detection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dos_Acticity_Detection))
        Me.outputbox = New System.Windows.Forms.RichTextBox()
        Me.start = New System.Windows.Forms.Button()
        Me.dos = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'outputbox
        '
        Me.outputbox.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.outputbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputbox.Location = New System.Drawing.Point(372, 194)
        Me.outputbox.Name = "outputbox"
        Me.outputbox.ReadOnly = True
        Me.outputbox.Size = New System.Drawing.Size(575, 272)
        Me.outputbox.TabIndex = 0
        Me.outputbox.Text = ""
        '
        'start
        '
        Me.start.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.start.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.start.Location = New System.Drawing.Point(65, 354)
        Me.start.Name = "start"
        Me.start.Size = New System.Drawing.Size(221, 65)
        Me.start.TabIndex = 1
        Me.start.Text = "Start"
        Me.start.UseVisualStyleBackColor = False
        '
        'dos
        '
        Me.dos.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.dos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dos.FormattingEnabled = True
        Me.dos.Items.AddRange(New Object() {"Wlan0", "Eth0"})
        Me.dos.Location = New System.Drawing.Point(87, 194)
        Me.dos.Name = "dos"
        Me.dos.Size = New System.Drawing.Size(176, 32)
        Me.dos.TabIndex = 2
        Me.dos.Text = "Interface"
        '
        'Dos_Acticity_Detection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(985, 490)
        Me.Controls.Add(Me.dos)
        Me.Controls.Add(Me.start)
        Me.Controls.Add(Me.outputbox)
        Me.Name = "Dos_Acticity_Detection"
        Me.Text = "Dos_Acticity_Detection"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents outputbox As RichTextBox
    Friend WithEvents start As Button
    Friend WithEvents dos As ComboBox
End Class
