using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbPSCBSLauncherGenerator
{
    public class ClAnyGame
    {
        private String _title;
        private String _date;
        private String _image;
        private String _publisher;
        private int _players;

        public ClAnyGame(String title, String date, String image, String publisher, int players)
        {
            _title = title;
            _date = date;
            _image = image;
            _publisher = publisher;
            _players = setPlayers(players);
        }

        int setPlayers(int val)
        {
            int newval = 0;
            if (val > 0)
            {
                newval = val;
            }
            else
            {
                newval = 1;
            }
            return newval;
        }

        public String Title { get => _title; set => _title = value; }
        public String Date { get => _date; set => _date = value; }
        public String Image { get => _image; set => _image = value; }
        public String Publisher { get => _publisher; set => _publisher = value; }
        public int Players { get => _players; set => _players = setPlayers(value); }
    }
}
