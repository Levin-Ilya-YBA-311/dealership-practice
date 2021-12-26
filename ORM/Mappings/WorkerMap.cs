﻿// <copyright file="WorkerMap.cs" company="Лёвин И. Д.">
// Copyright (c) Лёвин И. Д.. All rights reserved.
// </copyright>

namespace ORM.Mappings
{
    using Domain;
    using FluentNHibernate.Mapping;

    internal class WorkerMap : ClassMap<Worker>
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="WorkerMap"/>.
        /// </summary>
        public WorkerMap()
        {
            // this.Schema("dbo");

            this.Table("Workers");

            this.Id(x => x.Id_worker).Not.Nullable();

            this.Map(x => x.FIO).Not.Nullable();
            this.Map(x => x.Working).Not.Nullable();

            this.HasMany(x => x.Carsales);
        }
    }
}
