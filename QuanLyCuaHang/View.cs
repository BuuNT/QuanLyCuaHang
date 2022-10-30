using System;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    public partial class View : Form
    {
        private Management mngt;
        public View()
        {
            InitializeComponent();
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            //Caption color
            Dwmapi.ChangeColor(this.Handle, 35, panel_Top.BackColor);
            
            mngt = new Management();
            textBox_Id.DataBindings.Add("Text", mngt.Data, "Id", true, DataSourceUpdateMode.OnPropertyChanged);
            textBox_Name.DataBindings.Add("Text", mngt.Data, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
            textBox_Category.DataBindings.Add("Text", mngt.Data, "Category", true, DataSourceUpdateMode.OnPropertyChanged);
            textBox_Company.DataBindings.Add("Text", mngt.Data, "Company", true, DataSourceUpdateMode.OnPropertyChanged);
            textBox_MfgDate.DataBindings.Add("Text", mngt.Data, "MfgDate", true, DataSourceUpdateMode.OnPropertyChanged);
            textBox_ExpDate.DataBindings.Add("Text", mngt.Data, "ExpDate", true, DataSourceUpdateMode.OnPropertyChanged);
            textBox_CatHeader.DataBindings.Add("Text", mngt.Data, "CatHeader", true, DataSourceUpdateMode.OnPropertyChanged);
            textBox_Search.DataBindings.Add("Text", mngt.Data, "Search", true, DataSourceUpdateMode.OnPropertyChanged);
            productGridView.DataSource = mngt.Data.Products;
            comboBox_CatHeader.DataSource = mngt.Data.CatHeaders;
            LoadProducts();
        }

        private void LoadProducts()
        {
            productGridView.RowHeadersVisible = false;
            for (int i = 1; i < productGridView.ColumnCount; i++)
            {
                productGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void ShowMessage()
        {
            if (mngt.Data.Msg == Message.Empty) return;
            MessageBox.Show(mngt.Data.Msg);
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            mngt.Search();
            LoadProducts();
            ShowMessage();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            mngt.Add();
            LoadProducts();
            ShowMessage();
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            mngt.Edit();
            LoadProducts();
            ShowMessage();
        }

        private void button_Del_Click(object sender, EventArgs e)
        {
            mngt.Del();
            LoadProducts();
            ShowMessage();
        }

        private void button_Get_Click(object sender, EventArgs e)
        {
            mngt.Get();
            LoadProducts();
            ShowMessage();
        }

        private void productGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mngt.Data.RowIndex = e.RowIndex;
            mngt.FillTextBoxes();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            mngt.Data.CurrentTabPage = tabControl.SelectedIndex;
        }

        private void comboBox_CatHeader_SelectedIndexChanged(object sender, EventArgs e)
        {
            mngt.Data.CurrentCategory = comboBox_CatHeader.SelectedIndex;
        }

        private void comboBox_CatHeader_SelectedValueChanged(object sender, EventArgs e)
        {
            mngt.Data.CatHeader = comboBox_CatHeader.Text;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    btnMaximize.Image = Properties.Resources.white_maximize_32;
                    this.WindowState = FormWindowState.Normal; break;
                case FormWindowState.Normal:
                    btnMaximize.Image = Properties.Resources.white_normal_32;
                    this.WindowState = FormWindowState.Maximized; break;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel_Top_MouseDown(object sender, MouseEventArgs e)
        {
            User32.DragDrop(this.Handle);
        }
    }
}