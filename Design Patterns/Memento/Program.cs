using System;

namespace Memento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book
            {
                Isbn = "1234",
                Title = "Sefiller",
                Author = "Victor Hugo"
            };

            book.ShowBook();

            // Kitabın yedeğini alalım
            CareTaker history = new CareTaker();
            history.Memento = book.CreateUndo();

            // Bilgileri değiştirelim
            book.Isbn = "54321";
            book.Title = "VİCTOR HUGO";
            book.ShowBook();

            // Eski haline geri dönelim
            book.RestoreFromUndo(history.Memento);
            book.ShowBook();

            Console.ReadLine();
        }
    }

    class Book
    {
        private string _title;
        private string _author;
        private string _isbn;
        private DateTime _lastEdited;

        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                SetLastEditted();
            }
        }

        public string Author
        {
            get { return _author; }
            set
            {
                _author = value;
                SetLastEditted();
            }
        }

        public string Isbn
        {
            get { return _isbn; }
            set
            {
                _isbn = value;
                SetLastEditted();
            }
        }

        private void SetLastEditted()
        {
            _lastEdited = DateTime.UtcNow;
        }

        public Memento CreateUndo()
        {
            return new Memento(_isbn, _title, _author, _lastEdited);
        }

        public void RestoreFromUndo(Memento memento)
        {
            _isbn = memento.Isbn;
            _title = memento.Title;
            _author = memento.Author;
            _lastEdited = DateTime.UtcNow;
        }

        public void ShowBook()
        {
            Console.WriteLine("{0}, {1}, {2} edited: {3}", Isbn, Title, Author, _lastEdited);
        }
    }

    // Memento class - kitap geçmişini tutar
    class Memento
    {
        public string Title { get; set; }
        public string Isbn { get; set; }
        public string Author { get; set; }
        public DateTime LastEdited { get; set; }

        public Memento(string isbn, string title, string author, DateTime lastEdited)
        {
            Isbn = isbn;
            Title = title;
            Author = author;
            LastEdited = lastEdited;
        }
    }

    // CareTaker - mementoyu saklar
    class CareTaker
    {
        public Memento Memento { get; set; }
    }
}
