using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
   class Account
    {
        public int accountNo;
        public string name;
        public static float rateOfInterest = 10.9f;

       public Account(int accountNo,string name)
        {
            this.accountNo = accountNo;
            this.name = name;
        }
        public void display()
        {
            Console.WriteLine(accountNo+" "+name+" "+rateOfInterest);
        }
    }
    class TestAccount
    {
        public static void Main() {
            Account.rateOfInterest = 15.08f;
            Account account1 = new Account(12, "abc");
            Account account2 = new Account(78, "efg");
            account1.display();
            account2.display();



        }
    }
}
