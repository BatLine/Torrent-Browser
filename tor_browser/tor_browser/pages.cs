using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Pirate_Bay;

namespace tor_browser
{
    class pages
    {
        public List<pages> _pages = new List<pages>();
        public List<pageItem> items = new List<pageItem>();
        public int pageNumber;

        public pages(List<Torrent> t)
        {
            List<pageItem> items = makeItems(t);
            int intCount = 0;
            int pageNumber = 1;
            pages _p = new pages();
            foreach (pageItem pi in items)
            {
                if (intCount >= 10)
                {
                    _p.pageNumber = pageNumber;
                    _pages.Add(_p);
                    _p = new pages();
                    pageNumber++;
                    intCount = 0;
                }
                _p.items.Add(pi);
                intCount++;
            }
        }
        public pages() { }

        List<pageItem> makeItems(List<Torrent> _t)
        {
            List<pageItem> result = new List<pageItem>();
            foreach (Torrent t in _t)
            {
                pageItem pi = new pageItem();
                pi.name = t.Name;
                if (t.Leechers <= 0) { pi.health = 1; }
                else if (t.Seeds / t.Leechers >= 1) { pi.health = 1; }
                else { pi.health = t.Seeds / t.Leechers; }
                pi.category = convertCategory(t.Category);
                pi.isTrusted = t.IsTrusted;
                pi.size = t.Size;
                pi.magnet = t.Magnet;
                pi.uploaded = t.Uploaded;
                pi.strHealth = t.Seeds + "/" + t.Leechers;
                result.Add(pi);
            }
            return result;
        }

        string convertCategory(int number)
        {
            string result = "All";
            switch (number)
            {
                case 0: result = "All"; break;
                case 300: result = "Applications"; break;
                case 100: result = "Audio"; break;
                case 400: result = "Games"; break;
                case 600: result = "Other"; break;
                case 500: result = "Porn"; break;
                case 200: result = "Videos"; break;
            }
            return result;
        }
    }
}
