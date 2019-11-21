using Baitaptuan4.Helpers;
using Baitaptuan4.Interface;
using Baitaptuan4.Models;
using Baitaptuan4.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Baitaptuan4.Repository
{
    public class LoaihoaRepository : ILoaihoaRepository
    {
        Database db;
        public LoaihoaRepository()
        {
            db = new Database();
        }
        public bool Delete(Loaihoa h)
        {
            return db.DeleteLoaihoa(h);
        }
        public Loaihoa GetLoaihoaById(int Maloai)
        {
            return db.GetLoaihoaByid(Maloai);
        }
        

        public ObservableCollection<Loaihoa> GetLoaihoas()
        {
            return new ObservableCollection<Loaihoa>( db.GetLoaihoas());
        }

        public bool Insert(Loaihoa h)
        {
            return db.InsertLoaihoa(h);
        }
        public bool Update(Loaihoa h)
        {
            return db.UpdateLoaihoa(h);
        }

        
    }
}
