using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace ProjetADSA
{
    class Tournament
    {
        List<Pool> array = new List<Pool>(8);

        List<Team> pot1 = new List<Team>(8);
        List<Team> pot2 = new List<Team>(8);
        List<Team> pot3 = new List<Team>(8);
        List<Team> pot4 = new List<Team>(8);

        List<Team> total_team = new List<Team>();

        DirectElimination directE; 

        public Tournament()
        {
            string json = File.ReadAllText("Equipe_Tournoi.json");
            json.Replace('"', '\'');
            this.total_team = JsonConvert.DeserializeObject<List<Team>>(json);


            int i;
            total_team.Sort(Team.CoefficientSort);
            for(i=0; i < 8; i++)
            {
                this.pot1.Add(total_team[i]);
            }

            for (i=8; i < 16; i++)
            {
                this.pot2.Add(total_team[i]);
            }

            for (i=16; i < 24; i++)
            {
                this.pot3.Add(total_team[i]);
            }

            for (i=24; i < 32; i++)
            {
                this.pot4.Add(total_team[i]);
            }

            draw();


        }

        public List<Team> Total_team
        {
            get
            {
                return total_team;
            }
            set
            {
                this.total_team = value;
            }
        }

        public List<Pool> Array { get => array; }

        public DirectElimination DirectE
        {
            get
            {
                return this.directE;
            }
        }

        public void draw()
        {
            int i = 0;
            Random r = new Random();
            while (i < 8)
            {
                List<String> country = new List<string>(3);

                int take = r.Next(this.pot1.Count() - 1);
                Team a = this.pot1[take];
                pot1.RemoveAt(take);
                country.Add(a.Country);

                Team b;
                do
                {
                    if (this.pot2.Count() - 1 > 0)
                    {
                        take = r.Next(this.pot2.Count() - 1);
                    }
                    else
                    {
                        take = 0;
                    }
                    b = this.pot2[take];
                } while (b.Country == country[0]);
                pot2.RemoveAt(take);
                country.Add(b.Country);

                Team c;
                do
                {
                    if (this.pot3.Count() - 1 > 0)
                    {
                        take = r.Next(this.pot3.Count() - 1);
                    }
                    else
                    {
                        take = 0;
                    }
                    c = this.pot3[take];
                } while (c.Country == country[0] && c.Country == country[1]);
                pot3.RemoveAt(take);
                country.Add(c.Country);

                Team d;
                do
                {
                    if (this.pot4.Count() - 1 > 0)
                    {
                        take = r.Next(this.pot4.Count() - 1);
                    }
                    else
                    {
                        take = 0;
                    }
                    d = this.pot4[take];
                } while (d.Country == country[0] && d.Country == country[1] && d.Country == country[2]);
                pot4.RemoveAt(take);

                Pool p = new Pool(a, b, c, d);
                this.Array.Add(p);

                i++;
            }

            playPool();
        }

        public void getHead()
        {
            List<Team> head = new List<Team>(8);
            List<Team> noHead = new List<Team>(8);
            foreach (Pool p in Array)
            {
                head.Add(p.Order[1]);
                noHead.Add(p.Order[2]);
            }

            BinaryTree b = new BinaryTree();
            this.directE = new DirectElimination(b, head, noHead);
        }

        public void playPool()
        {
            for(int i = 0; i < this.Array.Count; i++)
            {
                this.Array[i].playPool();
                this.Array[i].Order.Sort();
            }
        }

    }
}
