<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.detection = New System.Windows.Forms.Button()
        Me.sla = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'detection
        '
        Me.detection.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.detection.Location = New System.Drawing.Point(95, 272)
        Me.detection.Name = "detection"
        Me.detection.Size = New System.Drawing.Size(285, 98)
        Me.detection.TabIndex = 0
        Me.detection.Text = "DOS Activity Detection "
        Me.detection.UseVisualStyleBackColor = True
        '
        'sla
        '
        Me.sla.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sla.Location = New System.Drawing.Point(585, 272)
        Me.sla.Name = "sla"
        Me.sla.Size = New System.Drawing.Size(308, 98)
        Me.sla.TabIndex = 1
        Me.sla.Text = "Suspicious Login Detection"
        Me.sla.UseVisualStyleBackColor = True
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(985, 490)
        Me.Controls.Add(Me.sla)
        Me.Controls.Add(Me.detection)
        Me.Name = "login"
        Me.Text = "SuspiciousActivityDetection"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents detection As Button
    Friend WithEvents sla As Button
End Class
