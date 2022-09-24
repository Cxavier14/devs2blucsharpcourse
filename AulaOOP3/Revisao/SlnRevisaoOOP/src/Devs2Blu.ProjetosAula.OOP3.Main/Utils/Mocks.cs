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
            CargaRecepcionista();
        }

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
            string[] especialidade = { "Clinico Geral", "Cardiologista", "Endocrinologista", "Neurologista", "Oftalmologista", "Pediatra" };

            for (int i = 0; i < 6; i++)
            {
                Medico medico = new Medico(i, $"Médico {i}", $"{i}{i}{i}887744", rd.Next(1, 1000), especialidade[rd.Next(0, especialidade.Length)]);
                ListaMedicos.Add(medico);
            }
        }

        public void CargaRecepcionista()
        {

        }
    }
}
