<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.usernametextbox = New System.Windows.Forms.TextBox()
        Me.desiredusernamelabel = New System.Windows.Forms.Label()
        Me.desiredcolorlabel = New System.Windows.Forms.Label()
        Me.previewpicturebox = New System.Windows.Forms.PictureBox()
        Me.generatebutton = New System.Windows.Forms.Button()
        Me.creditlabel = New System.Windows.Forms.Label()
        CType(Me.previewpicturebox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'usernametextbox
        '
        Me.usernametextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernametextbox.Location = New System.Drawing.Point(12, 42)
        Me.usernametextbox.MaxLength = 29
        Me.usernametextbox.Name = "usernametextbox"
        Me.usernametextbox.Size = New System.Drawing.Size(167, 29)
        Me.usernametextbox.TabIndex = 0
        '
        'desiredusernamelabel
        '
        Me.desiredusernamelabel.AutoSize = True
        Me.desiredusernamelabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.desiredusernamelabel.Location = New System.Drawing.Point(11, 15)
        Me.desiredusernamelabel.Name = "desiredusernamelabel"
        Me.desiredusernamelabel.Size = New System.Drawing.Size(167, 24)
        Me.desiredusernamelabel.TabIndex = 1
        Me.desiredusernamelabel.Text = "Desired Username"
        '
        'desiredcolorlabel
        '
        Me.desiredcolorlabel.AutoSize = True
        Me.desiredcolorlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.desiredcolorlabel.Location = New System.Drawing.Point(33, 74)
        Me.desiredcolorlabel.Name = "desiredcolorlabel"
        Me.desiredcolorlabel.Size = New System.Drawing.Size(125, 24)
        Me.desiredcolorlabel.TabIndex = 2
        Me.desiredcolorlabel.Text = "Desired Color"
        '
        'previewpicturebox
        '
        Me.previewpicturebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.previewpicturebox.Location = New System.Drawing.Point(32, 101)
        Me.previewpicturebox.Name = "previewpicturebox"
        Me.previewpicturebox.Size = New System.Drawing.Size(128, 128)
        Me.previewpicturebox.TabIndex = 3
        Me.previewpicturebox.TabStop = False
        '
        'generatebutton
        '
        Me.generatebutton.Location = New System.Drawing.Point(12, 235)
        Me.generatebutton.Name = "generatebutton"
        Me.generatebutton.Size = New System.Drawing.Size(167, 23)
        Me.generatebutton.TabIndex = 4
        Me.generatebutton.Text = "Generate"
        Me.generatebutton.UseVisualStyleBackColor = True
        '
        'creditlabel
        '
        Me.creditlabel.AutoSize = True
        Me.creditlabel.Location = New System.Drawing.Point(25, 261)
        Me.creditlabel.Name = "creditlabel"
        Me.creditlabel.Size = New System.Drawing.Size(146, 13)
        Me.creditlabel.TabIndex = 5
        Me.creditlabel.Text = "Made with love, by Substitute"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(191, 281)
        Me.Controls.Add(Me.creditlabel)
        Me.Controls.Add(Me.generatebutton)
        Me.Controls.Add(Me.previewpicturebox)
        Me.Controls.Add(Me.desiredcolorlabel)
        Me.Controls.Add(Me.desiredusernamelabel)
        Me.Controls.Add(Me.usernametextbox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DS Color Picker"
        CType(Me.previewpicturebox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents usernametextbox As TextBox
    Friend WithEvents desiredusernamelabel As Label
    Friend WithEvents desiredcolorlabel As Label
    Friend WithEvents previewpicturebox As PictureBox
    Friend WithEvents generatebutton As Button
    Friend WithEvents creditlabel As Label
End Class
