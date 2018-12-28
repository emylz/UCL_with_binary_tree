﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetADSA
{
    class Team : IComparable<Team>
    {
        string name;

        int attack;
        int defense;
        int teamCohesion;
        int overall;
        string country;

        int pointNumber;
        int victoryNumber;
        int defeatNumber;
        int drawNumber;

        int scored;
        int conceded;
        int avg;
        int played;

        int coefficient;

        public Team(string name,  int attack, int defence, int teamCohesion, int coefficient, string country)
        {
            this.name = name;
            this.attack = attack;
            this.defense = defence;
            this.teamCohesion = teamCohesion;
            this.coefficient = coefficient;
            int mean = this.attack + this.defense + this.teamCohesion;
            this.overall = mean / 3;
            this.country = country;
            if(this.name.Length < 15)
            {
                int i = this.name.Length;
                while(i < 20)
                {
                    this.name += " ";
                    i++;
                }
            }
        }

        public int Attack { get => attack; set => attack = value; }
        public int Defense { get => defense; set => defense = value; }
        public int TeamCohesion { get => teamCohesion; set => teamCohesion = value; }
        public int PointNumber { get => pointNumber; set => pointNumber = value; }
        public int VictoryNumber { get => victoryNumber; set => victoryNumber = value; }
        public int DefeatNumber { get => defeatNumber; set => defeatNumber = value; }
        public int DrawNumber { get => drawNumber; set => drawNumber = value; }
        public string Name { get => name; set => name = value; }
        public int Avg
        {
            get
            {
                return avg;
            }
        }
        public string Country
        {
            get
            {
                return this.country;
            }
        }

        public int Scored
        {
            get => scored;
            set
            {
                scored = value;
                this.avg = this.scored - this.conceded;
            }
        }
        public int Conceded
        { get => conceded;
            set
            {
                conceded = value;
                this.avg = this.scored - this.conceded;
            }
        }

        public int Played { get => played; set => played = value; }
        public int Coefficient { get => coefficient; set => coefficient = value; }
        public int Overhall { get => overall; }

        public int CompareTo(Team t)
        {
            return -1 * this.pointNumber.CompareTo(t.pointNumber);
        }

        static public int CoefficientSort(Team t1, Team t2)
        {
            return -1 * t1.coefficient.CompareTo(t2.coefficient);
        }

        static public int avgSort(Team t1, Team t2)
        {
            return -1 * t1.avg.CompareTo(t2.avg);
        }

        static public int attSort(Team t1, Team t2)
        {
            return -1 * t1.attack.CompareTo(t2.attack);
        }

        public override string ToString()
        {
            return this.Name + " Pts: " + this.PointNumber + " P: " + this.Played + " W: " + this.VictoryNumber + " D: " + this.DrawNumber + " L: " + this.DefeatNumber +
                 " Avg: " + this.Avg;
        }

    }
}