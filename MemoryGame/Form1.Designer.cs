
namespace MemoryGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vsPlayerBtn = new System.Windows.Forms.Button();
            this.vsComputerBtn = new System.Windows.Forms.Button();
            this.statisticsBtn = new System.Windows.Forms.Button();
            this.vsSingleBtn = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.helpBtn = new System.Windows.Forms.Button();
            this.errorPanel = new System.Windows.Forms.Panel();
            this.errorTextBox = new System.Windows.Forms.TextBox();
            this.errorPicture = new System.Windows.Forms.PictureBox();
            this.vsSinglePanel = new System.Windows.Forms.Panel();
            this.existingUserRadioBtn1 = new System.Windows.Forms.RadioButton();
            this.newUserRadioBtn1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.newUserPanel1 = new System.Windows.Forms.Panel();
            this.newUser1Label = new System.Windows.Forms.Label();
            this.newUser1Btn = new System.Windows.Forms.Button();
            this.newUser1Name = new System.Windows.Forms.TextBox();
            this.existingUserPanel1 = new System.Windows.Forms.Panel();
            this.existingUserBtn1 = new System.Windows.Forms.Button();
            this.existingUserComboBox1 = new System.Windows.Forms.ComboBox();
            this.existingUser1Label = new System.Windows.Forms.Label();
            this.gameOptionPanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.gridSizes = new System.Windows.Forms.ComboBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.dogsRadio = new System.Windows.Forms.RadioButton();
            this.catsRadioImage = new System.Windows.Forms.PictureBox();
            this.dogsRadioImage = new System.Windows.Forms.PictureBox();
            this.catsRadio = new System.Windows.Forms.RadioButton();
            this.helpPanel = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.homePanel = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.statisticsPanel = new System.Windows.Forms.Panel();
            this.statisticsHeader = new System.Windows.Forms.Label();
            this.vsComputerPanel = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.computerDifficulties = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.vsPlayerPanel = new System.Windows.Forms.Panel();
            this.existingUserRadioBtn2 = new System.Windows.Forms.RadioButton();
            this.newUserRadioBtn2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.existingUserPanel2 = new System.Windows.Forms.Panel();
            this.existingUserBtn2 = new System.Windows.Forms.Button();
            this.existingUserComboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.newUserPanel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.newUserBtn2 = new System.Windows.Forms.Button();
            this.newUser2Name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.errorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorPicture)).BeginInit();
            this.vsSinglePanel.SuspendLayout();
            this.newUserPanel1.SuspendLayout();
            this.existingUserPanel1.SuspendLayout();
            this.gameOptionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catsRadioImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogsRadioImage)).BeginInit();
            this.helpPanel.SuspendLayout();
            this.homePanel.SuspendLayout();
            this.statisticsPanel.SuspendLayout();
            this.vsComputerPanel.SuspendLayout();
            this.vsPlayerPanel.SuspendLayout();
            this.existingUserPanel2.SuspendLayout();
            this.newUserPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // vsPlayerBtn
            // 
            this.vsPlayerBtn.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vsPlayerBtn.Location = new System.Drawing.Point(12, 144);
            this.vsPlayerBtn.Name = "vsPlayerBtn";
            this.vsPlayerBtn.Size = new System.Drawing.Size(220, 60);
            this.vsPlayerBtn.TabIndex = 3;
            this.vsPlayerBtn.Text = "Against human";
            this.vsPlayerBtn.UseVisualStyleBackColor = true;
            this.vsPlayerBtn.Click += new System.EventHandler(this.vsPlayerBtn_Click);
            // 
            // vsComputerBtn
            // 
            this.vsComputerBtn.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vsComputerBtn.Location = new System.Drawing.Point(12, 220);
            this.vsComputerBtn.Name = "vsComputerBtn";
            this.vsComputerBtn.Size = new System.Drawing.Size(220, 60);
            this.vsComputerBtn.TabIndex = 4;
            this.vsComputerBtn.Text = "Against computer";
            this.vsComputerBtn.UseVisualStyleBackColor = true;
            this.vsComputerBtn.Click += new System.EventHandler(this.vsComputerBtn_Click);
            // 
            // statisticsBtn
            // 
            this.statisticsBtn.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statisticsBtn.Location = new System.Drawing.Point(12, 295);
            this.statisticsBtn.Name = "statisticsBtn";
            this.statisticsBtn.Size = new System.Drawing.Size(220, 60);
            this.statisticsBtn.TabIndex = 5;
            this.statisticsBtn.Text = "Statistics";
            this.statisticsBtn.UseVisualStyleBackColor = true;
            this.statisticsBtn.Click += new System.EventHandler(this.statisticsBtn_Click);
            // 
            // vsSingleBtn
            // 
            this.vsSingleBtn.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vsSingleBtn.Location = new System.Drawing.Point(12, 69);
            this.vsSingleBtn.Name = "vsSingleBtn";
            this.vsSingleBtn.Size = new System.Drawing.Size(220, 60);
            this.vsSingleBtn.TabIndex = 6;
            this.vsSingleBtn.Text = "Single player";
            this.vsSingleBtn.UseVisualStyleBackColor = true;
            this.vsSingleBtn.Click += new System.EventHandler(this.vsSingleBtn_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.logoPictureBox);
            this.splitContainer1.Panel1.Controls.Add(this.helpBtn);
            this.splitContainer1.Panel1.Controls.Add(this.vsComputerBtn);
            this.splitContainer1.Panel1.Controls.Add(this.statisticsBtn);
            this.splitContainer1.Panel1.Controls.Add(this.vsSingleBtn);
            this.splitContainer1.Panel1.Controls.Add(this.vsPlayerBtn);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.errorPanel);
            this.splitContainer1.Panel2.Controls.Add(this.vsSinglePanel);
            this.splitContainer1.Panel2.Controls.Add(this.gameOptionPanel);
            this.splitContainer1.Panel2.Controls.Add(this.helpPanel);
            this.splitContainer1.Panel2.Controls.Add(this.homePanel);
            this.splitContainer1.Panel2.Controls.Add(this.statisticsPanel);
            this.splitContainer1.Panel2.Controls.Add(this.vsComputerPanel);
            this.splitContainer1.Panel2.Controls.Add(this.vsPlayerPanel);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1212, 761);
            this.splitContainer1.SplitterDistance = 305;
            this.splitContainer1.TabIndex = 7;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Location = new System.Drawing.Point(12, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(220, 50);
            this.logoPictureBox.TabIndex = 8;
            this.logoPictureBox.TabStop = false;
            this.logoPictureBox.Click += new System.EventHandler(this.logoPictureBox_Click);
            // 
            // helpBtn
            // 
            this.helpBtn.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.helpBtn.Location = new System.Drawing.Point(12, 375);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(220, 60);
            this.helpBtn.TabIndex = 7;
            this.helpBtn.Text = "Help";
            this.helpBtn.UseVisualStyleBackColor = true;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // errorPanel
            // 
            this.errorPanel.BackColor = System.Drawing.Color.IndianRed;
            this.errorPanel.Controls.Add(this.errorTextBox);
            this.errorPanel.Controls.Add(this.errorPicture);
            this.errorPanel.Font = new System.Drawing.Font("Sitka Text", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.errorPanel.Location = new System.Drawing.Point(395, 268);
            this.errorPanel.Name = "errorPanel";
            this.errorPanel.Size = new System.Drawing.Size(355, 289);
            this.errorPanel.TabIndex = 7;
            this.errorPanel.Visible = false;
            this.errorPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.errorPanel_Paint);
            // 
            // errorTextBox
            // 
            this.errorTextBox.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorTextBox.Location = new System.Drawing.Point(20, 125);
            this.errorTextBox.Multiline = true;
            this.errorTextBox.Name = "errorTextBox";
            this.errorTextBox.ReadOnly = true;
            this.errorTextBox.Size = new System.Drawing.Size(314, 144);
            this.errorTextBox.TabIndex = 1;
            this.errorTextBox.Text = "Error with input";
            // 
            // errorPicture
            // 
            this.errorPicture.Location = new System.Drawing.Point(20, 14);
            this.errorPicture.Name = "errorPicture";
            this.errorPicture.Size = new System.Drawing.Size(256, 121);
            this.errorPicture.TabIndex = 0;
            this.errorPicture.TabStop = false;
            this.errorPicture.Click += new System.EventHandler(this.errorPicture_Click);
            // 
            // vsSinglePanel
            // 
            this.vsSinglePanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.vsSinglePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vsSinglePanel.Controls.Add(this.existingUserRadioBtn1);
            this.vsSinglePanel.Controls.Add(this.newUserRadioBtn1);
            this.vsSinglePanel.Controls.Add(this.label3);
            this.vsSinglePanel.Controls.Add(this.label2);
            this.vsSinglePanel.Controls.Add(this.label1);
            this.vsSinglePanel.Controls.Add(this.newUserPanel1);
            this.vsSinglePanel.Controls.Add(this.existingUserPanel1);
            this.vsSinglePanel.Location = new System.Drawing.Point(22, 12);
            this.vsSinglePanel.Name = "vsSinglePanel";
            this.vsSinglePanel.Size = new System.Drawing.Size(350, 235);
            this.vsSinglePanel.TabIndex = 0;
            // 
            // existingUserRadioBtn1
            // 
            this.existingUserRadioBtn1.AutoSize = true;
            this.existingUserRadioBtn1.Location = new System.Drawing.Point(134, 35);
            this.existingUserRadioBtn1.Name = "existingUserRadioBtn1";
            this.existingUserRadioBtn1.Size = new System.Drawing.Size(14, 13);
            this.existingUserRadioBtn1.TabIndex = 11;
            this.existingUserRadioBtn1.TabStop = true;
            this.existingUserRadioBtn1.UseVisualStyleBackColor = true;
            this.existingUserRadioBtn1.CheckedChanged += new System.EventHandler(this.existingUserRadioBtn1_CheckedChanged);
            // 
            // newUserRadioBtn1
            // 
            this.newUserRadioBtn1.AutoSize = true;
            this.newUserRadioBtn1.Location = new System.Drawing.Point(43, 35);
            this.newUserRadioBtn1.Name = "newUserRadioBtn1";
            this.newUserRadioBtn1.Size = new System.Drawing.Size(14, 13);
            this.newUserRadioBtn1.TabIndex = 10;
            this.newUserRadioBtn1.TabStop = true;
            this.newUserRadioBtn1.UseVisualStyleBackColor = true;
            this.newUserRadioBtn1.CheckedChanged += new System.EventHandler(this.newUserRadioBtn1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Sitka Text", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(205, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 70);
            this.label3.TabIndex = 9;
            this.label3.Text = "Player1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(102, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Existing user";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "New user";
            // 
            // newUserPanel1
            // 
            this.newUserPanel1.Controls.Add(this.newUser1Label);
            this.newUserPanel1.Controls.Add(this.newUser1Btn);
            this.newUserPanel1.Controls.Add(this.newUser1Name);
            this.newUserPanel1.Location = new System.Drawing.Point(43, 96);
            this.newUserPanel1.Name = "newUserPanel1";
            this.newUserPanel1.Size = new System.Drawing.Size(200, 100);
            this.newUserPanel1.TabIndex = 7;
            this.newUserPanel1.Visible = false;
            this.newUserPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.newUserPanel1_Paint);
            // 
            // newUser1Label
            // 
            this.newUser1Label.AutoSize = true;
            this.newUser1Label.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newUser1Label.Location = new System.Drawing.Point(68, 13);
            this.newUser1Label.Name = "newUser1Label";
            this.newUser1Label.Size = new System.Drawing.Size(75, 20);
            this.newUser1Label.TabIndex = 2;
            this.newUser1Label.Text = "Username";
            // 
            // newUser1Btn
            // 
            this.newUser1Btn.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newUser1Btn.Location = new System.Drawing.Point(68, 64);
            this.newUser1Btn.Name = "newUser1Btn";
            this.newUser1Btn.Size = new System.Drawing.Size(75, 31);
            this.newUser1Btn.TabIndex = 1;
            this.newUser1Btn.Text = "Save";
            this.newUser1Btn.UseVisualStyleBackColor = true;
            this.newUser1Btn.Click += new System.EventHandler(this.newUser1Btn_Click);
            // 
            // newUser1Name
            // 
            this.newUser1Name.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newUser1Name.Location = new System.Drawing.Point(56, 36);
            this.newUser1Name.Name = "newUser1Name";
            this.newUser1Name.Size = new System.Drawing.Size(100, 24);
            this.newUser1Name.TabIndex = 0;
            this.newUser1Name.TextChanged += new System.EventHandler(this.newUser1Name_TextChanged);
            // 
            // existingUserPanel1
            // 
            this.existingUserPanel1.Controls.Add(this.existingUserBtn1);
            this.existingUserPanel1.Controls.Add(this.existingUserComboBox1);
            this.existingUserPanel1.Controls.Add(this.existingUser1Label);
            this.existingUserPanel1.Location = new System.Drawing.Point(43, 96);
            this.existingUserPanel1.Name = "existingUserPanel1";
            this.existingUserPanel1.Size = new System.Drawing.Size(200, 100);
            this.existingUserPanel1.TabIndex = 8;
            this.existingUserPanel1.Visible = false;
            this.existingUserPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.existingUserPanel1_Paint);
            // 
            // existingUserBtn1
            // 
            this.existingUserBtn1.Location = new System.Drawing.Point(65, 67);
            this.existingUserBtn1.Name = "existingUserBtn1";
            this.existingUserBtn1.Size = new System.Drawing.Size(75, 23);
            this.existingUserBtn1.TabIndex = 2;
            this.existingUserBtn1.Text = "Select";
            this.existingUserBtn1.UseVisualStyleBackColor = true;
            this.existingUserBtn1.Click += new System.EventHandler(this.existingUserBtn1_Click);
            // 
            // existingUserComboBox1
            // 
            this.existingUserComboBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.existingUserComboBox1.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.existingUserComboBox1.FormattingEnabled = true;
            this.existingUserComboBox1.Location = new System.Drawing.Point(40, 38);
            this.existingUserComboBox1.Name = "existingUserComboBox1";
            this.existingUserComboBox1.Size = new System.Drawing.Size(121, 27);
            this.existingUserComboBox1.TabIndex = 1;
            this.existingUserComboBox1.SelectedIndexChanged += new System.EventHandler(this.existingUserComboBox1_SelectedIndexChanged);
            // 
            // existingUser1Label
            // 
            this.existingUser1Label.AutoSize = true;
            this.existingUser1Label.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.existingUser1Label.Location = new System.Drawing.Point(67, 18);
            this.existingUser1Label.Name = "existingUser1Label";
            this.existingUser1Label.Size = new System.Drawing.Size(79, 20);
            this.existingUser1Label.TabIndex = 0;
            this.existingUser1Label.Text = "Select user";
            // 
            // gameOptionPanel
            // 
            this.gameOptionPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gameOptionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gameOptionPanel.Controls.Add(this.label9);
            this.gameOptionPanel.Controls.Add(this.gridSizes);
            this.gameOptionPanel.Controls.Add(this.startBtn);
            this.gameOptionPanel.Controls.Add(this.dogsRadio);
            this.gameOptionPanel.Controls.Add(this.catsRadioImage);
            this.gameOptionPanel.Controls.Add(this.dogsRadioImage);
            this.gameOptionPanel.Controls.Add(this.catsRadio);
            this.gameOptionPanel.Location = new System.Drawing.Point(22, 268);
            this.gameOptionPanel.Name = "gameOptionPanel";
            this.gameOptionPanel.Size = new System.Drawing.Size(351, 289);
            this.gameOptionPanel.TabIndex = 5;
            this.gameOptionPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.gameOptionPanel_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(53, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Gridsize";
            // 
            // gridSizes
            // 
            this.gridSizes.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.gridSizes.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gridSizes.FormattingEnabled = true;
            this.gridSizes.Location = new System.Drawing.Point(21, 26);
            this.gridSizes.Name = "gridSizes";
            this.gridSizes.Size = new System.Drawing.Size(125, 27);
            this.gridSizes.TabIndex = 5;
            this.gridSizes.SelectedIndexChanged += new System.EventHandler(this.gridSizes_SelectedIndexChanged);
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Sitka Text", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startBtn.Location = new System.Drawing.Point(24, 205);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(236, 75);
            this.startBtn.TabIndex = 4;
            this.startBtn.Text = "Play";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            this.startBtn.MouseHover += new System.EventHandler(this.startBtn_MouseHover);
            // 
            // dogsRadio
            // 
            this.dogsRadio.AutoSize = true;
            this.dogsRadio.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dogsRadio.Location = new System.Drawing.Point(160, 59);
            this.dogsRadio.Name = "dogsRadio";
            this.dogsRadio.Size = new System.Drawing.Size(96, 24);
            this.dogsRadio.TabIndex = 3;
            this.dogsRadio.TabStop = true;
            this.dogsRadio.Text = "characters";
            this.dogsRadio.UseVisualStyleBackColor = true;
            this.dogsRadio.CheckedChanged += new System.EventHandler(this.dogsRadio_CheckedChanged);
            // 
            // catsRadioImage
            // 
            this.catsRadioImage.Location = new System.Drawing.Point(24, 99);
            this.catsRadioImage.Name = "catsRadioImage";
            this.catsRadioImage.Size = new System.Drawing.Size(100, 100);
            this.catsRadioImage.TabIndex = 0;
            this.catsRadioImage.TabStop = false;
            this.catsRadioImage.Click += new System.EventHandler(this.catsRadioImage_Click);
            // 
            // dogsRadioImage
            // 
            this.dogsRadioImage.Location = new System.Drawing.Point(160, 99);
            this.dogsRadioImage.Name = "dogsRadioImage";
            this.dogsRadioImage.Size = new System.Drawing.Size(100, 100);
            this.dogsRadioImage.TabIndex = 1;
            this.dogsRadioImage.TabStop = false;
            this.dogsRadioImage.Click += new System.EventHandler(this.dogsRadioImage_Click);
            // 
            // catsRadio
            // 
            this.catsRadio.AutoSize = true;
            this.catsRadio.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.catsRadio.Location = new System.Drawing.Point(24, 59);
            this.catsRadio.Name = "catsRadio";
            this.catsRadio.Size = new System.Drawing.Size(54, 24);
            this.catsRadio.TabIndex = 2;
            this.catsRadio.TabStop = true;
            this.catsRadio.Text = "cats";
            this.catsRadio.UseVisualStyleBackColor = true;
            this.catsRadio.CheckedChanged += new System.EventHandler(this.catsRadio_CheckedChanged);
            // 
            // helpPanel
            // 
            this.helpPanel.Controls.Add(this.label13);
            this.helpPanel.Controls.Add(this.textBox1);
            this.helpPanel.Location = new System.Drawing.Point(22, 12);
            this.helpPanel.Name = "helpPanel";
            this.helpPanel.Size = new System.Drawing.Size(351, 235);
            this.helpPanel.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Sitka Text", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(82, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 47);
            this.label13.TabIndex = 1;
            this.label13.Text = "Help";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 60);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(241, 38);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "This game is pretty self explanatory";
            // 
            // homePanel
            // 
            this.homePanel.Controls.Add(this.label14);
            this.homePanel.Location = new System.Drawing.Point(22, 12);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(351, 235);
            this.homePanel.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Sitka Text", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(25, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(167, 47);
            this.label14.TabIndex = 1;
            this.label14.Text = "Welcome!";
            // 
            // statisticsPanel
            // 
            this.statisticsPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.statisticsPanel.Controls.Add(this.statisticsHeader);
            this.statisticsPanel.Location = new System.Drawing.Point(22, 12);
            this.statisticsPanel.Name = "statisticsPanel";
            this.statisticsPanel.Size = new System.Drawing.Size(351, 545);
            this.statisticsPanel.TabIndex = 3;
            this.statisticsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.statisticsPanel_Paint);
            // 
            // statisticsHeader
            // 
            this.statisticsHeader.AutoSize = true;
            this.statisticsHeader.Font = new System.Drawing.Font("Sitka Text", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statisticsHeader.Location = new System.Drawing.Point(54, 11);
            this.statisticsHeader.Name = "statisticsHeader";
            this.statisticsHeader.Size = new System.Drawing.Size(156, 47);
            this.statisticsHeader.TabIndex = 0;
            this.statisticsHeader.Text = "Statistics";
            // 
            // vsComputerPanel
            // 
            this.vsComputerPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.vsComputerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vsComputerPanel.Controls.Add(this.label12);
            this.vsComputerPanel.Controls.Add(this.computerDifficulties);
            this.vsComputerPanel.Controls.Add(this.label11);
            this.vsComputerPanel.Location = new System.Drawing.Point(395, 12);
            this.vsComputerPanel.Name = "vsComputerPanel";
            this.vsComputerPanel.Size = new System.Drawing.Size(350, 235);
            this.vsComputerPanel.TabIndex = 2;
            this.vsComputerPanel.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(72, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 20);
            this.label12.TabIndex = 12;
            this.label12.Text = "Difficulty";
            // 
            // computerDifficulties
            // 
            this.computerDifficulties.FormattingEnabled = true;
            this.computerDifficulties.Location = new System.Drawing.Point(49, 138);
            this.computerDifficulties.Name = "computerDifficulties";
            this.computerDifficulties.Size = new System.Drawing.Size(121, 23);
            this.computerDifficulties.TabIndex = 11;
            this.computerDifficulties.SelectedIndexChanged += new System.EventHandler(this.computerDifficulties_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Sitka Text", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(173, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(181, 70);
            this.label11.TabIndex = 10;
            this.label11.Text = "Computer";
            // 
            // vsPlayerPanel
            // 
            this.vsPlayerPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.vsPlayerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vsPlayerPanel.Controls.Add(this.existingUserRadioBtn2);
            this.vsPlayerPanel.Controls.Add(this.newUserRadioBtn2);
            this.vsPlayerPanel.Controls.Add(this.label4);
            this.vsPlayerPanel.Controls.Add(this.label7);
            this.vsPlayerPanel.Controls.Add(this.label8);
            this.vsPlayerPanel.Controls.Add(this.existingUserPanel2);
            this.vsPlayerPanel.Controls.Add(this.newUserPanel2);
            this.vsPlayerPanel.Location = new System.Drawing.Point(395, 12);
            this.vsPlayerPanel.Name = "vsPlayerPanel";
            this.vsPlayerPanel.Size = new System.Drawing.Size(350, 235);
            this.vsPlayerPanel.TabIndex = 1;
            this.vsPlayerPanel.Visible = false;
            // 
            // existingUserRadioBtn2
            // 
            this.existingUserRadioBtn2.AutoSize = true;
            this.existingUserRadioBtn2.Location = new System.Drawing.Point(139, 38);
            this.existingUserRadioBtn2.Name = "existingUserRadioBtn2";
            this.existingUserRadioBtn2.Size = new System.Drawing.Size(14, 13);
            this.existingUserRadioBtn2.TabIndex = 18;
            this.existingUserRadioBtn2.TabStop = true;
            this.existingUserRadioBtn2.UseVisualStyleBackColor = true;
            this.existingUserRadioBtn2.CheckedChanged += new System.EventHandler(this.existingUserRadioBtn2_CheckedChanged);
            // 
            // newUserRadioBtn2
            // 
            this.newUserRadioBtn2.AutoSize = true;
            this.newUserRadioBtn2.Location = new System.Drawing.Point(49, 38);
            this.newUserRadioBtn2.Name = "newUserRadioBtn2";
            this.newUserRadioBtn2.Size = new System.Drawing.Size(14, 13);
            this.newUserRadioBtn2.TabIndex = 17;
            this.newUserRadioBtn2.TabStop = true;
            this.newUserRadioBtn2.UseVisualStyleBackColor = true;
            this.newUserRadioBtn2.CheckedChanged += new System.EventHandler(this.newUserRadioBtn2_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Sitka Text", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(209, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 70);
            this.label4.TabIndex = 16;
            this.label4.Text = "Player2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(108, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Existing user";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.label8.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(27, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "New user";
            // 
            // existingUserPanel2
            // 
            this.existingUserPanel2.Controls.Add(this.existingUserBtn2);
            this.existingUserPanel2.Controls.Add(this.existingUserComboBox2);
            this.existingUserPanel2.Controls.Add(this.label5);
            this.existingUserPanel2.Location = new System.Drawing.Point(52, 96);
            this.existingUserPanel2.Name = "existingUserPanel2";
            this.existingUserPanel2.Size = new System.Drawing.Size(200, 100);
            this.existingUserPanel2.TabIndex = 15;
            this.existingUserPanel2.Visible = false;
            // 
            // existingUserBtn2
            // 
            this.existingUserBtn2.Location = new System.Drawing.Point(67, 65);
            this.existingUserBtn2.Name = "existingUserBtn2";
            this.existingUserBtn2.Size = new System.Drawing.Size(75, 23);
            this.existingUserBtn2.TabIndex = 2;
            this.existingUserBtn2.Text = "Select";
            this.existingUserBtn2.UseVisualStyleBackColor = true;
            // 
            // existingUserComboBox2
            // 
            this.existingUserComboBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.existingUserComboBox2.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.existingUserComboBox2.FormattingEnabled = true;
            this.existingUserComboBox2.Location = new System.Drawing.Point(43, 38);
            this.existingUserComboBox2.Name = "existingUserComboBox2";
            this.existingUserComboBox2.Size = new System.Drawing.Size(121, 27);
            this.existingUserComboBox2.TabIndex = 1;
            this.existingUserComboBox2.SelectedIndexChanged += new System.EventHandler(this.existingUserComboBox2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(67, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Select user";
            // 
            // newUserPanel2
            // 
            this.newUserPanel2.Controls.Add(this.label6);
            this.newUserPanel2.Controls.Add(this.newUserBtn2);
            this.newUserPanel2.Controls.Add(this.newUser2Name);
            this.newUserPanel2.Location = new System.Drawing.Point(52, 96);
            this.newUserPanel2.Name = "newUserPanel2";
            this.newUserPanel2.Size = new System.Drawing.Size(200, 100);
            this.newUserPanel2.TabIndex = 14;
            this.newUserPanel2.Visible = false;
            this.newUserPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.newUserPanel2_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(71, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Username";
            // 
            // newUserBtn2
            // 
            this.newUserBtn2.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newUserBtn2.Location = new System.Drawing.Point(68, 65);
            this.newUserBtn2.Name = "newUserBtn2";
            this.newUserBtn2.Size = new System.Drawing.Size(75, 30);
            this.newUserBtn2.TabIndex = 1;
            this.newUserBtn2.Text = "Save";
            this.newUserBtn2.UseVisualStyleBackColor = true;
            this.newUserBtn2.Click += new System.EventHandler(this.newUserBtn2_Click);
            // 
            // newUser2Name
            // 
            this.newUser2Name.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newUser2Name.Location = new System.Drawing.Point(56, 36);
            this.newUser2Name.Name = "newUser2Name";
            this.newUser2Name.Size = new System.Drawing.Size(100, 24);
            this.newUser2Name.TabIndex = 0;
            this.newUser2Name.TextChanged += new System.EventHandler(this.newUser2Name_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1212, 761);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.errorPanel.ResumeLayout(false);
            this.errorPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorPicture)).EndInit();
            this.vsSinglePanel.ResumeLayout(false);
            this.vsSinglePanel.PerformLayout();
            this.newUserPanel1.ResumeLayout(false);
            this.newUserPanel1.PerformLayout();
            this.existingUserPanel1.ResumeLayout(false);
            this.existingUserPanel1.PerformLayout();
            this.gameOptionPanel.ResumeLayout(false);
            this.gameOptionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catsRadioImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogsRadioImage)).EndInit();
            this.helpPanel.ResumeLayout(false);
            this.helpPanel.PerformLayout();
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            this.statisticsPanel.ResumeLayout(false);
            this.statisticsPanel.PerformLayout();
            this.vsComputerPanel.ResumeLayout(false);
            this.vsComputerPanel.PerformLayout();
            this.vsPlayerPanel.ResumeLayout(false);
            this.vsPlayerPanel.PerformLayout();
            this.existingUserPanel2.ResumeLayout(false);
            this.existingUserPanel2.PerformLayout();
            this.newUserPanel2.ResumeLayout(false);
            this.newUserPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button vsPlayerBtn;
        private System.Windows.Forms.Button vsComputerBtn;
        private System.Windows.Forms.Button statisticsBtn;
        private System.Windows.Forms.Button vsSingleBtn;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel vsSinglePanel;
        private System.Windows.Forms.Panel vsPlayerPanel;
        private System.Windows.Forms.Panel vsComputerPanel;
        private System.Windows.Forms.Panel statisticsPanel;
        private System.Windows.Forms.Button helpBtn;
        private System.Windows.Forms.Panel helpPanel;
        private System.Windows.Forms.TextBox help;
        private System.Windows.Forms.Panel gameOptionPanel;
        private System.Windows.Forms.RadioButton dogsRadio;
        private System.Windows.Forms.RadioButton catsRadio;
        private System.Windows.Forms.PictureBox dogsRadioImage;
        private System.Windows.Forms.PictureBox catsRadioImage;
        private System.Windows.Forms.ComboBox gridSizes;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Panel newUserPanel1;
        private System.Windows.Forms.Button newUser1Btn;
        private System.Windows.Forms.TextBox newUser1Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel existingUserPanel1;
        private System.Windows.Forms.Label existingUser1Label;
        private System.Windows.Forms.Label newUser1Label;
        private System.Windows.Forms.ComboBox existingUserComboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button existingUserBtn1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel existingUserPanel2;
        private System.Windows.Forms.Button existingUserBtn2;
        private System.Windows.Forms.ComboBox existingUserComboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel newUserPanel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button newUserBtn2;
        private System.Windows.Forms.TextBox newUser2Name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton existingUserRadioBtn2;
        private System.Windows.Forms.RadioButton newUserRadioBtn2;
        private System.Windows.Forms.RadioButton existingUserRadioBtn1;
        private System.Windows.Forms.RadioButton newUserRadioBtn1;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox computerDifficulties;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label statisticsHeader;
        private System.Windows.Forms.Panel errorPanel;
        private System.Windows.Forms.TextBox errorTextBox;
        private System.Windows.Forms.PictureBox errorPicture;
        private System.Windows.Forms.Label label9;
    }
}

