using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Socjalna_Organizacja_MB.Forms
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
            dashboardUC1.BringToFront();
            labelTitle.Text = "Tablica";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboardUC1.BringToFront();
            labelTitle.Text = "Tablica";
            //<div>Icons made by <a href="https://www.freepik.com" title="Freepik">Freepik</a> from <a href="https://www.flaticon.com/" title="Flaticon">www.flaticon.com</a></div>
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //< div > Icons made by<a href= "https://www.flaticon.com/authors/lutfix" title= "lutfix" > lutfix </ a > from < a href= "https://www.flaticon.com/" title= "Flaticon" > www.flaticon.com </ a ></ div >
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //< div > Icons made by<a href= "https://www.flaticon.com/authors/freepik" title= "Freepik" > Freepik </ a > from < a href= "https://www.flaticon.com/" title= "Flaticon" > www.flaticon.com </ a ></ div >
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //<div>Icons made by <a href="https://www.flaticon.com/authors/flat-icons" title="Flat Icons">Flat Icons</a> from <a href="https://www.flaticon.com/" title="Flaticon">www.flaticon.com</a></div>
        }

        private void panelKontener_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            donnersUC1.BringToFront();
            dashboardUC1.Hide();
            labelTitle.Text = "Dodaj lub zaktualizuj rejestr dawców";
            //<div>Icons made by <a href="https://www.freepik.com" title="Freepik">Freepik</a> from <a href="https://www.flaticon.com/" title="Flaticon">www.flaticon.com</a></div>
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
