using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BaiTH_Tuan3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagThemLoaiHoa : ContentPage
    {
        public PagThemLoaiHoa()
        {
            InitializeComponent();
        }
        private void Cmdghi_Clicked(object sender, EventArgs e)
        {
            database db = new database();
            Loaihoa l = new Loaihoa { Tenloai = txttenloai.Text };
            if (db.InsertLoaihoa(l) == true)
            {
                DisplayAlert("Thông Báo", "Thêm loại hoa thành công", "OK");
            }
            else
                DisplayAlert("Thông Báo", "Thêm loại hoa Lỗi", "OK");

        }
    }

}