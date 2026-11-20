

namespace omar_khaled_mahmoud_assign1
{
    class Book {
        public string Title { get; set; }
        public int Pages { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // related to q1 //
            Console.WriteLine("Hello, Friend! may be i should i give you a name ?!");
            Book bo = new Book();

            object book = bo;
            Console.WriteLine(book);
            Console.WriteLine("[+] Done q1 [#]");

            // ------------------------- //
            // related to q2 //
            Console.WriteLine(book.ToString());
            Console.WriteLine(book.Equals(bo));
            Console.WriteLine(book.GetHashCode());
            Console.WriteLine(book.GetType());
            Console.WriteLine("[+] Done q2 [3]");

            // related to q3 //
            // int pages = "464"; //
            // --------------------- //
            // we will back soon //


            // ------------------------- //
            // related to q4 //
            try {
                int num1 = 10;
                int num2 = 0;
                int sum;

                sum = num1 / num2;
            }
            catch(DivideByZeroException e) {
                Console.WriteLine(e);
            }
            finally {
                Console.WriteLine("[+] Done q4 [#]");
            }
            // related to q5 //
            int pages = 100;
            double page = pages;
            Console.WriteLine(page);
            Console.WriteLine("[+] Done q5 [#]");

            // related to q6 //
            double price = 49.99;
            int prices = (int)price;
            Console.WriteLine(prices);
            Console.WriteLine("[+] Done q6 [#]");

             // related to q7 //
            string pagesTexts = "464"; //
            int pageText = int.Parse(pagesTexts);
            Console.WriteLine(pageText);
            Console.WriteLine(pageText.GetType());
            Console.WriteLine("[+] Done q7 [#]");

            // related to q8 //
            string yearText = "2023";
            int year = int.Parse(yearText);



            // string badchars = "abcd";
            // int badchars2 = int.TryParse(badchars);
            // ---------------- we will back soon ---------- //


            // related to q9 //
            int pagesBig = 464;
            string smText = pagesBig.ToString();
            Console.WriteLine(smText);
            Console.WriteLine(smText.GetType());
            Console.WriteLine("[+] Done q9 [#]");


            // related to q10 //
            int copies;
            copies = 100;
            object cop = copies;
            Console.WriteLine(cop);
            Console.WriteLine(cop.GetType());
            cop = (int)500;
            Console.WriteLine(cop);
            Console.WriteLine(cop.GetType());
            Console.WriteLine("[+] Done q10 [#]");


            // related to q11 //
            int? yeard = null;
            yeard = 2023;
            Console.WriteLine(yeard);
            Console.WriteLine(yeard.GetType());
            Console.WriteLine("[+] Done q11 [#]");

            // related to q12 //
            string? txt = null;
            Console.WriteLine(txt);
            txt = "hi follow me!";
            Console.WriteLine(txt);
            Console.WriteLine("[+] Done q12 [#]");


            // related to q13 //
            Book? book3 = null;
            try
            {
                Console.WriteLine(book3.Title);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally {
                Console.WriteLine("[+] Done q13 [#]");
            }

            // related to q14 //
            // --- we will back soon --- //
            // ------------------------ // 


            // related to final question 15 //
            string? name = "Ahmed";
            // we will back soon // 
            /*
             
             finally we have 4 question needed to be solve ?! 
             
             */

        }
    }
}
