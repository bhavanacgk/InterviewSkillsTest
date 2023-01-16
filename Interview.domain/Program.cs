using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.domain
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Admin obj = new Admin();
            obj.adminid = 1;
            obj.name = "bhavana";
            obj.pwd = "bhavana15";
            obj.ph_no = "7013224378";
            obj.email = "bhavana.gaddam15@gmail.com";
            obj.Update();
            Console.WriteLine("Updated");
            Console.ReadKey();*/

           /* Registration obj = new Registration();
            obj.registrationid = 1;
            obj.mail = "bhavanagaddam15@gmail.com";
            obj.pwd = "bhavana15";
            obj.name ="bhavana";
            obj.address = "Ongole";
            obj.gender = "female";
            obj.ph_no = "7013224378";
            obj.dob = DateTime.Now;
            Console.WriteLine("Inserted");
            Console.ReadKey();*/

            TestPaper obj = new TestPaper();
            obj.ques = "Which of the following is a logical OR operator?";
            obj.choice1 = "&";
            obj.choice2 = "&&";
            obj.choice3 = "||";
            obj.choice4 = "None of the above";
            obj.ans = "C";
            obj.tseries = null;
            obj.hint = null;
            obj.topicid = 2;
            obj.Insert();
            Console.WriteLine("Inserted");
            Console.ReadKey();

           /* Topics obj = new Topics();
            obj.tid = 1;
            obj.name = "bhavana";
            obj.Insert();
            Console.WriteLine("Inserted");
            Console.ReadKey();*/

            /*Score obj = new Score();
            obj.sid = 1;
            obj.registrationid = 1;
            obj.score = 10;
            obj.Insert();
            Console.WriteLine("Inserted");
            Console.ReadKey();*/

            /*Branch obj = new Branch();
            obj.bid = 1;
            obj.name = "cse";
            obj.tid = 1;
            obj.Insert();
            Console.WriteLine("Inserted");
            Console.ReadKey();*/

            /*Answer obj = new Answer();
            obj.ansid = 1;
            obj.qid = 1;
            obj.answer = "b";
            obj.registrationid = 1;
            obj.Insert();
            Console.WriteLine("Inserted");
            Console.ReadKey();*/

        }
    }
}
