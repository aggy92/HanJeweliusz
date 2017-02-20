using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HanJeweliusz
{
    public class AnswerFinder
    {
        public static String FindAnswer(String question)
        {
            String answer = (String) DataLoader.questionAnswerMap[question];
            if (answer == null || answer.Equals(""))
            {
                answer = FindAnswerWithinKeys(question);
            }
            return answer;
        }

        private static String FindAnswerWithinKeys(String question)
        {
            String answer = "Sorry I don`t understand your question.";
            foreach (String key in DataLoader.questionAnswerMap.Keys)
            {   
                if(key.ToLower().Contains(question.ToLower()))
                {
                    answer = "Did you mean \"";
                    answer += key + "\"?\r\n";
                    answer += DataLoader.questionAnswerMap[key];
                    return answer;
                }
            }
            return answer;

        }
    }
}