using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Windows.Forms;

namespace obiz_load_data
{
    public partial class Form2_json : Form
    {
        public string path = @"C:\Users\alex\Desktop\Homework\users.json";
        public input2Jsons input2Json;

        public Form2_json()
        {
            InitializeComponent();
            Read_json();
        }


        public class input2Jsons
        {
            public string Id;
            public string Name;
            public input2Jsons(string name)
            {
                this.Id = DateTimeOffset.Now.ToUnixTimeSeconds().ToString();
                this.Name = name;
            }
        }



        private void Add_Text_Click(object sender, EventArgs e)
        {

            input2Json = new input2Jsons(Tb_Text.Text);

            string output = JsonConvert.SerializeObject(input2Json);

            File.WriteAllText(path, $"[ {textBox2.Text + output} ]");

            Tb_Text.Text = "";

            Read_json();
        }

        private void Read_json()
        {
            if(textBox2.Text.Length != 0)
            {
                textBox2.Text = "";
            }
            string text = File.ReadAllText(path);

            JArray jsonArray = JArray.Parse(text);

            for (int i = jsonArray.Count - 1; i >= 0; i--)
            {
                textBox2.Text += JObject.Parse(jsonArray[i].ToString()).ToString() + "," + "\r\n";
            }
        }

        
        
    }
}
