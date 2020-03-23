<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SCP_02TrocaSenha
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
        Me.SCP_CancelarButton = New System.Windows.Forms.Button
        Me.SCP_TrocaSenhaAtualizarButton = New System.Windows.Forms.Button
        Me.SCP_TrocaSenhaSenhaNovaLabel = New System.Windows.Forms.Label
        Me.SCP_TrocaSenhaSenhaAtualLabel = New System.Windows.Forms.Label
        Me.SCP_TrocaSenhaLoginLabel = New System.Windows.Forms.Label
        Me.SCP_TrocaSenhaSenhaNovaTextBox = New System.Windows.Forms.TextBox
        Me.SCP_TrocaSenhaSenhaAtualTextBox = New System.Windows.Forms.TextBox
        Me.SCP_TrocaSenhaLoginTextBox = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'SCP_CancelarButton
        '
        Me.SCP_CancelarButton.BackColor = System.Drawing.Color.LightGray
        Me.SCP_CancelarButton.Location = New System.Drawing.Point(86, 87)
        Me.SCP_CancelarButton.Name = "SCP_CancelarButton"
        Me.SCP_CancelarButton.Size = New System.Drawing.Size(75, 23)
        Me.SCP_CancelarButton.TabIndex = 15
        Me.SCP_CancelarButton.Text = "Cancelar"
        Me.SCP_CancelarButton.UseVisualStyleBackColor = False
        '
        'SCP_TrocaSenhaAtualizarButton
        '
        Me.SCP_TrocaSenhaAtualizarButton.BackColor = System.Drawing.Color.LightGray
        Me.SCP_TrocaSenhaAtualizarButton.Location = New System.Drawing.Point(167, 87)
        Me.SCP_TrocaSenhaAtualizarButton.Name = "SCP_TrocaSenhaAtualizarButton"
        Me.SCP_TrocaSenhaAtualizarButton.Size = New System.Drawing.Size(75, 23)
        Me.SCP_TrocaSenhaAtualizarButton.TabIndex = 14
        Me.SCP_TrocaSenhaAtualizarButton.Text = "Atualizar"
        Me.SCP_TrocaSenhaAtualizarButton.UseVisualStyleBackColor = False
        '
        'SCP_TrocaSenhaSenhaNovaLabel
        '
        Me.SCP_TrocaSenhaSenhaNovaLabel.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.SCP_TrocaSenhaSenhaNovaLabel.Location = New System.Drawing.Point(36, 61)
        Me.SCP_TrocaSenhaSenhaNovaLabel.Name = "SCP_TrocaSenhaSenhaNovaLabel"
        Me.SCP_TrocaSenhaSenhaNovaLabel.Size = New System.Drawing.Size(100, 23)
        Me.SCP_TrocaSenhaSenhaNovaLabel.TabIndex = 12
        Me.SCP_TrocaSenhaSenhaNovaLabel.Text = "Senha Nova"
        Me.SCP_TrocaSenhaSenhaNovaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SCP_TrocaSenhaSenhaAtualLabel
        '
        Me.SCP_TrocaSenhaSenhaAtualLabel.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.SCP_TrocaSenhaSenhaAtualLabel.Location = New System.Drawing.Point(36, 35)
        Me.SCP_TrocaSenhaSenhaAtualLabel.Name = "SCP_TrocaSenhaSenhaAtualLabel"
        Me.SCP_TrocaSenhaSenhaAtualLabel.Size = New System.Drawing.Size(100, 23)
        Me.SCP_TrocaSenhaSenhaAtualLabel.TabIndex = 10
        Me.SCP_TrocaSenhaSenhaAtualLabel.Text = "Senha Atual"
        Me.SCP_TrocaSenhaSenhaAtualLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SCP_TrocaSenhaLoginLabel
        '
        Me.SCP_TrocaSenhaLoginLabel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SCP_TrocaSenhaLoginLabel.Location = New System.Drawing.Point(36, 9)
        Me.SCP_TrocaSenhaLoginLabel.Name = "SCP_TrocaSenhaLoginLabel"
        Me.SCP_TrocaSenhaLoginLabel.Size = New System.Drawing.Size(100, 23)
        Me.SCP_TrocaSenhaLoginLabel.TabIndex = 8
        Me.SCP_TrocaSenhaLoginLabel.Text = "Login"
        Me.SCP_TrocaSenhaLoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SCP_TrocaSenhaSenhaNovaTextBox
        '
        Me.SCP_TrocaSenhaSenhaNovaTextBox.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.SCP_TrocaSenhaSenhaNovaTextBox.Location = New System.Drawing.Point(142, 61)
        Me.SCP_TrocaSenhaSenhaNovaTextBox.MaxLength = 8
        Me.SCP_TrocaSenhaSenhaNovaTextBox.Name = "SCP_TrocaSenhaSenhaNovaTextBox"
        Me.SCP_TrocaSenhaSenhaNovaTextBox.Size = New System.Drawing.Size(100, 22)
        Me.SCP_TrocaSenhaSenhaNovaTextBox.TabIndex = 13
        Me.SCP_TrocaSenhaSenhaNovaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SCP_TrocaSenhaSenhaNovaTextBox.UseSystemPasswordChar = True
        '
        'SCP_TrocaSenhaSenhaAtualTextBox
        '
        Me.SCP_TrocaSenhaSenhaAtualTextBox.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.SCP_TrocaSenhaSenhaAtualTextBox.Location = New System.Drawing.Point(142, 35)
        Me.SCP_TrocaSenhaSenhaAtualTextBox.MaxLength = 8
        Me.SCP_TrocaSenhaSenhaAtualTextBox.Name = "SCP_TrocaSenhaSenhaAtualTextBox"
        Me.SCP_TrocaSenhaSenhaAtualTextBox.Size = New System.Drawing.Size(100, 22)
        Me.SCP_TrocaSenhaSenhaAtualTextBox.TabIndex = 11
        Me.SCP_TrocaSenhaSenhaAtualTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SCP_TrocaSenhaSenhaAtualTextBox.UseSystemPasswordChar = True
        '
        'SCP_TrocaSenhaLoginTextBox
        '
        Me.SCP_TrocaSenhaLoginTextBox.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.SCP_TrocaSenhaLoginTextBox.Location = New System.Drawing.Point(142, 9)
        Me.SCP_TrocaSenhaLoginTextBox.MaxLength = 20
        Me.SCP_TrocaSenhaLoginTextBox.Name = "SCP_TrocaSenhaLoginTextBox"
        Me.SCP_TrocaSenhaLoginTextBox.Size = New System.Drawing.Size(100, 22)
        Me.SCP_TrocaSenhaLoginTextBox.TabIndex = 9
        Me.SCP_TrocaSenhaLoginTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SCP_02TrocaSenha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 129)
        Me.Controls.Add(Me.SCP_CancelarButton)
        Me.Controls.Add(Me.SCP_TrocaSenhaAtualizarButton)
        Me.Controls.Add(Me.SCP_TrocaSenhaSenhaNovaLabel)
        Me.Controls.Add(Me.SCP_TrocaSenhaSenhaAtualLabel)
        Me.Controls.Add(Me.SCP_TrocaSenhaLoginLabel)
        Me.Controls.Add(Me.SCP_TrocaSenhaSenhaNovaTextBox)
        Me.Controls.Add(Me.SCP_TrocaSenhaSenhaAtualTextBox)
        Me.Controls.Add(Me.SCP_TrocaSenhaLoginTextBox)
        Me.Name = "SCP_02TrocaSenha"
        Me.Text = "SCP-Sistema Controle Produção"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SCP_CancelarButton As System.Windows.Forms.Button
    Friend WithEvents SCP_TrocaSenhaAtualizarButton As System.Windows.Forms.Button
    Friend WithEvents SCP_TrocaSenhaSenhaNovaLabel As System.Windows.Forms.Label
    Friend WithEvents SCP_TrocaSenhaSenhaAtualLabel As System.Windows.Forms.Label
    Friend WithEvents SCP_TrocaSenhaLoginLabel As System.Windows.Forms.Label
    Friend WithEvents SCP_TrocaSenhaSenhaNovaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SCP_TrocaSenhaSenhaAtualTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SCP_TrocaSenhaLoginTextBox As System.Windows.Forms.TextBox
End Class
