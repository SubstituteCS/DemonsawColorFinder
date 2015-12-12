<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PickColor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PickColor))
        Me.previewcolorpicturebox = New System.Windows.Forms.PictureBox()
        Me.colorslistview = New System.Windows.Forms.ListView()
        Me.confirmbutton = New System.Windows.Forms.Button()
        CType(Me.previewcolorpicturebox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'previewcolorpicturebox
        '
        Me.previewcolorpicturebox.Location = New System.Drawing.Point(12, 12)
        Me.previewcolorpicturebox.Name = "previewcolorpicturebox"
        Me.previewcolorpicturebox.Size = New System.Drawing.Size(128, 128)
        Me.previewcolorpicturebox.TabIndex = 0
        Me.previewcolorpicturebox.TabStop = False
        '
        'colorslistview
        '
        Me.colorslistview.BackColor = System.Drawing.Color.Black
        Me.colorslistview.Location = New System.Drawing.Point(146, 12)
        Me.colorslistview.MultiSelect = False
        Me.colorslistview.Name = "colorslistview"
        Me.colorslistview.Size = New System.Drawing.Size(284, 171)
        Me.colorslistview.TabIndex = 1
        Me.colorslistview.UseCompatibleStateImageBehavior = False
        '
        'confirmbutton
        '
        Me.confirmbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirmbutton.Location = New System.Drawing.Point(12, 146)
        Me.confirmbutton.Name = "confirmbutton"
        Me.confirmbutton.Size = New System.Drawing.Size(128, 37)
        Me.confirmbutton.TabIndex = 2
        Me.confirmbutton.Text = "Confirm"
        Me.confirmbutton.UseVisualStyleBackColor = True
        '
        'PickColor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 195)
        Me.Controls.Add(Me.confirmbutton)
        Me.Controls.Add(Me.colorslistview)
        Me.Controls.Add(Me.previewcolorpicturebox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PickColor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Color"
        CType(Me.previewcolorpicturebox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents previewcolorpicturebox As PictureBox
    Friend WithEvents colorslistview As ListView
    Friend WithEvents confirmbutton As Button
End Class
