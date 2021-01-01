using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilities
{
    public static class FormManager
    {


        public static void OpenForm(Form currentForm, Form nextForm)
        {
            currentForm.Hide();

            nextForm.ShowDialog();

            currentForm.Close();
        }
    }
}
