

namespace dealershippractice.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    ///  класс Бренд (марка автомобиля).
    /// </summary>
    class Brand
    {
        /// <summary>
        /// Конструктор инициализации 
        /// </summary>

        public Brand(int id_brand, string brand, string country)
        {
            this.id_brand = id_brand;
            this.brand = brand;
            this.country = country;
        }


        /// <summary>
        /// Уникальный идентификатор.
        /// </summary>
        public int id_brand { get; protected set; }

        /// <summary>
        /// Брэнд.
        /// </summary>
        public string brand { get; protected set; }

        /// <summary>
        /// Страна.
        /// </summary>
        public string country { get; protected set; }


        /// <summary>
        /// переопределение метода ToString
        /// </summary>

        public override string ToString()
        {
            return $"{this.brand} {this.country} ";
        }

    }
}


