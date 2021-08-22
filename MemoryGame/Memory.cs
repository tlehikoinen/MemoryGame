using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using CsvHelper;

namespace MemoryGame {
    public class Memory {
        private static string path = Environment.ExpandEnvironmentVariables("%TEMP%");
        private static string fileName = "memorygamedata.txt";
        FileHandler handler = new FileHandler(path, fileName);
        Player player1;
        Player player2;
        ComputerPlayer player3;
        List<String> existingPlayerNames;
        List<String[]> playerData;
        State gameState = State.none;
        DeckSelection deckSelection = DeckSelection.none;
        GridSize gridSize = GridSize.small;

        public Memory() {
            InitialiseFolder();
        }

        public void InitialiseFolder() {
            string path = Memory.path;
            string fileName = Memory.fileName;
            string pathToFile = Path.Combine(path, fileName);
            string header1 = "Name, GamesPlayed, GamesWon, Guesses, CorrectGuesses";

            Directory.CreateDirectory(path);

            if (!File.Exists(pathToFile)) {
                try {
                    var file = File.Create(pathToFile);
                    file.Close();
                    handler.addRow(header1);
                    System.Diagnostics.Debug.WriteLine("Created a file");
                }
                catch {
                    System.Diagnostics.Debug.WriteLine("Some error");
                }
            }
            setData();
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
            this.handler.addRow(this.player1.recordForm());
        }

        public void setExistingMemoryPlayer(string name, int boxNumber) {
            Player player = new Player();
            foreach(string[] item in playerData) {
                if (item[0] == name) {
                    player.SetPlayerInfo(item[0], int.Parse(item[1]), int.Parse(item[2]), int.Parse(item[3]), int.Parse(item[4]));
                    break;
                }
            }
            switch (boxNumber) {
                case 1: {
                    setMemoryPlayer1(player);
                    break;
                }
                case 2: {
                    setMemoryPlayer2(player);
                    break;
                }
            }
        }
        public void setMemoryPlayer2(Player player) {
            this.player2 = player;
            this.handler.addRow(this.player2.recordForm());
        }

        public void setComputerPlayer(ComputerPlayer player) {
            bool alreadyExist = false;
            foreach(string[] item in playerData) {
                if (item[0] == player.name) {
                    player.SetPlayerInfo(item[0], int.Parse(item[1]), int.Parse(item[2]), int.Parse(item[3]), int.Parse(item[4]));

                    this.player3 = player;
                    this.handler.addRow(this.player3.recordForm());
                }
            }
            if (!alreadyExist) {
                this.player3 = player;
                this.handler.addRow(this.player3.recordForm());
            }
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
        public string getPath() {
            return Memory.path;
        }
        public string getFile() {
            return Memory.fileName;
        }
        public List<String[]> getData() {
            return this.playerData;
        }
        public List<String> getExistingPlayerNames() {
            return this.existingPlayerNames;
        }
        public void setData() {
            this.playerData = handler.parseData();
            this.existingPlayerNames = handler.parseNames();
        }
        public void updateData(Player player, int gamesPlayed, int gamesWon, int guesses, int correctGuesses) {
            player.UpdatePlayerInfo(gamesPlayed, gamesWon, guesses, correctGuesses);
            var data = player.recordForm();
            handler.updateRow(data);
        }
        public void updateDataSingleplayer(Player player, int guesses, int correctGuesses) {
            System.Diagnostics.Debug.WriteLine("Single player data is not yet saved / updated " + player.name + " " +  guesses + " " + correctGuesses);
        }
        public void updateComputerplayerData(ComputerPlayer player, int gamesPlayed, int gamesWon, int guesses, int correctGuesses) {
            this.player3.UpdatePlayerInfo(gamesPlayed, gamesWon, guesses, correctGuesses);
            var data = player.recordForm();
            handler.updateRow(data);
        }
        public void somethingNames() {
            handler.parseData();
        }

    }
    public class Player {
        public string name { get; set; }
        public int gamesPlayed { get; set; } = 0;
        public int gamesWon { get; set; } = 0;
        public int guesses { get; set; } = 0;
        public int correctGuesses { get; set; } = 0;

