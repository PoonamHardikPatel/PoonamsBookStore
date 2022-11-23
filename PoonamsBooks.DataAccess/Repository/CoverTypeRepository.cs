using PoonamsBooks.DataAccess.Repository.IRepository;
using PoonamsBooks.Models;
using PoonamsBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PoonamsBooks.DataAccess.Repository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;

        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(CoverType coverType)
        {
            // use .NET LINQ to retrieve the first or default category object,
            // then pass the id as a generic entity which matches the category ID
            var objFromDb = _db.CoverTypes.FirstOrDefault(s => s.Id == coverType.Id);

            if (objFromDb != null)  // Save changes if not null
            {
                objFromDb.Name = coverType.Name;
                //_db.SaveChanges();
            }

            //throw new NotImplementedException();
        }
    }
}
