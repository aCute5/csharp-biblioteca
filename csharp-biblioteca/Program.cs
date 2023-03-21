// See https://aka.ms/new-console-template for more information
using csharp_biblioteca;

Console.WriteLine("Benvenuto nella Biblioteca");


List<Document> documents = new List<Document>()
            {
                new Book("Il signore degli anelli", "1954", "Fantasy", 1, "J.R.R. Tolkien", "1000"),
                new DVD("Il Padrino", "1972", "Drammatico", 2, "Francis Ford Coppola", "2h 55m"),
                new Book("Guerra e pace", "1869", "Storico", 3, "Lev Tolstoj", "1400")
            };

User user = User.Register();

List<Document> title = user.SearchDocumentByTitle(documents);

foreach( var Document in title)
{
    Console.WriteLine(Document.ToString());
}

