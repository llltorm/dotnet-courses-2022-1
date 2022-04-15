using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    public class OfficeEventArgs : EventArgs
    {
        public string Name { get; set; }
        public DateTime Time { get; set; }
    }
}
