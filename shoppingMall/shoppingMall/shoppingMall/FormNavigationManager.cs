using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppingMall
{
    public class FormNavigationManager
    {
        private static Form previousForm;

        public static void SetPreviousForm(Form form)
        {
            previousForm = form;
        }

        public static void NavigateBack()
        {
            if (previousForm != null)
            {
                previousForm.Show();
                previousForm = null; 
            }
        }
    }



}