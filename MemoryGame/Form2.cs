using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MemoryGame {
    public partial class Form2 : Form {
        Memory game = new Memory();

        public Form2(Memory game) {
            this.game = game;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            var name = textBox1.Text;
            System.Diagnostics.Debug.WriteLine(this.game.getMemoryPlayer1().name);
        }

        private void button2_Click(object sender, EventArgs e) {
            Player player = game.getMemoryPlayer1();

            switch (game.getGameState()) {
                case Memory.State.singleplayer:
                System.Diagnostics.Debug.WriteLine(player.name);
                System.Diagnostics.Debug.WriteLine(player.gamesPlayed);
                System.Diagnostics.Debug.WriteLine(game.getDeckSelection());
                System.Diagnostics.Debug.WriteLine(game.getGridSize());
                break;
                case Memory.State.multiplayer:
                Player player2 = game.getMemoryPlayer2();
                System.Diagnostics.Debug.WriteLine(player.name);
                System.Diagnostics.Debug.WriteLine(player.gamesPlayed);
                System.Diagnostics.Debug.WriteLine(game.getDeckSelection());
                System.Diagnostics.Debug.WriteLine(game.getGridSize());

                System.Diagnostics.Debug.WriteLine(player2.name);
                System.Diagnostics.Debug.WriteLine(player2.gamesPlayed);
                System.Diagnostics.Debug.WriteLine(game.getDeckSelection());
                System.Diagnostics.Debug.WriteLine(game.getGridSize());
                break;
                case Memory.State.vsComputer:
                ComputerPlayer ComPlayer = game.getComputerPlayer();
                System.Diagnostics.Debug.WriteLine(ComPlayer.name);
                System.Diagnostics.Debug.WriteLine(ComPlayer.gamesPlayed);
                System.Diagnostics.Debug.WriteLine(ComPlayer.difficulty);
                System.Diagnostics.Debug.WriteLine(game.getDeckSelection());
                System.Diagnostics.Debug.WriteLine(game.getGridSize());
                break;
                default: 
                    break;
            }

        }


        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) {

        }

        private void Form2_Load(object sender, EventArgs e) {

        }

        private void button3_Click(object sender, EventArgs e) {
            var f = new Form1();
            f.Show();
            this.Visible = false;
        }
    }
}
