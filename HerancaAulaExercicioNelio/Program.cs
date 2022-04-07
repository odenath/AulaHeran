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
            Account conta;
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
                Console.WriteLine("Digite o valor do emprétimo");
                double emp = double.Parse(Console.ReadLine().ToString());

                conta = new BusinessAccount(cont,nome,saldo,emp);
                Console.WriteLine(conta);
                Console.WriteLine("Deseja fazer deposito");
                int dep = int.Parse(Console.ReadLine().ToString());
                conta.Deposit(dep);
                Console.WriteLine(conta);
                Console.WriteLine("Deseja fazer um deposito");
            }
            else if (decisao == "P" || decisao == "p")
            {
                double juro = 0.01;
                conta = new SavingAccount(cont, nome, saldo, juro);
                Console.WriteLine(conta.ToString());
                Console.WriteLine("Deseja fazer deposito");
                int dep = int.Parse(Console.ReadLine().ToString());
                conta.Deposit(dep);
                Console.WriteLine(conta);


            }
            Console.WriteLine(conta);



            double gustavo = 1.0;
            int gu = 0;
            
            gu= Convert.ToInt32(gustavo);
            Console.WriteLine(gu);


        }
    }
}
