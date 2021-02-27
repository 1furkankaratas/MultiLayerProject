using Entities.Concrete;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Core.Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün Adı Geçersiz";

        public static string MaintenanceTime = "Bakım yapılıyor";
        public static string ProductListed = "Ürünler Listelendi";
        public static string ProductCountCategoryError = "Eklemek istediğiniz kategoriye daha fazla ürün eklenemez";

        public static string ProductNameAlreadyExists =
            "Bu isimde başka bir ürün var lütfen farklı bir isimde ürün ekleyiniz.";

        public static string CheckIfCategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklemiyor";

        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered = "Kayıt başarılı";
        public static string UserNotFound = "Kayıt başarılı";
        public static string SuccessfulLogin = "Giriş Başarılı";
        public static string PasswordError = "Parola Hatası";
        public static string UserAlreadyExists = "Bu kullanıcı zaten var";
        public static string AccessTokenCreated = "Token Oluşturuldu";
    }
}