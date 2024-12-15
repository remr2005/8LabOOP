using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONandLINQ
{
    /// <summary>
    /// Some class
    /// </summary>
    public class SomeClass
    {
        /// <summary>
        /// Some number
        /// </summary>
        public int number = 0;
        /// <summary>
        /// Some string
        /// </summary>
        public string str = "";
        /// <summary>
        /// Some class
        /// </summary>
        /// <param name="a"></param>
        public SomeClass(int a, string b)
        {
            number = a;
            str = b;
        }
        /// <summary>
        /// Get int param
        /// </summary>
        /// <returns></returns>
        public int ToInt() => number + str.Length;
        /// <summary>
        /// Get str param
        /// </summary>
        /// <returns></returns>
        public override string ToString() => number.ToString() + str;
    }
}
