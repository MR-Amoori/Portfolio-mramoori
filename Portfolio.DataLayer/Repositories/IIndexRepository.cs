using Portfolio.DataLayer.ViewModels;

namespace Portfolio.DataLayer.Repositories
{
    public interface IIndexRepository
    {
        IndexViewModel GetIndex();
    }
}