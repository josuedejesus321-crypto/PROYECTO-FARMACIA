using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Farmacia.Forms
{
    internal class Admin_Design
    {
        public void sidebar_Animacion(Panel sidebar, Timer sidebarTimer, ref bool sidebarExpand)
        {
            //determinar el tamaño minimo y maximo del sidebar
            if (sidebarExpand)
            {
                //si se expande, que se minimize
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }
        
        public void Submenu_Animacion(Panel historialesContainer, Timer historialesTimer, ref bool historialesCollapsed)
        {
            if (historialesCollapsed)
            {
                historialesContainer.Height += 10;
                if (historialesContainer.Height == historialesContainer.MaximumSize.Height)
                {
                    historialesCollapsed = false;
                    historialesTimer.Stop();
                }
            }
            else
            {
                historialesContainer.Height -= 10;
                if (historialesContainer.Height == historialesContainer.MinimumSize.Height)
                {
                    historialesCollapsed = true;
                    historialesTimer.Stop();
                }


            }
        }
    }
}
