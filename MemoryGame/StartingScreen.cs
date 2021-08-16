using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MemoryGame {
    public partial class StartingScreen : Form {
        public StartingScreen() {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e) {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
            tabPage1.Hide();
            tabPage1.Show();

        }

        private void tabPage2_Click(object sender, EventArgs e) {

        }

        private void StartingScreen_Load(object sender, EventArgs e) {
            try {
                pictureBox1.Image = Image.FromFile("../../../Pictures/Game/logo.png");
            }  catch {
                pictureBox1.BackColor = Color.Black;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }
    }
}
