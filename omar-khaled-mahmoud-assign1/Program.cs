

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
            // Q1- Create a Book class with a Title (string) and Pages (int)
            // then , create a book object and store it in an object variable and print the object to the console ? 
            #region Question-1
       
            Console.WriteLine("Hello, Friend! may be i should i give you a name ?!");
            Book bo = new Book();
            object book = bo;
            Console.WriteLine(book);
            Console.WriteLine("[+] Done q1 [#]");
           
            #endregion
   
            #region Question-2
            // Q2- using the book class above ,print the results of calling ToString(),Equals(),GetHashCode(),GetType() on the book object ?  //
            Console.WriteLine(book.ToString());
            Console.WriteLine(book.Equals(bo));
            Console.WriteLine(book.GetHashCode());
            Console.WriteLine(book.GetType());
            Console.WriteLine("[+] Done q2 [3]");
            #endregion

            #region Question-3
            // Q3- Look at the line below ,is it a compile-time error , runtime error or a logical error ? Fix it ?  //
            // int pages = "464";
            // it,s a compile-time error because we are trying to assign a string value to an int variable
            // ,we can fix it by changing the type of the variable to string or by parsing the string to an int . 
            int pages = int.Parse("464");
            Console.WriteLine(pages.GetType());
            #endregion

            #region Question-4

            // Q4- Write code that divides 10 by 0 inside a try block, catch the exception ,prints "Cannot divide by zero" 
            // ,then prints "Done" in a finally block ? 
            try {
                int ten,zero,sum;
                ten = 10;
                zero = 0;
                sum = ten / zero;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("Done");
            }

            #endregion

            #region Question-5

            // Q5- Declare an int variable called pages and assign it a value of 300
            // .Then declare a double variable called page and assign it the value of pages.
            // without using any casting or conversion methods. Finally, print the value of page to the console.
            int pagess = 300;
            double page = pagess;
            Console.WriteLine(page);

            #endregion

            #region Question-6
            // Q6- Declare a double variable called price and assign it a value of 49.99
            // then convert it to an int variable called prices using casting and print the value of prices to the console.
            double pricee = 49.99;
            int prices = (int)pricee;
            Console.WriteLine(prices);
            Console.WriteLine(prices.GetType());
            #endregion

            #region Question-7
            // Q7- Declare a string variable called pagesText and assign it a value of "464"
            // then convert it to an int variable called pageText using the convert class and print the value of pageText to the console.
            string pagesText = "464";
            int pageTextt = Convert.ToInt32(pagesText);
            Console.WriteLine(pageTextt);
            Console.WriteLine(pageTextt.GetType());
            #endregion

            #region Question-8
            // Q8- Declare a string variable called yearText and assign it a value of "2023",
            // then convert it to an int variable called year using the parse method and print the value of year to the console.
            // then the given Text string badtxt = "abcd" and try to convert it to an int variable called badtxt2
            // using the tryparse method and print the value of badtxt2 to the console.
            string yearText = "2023";
            int year = int.Parse(yearText);
            string badchars = "abcd";
            int badchars2;
            bool isConverted = int.TryParse(badchars, out badchars2);
            if(isConverted)
            {
                Console.WriteLine(badchars2);
            }
            else { 
                Console.WriteLine("Invalid number");
            }
            #endregion

            #region Question-9

            // Q9- Declare an int variable called pagesBig and assign it a value of 464
            // then convert it to a string variable called smText using the ToString() method and print the value of smText to the console.
            // then print the type of smText to the console.

            int pagesBig = 464;
            string smText = pagesBig.ToString();
            Console.WriteLine(smText);
            Console.WriteLine(smText.GetType());

            #endregion

            #region Question-10

            // Q10- Declare an int variable called copies and assign it a value of 100
            // then box it into an object variable called cop and print the value of cop to the console.
            // then unbox cop into an int variable called copies2 and print the value of copies2 to the console.
            // and print both the type of cop and copies2 to the console.

            int copies = 100;
            object cop = copies;
            int copies2 = (int)cop;
            Console.WriteLine(cop);
            Console.WriteLine(cop.GetType());
            Console.WriteLine(copies2);
            Console.WriteLine(copies2.GetType());

            #endregion
            

        }
    }
}
