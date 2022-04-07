using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaAulaExercicioNelio
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { private get; set; }
        public double Balance { get; protected set; }
        //encapsulamento protected, apenas outras classes podem alterar o valor, mas o progam n

        public Account()
        {

        }
        



        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public string GetHolder()
        {
            return Holder;
        }

        /*public int GetNumber()
            //apenas pelo método GetNumber podemos visualizar o Number

        {
            return Number;
        }
        */

        public virtual void Witdraw(double amount)
        {
            Balance -= amount;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public override string ToString()
        {
            return "A sua conta "+Number+"Usuário"+GetHolder()+"Saldo/Balance"+Balance;
        }

    }
}
