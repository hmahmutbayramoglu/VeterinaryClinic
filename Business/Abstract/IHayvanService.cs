using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IHayvanService
    {

        List<Hayvan> GetAll();

        Hayvan GetByİd(int id);

        List<Hayvan> GetByCustomerİd(int id);

        void Add(Hayvan hayvan);

        void Delete(Hayvan hayvan);

        void Update(Hayvan hayvan);

    }
}
