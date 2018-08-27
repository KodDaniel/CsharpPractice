using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemporaryForDictionaryPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj1 = new QuestionAndAnswer();
            var obj2 = new QuestionAndAnswer();
            obj1.Question = "Vad är näringslära?";
            obj1.Answer = "En lära om mat och kost.";
            obj2.Question = "Vem är Gud?";
            obj2.Answer = "Något som ej går att definiera just nu.";


            var dictionary = new Dictionary<string,string>();
            AddToDictionary(dictionary,obj1.Question, obj1.Answer);

            foreach (KeyValuePair<string, string> a in dictionary)
            {
                Console.WriteLine(a.Key + " " + a.Value);
            }
            Console.ReadLine();

            AddToDictionary(dictionary,obj2.Question, obj2.Answer);

            foreach (KeyValuePair<string, string> a in dictionary)
            {
                Console.WriteLine(a.Key + " " + a.Value);
            }
            Console.ReadLine();

        }

        public static Dictionary<string, string> AddToDictionary(Dictionary<string, string> sentInDictionary,
            string question, string answer)
        {
            sentInDictionary.Add(question,answer);
            return sentInDictionary;
        }



        public class QuestionAndAnswer
        {
            public string Question { get; set; }
            public string Answer { get; set; }





        }

    }
}
