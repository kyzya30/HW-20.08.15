using System;
using System.Collections.Generic;

namespace HW_20_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Book myBook = new Book();
            loop:
            Console.WriteLine("Выберите действие: 1 - добавить заметку 2 - посмотреть все заметки 3 - выход");
            int select = int.Parse(Console.ReadLine());
            switch (select)
            {
                case 1:
                {
                        Console.WriteLine("Введите страницу на которой Вы хотите оставить заметку:");
                        int pageNum = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите заметку:");
                        string txtOfNote = Console.ReadLine();
                        myBook.AddNote(pageNum, txtOfNote); 
                        goto loop;
                }
                case 2:
                {
                        myBook.ShowNotes();
                        goto loop;
                }
                case 3: break;
            }
        }
    }
    class Book
    {
        Notes notes;
        public Book()
        {
            notes = new Notes();   
        }
        private class Notes
        {
           public Dictionary<int, string> NotesList = new Dictionary<int, string>();
        }
        public void AddNote(int pageOfbook, string textOfNote)
        {
            notes.NotesList.Add(pageOfbook, textOfNote);
            Console.WriteLine("Заметка с текстом: \"{0}\" на {1} страницу добавлена.", textOfNote, pageOfbook);
        }
        public void ShowNotes()
        {
            foreach (var Lstnotes in notes.NotesList)
            {
                Console.WriteLine(Lstnotes);
            }
        }
       
    }
}
