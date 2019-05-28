using System;
using System.Collections.Generic;
using System.Data.Entity;//
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indimaret.Model
{
    //inheritence
    public class Initializer: DropCreateDatabaseAlways<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            List<Barang> barang = new List<Barang>();
            barang.Add(new Barang { TokoID = 1, KodeBarang = "KB001", NamaBarang = "Panadol", AsalPabrik = "Bogor", JmlBarang = 30, LamaKadaluarsa = 10 });
            barang.Add(new Barang { TokoID = 2, KodeBarang = "KB002", NamaBarang = "Decolgen", AsalPabrik = "Bandung", JmlBarang = 30, LamaKadaluarsa = 10 });
            barang.Add(new Barang { TokoID = 3, KodeBarang = "KB003", NamaBarang = "Promag", AsalPabrik = "Jakarta", JmlBarang = 30, LamaKadaluarsa = 10 });
            barang.Add(new Barang { TokoID = 4, KodeBarang = "KB004", NamaBarang = "Actifed", AsalPabrik = "Yogya", JmlBarang = 30, LamaKadaluarsa = 10 });

            base.Seed(context);

            foreach (var item in barang)
            {
                context.Barang.Add(item);
                 
                
            }
        }
    }
}
