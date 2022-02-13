using System;
using System.Collections.Generic;
using System.Text;

namespace MagicSquare
{
    class Magic1
    {
        private int mFieldSize;
        public Magic1(int field_size) {
            mFieldSize = field_size;
        }
        public bool spell_1(int x, int y ) 
        {
            return x > y;
        }
        
        public bool spell_2(int x, int y)
        {
            return y == mFieldSize - 1 - x;
        }
        
        public bool spell_3(int x, int y)
        {
            return y < (mFieldSize - 1 - x) + 6;
        }
        public bool spell_5(int x, int y)
        {
            return y == x / 2 ;
        }
        public bool spell_6(int x, int y)
        {
            
            return ( (x < 10) || (y < 10));
        }
        public bool spell_7(int x, int y)
        {

            return ((x > 16) && (y > 16));
        }
        public bool spell_8(int x, int y)
        {

            return ((x == 0) || (y == 0));
        }
        public bool spell_9(int x, int y)
        {

            return (y > x + 10) || (y < (x - 10) );
        }
        public bool spell_10(int x, int y)
        {
            return (y < x) && (y > (x/2) ) ;
        }

        public bool spell_11(int x, int y)
        {
            return ( (x-1)%23==0  || (y-1)%23==0 );
        }

        public bool spell_12(int x, int y)
        {
            //TODO
            return true;
            //return ((x - 1) % 23 == 0 || (y - 1) % 23 == 0);
        }
        public bool spell_13(int x, int y)
        {
            //TODO
            //return true
            return  (y > mFieldSize - 1 - x -4) && (y < mFieldSize - 1  -x +  4);
            //return ((x - 1) % 23 == 0 || (y - 1) % 23 == 0);
        }
        public bool spell_20(int x, int y) {
            return (y % 2 == 0 && x % 2 !=0) || ( x %2 == 0 && y %2 !=0);
        
        }

        public bool spell_21(int x, int y)
        {
            return (y==x || y==x/2 || y==x/4 || y==x/8);

        }
        public bool spell_23(int x, int y)
        {
            return (y % 3 == 0 && x % 2 == 0) ;

        }
        public bool spell_25(int x, int y)
        {
            return (y  % 6 ==0 || x % 6 ==0);

        }
    }
    

}

