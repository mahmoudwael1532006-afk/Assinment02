namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            // Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a
            // variable of type object.Print it.
            //Book book = new Book();
            //book.Title = "c# Basics";
            //book.Pages = 50;
            //object obj = book;
            //Console.WriteLine(obj);
            #endregion

            #region Q02
            //Using the Book class above, print the result of calling ToString(), Equals() (compare book with
            //itself), GetHashCode(), and GetType() on book
            //Console.WriteLine(obj.ToString());
            //Console.WriteLine(obj.Equals(obj));//in this case compare with value 
            //Console.WriteLine(obj.GetHashCode());
            //Console.WriteLine(obj.GetType());
            #endregion

            #region Q03
            //Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it.
            //int pages = "464";

            #endregion

            #region Q04
            //Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by
            //zero", and then prints "Done" in a finally block.
            //try
            //{
            //    int x = 10;
            //    Console.WriteLine(x / 0);
            //}
            //catch (Exception ex)//divide by zero exception
            //{
            //    Console.WriteLine("Cannot divide by zero");
            //}
            //finally { Console.WriteLine("Done"); }
            #endregion

            #region Q05
            //Declare an int pages = 300; then store it in a double variable without using a cast.
            //int pages = 300;
            //double pagesWithDouble = 300;//300.0

            #endregion

            #region Q06
            //Declare a double price = 49.99; then convert it into an int using a cast.
            //double price = 49.99;
            //int priceWithInt = (int)price;//49
            #endregion

            #region Q07
            //Given string pagesText = "464";, convert it into an int using the Convert class.
            //string pagesText = "464";
            //int pageTextWithInt=Convert.ToInt32(pagesText);
            #endregion

            #region Q08
            //Given string yearText = "2023";, convert it using int.Parse(). Then given string badText = "abc";,
            //use int.TryParse() to safely try converting it, and print "Invalid number" if it fails
            //string yearText= "2023";
            //int yearTextWithInt=int.Parse(yearText);
            //string badText = "abc";
            //int.TryParse(badText, out int badTexrWithInt);
            //if (badTexrWithInt == 0)
            //{
            //    Console.WriteLine("Invalid number");
            //}

            #endregion

            #region Q09
            // Given int pages = 464;, convert it into a string using ToString() and print its type using GetType()
            //to prove it's now a string.
            //int pages = 464;
            //string pagesWithString = pages.ToString();
            //Console.WriteLine(pagesWithString.GetType());//system.string
            #endregion

            #region Q10
            //Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int
            //variable, and print both.
            //int copies = 100;
            //object obj = copies;
            //int objInt = (int)obj;
            //Console.WriteLine(obj);//100
            //Console.WriteLine(objInt);//100
            #endregion
        }
    }
}
