using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class ControlExercicio
    {
        //ligar as duas classe
        ArmazeneoValor valor;
        public int opcao;
        public double num1;
        public double num2;
        public double ano;
        public double mes;
        public ControlExercicio()
        {
            valor = new ArmazeneoValor();

        }

        public int ConsultarOpcao
        {
            get
            {
                return opcao;
            }
            set
            {
                this.opcao = value;
            }

        }

        public void Menu()
        {
            Console.WriteLine("-----Menu-----" +
                "\n1. Exercicio 01" +
                "\n2. Exercicio 02" +
                "\n3. Exercicio 03" +
                "\n4. Exercicio 04");
            Console.WriteLine("Escolha uma das opções acima: ");
            ConsultarOpcao = Convert.ToInt32(Console.ReadLine());
        }//fim menu 
        public void Executar()
        {

            Menu();
            switch (ConsultarOpcao)
            { 
                case 1:
               Console.WriteLine (valor.Exercicio01());
                break;

                case 2:
                    Console.WriteLine("informe um numero: ");
                    int A = Convert.ToInt32(Console.ReadLine());
         
                    Console.WriteLine("O antecessor de " + A + "é: " + valor.Exercicio02(A));
                break;

                case 3:
                    do
                    {
                        Console.WriteLine("informe numero da base: ");
                       double num1 = Convert.ToDouble(Console.ReadLine());
                        if(num1 <= 0)
                        {
                            Console.WriteLine("Base digitatada não é valida, digite novamente!");
                        }
                    
                    } while (num1 <= 0);

                    do
                    {
                        Console.WriteLine("informe nemero da Aitura: ");
                        double num2 = Convert.ToDouble(Console.ReadLine());
                        if (num2 <=0)
                        {
                            Console.WriteLine("Altura digitada não é valida, digite novamente!");
                        }

                    } while (num2 <= 0);

                        break;

                case 4:
                    do
                    {
                        Console.WriteLine("Informe sua anos: ");
                        int ano = Convert.ToInt32(Console.ReadLine());
                        if (ano <= 0)
                        {
                            Console.WriteLine("idade invalida digite novamente!");
                        }

                    } while (ano <= 0);

                    do
                    {
                        Console.WriteLine("informe quantos meses voce tem: ");
                        int mes = Convert.ToInt32(Console.ReadLine());
                        if (mes <= 0) 
                        {
                            Console.WriteLine("sua idade invalida digite novamente!"); 
                        }
                        
                    }while( mes <=0);

                    do
                    {

                        Console.WriteLine("informe quantos meses voce tem: ");
                        int dias = Convert.ToInt32(Console.ReadLine());
                        if (dias <= 0) 
                        {
                            Console.WriteLine("sua idade invalida digite novamente!");
                        }

                    } while (dias <= 0); 
                    
                    break;

                default:
                Console.WriteLine("Código digitado não é valido!");
                break;
            }
        }
    }

}
