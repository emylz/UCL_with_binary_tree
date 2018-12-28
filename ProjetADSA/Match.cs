using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetADSA
{
    enum typeOfMatch { pool, directElimination };

    class Match
    {
        Team team1;
        Team team2;

        Team winner;
        Team looser;

        Team draw1;
        Team draw2;

        int time;
        int scoreTeam1;
        int scoreTeam2;
        int penaltyKick1;
        int penaltyKick2;

        typeOfMatch type;

        public Match(Team team1, Team team2, typeOfMatch type)
        {
            this.team1 = team1;
            this.team2 = team2;
            this.time = 90;
            this.scoreTeam1 = 0;
            this.scoreTeam2 = 0;
            this.winner = null;
            this.looser = null;
            this.penaltyKick1 = 0;
            this.penaltyKick2 = 0;
            this.type = type;
        }

        public Match()
        {
            this.type = typeOfMatch.directElimination;
        }

        public int Time { get => time; set => time = value; }
        public int ScoreTeam1 { get => scoreTeam1; set => scoreTeam1 = value; }
        public int ScoreTeam2 { get => scoreTeam2; set => scoreTeam2 = value; }
        public Team Team1 { get => team1; set => team1 = value; }
        public Team Team2 { get => team2; set => team2 = value; }
        public Team Winner { get => winner; set => winner = value; }
        public Team Looser { get => looser; set => looser = value; }
        public int PenaltyKick1 { get => penaltyKick1; }
        public int PenaltyKick2 { get => penaltyKick2; }
        public typeOfMatch Type { get => type; }

        public void playMatch()
        {
            Team[] array = new Team[2];
            Random r = new Random();
            int timer = 0;
            while (timer < this.time)
            {
                int likelihood = r.Next(100);
                int total = this.team1.TeamCohesion + this.team2.TeamCohesion;
                int coefficient1 = (this.team1.TeamCohesion * 100) / total;
                int coefficient2 = 100 - coefficient1;

                if(likelihood < coefficient1)
                {
                    likelihood = r.Next(100);
                    total = this.team1.Attack + this.team2.Defense;
                    coefficient1 = (this.team1.Attack * 100) / total;
                    if(likelihood < coefficient1)
                    {
                        this.scoreTeam1++;
                    }
                }
                else
                {
                    likelihood = r.Next(100);
                    total = this.team1.Defense + this.team2.Attack;
                    coefficient1 = (this.team1.Attack * 100) / total;
                    if (likelihood > coefficient1)
                    {
                        this.scoreTeam2++;
                    }
                }
                timer += 15;
            }

            if (this.scoreTeam1 == this.scoreTeam2 && this.type==typeOfMatch.directElimination)
            {
                this.time = 120;
                while(timer < this.time)
                {
                    int likelihood = r.Next(100);
                    int total = this.team1.TeamCohesion + this.team2.TeamCohesion;
                    int coefficient1 = this.team1.TeamCohesion / total;
                    int coefficient2 = 100 - coefficient1;

                    if (likelihood < coefficient1)
                    {
                        likelihood = r.Next(100);
                        total = this.team1.Attack + this.team2.Defense;
                        coefficient1 = this.team1.Attack / total;
                        if (likelihood < coefficient1)
                        {
                            this.scoreTeam1++;
                        }
                    }
                    else
                    {
                        likelihood = r.Next(100);
                        total = this.team1.Defense + this.team2.Attack;
                        coefficient1 = this.team1.Attack / total;
                        if (likelihood > coefficient1)
                        {
                            this.scoreTeam2++;
                        }
                    }
                    timer += 10;

                }
                if (this.scoreTeam1 == this.scoreTeam2)
                {
                    penaltyKick();
                    array = whoWinPenaltyKick();
                }
            }
            array = whoWinnPool();
            if (array != null)
            {
                this.winner = array[0];
                this.looser = array[1];
            }
            else
            {
                this.draw1 = this.team1;
                this.draw2 = this.team2;
            }
            pointDistribution();
        }

        public Team[] whoWinnPool()
        {
            if (this.scoreTeam1 == this.scoreTeam2) return null;
            Team[] array = new Team[2];
            if (this.scoreTeam1 > this.scoreTeam2)
            {
                array[0] = this.team1;
                array[1] = this.team2;
            }
            else if (this.scoreTeam1 < this.scoreTeam2)
            {
                array[0] = this.team2;
                array[1] = this.team1;
            }
            return array;
        }

        public Team[] whoWinPenaltyKick()
        {
            Team[] array = new Team[2];

            if (this.penaltyKick1 > this.penaltyKick2)
            {
                array[0] = this.team1;
                array[1] = this.team2;
            }
            else if (this.penaltyKick1 < this.penaltyKick2)
            {
                array[0] = this.team2;
                array[1] = this.team1;
            }

            return array;
        }

        public void penaltyKick()
        {
            int tour = 0;
            bool end = false;
            Random r = new Random();
            while (end == false)
            {
                int likelihood = r.Next(100);
                if (likelihood < 80)
                {
                    this.penaltyKick1++;
                }
                likelihood = r.Next(100);
                if (likelihood < 80)
                {
                    this.penaltyKick2++;
                }
                tour++;
                if(tour >= 5)
                {
                    if(this.penaltyKick1 - this.penaltyKick2 > 0 || this.penaltyKick1 - this.penaltyKick2 < 0)
                    {
                        end = true;
                    }
                }

            }
        }

        public void pointDistribution()
        {
            if (this.winner != null)
            {
                this.winner.PointNumber += 3;
                this.winner.VictoryNumber++;
                this.winner.Scored += this.scoreTeam1;
                this.winner.Conceded += this.scoreTeam2;
                this.winner.Played++;

                this.looser.Played++;
                this.looser.Conceded += this.scoreTeam1;
                this.looser.Scored += this.scoreTeam2;
                this.looser.DefeatNumber++;
            }
            else
            {
                this.draw1.DrawNumber++;
                this.draw1.PointNumber++;
                this.draw1.Scored += this.scoreTeam1;
                this.draw1.Conceded += this.scoreTeam2;
                this.draw1.Played++;

                this.draw2.DrawNumber++;
                this.draw2.PointNumber++;
                this.draw2.Scored += this.scoreTeam2;
                this.draw2.Conceded += this.scoreTeam1;
                this.draw2.Played++;

            }

        }

    }
}
