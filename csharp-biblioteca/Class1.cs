using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class User
        {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
       
        public bool IsRegistered { get; set; }

        public Prestito? Prestito { get; set; }

        public User (string name, string surname, string email, string password, string phoneNumber)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Password = password;
            PhoneNumber = phoneNumber;
           
        }
        public static  User Register()
        {
            Console.WriteLine("Dimmi il tuo nome:");
            string name = Console.ReadLine() ?? "";
            Console.WriteLine("Dimmi il tuo cognome:");
            string? surname = Console.ReadLine() ?? "";
            Console.WriteLine("Dimmi il tuo indirizzo di posta elettronica:");
            string? email = Console.ReadLine() ?? "";
            Console.WriteLine("Dimmi la tua password:");
            string? password = Console.ReadLine() ?? "";
            Console.WriteLine("Dimmi il tuo numero di telefono:");
            string? phoneNumber = Console.ReadLine() ?? "";
            User newUser = new User  (name,surname,email, password,phoneNumber);
            newUser.IsRegistered = true;
            return newUser;
        }
     public string  SearchDocumentByTitle(List<Document> documents)
        {
            if(IsRegistered == true)
            {
                Console.WriteLine("Dimmi il Titolo del libro che vuoi cercare:)");
                string titleSearch = Console.ReadLine() ?? ""; 
                if(titleSearch != null ) { 
                    foreach(var document in documents)
                    {
                        if( document.Title != null && document.Title.Contains(titleSearch))
                        {
                            Console.WriteLine($"Titolo: {document.Title}, Autore: {document.Author}, Genere: {document.Type}");
                            return document.Title;
                        }
                        else
                        {
                            Console.WriteLine("Nessun Titolo è stato trovato");
                            return "";

                        }
                    }
                } else
                {
                    Console.WriteLine("Il campo titolo è vuoto");
                    return "";
                }
            }
            else
            {
                 Console.WriteLine("Non sei registrato");
                return "";

            }
            return "";
        }
    
    }
    internal class Document
    {
        public int Id { get; set; }
        public string? Title { get; set; } 
        public string? Year { get; set; }

        public string? Type { get; set; }

        public int Position { get; set; }
        
        public string? Author { get; set; }

        public Document( string? title, string year, string? type, int position, string? author)
        {
            Id = new Random().Next(100, 900);
            Title = title;
            Year = year;
            Type = type;
            Position = position;
            Author = author;
        }
    }
    internal class DVD : Document
    {
        public string Time { get; set; } 

        public DVD(string? title, string year, string? type, int position, string? author, string Time): base(title, year, type, position, author)
        {
            this.Time = Time;
        }
    }
    internal class Book : Document
    {
        public string Pages { get; set; }

        public Book(string? title, string year, string? type, int position, string? author, string Pages): base(title, year, type, position, author)
        {
            this.Pages = Pages;
        }


    }
    internal class Prestito
    {
        public string? StartDate { get; set; }
        public string? EndDate { get; set; }

        public List<Document>? prestDocument { get; set; }   

        public Prestito(string? startDate, string? endDate, List<Document>? prestDocument)
        {
            StartDate = startDate;
            EndDate = endDate;
            this.prestDocument = prestDocument;
        }
    }
}


