using DAL.Interfaces.EFInterfaces.IEFRepositories;

namespace DAL.Interfaces
{
    public interface IEFUnitOfWork
    {
        IEFDeveloperRepository EFDeveloperRepository { get; }
        IEFGameRepository EFGameRepository { get; }
        IEFGenreRepository EFGenreRepository { get; }
        IEFPublisherRepository EFPublisherRepository { get; }
        IEFUserBoughtRepository EFUserBoughtRepository { get; }

        void Complete();
    }
}
