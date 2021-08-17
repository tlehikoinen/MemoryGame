using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace MemoryGame {

    public class Memory {

        Player player1;
        Player player2;
        ComputerPlayer player3;
        State gameState = State.none;
        DeckSelection deckSelection = DeckSelection.none;
        GridSize gridSize = GridSize.small;

        public Memory() {
            InitialiseFolder();
        }

        public static void InitialiseFolder() {
            string path = Environment.ExpandEnvironmentVariables("%TEMP%");
            Directory.CreateDirectory(path);
            Boolean file = File.Exists(path + "\\memorygame.txt");
            try {
                File.Create(path + "\\memorygame.txt");
            }
            catch {
                System.Diagnostics.Debug.WriteLine("Already exist");
            }
            System.Diagnostics.Debug.WriteLine(file);

        }

        public enum State {
            none,
            singleplayer,
            multiplayer,
            vsComputer
        }

        public enum DeckSelection {
            none,
            cats,
            characters
        }

        public enum GridSize {
            small,
            medium,
            big
        }

        public void setGameState(State state) {
            this.gameState = state;
        }
        public State getGameState() {
            return this.gameState;
        }

        public void setDeckSelection(DeckSelection deck) {
            this.deckSelection = deck;
        }
        public DeckSelection getDeckSelection() {
            return this.deckSelection;
        }
        public void setGridSize(GridSize size) { 
            this.gridSize = size;
        }
        public GridSize getGridSize() {
            return this.gridSize;
        }

        public void setMemoryPlayer1(Player player) {
            this.player1 = player;
        }

        public void setMemoryPlayer2(Player player) {
            this.player2 = player;
        }
        
        public void setComputerPlayer(ComputerPlayer player) {
            this.player3 = player;
        }

        public Player getMemoryPlayer1() {
            return this.player1;
        }
        public Player getMemoryPlayer2() {
            return this.player2;
        }
        public ComputerPlayer getComputerPlayer() {
            return this.player3;
        }
    }
    public class Player {
        public string name { get; set; }
        public int gamesPlayed { get; set; }
        public int gamesWon { get; set; }
        public int guesses { get; set; }
        public int correctGuesses { get; set; }

        public Player() {
        }

        public void SetPlayerInfo(string name, int gamesPlayed, int gamesWon, int guesses, int correctGuesses) {
            this.name = name;
            this.gamesPlayed = gamesPlayed;
            this.gamesWon = gamesWon;
            this.guesses = guesses;
            this.correctGuesses = correctGuesses;
        }

    }

    public class ComputerPlayer : Player {

        string[] adjectives = { "Furious", "Soft", "Unaccountable", "Zany", "Moldy", "Mountainous", "Flakyubiquitous", "Utter" };
        string[] names = { "Horn", "Copper", "Acoustics", "Servant", "Company", "Lumber", "Crime", "Station", "Story", "Bushes", "Government", "Back" };

        public string formName() {
            string name = "";
            var random = new Random();
            name += adjectives[random.Next(0, adjectives.Length-1)];
            name += names[random.Next(0, names.Length-1)];
            return name;
        }

        public enum Skillset {
            easy,
            medium,
            hard
        }

        public Skillset difficulty;

        public ComputerPlayer(Skillset skillset) {
            this.difficulty = skillset;
            this.name = formName();
        }

        public string getComputerPlayerInfo() {
            return this.name;
        }

        public Skillset getComputerSkillset() {
            return this.difficulty;
        }


    }

}
