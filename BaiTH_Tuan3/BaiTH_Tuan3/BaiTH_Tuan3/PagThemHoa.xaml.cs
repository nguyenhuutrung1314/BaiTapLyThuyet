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
    public partial class PagThemHoa : ContentPage
    {
        database db;
        List<Loaihoa> dsl;
        public PagThemHoa()
        {

            InitializeComponent();
            db = new database();
            dsl = db.selectLoaihoa();
            picdsloai.ItemsSource = dsl;
        }
        private void Cmdthem_Clicked(object sender, EventArgs e)
        {
            database db = new database();
            Hoa l = new Hoa { 
                Mahoa = picdsloai.SelectedIndex + 1,
                Tenhoa = txttenhoa.Text,
                Hinh = txthinh.Text,
                Mota = txtmota.Text,
                Gia = double.Parse(txtgia.Text)
            };
            if (db.InsertHoa(l) == true)
            {
                DisplayAlert("Thông Báo", "Thêm hoa thành công", "OK");
            }
            else
                DisplayAlert("Thông Báo", "Thêm hoa Lỗi", "OK");

        }
        private void Cmdxoa_Clicked(object sender, EventArgs e)
        {
            database db = new database();
            Hoa l = new Hoa
            {
                Mahoa = picdsloai.SelectedIndex,
                Tenhoa = txttenhoa.Text,
                Hinh = txthinh.Text,
                Mota = txtmota.Text,
                Gia = double.Parse(txtgia.Text)
            };
            if (db.DeleteHoa(l) == true)
            {
                DisplayAlert("Thông Báo", "Xoa hoa thành công", "OK");
            }
            else
                DisplayAlert("Thông Báo", "Xóa hoa Lỗi", "OK");

        }
        private void Picdsloai_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}