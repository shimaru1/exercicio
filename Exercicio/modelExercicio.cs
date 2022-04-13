using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class ArmazeneoValor
    {
        private int A;
        private int B;
        private int C;
        // declarando variavel
        public ArmazeneoValor()
        {
            //variavel
            ValorA = 0;
            ValorB = 0;
            ValorC = 0;

        }// metodo contruiçao

        //Métodos de acesso consultar e Modificar
        public int ValorA
        {

            get
            {
                return A;
            }
            set
            {
                this.A = value;
            }


            
        }//fim metodo modificar A

        public int ValorB
        {

            get
            {
                return B;
            }
            set
            {
                this.B = value;
            }

        }//fim metodo modificar B

        public int ValorC
        {

            get
            {
                return C;
            }
            set
            {
                this.C = value;
            }

        }//fim metodo modificar C

        //metodo Exercicio01
        public string Exercicio01()
        {

            ValorC = ValorA;
            ValorA = ValorB;
            ValorB = ValorC;
            return "A: " + "\nB: " + ValorB;

        }//fim do metodo exercicio 01

        public int Exercicio02(int num)
        {
            return num - 1;

        }

        public double Exercicio03(double num1 , double num2 )
        {
            return num1 * num2 ;
           
        }

        public int Exercicio04(int dias, int ano, int mes)
        {
            return (ano * 365) + mes * 30 + dias;

        }
        public double Exercicio05(double , double , double , double ,)
        {
            return ;
            
        }
        public

    }//fim da classe


}
