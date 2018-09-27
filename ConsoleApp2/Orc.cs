using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   public class Orc : Monster
    {

        public Orc(int totalHp, int attack, int defense, int agility, int currentHp) : base(totalHp, attack, defense, agility, currentHp) {
                attack = (attack * 120) / 100;
                defense = (defense * 115) / 100;
                agility = (agility * 70) / 100;
                totalHp = (totalHp * 95) / 100;
                currentHp = totalHp;
        }

        void onAttackBegin(Monster other) {

        }
        void onAttackEnd(Monster other) { }
        void onDefendBegin(Monster other) { }
        void onDefendEnd(Monster other) {
   /*         if (currentHp < (totalHp * 40)/100) {
                attack = (attack * 125) / 100;
            }*/
        }
        void onVictory(Monster other) { }

    }
}
