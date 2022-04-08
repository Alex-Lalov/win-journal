using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journal
{
    public class Entry
    {
        private string title, content;
        private int entrynum;
        private DateTime time;

        public Entry()
        {
            this.title = null;
            this.content = null;
            this.entrynum = 0;

        }
        public Entry(string title, string content, int entrynum)
        {
            this.title = title;
            this.content = content;
            this.entrynum = entrynum;
            this.time = DateTime.Now;
        }

        public string GetTitle()
        {
            return title;
        }

        public DateTime GetTime()
        {
            return time;
        }

        public string GetContent()
        {
            return content;
        }

        public int GetEntryNum()
        {
            return entrynum;
        }

        public void SetTitle(string title)
        {
            this.title = title;
        }

        public void SetContent(string content)
        {
            this.content = content;
        }

        public void SetEntryNum(int entrynum)
        {
            this.entrynum = entrynum;
        }

        override public string ToString()
        {
            return ("EntryName: " + title +
                "    EntryNum: " + entrynum +
                "\nContent: " + content +
                "\nDate and Time: " + time + "\n");
        }
    }
}
