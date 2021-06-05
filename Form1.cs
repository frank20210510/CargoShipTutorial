using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargoShipTutorial
{
    public partial class Form1 : Form
    { 
        Ship ship = new Ship();
    
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ship = new Ship();
            updateUI();
        }
        private void updateUI()
        {
            progressBar1.Maximum = ship.Capacity;

            if(ship.getShipLoad() <= ship.Capacity)
               progressBar1.Value = ship.getShipLoad();
            label_shipLabel.Text = ship.ToString();

        }
    }
}
