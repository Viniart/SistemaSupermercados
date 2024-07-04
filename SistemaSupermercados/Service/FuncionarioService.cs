using SistemaSupermercados.Models;
using SistemaSupermercados.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSupermercados.Service
{
    public class FuncionarioService
    {
        private List<Funcionario> funcionarios;
        int id = 1;

        public FuncionarioService()
        {
            funcionarios = new List<Funcionario>();
        }

        public void Cadastrar(Funcionario funcionario)
        {
            funcionario.Id = id;
            funcionarios.Add(funcionario);
            id++;
        }


        public void Listar()
        {
            foreach (var f in funcionarios)
            {
                DisplayHelper.ExibirFuncionario(f);
            }
        }

        public List<Funcionario> RetornarLista()
        {
            return funcionarios;
        }

        public bool Atualizar(int id, Funcionario funcionario)
        {
            Funcionario funcionarioLista = funcionarios.Find(p => p.Id == id);
            if (funcionarioLista != null)
            {
                funcionarioLista.Nome = funcionario.Nome;
                funcionarioLista.Cargo = funcionario.Cargo;
                funcionarioLista.NumeroRegistro = funcionario.NumeroRegistro;
                funcionarioLista.HorarioTrabalho = funcionario.HorarioTrabalho;

                // Se retornar true (verdadeiro) quer dizer que ele conseguiu achar o funcionario e atualizar
                return true;
            }
            // Se retornar false (falso) quer dizer que ele não conseguiu achar o funcionario
            return false;
        }

        public bool Deletar(int id)
        {
            Funcionario funcionario = funcionarios.Find(p => p.Id == id);
            if (funcionario != null)
            {
                funcionarios.Remove(funcionario);
                return true;
            }
            return false;
        }
    }
}
