using System;
using System.Collections.Generic;
using System.Linq;

namespace Entities
{
    public class LineCommand
    {
        public string Value { get; set; }

        public int Size
        {
            get
            {
                return Int32.Parse(Value.Split(',')[0]);
            }
        }

        public List<int> LstNumbers
        {
            get
            {
                var LstCharNumbers = Value.Split(',')[1].ToList();
                return LstCharNumbers.Select(x => Int32.Parse(x.ToString())).ToList();
            }
        }
    }
}
