using BL.Services;
using BL.Services.Interfaces;
using DAL.DatabaseObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcpProfessionals
{
    public partial class AddInventory : Form
    {
        private IComponentService _componentService;

        public AddInventory()
        {
            _componentService = new ComponentService();
            InitializeComponent();
            LoadDataSources();
        }

        private void LoadDataSources()
        {
            var componentList = _componentService.GetAllComponents();
            ComponentListCb.DataSource = componentList;
        }

        private void AddInventory_Load(object sender, EventArgs e)
        {

        }

        private void ComponentListCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedComponent = ComponentListCb.SelectedValue.ToString();

            var controllsForComponent = _componentService.GetControllsForComponent(selectedComponent);

            AddControlsToSplitContainerPanel(splitContainer1.Panel2, controllsForComponent);

            splitContainer1.Panel2.Show();
        }

        private void AddControlsToSplitContainerPanel(SplitterPanel panel2, List<TableDetailDto> controlls)
        {
            panel2.Controls.Clear();

            var initialLabelLocation = new Point(50, 50);
            var initialInputLocation = new Point(80, 50);
            controlls.ForEach(x =>
            {
                if (x.COLUMN_NAME != "Id")
                {
                    Ge
                    GenerateLabel(x.COLUMN_NAME, panel2, initialLabelLocation);
                    initialLabelLocation.Y += 30;
                    initialInputLocation.Y += 30;
                }
            });
        }

        private void GenerateLabel(string columnName, SplitterPanel panelView, Point location)
        {
            var controlLabel = new Label();

            controlLabel.Text = columnName;
            controlLabel.Location = location;

            panelView.Controls.Add(controlLabel);
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
