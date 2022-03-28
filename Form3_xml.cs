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
        string Path = @"E:\123.xml";
        public Form3_xml()
        {
            InitializeComponent();
            Read_Xml();
        }

        public void Read_Xml()
        {
            XmlDocument myXml = new XmlDocument();
            myXml.Load(Path);
            XmlNode user_info = myXml.DocumentElement;//讀取XML的根節點
            foreach (XmlNode node in user_info.ChildNodes)//對子節點進行迴圈
            {
                //如果節點名為Address
                if(node.Name == "Address")
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
    }
}
