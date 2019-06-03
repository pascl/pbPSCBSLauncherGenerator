using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbPSCBSLauncherGenerator
{
    public class ClQuickSettings
    {
        String _name;
        String _core;
        String _extension; // with '.'
        String _gamelistfolder;
        int _targetfolderid;

        public ClQuickSettings(String name, String core, String extension, String gamelistFolder, int targetFolderId)
        {
            _name = name;
            _core = core;
            _extension = extension;
            _gamelistfolder = gamelistFolder;
            _targetfolderid = targetFolderId;
        }

        public override String ToString()
        {
            return Name;
        }

        public string Name { get => _name; set => _name = value; }
        public string Core { get => _core; set => _core = value; }
        public string Extension { get => _extension; set => _extension = value; }
        public string Gamelistfolder { get => _gamelistfolder; set => _gamelistfolder = value; }
        public int Targetfolderid { get => _targetfolderid; set => _targetfolderid = value; }
    }
}
