using Entities.Concrete;
using System.Collections.Generic;

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
    }
}