using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoConstrutor
{
    class Pessoa
    {
        public string nome;
        public string sobrenome;
        public int anoNascimento;
        public int idade;

        public Pessoa()
        {
            nome = "Desconhecido";
            sobrenome = "Nenhum";
            anoNascimento = 0;
            idade = 0;
        }

        public Pessoa(string nome, string sobrenome, int anoNascimento)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.anoNascimento = anoNascimento;
            idade = Idade();
        }

        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.anoNascimento = 2002;
            idade = Idade();
        }

        private int Idade()
        {
            return 2020 - anoNascimento;
        }
    }
}
