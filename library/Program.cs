using library;
 
public class Program
{
    static void Main()
    {
        //default constructor
        book book1 = new book();
        book1.BookTitle = "Aylin";
        book1.AuthorName = "Ayşe";
        book1.AuthorSurname = "Kulin";
        book1.PublishingHouse = "Remzi Kitapevi";
        book1.NumberOfPage = 398;
        book1.PrintInformation();


        //alternative constructor
        book book2 = new book("Aylin", "Ayşe", "Kulin", "Remzi Kitapevi",  398);
        book2.PrintInformation();
    }
}