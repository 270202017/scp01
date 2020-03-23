
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class SCP_03ModuloAutos

    Private connectionString As String = "server=192.168.0.19;uid=relatorios;pwd=relatorios;database=Planejamento_SCP"

    Private da As SqlDataAdapter
    Private conn As SqlConnection
    Private bsource As New BindingSource()
    Private ds As DataSet = Nothing
    Private sql As String

    Private da2 As SqlDataAdapter
    Private conn2 As SqlConnection
    Private bsource2 As New BindingSource()
    Private ds2 As DataSet = Nothing
    Private sql2 As String

    Private da3 As SqlDataAdapter
    Private conn3 As SqlConnection
    Private bsource3 As New BindingSource()
    Private ds3 As DataSet = Nothing
    Private sql3 As String

    Private da4 As SqlDataAdapter
    Private conn4 As SqlConnection
    Private bsource4 As New BindingSource()
    Private ds4 As DataSet = Nothing
    Private sql4 As String

    Private da5 As SqlDataAdapter
    Private conn5 As SqlConnection
    Private bsource5 As New BindingSource()
    Private ds5 As DataSet = Nothing
    Private sql5 As String

    Private da6 As SqlDataAdapter
    Private conn6 As SqlConnection
    Private bsource6 As New BindingSource()
    Private ds6 As DataSet = Nothing
    Private sql6 As String

    Private da7 As SqlDataAdapter
    Private conn7 As SqlConnection
    Private bsource7 As New BindingSource()
    Private ds7 As DataSet = Nothing
    Private sql7 As String

    Private Sub PCP_Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PCP_Timer.Tick
        PCP_Timer_Label.Text = Mid(String.Format("{00:00:00}", Now - Data_Tma), 1, 8)
    End Sub

    Private Sub PCP_Timer_Label_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PCP_Timer_Label.TextChanged
        If PCP_Data_Limite_TextBox.Text = "" Then
            PCP_Timer_Label.BackColor = Color.LightSteelBlue
        ElseIf PCP_Data_Limite_TextBox.Text > PCP_Timer_Label.Text Then
            PCP_Timer_Label.BackColor = Color.Green
        Else
            PCP_Timer_Label.BackColor = Color.Red
        End If
    End Sub

    Private Sub SCP_Autos_IncluirButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SCP_Autos_IncluirButton.Click

        Dim SCPConexao As New SqlClient.SqlConnection(connectionString)
        Dim SCPObjComd As New SqlClient.SqlCommand()
        Dim SCPDdtr As SqlClient.SqlDataReader
        SCPObjComd.Connection = SCPConexao
        SCPObjComd.CommandType = CommandType.StoredProcedure
        SCPObjComd.CommandText = "Proc_SCP_01_Monitoria"  'nome da procedure criada no banco de dados
        SCPConexao.Open()

        Try
            SCPDdtr = SCPObjComd.ExecuteReader(CommandBehavior.CloseConnection)

            While SCPDdtr.Read()
                If SCPDdtr.HasRows Then
                    ComboBox1.Items.Add(SCPDdtr(0))
                Else
                    MsgBox("Erro, favor contatar o administrador!", MsgBoxStyle.Critical, "SCP")
                End If
            End While
            SCPDdtr.Close()
            SCPDdtr.Dispose()
            GroupBox1.Enabled = True
            ComboBox1.Enabled = True
            Button1.Enabled = False
            Button2.Enabled = True
            Button3.Enabled = False
            Button6.Enabled = False
            SCP_Autos_IncluirButton.Enabled = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SCP")
            ComboBox1.Focus()
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        ComboBox2.Text = ""
        ComboBox2.Items.Clear()

        Dim SCPConexao01 As New SqlClient.SqlConnection(connectionString)
        Dim SCPObjComd01 As New SqlClient.SqlCommand()
        Dim SCPDdtr01 As SqlClient.SqlDataReader
        SCPObjComd01.Connection = SCPConexao01
        SCPObjComd01.CommandType = CommandType.StoredProcedure
        SCPObjComd01.CommandText = "Proc_SCP_02_Monitoria"  'nome da procedure criada no banco de dados
        SCPObjComd01.Parameters.Add(New SqlClient.SqlParameter("@Grupo_Principal", SqlDbType.VarChar, 100)).Value = ComboBox1.Text

        SCPConexao01.Open()

        Try
            SCPDdtr01 = SCPObjComd01.ExecuteReader(CommandBehavior.CloseConnection)

            While SCPDdtr01.Read()
                If SCPDdtr01.HasRows Then
                    ComboBox2.Items.Add(SCPDdtr01(0))
                Else
                    MsgBox("Erro, favor contatar o administrador!", MsgBoxStyle.Critical, "SCP")
                End If
            End While
            SCPDdtr01.Close()
            SCPDdtr01.Dispose()
            ComboBox1.Enabled = False
            ComboBox2.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SCP")
            ComboBox1.Focus()
        End Try
    End Sub



    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        SCPForm_Login.Close()
        SCP_02TrocaSenha.Close()
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Data_Tma = Now
        PCP_Timer.Stop()
        PCP_Timer_Label.BackColor = Color.LightSteelBlue
        PCP_Timer_Label.Text = Mid(String.Format("{00:00:00}", Now - Data_Tma), 1, 8)

        ComboBox1.Text = ""
        ComboBox1.Items.Clear()
        ComboBox1.Enabled = False
        ComboBox2.Text = ""
        ComboBox2.Items.Clear()
        ComboBox2.Enabled = False
        ComboBox3.Text = ""
        ComboBox3.Items.Clear()
        ComboBox3.Enabled = False

        TextBox1.Text = ""
        TextBox1.Enabled = False
        TextBox2.Text = ""

        Data_LigacaoTextBox.Text = ""
        Data_LigacaoTextBox.Enabled = False

        GroupBox1.Enabled = False

        Button1.Enabled = True
        Button5.Enabled = True
        SCP_Autos_IncluirButton.Enabled = True
        Button3.Enabled = True

        ErroTextBox2.Text = 0

        DataGridView1.DataSource = ""
        DataGridView6.DataSource = ""
        DataGridView8.DataSource = ""

        TextBox2.Text = ""

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        If TextBox2.Text = "A" Then
            GoTo pulao
        End If

        If TextBox2.Text = "Z" Then
            'Criterio 01
            Dim SCPConexao100 As New SqlClient.SqlConnection(connectionString)
            Dim SCPObjComd100 As New SqlClient.SqlCommand()
            Dim SCPDdtr100 As SqlClient.SqlDataReader
            SCPObjComd100.Connection = SCPConexao100
            SCPObjComd100.CommandType = CommandType.StoredProcedure
            SCPObjComd100.CommandText = "Proc_SCP_Delete_01"  'nome da procedure criada no banco de dados
            SCPObjComd100.Parameters.Add(New SqlClient.SqlParameter("@Numero_Gravacao", SqlDbType.VarChar, 100)).Value = TextBox1.Text

            SCPConexao100.Open()

            Try
                SCPDdtr100 = SCPObjComd100.ExecuteReader(CommandBehavior.CloseConnection)
                SCPDdtr100.Close()
                SCPDdtr100.Dispose()
                MsgBox("Gravação Apagada", MsgBoxStyle.Critical, "SCP")

                Data_Tma = Now
                PCP_Timer.Stop()
                PCP_Timer_Label.BackColor = Color.LightSteelBlue
                PCP_Timer_Label.Text = Mid(String.Format("{00:00:00}", Now - Data_Tma), 1, 8)

                ComboBox1.Text = ""
                ComboBox1.Items.Clear()
                ComboBox1.Enabled = False
                ComboBox2.Text = ""
                ComboBox2.Items.Clear()
                ComboBox2.Enabled = False
                ComboBox3.Text = ""
                ComboBox3.Items.Clear()
                ComboBox3.Enabled = False

                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox1.Enabled = False

                Data_LigacaoTextBox.Text = ""
                Data_LigacaoTextBox.Enabled = False

                GroupBox1.Enabled = False

                Button1.Enabled = True
                Button5.Enabled = True
                SCP_Autos_IncluirButton.Enabled = True
                Button3.Enabled = True

                ErroTextBox2.Text = 0

                DataGridView1.DataSource = ""
                DataGridView6.DataSource = ""
                DataGridView8.DataSource = ""

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "SCP")
                GoTo final
            End Try

            GoTo final

        End If

        'Criterio 01
        Dim SCPConexao99 As New SqlClient.SqlConnection(connectionString)
        Dim SCPObjComd99 As New SqlClient.SqlCommand()
        Dim SCPDdtr99 As SqlClient.SqlDataReader
        SCPObjComd99.Connection = SCPConexao99
        SCPObjComd99.CommandType = CommandType.StoredProcedure
        SCPObjComd99.CommandText = "Proc_SCP_InsereProd_02"  'nome da procedure criada no banco de dados
        SCPObjComd99.Parameters.Add(New SqlClient.SqlParameter("@Desc_TabelaMonitoria", SqlDbType.VarChar, 100)).Value = ComboBox3.Text
        SCPObjComd99.Parameters.Add(New SqlClient.SqlParameter("@Desc_Avaliador", SqlDbType.VarChar, 100)).Value = Desc_Avaliador.Text
        SCPObjComd99.Parameters.Add(New SqlClient.SqlParameter("@DescOperacao_Funcionario", SqlDbType.VarChar, 100)).Value = ComboBox1.Text
        SCPObjComd99.Parameters.Add(New SqlClient.SqlParameter("@Desc_Funcionario", SqlDbType.VarChar, 100)).Value = ComboBox2.Text
        SCPObjComd99.Parameters.Add(New SqlClient.SqlParameter("@Numero_Gravacao", SqlDbType.VarChar, 100)).Value = TextBox1.Text
        SCPObjComd99.Parameters.Add(New SqlClient.SqlParameter("@Data_Ligacao", SqlDbType.VarChar, 100)).Value = Data_LigacaoTextBox.Text

        SCPConexao99.Open()

        Try
            SCPDdtr99 = SCPObjComd99.ExecuteReader(CommandBehavior.CloseConnection)
            SCPDdtr99.Close()
            SCPDdtr99.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SCP")
            GoTo final
        End Try

