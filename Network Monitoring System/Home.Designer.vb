<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.networktrafficanalysis = New System.Windows.Forms.Button()
        Me.networkscanner = New System.Windows.Forms.Button()
        Me.vulnerabilityanalysis = New System.Windows.Forms.Button()
        Me.openportscanner = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.activitydetection = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'networktrafficanalysis
        '
        Me.networktrafficanalysis.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.networktrafficanalysis.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.networktrafficanalysis.Location = New System.Drawing.Point(852, 363)
        Me.networktrafficanalysis.Name = "networktrafficanalysis"
        Me.networktrafficanalysis.Size = New System.Drawing.Size(220, 66)
        Me.networktrafficanalysis.TabIndex = 0
        Me.networktrafficanalysis.Text = "Network Traffic Analysis"
        Me.networktrafficanalysis.UseVisualStyleBackColor = False
        '
        'networkscanner
        '
        Me.networkscanner.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.networkscanner.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.networkscanner.Location = New System.Drawing.Point(277, 363)
        Me.networkscanner.Name = "networkscanner"
        Me.networkscanner.Size = New System.Drawing.Size(202, 66)
        Me.networkscanner.TabIndex = 1
        Me.networkscanner.Text = "Network Scanner"
        Me.networkscanner.UseVisualStyleBackColor = False
        '
        'vulnerabilityanalysis
        '
        Me.vulnerabilityanalysis.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.vulnerabilityanalysis.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vulnerabilityanalysis.Location = New System.Drawing.Point(852, 204)
        Me.vulnerabilityanalysis.Name = "vulnerabilityanalysis"
        Me.vulnerabilityanalysis.Size = New System.Drawing.Size(220, 67)
        Me.vulnerabilityanalysis.TabIndex = 2
        Me.vulnerabilityanalysis.Text = "Vulnerabilty Analysis"
        Me.vulnerabilityanalysis.UseVisualStyleBackColor = False
        '
        'openportscanner
        '
        Me.openportscanner.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.openportscanner.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.openportscanner.Location = New System.Drawing.Point(277, 204)
        Me.openportscanner.Name = "openportscanner"
        Me.openportscanner.Size = New System.Drawing.Size(202, 67)
        Me.openportscanner.TabIndex = 3
        Me.openportscanner.Text = "Open Port Scanner"
        Me.openportscanner.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(52, 596)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(106, 40)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Help"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(1175, 596)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(116, 39)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "About"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'activitydetection
        '
        Me.activitydetection.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.activitydetection.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.activitydetection.Location = New System.Drawing.Point(544, 504)
        Me.activitydetection.Name = "activitydetection"
        Me.activitydetection.Size = New System.Drawing.Size(247, 67)
        Me.activitydetection.TabIndex = 6
        Me.activitydetection.Text = "Suspicious Activity Detection"
        Me.activitydetection.UseVisualStyleBackColor = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1367, 648)
        Me.Controls.Add(Me.activitydetection)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.openportscanner)
        Me.Controls.Add(Me.vulnerabilityanalysis)
        Me.Controls.Add(Me.networkscanner)
        Me.Controls.Add(Me.networktrafficanalysis)
        Me.DoubleBuffered = True
        Me.Name = "Home"
        Me.Text = "Home"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents networktrafficanalysis As Button
    Friend WithEvents networkscanner As Button
    Friend WithEvents vulnerabilityanalysis As Button
    Friend WithEvents openportscanner As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents activitydetection As Button
End Class
