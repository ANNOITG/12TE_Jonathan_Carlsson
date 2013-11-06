using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namnlista
{
    class Lagmedlem
    {
        public string namn { get; set; }
        public string nick { get; set; }
        public int alder { get; set; }
        public string adress { get; set; }
        public string kon { get; set; }
        public string spel { get; set; }
        public string aktiv { get; set; }

        public override string ToString()
        {
            return "Namn: " + namn + "\nNickname: " + nick + "\nÅlder: " + alder + "\nKön: " + kon + "\nAdress: " + adress + "\nSpel: " + spel + "\nAktivitetsnivå: " + aktiv;
        }
    }
}
