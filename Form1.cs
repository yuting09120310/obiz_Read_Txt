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

namespace obiz_load_data
{
    public partial class Form1 : Form
    {
        public string path = @"C:\Users\alex\Desktop\Homework\123.txt";
        public string text;

        public Form1()
        {
            InitializeComponent();
            ReadText();
        }

        public void ReadText()
        {
            text = File.ReadAllText(path);
            textBox2.Text = text;
        }

        private void Add_Text_Click(object sender, EventArgs e)
        {
            string[] new_string = { Tb_Text.Text , text };
            File.WriteAllLines(path, new_string);
            ReadText();
            Clear();
        }

        public void Clear()
        {
            Tb_Text.Text = "";
        }
    }
}
