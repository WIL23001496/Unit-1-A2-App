using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_App
{
    internal class Dice
    {

        //1. Attributes
        protected string _Colour;
        protected int _Num;








        //2. Properties
        public string Colour
        {
            get         //2a
            {
                return _Colour;
            }
            set         //2b
            {
                if ((value.Length > 0) && (value.Length <= 10))     //2b-1
                {
                    _Colour = value;
                }
                else
                {
                    throw new Exception("Bad colour : " + value);     //2b-2
                }
               


            }
        }//End Colour p
        public virtual int Num                          //2c
        {
            get { return _Num; }//Read only Property
        }//End Num Property








        //3. Methods
        protected static Random random = new Random();//3a

        public virtual void GenerateNumber()        //4a
        {
            _Num = random.Next(0, 6);           //4a-2
        }//End of GenerateNumber










        //4. Override Methods
        public override string ToString()       //4b
        {
            return Colour + " " + _Num;
        }//End of ToString Method










        //5. Object Constructor Methods
        public Dice()                     //5a
        {
            _Num = 1;
            _Colour = "Black";
        }//End of Dice Constructor

        public Dice (string inColour, int inNum)     //5b
        {
            _Colour=inColour;
            _Num = inNum;   
        }//End of Dice C

        public Dice (string inColour)           //8
        {
            Colour = inColour;
            GenerateNumber();
        }//End of Dice c



    }//End of Dice c
}
