using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace MemoryGame {

    public class Memory {

        Player player1;
        Player player2;
        
        public Memory() { }
        public void setMemoryPlayers(Player player1, Player player2) {
            this.player1 = player1;
            this.player2 = player2;
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

        string[] adjectives = { "Furious, Soft, unaccountable, zany, moldy, mountainous, flakyubiquitous, utter" };
        string[] names = { "horn, copper, acoustics, servant, company, lumber, crime, station, story, bushes, government, back" };


        public enum Skillset {
            easy,
            medium,
            hard
        }

        public Skillset difficulty;

        public ComputerPlayer(Skillset skillset) {
            this.difficulty = skillset;
        }


    }

}
