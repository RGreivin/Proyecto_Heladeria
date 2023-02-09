using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL.Pantalla
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(4);
            Opacity -= 0.020;
            Lbl_Progress.Text = progressBar1.Value.ToString() + "%";
            if (Opacity == 0.0)
            {
                timer1.Stop();
                this.Hide();
                Pantalla.Login log = new Pantalla.Login();
                log.ShowDialog();
            }
            //    Lbl_Progress.Text = progressBar1.Value.ToString() + "%";
            //    if (progressBar1.Value == progressBar1.Maximum)
            //    {
            //        timer1.Stop();
            //        this.Hide();
            //        Pantalla.Login  log= new Pantalla.Login();
            //        log.ShowDialog();
            //    }
        }   
     }
}
