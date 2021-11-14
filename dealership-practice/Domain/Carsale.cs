using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dealershippractice.Domain
{
    /// <summary>
    /// класс Продажа автомобиля.
    /// </summary>
    class Carsale
    {
        public Carsale(int id_carsale, int id_car, int id_worker, DateTime sale_date, double total_price, int flag_option)
        {
            this.id_carsale = id_carsale;
            this.id_car = id_car;
            this.id_worker = id_worker;
            this.sale_date = sale_date;
            this.total_price = total_price;
            this.flag_option = flag_option;
        }

        /// <summary>
        /// Уникальный идентификатор.
        /// </summary>
        public int id_carsale { get; protected set; }

        /// <summary>
        /// Автомобиль (уникальный ключь).
        /// </summary>
        public int id_car { get; protected set; }

        /// <summary>
        /// Сотрудник (уникальный ключь).
        /// </summary>
        public int id_worker { get; protected set; }

        /// <summary>
        /// Дата продажи.
        /// </summary>
        public DateTime sale_date { get; protected set; }

        /// <summary>
        /// итоговая стоимость.
        /// </summary>
        public double total_price { get; protected set; }

        /// <summary>
        /// наличие  дополнительных опций.
        /// </summary>
        public int flag_option { get; protected set; }

        /// <summary>
        /// переопределение метода ToString
        /// </summary>

        public override string ToString()
        {
            return $"{this.sale_date} {this.total_price} ";
        }


    }
}


