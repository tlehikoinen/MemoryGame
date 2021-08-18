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

        private void Form2_Load(object sender, EventArgs e) {
            initialiseGrid();
        }

        private int gridSizeInNumber(Memory.GridSize size) {
            switch ((Memory.GridSize)Enum.Parse(typeof(Memory.GridSize), size.ToString())) {
                case Memory.GridSize.small: {
                    return 4;
                }
                case Memory.GridSize.medium: {
                    return 6;
                }
                case Memory.GridSize.big: {
                    return 8;
                }
                default:
                    return 0;
            }
        }

        private void initialiseGrid() {
            memoryGameGrid.ColumnCount = gridSizeInNumber(game.getGridSize());
            memoryGameGrid.RowCount = gridSizeInNumber(game.getGridSize());
            var grids = gridSizeInNumber(game.getGridSize());
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

            for (int i= 0; i < memoryGameGrid.ColumnCount; i++) {
                for(int j = 0; j < memoryGameGrid.RowCount; j++) {
                    Panel panel = new Panel {
                        Size = new Size(pictureSize, pictureSize),
                    };
                    string rowPos = i + "," + j;
                    panel.Click += memoryGamePanelClick;
                    panel.Name = rowPos;
                    panel.BorderStyle = BorderStyle.Fixed3D;
                    memoryGameGrid.Controls.Add(panel, i, j);
                }
            }
        }

        void memoryGamePanelClick(object sender, EventArgs e) {
            Panel panel = sender as Panel;
            if(panel.BackgroundImage == null) { 
            panel.BackgroundImage = resizeImage(Image.FromFile("../../../Pictures/Game/1.png"), panel.Size);
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

        private void memoryGameGrid_Paint(object sender, PaintEventArgs e) {

        }
    }
}
