using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Threading1
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Teal400, Primary.Teal500,
                Primary.Teal500, Accent.Pink700,
                TextShade.WHITE
            );
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            int i = 1;
            progressBar1.Maximum = 100;
            while(i < 100)
            {
                progressBar1.Value += 1;
                System.Threading.Thread.Sleep(10);
                i++;
            }
        }
    }
}
