using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secret_Library
{
    public partial class AdminUserControl : UserControl
    {
        public AdminUserControl()
        {
            InitializeComponent();
            AdminDataUserControl userControl = new AdminDataUserControl();
            AddUserControl (userControl);
        }

        private void AddUserControl(AdminDataUserControl userControl)
        {
            throw new NotImplementedException();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
