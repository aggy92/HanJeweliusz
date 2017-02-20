using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace HanJeweliusz
{
    
    public class DataLoader
    {
        public static IDictionary questionAnswerMap = new Dictionary<String, String>();

        public static void ParseTextAndInsertToMap(String text)
        {
            text = Regex.Replace(text, @"\t|\n|\r", "");
            String[] splitted = Regex.Split(text,"&");

            string question;
            foreach (string s in splitted)
            {
                if (s.Length == 0) continue;
                string answer;
                var st = s.Trim();

                if (st.Contains("#")) { 
                question = st.Substring(0, st.IndexOf('#'));
                answer = st.Substring(st.IndexOf('#') + 1);
                questionAnswerMap.Add(question.Trim(), answer.Trim());
            }

            }
        }
    }
}