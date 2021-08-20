using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace MemoryGame {
    public partial class Form2 : Form {
        Memory game = new Memory();
        GridSizeInNumber grid = new GridSizeInNumber();
        List<string> pictureAddresses = new List<string>();
        int[] shuffledNumbers;
        int click = 1;
        ClickedPanel firstClick = new ClickedPanel();
        ClickedPanel secondClick = new ClickedPanel();
        GameState state = new GameState();
        PlayerState player1 = new PlayerState(GameState.Players.player1);
        PlayerState player2 = new PlayerState(GameState.Players.player2);
        string player1Name;
        string player2Name;
        List<Panel> panelList = new List<Panel>();
        ComputerPlayerWisdom computerWisdom;


        public Form2(Memory game) {
            this.game = game;
            InitializeComponent();
            initialiseGrid();
            initialiseState();
            randomiseAddresses();
            getImages(pictureFolderPath(game.getDeckSelection()));
            if(game.getGameState() == Memory.State.vsComputer) {
                initialiseComputer();
            }
        }

        private void initialiseComputer() {
            this.computerWisdom = new ComputerPlayerWisdom(this.shuffledNumbers, game.getComputerPlayer().difficulty, panelList);
            this.computerWisdom.printInitialSkills();
        }
        private void Form2HideAll() {
            memoryGameGrid.Visible = false;
            winnerPanelMP.Visible = false;
            winnerPanelSP.Visible = false;
            currentPlayerLabel.Visible = false;
        }
        private void toggleCurrentPlayer() {
            switch ((GameState.Players)Enum.Parse(typeof(GameState.Players), state.currentPlayer.ToString())) {
                case GameState.Players.player1:
                currentPlayerLabel.Text = player2Name;
                state.currentPlayer = GameState.Players.player2;
                break;
                case GameState.Players.player2:
                currentPlayerLabel.Text = player1Name;
                state.currentPlayer = GameState.Players.player1;
                break;
            }
        }

        private void updateGuess() {
            switch ((GameState.Players)Enum.Parse(typeof(GameState.Players), state.currentPlayer.ToString())) {
                case GameState.Players.player1: {
                    this.player1.incrementGuesses();
                    break;
                }
                case GameState.Players.player2: {
                    this.player2.incrementGuesses();
                    break;
                }
            }
        }
        private void updateCorrectGuess() {
            switch ((GameState.Players)Enum.Parse(typeof(GameState.Players), state.currentPlayer.ToString())) {
                case GameState.Players.player1: {
                    this.player1.incrementCorrectGuesses();
                    break;
                }
                case GameState.Players.player2: {
                    this.player2.incrementCorrectGuesses();
                    break;
                }
            }
            this.state.ongoingCorrectGuesses += 1;
            if (this.state.ongoingCorrectGuesses == this.state.maximumCorrectGuesses) {
                endGame();
            }
        }
        private void endGame() {
            checkAndSetWinner();
            System.Diagnostics.Debug.WriteLine("Player1");
            System.Diagnostics.Debug.WriteLine(player1.getGuesses().guesses);
            System.Diagnostics.Debug.WriteLine(player1.getGuesses().correctGuesses);
            System.Diagnostics.Debug.WriteLine("Player2");
            System.Diagnostics.Debug.WriteLine(player2.getGuesses().guesses);
            System.Diagnostics.Debug.WriteLine(player2.getGuesses().correctGuesses);
        }

        private void checkAndSetWinner() {
            Player gamePlayer1 = game.getMemoryPlayer1();
            Player gamePlayer2 = game.getMemoryPlayer2();
            int player1Guesses = player1.getGuesses().correctGuesses;
            int player2Guesses = player2.getGuesses().correctGuesses;
            if (player1Guesses == player2Guesses) {
                setEndGameScreenMultiplayer(true);
                // NEEDS COMP PLAYER
                if(game.getGameState() == Memory.State.multiplayer) {
                    UpdateData(gamePlayer1, gamePlayer2, true);
                }
                return;
            }
            if (player1Guesses > player2Guesses) {
                state.winningPlayer = this.player1;
            }
            else {
                state.winningPlayer = this.player2;
            }
            switch ((Memory.State)Enum.Parse(typeof(Memory.State), game.getGameState().ToString())) {
                case (Memory.State.singleplayer): {
                    setEndGameScreenSinglePlayer();
                    break;
                }
                case (Memory.State.multiplayer): {
                    this.state.winningPlayerOrgForm = this.player1 == this.state.winningPlayer ? gamePlayer1 : gamePlayer2;
                    setEndGameScreenMultiplayer(false);
                    UpdateData(gamePlayer1, gamePlayer2, false);
                    break;
                }
                case (Memory.State.vsComputer): {
                    System.Diagnostics.Debug.WriteLine("konehan ei vielä edes toimi");
                    this.state.winningPlayerOrgForm = this.player1 == state.winningPlayer ? game.getMemoryPlayer1() : game.getComputerPlayer();
                    setEndGameScreenMultiplayer(false);
                    break;
                }
            }
        }

        private void UpdateData(Player player1, Player player2, bool draw) {
            if (draw) {
                game.updateData(player1, 1, 0, this.player1.getGuesses().guesses, this.player1.getGuesses().correctGuesses);
                game.updateData(player2, 1, 0, this.player2.getGuesses().guesses, this.player2.getGuesses().correctGuesses);
            }
            else {
                game.updateData(player1, 1, player1 == this.state.winningPlayerOrgForm ? 1 : 0, this.player1.getGuesses().guesses, this.player1.getGuesses().correctGuesses);
                game.updateData(player2, 1, player2 == this.state.winningPlayerOrgForm ? 1 : 0, this.player2.getGuesses().guesses, this.player2.getGuesses().correctGuesses);
            }
        }

        /* END GAME PANELS */
        private void setEndGameScreenSinglePlayer() {
            Form2HideAll();
            winnerPanelTextBox.Text = "Guesses : " + this.player1.getGuesses().guesses + "\r\n" + "Correct guesses : " + this.player1.getGuesses().correctGuesses;
            winnerPanelSP.Visible = true;
        }
        private void setEndGameScreenMultiplayer(Boolean draw) {
            Form2HideAll();
            player1StatsLabel.Text = game.getMemoryPlayer1().name;
            if (game.getGameState() == Memory.State.multiplayer) {
                player2StatsLabel.Text = game.getMemoryPlayer2().name;
            } else {
                player2StatsLabel.Text = game.getComputerPlayer().name;
            }
            player1StatsTextbox.Text = "Guesses : " + this.player1.getGuesses().guesses + "\r\n" + "Correct guesses : " + this.player1.getGuesses().correctGuesses;
            player2StatsTextbox.Text = "Guesses : " + this.player2.getGuesses().guesses + "\r\n" + "Correct guesses : " + this.player2.getGuesses().correctGuesses;
            if (!draw) {
                winnerTextBox.Text = this.state.winningPlayerOrgForm.name;
            }
            else {
                winnerLabel.Text = "Draw";
                winnerTextBox.Visible = false;
            }
            winnerPanelMP.Visible = true;
        }
        /* END */

        // This function returns integer array presentation of shuffled cards
        private void randomiseAddresses() {
            Random rnd = new Random();

            // Big grid 6x6 will have 18 different cards
            int[] maxCards = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
            maxCards = maxCards.OrderBy(x => rnd.Next()).ToArray();
            // Get card count according to game state
            //var gridSize = gridSizeInNumber(game.getGridSize());
            //int neededCards = gridSize.column * gridSize.row / 2;
            int neededCards = state.maximumCorrectGuesses;

            // Each cards needs duplicate
            int[] newCards = new int[neededCards * 2];
            int j = 0;

            // Save duplicates!
            for (int i = 0; i < newCards.Length; i++) {
                newCards[i] = maxCards[j];
                j++;
                if (j == neededCards)
                    j = 0;
            }

            // Randomise again
            newCards = newCards.OrderBy(x => rnd.Next()).ToArray();
            this.shuffledNumbers = newCards;
        }

        private GridSizeInNumber gridSizeInNumber(Memory.GridSize size) {
            switch ((Memory.GridSize)Enum.Parse(typeof(Memory.GridSize), size.ToString())) {
                case Memory.GridSize.small: {
                    grid.column = 4;
                    grid.row = 3;
                    return grid;
                }
                case Memory.GridSize.medium: {
                    grid.column = 5;
                    grid.row = 4;
                    return grid;
                }
                case Memory.GridSize.big: {
                    grid.column = 6;
                    grid.row = 6;
                    return grid;
                }
                default:
                return grid;
            }
        }

        private string pictureFolderPath(Memory.DeckSelection deck) {
            switch ((Memory.DeckSelection)Enum.Parse(typeof(Memory.DeckSelection), deck.ToString())) {
                case Memory.DeckSelection.cats: {
                    return "../../../Pictures/Images/Cats";
                }
                case Memory.DeckSelection.characters: {
                    return "../../../Pictures/Images/Characters";
                }
                default:
                return "";
            }
        }
        private void initialiseGrid() {
            memoryGameGrid.ColumnCount = gridSizeInNumber(game.getGridSize()).column;
            memoryGameGrid.RowCount = gridSizeInNumber(game.getGridSize()).row;
            var grids = memoryGameGrid.ColumnCount;
            var padding = 5;
            var size = this.memoryGameGrid.Size.Width;
            var boxSize = ((size / grids) - padding);
            var pictureSize = ((size / grids) - padding);

            TableLayoutColumnStyleCollection colStyles = this.memoryGameGrid.ColumnStyles;
            foreach (ColumnStyle style in colStyles) {
                style.SizeType = SizeType.Absolute;
                style.Width = boxSize;
            }
            TableLayoutRowStyleCollection rowStyles = this.memoryGameGrid.RowStyles;
            foreach (RowStyle style in rowStyles) {
                style.SizeType = SizeType.Absolute;
                style.Height = boxSize;
            }
            int k = 0;
            for (int i = 0; i < memoryGameGrid.ColumnCount; i++) {
                for (int j = 0; j < memoryGameGrid.RowCount; j++) {
                    Panel panel = new Panel {
                        Size = new Size(pictureSize, pictureSize),
                    };
                    int sum = k;
                    string rowPos = i + "," + j;
                    panel.Click += memoryGamePanelClick;
                    panel.Name = sum.ToString();
                    panel.BorderStyle = BorderStyle.Fixed3D;
                    memoryGameGrid.Controls.Add(panel, i , j);
                    panelList.Add(panel);
                    k++;
                }
            }
        }
        private void doComputerThings() {
            bool continueOrNot = false;
            memoryGameGrid.Enabled = false;
            
            do {
                this.computerWisdom.guessPictures();
                ComputerGuessResult result = this.computerWisdom.getGuess();
                System.Diagnostics.Debug.WriteLine("DO COMPUTER PANEL1 " + result.panel1Number);
                System.Diagnostics.Debug.WriteLine("DO COMPUTER PANEL2 " + result.panel2Number);
                System.Diagnostics.Debug.WriteLine("DO COMPUTER PANELRESULT " + result.correctGuess);


                panelList.ElementAt(result.panel1Number).BackgroundImage = resizeImage(Image.FromFile(pictureAddresses[shuffledNumbers[result.panel1Number]]), panelList.ElementAt(1).Size);
                wait(1000);
                updateGuess();
                panelList.ElementAt(result.panel2Number).BackgroundImage = resizeImage(Image.FromFile(pictureAddresses[shuffledNumbers[result.panel2Number]]), panelList.ElementAt(1).Size);
                wait(1000);
                updateGuess();
                System.Diagnostics.Debug.WriteLine("COMPUTER THINGS " + result.correctGuess);
                if (!result.correctGuess) {
                    panelList.ElementAt(result.panel1Number).BackgroundImage = null;
                    panelList.ElementAt(result.panel2Number).BackgroundImage = null;
                    toggleCurrentPlayer();
                    this.computerWisdom.increaseWisdomWithPanelNumber(result.panel1Number);
                    this.computerWisdom.increaseWisdomWithPanelNumber(result.panel2Number);
                    continueOrNot = false;
                    memoryGameGrid.Enabled = true;

                }
                else {
                    this.computerWisdom.removeMatchedPair(result.panel1Number, result.panel2Number);
                    updateCorrectGuess();
                    continueOrNot = true;
                }
            } while (continueOrNot && state.ongoingCorrectGuesses != state.maximumCorrectGuesses);

        }



        //foreach (int number in shuffledNumbers) {
        //    System.Diagnostics.Debug.WriteLine(number);
        //}
        //foreach (Panel panel in panelList) {
        //    panel.BackgroundImage = resizeImage(Image.FromFile(pictureAddresses[shuffledNumbers[int.Parse(panel.Name)]]), panel.Size);
        //}
        //pictureAddresses[shuffledNumbers[int.Parse(panel.Name)]]



        private void initialiseState() {
            Random rnd = new Random();
            var gridSize = gridSizeInNumber(game.getGridSize());
            int neededCards = gridSize.column * gridSize.row / 2;
            state.maximumCorrectGuesses = neededCards;
            player1Name = this.game.getMemoryPlayer1().name;

            switch ((Memory.State)Enum.Parse(typeof(Memory.State), game.getGameState().ToString())) {
                case (Memory.State.singleplayer): {
                    this.state.currentPlayer = GameState.Players.player1;
                    currentPlayerLabel.Text = game.getMemoryPlayer1().name;
                    break;
                }
                case (Memory.State.multiplayer): {
                    player2Name = this.game.getMemoryPlayer2().name;
                    state.currentPlayer = rnd.Next(1, 50) % 2 == 1 ? GameState.Players.player1 : GameState.Players.player2;
                    currentPlayerLabel.Text = this.state.currentPlayer == GameState.Players.player1 ? player1Name : player2Name;
                    break;
                }
                case (Memory.State.vsComputer): {
                    player2Name = this.game.getComputerPlayer().name;
                    //state.currentPlayer = rnd.Next(1, 50) % 2 == 1 ? GameState.Players.player1 : GameState.Players.player2;
                    // Computer has time to wait
                    state.currentPlayer = GameState.Players.player1;
                    currentPlayerLabel.Text = this.state.currentPlayer == GameState.Players.player1 ? player1Name : player2Name;
                    break;
                }
            }
        }
        private void handleFirstClick(Panel panel) {
            firstClick.clickedPanel = panel;
            firstClick.pictureNumber = int.Parse(panel.Name);
            if(game.getGameState() == Memory.State.vsComputer) {
                computerWisdom.increaseWisdomWithPanelNumber(int.Parse(panel.Name));
            }
        }
        private void handleSecondClick(Panel panel) {
            secondClick.clickedPanel = panel;
            secondClick.pictureNumber = int.Parse(panel.Name);
            if (game.getGameState() == Memory.State.vsComputer) {
                computerWisdom.increaseWisdomWithPanelNumber(int.Parse(panel.Name));
            }
        }

        private Boolean secondClickEqualsFirst(Panel panel) {
            //System.Diagnostics.Debug.WriteLine(pictureAddresses[shuffledNumbers[int.Parse(panel.Name)]]);
            //System.Diagnostics.Debug.WriteLine(pictureAddresses[shuffledNumbers[firstClick.pictureNumber]]);
            if ((pictureAddresses[shuffledNumbers[firstClick.pictureNumber]]) == pictureAddresses[shuffledNumbers[int.Parse(panel.Name)]]) {
                return true;
            }
            return false;
        }

        void memoryGamePanelClick(object sender, EventArgs e) {
            Panel panel = sender as Panel;

            if (panel.BackgroundImage != null) {
                return;
            }

            switch (this.click) {
                case 1: {
                    updateGuess();
                    panel.BackgroundImage = resizeImage(Image.FromFile(pictureAddresses[shuffledNumbers[int.Parse(panel.Name)]]), panel.Size);
                    handleFirstClick(panel);
                    this.click = 2;
                    break;
                }
                case 2: {
                    memoryGameGrid.Enabled = false;
                    panel.BackgroundImage = resizeImage(Image.FromFile(pictureAddresses[shuffledNumbers[int.Parse(panel.Name)]]), panel.Size);
                    wait(1000);
                    handleSecondClick(panel);
                    if (secondClickEqualsFirst(panel)) {
                        if (game.getGameState() == Memory.State.vsComputer) {
                            computerWisdom.removeMatchedPair(int.Parse(firstClick.clickedPanel.Name), int.Parse(secondClick.clickedPanel.Name));
                        }
                        updateCorrectGuess();
                        memoryGameGrid.Enabled = true;

                    }
                    else {
                        firstClick.clickedPanel.BackgroundImage = null;
                        firstClick.clickedPanel = null;
                        secondClick.clickedPanel.BackgroundImage = null;
                        secondClick.clickedPanel = null;
                        if (game.getGameState() != Memory.State.singleplayer) {
                            toggleCurrentPlayer();
                        }
                        memoryGameGrid.Enabled = true;
                    }
                    this.click = 1;
                    break;
                }
            }

                if (state.currentPlayer == GameState.Players.player2 && game.getGameState() == Memory.State.vsComputer) {
                        doComputerThings();
                    }

                
            
        }


        private void exitButton_Click(object sender, EventArgs e) {
            var f = new Form1();
            f.Show();
            this.Visible = false;
        }
        private Image resizeImage(Image image, Size size) {
            return (Image)(new Bitmap(image, size));
        }

        private void getImages(string path) {
            var files = Directory.GetFiles(path);
            foreach (string file in files) {
                pictureAddresses.Add(file);
            }
        }

        private void button8_Click(object sender, EventArgs e) {
            System.Diagnostics.Debug.WriteLine(player1.getGuesses().guesses);
            System.Diagnostics.Debug.WriteLine(player1.getGuesses().correctGuesses);
            System.Diagnostics.Debug.WriteLine(player2.getGuesses().guesses);
            System.Diagnostics.Debug.WriteLine(player2.getGuesses().correctGuesses);
        }
        public void wait(int milliseconds) {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) => {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled) {
                Application.DoEvents();
            }
        }
    }

    public class GridSizeInNumber {
        public int column;
        public int row;
    }

    public class ClickedPanel {
        public Panel clickedPanel;
        public int pictureNumber;
    }

    public class GameState {
        public enum Players {
            player1,
            player2
        }
        public Players currentPlayer { get; set; }
        public int ongoingCorrectGuesses { get; set; } = 0;
        public int maximumCorrectGuesses { get; set; }
        public PlayerState winningPlayer { get; set; }
        public Player winningPlayerOrgForm { get; set; }
    }

    public class PlayerState {
        GameState.Players player { get; set; }
        public PlayerState(GameState.Players player) { this.player = player; }
        Guesses guesses = new Guesses();

        public void incrementGuesses() {
            this.guesses.guesses += 1;
        }
        public void incrementCorrectGuesses() {
            this.guesses.correctGuesses += 1;
        }
        public Guesses getGuesses() {
            return guesses;
        }
    }

    public class Guesses {
        public int guesses = 0;
        public int correctGuesses = 0;
    }

    public class ComputerGuessResult {
        public int panel1Number;
        public int panel2Number;
        public bool correctGuess;
}

    public class ComputerWisdom {
        public int number { get; set; }
        public int knows { get; set; } = 0;
        public int panelNumber { get; set; }
        public ComputerWisdom(int number, int knows, int panelNumber) { 
            this.number = number; 
            this.knows = knows;
            this.panelNumber = panelNumber;
        }
    }

    public class ComputerPlayerWisdom {
        List<ComputerWisdom> knowledge = new List<ComputerWisdom>();
        ComputerPlayer.Skillset skill;
        private static readonly Func<int, int, int> GetRandomNext = GetRandomFunc();
        ComputerGuessResult guessResult = new ComputerGuessResult();

        public int getRandom(int min, int max) {
            return GetRandomNext(min, max);
        }

        public ComputerPlayerWisdom(int[] shuffledNumbers, ComputerPlayer.Skillset skill, List<Panel> list) {
            this.skill = skill;
            setInitialSkills(shuffledNumbers, list);
        }
        private static Func<int, int, int> GetRandomFunc() {
            Random random = new Random();
            object lockObject = new object();

            return (min, max) =>
            {
                lock (lockObject) {
                    return random.Next(min, max);
                }
            };
        }

        private void setInitialSkills(int[] shuffledNumbers, List<Panel> list) {
            int i = 0;
            foreach (int number in shuffledNumbers) {
                knowledge.Add(new ComputerWisdom(number, 0, int.Parse(list.ElementAt(i).Name)));
                i++;
            }
        }

        public ComputerGuessResult getGuess() {
            return this.guessResult;
        }

        public void printInitialSkills() {
            System.Diagnostics.Debug.WriteLine(this.skill);
            foreach (ComputerWisdom wisdom in knowledge) {
                System.Diagnostics.Debug.WriteLine(wisdom.knows + " " + wisdom.number + " " + wisdom.panelNumber);
            }
        }
        public void increaseWisdomWithPanelNumber(int panelNumber) {
            int boxNumber = panelNumber;
            System.Diagnostics.Debug.WriteLine("BOX NUMBER INCREASE WISDOM " + boxNumber);
            switch ((ComputerPlayer.Skillset)Enum.Parse(typeof(ComputerPlayer.Skillset), this.skill.ToString())) {
                case ComputerPlayer.Skillset.easy: {
                    this.knowledge
                           .Where(x => x.panelNumber == boxNumber)
                           .ToList()
                           .ForEach(x => { x.knows += 2; });
                    break;
                }
                case ComputerPlayer.Skillset.medium: {
                    this.knowledge
                           .Where(x => x.panelNumber == boxNumber)
                           .ToList()
                           .ForEach(x => { x.knows += 3; });
                    break;
                }
                case ComputerPlayer.Skillset.hard: {
                    this.knowledge
                           .Where(x => x.panelNumber == boxNumber)
                           .ToList()
                           .ForEach(x => { x.knows += 5; });
                    break;
                }
            }
        }

        public void removeMatchedPair(int panelName, int panel2Name) {
            this.knowledge.RemoveAll(kl => new[] { panelName, panel2Name }.Contains(kl.panelNumber) );
        }

        public void guessPictures() {
            Random rnd = new Random();
            int number = rnd.Next(0, this.knowledge.Count);
            bool firstMatch = this.getRandom(0, 10) % 2 == 1;
            int firstPanelToCompare = this.knowledge.ElementAt(number).number;
            var panels = this.knowledge.FindAll(kl => kl.number == firstPanelToCompare);
            var wrongPanels = this.knowledge.FindAll(kl => kl.number != firstPanelToCompare);
            int wrongPanelCount = this.getRandom(0, wrongPanels.Count);
            this.guessResult.panel1Number = panels.ElementAt(0).panelNumber;
            this.guessResult.panel2Number = panels.ElementAt(1).panelNumber;
            this.guessResult.correctGuess = false;


            //panels.ForEach(i => System.Diagnostics.Debug.WriteLine("Panels i know "  + i.panelNumber + " " + i.number + "  " + i.knows));
            //wrongPanels.ForEach(i => System.Diagnostics.Debug.WriteLine("Panels i dont know " + i.panelNumber + " " + i.number + "  " + i.knows));

            System.Diagnostics.Debug.WriteLine("guess element 0 " + guessPicture(panels.ElementAt(0).knows));
            System.Diagnostics.Debug.WriteLine("guess element 1 " + guessPicture(panels.ElementAt(1).knows));


            if (firstMatch) {
                this.guessResult.panel1Number = panels.ElementAt(1).panelNumber;
                if (guessPicture(panels.ElementAt(0).knows)) {
                    System.Diagnostics.Debug.WriteLine("CORECT");
                    this.guessResult.panel2Number = panels.ElementAt(0).panelNumber;
                    this.guessResult.correctGuess = true;
                }
                else {
                    this.guessResult.panel1Number = wrongPanels.ElementAt(this.getRandom(0, wrongPanels.Count)).panelNumber;
                }
            }
            else {
                this.guessResult.panel2Number = panels.ElementAt(0).panelNumber;
                if (guessPicture(panels.ElementAt(1).knows)) {
                    this.guessResult.panel2Number = panels.ElementAt(1).panelNumber;
                    System.Diagnostics.Debug.WriteLine("CORECT");
                    this.guessResult.correctGuess = true;
                }
                else {
                    this.guessResult.panel2Number = wrongPanels.ElementAt(this.getRandom(0, wrongPanels.Count)).panelNumber;
                }
            }
            System.Diagnostics.Debug.WriteLine("DID I GUESS CORRECTLY " + this.guessResult.correctGuess);
            System.Diagnostics.Debug.WriteLine("TESTING END");
        }

        private bool guessPicture(int knows) {
            //System.Diagnostics.Debug.WriteLine("GUESSPICTURE FUNC WITH PARAMETER" + knows);
            Random rnd = new Random();
            int random = rnd.Next(0, 1000);
            bool result = false;
            //System.Diagnostics.Debug.WriteLine("RANDOM NUMBER " + random);
            switch (knows) {
                case int n when (n < 4): {
                    result = (random % 4 == 0);
                    //System.Diagnostics.Debug.WriteLine("GUESSPICTURE FUNC WITH CASE 0123 RESULT " + result);
                    System.Diagnostics.Debug.WriteLine("result 1 ", result);
                    return result;
                }
                case int n when (n > 3 && n < 6): {
                    result = (random % 3 == 0);
                    System.Diagnostics.Debug.WriteLine("result 2 ", result);
                    return result;
                    
                }
                case int n when (n > 6 && n < 10): {
                    result = (random % 2 == 0);
                    System.Diagnostics.Debug.WriteLine("result 3 ", result);

                    return result;
                }
                default: {
                    System.Diagnostics.Debug.WriteLine("default");

                    return true;

                }

            }

        }

    }


}
