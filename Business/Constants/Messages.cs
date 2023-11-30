using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        
        public static string ProductNameInvalıd = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
       
        public static string ProductCountOfCatgeoryError = "Bir kategoride maximum 10 ürün olmalı";

        public static string Updated = "Updated";
        public static string Added = "Added";
        public static string Deleted = "Deleted";
        public static string Listed = "Listelendi";

        public static string ProductNameAlreadyExists = "Ürün ismi mevcut";

        public static string CategoryLimitExceded = "Kategori limiti aşıldı yeni ürün eklenemez.";
    }
}
