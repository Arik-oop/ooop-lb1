using System;

namespace Model
{
    /// <summary>
    /// Класс для сериализации/десериализации изданий в XML.
    /// </summary>
    public class PublicationData
    {
        /// <summary>
        /// Тип издания (название).
        /// </summary>
        public string PublicationType { get; set; }

        /// <summary>
        /// Заглавие издания.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Сведения о заглавии.
        /// </summary>
        public string TitleInformation { get; set; }

        /// <summary>
        /// Год издания.
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Место издания.
        /// </summary>
        public string Place { get; set; }

        /// <summary>
        /// Издательство.
        /// </summary>
        public string Publisher { get; set; }

        /// <summary>
        /// Количество страниц.
        /// </summary>
        public int TotalPages { get; set; }

        /// <summary>
        /// Список авторов для книги (через разделитель).
        /// </summary>
        public string Authors { get; set; }

        /// <summary>
        /// Частота издания для журнала.
        /// </summary>
        public string Frequency { get; set; }

        /// <summary>
        /// Редакционная коллегия для сборника.
        /// </summary>
        public string EditorialBoard { get; set; }

        /// <summary>
        /// Ответственные редакторы для сборника.
        /// </summary>
        public string ResponsibleEditors { get; set; }

        /// <summary>
        /// Полное имя автора для диссертации.
        /// </summary>
        public string AuthorFull { get; set; }

        /// <summary>
        /// Специальность для диссертации.
        /// </summary>
        public string Speciality { get; set; }

        /// <summary>
        /// Учёная степень для диссертации.
        /// </summary>
        public string Degree { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса
        /// <see cref="PublicationData"/>.
        /// Требуется для сериализации XML.
        /// </summary>
        public PublicationData() { }

        /// <summary>
        /// Создаёт объект <see cref="PublicationData"/>
        /// из издания <see cref="PublicationBase"/>.
        /// </summary>
        /// <param name="pub">Исходное издание.</param>
        /// <returns>Объект данных для сериализации.</returns>
        public static PublicationData FromPublication(
            PublicationBase pub)
        {
            if (pub == null)
            {
                throw new ArgumentNullException(nameof(pub));
            }

            var data = new PublicationData
            {
                Title = pub.Title,
                TitleInformation = pub.TitleInformation,
                Year = pub.Year,
                Place = pub.Place,
                Publisher = pub.Publisher,
                TotalPages = pub.TotalPages
            };

            if (pub is Book book)
            {
                data.PublicationType = "Book";
                data.Authors = string.Join("|", book.Authors);
            }
            else if (pub is Journal journal)
            {
                data.PublicationType = "Journal";
                data.Frequency = journal.Frequency;
            }
            else if (pub is Collection collection)
            {
                data.PublicationType = "Collection";
                data.EditorialBoard = collection.EditorialBoard;
                data.ResponsibleEditors = collection.ResponsibleEditors;
            }
            else if (pub is Dissertation dissertation)
            {
                data.PublicationType = "Dissertation";
                data.AuthorFull = dissertation.AuthorFull;
                data.Speciality = dissertation.Speciality;
                data.Degree = dissertation.Degree;
            }

            return data;
        }

        /// <summary>
        /// Создаёт издание <see cref="PublicationBase"/>
        /// из объекта <see cref="PublicationData"/>.
        /// </summary>
        /// <returns>Созданное издание.</returns>
        /// <exception cref="InvalidOperationException">
        /// Выбрасывается при неизвестном типе издания.</exception>
        public PublicationBase ToPublication()
        {
            return PublicationType switch
            {
                "Book" => CreateBook(),
                "Journal" => CreateJournal(),
                "Collection" => CreateCollection(),
                "Dissertation" => CreateDissertation(),
                _ => throw new InvalidOperationException(
                    $"Неизвестный тип издания: {PublicationType}")
            };
        }

        /// <summary>
        /// Создаёт объект книги из данных сериализации.
        /// </summary>
        /// <returns>Созданная книга.</returns>
        private Book CreateBook()
        {
            var book = new Book
            {
                Title = Title,
                TitleInformation = TitleInformation,
                Year = Year,
                Place = Place,
                Publisher = Publisher,
                TotalPages = TotalPages
            };

            if (!string.IsNullOrEmpty(Authors))
            {
                book.AddAuthors(Authors.Split('|'));
            }

            return book;
        }

        /// <summary>
        /// Создаёт объект журнала из данных сериализации.
        /// </summary>
        /// <returns>Созданный журнал.</returns>
        private Journal CreateJournal() => new Journal
        {
            Title = Title,
            TitleInformation = TitleInformation,
            Year = Year,
            Place = Place,
            Publisher = Publisher,
            TotalPages = TotalPages,
            Frequency = Frequency
        };

        /// <summary>
        /// Создаёт объект сборника из данных сериализации.
        /// </summary>
        /// <returns>Созданный сборник.</returns>
        private Collection CreateCollection() => new Collection
        {
            Title = Title,
            TitleInformation = TitleInformation,
            Year = Year,
            Place = Place,
            Publisher = Publisher,
            TotalPages = TotalPages,
            EditorialBoard = EditorialBoard,
            ResponsibleEditors = ResponsibleEditors
        };

        /// <summary>
        /// Создаёт объект диссертации из данных сериализации.
        /// </summary>
        /// <returns>Созданная диссертация.</returns>
        private Dissertation CreateDissertation() => new Dissertation
        {
            Title = Title,
            TitleInformation = TitleInformation,
            Year = Year,
            Place = Place,
            Publisher = Publisher,
            TotalPages = TotalPages,
            AuthorFull = AuthorFull,
            Speciality = Speciality,
            Degree = Degree
        };
    }
}