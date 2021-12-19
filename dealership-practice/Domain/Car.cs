
namespace dealershippractice.Domain
{
    using System;

    /// <summary>
    /// класс Автомобиль.
    /// </summary>
    public class Car
    {
        /// <summary>
        /// конструктор 
        /// </summary>
        
        public Car(int id_car, int id_brand, string model, int year, double engine_power, string color, double price)
        {
            this.id_car = id_car;
            this.id_brand = id_brand;
            this.model = model;
            this.year = year;
            this.engine_power = engine_power;
            this.color = color;
            this.price = price;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Car"/>.
        /// </summary>
        // в этом месте  protected - только для ORM
        //
        [Obsolete("For ORM only", true)]
        protected Car()
        {
        }


        /// <summary>
        /// Уникальный идентификатор.
        /// </summary>
        public virtual int id_car { get; protected set; }
        /// <summary>
        /// Бренд-марка.
        /// </summary>
        public virtual int id_brand { get; protected set; }
        /// <summary>
        /// модель.
        /// </summary>
        public virtual string model { get; protected set; }
        /// <summary>
        /// год выпуска.
        /// </summary>
        public virtual int year { get; protected set; }
        /// <summary>
        /// мощность двигателя.
        /// </summary>
        public virtual double engine_power { get; protected set; }
        /// <summary>
        /// цвет автомобиля.
        /// </summary>
        public virtual string color { get; protected set; }
        /// <summary>
        /// базовая стоимость.
        /// </summary>
        public virtual double price { get; protected set; }


        /// <summary>
        /// переопределение метода ToString
        /// </summary>
      
        public override string ToString()
        {
            return $"{this.model} {this.color} {this.year}  {this.price}";
        }

    }
}

