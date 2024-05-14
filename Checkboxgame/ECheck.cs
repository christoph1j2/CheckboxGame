using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Checkboxgame
{
    public class ECheck
    {
        public CheckBox re, li, ob, un, th;
        public ECheck(CheckBox t)
        {
            th = t;
        }
        public void Integrate(CheckBox l, CheckBox r, CheckBox o, CheckBox u)
        {
            li = l;
            re = r;
            ob = o;
            un = u;
        }
        public void Change()
        {
            if (li != null)
            {
                li.IsChecked = !li.IsChecked;
            }
            if (re != null)
            {
                re.IsChecked = !re.IsChecked;
            }
            if (un != null)
            {
                un.IsChecked = !un.IsChecked;
            }
            if (ob != null)
            {
                ob.IsChecked = !ob.IsChecked;
            }
        }
    }
}
