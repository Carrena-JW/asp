using Raven.Client.Documents;
using ravendb.Models;

namespace ravendb.Raven
{
    public class TestFunction
    {
        public static void CreateSomeData()
        {
            var start = DateTime.Now;


            using var session = DocumentStoreHolder.store.OpenSession();

            for (int i = 0; i < 10000; i++)
            {
                var product = new Product($"thisIsId_{i}", $"thisIsName_{i}", 50000.0);

                session.Store(product);
            }
            
            session.SaveChanges();


            var end = DateTime.Now;
            var totalProcessingTime = end - start;
            Console.WriteLine(totalProcessingTime.ToString());
        }

        public static async Task QuerySomeData()
        {
            using var session = DocumentStoreHolder.store.OpenAsyncSession();
            var allProduct =await session.Query<Product>().ToListAsync();

            foreach(var p in allProduct)
            {
                Console.WriteLine($"ID : {p.getId()}, NAME: {p.getName()}, PRICE:{p.getPrice()}");
            }

        }
    }
}
