using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace HerancaAulaExercicioNelio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account conta=new Account();

            //conta é do tipo Account, da mesma forma q temos numero do tipo double
            //atributos e métodos

               Console.WriteLine("Digite o número da conta");
               int cont = int.Parse(Console.ReadLine());
               Console.WriteLine("Digite o nome do user:");
               string nome = Console.ReadLine();
               Console.WriteLine("Digite o deposito inicial");
               double saldo = double.Parse(Console.ReadLine());
               Console.WriteLine("Deseja conta Empresarial 'E', se deseja conta poupança 'P', ou digite qualquer outra coisa");
               string decisao= Console.ReadLine();
            
           

            if (decisao == "E" || decisao == "e")
            {   
                Console.WriteLine("Digite o valor do emprétimo(Loan)");
                double emp = double.Parse(Console.ReadLine().ToString());

                conta = new BusinessAccount(cont,nome,saldo,emp);  
              
       
            }
            else if (decisao == "P" || decisao == "p")
            {
                double juro = 0.01;
                conta = new SavingAccount(cont, nome, saldo, juro);
               
            }
            else
            {
                conta = new Account(cont, nome, saldo);
            }


            Console.WriteLine(conta);
            Console.WriteLine("Deseja fazer saque ");
            string deci =Console.ReadLine();
           
            if (deci == "S" || deci == "s")
            {
                Console.WriteLine("Digite o valor");
                double saque = double.Parse(Console.ReadLine().ToString());
                conta.Witdraw(saque);
                Console.WriteLine(conta);

            }
            Console.WriteLine(conta);

                



            /*double gustavo = 1.1;
            int gu = 0;
            
            gu= Convert.ToInt32(gustavo);
            Console.WriteLine(gu);
            */

        }
    }
}
