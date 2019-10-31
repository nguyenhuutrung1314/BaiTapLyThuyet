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
    public partial class PageDShoa : ContentPage
    {
        database db;
        List<Loaihoa> dsl;
        List<Hoa> h;
        public PageDShoa()
        {
            InitializeComponent();
            db = new database();
            dsl = db.selectLoaihoa();
            
            picdsloai.ItemsSource = dsl;
        }
        private void Picdsloai_SelectedIndexChanged(object sender, EventArgs e)
        {
            db = new database();
            int d;
            d = picdsloai.SelectedIndex + 1;
            lstds.ItemsSource = db.selecthoadk(d);
        }
    }
}