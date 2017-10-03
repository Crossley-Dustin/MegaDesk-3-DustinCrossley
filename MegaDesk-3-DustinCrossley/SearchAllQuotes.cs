using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_DustinCrossley
{
    public partial class SearchAllQuotes : Form
    {
        MainMenu frmMainMenu;
        public SearchAllQuotes(MainMenu MainMenu)
        {
            InitializeComponent();
            frmMainMenu = MainMenu;
        }

        private void SearchAllQuotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMainMenu.Show();
        }
    }
}
