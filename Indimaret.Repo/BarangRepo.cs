using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Indimaret.Model;

namespace Indimaret.Repo
{
    public class BarangRepo
    {
        public static List<Barang> GetAll()
        {
            List<Barang> result = new List<Barang>();
            using(DataContext db = new DataContext())
            {
                result = db.Barang.ToList();
            }
            return result;
        }

        public static Boolean Createbarang(Barang barang)
        {
            try
            {
                using (DataContext db = new DataContext())
                {
                    db.Barang.Add(barang);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                
                return false;
            }
        }

        //tanpa static menjadi non static
        public static Boolean Deletebarang(int ID)
        {
            try
            {
                Barang dep;
                using (DataContext db = new DataContext())
                {
                    dep = db.Barang.Where(d => d.ID == ID).First();
                    db.Entry(dep).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public static Barang GetByID(int ID)
        {
            Barang barang = new Barang();
            using (DataContext db = new DataContext())
            {
                barang = db.Barang.Where(d => d.ID == ID).First();
                return barang;
            }
        }

        public static Boolean Editbarang(Barang barang)
        {
            try
            {
                using (DataContext db = new DataContext())
                {
                    db.Entry(barang).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
