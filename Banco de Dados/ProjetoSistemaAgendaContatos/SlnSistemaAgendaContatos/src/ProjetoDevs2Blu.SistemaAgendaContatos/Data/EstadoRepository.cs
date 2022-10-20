using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDevs2Blu.SistemaAgendaContatos.Data
{
    public class EstadoRepository
    {
        public MySqlDataReader FetchAll()
        {
            try
            {
                MySqlConnection conn = ConnectionMySQL.GetConnection();
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_UF, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                return reader;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public MySqlDataReader GetUfById(int id_uf)
        {
            try
            {
                MySqlConnection conn = ConnectionMySQL.GetConnection();
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_UF_BY_ID, conn);
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id_uf;
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

        private const String SQL_SELECT_UF = @"SELECT * FROM estado";
        private const String SQL_SELECT_UF_BY_ID = @"SELECT * FROM estado WHERE id = @id";
        #endregion
    }
}
