using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkLinkedlistDelegate
{
    internal class Employe : Human
    {
        public string Position { get; set; }

        public Employe(string name, string position) : base(name)
        {
            Position = position;
        }
    }
}
