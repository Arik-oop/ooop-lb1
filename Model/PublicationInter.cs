using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    /// Интерфейс издания
    /// </summary>
    public interface PublicationInter
    {
        /// <summary>
        /// Заглавие
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// Сведение о заглавии
        /// </summary>
        string TitleInformation { get; set; }

        /// <summary>
        /// Год
        /// </summary>
        int Year { get; set; }

        /// <summary>
        /// Место
        /// </summary>
        string Place { get; set; }

        /// <summary>
        /// Издательство
        /// </summary>
        string Publisher { get; set; }

        /// <summary>
        /// Количество страниц
        /// </summary>
        int TotalPages { get; set; }

        /// <summary>
        /// Метод формирования описания по ГОСТу
        /// </summary>
        /// <returns>Строку с информацие об издании</returns>
        string GetGOST();
    }
}
