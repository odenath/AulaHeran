using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaAulaExercicioNelio
{
    internal class BusinessAccount:Account
    {
        public double Loan;

        public BusinessAccount()
        {

        }
        public BusinessAccount(int number, string holder, double balance,double loan) : base(number, holder, balance)
        {
            Loan = loan;
        }
        public override void Witdraw(double amount)
        {
            base.Witdraw(amount);
            Balance -= 5;
        }
        public void Loann(double amount)
        {
            if (amount <= Loan)
            {
                Balance += amount;
            }
        }
       
        
        public override string ToString()
        {
            return "A sua conta " + Number + "Usuário" + GetHolder() + "Saldo/Balance" + Balance+"Limite de empréstimo"+Loan;
        }
    }







    }

