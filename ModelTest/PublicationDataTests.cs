using Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace ModelTest
{
    /// <summary>
    /// Класс для проведения тестов класса PublicationData
    /// </summary>
    [TestFixture]
    public class PublicationDataTests
    {
        /// <summary>
        /// Проверка создания PublicationData из книги
        /// </summary>
        [TestCase(TestName = "Проверка создания PublicationData из книги")]
        public void FromPublicationBookTest()
        {
            var book = new Book
            {
                Title = "Тестовая книга",
                TitleInformation = "учебное пособие",
                Year = 2023,
                Place = "Москва",
                Publisher = "Наука",
                TotalPages = 300
            };
            book.AddAuthors("Иванов И.И.", "Петров П.П.");

            var data = PublicationData.FromPublication(book);

            Assert.Multiple(() =>
            {
                Assert.That(data.PublicationType, Is.EqualTo("Book"));
                Assert.That(data.Title, Is.EqualTo("Тестовая книга"));
                Assert.That(data.TitleInformation, Is.EqualTo("учебное пособие"));
                Assert.That(data.Year, Is.EqualTo(2023));
                Assert.That(data.Place, Is.EqualTo("Москва"));
                Assert.That(data.Publisher, Is.EqualTo("Наука"));
                Assert.That(data.TotalPages, Is.EqualTo(300));
                Assert.That(data.Authors, Does.Contain("Иванов И.И."));
                Assert.That(data.Authors, Does.Contain("Петров П.П."));
            });
        }

        /// <summary>
        /// Проверка создания PublicationData из журнала
        /// </summary>
        [TestCase(TestName = "Проверка создания PublicationData из журнала")]
        public void FromPublicationJournalTest()
        {
            var journal = new Journal
            {
                Title = "Тестовый журнал",
                TitleInformation = "научный",
                Year = 2024,
                Place = "СПб",
                Publisher = "Питер",
                TotalPages = 150,
                Frequency = "Ежемесячно"
            };

            var data = PublicationData.FromPublication(journal);

            Assert.Multiple(() =>
            {
                Assert.That(data.PublicationType, Is.EqualTo("Journal"));
                Assert.That(data.Frequency, Is.EqualTo("Ежемесячно"));
            });
        }

        /// <summary>
        /// Проверка создания PublicationData из сборника
        /// </summary>
        [TestCase(TestName = "Проверка создания PublicationData из сборника")]
        public void FromPublicationCollectionTest()
        {
            var collection = new Collection
            {
                Title = "Тестовый сборник",
                Year = 2023,
                Place = "Москва",
                Publisher = "МГУ",
                TotalPages = 250,
                EditorialBoard = "Иванов И.И.",
                ResponsibleEditors = "Петров П.П."
            };

            var data = PublicationData.FromPublication(collection);

            Assert.Multiple(() =>
            {
                Assert.That(data.PublicationType, Is.EqualTo("Collection"));
                Assert.That(data.EditorialBoard, Is.EqualTo("Иванов И.И."));
                Assert.That(data.ResponsibleEditors, Is.EqualTo("Петров П.П."));
            });
        }

        /// <summary>
        /// Проверка создания PublicationData из диссертации
        /// </summary>
        [TestCase(TestName = "Проверка создания PublicationData из диссертации")]
        public void FromPublicationDissertationTest()
        {
            var dissertation = new Dissertation
            {
                Title = "Тестовая диссертация",
                Year = 2024,
                Place = "Казань",
                Publisher = "КГУ",
                TotalPages = 180,
                AuthorFull = "Иванов Иван Иванович",
                Speciality = "05.13.01",
                Degree = "Кандидат наук"
            };

            var data = PublicationData.FromPublication(dissertation);

            Assert.Multiple(() =>
            {
                Assert.That(data.PublicationType, Is.EqualTo("Dissertation"));
                Assert.That(data.AuthorFull, Is.EqualTo("Иванов Иван Иванович"));
                Assert.That(data.Speciality, Is.EqualTo("05.13.01"));
                Assert.That(data.Degree, Is.EqualTo("Кандидат наук"));
            });
        }

        /// <summary>
        /// Проверка создания PublicationData из null
        /// </summary>
        [TestCase(TestName = "Проверка создания PublicationData из null")]
        public void FromPublicationNullTest()
        {
            Assert.Throws<ArgumentNullException>(
                () => PublicationData.FromPublication(null));
        }

        /// <summary>
        /// Проверка создания книги из PublicationData
        /// </summary>
        [TestCase(TestName = "Проверка создания книги из PublicationData")]
        public void ToPublicationBookTest()
        {
            var data = new PublicationData
            {
                PublicationType = "Book",
                Title = "Книга из данных",
                TitleInformation = "учебное пособие",
                Year = 2023,
                Place = "Москва",
                Publisher = "Наука",
                TotalPages = 200,
                Authors = "Иванов И.И.|Петров П.П."
            };

            var publication = data.ToPublication();

            Assert.Multiple(() =>
            {
                Assert.That(publication, Is.InstanceOf<Book>());
                Assert.That(publication.Title, Is.EqualTo("Книга из данных"));
                var book = publication as Book;
                Assert.That(book.Authors.Count, Is.EqualTo(2));
            });
        }

        /// <summary>
        /// Проверка создания журнала из PublicationData
        /// </summary>
        [TestCase(TestName = "Проверка создания журнала из PublicationData")]
        public void ToPublicationJournalTest()
        {
            var data = new PublicationData
            {
                PublicationType = "Journal",
                Title = "Журнал из данных",
                TitleInformation = "научный журнал",
                Year = 2024,
                Place = "СПб",
                Publisher = "Питер",
                TotalPages = 100,
                Frequency = "Ежеквартально"
            };

            var publication = data.ToPublication();

            Assert.Multiple(() =>
            {
                Assert.That(publication, Is.InstanceOf<Journal>());
                Assert.That((publication as Journal).Frequency, Is.EqualTo("Ежеквартально"));
            });
        }

        /// <summary>
        /// Проверка создания сборника из PublicationData
        /// </summary>
        [TestCase(TestName = "Проверка создания сборника из PublicationData")]
        public void ToPublicationCollectionTest()
        {
            var data = new PublicationData
            {
                PublicationType = "Collection",
                Title = "Сборник из данных",
                TitleInformation = "сборник статей",
                Year = 2023,
                Place = "Москва",
                Publisher = "МГУ",
                TotalPages = 300,
                EditorialBoard = "Иванов И.И.",
                ResponsibleEditors = "Петров П.П."
            };

            var publication = data.ToPublication();

            Assert.Multiple(() =>
            {
                Assert.That(publication, Is.InstanceOf<Collection>());
                var collection = publication as Collection;
                Assert.That(collection.EditorialBoard, Is.EqualTo("Иванов И.И."));
                Assert.That(collection.ResponsibleEditors, Is.EqualTo("Петров П.П."));
            });
        }

        /// <summary>
        /// Проверка создания диссертации из PublicationData
        /// </summary>
        [TestCase(TestName = "Проверка создания диссертации из PublicationData")]
        public void ToPublicationDissertationTest()
        {
            var data = new PublicationData
            {
                PublicationType = "Dissertation",
                Title = "Диссертация из данных",
                TitleInformation = "научная работа",
                Year = 2024,
                Place = "Казань",
                Publisher = "КГУ",
                TotalPages = 200,
                AuthorFull = "Иванов Иван Иванович",
                Speciality = "05.13.01",
                Degree = "Доктор наук"
            };

            var publication = data.ToPublication();

            Assert.Multiple(() =>
            {
                Assert.That(publication, Is.InstanceOf<Dissertation>());
                var dissertation = publication as Dissertation;
                Assert.That(dissertation.AuthorFull, Is.EqualTo("Иванов Иван Иванович"));
                Assert.That(dissertation.Speciality, Is.EqualTo("05.13.01"));
                Assert.That(dissertation.Degree, Is.EqualTo("Доктор наук"));
            });
        }

        /// <summary>
        /// Проверка создания неизвестного типа издания
        /// </summary>
        [TestCase(TestName = "Проверка создания неизвестного типа издания")]
        public void ToPublicationUnknownTypeTest()
        {
            var data = new PublicationData
            {
                PublicationType = "UnknownType"
            };

            Assert.Throws<InvalidOperationException>(
                () => data.ToPublication());
        }

        /// <summary>
        /// Проверка конструктора по умолчанию
        /// </summary>
        [TestCase(TestName = "Проверка конструктора по умолчанию")]
        public void DefaultConstructorTest()
        {
            var data = new PublicationData();
            Assert.That(data, Is.Not.Null);
        }

        /// <summary>
        /// Проверка сериализации и десериализации
        /// </summary>
        [TestCase(TestName = "Проверка сериализации и десериализации")]
        public void SerializationDeserializationTest()
        {
            var publications = new List<PublicationData>
            {
                new PublicationData
                {
                    PublicationType = "Book",
                    Title = "Тестовая книга",
                    TitleInformation = "учебное пособие",
                    Year = 2023,
                    Place = "Москва",
                    Publisher = "Наука",
                    TotalPages = 200,
                    Authors = "Иванов И.И."
                }
            };

            var serializer = new XmlSerializer(typeof(List<PublicationData>));
            string xml;
            using (var writer = new StringWriter())
            {
                serializer.Serialize(writer, publications);
                xml = writer.ToString();
            }

            Assert.That(xml, Does.Contain("Book"));
            Assert.That(xml, Does.Contain("Тестовая книга"));

            using (var reader = new StringReader(xml))
            {
                var deserialized = (List<PublicationData>)serializer.Deserialize(reader);
                Assert.Multiple(() =>
                {
                    Assert.That(deserialized.Count, Is.EqualTo(1));
                    Assert.That(deserialized[0].Title, Is.EqualTo("Тестовая книга"));
                });
            }
        }
    }
}