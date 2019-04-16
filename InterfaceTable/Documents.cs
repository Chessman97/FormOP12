using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTable
{
    class Documents
    {
        private static Documents instance1 = new Documents();
        private static Documents instance2 = new Documents();
        private static Documents inst3 = new Documents();
        private static Documents inst4 = new Documents();

        public static Documents getInstance1()
        {
            return instance1;
        }

        public static Documents getInstance2()
        {
            return instance2;
        }

        public static Documents getInst3()
        {
            return inst3;
        }

        public static Documents getInst4()
        {
            return inst4;
        }

        public String[] sum;
        public String str;
        public String[] re;
        public String[] revenue;
        private Documents() { }
        public void setSum(String[] sum)
        {
            this.sum = sum;
        }
        public String[] getSum()
        {
            return sum;
        }
        public void setRe(String[] re)
        {
            this.re = re;
        }
        public void setRevenue(String[] revenue)
        {
            this.revenue = revenue;
        }

        public void setStr(String str)
        {
            this.str = str;
        }
        public String[] getRe()
        {
            return re;
        }
        public String[] getRev()
        {
            return revenue;
        }
        public String getStr()
        {
            return str;
        }
    }
}
