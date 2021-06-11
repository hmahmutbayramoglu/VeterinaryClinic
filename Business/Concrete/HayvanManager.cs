using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class HayvanManager : IHayvanService
    {

        private IHayvanDal _hayvanDal;

        public HayvanManager(IHayvanDal hayvanDal)
        {
            _hayvanDal = hayvanDal;
        }


        public void Add(Hayvan hayvan)
        {
            //iş kodları 
            //Örnek iş kodu 

            //if (_hayvanDal.Get(p => p.Adi == hayvan.Adi) == null)
            //{
            //    _hayvanDal.Add(hayvan);
            //}
            //else
            //{
            //    throw new Exception ("Bu isimde zaten kayıtlı hayvan var");
            //}
            _hayvanDal.Add(hayvan);
        }

        public void Delete(Hayvan hayvan)
        {
            _hayvanDal.Delete(hayvan);
        }

        public List<Hayvan> GetAll()
        {
            return _hayvanDal.GetList().ToList();
        }

        public List<Hayvan> GetByCustomerİd(int id)
        {
            return _hayvanDal.GetList(p => p.Musteriİd == id).ToList();
        }

        public Hayvan GetByİd(int id)
        {
            return _hayvanDal.Get(p => p.İd == id);
        }

        public void Update(Hayvan hayvan)
        {
            _hayvanDal.Update(hayvan);
        }
    }
}
