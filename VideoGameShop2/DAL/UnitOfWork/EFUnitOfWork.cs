using DAL.Interfaces;
using DAL.Interfaces.EFInterfaces.IEFRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.UnitOfWork
{
    public class EFUnitOfWork : IEFUnitOfWork
    {
        private readonly IEFDeveloperRepository _efDeveloperRepository;
        private readonly IEFGameRepository _efGameRepository;
        private readonly IEFGenreRepository _efGenreRepository;
        private readonly IEFPublisherRepository _efPublisherRepository;
        private readonly IEFUserBoughtRepository _efUserBoughtRepository;

        public EFUnitOfWork(IEFDeveloperRepository eFDeveloperRepository,
            IEFGameRepository eFGameRepository,
            IEFGenreRepository eFGenreRepository,
            IEFPublisherRepository eFPublisherRepository,
            IEFUserBoughtRepository eFUserBoughtRepository)
        {
            _efDeveloperRepository = eFDeveloperRepository;
            _efGameRepository = eFGameRepository;
            _efGenreRepository = eFGenreRepository;
            _efPublisherRepository = eFPublisherRepository;
            _efUserBoughtRepository = eFUserBoughtRepository;
        }

        public IEFDeveloperRepository EFDeveloperRepository
        {
            get { return _efDeveloperRepository; }
        }

        public IEFGameRepository EFGameRepository
        {
            get { return _efGameRepository; }
        }

        public IEFGenreRepository EFGenreRepository
        {
            get { return _efGenreRepository; }
        }

        public IEFPublisherRepository EFPublisherRepository
        {
            get { return _efPublisherRepository; }
        }

        public IEFUserBoughtRepository EFUserBoughtRepository
        {
            get { return _efUserBoughtRepository; }
        }

        public void Complete()
        { throw new NotImplementedException(); }
    }
}
