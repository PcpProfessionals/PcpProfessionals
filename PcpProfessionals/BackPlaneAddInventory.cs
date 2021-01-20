using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;

namespace PcpProfessionals
{
    public partial class BackPlaneAddInventory : Form
    {
        private string _componentLabelText;

        public BackPlaneAddInventory(string componentLabelName)
        {
            InitializeComponent();
            _componentLabelText = componentLabelName;
        }

        private void backPlaneBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.backPlaneBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pcpProfessionalDataSet);
        }

        private void BackPlaneAddInventory_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            // TODO: This line of code loads data into the 'pcpProfessionalDataSet.BackPlane' table. You can move, or remove it, as needed.
            this.backPlaneTableAdapter.Fill(this.pcpProfessionalDataSet.BackPlane);
            this.ComponentNameLbl.Text = _componentLabelText;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            var addInventory = new AddInventory();

            FormManager.GotoForm(this, addInventory);
        }

        private void MaximizeWindow()
        {
            var rectangle = Screen.FromControl(this).Bounds;
            this.FormBorderStyle = FormBorderStyle.None;
            Size = new Size(rectangle.Width, rectangle.Height);
            Location = new Point(0, 0);
            var workingRectangle = Screen.PrimaryScreen.WorkingArea;
            this.Size = new Size(workingRectangle.Width, workingRectangle.Height);
        }

        private void ResizableWindow()
        {
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
        }

        private void ComponentNameLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
