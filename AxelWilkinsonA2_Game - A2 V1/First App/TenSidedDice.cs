using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_App
{
    internal class TenSidedDice : Dice
    {
        public override void GenerateNumber()
        {
            _Num = random.Next(1, 10);//a

        }//End of GenerateNumber Method


        public TenSidedDice(string inColour)
    : base(inColour)//a
        {   
            GenerateNumber();//b
        }//end of TenSidedDice Constructor

    }//End of TenSidedDice class


}