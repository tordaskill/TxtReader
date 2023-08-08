using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TxtReader
{
    class logic
    {
        public string listOfTxtFiles;
        public string nameOfTxtFile;
        public string name;
        public string path;
        public string contentOfOneTxt;
        public string content;
        public void findTxtFiles() //function which find all txt files in the folder
        {
            var txtFiles = Directory.GetFiles(path, "*.txt");//read all txt files in the folder
            listOfTxtFiles = "" + "\r\n"; //assign zero value to first row
            foreach (var names in txtFiles)//create list of all rows
            {
                listOfTxtFiles += names + "\r\n";
            }
        }
        public void findContent()
        {
            findTxtFiles();
            using (StringReader reader = new StringReader(listOfTxtFiles))
            {
                string line;
                line = reader.ReadLine(); //read line
                while ((line = reader.ReadLine()) != null)
                {
                    nameOfTxtFile = line; //whole path to file
                    name = nameOfTxtFile;
                    var replacement = name.Replace(path, "");////  clean name of file
                    name = replacement;
                    contentOfOneTxt = System.IO.File.ReadAllText(nameOfTxtFile); //content of one txt file
                    content += contentOfOneTxt; //add each content to one place
                } 
            }
        }


    }
}
