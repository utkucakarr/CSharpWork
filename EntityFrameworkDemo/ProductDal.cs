using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace EntityFrameworkDemo
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            // .net memory yöneticisi işi biten nesneler varmı diye bakıyor GarbageCollector sistemiyle işi bitenleri bellekten atıyor
            // Biz using ile garbageCollector'u beklemeden nesneyi zorla bellekten atıyoruz. Bu işleme Dispose denir.
            using (ETradeContext eTradeContext = new ETradeContext())
            {
                return eTradeContext.Products.ToList();
            }
        }

        public List<Product> GetByName(string name)
        {
            using (ETradeContext eTradeContext = new ETradeContext())
            {
                return eTradeContext.Products.Where(x => x.Name.Contains(name)).ToList();
            };
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            using (ETradeContext eTradeContext = new ETradeContext())
            {
                //veritabanına bu sorguyu atar
                //Where bize liste dönüşü yapar.
                return eTradeContext.Products.Where(x => x.UnitPrice >= min && x.UnitPrice <= max).ToList();
            }
        }

        public Product GetByIdProduct(int id)
        {
            using (ETradeContext eTradeContext = new ETradeContext())
            {
                //ilk değeri getirir
                var result = eTradeContext.Products.FirstOrDefault(x => x.Id == id);
                //Birden fazla kayıt gelirse hata dönüyor.
                //var result = eTradeContext.Products.SingleOrDefault(x => x.Id == id);
                return result;
            }
        }

        public List<Product> GetByUnitPrice(decimal unitPrice)
        {
            using (ETradeContext eTradeContext = new ETradeContext())
            {
                //veritabanına bu sorguyu atar
                return eTradeContext.Products.Where(x => x.UnitPrice >= unitPrice).ToList();
            }
        }

        public void Add(Product product)
        {
            //ETradeContext'den yeni bir instance oluşturup bunu eTradeContext değişkeninin içine atıyoruz.
            using (ETradeContext eTradeContext = new ETradeContext())
            {
                var entity = eTradeContext.Entry(product);
                entity.State = EntityState.Added;
                eTradeContext.SaveChanges();
            }
        }

        public void Update(Product product)
        {
            using (ETradeContext eTradeContext = new ETradeContext())
            {
                //gönderdiğimiz product'ı veri tabanındaki product ile eşitliyor
                var entity = eTradeContext.Entry(product);
                //Durumu güncellendi olarak işaretledik. Modified = değiştirildi
                entity.State = EntityState.Modified;
                eTradeContext.SaveChanges();
            }
        }

        public void Remove(Product product)
        {
            using (ETradeContext eTradeContext = new ETradeContext())
            {
                var entity = eTradeContext.Entry(product);
                entity.State = EntityState.Deleted;
                eTradeContext.SaveChanges();
            }
        }
    }
}
