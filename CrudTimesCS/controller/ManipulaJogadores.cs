using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CrudTimesCS.model;
using System.Windows.Forms;
using CrudTimesCS.view;
using System;
using System.Collections.Generic;

namespace CrudTimesCS.controller
{
    class ManipulaJogadores
    {
        public void cadastroJogadores()
        {
            SqlConnection cn = new SqlConnection(controller.ConexaoBD.Conectar());
            SqlCommand cmd = new SqlCommand("pInserirJogadores", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@NomeJogadores", jogadores.NomeJogadores);
                cmd.Parameters.AddWithValue("@EmailJogadores", jogadores.EmailJogadores);
                cmd.Parameters.AddWithValue("@FoneJogadores", jogadores.FoneJogadores);

                SqlParameter nv = cmd.Parameters.Add("@CodJogadores", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;

                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Cadastro Efetuado com Sucesso, Deseja executar um novo cadastro?",
                    "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    jogadores.Retorno1 = "Sim";
                    return;
                }
                else
                {
                    jogadores.Retorno1 = "Não";
                    return;
                }

            }
            catch
            {

            }
        }
          public void pesquisarCodigoJogadores()
        {
            SqlConnection cn = new SqlConnection(ConexaoBD.Conectar());
            SqlCommand cmd = new SqlCommand("pBuscarCodigoJogadores", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@CodJogadores", jogadores.CodJogadores);
                cn.Open();

                var arrayDados = cmd.ExecuteReader();

                if (arrayDados.Read())
                {
                    jogadores.CodJogadores = Convert.ToInt32(arrayDados["CodJogadores"]);
                    jogadores.NomeJogadores = arrayDados["NomeJogadores"].ToString();
                    jogadores.EmailJogadores = arrayDados["EmailJogadores"].ToString();
                    jogadores.FoneJogadores = arrayDados["FoneJogadores"].ToString();
                    jogadores.Retorno1 = "Sim";

                }
                else
                {
                    MessageBox.Show("Código Não Localizado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    jogadores.Retorno1 = "Não";
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
