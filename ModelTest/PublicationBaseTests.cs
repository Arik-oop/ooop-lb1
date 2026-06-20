using Model;
using NUnit.Framework;
using System.Text;

namespace ModelTest
{
    /// <summary>
    /// Класс для проведения тестов класса PublicationBase
    /// </summary>
    [TestFixture]
    public class PublicationBaseTests
    {
        [TestCase(TestName = "Проверка метода ValidateString() корректными данными")]
        public void ValidateStringAssertionTest()
        {
            var testPublication = new TestPublication();
            Assert.DoesNotThrow(() => testPublication.TestValidateString
            ("Корректная строка", "TestField"));
            Assert.DoesNotThrow(() => testPublication.TestValidateString
            ("A", "TestField"));
            Assert.DoesNotThrow(() => testPublication.TestValidateString
            ("Очень длинная строка с пробелами и символами!!!", "TestField"));
        }

        [TestCase("", TestName = "Пустая строка")]
        [TestCase("   ", TestName = "Строка из пробелов")]
        [TestCase(null, TestName = "Проверка null в методе ValidateString")]
        public void ValidateStringAssertionNegativeTest(string? invalidValue)
        {
            var testPublication = new TestPublication();
            Assert.Throws<ArgumentException>(() => testPublication.TestValidateString
            (invalidValue, "TestField"));
        }

        [TestCase(868, TestName = "Минимальный год")]
        [TestCase(1500, TestName = "Средний год")]
        [TestCase(2026, TestName = "Текущий год")]
        public void ValidateYearAssertionTest(int year)
        {
            var testPublication = new TestPublication();
            Assert.DoesNotThrow(() => testPublication.TestValidateYear(year));
        }

        [TestCase(867, TestName = "Год меньше минимального")]
        [TestCase(2027, TestName = "Год больше текущего")]
        [TestCase(100, TestName = "Слишком маленький год")]
        public void ValidateYearAssertionNegativeTest(int year)
        {
            var testPublication = new TestPublication();
            Assert.Throws<ArgumentException>(() 
                => testPublication.TestValidateYear(year));
        }

        [TestCase(7, TestName = "Минимальное количество страниц")]
        [TestCase(100, TestName = "Среднее количество страниц")]
        [TestCase(10000, TestName = "Большое количество страниц")]
        public void ValidatePositiveNumberAssertionTest(int pages)
        {
            var testPublication = new TestPublication();
            Assert.DoesNotThrow(() 
                => testPublication.TestValidatePositiveNumber(pages));
        }

        [TestCase(0, TestName = "Ноль страниц")]
        [TestCase(-1, TestName = "Отрицательное количество страниц")]
        [TestCase(-100, TestName = "Большое отрицательное число")]
        [TestCase(5, TestName = "Меньше минимального количества страниц")]
        public void ValidatePositiveNumberAssertionNegativeTest(int pages)
        {
            var testPublication = new TestPublication();
            Assert.Throws<ArgumentException>(() 
                => testPublication.TestValidatePositiveNumber(pages));
        }

        [TestCase(TestName = 
            "Проверка метода AppendIfNotEmpty() корректными данными")]
        public void AppendIfNotEmptyAssertionTest()
        {
            var testPublication = new TestPublication();
            var testData = new (string Prefix, string Value, 
                string Suffix, string Expected)[]
            {
                ("prefix ", "value", " suffix", "prefix value suffix"),
                ("", "value", "", "value"),
                (">>>", "value", "", ">>>value")
            };

            foreach (var (prefix, value, suffix, expected) in testData)
            {
                var stringBuilder = new StringBuilder();
                testPublication.TestAppendIfNotEmpty
                    (stringBuilder, prefix, value, suffix);
                Assert.That(stringBuilder.ToString(), Is.EqualTo(expected));
            }
        }

        [TestCase(TestName = "Проверка метода AppendIfNotEmpty() " +
            "некорректными значениями")]
        public void AppendIfNotEmptyNegativeTest()
        {
            var testPublication = new TestPublication();
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("start");

            testPublication.TestAppendIfNotEmpty(stringBuilder, 
                "prefix ", "", " suffix");
            testPublication.TestAppendIfNotEmpty(stringBuilder, 
                "prefix ", "   ", " suffix");
            testPublication.TestAppendIfNotEmpty(stringBuilder, 
                "prefix ", null, " suffix");

            Assert.That(stringBuilder.ToString(), Is.EqualTo("start"));
        }

        [TestCase(TestName = "Проверка класса PublicationBase " +
            "со всеми свойствами")]
        public void AllPropertiesAssertionTest()
        {
            var publication = new Book();
            publication.Title = "Тестовое название";
            publication.TitleInformation = "Тестовое подзаголовок";
            publication.Year = 2023;
            publication.Place = "Санкт-Петербург";
            publication.Publisher = "ТестИздат";
            publication.TotalPages = 500;

            Assert.Multiple(() =>
            {
                Assert.That(publication.Title, Is.EqualTo("Тестовое название"));
                Assert.That(publication.TitleInformation, 
                    Is.EqualTo("Тестовое подзаголовок"));
                Assert.That(publication.Year, Is.EqualTo(2023));
                Assert.That(publication.Place, Is.EqualTo("Санкт-Петербург"));
                Assert.That(publication.Publisher, Is.EqualTo("ТестИздат"));
                Assert.That(publication.TotalPages, Is.EqualTo(500));
            });
        }

        /// <summary>
        /// Вспомогательный класс для тестирования защищенных методов PublicationBase
        /// </summary>
        public class TestPublication : PublicationBase
        {
            /// <summary>
            /// Метод получения информации по ГОСТ
            /// </summary>
            /// <returns>Строку для теста</returns>
            public override string GetGOST()
            {
                return "Test GOST Information";
            }

            /// <summary>
            /// Метод тестирования валидации строки
            /// </summary>
            /// <param name="value">Значение</param>
            /// <param name="propertyName">Свойство</param>
            public void TestValidateString(string value, string propertyName)
            {
                ValidateString(value, propertyName);
            }

            /// <summary>
            /// Метод тестирования валидации года
            /// </summary>
            /// <param name="year">Год издания</param>
            public void TestValidateYear(int year)
            {
                ValidateYear(year, "Year");
            }

            /// <summary>
            /// Метод тестирования валидации положительного числа
            /// </summary>
            /// <param name="totalPages">Количество страниц</param>
            public void TestValidatePositiveNumber(int totalPages)
            {
                ValidatePositiveNumber(totalPages, "TotalPages");
            }

            /// <summary>
            /// Метод тестирования AppendIfNotEmpty
            /// </summary>
            /// <param name="stringBuilder">Конструкция stringBuilder</param>
            /// <param name="prefix">Префикс</param>
            /// <param name="value">Значение</param>
            /// <param name="suffix">Суффикс</param>
            public void TestAppendIfNotEmpty(StringBuilder stringBuilder, 
                string prefix, string value, string suffix = "")
            {
                AppendIfNotEmpty(stringBuilder, prefix, value, suffix);
            }
        }
    }
}