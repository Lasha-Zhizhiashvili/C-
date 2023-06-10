using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    internal class Algorithm
    {
        public static bool All<T>(List<T> list, Func<T, bool> comparer)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (!comparer(list[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool Any<T>(List<T> list, Func<T, bool> comparer)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (comparer(list[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public static T Distinct<T>(T[] mass, Func<T, bool> comparer)
        {
            for (int i = 0; i < mass.Length; i++)
            {
                if (comparer(mass[i]))
                {
                    return mass[i];
                }
            }
            return default;
        }
    }
}
