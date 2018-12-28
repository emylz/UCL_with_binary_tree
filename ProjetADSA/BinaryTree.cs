using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetADSA
{
    class BinaryTree
    {
        private Node root;
        private int count;

        public Node Root { get => root; set => root = value; }

        public BinaryTree()
        {
            this.root = new Node();
            this.count = 0;

            while (this.count < 14)
            {
                Node tmp = this.root;
                Queue<Node> q = new Queue<Node>();
                q.Enqueue(tmp);

                while (q.Count != 0)
                {
                    tmp = q.Dequeue();

                    if (tmp.leftLeaf == null)
                    {
                        tmp.leftLeaf = new Node();
                        tmp.leftLeaf.parent = tmp;
                        break;
                    }
                    else q.Enqueue(tmp.leftLeaf);

                    if (tmp.rightLeaf == null)
                    {
                        tmp.rightLeaf = new Node();
                        tmp.rightLeaf.parent = tmp;
                        break;
                    }
                    else q.Enqueue(tmp.rightLeaf);

                }
                this.count++;

            }

        }

        public bool isEmpty()
        {
            return root == null;
        }

        public void insert(Match m)
        {
            Node temp = this.root;
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(temp);
            while (q.Count() != 0)
            {
                temp = q.Peek();
                q.Dequeue();

                if (temp.leftLeaf == null && temp.match.Team1 == null)
                {
                    temp.match = m;
                    break;
                }
                if (temp.leftLeaf != null && temp.rightLeaf != null && temp.leftLeaf.isVisited && temp.rightLeaf.isVisited && temp.match.Team1 == null)
                {
                    temp.match = m;
                    break;
                }
                if (temp.leftLeaf != null && temp.leftLeaf.isVisited == false)
                {
                    q.Enqueue(temp.leftLeaf);
                }
                if (temp.rightLeaf != null && temp.rightLeaf.isVisited == false)
                {
                    q.Enqueue(temp.rightLeaf);
                }
            }
        }

        public Match search(Team t1, Team t2)
        {
            return root.search(root, t1, t2);
        }

        public bool isLeaf()
        {
            if (!isEmpty())
                return root.isLeaf(ref root);

            return true;
        }

        public void display()
        {
            if (!isEmpty())
                root.display(root);
        }

        public int Count()
        {
            return count;
        }

        public void tourSelction()
        {
            List<Team> winner = new List<Team>();
            Node temp = this.root;
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(temp);
            while (q.Count() != 0)
            {
                temp = q.Peek();
                q.Dequeue();

                if ((temp.leftLeaf == null && temp.isVisited == false) || (temp.leftLeaf.isVisited && temp.rightLeaf.isVisited))
                {
                    temp.match.playMatch();
                    temp.isVisited = true;
                    winner.Add(temp.match.Winner);
                }
                else if (temp.leftLeaf != null) //If the leftLeaf is not null, the rightLeaf is not null too because this how build our tree
                {
                    q.Enqueue(temp.leftLeaf);
                    q.Enqueue(temp.rightLeaf);
                }
            }
            if (winner.Count > 1)
            {

                for (int i = 0; i < winner.Count; i += 2)
                {
                    Match m = new Match(winner[i], winner[i + 1], typeOfMatch.directElimination);
                    insert(m);

                }
            }
            winner.Clear();
        }
    }
}
