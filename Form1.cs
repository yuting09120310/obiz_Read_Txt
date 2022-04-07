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
            read_text();
        }

        public void read_text()
        {
            try
            {
                text = File.ReadAllText(Path);
                txtShow.Text = text;
            }catch(Exception ex)
            {
                msg_Log.save_log(AppName, ex);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtName.Text.Length != 0)
                {
                    string[] new_string = { txtName.Text, text };
                    File.WriteAllLines(Path, new_string);
                    read_text();
                    clear();
                }
            }catch(Exception ex)
            {
                msg_Log.save_log(AppName, ex);
            }
        }

        public void clear()
        {
            txtName.Text = "";
        }
    }
}
