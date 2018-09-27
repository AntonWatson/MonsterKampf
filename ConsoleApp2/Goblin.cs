using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

     public class Goblin : Monster
    {
       /* public int getHp()
        {

            return (totalHp * 80)/100;
        }*/

        public int getAgility() {


            return (agility * 12)/10;
        }

        public Goblin(int totalHp, int attack, int defense, int agility, int currentHp):base(totalHp, attack, defense, agility, currentHp) {
            totalHp = (totalHp * 80) / 100;
            attack = (attack * 105) / 100;
            defense = (defense * 95) / 100;
            agility = (agility * 120) / 100;


        }
    }
}
