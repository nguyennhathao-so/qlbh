using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bài_quản_lí_đơn_hàng
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void LogIn_Load(object sender, EventArgs e)
        {
            // Thiết lập ban đầu với 10 dấu cách
            userControl11.Texts = new string(' ', 6);
            userControl12.Texts = new string(' ', 6);
        }
 

        private void userControl11_Load(object sender, EventArgs e)
        {
            
        }
        
    }
}