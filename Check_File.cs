using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace obiz_load_data
{
    internal class Check_File
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="File_Path">檔案路徑</param>
        /// <param name="File_Type">檔案副檔名</param>
        public void Files_Exist(string File_Path , string File_Type)
        {
            if (!System.IO.File.Exists(File_Path))
            {
                File.Create(File_Path).Close();

                if (File_Type.ToLower() == "json")
                {
                    using (StreamWriter sw = new StreamWriter(File_Path, true))
                    {
                        sw.WriteLine("[]");
                    }
                }
            }
        }
    }
}
