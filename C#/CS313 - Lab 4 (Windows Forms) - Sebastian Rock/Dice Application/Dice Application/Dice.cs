using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Application
{
    public class Dice : IEnumerable<Die>
    {
        private List<Die> dieCollection = new List<Die>();

        public Dice()
        {
        }

        public Dice(int NumberDice, int NumberSides, string Color)
        {
            for (int i = 0; i < NumberDice; i++ )
            {
                dieCollection.Add(new Die(NumberSides, Color));
            }
        }

        public void Roll()
        {
            foreach(Die d in dieCollection)
                d.Roll();
        }

        public int Total
        {
            get
            {
                int total = 0;
                foreach (Die d in dieCollection)
                    total += d.SideUp;
                return total;
            }
        }

        public int HighValue
        {
            get
            {
                int maximumValue = Int32.MinValue;
                foreach (Die d in dieCollection)
                    maximumValue = maximumValue >= d.SideUp ? maximumValue : d.SideUp;
                return maximumValue;
            }
        }

        public int LowValue
        {
            get
            {
                int minumumValue = Int32.MaxValue;
                foreach (Die d in dieCollection)
                    minumumValue = minumumValue <= d.SideUp ? minumumValue : d.SideUp;
                return minumumValue;
            }
        }

        public int countValue(int faceValue)
        {
            int count = 0;
            foreach (Die d in dieCollection)
                if (d.SideUp == faceValue)
                    count++;
            return count;
        }

        public IEnumerator<Die> GetEnumerator()
        {
            return dieCollection.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return dieCollection.GetEnumerator();
        }

        public Die dieAt (int index)
        {
            return dieCollection.ElementAt(index);
        }

        public void addDie(Die d)
        {
            dieCollection.Add(d);
        }

        
    }
}