pulao:

        TextBox1.Enabled = False
        Data_LigacaoTextBox.Enabled = False
        Button2.Enabled = False
        Button4.Enabled = False
        Button6.Enabled = True

        Data_Tma = Now
        PCP_Timer.Start()

        'Identificação

        conn = New SqlConnection(connectionString)
        sql = "Select Seq,Rtrim(Ltrim(Desc_CriterioSituacao)) Bloco,Rtrim(Ltrim(Desc_Criterio)) Procedimento,Rtrim(Ltrim(Desc_Criterio_02)) Procedimento_Desricao, Pontuacao,Status_Avaliacao,Pequeno_Memorando Obs From SCP_Tab_Prod_TabelaMonitoria_Producao_02 With(Nolock) Where 1=1 And Numero_Gravacao='" & TextBox1.Text & "' And Desc_CriterioSituacao<>'Falha Grave' Order By Id_SubItem,Id_CriterioCriterio"
        da = New SqlDataAdapter(sql, conn)
        conn.Open()
        ds = New DataSet()
        Dim commandBuilder As New SqlCommandBuilder(da)

        da.Fill(ds, "SCP_Tab_Prod_TabelaMonitoria_Producao_02")
        bsource.DataSource = ds.Tables("SCP_Tab_Prod_TabelaMonitoria_Producao_02")
        DataGridView1.DataSource = bsource
        'DataGridView6



        conn.Close()

        'Falha Grave

        conn6 = New SqlConnection(connectionString)
        sql6 = "Select Seq,Rtrim(Ltrim(Desc_CriterioSituacao)) Bloco,Rtrim(Ltrim(Desc_Criterio)) Procedimento,Pontuacao,Avaliado_Sim,Avaliado_Nao,Avaliado_NaoAvaliado,Pequeno_Memorando Obs From SCP_Tab_Prod_TabelaMonitoria_Producao_02 With(Nolock) Where 1=1 And Numero_Gravacao='" & TextBox1.Text & "' And Desc_CriterioSituacao='Falha Grave' Order By Id_SubItem,Id_CriterioCriterio"
        da6 = New SqlDataAdapter(sql6, conn6)
        conn6.Open()
        ds6 = New DataSet()
        Dim commandBuilder06 As New SqlCommandBuilder(da6)

        da6.Fill(ds6, "SCP_Tab_Prod_TabelaMonitoria_Producao_02")
        bsource6.DataSource = ds6.Tables("SCP_Tab_Prod_TabelaMonitoria_Producao_02")
        DataGridView6.DataSource = bsource6
        DataGridView6.Columns(0).Visible = False
        DataGridView6.Columns(1).ReadOnly = True
        DataGridView6.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView6.Columns(2).ReadOnly = True
        conn6.Close()


