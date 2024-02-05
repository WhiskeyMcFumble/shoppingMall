using System.Collections.Generic;
using System.Windows.Forms;

namespace shoppingMall
{
    public interface INameable
    {
        string GetName();
    }

    public class PanelCreator : IPanelCreator
    {
        public void CreatePanels<T>(List<T> items, Panel formPanel) where T : INameable
        {
            foreach (T item in items)
            {
                Panel panelItem = new Panel();
                panelItem.Size = new System.Drawing.Size(200, 150);
                Button button = new Button();
                button.Text = item.GetName();
                button.Size = new System.Drawing.Size(100, 100);
                // Add click event handler or any other logic here
                panelItem.Controls.Add(button);
                formPanel.Controls.Add(panelItem);
            }
        }
    }
}