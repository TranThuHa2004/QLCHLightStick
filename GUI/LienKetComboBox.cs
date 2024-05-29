using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using System.Data.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Guna.UI2.WinForms;

namespace GUI
{
    public  class LienKetComboBox 
    {
        public void LienKet2DuLieu(DataTable dataTable, string displayMember, string valueMember, Guna2ComboBox comboBox)
        {
            BindingSource bindingSource = new BindingSource();//liên kết dữ liệu giữa các nguồn dữ liệu và các điều khiển trên giao diện người dùng.
            bindingSource.DataSource = dataTable;
            comboBox.DisplayMember = displayMember;//tên cột hiển thị
            comboBox.ValueMember = valueMember;//tên gtri tương ứng
            comboBox.DataSource = bindingSource;//liên kết combobox với bindingSource, để combobox hiển thị dữ liệu từ dataTable
        }
        public void LienKet1DuLieu(DataTable dataTable, string displayMember, Guna2ComboBox comboBox)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            comboBox.DisplayMember = displayMember;
            comboBox.DataSource = bindingSource;
        }
    }
}
