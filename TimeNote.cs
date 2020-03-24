using System;
using System.Collections.Generic;
using System.Text;

namespace LV1
{
    class TimeNote : Note
    {
        public DateTime time = new DateTime();

      
        
        public TimeNote()
        {
            time = DateTime.Now;
        }
        public TimeNote (string text, string author, int importance, DateTime time):base(text, importance, author)
        {
            time = DateTime.Now;
            this.time = time;
        }
        public void setTime(DateTime time)
        {
            time = DateTime.Now;
            this.time = time;
        }
        public DateTime getTime()
        {
            return this.time;
        }
        public override string ToString()
        {
            return base.ToString() + "\n" + "Time: "+this.time;
        }
    }
}
