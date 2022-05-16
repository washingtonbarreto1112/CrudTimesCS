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
                cmd.Parameters.AddWithValue("@NomeTimes",times.NomeTimes);
                cmd.Parameters.AddWithValue("@LogoTimes",times.LogoTimes);
                cmd.Parameters.AddWithValue("@FraseTimes", times.FrasesTimes);

                SqlParameter nv = cmd.Parameters.Add("@CodTimes", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;

                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Cadastro Efetuado com Sucesso, Deseja executar um novo cadastro?",
                    "Atenção",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);

                if(resposta == DialogResult.Yes)
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
            catch(Exception)
            {
                throw;
            }
        }
    }
}
