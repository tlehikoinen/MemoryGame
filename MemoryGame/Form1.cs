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

        public Form1() {
            //this.game = game;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            Memory game = new Memory();
            this.game = game;
            initialiseGridSizes();
            initialiseComputerDifficulties();
            setGameOptionImages();
            openHomePage();
            setStatistics();
            setExistingPlayers();
        }

    /* HELPER FUNCTIONS */

        private Boolean nameAlreadyExists(string name) {
            var data = game.getExistingPlayerNames();
            foreach (string existingName in data) {
                if (existingName == name)
                    return true;
            }
            return false;
        }
        private void openHomePage() {
            hideAllMainPanels();
            homePanel.Visible = true;
        }
        private void toggleTwoPanels(Panel toVisible, Panel toHide) {
            toHide.Hide();
            toVisible.Visible = true;
        }
        private void initialiseGridSizes() {
            foreach (Memory.GridSize size in Memory.GridSize.GetValues(typeof(Memory.GridSize))) {
                gridSizes.Items.Add(size);
            }
            gridSizes.SelectedIndex = 1;
        }
        private void initialiseComputerDifficulties() {
            foreach (ComputerPlayer.Skillset skill in ComputerPlayer.Skillset.GetValues(typeof(ComputerPlayer.Skillset))) {
                computerDifficulties.Items.Add(skill);
            }
        }
        private void setGameOptionImages() {
            logoPictureBox.Image = Image.FromFile("../../../Pictures/Game/logo.png");
            catsRadioImage.Image = Image.FromFile("../../../Pictures/Game/catRadio.png");
            dogsRadioImage.Image = Image.FromFile("../../../Pictures/Game/marioRadio.png");
            errorPicture.Image = Image.FromFile("../../../Pictures/Game/error.png");
        }

        private void setExistingPlayers() {
            var data = game.getExistingPlayerNames();
            foreach (string item in data) {
                existingUserComboBox1.Items.Add(item);
                existingUserComboBox2.Items.Add(item);
            }
        }
        
        private void setStatistics() {
            var data = game.getData();
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Name";
            dataGridView1.Columns[1].Name = "Games";
            dataGridView1.Columns[2].Name = "GamesWon";
            dataGridView1.Columns[3].Name = "Guesses";
            dataGridView1.Columns[4].Name = "CorrectGuesses";

            foreach (string[] item in data) {
                dataGridView1.Rows.Add(item);
            }


        }

        // New user forms have button or error visible depending on textbox content
        private void newUserTextBoxStateHandler(TextBox textBox, Button button, Label error) {
            if (String.IsNullOrEmpty(textBox.Text)) {
                button.Enabled = false;
                return;
            }
            else {
                button.Enabled = true;
            }

            if (nameAlreadyExists(textBox.Text)) {
                button.Visible = false;
                error.Visible = true;
            }
            else {
                button.Visible = true;
                error.Visible = false;
            }
        }

        public void hideAllMainPanels() { 
            vsPlayerPanel.Hide();
            vsComputerPanel.Hide();
            statisticsPanel.Hide();
            vsSinglePanel.Hide();
            helpPanel.Hide();
            gameOptionPanel.Hide();
            homePanel.Hide();
            errorPanel.Hide();
        }

        public void showGameOptionPanel() {
            gameOptionPanel.Visible = true;
        }
        public void showPlayer1Panel() {
            vsSinglePanel.Visible = true;
        }

        // Opens panel sent as parameter, in case of vsComputer and vsPlayer, vsSingle and gameoption panels are also kept open
        public void showPanel(Panel showPanel) {
            hideAllMainPanels();
            showPanel.Visible = true;
            if (new[] { vsPlayerPanel, vsComputerPanel, vsSinglePanel }.Contains(showPanel)) {
                showPlayer1Panel();
                showGameOptionPanel();
            }
        }

        // Delete if no use -- probably works though
        public void showPanelsNoHide(Panel[] panels) {
            hideAllMainPanels();
            foreach (Panel panel in panels) {
                panel.Visible = true;
            }
        }

    /* HELPER FUNCTIONS END */


    /* FUNCTIONS FOR EACH MAIN PANEL TO GET VISIBLE */
        /* Also updates game state between single, multi and vsComp */
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
            var size = (Memory.GridSize)Enum.Parse(typeof(Memory.GridSize), gridSizes.SelectedItem.ToString());
            game.setGridSize(size);
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
            newUserTextBoxStateHandler(newUser1Name, newUser1Btn, newUserExistsError1);
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
            string name = existingUserComboBox1.Text;
            game.setExistingMemoryPlayer(name, 1);

        }

        /* SINGLE PLAYER PANEL END */

        /* PLAYER2 PANEL */

        private void newUserPanel2_Paint(object sender, PaintEventArgs e) {

        }

        private void newUser2Name_TextChanged(object sender, EventArgs e) {
            newUserTextBoxStateHandler(newUser2Name, newUserBtn2, newUserExistsError2);
        }

        private void newUserBtn2_Click(object sender, EventArgs e) {
            Player player2 = new Player();
            player2.SetPlayerInfo(newUser2Name.Text, 0, 0, 0, 0);
            game.setMemoryPlayer2(player2);
        }

        private void existingUserComboBox2_SelectedIndexChanged(object sender, EventArgs e) {

        }
        private void existingUserBtn2_Click(object sender, EventArgs e) {
            string name = existingUserComboBox2.Text;
            game.setExistingMemoryPlayer(name, 2);
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
            
            System.Diagnostics.Debug.WriteLine(readyToPlay());

            if (readyToPlay()) { 
            var f = new Form2(game);
            f.Owner = this;
            f.Show();
            this.Visible = false;
            } else {
                errorPanel.Visible = true;
            }
        }

        private void startBtn_MouseHover(object sender, EventArgs e) {
        }

        private void computerDifficulties_SelectedIndexChanged(object sender, EventArgs e) {
            var skill = (ComputerPlayer.Skillset)Enum.Parse(typeof(ComputerPlayer.Skillset), computerDifficulties.SelectedItem.ToString());
            ComputerPlayer player = new ComputerPlayer(skill);
            game.setComputerPlayer(player);
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e) {

        }


        //Keeps track of fields which are required for each state and enables play button if requirements are satisfied
        private Boolean readyToPlay() {
            Player player = game.getMemoryPlayer1();
            Memory.GridSize size = game.getGridSize();
            Memory.DeckSelection deck = game.getDeckSelection();
            Memory.State state = game.getGameState();

            if (player == null) {
                errorTextBox.Text = "Error with player1";
                return false;
            }

            // Check if deck is selected or not, gridsize have default value, and computer player is constructed using skillset, so not checking for those
            if (deck == Memory.DeckSelection.none) {
                errorTextBox.Text = "Choose deck";
                return false;
            } 


            switch (game.getGameState()) {
                case Memory.State.singleplayer: { 
                    return true;
                }
                case Memory.State.multiplayer: { 
                    Player player2 = game.getMemoryPlayer2();
                    if (player2 == null) {
                        errorTextBox.Text = "Error with player2";
                        return false;
                    }
                    return true;
                }
                case Memory.State.vsComputer:
                    Player compPlayer = game.getComputerPlayer();
                    if (compPlayer == null) { 
                        errorTextBox.Text = "Select computer difficulty";
                        return false;
                    }   
                    return true;

                default:
                    return false;

            }
        }

    }
}
