using MySql.Data.MySqlClient;
using ProjetoDevs2Blu.SistemaContatos.ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDevs2Blu.SistemaAgendaContatos.Data
{
    public class CompromissoRepository
    {
        public bool Save(Compromisso compromisso, MySqlConnection conn)
        {
            try
            {
                conn = ConnectionMySQL.GetConnection();
                return (SaveCompromisso(compromisso, conn)) > 0;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private Int32 SaveCompromisso(Compromisso compromisso, MySqlConnection conn)
        {
            if(compromisso.Contato.Id <= 0 || compromisso.Contato.Id == null)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(SQL_INSERT_COMPROMISSO, conn);
                    cmd.Parameters.Add("@titulo", MySqlDbType.VarChar, 45).Value = compromisso.Titulo;
                    cmd.Parameters.Add("@diassemana", MySqlDbType.Enum).Value = compromisso.Dia;
                    cmd.Parameters.Add("@data", MySqlDbType.Date).Value = compromisso.Data;
                    cmd.Parameters.Add("@flstatus", MySqlDbType.Enum).Value = compromisso.Status;

                    cmd.ExecuteNonQuery();
                    return (int)cmd.LastInsertedId;
                }
                catch (MySqlException myExc)
                {
                    MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
            else
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(SQL_INSERT_COMPROMISSO_IDCONTATO, conn);
                    cmd.Parameters.Add("id_contato", MySqlDbType.Int32).Value = compromisso.Contato.Id;
                    cmd.Parameters.Add("@titulo", MySqlDbType.VarChar, 45).Value = compromisso.Titulo;
                    cmd.Parameters.Add("@diassemana", MySqlDbType.Enum).Value = compromisso.Dia;
                    cmd.Parameters.Add("@data", MySqlDbType.Date).Value = compromisso.Data;
                    cmd.Parameters.Add("@flstatus", MySqlDbType.Enum).Value = compromisso.Status;

                    cmd.ExecuteNonQuery();
                    return (int)cmd.LastInsertedId;
                }
                catch (MySqlException myExc)
                {
                    MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
            

        }

        public MySqlDataReader GetAllCompromissos()
        {
            try
            {
                MySqlConnection conn = ConnectionMySQL.GetConnection();
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_COPROMISSO, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                return reader;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public bool Update(Compromisso compromisso, MySqlConnection conn)
        {
            if (compromisso.Contato.Id <= 0 || compromisso.Contato.Id == null)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(SQL_UPDATE_COPROMISSO, conn);
                    cmd.Parameters.Add("@titulo", MySqlDbType.VarChar, 45).Value = compromisso.Titulo;
                    cmd.Parameters.Add("@diassemana", MySqlDbType.Enum).Value = compromisso.Dia;
                    cmd.Parameters.Add("@data", MySqlDbType.Date).Value = compromisso.Data;
                    cmd.Parameters.Add("@flstatus", MySqlDbType.Enum).Value = compromisso.Status;

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
            else
            {
                MySqlCommand cmd = new MySqlCommand(SQL_UPDATE_COPROMISSO_IDCONTATO, conn);
                cmd.Parameters.Add("@id_contato", MySqlDbType.Int32).Value = compromisso.Contato.Id;
                cmd.Parameters.Add("@titulo", MySqlDbType.VarChar, 45).Value = compromisso.Titulo;
                cmd.Parameters.Add("@diassemana", MySqlDbType.Enum).Value = compromisso.Dia;
                cmd.Parameters.Add("@data", MySqlDbType.Date).Value = compromisso.Data;
                cmd.Parameters.Add("@flstatus", MySqlDbType.Enum).Value = compromisso.Status;

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                return false;
            }                
        }

        public bool Delete(int id)
        {
            try
            {
                MySqlConnection conn = ConnectionMySQL.GetConnection();
                MySqlCommand cmd = new MySqlCommand(SQL_DELETE_COPROMISSO, conn);
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

        #region SQLs

        private const String SQL_INSERT_COMPROMISSO_IDCONTATO = @"INSERT INTO compromisso
(id_contato,
titulo,
diassemana,
data,
flstatus)
VALUES
(@id_contato,
@titulo,
@diassemana,
@data,
A);";
        private const String SQL_INSERT_COMPROMISSO = @"INSERT INTO compromisso
(titulo,
diassemana,
data,
flstatus)
VALUES
(@titulo,
@diassemana,
@data,
A);";
        private const String SQL_UPDATE_COPROMISSO_IDCONTATO = @"UPDATE compromisso
SET
id_contato = @id_contato,
titulo = @titulo,
diassemana = @diassemana,
data = @data,
flstatus = @flstatus
WHERE id = @id";
        private const String SQL_UPDATE_COPROMISSO = @"UPDATE compromisso
SET
titulo = @titulo,
diassemana = @diassemana,
data = @data,
flstatus = @flstatus
WHERE id = @id";
        private const String SQL_SELECT_COPROMISSO = @"SELECT * FROM compromisso";
        private const String SQL_DELETE_COPROMISSO = @"DELETE FROM compromisso WHERE id = @id";
        #endregion
    }
}
