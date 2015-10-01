using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_I
{
    class Items
    {
        int[] ID=new int[2];
        string discreption;
        string name;
        double weight;
        int cost;
        public Items(int[] id)
        {
            findID(id);
            ID = id;
        }
        public void findID(int[] id)
        {
            switch (id[0])
            {
                case 1:

                    break;
            }
        }
    }
}
