using System;

namespace Model
{
    /// <summary>
    /// Класс для генерации случайных изданий.
    /// </summary>
    public static class RandomDataGenerator
    {
        /// <summary>
        /// Генератор случайных чисел.
        /// </summary>
        private static readonly Random _random = new Random();

        /// <summary>
        /// Массив случайных названий книг.
        /// </summary>
        private static readonly string[] BookTitles =
        {
            "Война и мир", "Преступление и наказание", "Анна Каренина",
            "Мастер и Маргарита", "Евгений Онегин", "Мёртвые души",
            "Отцы и дети", "Идиот", "Братья Карамазовы", "Тихий Дон",
            "Доктор Живаго", "Обломов", "Герой нашего времени",
            "Записки из подполья", "Бесы", "Подросток"
        };

        /// <summary>
        /// Массив случайных авторов.
        /// </summary>
        private static readonly string[] Authors =
        {
            "Толстой Л.Н.", "Достоевский Ф.М.", "Пушкин А.С.",
            "Булгаков М.А.", "Гоголь Н.В.", "Тургенев И.С.",
            "Чехов А.П.", "Лермонтов М.Ю.", "Гончаров И.А.",
            "Шолохов М.А.", "Пастернак Б.Л."
        };

        /// <summary>
        /// Массив случайных мест издания.
        /// </summary>
        private static readonly string[] Places =
        {
            "Москва", "Санкт-Петербург", "Казань", "Новосибирск",
            "Екатеринбург", "Нижний Новгород", "Самара", "Омск",
            "Челябинск", "Ростов-на-Дону", "Уфа", "Красноярск"
        };

        /// <summary>
        /// Массив случайных издательств.
        /// </summary>
        private static readonly string[] Publishers =
        {
            "Наука", "Просвещение", "АСТ", "Эксмо", "Дрофа",
            "Феникс", "Питер", "БХВ-Петербург", "Вильямс", "Диалектика"
        };

        /// <summary>
        /// Массив случайных специальностей для диссертаций.
        /// </summary>
        private static readonly string[] Specialities =
        {
            "05.13.01", "05.13.06", "05.13.11", "05.13.17",
            "05.13.18", "05.13.02", "05.13.10", "05.13.12"
        };

        /// <summary>
        /// Массив случайных ученых степеней.
        /// </summary>
        private static readonly string[] Degrees =
        {
            "кандидат технических наук", "кандидат физико-математических наук",
            "кандидат экономических наук", "кандидат педагогических наук",
            "доктор технических наук", "доктор физико-математических наук"
        };

        /// <summary>
        /// Массив случайных полных имён авторов диссертаций.
        /// </summary>
        private static readonly string[] AuthorFullNames =
        {
            "Иванов Иван Иванович", "Петров Петр Петрович",
            "Сидоров Сидор Сидорович", "Смирнов Алексей Николаевич",
            "Кузнецова Мария Владимировна", "Попов Дмитрий Сергеевич",
            "Васильева Елена Александровна", "Новиков Андрей Викторович"
        };

        /// <summary>
        /// Массив случайных сведений о заглавии.
        /// </summary>
        private static readonly string[] TitleInformations =
        {
            "роман", "повесть", "сборник рассказов", "монография",
            "учебное пособие", "научное издание", "художественная литература",
            "документальная проза", "исторический очерк", "биография",
            "справочник", "энциклопедия", "антология", "хрестоматия"
        };

        /// <summary>
        /// Массив случайных частот издания журналов.
        /// </summary>
        private static readonly string[] Frequencies =
        {
            "Ежемесячно", "Ежеквартально", "Еженедельно",
            "Два раза в месяц", "Раз в полгода", "Ежегодно"
        };

        /// <summary>
        /// Массив случайных названий журналов.
        /// </summary>
        private static readonly string[] JournalTitles =
        {
            "Вестник науки", "Технические науки", "Современные технологии",
            "Инновации и развитие", "Научный прогресс", "Исследования и практика",
            "Технологии будущего", "Научный вестник", "Актуальные проблемы науки"
        };

