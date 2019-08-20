using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class DDGame
    {
        public void StartGame(DynamicDie die, int modifier, Random rand)
        {
            die.RollDie(rand);
            var rollResult = die.DieSides[0];

            if (rollResult == 1)
                Console.WriteLine("You Miss");
            else if (rollResult == 20)
            {
                WeapeonDamage("2d6", rand);
            }        
            else
            {
                rollResult += modifier;
                if (rollResult > new Enemy().ArmourClass)
                {
                    WeapeonDamage("2d6", rand);
                }
                else
                    Console.WriteLine("No Damage");
            }
        }

        public void WeapeonDamage(String damageString, Random rand)
        {
            var damageArray = damageString.Split('d');
            var damage = 0;
            var damageNumbers = new[] { Convert.ToInt32(damageArray[0]), Convert.ToInt32(damageArray[1]) };
            var die = new DynamicDie(damageNumbers[1]);
            for (var i = 0; i < damageNumbers[0]; i++)
            {
                die.RollDie(rand);
                damage += die.DieSides[0];
            }
            Console.WriteLine("Damage: " + damage);
        }
    }
}
