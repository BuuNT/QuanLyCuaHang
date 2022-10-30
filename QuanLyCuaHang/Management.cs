using System;
using System.Collections.Generic;
namespace QuanLyCuaHang
{
    internal class Management
    {
        private List<Product> products;
        private List<String> catHeaders;
        private List<List<Product>> categories;
        public DataBinding Data { get; set; }

        public Management()
        {
            products = new List<Product>();
            categories = new List<List<Product>>();
            catHeaders = new List<String>();
            Data = new DataBinding();
            Data.Products.DataSource = products;
            Data.CatHeaders.DataSource = catHeaders;
            ExampleProduct();
        }

        private void UpdateData(List<Product> source)
        {
            Data.Products.DataSource = null;
            Data.Products.DataSource = source;
            Data.CatHeaders.ResetBindings(true);
        }

        internal void ExampleProduct()
        {
            Product example = new Product
            {
                Id = 0,
                Name = "Example Product",
                Category = "Example",
                Company = "Example Company",
                MfgDate = DateTime.Today,
                ExpDate = DateTime.Today.AddYears(1)
            };
            products.Add(example);
            UpdateData(products);
        }

        internal void Search()
        {
            Data.Msg = Message.Empty;
            int id; var result = new List<Product>();
            
            ValidString(Data.Search);
            if (Data.Msg != Message.Empty) goto ret;
            
            ValidInteger(Data.Search, out id);
            if (Data.Msg == Message.Empty)
            {
                result.AddRange(FindByID(id));
                goto ret;
            }
            Data.Msg = Message.Empty;
            result.AddRange(FindByCategory(Data.Search));
            
        ret:
            if (result.Count == 0)
            {
                Data.Msg = Message.ProductNotFound;
            }
            UpdateData(result); 
        }

        internal void Add()
        {
            Data.Msg = Message.Empty;
            switch (Data.CurrentTabPage)
            {
                case 0:
                    AddProduct(); break;
                case 1:
                    AddCategory(); break;
            }
        }

        internal void Edit()
        {
            Data.Msg = Message.Empty;
            switch (Data.CurrentTabPage)
            {
                case 0:
                    EditProduct(); break;
                case 1:
                    EditCategory(); break;
            }
        }

        internal void Del()
        {
            Data.Msg = Message.Empty;
            switch (Data.CurrentTabPage)
            {
                case 0:
                    DelProduct(); break;
                case 1:
                    DelCategory(); break;
            }
        }

        internal void Get()
        {
            Data.Msg = Message.Empty;
            UpdateData(products);
        }

        private void AddProduct()
        {
            int id; DateTime mfgDate, expDate;
            ValidProductID(out id, out mfgDate, out expDate);
            if (Data.Msg != Message.Empty) return;
            products.Add(new Product
            {
                Id = id,
                Name = Data.Name,
                Category = Data.Category,
                Company = Data.Company,
                MfgDate = mfgDate,
                ExpDate = expDate
            });
            UpdateData(products);
        }

        private void EditProduct()
        {
            int id; DateTime mfgDate, expDate;
            ValidIndex(Data.RowIndex);
            if (Data.Msg != Message.Empty) return;
            ValidProductID(out id, out mfgDate, out expDate);
            if (id == products[Data.RowIndex].Id && Data.Msg == Message.IdDoesExist)
            {
                Data.Msg = Message.Empty;
            }
            if (Data.Msg != Message.Empty) return;
            
            products[Data.RowIndex] = new Product
            {
                Id = id,
                Name = Data.Name,
                Category = Data.Category,
                Company = Data.Company,
                MfgDate = mfgDate,
                ExpDate = expDate
            };
            UpdateData(products);
        }

        private void DelProduct()
        {
            ValidIndex(Data.RowIndex);
            if (Data.Msg != Message.Empty) return;
            products.RemoveAt(Data.RowIndex);
            Data.RowIndex -= 1;
            UpdateData(products);
        }


        private void AddCategory()
        {
            List<Product> result = new List<Product>();
            ValidString(Data.CatHeader);
            if (Data.Msg != Message.Empty) goto ret;
            if (catHeaders.Contains(Data.CatHeader))
            {
                Data.Msg = Message.CatDoesExist;
                goto ret;
            }
            result = FindByCategory(Data.CatHeader);
            if(result.Count == 0)
            {
                Data.Msg = Message.DoesNotExist;
                goto ret;
            }
            categories.Add(result);
            catHeaders.Add(Data.CatHeader);
        ret:
            UpdateData(result);
        }

