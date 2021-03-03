using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    //Implemente etmek icin db tablosu mu diye bakarız. Joinli vs oldugu için cevap hayır 
    //o yüzden IEntity veremeyiz
    public class ProductDetailDto:IDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public short UnitsInStock { get; set; }

    }
}
