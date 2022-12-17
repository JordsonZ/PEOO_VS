using System;
using System.Collections.Generic;
using System.Text;

namespace EstadoCidadeApp
{
    class Estado
    {
        private string nome;
        private double area;
        private Cidade[] cidades = new Cidade[10];
        private int k = 0;

        public Estado(string n)
        {
            nome = n;
        }
        public void SetArea(double a)
        {
            area = a;
        }
        public double GetArea()
        {
            return area;
        }
        public void Inserir(Cidade c)
        {
            cidades[k] = c;
            k++;
        }
        public Cidade[] Listar()
        {
            Cidade[] vetor = new Cidade[k];
            Array.Copy(cidades, vetor, k);
            return vetor;
        }
        public int Populacao()
        {
            int Total;
            int populacao = 0;
            for (int i = 1; i >= k; i++)
            {
                Total = populacao++;
            }
            return Populacao();
        }         
        public override string ToString()
        {
            return $"{Listar()} - {nome} - {Populacao()}";
        }
    }
    class Cidade : object
    {
        private string nome;
        private double area;
        private int populacao;
        public Cidade(string n)
        {
            nome = n;
        }
        public void SetArea(double a)
        {
            this.area = a;
        }
        public void SetPopulacao(int p)
        {
            this.populacao = p;
        }
        public string GetNome()
        {
            return nome;
        }
        public int GetPopulacao()
        {
            return this.populacao;
        }
        public override string ToString()
        {
            return $"{nome} - {area} - {populacao}";
        }
    }
}
