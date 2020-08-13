using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicentaCatalog
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }
        public HomeForm(int type)
        {
            InitializeComponent();
            if (type == 0)
            {
                label1.Text = "Bun venit!\nAceasta este aplicatia de gestionare a situatiei scoalare pentru studenti,\n in cadrul careia puteti actualiza situatia studentilor dumnevoastra.";
            }
            if (type == 1)
            {
                label1.Text = "Bun venit!\nAceasta este aplicatia de gestionare a situatiei scoalare pentru studenti,\n unde puteti vizualiza punctajele din cadrul celor patru ani de studii.";
            }
            if (type == 2)
            {
                label1.Text = "Bun venit!\nAceasta este aplicatia de gestionare a situatiei scoalare pentru studenti,\n unde puteti vizualiza punctajele din cadrul celor patru ani de studii pentru studentii alesi.";
            }
            if (type == 3)
            {
                label1.Text = "Bun venit!\nAceasta este aplicatia de gestionare a situatiei scoalare pentru studenti,\n in cadrul careia sunteti administrator!";
            }
        }

    }
}
