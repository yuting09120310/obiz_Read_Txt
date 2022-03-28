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
        public string Path = @"C:\Users\alex\Desktop\Homework\Form_txt.txt";
        public string text;
        Check_File CF = new Check_File();

        public Form1()
        {
            InitializeComponent();
            CF.Files_Exist(Path, "txt");
            ReadText();
        }

        public void ReadText()
        {
            text = File.ReadAllText(Path);
            textBox2.Text = text;
        }

        private void Add_Text_Click(object sender, EventArgs e)
        {
            string[] new_string = { Tb_Text.Text , text };
            File.WriteAllLines(Path, new_string);
            ReadText();
            Clear();
        }

        public void Clear()
        {
            Tb_Text.Text = "";
        }
    }
}
