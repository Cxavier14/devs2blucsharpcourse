using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Utils
{
    public class Mocks
    {
        public List<Paciente> ListaPacientes { get; set; }
        public List<Medico> ListaMedicos { get; set; }
        public List<Recepcionista> ListaRecepcionistas { get; set; }
        public List<Fornecedor> ListaFornecedores { get; set; }

        public Mocks()
        {
            ListaPacientes = new List<Paciente>();
            ListaMedicos = new List<Medico>();
            ListaRecepcionistas = new List<Recepcionista>();
            ListaFornecedores = new List<Fornecedor>();

            CargaMock();
        }

        public void CargaMock()
        {
            CargaPacientes();
            CargaMedicos();
        }

        List<string> Especialidades = new List<string> 
        { "Clinica Geral", "Cardiologia", "Dermatologia", "Endocrinologia","Geriatria", "Ginecologia",
        "Mastologia", "Neurologia", "Oftalmologia", "Ortopedia", "Pediatria"};

        public void CargaPacientes()
        {
            for (int i = 0; i < 10; i++)
            {
                Paciente paciente = new Paciente(i, $"Paciente {i}", $"{i}{i}{i}888444666", "Unimed");
                ListaPacientes.Add(paciente);
            }
        }

        public void CargaMedicos()
        {
            Random rd = new Random();
            for (int i = 0; i < 10; i++)
            {
                string especialidades = Especialidades[rd.Next(1,11)].ToString();
                Medico medico = new Medico(i, $"Medico {i}", $"{i}{i}{i}887744", rd.Next(1, 1000), especialidades);
                ListaMedicos.Add(medico);
            }
        }
    }
}
