using NorthWind.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace NorthWind.DataAccess.Abstract
{
    // Bu T referans tipinde olucak IEntity'den gelicek ve new'lenebilen olmalı
    public interface IEntityRepository<T> where T : class ,IEntity, new()
    {
        // T Generic bir tipdir
        // Filtereye görede ürün getirebilir. Ama filtre vermezse bütün veriler gelir.
        List<T> GetAll(Expression<Func<T, bool>> filter = null);

        T GetProduct(Expression<Func<T, bool>> filter);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}