final:
    End Sub

    Private Sub DataGridView1_RowPrePaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPrePaintEventArgs) Handles DataGridView1.RowPrePaint

        If DataGridView1.Rows(e.RowIndex).Cells(4).Value > 0 Then
            DataGridView1.Rows(e.RowIndex).Cells(0).Style.BackColor = Color.LightGreen
            DataGridView1.Rows(e.RowIndex).Cells(1).Style.BackColor = Color.LightGreen
            DataGridView1.Rows(e.RowIndex).Cells(2).Style.BackColor = Color.LightGreen
            DataGridView1.Rows(e.RowIndex).Cells(3).Style.BackColor = Color.LightGreen
            DataGridView1.Rows(e.RowIndex).Cells(4).Style.BackColor = Color.LightGreen
            DataGridView1.Rows(e.RowIndex).Cells(5).Style.BackColor = Color.LightGreen
            DataGridView1.Rows(e.RowIndex).Cells(6).Style.BackColor = Color.LightGreen
        End If
    End Sub

    Private Sub DataGridView6_RowPrePaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPrePaintEventArgs) Handles DataGridView6.RowPrePaint

        If DataGridView6.Rows(e.RowIndex).Cells(3).Value > 0 Then
            DataGridView6.Rows(e.RowIndex).Cells(0).Style.BackColor = Color.Green
            DataGridView6.Rows(e.RowIndex).Cells(1).Style.BackColor = Color.Green
            DataGridView6.Rows(e.RowIndex).Cells(2).Style.BackColor = Color.Green
            DataGridView6.Rows(e.RowIndex).Cells(3).Style.BackColor = Color.Green
            DataGridView6.Rows(e.RowIndex).Cells(4).Style.BackColor = Color.Green
            DataGridView6.Rows(e.RowIndex).Cells(5).Style.BackColor = Color.Green
            DataGridView6.Rows(e.RowIndex).Cells(6).Style.BackColor = Color.Green
        End If

    End Sub


    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        ComboBox1.Enabled = True
        ComboBox2.Enabled = True
        ComboBox3.Enabled = True
        TextBox1.Enabled = True
        Data_LigacaoTextBox.Enabled = True
        Button2.Enabled = True
        Button4.Enabled = True
        TextBox1.Focus()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        'Identificação
        Try
            Dim dt As DataTable = ds.Tables("SCP_Tab_Prod_TabelaMonitoria_Producao_02")
            Dim dt6 As DataTable = ds6.Tables("SCP_Tab_Prod_TabelaMonitoria_Producao_02")

            Me.DataGridView1.BindingContext(dt).EndCurrentEdit()
            Me.da.Update(dt)

            Me.DataGridView6.BindingContext(dt6).EndCurrentEdit()
            Me.da6.Update(dt6)

            'MessageBox.Show("Banco de dados Atualizado com sucesso", "Atualizado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Erro : " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


        'Placar

        Dim dtplac As New DataTable
        Dim daplac As New SqlDataAdapter("Proc_SCP_Placar_02", connectionString)
        daplac.SelectCommand.CommandType = CommandType.StoredProcedure
        daplac.SelectCommand.Parameters.Add("@Numero_Gravacao", SqlDbType.VarChar)
        daplac.SelectCommand.Parameters("@Numero_Gravacao").Value = TextBox1.Text
        daplac.Fill(dtplac)
        Me.DataGridView8.DataSource = dtplac
        DataGridView8.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.MultiSelect = False

        'Placar 02

        Dim SCPConexao02Placar As New SqlClient.SqlConnection(connectionString)
        Dim SCPObjComd02Placar As New SqlClient.SqlCommand()
        Dim SCPDdtr02Placar As SqlClient.SqlDataReader
        SCPObjComd02Placar.Connection = SCPConexao02Placar
        SCPObjComd02Placar.CommandType = CommandType.StoredProcedure
        SCPObjComd02Placar.CommandText = "Proc_SCP_Placar_02_Erro"  'nome da procedure criada no banco de dados
        SCPObjComd02Placar.Parameters.Add(New SqlClient.SqlParameter("@Numero_Gravacao", SqlDbType.VarChar, 100)).Value = TextBox1.Text

        SCPConexao02Placar.Open()

        Try
            SCPDdtr02Placar = SCPObjComd02Placar.ExecuteReader(CommandBehavior.CloseConnection)

            While SCPDdtr02Placar.Read()
                If SCPDdtr02Placar.HasRows Then
                    ErroTextBox2.Text = SCPDdtr02Placar(0)
                Else
                    MsgBox("Erro, favor contatar o administrador!", MsgBoxStyle.Critical, "SCP")
                End If
            End While
            SCPDdtr02Placar.Close()
            SCPDdtr02Placar.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SCP")
            ComboBox2.Focus()
        End Try


    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("Inserir Gravação!", MsgBoxStyle.OkOnly)
        TextBox2.Text = "A"
        GroupBox1.Enabled = True
        Button1.Enabled = False
        Button2.Enabled = True
        Button4.Enabled = True
        Button3.Enabled = False
        Button6.Enabled = False
        SCP_Autos_IncluirButton.Enabled = False
        Button5.Enabled = False
        TextBox1.Enabled = True
        TextBox1.Focus()
    End Sub

    Private Sub ErroTextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ErroTextBox2.TextChanged
        If ErroTextBox2.Text = 0 Then
            EncerrarButton5.Enabled = True
        Else
            EncerrarButton5.Enabled = False
        End If

    End Sub

    Private Sub EncerrarButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EncerrarButton5.Click

        'Placar 02

        Dim SCPConexao02Encerrado As New SqlClient.SqlConnection(connectionString)
        Dim SCPObjComd02Encerrado As New SqlClient.SqlCommand()
        Dim SCPDdtr02Encerrado As SqlClient.SqlDataReader
        SCPObjComd02Encerrado.Connection = SCPConexao02Encerrado
        SCPObjComd02Encerrado.CommandType = CommandType.StoredProcedure
        SCPObjComd02Encerrado.CommandText = "Proc_SCP_Placar_Encerra"  'nome da procedure criada no banco de dados
        SCPObjComd02Encerrado.Parameters.Add(New SqlClient.SqlParameter("@Numero_Gravacao", SqlDbType.VarChar, 100)).Value = TextBox1.Text

        SCPConexao02Encerrado.Open()

        Try
            SCPDdtr02Encerrado = SCPObjComd02Encerrado.ExecuteReader(CommandBehavior.CloseConnection)

            SCPDdtr02Encerrado.Close()
            SCPDdtr02Encerrado.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SCP")
            ComboBox2.Focus()
        End Try

        MsgBox("Monitoria Atualizada", MsgBoxStyle.Critical, "SCP")

        Data_Tma = Now
        PCP_Timer.Stop()
        PCP_Timer_Label.BackColor = Color.LightSteelBlue
        PCP_Timer_Label.Text = Mid(String.Format("{00:00:00}", Now - Data_Tma), 1, 8)

        ComboBox1.Text = ""
        ComboBox1.Items.Clear()
        ComboBox1.Enabled = False
        ComboBox2.Text = ""
        ComboBox2.Items.Clear()
        ComboBox2.Enabled = False
        ComboBox3.Text = ""
        ComboBox3.Items.Clear()
        ComboBox3.Enabled = False

        TextBox1.Text = ""
        TextBox1.Enabled = False

        Data_LigacaoTextBox.Text = ""
        Data_LigacaoTextBox.Enabled = False

        GroupBox1.Enabled = False

        Button1.Enabled = True
        SCP_Autos_IncluirButton.Enabled = True
        Button3.Enabled = True

        ErroTextBox2.Text = 0

        DataGridView1.DataSource = ""
        DataGridView6.DataSource = ""
        DataGridView8.DataSource = ""

        TextBox2.Text = ""

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MsgBox("Apagar Gravação!", MsgBoxStyle.OkOnly)
        TextBox2.Text = "Z"
        GroupBox1.Enabled = True
        Button1.Enabled = False
        Button2.Enabled = True
        Button4.Enabled = True
        Button3.Enabled = False
        Button6.Enabled = False
        SCP_Autos_IncluirButton.Enabled = False
        Button5.Enabled = False
        TextBox1.Enabled = True
        TextBox1.Focus()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim SCPConexao02 As New SqlClient.SqlConnection(connectionString)
        Dim SCPObjComd02 As New SqlClient.SqlCommand()
        Dim SCPDdtr02 As SqlClient.SqlDataReader
        SCPObjComd02.Connection = SCPConexao02
        SCPObjComd02.CommandType = CommandType.StoredProcedure
        SCPObjComd02.CommandText = "Proc_SCP_03_Monitoria"  'nome da procedure criada no banco de dados
        SCPObjComd02.Parameters.Add(New SqlClient.SqlParameter("@Grupo_Principal", SqlDbType.VarChar, 100)).Value = ComboBox1.Text

        SCPConexao02.Open()

        Try
            SCPDdtr02 = SCPObjComd02.ExecuteReader(CommandBehavior.CloseConnection)

            While SCPDdtr02.Read()
                If SCPDdtr02.HasRows Then
                    ComboBox3.Items.Add(SCPDdtr02(0))
                Else
                    MsgBox("Erro, favor contatar o administrador!", MsgBoxStyle.Critical, "SCP")
                End If
            End While
            SCPDdtr02.Close()
            SCPDdtr02.Dispose()
            'ComboBox2.Enabled = False
            ComboBox3.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SCP")
            ComboBox2.Focus()
        End Try
    End Sub

End Class