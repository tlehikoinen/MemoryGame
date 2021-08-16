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
            var name = textBox2.Text;
            System.Diagnostics.Debug.WriteLine(name);
            System.Diagnostics.Debug.WriteLine(game.getGameState());
            //System.Diagnostics.Debug.WriteLine(game.getComputerPlayer().difficulty);
            System.Diagnostics.Debug.WriteLine(game.getGridSize());
            System.Diagnostics.Debug.WriteLine(game.getDeckSelection());




        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) {

        }

        private void Form2_Load(object sender, EventArgs e) {

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
        private void button3_Click(object sender, EventArgs e) {
            InitialiseFolder();
        }
    }
}
