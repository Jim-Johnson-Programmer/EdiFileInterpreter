using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdiFileInterpreter.Libraries.Models
{
    public class ParsedRawFileModel
    {
        public string HeaderRowRaw { get; set; }
        public string[] HeaderRowParsed { get; set; } = new string[0];

    }
}
