using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Fundamentals.Procedural_Approach
{
    using System;
    using System.Collections.Generic;

    class LibraryProcedural
    {
        static List<Dictionary<string, object>> books = new List<Dictionary<string, object>>();
        static List<Dictionary<string, string>> issuedBooks = new List<Dictionary<string, string>>();

        static void AddBook(string id, string title, string author)
        {
            books.Add(new Dictionary<string, object>
        {
            { "ID", id },
            { "Title", title },
            { "Author", author },
            { "IsAvailable", true }
        });
        }

        static void IssueBook(string bookId, string memberId, string memberName)
        {
            foreach (var book in books)
            {
                if ((string)book["ID"] == bookId && (bool)book["IsAvailable"])
                {
                    book["IsAvailable"] = false;
                    issuedBooks.Add(new Dictionary<string, string>
                {
                    { "BookID", bookId },
                    { "MemberID", memberId },
                    { "MemberName", memberName }
                });
                    Console.WriteLine($"Book {book["Title"]} issued to {memberName}.");
                    return;
                }
            }
            Console.WriteLine("Book not available.");
        }

        static void ViewLibraryStatus()
        {
            Console.WriteLine("Available Books:");
            foreach (var book in books)
            {
                if ((bool)book["IsAvailable"])
                {
                    Console.WriteLine($"- {book["Title"]} by {book["Author"]}");
                }
            }

            Console.WriteLine("\nIssued Books:");
            foreach (var issued in issuedBooks)
            {
                Console.WriteLine($"- Book ID: {issued["BookID"]}, Issued to: {issued["MemberName"]}");
            }
        }

        public static void CallProcedure()
        {
            AddBook("1", "1984", "George Orwell");
            AddBook("2", "To Kill a Mockingbird", "Harper Lee");

            ViewLibraryStatus();

            IssueBook("1", "101", "Alice");
            ViewLibraryStatus();
        }
    }

}
