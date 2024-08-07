﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRMS.View;
using HRMS.Tools;

namespace HRMS.View
{
    public partial class Dashboard : Form
    {
        private Panel activityPanel;
        private HRMSLogin loginform;
        public Dashboard(/*string Username, int AccessLevel, HRMSLogin loginform*/)
        {
            //this.loginform = loginform;
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            activityPanel = mainpanel; ;  //Stores local reference to Dashboard Panel

        }

        private void Company_Click(object sender, EventArgs e)
        {

        }

        private void employeeButton_Click_1(object sender, EventArgs e)
        {
            if (!activityPanel.Controls.Contains(Directory.Register))
            {
                activityPanel.Controls.Add(Directory.Register);
                Directory.Register.Dock = DockStyle.Fill;
                Directory.Register.BringToFront();
            }
            else
            {
                Directory.Register.BringToFront();
            }
        }

        private void RuleButton_Click(object sender, EventArgs e)
        {
            if (!activityPanel.Controls.Contains(Directory.company))
            {
                activityPanel.Controls.Add(Directory.company);
                Directory.Register.Dock = DockStyle.Fill;
                Directory.Register.BringToFront();
            }
            else
            {
                Directory.company.BringToFront();
            }
        }

        private void Orgchart_Click(object sender, EventArgs e)
        {
            if (!activityPanel.Controls.Contains(Directory.orgChart))
            {
                activityPanel.Controls.Add(Directory.orgChart);
                Directory.Register.Dock = DockStyle.Fill;
                Directory.Register.BringToFront();
            }
            else
            {
                Directory.Register.BringToFront();
            }
        }

        private void Incidents_Click(object sender, EventArgs e)
        {
            if (!activityPanel.Controls.Contains(Directory.report))
            {
                activityPanel.Controls.Add(Directory.report);
                Directory.Register.Dock = DockStyle.Fill;
                Directory.Register.BringToFront();
            }
            else
            {
                Directory.report.BringToFront();
            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            loginform.Show();
            this.Close();
        }
    }
}
