using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfa_Vega
{
    /// <summary>
    /// Ekran üzerinde seçilen değişkenlerin tutulduğu class.
    /// Ayarlar ekranında kullanılıyor.
    /// Resim ve RFID seçenekleri ilerleyen dönemlerde eklenebilir.
    /// </summary>
    public static class Selected
    {
        /// <summary>
        /// Selected NAMEID
        /// </summary>
        public static int NameID = 1;
        /// <summary>
        /// SELECTED TYPEID
        /// </summary>
        public static int TypeID = 0;
        /// <summary>
        /// SELECTED OWNER ID
        /// </summary>
        public static int OwnerID = 0;

        /// <summary>
        /// GetAll() metodunun hangi amaçla çağırıldığını tutan enum.
        /// </summary>
        public enum Mode
        {
            Type,
            Name,
            Owner
        }
        
        /// <summary>
        /// cbName üzerinde listelencek olan Birimlerin isimleri.
        /// </summary>
        public static List<string> NameName = new List<string>();
        /// <summary>
        /// NameName değişkenlerinin bulunduğu satırların ID'leri.
        /// </summary>
        public static List<int> NameInt = new List<int>();

        /// <summary>
        /// cbType üzerinde listelenecek olan birimlerin isimleri.
        /// </summary>
        public static List<string> TypeName = new List<string>();
        /// <summary>
        /// TypeName değişkenlerinin bulunduğu satırların ID'leri.
        /// </summary>
        public static List<int> TypeInt = new List<int>();

        /// <summary>
        /// cbOwner üzerinde listelenecek olan birimlerin isimleri.
        /// </summary>
        public static List<string> OwnerName = new List<string>();
        /// <summary>
        /// OwnerName değişkenlerinin buludğu satırların ID'leri.
        /// </summary>
        public static List<int> OwnerInt = new List<int>();

          
      
    }
}
