using Conssecionaria.DATA.Interfaces;
using Conssecionaria.DATA.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conssecionaria.DATA.Repositories
{
    public class RepositoryBase<T> : IRepositoryModel<T>, IDisposable where T : class
    {
        protected ConcessionariaContext _Context;
        public bool _SaveChanges = true;

        public RepositoryBase(bool saveChanges = true)
        {
            _SaveChanges = saveChanges;
            _Context = new ConcessionariaContext();
        }

        public T Creat(T objeto)
        {
            _Context.Set<T>().Add(objeto);

            if (_SaveChanges)
            {
                _Context.SaveChanges();
            }

            return objeto;
        }

        public void Delete(T objeto)
        {
            _Context.Set<T>().Remove(objeto);

            if (_SaveChanges)
            {
                _Context.SaveChanges();
            }
        }

        public void Delete(params object[] variavel)
        {
            var obj = SelectPk(variavel);
            Delete(obj);
        }

        public void Dispose()
        {
            _Context.Dispose();
        }

        public T Edit(T objeto)
        {
            _Context.Entry(objeto).State = EntityState.Modified;

            if (_SaveChanges)
            {
                _Context.SaveChanges();
            }

            return objeto;
        }

        public void SaveChages()
        {
            _Context.SaveChanges();
        }

        public List<T> SelectAll()
        {
            return _Context.Set<T>().ToList();
        }

        public T SelectPk(params object[] variavel)
        {
            return _Context.Set<T>().Find(variavel);
        }
    }
}
