<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SCPForm_Login
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
        Me.SCPAlterarSenhaButton = New System.Windows.Forms.Button()
        Me.SCPEntrarButton = New System.Windows.Forms.Button()
        Me.SCPSenhaLabel = New System.Windows.Forms.Label()
        Me.SCPLoginLabel = New System.Windows.Forms.Label()
        Me.SCPSenhaTextBox = New System.Windows.Forms.TextBox()
        Me.SCPLoginTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'SCPAlterarSenhaButton
        '
        Me.SCPAlterarSenhaButton.BackColor = System.Drawing.Color.LightGray
        Me.SCPAlterarSenhaButton.Location = New System.Drawing.Point(196, 54)
        Me.SCPAlterarSenhaButton.Name = "SCPAlterarSenhaButton"
        Me.SCPAlterarSenhaButton.Size = New System.Drawing.Size(82, 22)
        Me.SCPAlterarSenhaButton.TabIndex = 12
        Me.SCPAlterarSenhaButton.Text = "Alterar Senha"
        Me.SCPAlterarSenhaButton.UseVisualStyleBackColor = False
        '
        'SCPEntrarButton
        '
        Me.SCPEntrarButton.BackColor = System.Drawing.Color.LightGray
        Me.SCPEntrarButton.Location = New System.Drawing.Point(196, 23)
        Me.SCPEntrarButton.Name = "SCPEntrarButton"
        Me.SCPEntrarButton.Size = New System.Drawing.Size(82, 22)
        Me.SCPEntrarButton.TabIndex = 11
        Me.SCPEntrarButton.Text = "Entrar"
        Me.SCPEntrarButton.UseVisualStyleBackColor = False
        '
        'SCPSenhaLabel
        '
        Me.SCPSenhaLabel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SCPSenhaLabel.Location = New System.Drawing.Point(12, 53)
        Me.SCPSenhaLabel.Name = "SCPSenhaLabel"
        Me.SCPSenhaLabel.Size = New System.Drawing.Size(60, 20)
        Me.SCPSenhaLabel.TabIndex = 9
        Me.SCPSenhaLabel.Text = "Senha"
        Me.SCPSenhaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SCPLoginLabel
        '
        Me.SCPLoginLabel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SCPLoginLabel.Location = New System.Drawing.Point(12, 23)
        Me.SCPLoginLabel.Name = "SCPLoginLabel"
        Me.SCPLoginLabel.Size = New System.Drawing.Size(60, 20)
        Me.SCPLoginLabel.TabIndex = 7
        Me.SCPLoginLabel.Text = "Usuário"
        Me.SCPLoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SCPSenhaTextBox
        '
        Me.SCPSenhaTextBox.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.SCPSenhaTextBox.Location = New System.Drawing.Point(78, 54)
        Me.SCPSenhaTextBox.MaxLength = 8
        Me.SCPSenhaTextBox.Name = "SCPSenhaTextBox"
        Me.SCPSenhaTextBox.Size = New System.Drawing.Size(100, 22)
        Me.SCPSenhaTextBox.TabIndex = 10
        Me.SCPSenhaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SCPSenhaTextBox.UseSystemPasswordChar = True
        '
        'SCPLoginTextBox
        '
        Me.SCPLoginTextBox.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.SCPLoginTextBox.Location = New System.Drawing.Point(78, 23)
        Me.SCPLoginTextBox.MaxLength = 20
        Me.SCPLoginTextBox.Name = "SCPLoginTextBox"
        Me.SCPLoginTextBox.Size = New System.Drawing.Size(100, 22)
        Me.SCPLoginTextBox.TabIndex = 8
        Me.SCPLoginTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SCPForm_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 102)
        Me.Controls.Add(Me.SCPAlterarSenhaButton)
        Me.Controls.Add(Me.SCPEntrarButton)
        Me.Controls.Add(Me.SCPSenhaLabel)
        Me.Controls.Add(Me.SCPLoginLabel)
        Me.Controls.Add(Me.SCPSenhaTextBox)
        Me.Controls.Add(Me.SCPLoginTextBox)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SCPForm_Login"
        Me.Text = "SCP-Sistema Controle Produção"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SCPAlterarSenhaButton As System.Windows.Forms.Button
    Friend WithEvents SCPEntrarButton As System.Windows.Forms.Button
    Friend WithEvents SCPSenhaLabel As System.Windows.Forms.Label
    Friend WithEvents SCPLoginLabel As System.Windows.Forms.Label
    Friend WithEvents SCPSenhaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SCPLoginTextBox As System.Windows.Forms.TextBox

End Class
