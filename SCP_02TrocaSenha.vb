Public Class SCP_02TrocaSenha

    Private Sub SCP_CancelarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SCP_CancelarButton.Click
        Me.Close()
        SCPForm_Login.Show()
    End Sub

    Private Sub SCP_TrocaSenhaAtualizarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SCP_TrocaSenhaAtualizarButton.Click

        Dim SCPTROCAConexao As New SqlClient.SqlConnection("server=192.168.0.19;uid=relatorios;pwd=relatorios;database=Planejamento_SCP")
        Dim SCPTROCAObjComd As New SqlClient.SqlCommand()
        Dim SCPTROCADdtr As SqlClient.SqlDataReader

        SCPTROCAObjComd.Connection = SCPTROCAConexao
        SCPTROCAObjComd.CommandType = CommandType.StoredProcedure
        SCPTROCAObjComd.CommandText = "SCP_Atualiza_Senha"  'nome da procedure criada no banco de dados
        SCPTROCAObjComd.Parameters.Add(New SqlClient.SqlParameter("@Login", SqlDbType.VarChar, 20)).Value = SCP_TrocaSenhaLoginTextBox.Text
        SCPTROCAObjComd.Parameters.Add(New SqlClient.SqlParameter("@SenhaAntiga", SqlDbType.VarChar, 20)).Value = SCP_TrocaSenhaSenhaAtualTextBox.Text
        SCPTROCAObjComd.Parameters.Add(New SqlClient.SqlParameter("@SenhaNova", SqlDbType.VarChar, 20)).Value = SCP_TrocaSenhaSenhaNovaTextBox.Text
        SCPTROCAObjComd.Parameters.Add(New SqlClient.SqlParameter("@Versao", SqlDbType.VarChar, 10)).Value = "V01.01"
        SCPTROCAConexao.Open()

        Try
            SCPTROCADdtr = SCPTROCAObjComd.ExecuteReader(CommandBehavior.CloseConnection)
            While SCPTROCADdtr.Read()
                If SCPTROCADdtr.HasRows Then
                    MsgBox("Senha alterada!", MsgBoxStyle.Exclamation, "SCP")
                    SCP_TrocaSenhaLoginTextBox.Text = ""
                    SCP_TrocaSenhaSenhaAtualTextBox.Text = ""
                    SCP_TrocaSenhaSenhaNovaTextBox.Text = ""
                    Me.Close()
                    SCPForm_Login.Show()
                    SCPForm_Login.SCPLoginTextBox.Focus()
                End If
            End While

            SCPTROCADdtr.Close()
            SCPTROCADdtr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SCP")
        End Try
    End Sub

End Class