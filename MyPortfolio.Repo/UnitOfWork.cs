using MyPortfolio.DAL.EF;
using MyPortfolio.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyPortfolio.Repo
{
    public class UnitOfWork : IDisposable
    {
        private ApplicationContext db = new ApplicationContext();
        private Repository<Category> CategoryRepository;
        private Repository<Comment> CommentRepository;
        private Repository<Record> RecordRepository;
        private Repository<TypeRecord> TypeRecordRepository;

        public Repository<Category> Categories
        {
            get
            {
                if(CategoryRepository == null)
                    CategoryRepository = new Repository<Category>(db);
                return CategoryRepository;
            }
        }

        public Repository<Comment> Comments
        {
            get
            {
                if (CommentRepository == null)
                    CommentRepository = new Repository<Comment>(db);
                return CommentRepository;
            }
        }

        public Repository<Record> Records
        {
            get
            {
                if (RecordRepository == null)
                    RecordRepository = new Repository<Record>(db);
                return RecordRepository;
            }
        }

        public Repository<TypeRecord> TypeRecords
        {
            get
            {
                if (TypeRecordRepository == null)
                    TypeRecordRepository = new Repository<TypeRecord>(db);
                return TypeRecordRepository;
            }
        }



        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
