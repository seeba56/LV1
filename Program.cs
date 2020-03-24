using System;

namespace LV1
{
    class Program
    {
        static void Main(string[] args)
        {
            Note FirstNote = new Note();
            Console.WriteLine(FirstNote.getAuthor());
            Console.WriteLine(FirstNote.getText());
            Note SecondNote = new Note("Korona svijetom hara");
            Console.WriteLine(SecondNote.getAuthor());
            Console.WriteLine(SecondNote.getText());
            Note ThirdNote = new Note("Potresi u Hrvatskoj",5, "Marko Marulić");
            Console.WriteLine(ThirdNote.getAuthor());
            Console.WriteLine(ThirdNote.getText());
            Console.WriteLine(ThirdNote.ToString());
            TimeNote timeNote = new TimeNote();
            Console.WriteLine(timeNote.ToString());


        }
    }
}
