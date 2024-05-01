using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_App
{
    internal class TwentySidedDice : Dice
    {
        public override void GenerateNumber()
        {
            _Num = random.Next(1, 10);//a

        }//End of GenerateNumber Method


        public TwentySidedDice(string inColour)
    : base(inColour)//a
        {
            GenerateNumber();//b
        }//end of TwentySidedDice Constructor

    }//End of TwentySidedDice class


}