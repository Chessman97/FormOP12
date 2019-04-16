using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTable
{
    class Record
    {
        private int number;
        private int numberCalc;

        private String recname;
        private int code;
        private int colRelise, costFact, sumFact, costEnterprise, sumEnterprise;
        private String note;

        public Record(int number, int numberCalc, String recname, int code, int colRelise, int costFact, int sumFact,
            int costEnterprise, int sumEnterprise, String note)
        {        
            this.number = number;
            this.numberCalc = numberCalc;
            this.recname = recname;
            this.code = code;
            this.colRelise = colRelise;
            this.costFact = costFact;
            this.sumFact = sumFact;
            this.costEnterprise = costEnterprise;
            this.sumEnterprise = sumEnterprise;
            this.note = note;
        }

        public void setRec(String currentName, int costFact_, int costEnterprise_)
        {
            if (currentName == "Борщ")
            {
                numberCalc = 114;
                code = 9412;
                if (costFact_ == 0)
                    costFact = 35;               
                calcSumFact();
                if (costEnterprise_ == 0)
                    costEnterprise = 15;
                calcSumEnter();
            }
            else if(currentName == "Оливье")
                 {
                     numberCalc = 118;
                     code = 6542;
                     if (costFact_ == 0)
                        costFact = 40;
                     calcSumFact();
                     if (costEnterprise_ == 0)
                        costEnterprise = 13;
                     calcSumEnter();
                 }
                 else if (currentName == "Манты")
                      {
                        numberCalc = 126;
                        code = 7333;
                        if (costFact_ == 0)
                            costFact = 80;
                        calcSumFact();
                        if (costEnterprise_ == 0)
                            costEnterprise = 45;
                        calcSumEnter();
                      }
                      else if (currentName == "Чай")
                            {
                                numberCalc = 173;
                                code = 5431;
                                if (costFact_ == 0)
                                    costFact = 15;
                                calcSumFact();
                                if (costEnterprise_ == 0)
                                    costEnterprise = 3;
                                calcSumEnter();
                            }

        }
        private void calcSumFact()
        {
            sumFact = colRelise * costFact;
        }
        private void calcSumEnter()
        {
            sumEnterprise = colRelise * costEnterprise;
        }

        public Record(int number)
        {
            this.number = number;
        }
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        public int NumberCalc
        {
            get { return numberCalc; }
            set { numberCalc = value; }
        }
        public String Recname
        {
            get { return recname; }
            set { recname = value; }
        }


        public int Code
        {
            get { return code; }
            set { code = value; }
        }

        public int ColRelise
        {
            get { return colRelise; }
            set { colRelise = value; }
        }
        public int CostFact
        {
            get { return costFact; }
            set { costFact = value; }
        }
        public int SumFact
        {
            get { return sumFact; }
            set { sumFact = value; calcSumFact(); }
        }
        public int CostEnterprise
        {
            get { return costEnterprise; }
            set { costEnterprise = value; }
        }
        public int SumEnterprise
        {
            get { return sumEnterprise; }
            set { sumEnterprise = value; calcSumEnter(); }
        }
        public String Note
        {
            get { return note; }
            set { note = value; }
        }

    }
}
