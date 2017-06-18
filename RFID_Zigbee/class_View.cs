using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFID_Zigbee
{
    class class_view
    {
        public void Initialize(TableLayoutPanel customer_information)
        {
            customer_information.ColumnStyles.Clear();
            customer_information.RowStyles.Clear();

            customer_information.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            customer_information.AutoScroll = true;

            customer_information.ColumnCount = 3;
            for (int i = 0; i < 2; i++)
            {
                Label label = new Label();
                label.Text = "Label_" + i;
                label.AutoSize = true;
                label.Anchor = ((AnchorStyles)((AnchorStyles.Left | AnchorStyles.Right)));
                customer_information.Controls.Add(label);

                TextBox txtobj = new TextBox();
                txtobj.Text = "TextBox_" + i;
                txtobj.Width = 70;
                customer_information.Controls.Add(txtobj);
            }

                customer_information.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        }
    }
}