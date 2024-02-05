using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppingMall
{
    public static class FormNavigationManager
    {
        private static Form previousForm;

        public static void SetPreviousForm(Form form)
        {
            previousForm = form;
        }

        public static Form GetPreviousForm()
        {
            return previousForm;
        }

    }
}