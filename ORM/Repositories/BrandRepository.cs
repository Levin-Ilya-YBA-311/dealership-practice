// <copyright file="IRepository.cs" company="МИИТ">
// Copyright (c) Кругов Ю.А. All rights reserved.
// </copyright>

namespace ORM.Repositories
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using Domain;
    using NHibernate;

    /// <summary>
    /// Репозиторий для Бренда(марки автомобиля).
    /// </summary>
    public class BrandRepository : IRepository<Brand>
    {
        private readonly ISession _session;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="BrandRepository"/>.
        /// </summary>
        /// <param name="session">Сессия для Бренда(марки автомобиля).</param>
        public BrandRepository(ISession session)
        {
            this._session = session
                ?? throw new ArgumentNullException(nameof(session));
        }

        /// <inheritdoc/>
        public IQueryable<Brand> Filter(Expression<Func<Brand, bool>> predicate)
        {
            return this.GetAll().Where(predicate);
        }

        /// <inheritdoc/>
        public Brand Find(Expression<Func<Brand, bool>> predicate)
        {
            return this.GetAll().FirstOrDefault(predicate);
        }

        /// <inheritdoc/>
        public Brand Get(int id)
        {
            return this._session.Get<Brand>(id);
        }

        /// <inheritdoc/>
        public IQueryable<Brand> GetAll()
        {
            return this._session.Query<Brand>();
        }

        /// <inheritdoc/>
        public bool TryGet(int id, out Brand Brand)
        {
            Brand = this.GetAll().SingleOrDefault(d => d.Id_brand == id);
            return Brand != null;
        }

        /// <inheritdoc/>
        public Brand Create(Brand Brand)
        {
            var id = (int)this._session.Save(Brand);
            this._session.Flush();
            return Brand;
        }

        /// <inheritdoc/>
        public void Delete(int id)
        {
            if (!this.TryGet(id, out var Brand))
            {
                return;
            }

            this._session.Delete(Brand);
            this._session.Flush();
        }

        /// <inheritdoc/>
        public void Update(Brand Brand)
        {
            this._session.Update(Brand);
            this._session.Flush();
        }
    }
}