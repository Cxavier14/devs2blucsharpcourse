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
            CargaRecepcionistas();
            CargaFornecedor();
        }

        public void CargaPacientes()
        {
            Random rd = new Random();
            string[] convenios = { "Unimed", "Clinipan", "Amil", "SulAmerica" };

            for (int i = 0; i < 10; i++)
            {
                Paciente paciente = new Paciente(i, $"Paciente {i}", $"{i}{i}{i}888444666", convenios[rd.Next(0, convenios.Length)]);
                ListaPacientes.Add(paciente);
            }
        }

        public void CargaMedicos()
        {
            Random rd = new Random();
            string[] especialidade = { "Clinico Geral", "Cardiologista", "Endocrinologista",
                                        "Neurologista", "Oftalmologista", "Pediatra" };

            for (int i = 0; i < 6; i++)
            {
                Medico medico = new Medico(i, $"Médico {i}", $"{i}{i}{i}887744", rd.Next(1, 1000),
                    especialidade[rd.Next(0, especialidade.Length)]);
                ListaMedicos.Add(medico);
            }
        }

        public void CargaRecepcionistas()
        {
            Random rd = new Random();
            string[] setores = { "Ambulatório", "Exames", "Internação", "Centro Cirúrgico", "UTI", "Pronto Socorro", "Serviços Assistenciais" };

            for (int i = 0; i < 10; i++)
            {
                Recepcionista recepcionista = new Recepcionista(i, $"Recepcionista {i}", $"{rd.Next(160, 777)}55566677",
                    setores[rd.Next(0, setores.Length)]);
                ListaRecepcionistas.Add(recepcionista);
            }
        }

        public void CargaFornecedor()
        {
            Random rd = new Random();
            string[] tiposFornecedores = { "Medicamentos Geral", "Medicamentos Importados", "Materiais de Limpeza", "Materiais Cirurgicos" };

            for (int i = 0; i < 10; i++)
            {
                Fornecedor fornecedor = new Fornecedor(i, $"Fornecedor {i}", $"{rd.Next(122, 999)}000134",
                    tiposFornecedores[rd.Next(0, tiposFornecedores.Length)]);
                ListaFornecedores.Add(fornecedor);
            }
        }
    }
}
