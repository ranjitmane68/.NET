﻿namespace PublisherDomain
{
    public class Author
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public List<Book> Books { get; set; } = new List<Book>();

    }
}
