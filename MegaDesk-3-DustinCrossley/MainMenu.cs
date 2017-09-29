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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnNewQuote_Click(object sender, EventArgs e)
        {
            AddQuote NewQuote = new AddQuote(this);
            NewQuote.Show();
            this.Hide();
        }
    }
}
