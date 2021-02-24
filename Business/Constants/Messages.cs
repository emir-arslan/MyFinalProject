using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    //new lememek için static verdik
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime = "Sistem bakımdadır.";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Bir kategorideki en fazla olabilecek ürün limiti aşıldı.";
        public static string ProductNameAlreadyExists = "Eklemeye çalışılan ürün ismi sistemde mevcuttur.";
        public static string CategoryLimitExceded ="Kategori limiti aşıldığı için yeni ürün eklenemiyor.";
    }
}
