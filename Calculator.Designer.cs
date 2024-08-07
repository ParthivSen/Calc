namespace Calculator
{
    partial class Calculator
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            BtnBack = new Button();
            BtnDivide = new Button();
            BtnMultiply = new Button();
            BtnMinus = new Button();
            BtnPlus = new Button();
            BtnEqual = new Button();
            TxtMain = new TextBox();
            TxtRcnt = new TextBox();
            RcntHistBtn = new Button();
            label1 = new Label();
            MainMenuBtn = new Button();
            SideBar = new FlowLayoutPanel();
            panel2 = new Panel();
            textBox1 = new TextBox();
            MenuBtn = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel1 = new Panel();
            button6 = new Button();
            SiderBarTimer = new System.Windows.Forms.Timer(components);
            BtnPercent = new Button();
            BtnCE = new Button();
            BtnC = new Button();
            BtnFrac = new Button();
            BtnSqre = new Button();
            BtnSqrt = new Button();
            BtnNum7 = new Button();
            BtnNum8 = new Button();
            BtnNum9 = new Button();
            BtnNum4 = new Button();
            BtnNum5 = new Button();
            BtnNum6 = new Button();
            BtnNum1 = new Button();
            BtnNum2 = new Button();
            BtnNum3 = new Button();
            BtnNegate = new Button();
            BtnNum0 = new Button();
            BtnDecimal = new Button();
            button25 = new Button();
            button26 = new Button();
            button27 = new Button();
            button28 = new Button();
            button29 = new Button();
            button30 = new Button();
            HistoryBar = new FlowLayoutPanel();
            panel3 = new Panel();
            NoHistLbl = new Label();
            panel4 = new Panel();
            label4 = new Label();
            label3 = new Label();
            HistoryBarTimer = new System.Windows.Forms.Timer(components);
            SideBar.SuspendLayout();
            panel2.SuspendLayout();
            HistoryBar.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // BtnBack
            // 
            BtnBack.BackColor = SystemColors.InactiveBorder;
            BtnBack.FlatAppearance.BorderColor = SystemColors.GradientInactiveCaption;
            BtnBack.Font = new Font("Segoe UI Symbol", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnBack.Location = new Point(229, 184);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(75, 51);
            BtnBack.TabIndex = 3;
            BtnBack.Text = "⌫";
            BtnBack.UseVisualStyleBackColor = false;
            BtnBack.Click += BtnBack_Click;
            // 
            // BtnDivide
            // 
            BtnDivide.BackColor = SystemColors.InactiveBorder;
            BtnDivide.Font = new Font("Courier New", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnDivide.Location = new Point(229, 235);
            BtnDivide.Name = "BtnDivide";
            BtnDivide.Size = new Size(75, 51);
            BtnDivide.TabIndex = 7;
            BtnDivide.Text = "÷";
            BtnDivide.UseVisualStyleBackColor = false;
            BtnDivide.Click += BtnDivide_Click;
            // 
            // BtnMultiply
            // 
            BtnMultiply.BackColor = SystemColors.InactiveBorder;
            BtnMultiply.Font = new Font("Courier New", 18F);
            BtnMultiply.Location = new Point(229, 286);
            BtnMultiply.Name = "BtnMultiply";
            BtnMultiply.Size = new Size(75, 51);
            BtnMultiply.TabIndex = 11;
            BtnMultiply.Text = "×";
            BtnMultiply.UseVisualStyleBackColor = false;
            BtnMultiply.Click += BtnMultiply_Click;
            // 
            // BtnMinus
            // 
            BtnMinus.BackColor = SystemColors.InactiveBorder;
            BtnMinus.Font = new Font("Courier New", 18F);
            BtnMinus.Location = new Point(229, 337);
            BtnMinus.Name = "BtnMinus";
            BtnMinus.Size = new Size(75, 51);
            BtnMinus.TabIndex = 15;
            BtnMinus.Text = "-";
            BtnMinus.UseVisualStyleBackColor = false;
            BtnMinus.Click += BtnMinus_Click;
            // 
            // BtnPlus
            // 
            BtnPlus.BackColor = SystemColors.InactiveBorder;
            BtnPlus.Font = new Font("Courier New", 18F);
            BtnPlus.Location = new Point(229, 388);
            BtnPlus.Name = "BtnPlus";
            BtnPlus.Size = new Size(75, 51);
            BtnPlus.TabIndex = 19;
            BtnPlus.Text = "+";
            BtnPlus.UseVisualStyleBackColor = false;
            BtnPlus.Click += BtnPlus_Click;
            // 
            // BtnEqual
            // 
            BtnEqual.BackColor = SystemColors.HotTrack;
            BtnEqual.BackgroundImageLayout = ImageLayout.None;
            BtnEqual.FlatAppearance.BorderColor = SystemColors.HotTrack;
            BtnEqual.FlatAppearance.BorderSize = 0;
            BtnEqual.Font = new Font("Courier New", 18F);
            BtnEqual.Location = new Point(229, 439);
            BtnEqual.Margin = new Padding(0);
            BtnEqual.Name = "BtnEqual";
            BtnEqual.Size = new Size(75, 51);
            BtnEqual.TabIndex = 23;
            BtnEqual.Text = "=";
            BtnEqual.UseVisualStyleBackColor = false;
            BtnEqual.Click += BtnEqual_Click;
            // 
            // TxtMain
            // 
            TxtMain.BackColor = SystemColors.Control;
            TxtMain.BorderStyle = BorderStyle.None;
            TxtMain.Font = new Font("Segoe UI Variable Text Semibold", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtMain.Location = new Point(7, 76);
            TxtMain.Name = "TxtMain";
            TxtMain.ReadOnly = true;
            TxtMain.Size = new Size(289, 58);
            TxtMain.TabIndex = 30;
            TxtMain.Text = "0";
            TxtMain.TextAlign = HorizontalAlignment.Right;
            // 
            // TxtRcnt
            // 
            TxtRcnt.BackColor = SystemColors.Control;
            TxtRcnt.BorderStyle = BorderStyle.None;
            TxtRcnt.Font = new Font("Segoe UI Variable Text Light", 12F);
            TxtRcnt.ForeColor = SystemColors.ControlDarkDark;
            TxtRcnt.Location = new Point(7, 48);
            TxtRcnt.Name = "TxtRcnt";
            TxtRcnt.ReadOnly = true;
            TxtRcnt.Size = new Size(289, 22);
            TxtRcnt.TabIndex = 31;
            TxtRcnt.TextAlign = HorizontalAlignment.Right;
            // 
            // RcntHistBtn
            // 
            RcntHistBtn.BackColor = SystemColors.Control;
            RcntHistBtn.FlatAppearance.BorderSize = 0;
            RcntHistBtn.FlatStyle = FlatStyle.Flat;
            RcntHistBtn.ForeColor = SystemColors.ControlLight;
            RcntHistBtn.Image = (Image)resources.GetObject("RcntHistBtn.Image");
            RcntHistBtn.Location = new Point(268, 9);
            RcntHistBtn.Name = "RcntHistBtn";
            RcntHistBtn.Size = new Size(33, 33);
            RcntHistBtn.TabIndex = 32;
            RcntHistBtn.UseVisualStyleBackColor = false;
            RcntHistBtn.Click += RcntHistBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Small Semibol", 15F);
            label1.Location = new Point(40, 12);
            label1.Name = "label1";
            label1.Size = new Size(96, 27);
            label1.TabIndex = 33;
            label1.Text = "Standard";
            // 
            // MainMenuBtn
            // 
            MainMenuBtn.FlatAppearance.BorderSize = 0;
            MainMenuBtn.FlatStyle = FlatStyle.Flat;
            MainMenuBtn.Font = new Font("Segoe UI Symbol", 14F, FontStyle.Bold);
            MainMenuBtn.Location = new Point(7, 9);
            MainMenuBtn.Name = "MainMenuBtn";
            MainMenuBtn.Size = new Size(33, 33);
            MainMenuBtn.TabIndex = 34;
            MainMenuBtn.Text = "☰";
            MainMenuBtn.UseVisualStyleBackColor = true;
            MainMenuBtn.Click += MainMenuBtn_Click;
            // 
            // SideBar
            // 
            SideBar.BackColor = Color.GhostWhite;
            SideBar.Controls.Add(panel2);
            SideBar.Controls.Add(button1);
            SideBar.Controls.Add(button2);
            SideBar.Controls.Add(button3);
            SideBar.Controls.Add(button4);
            SideBar.Controls.Add(button5);
            SideBar.Controls.Add(panel1);
            SideBar.Controls.Add(button6);
            SideBar.Dock = DockStyle.Left;
            SideBar.Location = new Point(0, 0);
            SideBar.MaximumSize = new Size(252, 494);
            SideBar.MinimumSize = new Size(0, 494);
            SideBar.Name = "SideBar";
            SideBar.Size = new Size(0, 494);
            SideBar.TabIndex = 35;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(MenuBtn);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(249, 79);
            panel2.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.GhostWhite;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Variable Display Semib", 10F);
            textBox1.Location = new Point(9, 58);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(100, 18);
            textBox1.TabIndex = 36;
            textBox1.Text = "Calculator";
            // 
            // MenuBtn
            // 
            MenuBtn.FlatAppearance.BorderColor = Color.White;
            MenuBtn.FlatAppearance.BorderSize = 0;
            MenuBtn.FlatStyle = FlatStyle.Flat;
            MenuBtn.Font = new Font("Segoe UI", 14F);
            MenuBtn.Location = new Point(4, 7);
            MenuBtn.Name = "MenuBtn";
            MenuBtn.Size = new Size(30, 30);
            MenuBtn.TabIndex = 0;
            MenuBtn.Text = "☰";
            MenuBtn.UseVisualStyleBackColor = true;
            MenuBtn.Click += MenuBtn_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Variable Text", 10F);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(3, 88);
            button1.Name = "button1";
            button1.Size = new Size(240, 41);
            button1.TabIndex = 37;
            button1.Text = "      Standard";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Variable Text", 10F);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(3, 135);
            button2.Name = "button2";
            button2.Size = new Size(240, 41);
            button2.TabIndex = 38;
            button2.Text = "      Scientific";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderColor = Color.White;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Variable Text", 10F);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(3, 182);
            button3.Name = "button3";
            button3.Size = new Size(240, 41);
            button3.TabIndex = 39;
            button3.Text = "      Graphical";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderColor = Color.White;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Variable Text", 10F);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(3, 229);
            button4.Name = "button4";
            button4.Size = new Size(240, 41);
            button4.TabIndex = 40;
            button4.Text = "      Programmer";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderColor = Color.White;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Variable Text", 10F);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(3, 276);
            button5.Name = "button5";
            button5.Size = new Size(240, 41);
            button5.TabIndex = 41;
            button5.Text = "      Date Calculation";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Location = new Point(3, 323);
            panel1.Name = "panel1";
            panel1.Size = new Size(249, 110);
            panel1.TabIndex = 42;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI Variable Small", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(3, 439);
            button6.Name = "button6";
            button6.Size = new Size(249, 45);
            button6.TabIndex = 43;
            button6.Text = "       Settings";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = true;
            // 
            // SiderBarTimer
            // 
            SiderBarTimer.Interval = 1;
            SiderBarTimer.Tick += SideBarTimer_Tick;
            // 
            // BtnPercent
            // 
            BtnPercent.BackColor = SystemColors.InactiveBorder;
            BtnPercent.Font = new Font("Segoe UI Variable Text Semiligh", 12F);
            BtnPercent.ForeColor = SystemColors.ControlText;
            BtnPercent.Location = new Point(4, 184);
            BtnPercent.Name = "BtnPercent";
            BtnPercent.Size = new Size(75, 51);
            BtnPercent.TabIndex = 0;
            BtnPercent.Text = "%";
            BtnPercent.UseVisualStyleBackColor = false;
            BtnPercent.Click += BtnPercent_Click;
            // 
            // BtnCE
            // 
            BtnCE.BackColor = SystemColors.InactiveBorder;
            BtnCE.Font = new Font("Segoe UI Variable Text Semiligh", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnCE.Location = new Point(79, 184);
            BtnCE.Name = "BtnCE";
            BtnCE.Size = new Size(75, 51);
            BtnCE.TabIndex = 1;
            BtnCE.Text = "CE";
            BtnCE.UseVisualStyleBackColor = false;
            BtnCE.Click += BtnCE_Click;
            // 
            // BtnC
            // 
            BtnC.BackColor = SystemColors.InactiveBorder;
            BtnC.Font = new Font("Segoe UI Variable Text Semiligh", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnC.Location = new Point(154, 184);
            BtnC.Name = "BtnC";
            BtnC.Size = new Size(75, 51);
            BtnC.TabIndex = 2;
            BtnC.Text = "C";
            BtnC.UseVisualStyleBackColor = false;
            BtnC.Click += BtnC_Click;
            // 
            // BtnFrac
            // 
            BtnFrac.BackColor = SystemColors.InactiveBorder;
            BtnFrac.Font = new Font("Segoe UI Symbol", 12F);
            BtnFrac.Location = new Point(4, 235);
            BtnFrac.Name = "BtnFrac";
            BtnFrac.Size = new Size(75, 51);
            BtnFrac.TabIndex = 4;
            BtnFrac.Text = "⅟x";
            BtnFrac.UseVisualStyleBackColor = false;
            BtnFrac.Click += BtnFrac_Click;
            // 
            // BtnSqre
            // 
            BtnSqre.BackColor = SystemColors.InactiveBorder;
            BtnSqre.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSqre.Location = new Point(79, 235);
            BtnSqre.Name = "BtnSqre";
            BtnSqre.Size = new Size(75, 51);
            BtnSqre.TabIndex = 5;
            BtnSqre.Text = "x²";
            BtnSqre.UseVisualStyleBackColor = false;
            BtnSqre.Click += BtnSqre_Click;
            // 
            // BtnSqrt
            // 
            BtnSqrt.BackColor = SystemColors.InactiveBorder;
            BtnSqrt.Font = new Font("Segoe UI Symbol", 12F);
            BtnSqrt.Location = new Point(154, 235);
            BtnSqrt.Name = "BtnSqrt";
            BtnSqrt.Size = new Size(75, 51);
            BtnSqrt.TabIndex = 6;
            BtnSqrt.Text = "√x";
            BtnSqrt.UseVisualStyleBackColor = false;
            BtnSqrt.Click += BtnSqrt_Click;
            // 
            // BtnNum7
            // 
            BtnNum7.Font = new Font("Segoe UI Variable Text", 14F);
            BtnNum7.Location = new Point(4, 286);
            BtnNum7.Name = "BtnNum7";
            BtnNum7.Size = new Size(75, 51);
            BtnNum7.TabIndex = 8;
            BtnNum7.Text = "7";
            BtnNum7.UseVisualStyleBackColor = true;
            BtnNum7.Click += BtnNum7_Click;
            // 
            // BtnNum8
            // 
            BtnNum8.Font = new Font("Segoe UI Variable Text", 14F);
            BtnNum8.Location = new Point(79, 286);
            BtnNum8.Name = "BtnNum8";
            BtnNum8.Size = new Size(75, 51);
            BtnNum8.TabIndex = 9;
            BtnNum8.Text = "8";
            BtnNum8.UseVisualStyleBackColor = true;
            BtnNum8.Click += BtnNum8_Click;
            // 
            // BtnNum9
            // 
            BtnNum9.BackColor = SystemColors.ControlLightLight;
            BtnNum9.Font = new Font("Segoe UI Variable Text", 14F);
            BtnNum9.Location = new Point(154, 286);
            BtnNum9.Name = "BtnNum9";
            BtnNum9.Size = new Size(75, 51);
            BtnNum9.TabIndex = 10;
            BtnNum9.Text = "9";
            BtnNum9.UseVisualStyleBackColor = false;
            BtnNum9.Click += BtnNum9_Click;
            // 
            // BtnNum4
            // 
            BtnNum4.Font = new Font("Segoe UI Variable Text", 14F);
            BtnNum4.Location = new Point(4, 337);
            BtnNum4.Name = "BtnNum4";
            BtnNum4.Size = new Size(75, 51);
            BtnNum4.TabIndex = 12;
            BtnNum4.Text = "4";
            BtnNum4.UseVisualStyleBackColor = true;
            BtnNum4.Click += BtnNum4_Click;
            // 
            // BtnNum5
            // 
            BtnNum5.Font = new Font("Segoe UI Variable Text", 14F);
            BtnNum5.Location = new Point(79, 337);
            BtnNum5.Name = "BtnNum5";
            BtnNum5.Size = new Size(75, 51);
            BtnNum5.TabIndex = 13;
            BtnNum5.Text = "5";
            BtnNum5.UseVisualStyleBackColor = true;
            BtnNum5.Click += BtnNum5_Click;
            // 
            // BtnNum6
            // 
            BtnNum6.Font = new Font("Segoe UI Variable Text", 14F);
            BtnNum6.Location = new Point(154, 337);
            BtnNum6.Name = "BtnNum6";
            BtnNum6.Size = new Size(75, 51);
            BtnNum6.TabIndex = 14;
            BtnNum6.Text = "6";
            BtnNum6.UseVisualStyleBackColor = true;
            BtnNum6.Click += BtnNum6_Click;
            // 
            // BtnNum1
            // 
            BtnNum1.Font = new Font("Segoe UI Variable Text", 14F);
            BtnNum1.Location = new Point(4, 388);
            BtnNum1.Name = "BtnNum1";
            BtnNum1.Size = new Size(75, 51);
            BtnNum1.TabIndex = 16;
            BtnNum1.Text = "1";
            BtnNum1.UseVisualStyleBackColor = true;
            BtnNum1.Click += BtnNum1_Click;
            // 
            // BtnNum2
            // 
            BtnNum2.Font = new Font("Segoe UI Variable Text", 14F);
            BtnNum2.Location = new Point(79, 388);
            BtnNum2.Name = "BtnNum2";
            BtnNum2.Size = new Size(75, 51);
            BtnNum2.TabIndex = 17;
            BtnNum2.Text = "2";
            BtnNum2.UseVisualStyleBackColor = true;
            BtnNum2.Click += BtnNum2_Click;
            // 
            // BtnNum3
            // 
            BtnNum3.Font = new Font("Segoe UI Variable Text", 14F);
            BtnNum3.Location = new Point(154, 388);
            BtnNum3.Name = "BtnNum3";
            BtnNum3.Size = new Size(75, 51);
            BtnNum3.TabIndex = 18;
            BtnNum3.Text = "3";
            BtnNum3.UseVisualStyleBackColor = true;
            BtnNum3.Click += BtnNum3_Click;
            // 
            // BtnNegate
            // 
            BtnNegate.Font = new Font("Segoe UI", 15F);
            BtnNegate.Location = new Point(4, 439);
            BtnNegate.Name = "BtnNegate";
            BtnNegate.Size = new Size(75, 51);
            BtnNegate.TabIndex = 20;
            BtnNegate.Text = "±";
            BtnNegate.UseVisualStyleBackColor = true;
            BtnNegate.Click += BtnNegate_Click;
            // 
            // BtnNum0
            // 
            BtnNum0.Font = new Font("Segoe UI Variable Text", 14F);
            BtnNum0.Location = new Point(79, 439);
            BtnNum0.Name = "BtnNum0";
            BtnNum0.Size = new Size(75, 51);
            BtnNum0.TabIndex = 21;
            BtnNum0.Text = "0";
            BtnNum0.UseVisualStyleBackColor = true;
            BtnNum0.Click += BtnNum0_Click;
            // 
            // BtnDecimal
            // 
            BtnDecimal.Font = new Font("Segoe UI", 15F);
            BtnDecimal.Location = new Point(154, 439);
            BtnDecimal.Name = "BtnDecimal";
            BtnDecimal.Size = new Size(75, 51);
            BtnDecimal.TabIndex = 22;
            BtnDecimal.Text = ".";
            BtnDecimal.UseVisualStyleBackColor = true;
            BtnDecimal.Click += BtnDecimal_Click;
            // 
            // button25
            // 
            button25.Enabled = false;
            button25.FlatAppearance.BorderColor = Color.White;
            button25.FlatAppearance.BorderSize = 0;
            button25.FlatStyle = FlatStyle.Flat;
            button25.ForeColor = SystemColors.ControlDark;
            button25.Location = new Point(7, 151);
            button25.Name = "button25";
            button25.Size = new Size(49, 27);
            button25.TabIndex = 24;
            button25.Text = "MC";
            button25.UseVisualStyleBackColor = true;
            // 
            // button26
            // 
            button26.Enabled = false;
            button26.FlatAppearance.BorderColor = Color.White;
            button26.FlatAppearance.BorderSize = 0;
            button26.FlatStyle = FlatStyle.Flat;
            button26.ForeColor = SystemColors.ControlDark;
            button26.Location = new Point(56, 151);
            button26.Name = "button26";
            button26.Size = new Size(49, 27);
            button26.TabIndex = 25;
            button26.Text = "MR";
            button26.UseVisualStyleBackColor = true;
            // 
            // button27
            // 
            button27.FlatAppearance.BorderColor = Color.White;
            button27.FlatAppearance.BorderSize = 0;
            button27.FlatStyle = FlatStyle.Flat;
            button27.Location = new Point(203, 151);
            button27.Name = "button27";
            button27.Size = new Size(49, 27);
            button27.TabIndex = 26;
            button27.Text = "MS";
            button27.UseVisualStyleBackColor = true;
            // 
            // button28
            // 
            button28.BackgroundImageLayout = ImageLayout.None;
            button28.FlatAppearance.BorderColor = Color.White;
            button28.FlatAppearance.BorderSize = 0;
            button28.FlatStyle = FlatStyle.Flat;
            button28.ImageAlign = ContentAlignment.BottomCenter;
            button28.Location = new Point(105, 151);
            button28.Name = "button28";
            button28.Size = new Size(49, 27);
            button28.TabIndex = 27;
            button28.Text = "M+";
            button28.UseVisualStyleBackColor = true;
            // 
            // button29
            // 
            button29.FlatAppearance.BorderColor = Color.White;
            button29.FlatAppearance.BorderSize = 0;
            button29.FlatStyle = FlatStyle.Flat;
            button29.Location = new Point(154, 151);
            button29.Name = "button29";
            button29.Size = new Size(49, 27);
            button29.TabIndex = 28;
            button29.Text = "M-";
            button29.UseVisualStyleBackColor = true;
            // 
            // button30
            // 
            button30.Enabled = false;
            button30.FlatAppearance.BorderColor = Color.White;
            button30.FlatAppearance.BorderSize = 0;
            button30.FlatStyle = FlatStyle.Flat;
            button30.ForeColor = SystemColors.ControlDark;
            button30.Location = new Point(252, 151);
            button30.Name = "button30";
            button30.Size = new Size(49, 27);
            button30.TabIndex = 29;
            button30.Text = "M⏷";
            button30.UseVisualStyleBackColor = true;
            // 
            // HistoryBar
            // 
            HistoryBar.BackColor = Color.GhostWhite;
            HistoryBar.Controls.Add(panel3);
            HistoryBar.Controls.Add(NoHistLbl);
            HistoryBar.Controls.Add(panel4);
            HistoryBar.Dock = DockStyle.Bottom;
            HistoryBar.Location = new Point(0, 494);
            HistoryBar.MaximumSize = new Size(307, 310);
            HistoryBar.MinimumSize = new Size(307, 0);
            HistoryBar.Name = "HistoryBar";
            HistoryBar.Size = new Size(307, 0);
            HistoryBar.TabIndex = 36;
            // 
            // panel3
            // 
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(306, 5);
            panel3.TabIndex = 0;
            // 
            // NoHistLbl
            // 
            NoHistLbl.AutoSize = true;
            NoHistLbl.Font = new Font("Segoe UI", 10F);
            NoHistLbl.Location = new Point(3, 11);
            NoHistLbl.Name = "NoHistLbl";
            NoHistLbl.Size = new Size(153, 19);
            NoHistLbl.TabIndex = 1;
            NoHistLbl.Text = "  There's No History Yet";
            // 
            // panel4
            // 
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(3, 33);
            panel4.Name = "panel4";
            panel4.Size = new Size(305, 64);
            panel4.TabIndex = 2;
            // 
            // label4
            // 
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 0;
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 1;
            // 
            // HistoryBarTimer
            // 
            HistoryBarTimer.Interval = 1;
            HistoryBarTimer.Tick += HistoryBarTimer_Tick;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(308, 494);
            Controls.Add(HistoryBar);
            Controls.Add(SideBar);
            Controls.Add(MainMenuBtn);
            Controls.Add(label1);
            Controls.Add(RcntHistBtn);
            Controls.Add(TxtRcnt);
            Controls.Add(TxtMain);
            Controls.Add(button30);
            Controls.Add(button29);
            Controls.Add(button28);
            Controls.Add(button27);
            Controls.Add(button26);
            Controls.Add(button25);
            Controls.Add(BtnEqual);
            Controls.Add(BtnDecimal);
            Controls.Add(BtnNum0);
            Controls.Add(BtnNegate);
            Controls.Add(BtnPlus);
            Controls.Add(BtnNum3);
            Controls.Add(BtnNum2);
            Controls.Add(BtnNum1);
            Controls.Add(BtnMinus);
            Controls.Add(BtnNum6);
            Controls.Add(BtnNum5);
            Controls.Add(BtnNum4);
            Controls.Add(BtnMultiply);
            Controls.Add(BtnNum9);
            Controls.Add(BtnNum8);
            Controls.Add(BtnNum7);
            Controls.Add(BtnDivide);
            Controls.Add(BtnSqrt);
            Controls.Add(BtnSqre);
            Controls.Add(BtnFrac);
            Controls.Add(BtnBack);
            Controls.Add(BtnC);
            Controls.Add(BtnCE);
            Controls.Add(BtnPercent);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(324, 533);
            Name = "Calculator";
            Text = "Calculator";
            SideBar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            HistoryBar.ResumeLayout(false);
            HistoryBar.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BtnBack;
        private Button BtnDivide;
        private Button BtnMultiply;
        private Button BtnMinus;
        private Button BtnPlus;
        private Button BtnEqual;
        private TextBox TxtMain;
        private TextBox TxtRcnt;
        private Button RcntHistBtn;
        private Label label1;
        private Button MainMenuBtn;
        private FlowLayoutPanel SideBar;
        private Button button1;
        private Panel panel2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button MenuBtn;
        private TextBox textBox1;
        private System.Windows.Forms.Timer SiderBarTimer;
        private Panel panel1;
        private Button button6;
        private Button BtnPercent;
        private Button BtnCE;
        private Button BtnC;
        private Button BtnFrac;
        private Button BtnSqre;
        private Button BtnSqrt;
        private Button BtnNum7;
        private Button BtnNum8;
        private Button BtnNum9;
        private Button BtnNum4;
        private Button BtnNum5;
        private Button BtnNum6;
        private Button BtnNum1;
        private Button BtnNum2;
        private Button BtnNum3;
        private Button BtnNegate;
        private Button BtnNum0;
        private Button BtnDecimal;
        private Button button25;
        private Button button26;
        private Button button27;
        private Button button28;
        private Button button29;
        private Button button30;
        private FlowLayoutPanel HistoryBar;
        private System.Windows.Forms.Timer HistoryBarTimer;
        private Panel panel3;
        private Label NoHistLbl;
        private Panel panel4;
        private Label label4;
        private Label label3;
    }
}
