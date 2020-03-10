<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.SHOW = New System.Windows.Forms.PictureBox()
        Me.loading_button = New System.Windows.Forms.Button()
        Me.next_image = New System.Windows.Forms.Button()
        Me.previous_button = New System.Windows.Forms.Button()
        CType(Me.SHOW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SHOW
        '
        Me.SHOW.Location = New System.Drawing.Point(12, 22)
        Me.SHOW.Name = "SHOW"
        Me.SHOW.Size = New System.Drawing.Size(776, 393)
        Me.SHOW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SHOW.TabIndex = 0
        Me.SHOW.TabStop = False
        '
        'loading_button
        '
        Me.loading_button.Location = New System.Drawing.Point(58, 421)
        Me.loading_button.Name = "loading_button"
        Me.loading_button.Size = New System.Drawing.Size(75, 23)
        Me.loading_button.TabIndex = 1
        Me.loading_button.Text = "Load"
        Me.loading_button.UseVisualStyleBackColor = True
        '
        'next_image
        '
        Me.next_image.Location = New System.Drawing.Point(243, 421)
        Me.next_image.Name = "next_image"
        Me.next_image.Size = New System.Drawing.Size(75, 23)
        Me.next_image.TabIndex = 2
        Me.next_image.Text = "Next"
        Me.next_image.UseVisualStyleBackColor = True
        '
        'previous_button
        '
        Me.previous_button.Location = New System.Drawing.Point(403, 421)
        Me.previous_button.Name = "previous_button"
        Me.previous_button.Size = New System.Drawing.Size(75, 23)
        Me.previous_button.TabIndex = 3
        Me.previous_button.Text = "Prev"
        Me.previous_button.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.previous_button)
        Me.Controls.Add(Me.next_image)
        Me.Controls.Add(Me.loading_button)
        Me.Controls.Add(Me.SHOW)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.SHOW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SHOW As PictureBox
    Friend WithEvents loading_button As Button
    Friend WithEvents next_image As Button
    Friend WithEvents previous_button As Button
End Class
