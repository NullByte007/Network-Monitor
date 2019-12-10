<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Suspicious_Login_Detection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Suspicious_Login_Detection))
        Me.search = New System.Windows.Forms.Button()
        Me.outputbox = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'search
        '
        Me.search.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.search.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search.Location = New System.Drawing.Point(92, 322)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(250, 65)
        Me.search.TabIndex = 0
        Me.search.Text = "Search"
        Me.search.UseVisualStyleBackColor = False
        '
        'outputbox
        '
        Me.outputbox.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.outputbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputbox.Location = New System.Drawing.Point(390, 199)
        Me.outputbox.Name = "outputbox"
        Me.outputbox.ReadOnly = True
        Me.outputbox.Size = New System.Drawing.Size(563, 265)
        Me.outputbox.TabIndex = 1
        Me.outputbox.Text = ""
        '
        'Suspicious_Login_Detection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(985, 490)
        Me.Controls.Add(Me.outputbox)
        Me.Controls.Add(Me.search)
        Me.Name = "Suspicious_Login_Detection"
        Me.Text = "Suspicious_Login_Detection"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents search As Button
    Friend WithEvents outputbox As RichTextBox
End Class
