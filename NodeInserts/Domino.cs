using NodeClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeInserts
{
    public class Domino
    {
        private int num1;
        private int num2;

        public Domino(int num1,int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        public int GetNum1() { return num1; }
        public int GetNum2() { return num2; }
        public void SetNum1(int num1) { this.num1 = num1; }
        public void SetNum2(int num2) {  this.num2 = num2; }

       

    }
}
