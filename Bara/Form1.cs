using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bara
{
    public partial class Form1 : Form
    {
        public static int brojac = 0;

        Dictionary<string, Zaba> dic = new Dictionary<string, Zaba>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmsDodaj_MouseClick(object sender, MouseEventArgs e)
        {
            Zaba z = new Zaba();
            z.Naziv= "Žaba" + (brojac += 1);
           
            Label lbl = new Label();
            Controls.Add(lbl);
            lbl.Text = z.Naziv;
            lbl.Location = this.PointToClient(Cursor.Position);
            lbl.Click += (o, a) =>
            {
                Label l = (Label)o;
                
                Controls.Remove(l);
                dic.Remove(l.Text);
                if (dic.Count==0)
                {
                    MessageBox.Show("Hoću još žaba!!!", "Roda: ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            };
                dic.Add(z.Naziv,z);

        }
    }
}
