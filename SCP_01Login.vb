Imports Microsoft.SqlServer.Server
Imports System
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Text

Public Class SCPForm_Login

    Private Sub SCPEntrarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SCPEntrarButton.Click
        Dim SCPConexao As New SqlClient.SqlConnection("server=192.168.0.19;uid=relatorios;pwd=relatorios;database=Planejamento_SCP")
        Dim SCPObjComd As New SqlClient.SqlCommand()
        Dim SCPDdtr As SqlClient.SqlDataReader
        SCPObjComd.Connection = SCPConexao
        SCPObjComd.CommandType = CommandType.StoredProcedure
        SCPObjComd.CommandText = "SCP_Valida_Login"  'nome da procedure criada no banco de dados
        SCPObjComd.Parameters.Add(New SqlClient.SqlParameter("@Login", SqlDbType.VarChar, 20)).Value = SCPLoginTextBox.Text
        SCPObjComd.Parameters.Add(New SqlClient.SqlParameter("@Senha", SqlDbType.VarChar, 10)).Value = SCPSenhaTextBox.Text
        SCPObjComd.Parameters.Add(New SqlClient.SqlParameter("@Versao", SqlDbType.VarChar, 10)).Value = "V01.01"
        SCPConexao.Open()

        Try
            SCPDdtr = SCPObjComd.ExecuteReader(CommandBehavior.CloseConnection)

            While SCPDdtr.Read()
                If SCPDdtr.HasRows Then
                    SCP_05ModuloPOS.Show()
                    SCP_05ModuloPOS.Desc_Avaliador.Text = SCPLoginTextBox.Text
                    Me.Hide()

                Else
                    MsgBox("Erro, favor contatar o administrador!", MsgBoxStyle.Critical, "SCP")
                End If
            End While
            SCPDdtr.Close()
            SCPDdtr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SCP")
            SCPLoginTextBox.Focus()
        End Try
    End Sub

    Private Sub SCPAlterarSenhaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SCPAlterarSenhaButton.Click
        Me.Hide()
        SCP_02TrocaSenha.Show()
    End Sub

End Class
