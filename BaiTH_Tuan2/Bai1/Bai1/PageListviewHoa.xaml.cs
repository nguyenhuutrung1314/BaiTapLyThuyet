using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bai1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    
    public partial class PageListviewHoa : ContentPage
    {
        ObservableCollection<hoa> Hoas = new ObservableCollection<hoa>();
        public PageListviewHoa()
        {
            InitializeComponent();
            Hoas.Add(new hoa { TenHoa = "Đón xuân", Gia = 50000, Hinh = "cuc1.png", MoTa = "Hoa cúc các màu trắng, vàng, cam" });
            Hoas.Add(new hoa { TenHoa = "Hồn nhiên", Gia = 60000, Hinh = "cuc2.png", MoTa = "Hoa cúc vàng, cam, lá măng" });
            Hoas.Add(new hoa { TenHoa = "Tím thủy chung", Gia = 45000, Hinh = "cuc3.png", MoTa = "Hoa cúc tím" });
            lsvHoa.ItemsSource = Hoas;
        }
    }
}