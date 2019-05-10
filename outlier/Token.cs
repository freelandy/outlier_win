using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outlier
{
    public class Token
    {
        public string Word { set; get; }
        public bool IsInDictionary { set; get; }
        public bool IsStopword { set; get; }
        public bool IsPunctuation { set; get; }
        public bool IsCardinalNumber { set; get; }
        public bool IsComparative { set; get; }
        public bool IsSuperlative { set; get; }
        public bool IsAbbreviation { set; get; }
        public string Lemma { set; get; }
        public string Pos { set; get; }
    }
}
