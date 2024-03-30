using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandyme_Felix_PRG281_ST
{
    class FullTime:Student
    {
        public FullTime(int num, string name, double avera, string res, double fee, double payed, string typestude): base(num, name, avera, res, fee, payed, typestude)
        {

        }

        /*public override double calculatePayment()
        {
            return  Payment = (Payment - (Payment * Payment));
        }*/
        public override string ToString()
        {
            return string.Format("{0} \t {1} \t {2} \t {3} \t {4} \t {5}", StudNumber, StudName, Average, Results, Fees, Payment);
        }
    }
}
