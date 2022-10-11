using Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Forms.Data
{
    public class PacienteRepository
    {
        public PessoaRepository PessoaRepository = new PessoaRepository();
        public EnderecoRepository EnderecoRepository = new EnderecoRepository();

        public Paciente Save(Paciente paciente, Endereco endereco = null)
        {
            try
            {
                MySqlConnection conn = ConnectionMySQL.GetConnection();

                paciente.Pessoa.Id = PessoaRepository.Save(paciente.Pessoa, conn);

                if (paciente.Pessoa.Id > 0)
                {
                    if (endereco != null)
                    {
                        endereco.Pessoa = paciente.Pessoa;
                        EnderecoRepository.Save(endereco, conn);
                    }

                    paciente.Id = SavePaciente(paciente, conn);
                }

                conn.Close();
                return paciente;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private Int32 SavePaciente(Paciente paciente, MySqlConnection conn)
        {
            try
            {
                

                MySqlCommand cmd = new MySqlCommand(SQL_INSERT_PACIENTE, conn);
                cmd.Parameters.Add("@id_pessoa", MySqlDbType.Int32).Value = paciente.Pessoa.Id;
                cmd.Parameters.Add("@id_convenio", MySqlDbType.Int32).Value = paciente.Convenio.Id;
                cmd.Parameters.Add("@numero_prontuario", MySqlDbType.VarChar, 50).Value = NrProntuario();
                cmd.Parameters.Add("@paciente_risco", MySqlDbType.Enum).Value = PacienteRisco();

                cmd.ExecuteNonQuery();
                return (Int32)cmd.LastInsertedId;

            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public bool Update(Paciente paciente)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_UPDATE_PACIENTE, conn);
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = paciente.Id;
                cmd.Parameters.Add("@id_convenio", MySqlDbType.Int32).Value = paciente.Convenio.Id;
                cmd.Parameters.Add("@numero_prontuario", MySqlDbType.Int32).Value = NrProntuario();
                cmd.Parameters.Add("@paciente_risco", MySqlDbType.VarChar, 5).Value = PacienteRisco();

                MySqlDataReader reader = cmd.ExecuteReader();

                return true;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                MySqlConnection conn = ConnectionMySQL.GetConnection();
                MySqlCommand cmd = new MySqlCommand(SQL_DELETE_PACIENTE, conn);
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

                cmd.ExecuteReader();
                return true;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public MySqlDataReader GetPacientes()
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_PACIENTES, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                return reader;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public MySqlDataReader GetPacienteById(int idPaciente)
        {
            try
            {
                MySqlConnection conn = ConnectionMySQL.GetConnection();
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_PACIENTE_BY_ID, conn);
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = idPaciente;
                MySqlDataReader dataReader = cmd.ExecuteReader();

                return dataReader;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }


        #region SQLs

        private const String SQL_SELECT_PACIENTES = @"SELECT * FROM paciente";
        private const String SQL_INSERT_PACIENTE = @"INSERT INTO paciente
(id_pessoa,
id_convenio,
numero_prontuario,
paciente_risco,
flstatus,
flobito)
VALUES
(@id_pessoa,
@id_convenio,
@numero_prontuario,
@paciente_risco,
'A',
0)";
        private const String SQL_UPDATE_PACIENTE = @"UPDATE paciente
SET
id_convenio = @id_convenio,
numero_prontuario = @numero_prontuario,
paciente_risco = @paciente_risco,
WHERE id = @id;";
        private const String SQL_DELETE_PACIENTE = @"DELETE FROM paciente WHERE id = @id";
        private const String SQL_SELECT_PACIENTE_BY_ID = @"select p.id,
	   pa.id as id_paciente,
       p.nome,
       p.cgccpf,
       p.tipopessoa,
       pa.numero_prontuario,
       pa.id_convenio,
       c.nome,
       e.CEP,
       e.rua,
       e.numero,
       e.bairro,
       e.cidade,
       e.uf
from pessoa p
join paciente pa 
	on pa.id_pessoa = p.id
join convenio c 
	on pa.id_convenio = c.id
join endereco e 
	on e.id_pessoa = p.id
WHERE p.id = @id";

        #endregion

        #region PacRisco/NrProntuario
        public String PacienteRisco()
        {
            Random rd = new Random();
            string[] riscoPac = { "ALTO", "MEDIO", "BAIXO" };
            return riscoPac[rd.Next(0, riscoPac.Length)];
        }

        public Int32 NrProntuario()
        {
            Random rd = new Random();
            int prontuario = rd.Next(111, 888) + DateTime.Now.Second;
            return prontuario;
        }
        #endregion
    }
}
