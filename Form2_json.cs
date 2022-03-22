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
using Newtonsoft.Json;
using System;
using Newtonsoft.Json.Linq;

namespace obiz_load_data
{
    public partial class Form2_json : Form
    {
        public string path = @"C:\Users\alex\Desktop\Homework\users.json";

        public ConfigurationDto configurationDto;


        public Form2_json()
        {
            InitializeComponent();
            Read_json();
        }


        public class ConfigurationDto
        {
            public string Id;
            public string Name;
            public ConfigurationDto(string name)
            {
                this.Id = DateTimeOffset.Now.ToUnixTimeSeconds().ToString();
                this.Name = name;
            }
        }



        private void Add_Text_Click(object sender, EventArgs e)
        {
            configurationDto = new ConfigurationDto(Tb_Text.Text);

            string output = JsonConvert.SerializeObject(configurationDto);

            File.WriteAllText(@"C:\Users\alex\Desktop\Homework\users.json", output);
        }

        private void Read_json()
        {
            FileStream fs = new FileStream(@"C:\Users\alex\Desktop\Homework\users.json", FileMode.Open, FileAccess.Read);
            StreamReader files = new StreamReader(fs, System.Text.Encoding.Default);
            JsonTextReader reader = new JsonTextReader(files);//解析json模組
            JObject o = (JObject)JToken.ReadFrom(reader);

        }

        
    }
}
