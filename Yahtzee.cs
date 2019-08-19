using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Yahtzee
    {
        private List<Die> Dice = new List<Die> ();
        public int NumDice { get; set; }
        public Yahtzee(int num)
        {
            this.NumDice = num;
            for (var i = 0; i < this.NumDice; i++)
            {
                Dice.Add(new Die());
            }
        }

        //Rolls all Dice 
        public void RollDice(Random rand)
        {                               
            for(int j = 0; j < Dice.Count; j++)          
                Dice[j].RollDie(rand);
  
            ShowDice();          
        }

        public void RollDice(Random rand, int[] pickedDice)
        {
            for (int j = 0; j < pickedDice.Length; j++)
            {
                Dice[pickedDice[j]].RollDie(rand);
            }           
            ShowDice();
        }

        public void ShowDice()
        {
            foreach (var item in Dice)
            {
                Console.Write(item.sides[0] + "  ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public void StartGame(int times, Random rand)
        {
            Console.Write("Game started.. ");
            for (int i = 0;  i < times; i++)
            {
                Console.Write("Rolling Dice - Round {0}: ", i+1);    
                RollDice(rand);
                var pickedDice = PickDice(2);
                Console.Write("Re-rolling your selected Dice: ");
                RollDice(rand, pickedDice);
            }
            Console.WriteLine();
        }

        public int[] PickDice(int numDice)
        {
            Console.Write("Pick {0} Dice to re-roll, enter the numbers in the range 1 to 5, separated by space: ", numDice);

            var input = Console.ReadLine();
            var strAry = input.Split(' ');

            int[] numbers = new int[strAry.Length];
           
            for (int i = 0; i < numbers.Length; i++)           
                numbers[i] = Convert.ToInt32(strAry[i]) - 1;                                   
            Console.WriteLine();
            return numbers;            
        }

    }
}
