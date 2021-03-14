using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    //static newlememek icin
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi"; //public oldugu için pascal case, private olsa camel case
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda.";
        public static string ProductListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists = "Böyle bir ürün ismi var.";
        public static string CategoryLimitExceded = "Kategori limitine ulaşıldı.";
    }
}