        public Player() {
        }

        public void SetPlayerInfo(string name, int gamesPlayed, int gamesWon, int guesses, int correctGuesses) {
            this.name = name;
            this.gamesPlayed = gamesPlayed;
            this.gamesWon = gamesWon;
            this.guesses = guesses;
            this.correctGuesses = correctGuesses;
        }
        public void UpdatePlayerInfo(int gamesPlayed, int gamesWon, int guesses, int correctGuesses) {
            this.gamesPlayed += gamesPlayed;
            this.gamesWon += gamesWon;
            this.guesses += guesses;
            this.correctGuesses += correctGuesses;
        }

        public string recordForm() {
            return this.name + ',' + this.gamesPlayed + ',' + this.gamesWon + ',' + this.guesses + ',' + this.correctGuesses;
            //return playerData;
        }
    }

    public class ComputerPlayer : Player {

        private string[] adjectives = { "Furious", "Notorious", "Big" };
        private string[] names = { "Horn", "Boombox", "Kitty" };

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
            this.gamesPlayed = 0;
            this.gamesWon = 0;
            this.guesses = 0;
            this.correctGuesses = 0;
        }

        public string getComputerPlayerInfo() {
            return this.name;
        }

        public Skillset getComputerSkillset() {
            return this.difficulty;
        }
    }

    public class FileHandler {
        string csvPath;
        public string data { get; set; }
        public FileHandler(string path, string file) {
            this.csvPath = Path.Combine(path, file);
        }

        public string getData() {
            string read = File.ReadAllText(this.csvPath);
            return read;
        }

        public void addRow(string data) {
            string[] splitted = data.Split(",");
            string name = splitted[0];
            bool alreadyExists = false;
            var existingData = parseData();
            foreach (string[] item in existingData) {
                if (item[0] == name) {
                    alreadyExists = true;
                    break;
                }
            }
            if (!alreadyExists)
                File.AppendAllLines(this.csvPath, new[] { data.ToString() });
        }

        public void updateRow(string data) {
            
            List<String[]> existingData = parseData();
            List<String[]> updatedData = new List<String[]>();
            string[] splitted = data.Split(",");

            // Make updated data list
            foreach (string[] item in existingData) {
                if (item[0] == splitted[0]) {
                    updatedData.Add(splitted);
                } else {
                    updatedData.Add(item);
                }
            }

            // Empty the datafile and set header
            File.WriteAllLines(this.csvPath, new[] { "Name, GamesPlayed, GamesWon, Guesses, CorrectGuesses" });

            //Write updated data to file
            foreach (string[] item in updatedData) {
                File.AppendAllLines(this.csvPath, new[] { stringFormat(item).ToString() });
            }
        }

        public string stringFormat(string[] data) {
            string stringFormat = "";
            for (int i = 0; i < data.Length; i++) {
                stringFormat += data[i];
                if(i != data.Length - 1) {
                    stringFormat += ",";
                }
            }
            return stringFormat;
        }
        public List<String[]> parseData() {
            string[] lines = File.ReadAllLines(csvPath);
            List<string[]> playerData = new List<string[]>();
            for (int i = 1; i < lines.Length; i++) {
                string[] splitted = lines[i].Split(',');
                playerData.Add(splitted);
            }
            return playerData;
        }
        public List<String> parseNames() {
            string[] lines = File.ReadAllLines(csvPath);
            List<string> playerNames = new List<string>();
            for (int i = 1; i < lines.Length; i++) {
                string[] splitted = lines[i].Split(',');
                playerNames.Add(splitted[0]);
            }
            return playerNames;
        }
    }

}
