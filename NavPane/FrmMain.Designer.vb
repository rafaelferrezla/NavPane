<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.BtnAbout = New System.Windows.Forms.Button()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Timer2
        '
        Me.Timer2.Interval = 1
        '
        'Btn2
        '
        Me.Btn2.BackgroundImage = Global.NavPane.My.Resources.Resources.menu
        Me.Btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn2.FlatAppearance.BorderSize = 0
        Me.Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn2.Location = New System.Drawing.Point(0, 0)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(45, 45)
        Me.Btn2.TabIndex = 1
        Me.Btn2.UseVisualStyleBackColor = True
        '
        'Panel
        '
        Me.Panel.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel.Controls.Add(Me.BtnAbout)
        Me.Panel.Controls.Add(Me.Btn2)
        Me.Panel.Location = New System.Drawing.Point(0, 0)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(0, 494)
        Me.Panel.TabIndex = 0
        '
        'BtnAbout
        '
        Me.BtnAbout.FlatAppearance.BorderSize = 0
        Me.BtnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAbout.Font = New System.Drawing.Font("Segoe WP", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAbout.Image = Global.NavPane.My.Resources.Resources.feature2
        Me.BtnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAbout.Location = New System.Drawing.Point(0, 459)
        Me.BtnAbout.Name = "BtnAbout"
        Me.BtnAbout.Size = New System.Drawing.Size(160, 36)
        Me.BtnAbout.TabIndex = 2
        Me.BtnAbout.Text = "About"
        Me.BtnAbout.UseVisualStyleBackColor = True
        '
        'Btn1
        '
        Me.Btn1.BackgroundImage = Global.NavPane.My.Resources.Resources.menu
        Me.Btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn1.FlatAppearance.BorderSize = 0
        Me.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn1.ImageKey = "(none)"
        Me.Btn1.Location = New System.Drawing.Point(0, 0)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(45, 45)
        Me.Btn1.TabIndex = 0
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 497)
        Me.Controls.Add(Me.Btn1)
        Me.Controls.Add(Me.Panel)
        Me.Font = New System.Drawing.Font("Segoe WP", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "FrmMain"
        Me.Text = "NavPane"
        Me.Panel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btn1 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Btn2 As System.Windows.Forms.Button
    Friend WithEvents BtnAbout As System.Windows.Forms.Button
    Friend WithEvents Panel As System.Windows.Forms.Panel

End Class