        private void EditCategory()
        {
            List<Product> result = new List<Product>();
            ValidString(Data.CatHeader);
            if (Data.Msg != Message.Empty) goto ret;
            ValidIndex(Data.CurrentCategory);
            if (Data.Msg != Message.Empty) goto ret;

            catHeaders[Data.CurrentCategory] = Data.CatHeader;
            result = categories[Data.CurrentCategory];
            foreach(var r in result)
            {
                r.Category = Data.CatHeader;
            }

            var idx = catHeaders.IndexOf(Data.CatHeader);
            if (idx != -1)
            {
                catHeaders.RemoveAt(Data.CurrentCategory);
                categories.RemoveAt(Data.CurrentCategory);
                categories[idx].AddRange(result);
                result = categories[idx];
            }

        ret:
            UpdateData(result);
        }

        private void DelCategory()
        {
            List<Product> result = new List<Product>();
            ValidIndex(Data.CurrentCategory);
            if (Data.Msg != Message.Empty) goto ret;
            catHeaders.RemoveAt(Data.CurrentCategory);
            categories.RemoveAt(Data.CurrentCategory);
            Data.CurrentCategory -= 1;
            if (Data.CurrentCategory >= 0)
            {
                result = categories[Data.CurrentCategory];
            }
        ret:
            UpdateData(result);
        }

        //---------------------------------------------------------
        private void ValidDateTime(string v, out DateTime dt)
        {
            Data.Msg = Message.Empty;
            if (!DateTime.TryParse(v, out dt))
            {
                Data.Msg = Message.DateTimeOnly;
            }
        }

        private void ValidInteger(string v, out int id)
        {
            Data.Msg = Message.Empty;
            if (!int.TryParse(v, out id))
            {
                Data.Msg = Message.IntegerOnly;
            }
        }
        internal void ValidIndex(int idx)
        {
            Data.Msg = Message.Empty;
            if (!IsValidIndex(idx))
            {
                Data.Msg = Message.InValidIndex;
            }

        }

        internal void ValidString(string v)
        {
            Data.Msg = Message.Empty;
            if (IsEmptyStr(v))
            {
                Data.Msg = Message.InValidValue;
            }
        }

        private void ValidProductID(out int id, out DateTime mfgDate, out DateTime expDate)
        {
            Data.Msg = Message.Empty;
            mfgDate = DateTime.Today;
            expDate = DateTime.Today;
            
            ValidInteger(Data.Id, out id);
            if (Data.Msg != Message.Empty) return;

            ValidDateTime(Data.MfgDate, out mfgDate);
            if (Data.Msg != Message.Empty) return;

            ValidDateTime(Data.ExpDate, out expDate);
            if (Data.Msg != Message.Empty) return;

            if (!IsValidProductID(id))
            {
                Data.Msg = Message.IdDoesExist; return;
            }

        }

        private bool IsValidIndex(int idx)
        {
            return idx != -1;
        }

        private bool IsValidProductID(int id)
        {
            foreach (var product in products)
            {
                if (product.Id == id) return false;
            }
            return true;
        }

        internal bool IsEmptyStr(string v)
        {
            return v == String.Empty;
        }
        //---------------------------------------------------------------

        internal List<Product> FindByCategory(string text)
        {
            List<Product> result = new List<Product>();
            foreach (var product in products)
            {
                if (product.Category == text)
                {
                    result.Add(product);
                }
            }
            return result;
        }

        internal List<Product> FindByID(int id)
        {
            List<Product> result = new List<Product>();
            foreach (var product in products)
            {
                if (product.Id == id)
                {
                    result.Add(product);
                    break;
                };
            }
            return result;
        }

        internal void FillTextBoxes()
        {
            if (IsValidIndex(Data.RowIndex))
            {
                Product data = (Product)Data.Products[Data.RowIndex];
                switch (Data.CurrentTabPage)
                {
                    case 0:
                        Data.Id = data.Id.ToString();
                        Data.Name = data.Name;
                        Data.Category = data.Category;
                        Data.Company = data.Company;
                        Data.MfgDate = data.MfgDate.ToShortDateString();
                        Data.ExpDate = data.ExpDate.ToShortDateString();
                        break;
                    case 1:
                        Data.CatHeader = data.Category;
                        break;
                }
            }
        }
    }
}