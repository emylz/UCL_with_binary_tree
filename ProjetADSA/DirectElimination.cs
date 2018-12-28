using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetADSA
{
    enum step { firstRound, quaterFinal, semiFinal, final };

    class DirectElimination
    {
        List<Team> head = new List<Team>(8);
        List<Team> noHead = new List<Team>(8);

        step step;

        BinaryTree directElim;

        public List<Team> Head { get => head;  }
        public List<Team> NoHead { get => noHead; }
        public BinaryTree DirectElim { get => directElim; }

        public DirectElimination(BinaryTree t, List<Team> h1, List<Team> h2)
        {
            this.directElim = t;
            this.head = h1;
            this.noHead = h2;
            this.step = step.firstRound;
        }

        public void nextStep()
        {
            this.step++;
        }

        public void draw()
        {
            int i = 0;
            Random r = new Random();
            while(i < 8)
            {
                int take = r.Next(this.Head.Count - 1);
                int take2 = r.Next(this.noHead.Count - 1);
                Match m = new Match(this.Head[take], this.NoHead[take2], typeOfMatch.directElimination);
                this.directElim.insert(m);
                this.head.RemoveAt(take);
                this.NoHead.RemoveAt(take2);
                i++;
            }
        }

    }

}
