using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandyme_Felix_PRG281_ST
{
    abstract class Student
    {
        double average;
        double fees;
        string results;
        string studentType;
        string studName;
        int studNumber;
        double payment;

        public int StudNumber { get => studNumber; set => studNumber = value; }
        public string StudName { get => studName; set => studName = value; }
        public double Average { get => average; set => average = value; }
        public string Results { get => results; set => results = value; }
        public double Fees { get => fees; set => fees = value; }
       
        public double Payment { get => payment; set => payment = value; }
        public string StudentType { get => studentType; set => studentType = value; }

        /*public override double calculatePayment()
        {

            return Payment = (Payment - (Payment * Payment));
            
        }*/

        public Student(int studentnumber, string studentname, double ave, string res,  double fee, double pay, string stype)
        {
            this.studName = studentname;
            this.average = ave;
            this.studNumber = studentnumber;
            this.results = res;
            this.studentType = stype;
            this.Fees = fee;
            this.payment = pay;


        }

       
        public override string ToString()
        {
            return string.Format("{0} \t {1} \t {2} \t {3} \t {4} \t {5}", StudNumber, StudName, Average, Results, Fees, Payment);
        }

    }
}
