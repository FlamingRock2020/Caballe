﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caballe_03LabExercise1
{
    public partial class frmConfirmation : Form
    {
        public frmConfirmation()
        {
            InitializeComponent();
        }

        private void lblStudentNo_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
        }



        private void frmConfirmation_Load(object sender, EventArgs e)
        {
            lblStudentNo.Text = StudentInformationClass.SetStudentNo.ToString(); 
            lblName.Text = StudentInformationClass.SetFullName; 
            lblProgram.Text = StudentInformationClass.SetProgram; 
            lblBirthday.Text = StudentInformationClass.SetBirthday; 
            lblGender.Text = StudentInformationClass.SetGender; 
            lblContactNo.Text = StudentInformationClass.SetContactNo.ToString(); 
            lblAge.Text = StudentInformationClass.SetAge.ToString();
        }
    }
}
