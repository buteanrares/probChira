﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace probChira.UI
{
    public partial class ModifyEmployeeForm : Form
    {
        private Service service;
        private DataGridViewRow row;

        public ModifyEmployeeForm(Service service, DataGridViewRow row) {
            this.service = service;
            this.row = row;
            InitializeComponent();
        }
    }
}
