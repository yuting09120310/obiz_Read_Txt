using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace obiz_load_data
{
    public partial class Form3_xml : Form
    {
        string Path = @"C:\Users\alex\Desktop\Homework\Form_xml.xml";
        Msg_log msg_log = new Msg_log();
        String AppName = "Form3_xml";

        public Form3_xml()
        {
            InitializeComponent();
            setup();
            Read_Xml();
        }

        void setup()
        {
            comboBox1.Items.Add("USA");
            comboBox1.Items.Add("ROC");
        }

        public void Read_Xml()
        {
            try
            {
                XmlDocument myXml = new XmlDocument();
                myXml.Load(Path);
                XmlNode user_info = myXml.DocumentElement;//讀取XML的根節點
                foreach (XmlNode node in user_info.ChildNodes)//對子節點進行迴圈
                {
                    //如果節點名為Address
                    if (node.Name == "Address")
                    {
                        //將結點內容全部展開
                        foreach (XmlNode item in node.ChildNodes)
                        {
                            //將每個節點的內容顯示出來
                            switch (item.Name)
                            {
                                case "Name":
                                    textBox2.Text += ($"姓名：{item.InnerText}" + Environment.NewLine);
                                    break;

                                case "Country":
                                    textBox2.Text += ($"國家：{item.InnerText}" + Environment.NewLine);
                                    break;
                            }
                        }
                        textBox2.Text += Environment.NewLine;
                    }
                }

            }
            catch(Exception ex)
            {
                msg_log.save_log(AppName , ex);
            }
        }

        private void Add_Text_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = "";

                XmlDocument myXml = new XmlDocument();
                myXml.Load(Path);

                XmlNode node = myXml.SelectSingleNode("PurchaseOrder");

                //建立大節點 address
                XmlElement main = myXml.CreateElement("Address"); //添加Address節點
                node.AppendChild(main);

                //建立小節點 名字 國家
                XmlElement name = myXml.CreateElement("Name");
                name.InnerText = Tb_Text.Text;
                main.AppendChild(name);
                XmlElement country = myXml.CreateElement("Country");
                country.InnerText = comboBox1.Text;
                main.AppendChild(country);

                myXml.Save(Path);

                Read_Xml();
            }catch(Exception ex)
            {
               msg_log.save_log(AppName, ex);
            }
        }

    }
}
