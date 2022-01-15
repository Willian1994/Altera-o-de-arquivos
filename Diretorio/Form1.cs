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

namespace Diretorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C: \Users\wirioliveira\source\repos\teste.txt\";

            bool res = Directory.Exists(path + "logan");
            lista.Items.Add(res);

            if (!res)
            {
                Directory.CreateDirectory(path + "logan");
            }

        }
    }
}

//Directory.Exists();
//Directory.CreateDirectory();
//Directory.Delete();
//Directory.Move();
//Directory.GetDirectories();
//Directory.GetFiles();
//Directory.GetDirectoryRoot();
//Directory.GetLogicalDrives();
//Directory.GetParent();
//Directory.GetCurrentDirectory();