        /// <summary>
        /// Массив случайных названий сборников.
        /// </summary>
        private static readonly string[] CollectionTitles =
        {
            "Сборник научных трудов", "Материалы конференции",
            "Труды института", "Сборник статей", "Научные доклады",
            "Исследования молодых ученых", "Сборник тезисов"
        };

        /// <summary>
        /// Массив случайных редакционных коллегий.
        /// </summary>
        private static readonly string[] EditorialBoards =
        {
            "Иванов И.И., Петров П.П., Сидоров С.С.",
            "Смирнов А.Н., Кузнецова М.В., Попов Д.С.",
            "Васильева Е.А., Новиков А.В., Морозов В.В."
        };

        /// <summary>
        /// Массив случайных ответственных редакторов.
        /// </summary>
        private static readonly string[] ResponsibleEditors =
        {
            "Иванов И.И.", "Петров П.П.", "Сидоров С.С.",
            "Смирнов А.Н.", "Кузнецова М.В.", "Попов Д.С."
        };

        /// <summary>
        /// Массив случайных тем для диссертаций.
        /// </summary>
        private static readonly string[] DissertationTopics =
        {
            "оптимизации", "анализа", "синтеза", "моделирования",
            "разработки", "исследования", "проектирования"
        };

        /// <summary>
        /// Генерирует случайную книгу.
        /// </summary>
        /// <returns>Случайная книга.</returns>
        public static Book GenerateRandomBook()
        {
            var book = new Book
            {
                Title = GetRandomElement(BookTitles),
                TitleInformation = GetRandomElement(TitleInformations),
                Place = GetRandomElement(Places),
                Publisher = GetRandomElement(Publishers),
                Year = _random.Next(1990, 2024),
                TotalPages = _random.Next(100, 500)
            };

            int authorCount = _random.Next(1, 4);
            for (int i = 0; i < authorCount; i++)
            {
                book.AddAuthors(GetRandomElement(Authors));
            }

            return book;
        }

        /// <summary>
        /// Генерирует случайный журнал.
        /// </summary>
        /// <returns>Случайный журнал.</returns>
        public static Journal GenerateRandomJournal()
        {
            return new Journal
            {
                Title = GetRandomElement(JournalTitles),
                TitleInformation = GetRandomElement(TitleInformations),
                Place = GetRandomElement(Places),
                Publisher = GetRandomElement(Publishers),
                Year = _random.Next(1990, 2024),
                TotalPages = _random.Next(50, 300),
                Frequency = GetRandomElement(Frequencies)
            };
        }

        /// <summary>
        /// Генерирует случайный сборник.
        /// </summary>
        /// <returns>Случайный сборник.</returns>
        public static Collection GenerateRandomCollection()
        {
            return new Collection
            {
                Title = GetRandomElement(CollectionTitles),
                TitleInformation = GetRandomElement(TitleInformations),
                Place = GetRandomElement(Places),
                Publisher = GetRandomElement(Publishers),
                Year = _random.Next(1990, 2024),
                TotalPages = _random.Next(100, 400),
                EditorialBoard = GetRandomElement(EditorialBoards),
                ResponsibleEditors = GetRandomElement(ResponsibleEditors)
            };
        }

        /// <summary>
        /// Генерирует случайную диссертацию.
        /// </summary>
        /// <returns>Случайная диссертация.</returns>
        public static Dissertation GenerateRandomDissertation()
        {
            return new Dissertation
            {
                Title = $"Исследование методов {GetRandomElement(DissertationTopics)}",
                TitleInformation = GetRandomElement(TitleInformations),
                Place = GetRandomElement(Places),
                Publisher = GetRandomElement(Publishers),
                Year = _random.Next(2000, 2024),
                TotalPages = _random.Next(100, 300),
                AuthorFull = GetRandomElement(AuthorFullNames),
                Speciality = GetRandomElement(Specialities),
                Degree = GetRandomElement(Degrees)
            };
        }

        /// <summary>
        /// Получает случайный элемент из массива.
        /// </summary>
        /// <typeparam name="T">Тип элементов массива.</typeparam>
        /// <param name="array">Массив элементов.</param>
        /// <returns>Случайный элемент.</returns>
        private static T GetRandomElement<T>(T[] array)
        {
            return array[_random.Next(array.Length)];
        }
    }
}