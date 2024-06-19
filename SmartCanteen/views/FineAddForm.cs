using SmartCanteen.controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCanteen.views
{
    public partial class FineAddForm : Form
    {
        private readonly FineController fineController = new FineController();
        public FineAddForm()
        {
            InitializeComponent();
        }

        private void btnFineLeave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFineRegister_Click(object sender, EventArgs e)
        {
            if(!ValidateValues())
            {
                return;
            }

            int horas = (int)nmrHours.Value;
            double value = (double)nmrFine.Value;

            try
            {
                fineController.AddFine(horas, value);
                MessageBox.Show("Multa adicionada com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool ValidateValues()
        {
            if ((int)nmrHours.Value < 0)
            {
                MessageBox.Show("Por favor, introduza as horas.");
                return false;
            }

            if ((double)nmrFine.Value < 0)
            {
                MessageBox.Show("Por favor, introduza um preço válido.");
                return false;
            }

            return true;
        }
    }
}
