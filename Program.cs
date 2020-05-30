using System;

namespace Herança
{
    class Pessoa
    {
        public string nome {get;set;}
        
        public Pessoa(string nome){
            this.nome = nome;
        }
        public string Saudacao(){
            return "Olá , meu nome é"+nome;
        }
    }

    class CPF : Pessoa
    {
        public string cpf {get;set;}
        public string rg {get;set;}


        public CPF(string nome , string cpf, string rg)
        {
            this.cpf = cpf;
            this.rg = rg;
            this.nome = nome;
        }

        public bool ValidarCPF(string cpf){
            if (cpf.Length == 11){
                return true;
            }
            return false;
        }

    }
    class CNPJ : Pessoa
    {
        public string cnpj {get;set;}
        public CNPJ(string cnpj){
            this.cnpj = cnpj;
        }
        public bool ValidarCNPJ(string cnpj){
            if(cnpj.Length == 14){
                return true;
            }
            return false;s
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
