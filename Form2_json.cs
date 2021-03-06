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
        public string Path = @"C:\Users\alex\Desktop\Homework\Form_json.json";
        public input2Jsons input2Json;
        Msg_log msg_Log = new Msg_log();
        string AppName = "Form2_json";

        public Form2_json()
        {
            InitializeComponent();
            msg_Log.Files_Exist(Path,"JSon");
            read_json();
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //建立一個新的物件
                input2Json = new input2Jsons(txtName.Text);

                //將資料序列化
                string output = JsonConvert.SerializeObject(input2Json);

                //覆蓋所有資料 tb內容 + 序列化資料
                File.WriteAllText(Path, $"[ {txtShow.Text + output} ]");

                //將資料清空
                txtName.Text = "";

                //讀取
                read_json();
            }
            catch(Exception ex)
            {
                msg_Log.save_log(AppName, ex);
            }
        }

        private void read_json()
        {
            try
            {
                //清空內容
                if (txtShow.Text.Length != 0)
                {
                    txtShow.Text = "";
                }
                string text = File.ReadAllText(Path);

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
                    txtShow.Text += JObject.Parse(reversed[i].ToString()).ToString() + "," + "\r\n";
                }
            }
            catch(Exception ex)
            {
                msg_Log.save_log(AppName, ex);
            }
        }


        
    }
}
