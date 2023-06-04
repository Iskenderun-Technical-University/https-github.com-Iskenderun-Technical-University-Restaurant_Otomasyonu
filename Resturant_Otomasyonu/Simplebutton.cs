using System;
using System.Windows.Forms;

namespace Resturant_Otomasyonu
{
    internal class Simplebutton
    {
        public string Name { get; internal set; }

        public static explicit operator Simplebutton(Control v)
        {
            throw new NotImplementedException();
        }
    }
}