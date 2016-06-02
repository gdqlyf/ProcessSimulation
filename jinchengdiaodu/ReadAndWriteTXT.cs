using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace ProcessSimulation
{
    class ReadAndWriteTXT
    {
        //private string path;
        FileStream fs;
        public ReadAndWriteTXT(string path,FileMode style)
        {
            fs = new FileStream(path,style);
        }
        public WorkCollection ReadTXT()
        {
            WorkCollection workColl = new WorkCollection();
            using (StreamReader sr = new StreamReader(fs,System.Text.Encoding.GetEncoding("UTF-8")))
            {
                string[] temp;
                string eachLine;//保存数据
                int i = 0;
                while ((eachLine=sr.ReadLine()) != null)
                {
                    temp = eachLine.Split('-');
                    int id = int.Parse(temp[0]);
                    string name = temp[1];
                    int at = int.Parse(temp[2]);
                    int st = int.Parse(temp[3]);
                    //workColl[i] = new WorkObject(id, name, at, st);
                    workColl.dataList.Add(new WorkObject(id, name, at, st));
                    i++;
                }
            }
            return workColl;
        }
        public void WriteTXT(string txtstr)
        {
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.Write(txtstr);
            }
        }
    }
}
