using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string Added = "Başarıyla Eklendi.";
        public static string Deleted = "Başarıyla Silindi.";
        public static string Updated = "Başarıyla Güncellendi.";
        public static string Error = "Hata!";
        public static string Listed = "Listelendi.";

        /* Validation mesajları FluentValidation üzerine aktarıldı.
         * 
        public static string PriceInvalid = "Fiyat 10'dan küçük olamaz.";
        public static string IdInvalid = "ID 0 olamaz.";
        public static string NameInvalid = "Kurs ismi en az 5 karakter olmalı.";
        */



    }
}
