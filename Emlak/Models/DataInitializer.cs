using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace Emlak.Models
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var sehir = new List<Sehir>()
            {
                new Sehir() {SehirAd="İSTANBUL"},
                new Sehir() {SehirAd="ANKARA"},
                new Sehir() {SehirAd="İZMİR"}
            };
            foreach (var item in sehir)
            {
                context.Sehirs.Add(item);
            }
            context.SaveChanges();
            var semt = new List<Semt>()
            {

                new Semt() {SemtAd="KAĞITHANE",SehirId=1},
                new Semt() {SemtAd="KEÇİÖREN",SehirId=2},
                new Semt() {SemtAd="BORNOVA",SehirId=3},

            };
            foreach (var item in semt)
            {
                context.Semts.Add(item);
            }
            context.SaveChanges();

            var mahalle = new List<Mahalle>()
            {
                new Mahalle() {MahalleAd="ÇAĞLAYAN",SemtId=1},
                new Mahalle() {MahalleAd="İZZETPAŞA",SemtId=2},
                new Mahalle() {MahalleAd="TALATPAŞA",SemtId=1},
            };

            foreach (var item in mahalle )
            {
                context.Mahalles.Add(item);
            }
            context.SaveChanges();

            var durum = new List<Durum>()
            {
                new Durum() {DurumAd="KİRALIK"},
                new Durum() {DurumAd="SATILIK"}
            };

            foreach (var item in durum)
            {
                context.Durums.Add(item);
            }
            context.SaveChanges();


            var tip = new List<Tip>()
            {
                new Tip() {TipAd="EV", TipId=1},
                new Tip() {TipAd="DÜKKAN",TipId=1},
                new Tip() {TipAd="EV", TipId=2},
                new Tip() {TipAd="DÜKKAN",TipId=2},
            };

            foreach(var item in tip)
            {
                context.Tips.Add(item);

            }
            context.SaveChanges();

            var ilan = new List<Ilan>()
            {
                new Ilan() {Aciklama ="Ev Güzel",Adres="Murat Sok",OdaSayisi=5,BanyoSayisi=2,Kredi=true,Fiyat=2000,MahalleId=1,Alan=120,SemtId=1,SehirId=1,DurumId=1,TipId=1,Telefon="2122121212",Kat="2.kat",Userbame="Alican"},
                new Ilan() {Aciklama ="Ev Güzel 2",Adres="Nato Sok",OdaSayisi=4,BanyoSayisi=1,Kredi=true,Fiyat=3000,MahalleId=2,Alan=150,SemtId=1,SehirId=3,DurumId=2,TipId=4,Telefon="212223212",Kat="2.kat",Userbame="Alican"},

            };
            foreach(var item in ilan)
            {
                context.Ilans.Add(item);
            }
            context.SaveChanges();

            var resim = new List<Resim>()
            {
            
                new Resim() { ResimAd="x5_907568749h5m.jpg",IlanId=1},
                new Resim() { ResimAd="2.jpg",IlanId=1},
                new Resim() { ResimAd="3.jpg",IlanId=2},

    
            };
            foreach (var item in resim)
            {
                context.Resims.Add(item);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}