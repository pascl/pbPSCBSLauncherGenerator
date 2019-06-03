using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbPSCBSLauncherGenerator
{
    public class ClPaireIndexInt
    {
        private int _count;
        private int _index;

        public ClPaireIndexInt(int count, int index)
        {
            _count = count;
            _index = index;
        }
        
        public int Index { get => _index; set => _index = value; }
        public int Count { get => _count; set => _count = value; }
    }
}
