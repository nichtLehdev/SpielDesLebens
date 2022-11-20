using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiel_Des_Lebens
{
    internal class UI_Interface
    {
        private static UI_Interface ui_Interface;
        public Player player;
        private UI_Interface()
        {

        }

        public static UI_Interface getInstance()
        {
                if(ui_Interface == null)
                {
                    ui_Interface = new UI_Interface();
                }
                return ui_Interface;
        }


    }
}
