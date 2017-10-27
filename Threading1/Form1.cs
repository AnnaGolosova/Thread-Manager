using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Threading;
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
        private ThreadManager manager;
        private Thread thread1;
        private Thread thread2;
        private Thread thread3;

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

            manager = new ThreadManager(this);
            int i = 0;
            while (i < 15)
            {
                Grid.Rows.Add();
                i++;
            }
            Logs.Items.Clear();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            thread1 = new Thread(manager.FirstProcess);
            thread2 = new Thread(manager.SecondProcess);
            thread3 = new Thread(manager.ShowResult);

            thread1.Start();
            thread2.Start();
            thread3.Start();
        }

        public void ShowNextResult()
        {
            int count = manager.Count;
            ResultLabel.Text = (string)Grid.Rows[0].Cells[0].Value;
            for (int i = 1; i <= count; i++)
                Grid.Rows[i - 1].Cells[0].Value = Grid.Rows[i].Cells[0].Value;
            Grid.Rows[count].Cells[0].Value = "";
        }

        public void LoadValue(string value, int count)
        {
             Grid.Rows[count - 1].Cells[0].Value = value;
        }

        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            thread1.Abort();
            thread2.Abort();
            thread3.Abort();

            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter("Logs.txt");
            foreach (var item in Logs.Items)
            {
                SaveFile.WriteLine(item);
            }
        }

        public void AddToLogs(string log)
        {
            Logs.Items.Add(log);
        }
    }
}
