using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace HanJeweliusz
{
    public class FileReader
    {
        
        public static string ReadFile(String path)
        {
            string text = "";
            var lines = File.ReadAllLines(path);
            foreach (var line in lines)
                text += line;
            return text;
        }
    }  
}