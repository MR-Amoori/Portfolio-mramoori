namespace Portfolio.DataLayer.Repositories
{
    public interface IPortfolioRepository
    {
        Models.Portfolio GetBy(int id);
        void Add(Models.Portfolio portfolio);
        void Update(Models.Portfolio portfolio);
        void Delete(int id);
        void Save();
    }
}