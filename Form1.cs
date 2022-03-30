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
        string AppName = "Form1";
        Msg_log msg_Log = new Msg_log();

        public Form1()
        {
            InitializeComponent();
            msg_Log.Files_Exist(Path, "txt");
            ReadText();
        }

        public void ReadText()
        {
            try
            {
                text = File.ReadAllText(Path);
                textBox2.Text = text;
            }catch(Exception ex)
            {
                msg_Log.save_log(AppName, ex);
            }
        }

        private void Add_Text_Click(object sender, EventArgs e)
        {
            try
            {
                string[] new_string = { Tb_Text.Text, text };
                File.WriteAllLines(Path, new_string);
                ReadText();
                Clear();
            }catch(Exception ex)
            {
                msg_Log.save_log(AppName, ex);
            }
        }

        public void Clear()
        {
            Tb_Text.Text = "";
        }
    }
}
