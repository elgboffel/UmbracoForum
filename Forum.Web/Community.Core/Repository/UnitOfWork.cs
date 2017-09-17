using Community.Core.EntityModels;
using System;

namespace Community.Core.Repository
{
    public class UnitOfWork : IDisposable
    {
        private CommunityContext _context = new CommunityContext();
        private GenericRepository<Post> _postRepository;
        private GenericRepository<Reply> _replyRepository;
        private GenericRepository<Category> _categoryRepository;

        public GenericRepository<Post> PostRepository
        {
            get
            {

                if (_postRepository == null)
                {
                    _postRepository = new GenericRepository<Post>(_context);
                }
                return _postRepository;
            }
        }

        public GenericRepository<Reply> ReplyRepository
        {
            get
            {

                if (_replyRepository == null)
                {
                    _replyRepository = new GenericRepository<Reply>(_context);
                }
                return _replyRepository;
            }
        }

        public GenericRepository<Category> CategoryRepository
        {
            get
            {

                if (_categoryRepository == null)
                {
                    _categoryRepository = new GenericRepository<Category>(_context);
                }
                return _categoryRepository;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _context.Dispose();
                }

                disposedValue = true;
            }
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
