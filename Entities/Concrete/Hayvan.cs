using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Hayvan : IEntity
    {

        public int Id { get; set; }

        public int MusteriId { get; set; }

        public int TurId { get; set; }

        public int IrkId { get; set; }

        public string Adi { get; set; }

        public string Kurk { get; set; }

        public string OnemliHastaligi { get; set; }

        public string Aciklama { get; set; }

        public DateTime DogumTarihi { get; set; }

        public DateTime KayitTarihi { get; set; }

        public bool AktiflikDurumu { get; set; }


    }
}
