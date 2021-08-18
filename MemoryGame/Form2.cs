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
        Panel clicked1Panel = new Panel();

        public Form2(Memory game) {
            this.game = game;
            InitializeComponent();
            randomiseAddresses();
        }


        // This function returns integer array presentation of shuffled cards
        private void randomiseAddresses() {
            Random rnd = new Random();

            // Big grid 6x6 will have 18 different cards
            int[] maxCards = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
            maxCards = maxCards.OrderBy(x => rnd.Next()).ToArray();
            // Get card count according to game state
            var gridSize = gridSizeInNumber(game.getGridSize());
            int neededCards = gridSize.column * gridSize.row / 2;

            // Each cards needs duplicate
            int[] newCards = new int[neededCards*2];
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

        private void Form2_Load(object sender, EventArgs e) {
            initialiseGrid();
            getImages(pictureFolderPath(game.getDeckSelection()));
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
            for (int i= 0; i < memoryGameGrid.ColumnCount; i++) {
                for(int j = 0; j < memoryGameGrid.RowCount; j++) {
                    Panel panel = new Panel {
                        Size = new Size(pictureSize, pictureSize),
                    };
                    int sum = k;
                    string rowPos = i + "," + j;
                    panel.Click += memoryGamePanelClick;
                    panel.Name = sum.ToString();
                    panel.BorderStyle = BorderStyle.Fixed3D;
                    memoryGameGrid.Controls.Add(panel, i, j);
                    k++;
                }
            }
        }

        void memoryGamePanelClick(object sender, EventArgs e) {
            Random rnd = new Random();
            Panel panel = sender as Panel;
            if(panel.BackgroundImage == null) {
                try {
                    clicked1Panel.BackgroundImage = null;
                    panel.BackgroundImage = resizeImage(Image.FromFile(pictureAddresses[shuffledNumbers[int.Parse(panel.Name)]]), panel.Size);
                    clicked1Panel = panel;
                } catch {
                    panel.BackgroundImage = null;
                }
            
            } else {
                panel.BackgroundImage = null;
            }
            System.Diagnostics.Debug.WriteLine(panel.Name);
        }
        private void button3_Click(object sender, EventArgs e) {
            var f = new Form1();
            f.Show();
            this.Visible = false;
        }

        private Image resizeImage(Image image, Size size) {
            return (Image)(new Bitmap(image, size));
        }


        private void button6_Click(object sender, EventArgs e) {
            game.updateData();
        }

        private void button7_Click(object sender, EventArgs e) {
            string combinedPath = pictureFolderPath(game.getDeckSelection());
            getImages(combinedPath);
        }

        private void getImages(string path) {
            var files = Directory.GetFiles(path);
            foreach (string file in files) {
                pictureAddresses.Add(file);
            }
        }

        private void button8_Click(object sender, EventArgs e) {
            foreach (int item in shuffledNumbers) {
                System.Diagnostics.Debug.WriteLine(item);
            }
        }
    }

    public class GridSizeInNumber {
        public int column;
        public int row;
    }
}
