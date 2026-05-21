using Model;
using System;
using System.Collections.Generic;

namespace ConsoleLibrary
{
    /// <summary>
    /// Класс программы.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Ширина линии разделителя.
        /// </summary>
        private const int LineWidth = 60;

        /// <summary>
        /// Смещение для отображения номера.
        /// </summary>
        private const int NumberOffset = 1;

        /// <summary>
        /// Список для хранения всех изданий.
        /// </summary>
        private static List<IPublication> _publications = new();

        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        static void Main()
        {
            MainMenu();
        }

        /// <summary>
        /// Метод для отображения главного меню программы.
        /// </summary>
        private static void MainMenu()
        {
            Console.WriteLine("Электронная библиотека");

            while (true)
            {
                Console.WriteLine("\nВыберите действие:");
                Console.WriteLine("b - Добавить книгу");
                Console.WriteLine("j - Добавить журнал");
                Console.WriteLine("s - Добавить сборник");
                Console.WriteLine("d - Добавить диссертацию");
                Console.WriteLine("a - База изданий");
                Console.Write("Действие: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "b":
                    {
                        _publications.Add(InputBook());
                        Console.WriteLine("Книга добавлена\n");
                        break;
                    }
                    case "j":
                    {
                        _publications.Add(InputJournal());
                        break;
                    }
                    case "s":
                    {
                        _publications.Add(InputCollection());
                        Console.WriteLine("Сборник добавлен\n");
                        break;
                    }
                    case "d":
                    {
                        _publications.Add(InputDissertation());
                        Console.WriteLine("Диссертация добавлена\n");
                        break;
                    }
                    case "a":
                    {
                        ShowAllPublications();
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("Такого действия нету");
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Метод для получения словаря действий для базового класса.
        /// </summary>
        /// <typeparam name="T">Тип издания, наследуемый от PublicationBase.</typeparam>
        /// <returns>Словарь действий для заполнения свойств издания.</returns>
        private static Dictionary<string, Action<T>> GetBaseActions<T>()
            where T : PublicationBase
        {
            return new Dictionary<string, Action<T>>
            {
                //TODO: RSDN
                ["название"] = 
                    (publication) => publication.Title = Console.ReadLine(),
                ["сведения о заглавии"] = 
                    (publication) => publication.TitleInformation = Console.ReadLine(),
                ["место издания"] = 
                    (publication) => publication.Place = Console.ReadLine(),
                ["издательство"] = 
                    (publication) => publication.Publisher = Console.ReadLine(),
                ["год издания"] = 
                    (publication) => publication.Year = ReadInteger("Год издания"),
                ["количество страниц"] = 
                    (publication) => publication.TotalPages = ReadInteger("Количество страниц")
            };
        }

        /// <summary>
        /// Метод для ввода данных и создания книги.
        /// </summary>
        /// <returns>Экземпляр книги с заполненными данными.</returns>
        private static Book InputBook()
        {
            var actions = GetBaseActions<Book>();

            actions["авторы (перечислите по одному через Enter, " +
                "оставте пустую строку если закончили)"] = 
                (book) =>
                {
                    while (true)
                    {
                        //TODO: RSDN
                        Console.Write($"Автор {book.Authors.Count + NumberOffset}: ");
                        string author = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(author))
                        {
                            break;
                        }
                        book.AddAuthors(author.Trim());
                    }
                };

            return CreatePublication(actions);
        }

        /// <summary>
        /// Метод для ввода данных и создания журнала.
        /// </summary>
        /// <returns>Экземпляр журнала с заполненными данными.</returns>
        private static Journal InputJournal()
        {
            var actions = GetBaseActions<Journal>();

            actions["частоту издания"] = 
                (journal) => journal.Frequency = Console.ReadLine();

            return CreatePublication(actions);
        }

        /// <summary>
        /// Метод для ввода данных и создания сборника.
        /// </summary>
        /// <returns>Экземпляр сборника с заполненными данными.</returns>
        private static Collection InputCollection()
        {
            var actions = GetBaseActions<Collection>();

            actions["список редакционной коллегии"] = 
                (collection) => collection.EditorialBoard = Console.ReadLine();
            actions["список ответственных редакторов"] = 
                (collection) => collection.ResponsibleEditors = Console.ReadLine();

            return CreatePublication(actions);
        }

        /// <summary>
        /// Метод для ввода данных и создания диссертации.
        /// </summary>
        /// <returns>Экземпляр диссертации с заполненными данными.</returns>
        private static Dissertation InputDissertation()
        {
            var actions = GetBaseActions<Dissertation>();
            actions["полное имя автора, без сокращений"] = 
                (dissertation) => dissertation.AuthorFull = Console.ReadLine();
            actions["специальность"] = 
                (dissertation) => dissertation.Speciality = Console.ReadLine();
            actions["ученую степень диссертации"] = 
                (dissertation) => dissertation.Degree = Console.ReadLine();

            return CreatePublication(actions);
        }

        /// <summary>
        /// Метод для создания издания с применением переданных действий.
        /// </summary>
        /// <typeparam name="T">Тип издания, наследуемый от PublicationBase.</typeparam>
        /// <param name="actions">Словарь действий для заполнения свойств.</param>
        /// <returns>Экземпляр издания с заполненными данными.</returns>
        private static T CreatePublication<T>
            (Dictionary<string, Action<T>> actions)
            where T : PublicationBase, new()
        {
            T publication = new T();

            foreach (var item in actions)
            {
                while (true)
                {
                    try
                    {
                        Console.Write($"Введите {item.Key}: ");
                        item.Value(publication);
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка: {ex.Message}");
                    }
                }
            }

            return publication;
        }

        /// <summary>
        /// Метод для отображения списка всех изданий.
        /// </summary>
        private static void ShowAllPublications()
        {
            if (_publications.Count == 0)
            {
                Console.WriteLine("\nВ базе нет изданий");
                return;
            }

            Console.WriteLine("Список изданий в базе");

            for (int i = 0; i < _publications.Count; i++)
            {
                Console.WriteLine($"\nИздание №{i + NumberOffset}");
                Console.WriteLine(_publications[i].GetGOST());
            }

            Console.WriteLine($"Всего изданий: {_publications.Count}");
        }

        /// <summary>
        /// Метод для чтения целого числа с клавиатуры.
        /// </summary>
        /// <param name="fieldName">Название поля для сообщения об ошибке.</param>
        /// <returns>Введённое целое число.</returns>
        private static int ReadInteger
            (string fieldName)
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (int.TryParse(input, out int result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine($"Значение параметра '{fieldName}'" +
                        $" должно быть целым числом. Попробуйте снова.");
                }
            }
        }
    }
}