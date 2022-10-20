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
    public class PessoaRepository
    {
        public Int32 Save(Pessoa pessoa, MySqlConnection conn)
        {
            try
            {
                conn = ConnectionMySQL.GetConnection();
                return SavePessoa(pessoa, conn);

            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private Int32 SavePessoa(Pessoa pessoa, MySqlConnection conn)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_INSERT_PESSOA, conn);
                cmd.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = pessoa.Nome;
                cmd.Parameters.Add("@cgccpf", MySqlDbType.VarChar, 50).Value = pessoa.CGCCPF;
                cmd.Parameters.Add("@tipopessoa", MySqlDbType.Enum).Value = pessoa.TipoPessoa;

                cmd.ExecuteNonQuery();
                return (Int32)cmd.LastInsertedId;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public MySqlDataReader GetPessoas()
        {
            try
            {
                MySqlConnection conn = ConnectionMySQL.GetConnection();
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_PESSOAS, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                return reader;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public bool Update(Pessoa pessoa, MySqlConnection conn)
        {
            try
            {
                conn = ConnectionMySQL.GetConnection();
                MySqlCommand cmd = new MySqlCommand(SQL_UPDATE_PESSOA, conn);
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = pessoa.Id;
                cmd.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = pessoa.Nome;
                cmd.Parameters.Add("@cgccpf", MySqlDbType.VarChar, 25).Value = pessoa.CGCCPF;
                cmd.Parameters.Add("@flstatus", MySqlDbType.Enum).Value = pessoa.Status;

                cmd.ExecuteReader();
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
                MySqlCommand cmd = new MySqlCommand(SQL_DELETE_PESSOA, conn);
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

        #region SQLs
        private const String SQL_SELECT_PESSOA = @"SELECT * FROM pessoa";
        private const String SQL_INSERT_PESSOA = @"INSERT INTO pessoa
(nome,
cgccpf,
tipopessoa,
flstatus)
VALUES
(@nome,
@cgccpf,
@tipopessoa,
'A')";
        private const String SQL_UPDATE_PESSOA = @"UPDATE pessoa
SET
id = @id,
nome = @nome,
cgccpf = @cgccpf,
flstatus = @flstatus
WHERE id = @id;";
        private const String SQL_DELETE_PESSOA = @"DELETE FROM pessoa WHERE id = @id";


        private const String SQL_SELECT_PESSOAS = @"SELECT p.id as Código, 
       p.nome Nome, 
       cgccpf CPF, 
       p.flstatus Status, 
       pa.numero_prontuario Prontuário, 
       pa.paciente_risco as Risco, 
       (select nome from convenio where id = pa.id_convenio) Convênio, 
       e.CEP, 
       e.Rua, 
       numero as Número, 
       bairro as Bairro,
       cidade as Cidade, 
       UF as Estado
        FROM pessoa p 
        LEFT JOIN endereco e ON p.id = e.id_pessoa
        LEFT JOIN paciente pa ON p.id = pa.id_pessoa";
        #endregion
    }
}
