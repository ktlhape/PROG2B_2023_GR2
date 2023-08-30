using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    public class Fruit
    {
        //private string[] arFruit = new string[3];
        List<string> arFruit = new List<string>();
        //modifier return type this[type indexer]
        public string this[int x]
        {
            get
            {return arFruit[x];}
            set
            {arFruit.Add(value);}
        }

        public int Length() => arFruit.Count;
      
    }
}
