using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{


 public class Monster
    {
      public  int totalHp = 0;
      public  int attack = 0;
      public  int defense = 0;
      public  int agility = 0;
      public  int currentHp;
      public int InCombatAttack = 0;
      public int InCombatDefense = 0;
      public int InCombatAgility = 0;

        public Monster(int totalHp, int attack, int defense, int agility, int currentHp)
        {
            this.totalHp = totalHp;
            this.attack = attack;
            this.defense = defense;
            this.agility = agility;
            this.currentHp = currentHp;
        }
        public void SetMonsterInCombatStats() {

            this.InCombatAttack = attack;
            this.InCombatDefense = defense;
            this.InCombatAgility = agility;


        }



        public int getHP() {

            return totalHp;
        }

        public int getAttack() {

            return attack;
        }
        public int getDefense() {
            return defense;
        }
        public int getAgility() {

            return agility;
        }
        public int setHp() {
            currentHp = totalHp;
            return currentHp;
        }
        public void generateMonster(int totalStatPoints) {
            Random r = new Random();
            int statchooser;
            for (int i = 0; i < totalStatPoints; i++) {
                statchooser = r.Next(0,4);
                if (statchooser == 0)
                {
                    totalHp++;

                }
                else if (statchooser == 1)
                {

                    attack++;

                }
                else if (statchooser == 2)
                {

                    defense++;

                }
                else if( statchooser == 3) {
                    agility++;


                }


            }
        }

        void onAttackBegin(Monster other) {}
        void onAttackEnd(Monster other) { }
        void onDefendBegin(Monster other) { }
        void onDefendEnd(Monster other) { }
        void onVictory(Monster other) { }
    }
}




