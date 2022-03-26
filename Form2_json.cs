using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace obiz_load_data
{
    public partial class Form2_json : Form
    {
        public string path = @"E:\123.json";
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


        //新增資料事件
        private void Add_Text_Click(object sender, EventArgs e)
        {
            //建立一個新的物件
            input2Json = new input2Jsons(Tb_Text.Text);

            //將資料序列化
            string output = JsonConvert.SerializeObject(input2Json);

            //覆蓋所有資料 tb內容 + 序列化資料
            File.WriteAllText(path, $"[ {textBox2.Text + output} ]");

            //將資料清空
            Tb_Text.Text = "";

            //讀取
            Read_json();
        }

        private void Read_json()
        {
            //清空內容
            if(textBox2.Text.Length != 0)
            {
                textBox2.Text = "";
            }
            string text = File.ReadAllText(path);

            JArray jsonArray = JArray.Parse(text);


            //反轉陣列
            JArray reversed = new JArray();
            foreach (var tok in jsonArray.Reverse())
            {
                reversed.Add(tok);
            }

            //將資料逐筆寫入textbox
            for (int i = 0; i <= reversed.Count - 1; i++)
            {
                textBox2.Text += JObject.Parse(reversed[i].ToString()).ToString() + "," + "\r\n";
            }
        }
    }
}
