using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class book
    {
        //property
        public string BookTitle { get; set; }
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }
        public string PublishingHouse { get; set; }
        public int NumberOfPage { get; set; }
        public DateTime RegistrationDate { get; set; }


        //default

        public book()
        {
            RegistrationDate = DateTime.Now;
            Console.WriteLine("book object created.");

        }

        //alternative

        public book (string BookTitle, string AuthorName, string AuthorSurname, string PublishingHouse, int NumberOfPage)
        {
            BookTitle = BookTitle;
            AuthorName = AuthorName;
            AuthorSurname = AuthorSurname;
            PublishingHouse = PublishingHouse;
            NumberOfPage = NumberOfPage;
            RegistrationDate = DateTime.Now;
            Console.WriteLine("book object created.");

        }

        public void PrintInformation()

        {
            Console.WriteLine($" Book Title: {BookTitle}, Author Name: {AuthorName}, Author Surname: {AuthorSurname}, Publishing House: {PublishingHouse}, Number Of Page: {NumberOfPage}, Registration Date: {RegistrationDate}");
        }
        

    }

}
