namespace Portfolio.DataLayer.Repositories
{
    public interface IPortfolioRepository
    {
        Models.Portfolio GetBy(int id);
        void Update(Models.Portfolio portfolio);
        void Delete(int id);
        void AddPortfolio(Models.Portfolio portfolio);
        void Save();
    }
}