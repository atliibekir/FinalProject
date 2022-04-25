using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz!";
        public static string MaintenanceTime = "Sistem bakımda!";
        public static string ProductListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Kategori ürün ekleme kapasitesi aşıldı.";
        public static string ProductNameAllreadyExists = "Bu isimde zaten başka bir ürün var.";
        public static string CategoryLimitExceded = "Kategori sayısı aşıldığı için yeni ürün eklenemez.";
    }
}
