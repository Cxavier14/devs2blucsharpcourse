using MySql.Data.MySqlClient;
using ProjetoDevs2Blu.SistemaContatos.ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDevs2Blu.SistemaAgendaContatos.Data
{
    public class ContatoRepository
    {
        public bool Save(Contato contato, Estado estado, MySqlConnection conn)
        {
            try
            {
                conn = ConnectionMySQL.GetConnection();
                return (SaveContato(contato, estado, conn)) > 0;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private Int32 SaveContato(Contato contato, Estado estado, MySqlConnection conn)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_INSERT_CONTATO, conn);
                cmd.Parameters.Add("id_estado", MySqlDbType.Int32).Value = estado.Id;
                cmd.Parameters.Add("nome", MySqlDbType.VarChar, 45).Value = contato.Nome;
                cmd.Parameters.Add("telefone", MySqlDbType.VarChar, 20).Value = contato.Telefone;
                cmd.Parameters.Add("email", MySqlDbType.VarChar, 45).Value = contato.Email;
                cmd.Parameters.Add("redesocial", MySqlDbType.VarChar, 45).Value = contato.RedeSocial;
                cmd.Parameters.Add("rua", MySqlDbType.VarChar, 45).Value = contato.Rua;
                cmd.Parameters.Add("numero", MySqlDbType.Int32).Value = contato.Numero;
                cmd.Parameters.Add("bairro", MySqlDbType.VarChar, 45).Value = contato.Bairro;
                cmd.Parameters.Add("cidade", MySqlDbType.VarChar, 45).Value = contato.Cidade;

                cmd.ExecuteNonQuery();
                return (int)cmd.LastInsertedId;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }

        public bool Update(Contato contato, Estado estado, MySqlConnection conn)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_UPDATE_CONTATO, conn);
                cmd.Parameters.Add("id_estado", MySqlDbType.Int32).Value = estado.Id;
                cmd.Parameters.Add("nome", MySqlDbType.VarChar, 45).Value = contato.Nome;
                cmd.Parameters.Add("telefone", MySqlDbType.VarChar, 20).Value = contato.Telefone;
                cmd.Parameters.Add("email", MySqlDbType.VarChar, 45).Value = contato.Email;
                cmd.Parameters.Add("redesocial", MySqlDbType.VarChar, 45).Value = contato.RedeSocial;
                cmd.Parameters.Add("rua", MySqlDbType.VarChar, 45).Value = contato.Rua;
                cmd.Parameters.Add("numero", MySqlDbType.Int32).Value = contato.Numero;
                cmd.Parameters.Add("bairro", MySqlDbType.VarChar, 45).Value = contato.Bairro;
                cmd.Parameters.Add("cidade", MySqlDbType.VarChar, 45).Value = contato.Cidade;

                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = contato.Id;
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                return false;
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
                MySqlCommand cmd = new MySqlCommand(SQL_DELETE_CONTATO, conn);
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                return false;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public MySqlDataReader GetAllContatos()
        {
            try
            {
                MySqlConnection conn = ConnectionMySQL.GetConnection();
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_CONTATO, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                return reader;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public MySqlDataReader GetContatoById(int idContato)
        {
            try
            {
                MySqlConnection conn = ConnectionMySQL.GetConnection();
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_CONTATO_BY_ID, conn);
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = idContato;
                                
                MySqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        #region SQLs

        private const String SQL_INSERT_CONTATO = @"INSERT INTO contato
(id_estado,
nome,
telefone,
email,
redesocial,
rua,
numero,
bairro,
cidade)
VALUES
(@id_estado,
@nome,
@telefone,
@email,
@redesocial,
@rua,
@numero,
@bairro,
@cidade)";
        private const String SQL_UPDATE_CONTATO = @"UPDATE contato
SET
id_estado = @id_estado,
nome = @nome,
telefone = @telefone,
email = @email,
redesocial = @redesocial,
rua = @rua,
numero = @numero,
bairro = @bairro,
cidade = @cidade
WHERE id = @id";
        private const String SQL_SELECT_CONTATO = @"SELECT c.id,
	   c.nome,
       c.telefone,
       c.email,
       c.redesocial,
       c.rua,
       c.numero,
       c.bairro,
       c.cidade,
       e.uf,
       e.descricao
FROM contato c
JOIN estado e ON c.id_estado = e.id;";
        private const String SQL_DELETE_CONTATO = @"DELETE FROM contato WHERE id = @id";
        private const String SQL_SELECT_CONTATO_BY_ID = @"SELECT * FROM contato WHERE id = @id";
        #endregion
    }
}
