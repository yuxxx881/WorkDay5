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
        Me.btnShowRecipe = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnShowRecipe
        '
        Me.btnShowRecipe.Location = New System.Drawing.Point(144, 145)
        Me.btnShowRecipe.Name = "btnShowRecipe"
        Me.btnShowRecipe.Size = New System.Drawing.Size(100, 23)
        Me.btnShowRecipe.TabIndex = 0
        Me.btnShowRecipe.Text = "ShowRecipe"
        Me.btnShowRecipe.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 361)
        Me.Controls.Add(Me.btnShowRecipe)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Chicken Noodle Soup"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnShowRecipe As System.Windows.Forms.Button

End Class
