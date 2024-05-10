using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiCafe.DAO;
using QuanLiCafe.DTO;

namespace QuanLiCafe
{
    public partial class fTableManager : Form
    {
        public fTableManager()
        {
            InitializeComponent();
            LoadTable();
        }

        #region Method
        void LoadTable()
        {
            List<Table> tableList = TableDAO.Instance.LoadTableList();
            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;

                switch(item.Status)
                    {   
                      case "Trống":
                        btn.BackColor = Color.PowderBlue;
                        break;
                     default:
                        btn.BackColor = Color.Crimson;
                        break;
                    }
                    flpTable.Controls.Add(btn);
            }
        }
        #endregion
    }
}