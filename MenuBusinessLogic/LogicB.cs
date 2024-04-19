using MenuModel;
using MenuDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuBusinessLogic
{
    public class LogicB
    {
        List<Menu> menus = new List<Menu>();
        public void AddMenu(Menu menu)
        {
            menus.Add(menu);
        }

    }
}
