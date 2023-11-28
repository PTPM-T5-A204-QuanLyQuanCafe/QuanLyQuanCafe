using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control
{
    public class txtPassword:TextBox
    {
         ErrorProvider errorProvider1 = new ErrorProvider();
         public txtPassword()
        {
            this.TextChanged += txtPassword_TextChanged;
        }

         void txtPassword_TextChanged(object sender, EventArgs e)
         {
             if (this.Text.Length < 6)
             {
                 errorProvider1.SetError(this, "Vui long nhap it nhat 6 ki tu!");
             }
             else
                 errorProvider1.Clear();
         }
    }
}
