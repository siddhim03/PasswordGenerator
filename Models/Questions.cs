using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator.Models
{
    public class Questions
    {
        public string question;

        public string getQuestion()
        {
            return this.question;
        }

        static void Main(string[] args)
        {
            List<Questions> lstQuestions = new List<Questions>();
        }
    }
}
