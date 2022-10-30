using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Company { get; set; }
        public DateTime MfgDate { get; set; }
        public DateTime ExpDate { get; set; }
    }

    internal class DataBinding : INotifyPropertyChanged
    {
        //Fields
        private string _id;
        private string _name;
        private string _category;
        private string _company;
        private string _mfgDate;
        private string _expDate;
        private string _catHeader;
        private string _search;
        public BindingSource Products { get; set; }
        public BindingSource CatHeaders { get; set; }
        public int CurrentTabPage { get; set; }
        public int CurrentCategory { get; set; }
        public string Msg { get; internal set; }
        public event PropertyChangedEventHandler PropertyChanged;

        //Constructor
        public DataBinding() 
        {
            Products = new BindingSource();
            CatHeaders = new BindingSource();
        }

        //Methods
        public string Id
        {
            get { return _id; }
            set
            {
                if (_id == value) return;
                _id = value;
                OnPropertyChanged("Id");
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (_name == value) return;
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        public string Category
        {
            get { return _category; }
            set
            {
                if (_category == value) return;
                _category = value;
                OnPropertyChanged("Category");
            }
        }

        public string Company
        {
            get { return _company; }
            set
            {
                if (_company == value) return;
                _company = value;
                OnPropertyChanged("Company");
            }
        }

        public string MfgDate
        {
            get { return _mfgDate; }
            set
            {
                if (_mfgDate == value) return;
                _mfgDate = value;
                OnPropertyChanged("MfgDate");
            }
        }

        public string ExpDate
        {
            get { return _expDate; }
            set
            {
                if (_expDate == value) return;
                _expDate = value;
                OnPropertyChanged("ExpDate");
            }
        }

        public string CatHeader
        {
            get { return _catHeader; }
            set
            {
                if (_catHeader == value) return;
                _catHeader = value;
                OnPropertyChanged("CatHeader");
            }
        }

        public string Search
        {
            get { return _search; }
            set
            {
                if (_search == value) return;
                _search = value;
                OnPropertyChanged("Search");
            }
        }

        public int RowIndex { get; internal set; }

        private void OnPropertyChanged(string v)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(v));
            }
        }

    }

    internal class Message
    {
        public static string Empty = String.Empty;
        public static string InValidIndex = "Index không hợp lệ";
        public static string InValidValue = "Giá trị không hợp lệ";
        public static string IntegerOnly = "Mã sản phẩm phải là số nguyên";
        public static string ProductNotFound = "Không tìm thấy sản phẩm";
        public static string DoesNotExist = "Chưa có dữ liệu, vui lòng thêm sản phẩm";
        public static string IdDoesExist = "Mã sản phẩm đã tồn tại, vui lòng nhập mã mới";
        public static string CatDoesExist = "Danh sách sản phẩm đã tồn tại, vui lòng nhập mới hoặc chỉnh sửa";
        public static string DateTimeOnly = "Ngày sản xuất và hạn sử dụng phải đúng định dạng\nEx: 01/01/2023";
    }
}