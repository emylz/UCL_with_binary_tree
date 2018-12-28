using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetADSA
{
    class Node
    {
        public Match match;
        public Node rightLeaf;
        public Node leftLeaf;
        public bool isVisited;
        public Node parent;

        public Node(Team t1, Team t2, typeOfMatch type)
        {
            this.match = new Match(t1, t2, type);
            rightLeaf = null;
            leftLeaf = null;
            isVisited = false;
            this.parent = null;
        }

        public Node()
        {
            this.match = new Match();
            this.rightLeaf = null;
            this.leftLeaf = null;
            this.parent = null;
            this.isVisited = false;
        }

        public bool isLeaf(ref Node node)
        {
            return (node.rightLeaf == null && node.leftLeaf == null);

        }

        public Match search(Node node, Team t1, Team t2)
        {
            Node tmp = this;
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(tmp);
            if(tmp.rightLeaf != null)
            {
                if (tmp.rightLeaf.match.Team1 == t1 && tmp.rightLeaf.match.Team1 == t2)
                {
                    return tmp.rightLeaf.match;
                }
                else q.Enqueue(tmp.rightLeaf);
            }
            if (tmp.leftLeaf != null)
            {
                if (tmp.leftLeaf.match.Team1 == t1 && tmp.leftLeaf.match.Team1 == t2)
                {
                    return tmp.leftLeaf.match;
                }
                else q.Enqueue(tmp.leftLeaf);
            }
            return null;
        }

        public void display(Node n)
        {
            if (n == null)
                return;

            display(n.leftLeaf);
            Console.Write(n.match.Team1 +" " + n.match.Team2 + "\n");
            display(n.rightLeaf);
        }
    }

    


}
