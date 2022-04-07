using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaAulaExercicioNelio
{
    internal class SavingAccount : Account
    //Herança se consegue com :
    {
        public double interestRate { get; set; }
        //Atributo que vai ser encapsulado na classe principal com protected


        public SavingAccount()
        //Contrutor vazio, para ser instanciado ex: b.number
        {

        }
        public SavingAccount(int number, string holder, double balance, double interstR) : base(number, holder, balance)
        //Contrutor com parâmetros, ou seja obriga o cliente a dar todos os dados antes de iniciar
        //base: evita a repetição de código
        {
            this.interestRate = interstR;
        }
        public  override void Witdraw (double amount)
            //classe herdada e sobrescrita
            {
                base.Witdraw (amount);
                  Balance -= 2;
            }
        public override string ToString()
        {
            return Number + GetHolder() + Balance;
        }




    }
  
}
