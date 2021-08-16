using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MemoryGame
{
    public partial class Form1 : Form {
        Memory game = new Memory();



        public Form1(Memory game) {
            this.game = game;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            initialiseGridSizes();
            initialiComputerDifficulties();
            setGameOptionImages();
            openHomePage();
            //var nice = new StartingScreen();
            //nice.Show();
            //this.Visible = false;
        }

        /* HELPER FUNCTIONS */

        private void openHomePage() {
            hideAllMainPanels();
            homePanel.Visible = true;

        }
        
        private void toggleTwoPanels(Panel toVisible, Panel toHide) {
            toHide.Hide();
            toVisible.Visible = true;
        }

        private void initialiseGridSizes() {
            gridSizes.Items.Insert(0, "4x4");
            gridSizes.Items.Insert(1, "8x8");
        }
        private void initialiComputerDifficulties() {
            computerDifficulties.Items.Insert(0, "easy");
            computerDifficulties.Items.Insert(1, "medium");
            computerDifficulties.Items.Insert(2, "hard");
        }
        private void setGameOptionImages() {
            logoPictureBox.Image = Image.FromFile("../../../Pictures/Game/logo.png");
            catsRadioImage.Image = Image.FromFile("../../../Pictures/Game/catRadio.png");
            dogsRadioImage.Image = Image.FromFile("../../../Pictures/Game/marioRadio.png");
        }

        private void button1_Click(object sender, EventArgs e) {
            //InitialDataFolder("C:\\Temp\\", "tommi");
            Player player = new Player();
            Player player2 = new Player();


            game.setMemoryPlayers(player, player2);
            MessageBox.Show(player.name);

        }

        private void button2_Click(object sender, EventArgs e) {
            //var f = new Form3();
            //f.Owner = this;
            //f.Show();
            //this.Visible = false;
            MessageBox.Show("ok");


        }

        public void hideAllMainPanels() { 
            vsPlayerPanel.Hide();
            vsComputerPanel.Hide();
            statisticsPanel.Hide();
            vsSinglePanel.Hide();
            helpPanel.Hide();
            gameOptionPanel.Hide();
            homePanel.Hide();
        }

        public void showGameOptionPanel() {
            gameOptionPanel.Visible = true;
        }
        public void showPlayer1Panel() {
            vsSinglePanel.Visible = true;
        }


        public void showPanel(Panel showPanel) {
            hideAllMainPanels();
            showPanel.Visible = true;
            if (new[] { vsPlayerPanel, vsComputerPanel, vsSinglePanel }.Contains(showPanel)) {
                showPlayer1Panel();
                showGameOptionPanel();
            }
        }

        public void showPanelsNoHide(Panel[] panels) {
            hideAllMainPanels();
            foreach (Panel panel in panels) {
                panel.Visible = true;
            }
        }

        /* HELPER FUNCTIONS END */


        /* FUNCTIONS FOR EACH MAIN PANEL TO GET VISIBLE */
        private void vsPlayerBtn_Click(object sender, EventArgs e) {
            showPanel(vsPlayerPanel);
        }

        private void vsComputerBtn_Click(object sender, EventArgs e) {
            showPanel(vsComputerPanel);
        }

        private void vsSingleBtn_Click(object sender, EventArgs e) {
            showPanel(vsSinglePanel);
        }
        private void statisticsBtn_Click(object sender, EventArgs e) {
            showPanel(statisticsPanel);
        }

        private void helpBtn_Click(object sender, EventArgs e) {
            showPanel(helpPanel);
        }

        /* FUNCTIONS FOR MAKING MAIN PANEL VISIBLE END */

        private void vsSinglePanel_Paint(object sender, PaintEventArgs e) {

        }

        private void vsPlayerPanel_Paint(object sender, PaintEventArgs e) {

        }

        private void vsComputerPanel_Paint(object sender, PaintEventArgs e) {


        }

        private void singlePlayerName_TextChanged(object sender, EventArgs e) {

        }

        private void statisticsPanel_Paint(object sender, PaintEventArgs e) {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e) {

        }

        private void helpPanel_Paint(object sender, PaintEventArgs e) {

        }

        private void gameOptionPanel_Paint(object sender, PaintEventArgs e) {

        }

        private void catsRadioImage_Click(object sender, EventArgs e) {
            catsRadio.Checked = true;
        }

        private void dogsRadioImage_Click(object sender, EventArgs e) {
            dogsRadio.Checked = true;
        }

        private void catsRadio_CheckedChanged(object sender, EventArgs e) {
        }

        private void dogsRadio_CheckedChanged(object sender, EventArgs e) {

        }

        private void gridSizes_SelectedIndexChanged(object sender, EventArgs e) {
            var value = gridSizes.SelectedValue;

        }



        /* 
        ** SINGLE PLAYER PANEL 
        * This panel is visible for vsSingle, vsPlayer and vsComputer
        */

        private void newUserPanel1_Paint(object sender, PaintEventArgs e) {

        }
        private void existingUserPanel1_Paint(object sender, PaintEventArgs e) {

        }
        private void newUserRadioBtn1_CheckedChanged(object sender, EventArgs e) {
            toggleTwoPanels(newUserPanel1, existingUserPanel1);
        }

        private void existingUserRadioBtn1_CheckedChanged(object sender, EventArgs e) {
            toggleTwoPanels(existingUserPanel1, newUserPanel1);
        }



        private void existingUserComboBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void existingUserBtn1_Click(object sender, EventArgs e) {

        }

        /* SINGLE PLAYER PANEL END */

        /* PLAYER2 PANEL */

        private void newUserPanel2_Paint(object sender, PaintEventArgs e) {

        }

        private void newUser2Name_TextChanged(object sender, EventArgs e) {

        }

        private void newUserBtn2_Click(object sender, EventArgs e) {
        }

        private void existingUserComboBox2_SelectedIndexChanged(object sender, EventArgs e) {

        }



        private void newUserRadioBtn2_CheckedChanged(object sender, EventArgs e) {
            toggleTwoPanels(newUserPanel2, existingUserPanel2);

        }

        private void existingUserRadioBtn2_CheckedChanged(object sender, EventArgs e) {
            toggleTwoPanels(existingUserPanel2, newUserPanel2);

        }



        /* PLAYER2 PANEL END */




        private void logoPictureBox_Click(object sender, EventArgs e) {
            openHomePage();
        }

        private void homePanel_Paint(object sender, PaintEventArgs e) {

        }

        private void startBtn_Click(object sender, EventArgs e) {
            MessageBox.Show("Ei toimi vielä :'(");
        }

        private void computerDifficulties_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void newUser1Label_Click(object sender, EventArgs e) {

        }
    }
}
