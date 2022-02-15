using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraveenLibrary
{
    public  class PraveenBase
    {
        public int a;
        private int b;
        protected int c;
        internal int d;
        protected internal int e;

        public void ReadData()
        {
            a = 1;
            b = 2;
            c = 3;  
            d = 4;
            e = 5;
        }

    }
   
    public class PraveenDerived:PraveenBase
    {
        public void ReadDerivedData()
        {
            a = 1;
            b = 2;
            c = 3;
            d = 4;
            e = 5;
        }

    }
    public class PraveenOther
    {
        public void ReadOtherData()
        {
            PraveenBase pb=new PraveenBase();  
            pb.a = 1;   
            pb.b = 2;   
            pb.c = 3;   
            pb.d = 4;   
            pb.e = 5;

        }

    }
}
