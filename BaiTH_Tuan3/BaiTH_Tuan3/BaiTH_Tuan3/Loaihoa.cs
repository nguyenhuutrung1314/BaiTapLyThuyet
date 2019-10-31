using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTH_Tuan3
{
    public class Loaihoa
    {
        [PrimaryKey, AutoIncrement]
        public int Maloai { get; set; }
        public string Tenloai { get; set; }
    }
}
