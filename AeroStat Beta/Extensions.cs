using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroStat_Beta
{
    internal static class Extensions
    {
        public static void forAllControls(this Control parent, Action<Control> action)
        {
            foreach(Control c in parent.Controls)
            {
                action(c);
                forAllControls(c, action);
            }
        }
    }
}
