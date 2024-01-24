namespace Dip.Model
{
    class MongoDBProduct : DbProduct
    {
        public string GetProductById(int id)
        {
            return $"MongoDB: Exibindo dados do produto {id}.";
        }
    }
}
