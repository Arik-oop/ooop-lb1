using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    //TODO: Зачем?
    /// <summary>
    /// Интерфейс издания.
    /// </summary>
    public interface IPublication
    {
        /// <summary>
        /// Заглавие издания.
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// Сведения о заглавии.
        /// </summary>
        string TitleInformation { get; set; }

        /// <summary>
        /// Год издания.
        /// </summary>
        int Year { get; set; }

        /// <summary>
        /// Место издания.
        /// </summary>
        string Place { get; set; }

        /// <summary>
        /// Издательство.
        /// </summary>
        string Publisher { get; set; }

        /// <summary>
        /// Количество страниц.
        /// </summary>
        int TotalPages { get; set; }

        /// <summary>
        /// Метод для получения информации об издании по ГОСТ.
        /// </summary>
        /// <returns>Строковое описание издания по ГОСТ.</returns>
        string GetGOST();
    }
}
