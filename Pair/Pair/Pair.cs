using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pair
{
    public class Pair<T, U>
    {
        public T FirstValue;
        public U SecondValue;

        public Pair(T firstValue, U secondValue)
        {
            FirstValue = firstValue;
            SecondValue = secondValue;
        }

        public T GetFirstValue() { return FirstValue; }
        public U GetSecondValue() { return SecondValue; }

        public void ChangeFirstValue(T firstValue) => FirstValue = firstValue;

        public void ChangeSecondValue(U secondValue) => SecondValue = secondValue;
    }
}
