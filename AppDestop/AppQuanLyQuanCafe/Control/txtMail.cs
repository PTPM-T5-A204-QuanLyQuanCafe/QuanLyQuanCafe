using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control
{
    public class txtMail:TextBox
    {
        ErrorProvider errorProvider1 = new ErrorProvider();
        public txtMail()
        {
            this.TextChanged += txtMail_TextChanged;
        }

        void txtMail_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);

            if (!regex.IsMatch(this.Text))
            {
                errorProvider1.SetError(this, "Vui lòng nhập địa chỉ email hợp lệ.");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
