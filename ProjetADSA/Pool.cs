using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetADSA
{
    class Pool
    {
        List<Team> order = new List<Team>(4);
        Match[,] matchDay = new Match[6,2];

        Team t1;
        Team t2;
        Team t3;
        Team t4;

        public Pool(Team t1, Team t2, Team t3, Team t4)
        {
            this.t1 = t1;
            this.t2 = t2;
            this.t3 = t3;
            this.t4 = t4;

            order.Add(t1);
            order.Add(t2);
            order.Add(t3);
            order.Add(t4);

            schedul();
        }
        
        public void schedul()
        {
            Match m1 = new Match(this.t1, this.t2, typeOfMatch.pool);
            Match m2 = new Match(this.t3, this.t4, typeOfMatch.pool);

            Match m3 = new Match(this.t3, this.t1, typeOfMatch.pool);
            Match m4 = new Match(this.t2, this.t4, typeOfMatch.pool);

            Match m5 = new Match(this.t1, this.t4, typeOfMatch.pool);
            Match m6 = new Match(this.t2, this.t3, typeOfMatch.pool);

            Match m7 = new Match(this.t4, this.t1, typeOfMatch.pool);
            Match m8 = new Match(this.t3, this.t2, typeOfMatch.pool);

            Match m9 = new Match(this.t2, this.t1, typeOfMatch.pool);
            Match m10 = new Match(this.t4, this.t3, typeOfMatch.pool);

            Match m11 = new Match(this.t1, this.t3, typeOfMatch.pool);
            Match m12 = new Match(this.t4, this.t2, typeOfMatch.pool);

            matchDay[0, 0] = m1;
            matchDay[0, 1] = m2;

            matchDay[1, 0] = m3;
            matchDay[1, 1] = m4;

            matchDay[2, 0] = m5;
            matchDay[2, 1] = m6;

            matchDay[3, 0] = m7;
            matchDay[3, 1] = m8;

            matchDay[4, 0] = m9;
            matchDay[4, 1] = m10;

            matchDay[5, 0] = m11;
            matchDay[5, 1] = m12;
        }

        public List<Team> Order
        {
            get
            {
                return order;
            }
        }

        public void rank(int number)
        {
            order.Sort();
        }

        public override string ToString()
        {
            string display = "";

            foreach(Team t in order)
            {
                display += t.ToString() + "\n";
            }
 
            return display;
        }

        public void playPool()
        {
            for(int i = 0; i < this.matchDay.GetLength(0); i++)
            {
                for(int j = 0; j < this.matchDay.GetLength(1); j++)
                {
                    this.matchDay[i, j].playMatch();
                }
            }
        }



    }
}
