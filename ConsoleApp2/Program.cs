using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        int roundCounter;
       static void Main()
        {
            Goblin gob = new Goblin(0,0,0,0,0);
            Orc orc = new Orc(0,0,0,0,0);
            Console.WriteLine("is something Happening?");
            gob.generateMonster(60);
            Console.WriteLine("Oh, really, something is happening");
            Console.WriteLine("your monster stats are:");
            Console.WriteLine("TotalHp: " + gob.totalHp + " attack: " + gob.attack + " defense: " + gob.defense + " agility: " + gob.agility);


       /*     gob.attack = 15;
            gob.totalHp = 10;
            gob.totalHp = gob.getHp();
            gob.agility = 10;
            gob.agility = gob.getAgility();
            gob.defense = 10;
            gob.currentHp = gob.totalHp;
            Orc orc = new Orc();

            orc.attack = 10;
            orc.attack = orc.getAttack();
            orc.agility = 10;
            orc.agility = orc.getAgility();
            orc.defense = 10;
            orc.defense = orc.getDefense();
            orc.totalHp = 10;
            orc.totalHp = orc.getHp();
            orc.currentHp = orc.totalHp;    


            Combat combatBegin = new Combat();
            combatBegin.combatStart(gob,orc);



    */
            Console.Read();


        }

    }
}
