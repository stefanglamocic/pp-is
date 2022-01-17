﻿using JPPP.DataAccess;
using JPPP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JPPP.Forms
{
    public partial class AdminWorkerOption2 : Form
    {
        DataTable dt;
        List<Station> stations = new List<Station>();

        public AdminWorkerOption2()
        {
            InitializeComponent();
            AdminWorkerOption1.CustomizeDGV(this.dgvStations);
            FillStationsGrid();
        }

        private void FillStationsGrid() 
        {
            dt = new DataTable();
            dt.Columns.Add("ID Stanice");
            dt.Columns.Add("Opstina");
            dt.Columns.Add("Mjesto");
            dt.Rows.Clear();

            stations = StationDataAccess.GetStations();
            foreach (var s in stations) 
            {
                dt.Rows.Add(new object[] { s.StationID, s.Municipality, s.Place });
            }

            dgvStations.DataSource = dt;
        }

        private void tbSearch__TextChanged(object sender, EventArgs e)
        {
            string text = tbSearch.textBox1.Text;
            if (!text.Equals("Pretraži..."))
            {
                (dgvStations.DataSource as DataTable).DefaultView.RowFilter = "[ID Stanice] Like '" + text + "%' Or " +
                    "Opstina Like '" + text + "%' Or Mjesto Like '" + text + "%'";
            }
        }
    }
}