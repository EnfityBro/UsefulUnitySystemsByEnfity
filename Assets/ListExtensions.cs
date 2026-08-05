using System;
using System.Collections.Generic;

namespace Enfity.UsefulUnitySystems
{
    public static class ListExtensions
    {
        /// <summary>
        /// Shuffles the list using the Fisher-Yates algorithm.
        /// </summary>
        public static void Shuffle<T>(this IList<T> list)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            for (int i = list.Count - 1; i > 0; i--)
            {
                int j = UnityEngine.Random.Range(0, i + 1);

                T temp = list[i];
                list[i] = list[j];
                list[j] = temp;
            }
        }
    }
}



/*

How to use:
1. Just copy this script into your project and call necessary methods.

*/