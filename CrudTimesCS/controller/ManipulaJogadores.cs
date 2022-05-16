using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CrudTimesCS.model;
using System.Windows.Forms;
using CrudTimesCS.view;

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
    }
}
