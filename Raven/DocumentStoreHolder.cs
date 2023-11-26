using Raven.Client.Documents;

namespace ravendb.Raven
{
    public static class DocumentStoreHolder
    {
        private static readonly Lazy<IDocumentStore> layStore =
            new Lazy<IDocumentStore>(() =>
            {
                IDocumentStore store = new DocumentStore
                {
                    Urls = new[] { "http://localhost:8080/" },
                    Database = "carrena"
                };

                store.Initialize();

                return store;
            });

        public static IDocumentStore store => layStore.Value;

    }
}
