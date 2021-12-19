

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
    public class Brand
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
        /// Инициализирует новый экземпляр класса <see cref="Brand"/>.
        /// </summary>
        // в этом месте  protected - только для ORM
        //
        [Obsolete("For ORM only", true)]
        protected Brand()
        {
        }

        /// <summary>
        /// Уникальный идентификатор.
        /// </summary>
        public virtual int id_brand { get; protected set; }
     

        /// <summary>
        /// Брэнд.
        /// </summary>
        public virtual string brand { get; protected set; }

        /// <summary>
        /// Страна.
        /// </summary>
        public virtual string country { get; protected set; }


        /// <summary>
        /// переопределение метода ToString
        /// </summary>

        public override string ToString()
        {
            return $"{this.brand} {this.country} ";
        }

    }
}


