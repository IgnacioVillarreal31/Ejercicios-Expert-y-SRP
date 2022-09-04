using System;

namespace SRP
{
    public class Book
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }
        
        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }

        public void Posiciones(String sector, String shelve)
        {
            ShelveBook Posicion = new ShelveBook(sector,shelve);
        }
    }
}

/* 
No cumple con el principio SRP, debido a que hay mas de una responsabilidad en la clase Book
Las dos responsabilidades son: 
1) Agregar libros y su informacion 
2) Agregar donde se encuentra
*/