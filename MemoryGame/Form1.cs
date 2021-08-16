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
            initialiseComputerDifficulties();
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
            gridSizes.Items.Add(Memory.Gridsize.small);
            gridSizes.Items.Add(Memory.Gridsize.medium);
            gridSizes.Items.Add(Memory.Gridsize.big);

        }
        private void initialiseComputerDifficulties() {
            computerDifficulties.Items.Add(ComputerPlayer.Skillset.easy);
            computerDifficulties.Items.Add(ComputerPlayer.Skillset.medium);
            computerDifficulties.Items.Add(ComputerPlayer.Skillset.hard);
        }
        private void setGameOptionImages() {
            logoPictureBox.Image = Image.FromFile("../../../Pictures/Game/logo.png");
            catsRadioImage.Image = Image.FromFile("../../../Pictures/Game/catRadio.png");
            dogsRadioImage.Image = Image.FromFile("../../../Pictures/Game/marioRadio.png");
        }

        //private void button1_Click(object sender, EventArgs e) {
        //    //InitialDataFolder("C:\\Temp\\", "tommi");
        //    Player player = new Player();
        //    Player player2 = new Player();


        //    game.setMemoryPlayers(player, player2);
        //    MessageBox.Show(player.name);

        //}

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
            game.setGameState(Memory.State.multiplayer);
            showPanel(vsPlayerPanel);
        }

        private void vsComputerBtn_Click(object sender, EventArgs e) {
            game.setGameState(Memory.State.vsComputer);
            showPanel(vsComputerPanel);
        }

        private void vsSingleBtn_Click(object sender, EventArgs e) {
            game.setGameState(Memory.State.singleplayer);
            showPanel(vsSinglePanel);
        }
        private void statisticsBtn_Click(object sender, EventArgs e) {
            showPanel(statisticsPanel);
        }

        private void helpBtn_Click(object sender, EventArgs e) {
            showPanel(helpPanel);
        }

        /* FUNCTIONS FOR MAKING MAIN PANEL VISIBLE END */

        private void statisticsPanel_Paint(object sender, PaintEventArgs e) {

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
            var deck = (Memory.DeckSelection)Enum.Parse(typeof(Memory.DeckSelection), catsRadio.Text.ToString());
            game.setDeckSelection(deck);
        }

        private void dogsRadio_CheckedChanged(object sender, EventArgs e) {
            var deck = (Memory.DeckSelection)Enum.Parse(typeof(Memory.DeckSelection), dogsRadio.Text.ToString());
            game.setDeckSelection(deck);
        }

        private void gridSizes_SelectedIndexChanged(object sender, EventArgs e) {
            var size = (Memory.Gridsize)Enum.Parse(typeof(Memory.Gridsize), gridSizes.SelectedItem.ToString());
            game.setGridsize(size);
        }



        /* SINGLE PLAYER PANEL  */

        private void newUserRadioBtn1_CheckedChanged(object sender, EventArgs e) {
            toggleTwoPanels(newUserPanel1, existingUserPanel1);
        }

        private void existingUserRadioBtn1_CheckedChanged(object sender, EventArgs e) {
            toggleTwoPanels(existingUserPanel1, newUserPanel1);
        }

        private void newUserPanel1_Paint(object sender, PaintEventArgs e) {

        }
        private void newUser1Name_TextChanged(object sender, EventArgs e) {

        }
        private void newUser1Btn_Click(object sender, EventArgs e) {
            Player player1 = new Player();
            player1.SetPlayerInfo(newUser1Name.Text, 0, 0, 0, 0);
            game.setMemoryPlayer1(player1);
        }
        private void existingUserPanel1_Paint(object sender, PaintEventArgs e) {

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
            Player player2 = new Player();
            player2.SetPlayerInfo(newUser2Name.Text, 0, 0, 0, 0);
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

        private void startBtn_Click(object sender, EventArgs e) {
            MessageBox.Show("Ei toimi vielä :'(");
            var f = new Form2(game);
            f.Owner = this;
            f.Show();
            this.Visible = false;
        }

        private void computerDifficulties_SelectedIndexChanged(object sender, EventArgs e) {
            var skill = (ComputerPlayer.Skillset)Enum.Parse(typeof(ComputerPlayer.Skillset), computerDifficulties.SelectedItem.ToString());
            ComputerPlayer player = new ComputerPlayer(skill);
            game.setComputerPlayer(player);
        }


    }
}
