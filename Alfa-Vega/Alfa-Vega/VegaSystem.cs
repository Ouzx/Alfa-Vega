using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Alfa_Vega
{
    
    class VegaSystem : DB
    {

        /// <summary>
        /// Veri tabanına veri ekler
        /// </summary>
        public void Add(string _table, params object[] _data)
        {
            try
            {
                StringBuilder cmd = new StringBuilder();
                cmd.AppendFormat("INSERT INTO {0} VALUES({1}, ", _table, GetLastID(_table) + 1);
                for (int i = 0; i < _data.Length; i++)
                {
                    cmd.Append(_data[i].ToString() + ",");
                }
                cmd.Remove(cmd.Length - 1, 1);
                cmd.Append(")");
                //MessageBox.Show(cmd.ToString());
                Write(cmd.ToString());
                MessageBox.Show("Ekleme işlemi başarlı!", "Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurun ve İnternete Bağlı Olduğunuzdan emin olun! " + ex.ToString(),
                                                    "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Veri tabanından veri çeker
        /// </summary>
        public List<string> Get(string _table, int _ID)
        {
            try
            {
                return Read(_table, _ID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurun ve İnternete Bağlı Olduğunuzdan emin olun! " + ex.ToString(),
                                                    "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /// <summary>
        /// Veri tabanındaki bir veriyi düzenler
        /// </summary>
        public void Set(string _table, int _id, params object[] _data)
        {
            try
            {
                Edit(_table, _id, _data);
                MessageBox.Show("Düzenleme işlemi başarlı!", "Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurun ve İnternete Bağlı Olduğunuzdan emin olun! " + ex.ToString(),
                                                    "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Veri tabanındaki bir veriyi siler
        /// </summary>
        public void Delete(string _table, int _id)
        {
            try
            {
                Remove(_table, _id);
                MessageBox.Show("Silme işlemi başarlı!", "Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurun ve İnternete Bağlı Olduğunuzdan emin olun! " + ex.ToString(),
                                                    "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Veri tabanından istenilen sütunun verilerini çeker.
        /// </summary>
        public void GetParams(string _table, Selected.Mode mode)
        {
            try
            {
                GetAll(_table, mode);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurun ve İnternete Bağlı Olduğunuzdan emin olun! " + ex.ToString(),
                                                    "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void GetVegas()
        {
            try
            {
                GetVEGA();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurun ve İnternete Bağlı Olduğunuzdan emin olun! " + ex.ToString(),
                                                    "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Ana menüye veritabnından çektiği bilgilere göre veri aktarır.
        /// </summary>
        public void GetMenu()
        {
            try
            {
                GetMenus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen İnternete Bağlı Olduğunuzdan emin olun! " + ex.ToString(),
                                                    "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ClearMenu()
        {
            ClearMenus();
        }
        
    }

    
}
