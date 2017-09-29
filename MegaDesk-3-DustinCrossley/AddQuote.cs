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
    public partial class AddQuote : Form
    {
        Form MainMenu;

        public AddQuote(Form MainMenuForm)
        {
            InitializeComponent();
            MainMenu = MainMenuForm;
        }

        private void btnReturnToMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu.Show();
            this.Close();
        }
    }
}
