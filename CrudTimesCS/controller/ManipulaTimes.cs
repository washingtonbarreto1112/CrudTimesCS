using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CrudTimesCS.model;
using System.Windows.Forms;
using CrudTimesCS.view;

namespace CrudTimesCS.controller
{
    class ManipulaTimes
    {
        public void cadastroTimes()
        {
            SqlConnection cn = new SqlConnection(controller.ConexaoBD.Conectar());
            SqlCommand cmd = new SqlCommand("pInserirTimes", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@NomeTimes", times.NomeTimes);
                cmd.Parameters.AddWithValue("@LogoTimes", times.LogoTimes);
                cmd.Parameters.AddWithValue("@FraseTimes", times.FrasesTimes);

                SqlParameter nv = cmd.Parameters.Add("@CodTimes", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;

                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Cadastro Efetuado com Sucesso, Deseja executar um novo cadastro?",
                    "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    times.Retorno = "Sim";
                    return;
                    // TelaCadastrarTimes telaCadastrar = new TelaCadastrarTimes();
                    // telaCadastrar.abrirCadastro();
                }
                else
                {
                    times.Retorno = "Não";
                    return;
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        public void pesquisarCodigoTimes()
        {
            SqlConnection cn = new SqlConnection(ConexaoBD.Conectar());
            SqlCommand cmd = new SqlCommand("pBuscaCodigoTimes", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@CodTimes", times.CodTimes);
                cn.Open();

                var arrayDados = cmd.ExecuteReader();

                if (arrayDados.Read())
                {
                    times.CodTimes = Convert.ToInt32(arrayDados["CodTimes"]);
                    times.NomeTimes = arrayDados["NomeTimes"].ToString();
                    times.FrasesTimes = arrayDados["FraseTimes"].ToString();
                    times.LogoTimes = (System.Array)arrayDados["LogoTimes"];
                    times.Retorno = "Sim";

                }
                else
                {
                    MessageBox.Show("Código Não Localizado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    times.Retorno = "Não";
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void deletarTimes()
        {
            SqlConnection cn = new SqlConnection(ConexaoBD.Conectar());
            SqlCommand cmd = new SqlCommand("pDeletarTimes", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
