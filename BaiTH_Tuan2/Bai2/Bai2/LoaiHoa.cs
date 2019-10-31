using System;
using System.Collections.Generic;
using System.Text;

namespace Bai2
{
    public class LoaiHoa : List<hoa>
    {
        public string TenLoai { get; set; }
        private LoaiHoa(string tenloai)
        {
            TenLoai = tenloai;
        }
        public IList<LoaiHoa> Loaihoas { get; set; }
        public LoaiHoa()
        {
            List<LoaiHoa> l = new List<LoaiHoa>
            {
                new LoaiHoa("Hoa cúc")
                {
                    new hoa { TenHoa = "Đón xuân", Gia = 50000, Hinh = "cuc1.png", MoTa = "Hoa cúc các màu trắng, vàng, cam" } ,
            new hoa { TenHoa = "Hồn nhiên", Gia = 60000, Hinh = "cuc2.png", MoTa = "Hoa cúc vàng, cam, lá măng" } ,
            new hoa { TenHoa = "Tím thủy chung", Gia = 45000, Hinh = "cuc3.png", MoTa = "Hoa cúc tím" }},

                new LoaiHoa("Hoa cưới")
                {
                    new hoa { TenHoa = "dây tơ hồng", Gia = 250000, Hinh = "cuoi1.png", MoTa = "Hoa hồng màu hồng đậm, hoa hồng xanh, các loại lá măng" } ,
            new hoa { TenHoa = "Cầu thủy tinh", Gia = 220000, Hinh = "cuoi2.png", MoTa = "Hoa hồng và hoa thủy tiên trắng" } ,
            new hoa { TenHoa = "Duyên thầm", Gia = 260000, Hinh = "cuoi3.png", MoTa = "Hoa cúc trắng, baby, lá măng" }}
            };
            Loaihoas = l;
        }
    }
}
