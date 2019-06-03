using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbPSCBSLauncherGenerator
{
    public class ClPaireIndexString
    {
        private String _name;
        private int _index;

        public ClPaireIndexString(String name, int index)
        {
            _name = name;
            _index = index;
        }

        public string Name { get => _name; set => _name = value; }
        public int Index { get => _index; set => _index = value; }
    }
}
