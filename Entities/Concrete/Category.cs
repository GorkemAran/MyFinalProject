using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //-çıplak class kalmasın- yani class hh1 inheritance ya da interface implement almıyorsa ilerde sıkıntı yaşarsın
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
