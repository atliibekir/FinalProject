using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
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
        public static string  AuthorizationDenied="Yetkiniz Yok";
        internal static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        internal static string UserNotFound = "Kullanıcı bulunamadı";
        internal static string PasswordError = "Parola hatası";
        internal static string SuccessfulLogin = "Giriş başarılı";
        internal static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        internal static string AccessTokenCreated = "Token oluşturuldu";
    }
}
