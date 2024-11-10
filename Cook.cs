using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_project
{
    internal class Cook : Staff
    {
        enum Rank { 
            Junior,
            Chef,
            Sauce_chef,
            Confectioner
        }
        private Rank rank;

        public Cook(string name, int salary, string rank) : base(name, salary) {
            switch (rank) {
                case "Junior":
                    this.rank = Rank.Junior;
                    break;
                case "Chef":
                    this.rank= Rank.Chef;
                    break;
                case "Sauce chef":
                    this.rank = Rank.Sauce_chef;
                    break;
                case "Confectioner":
                    this.rank = Rank.Confectioner;
                    break;
            }
            
        }
    }
}
