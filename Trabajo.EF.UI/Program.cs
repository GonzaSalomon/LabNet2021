using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajo.EF.Entities;
using Trabajo.EF.Logic;
using Trabajo.EF.Logic.Exceptions;

namespace Trabajo.EF.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuUI menu = new MenuUI();
            menu.AccessMenu();
        }
    }
}
