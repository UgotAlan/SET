using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace set_gameboard
{
    public partial class Set : Form
    {
        public Set()
        {
            InitializeComponent();
        }
        //Set Button-----------------------------------------------------------
        private void set_button_Click(object sender, EventArgs e)
        {
            //Set Logic
        }

        private void set_button_MouseEnter(object sender, EventArgs e)
        {
            set_button.BackColor = Color.Gold;
        }

        private void set_button_MouseLeave(object sender, EventArgs e)
        {
            set_button.BackColor = Color.Goldenrod;
        }
        //-----------------------------------------------------------Set Button

        //Menu Buttons---------------------------------------------------------
        private void options_button_Click(object sender, EventArgs e)
        {
            //bring up options dialog
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            //bring up exit dialog
        }

        private void options_button_MouseEnter(object sender, EventArgs e)
        {
            options_button.ForeColor = Color.LightGray;
        }

        private void options_button_MouseLeave(object sender, EventArgs e)
        {
            options_button.ForeColor = Color.White;
        }

        private void exit_button_MouseEnter(object sender, EventArgs e)
        {
            exit_button.ForeColor = Color.LightGray;
        }

        private void exit_button_MouseLeave(object sender, EventArgs e)
        {
            exit_button.ForeColor = Color.White;
        }
        //---------------------------------------------------------Menu Buttons


    }
}
