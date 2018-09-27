using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Combat
    {
        public void combatStart(Monster monster1, Monster monster2)
        {


            int damage1 = monster1.InCombatAttack - monster2.InCombatDefense;
            int damage2 = monster2.InCombatAttack - monster1.InCombatDefense;
            while (monster1.currentHp >= 0 && monster2.currentHp >= 0)
            {
                if (monster1.InCombatAgility > monster2.InCombatAgility)
                {
                    monster2.currentHp = monster2.currentHp - damage1;
                    if (monster2.currentHp >= 0) {
                        break;

                    }
                    monster1.currentHp = monster1.currentHp - damage2;
                    if (monster1.currentHp >= 0)
                    {
                        break;

                    }
                }
                else
                {
                    monster1.currentHp = monster1.currentHp - damage2;
                    if (monster1.currentHp >= 0)
                    {
                        break;

                    }
                    monster2.currentHp = monster2.currentHp - damage1;
                    if (monster2.currentHp >= 0)
                    {
                        break;

                    }
                }
                Console.WriteLine("monster 1 current Hp is: " + monster1.currentHp);
                Console.WriteLine("monster 2 current Hp is: " + monster2.currentHp);
            }
        }
    }
}

