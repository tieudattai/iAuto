using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
namespace L
{
    internal static class StringExtensions
    {


    









    

      
       
 

        public static void Invoke(this Form form, Action a)
        {
            form.Invoke(new Action(a));
        }
 
        public static IEnumerable<T> AllControls<T>(this Control startingPoint) where T : Control
        {
            bool hit = startingPoint is T;
            if (hit)
            {
                yield return startingPoint as T;
            }
            foreach (var child in startingPoint.Controls.Cast<Control>())
            {
                foreach (var item in AllControls<T>(child))
                {
                    yield return item;
                }
            }
        }


        public static IEnumerable<Control> GetDescendants(this Control control)
        {
            var children = control.Controls.Cast<Control>();
            return children.Concat(children.SelectMany(c => GetDescendants(c)));
        }
        public static IEnumerable<ToolStripMenuItem> GetDescendants(this ToolStripMenuItem control)
        {
            var children = control.DropDownItems.Cast<ToolStripItem>().Where(i => i.GetType() == typeof(ToolStripMenuItem)).Cast<ToolStripMenuItem>();
            return children.Concat(children.SelectMany(c => GetDescendants(c)));
        }
      
    }
}
