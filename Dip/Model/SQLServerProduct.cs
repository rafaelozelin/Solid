namespace Dip.Model
{
    class SQLServerProduct : DbProduct
    {
        public string GetProductById(int id)
        {
            return $"SQLServer: Exibindo dados do produto {id}.";
        }
    }
}
