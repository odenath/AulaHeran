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
        
        public void Loann(double amount)
        {
            if (amount <= Loan)
            {
                Balance += amount;
            }
        }
       
        
        public override string ToString()
        {
            return Number+GetHolder()+Balance+Loan;
        }







    }
}
