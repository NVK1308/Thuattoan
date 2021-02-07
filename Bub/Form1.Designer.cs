namespace Bub
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tbArrLenght = new System.Windows.Forms.TextBox();
            this.btTaomang = new System.Windows.Forms.Button();
            this.btSort = new System.Windows.Forms.Button();
            this.BackGroundBubbleSort = new System.ComponentModel.BackgroundWorker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.pnMophongBubbleSort = new System.Windows.Forms.Panel();
            this.lbKetqua = new System.Windows.Forms.Label();
            this.lbBul0 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnMpQuickSort = new System.Windows.Forms.Panel();
            this.lbKetquaQ = new System.Windows.Forms.Label();
            this.lbLQuic0 = new System.Windows.Forms.Label();
            this.btTaoMangQuick = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbArrayLeghtQuick = new System.Windows.Forms.TextBox();
            this.btSorttingQuick = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btTrainning = new System.Windows.Forms.Button();
            this.btLoadData = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btCheck = new System.Windows.Forms.Button();
            this.btKetqua = new System.Windows.Forms.Button();
            this.lbRasult = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbFootsize = new System.Windows.Forms.TextBox();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.gridviewdata = new System.Windows.Forms.DataGridView();
            this.gridviewthongtin = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BackGroudQuickSort = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnMophongBubbleSort.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pnMpQuickSort.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewthongtin)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số phần tử";
            // 
            // tbArrLenght
            // 
            this.tbArrLenght.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbArrLenght.Location = new System.Drawing.Point(101, 14);
            this.tbArrLenght.Name = "tbArrLenght";
            this.tbArrLenght.Size = new System.Drawing.Size(100, 26);
            this.tbArrLenght.TabIndex = 1;
            // 
            // btTaomang
            // 
            this.btTaomang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTaomang.Location = new System.Drawing.Point(230, 9);
            this.btTaomang.Name = "btTaomang";
            this.btTaomang.Size = new System.Drawing.Size(108, 35);
            this.btTaomang.TabIndex = 4;
            this.btTaomang.Text = "Vẽ mảng";
            this.btTaomang.UseVisualStyleBackColor = true;
            this.btTaomang.Click += new System.EventHandler(this.btTaomang_Click);
            // 
            // btSort
            // 
            this.btSort.Enabled = false;
            this.btSort.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSort.Location = new System.Drawing.Point(361, 9);
            this.btSort.Name = "btSort";
            this.btSort.Size = new System.Drawing.Size(108, 35);
            this.btSort.TabIndex = 5;
            this.btSort.Text = "Sắp xếp";
            this.btSort.UseVisualStyleBackColor = true;
            this.btSort.Click += new System.EventHandler(this.btSort_Click);
            // 
            // BackGroundBubbleSort
            // 
            this.BackGroundBubbleSort.WorkerReportsProgress = true;
            this.BackGroundBubbleSort.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.BackGroundBubbleSort.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.BackGroundBubbleSort.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 171);
            this.tabControl1.MinimumSize = new System.Drawing.Size(975, 327);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(975, 371);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.pnMophongBubbleSort);
            this.tabPage1.Controls.Add(this.btTaomang);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbArrLenght);
            this.tabPage1.Controls.Add(this.btSort);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(967, 337);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thuật toán Bubble Sort";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(510, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(337, 30);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnMophongBubbleSort
            // 
            this.pnMophongBubbleSort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnMophongBubbleSort.AutoScroll = true;
            this.pnMophongBubbleSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(229)))), ((int)(((byte)(230)))));
            this.pnMophongBubbleSort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnMophongBubbleSort.Controls.Add(this.lbKetqua);
            this.pnMophongBubbleSort.Controls.Add(this.lbBul0);
            this.pnMophongBubbleSort.Location = new System.Drawing.Point(3, 47);
            this.pnMophongBubbleSort.MinimumSize = new System.Drawing.Size(961, 287);
            this.pnMophongBubbleSort.Name = "pnMophongBubbleSort";
            this.pnMophongBubbleSort.Size = new System.Drawing.Size(961, 287);
            this.pnMophongBubbleSort.TabIndex = 11;
            // 
            // lbKetqua
            // 
            this.lbKetqua.AutoSize = true;
            this.lbKetqua.Location = new System.Drawing.Point(4, 167);
            this.lbKetqua.Name = "lbKetqua";
            this.lbKetqua.Size = new System.Drawing.Size(130, 21);
            this.lbKetqua.TabIndex = 0;
            this.lbKetqua.Text = "Kết quả sắp xếp:";
            this.lbKetqua.Visible = false;
            // 
            // lbBul0
            // 
            this.lbBul0.AutoSize = true;
            this.lbBul0.Location = new System.Drawing.Point(4, 40);
            this.lbBul0.Name = "lbBul0";
            this.lbBul0.Size = new System.Drawing.Size(121, 21);
            this.lbBul0.TabIndex = 0;
            this.lbBul0.Text = "Mảng đầu vào: ";
            this.lbBul0.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pnMpQuickSort);
            this.tabPage2.Controls.Add(this.btTaoMangQuick);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.tbArrayLeghtQuick);
            this.tabPage2.Controls.Add(this.btSorttingQuick);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(967, 337);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thuật toán Quick Sort";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnMpQuickSort
            // 
            this.pnMpQuickSort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnMpQuickSort.AutoScroll = true;
            this.pnMpQuickSort.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnMpQuickSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(229)))), ((int)(((byte)(230)))));
            this.pnMpQuickSort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnMpQuickSort.Controls.Add(this.lbKetquaQ);
            this.pnMpQuickSort.Controls.Add(this.lbLQuic0);
            this.pnMpQuickSort.Location = new System.Drawing.Point(3, 47);
            this.pnMpQuickSort.MinimumSize = new System.Drawing.Size(961, 287);
            this.pnMpQuickSort.Name = "pnMpQuickSort";
            this.pnMpQuickSort.Size = new System.Drawing.Size(961, 287);
            this.pnMpQuickSort.TabIndex = 16;
            // 
            // lbKetquaQ
            // 
            this.lbKetquaQ.AutoSize = true;
            this.lbKetquaQ.Location = new System.Drawing.Point(4, 166);
            this.lbKetquaQ.Name = "lbKetquaQ";
            this.lbKetquaQ.Size = new System.Drawing.Size(130, 21);
            this.lbKetquaQ.TabIndex = 1;
            this.lbKetquaQ.Text = "Kết quả sắp xếp:";
            this.lbKetquaQ.Visible = false;
            // 
            // lbLQuic0
            // 
            this.lbLQuic0.AutoSize = true;
            this.lbLQuic0.Location = new System.Drawing.Point(4, 40);
            this.lbLQuic0.Name = "lbLQuic0";
            this.lbLQuic0.Size = new System.Drawing.Size(121, 21);
            this.lbLQuic0.TabIndex = 2;
            this.lbLQuic0.Text = "Mảng đầu vào: ";
            this.lbLQuic0.Visible = false;
            // 
            // btTaoMangQuick
            // 
            this.btTaoMangQuick.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTaoMangQuick.Location = new System.Drawing.Point(230, 6);
            this.btTaoMangQuick.Name = "btTaoMangQuick";
            this.btTaoMangQuick.Size = new System.Drawing.Size(108, 35);
            this.btTaoMangQuick.TabIndex = 14;
            this.btTaoMangQuick.Text = "Vẽ mảng";
            this.btTaoMangQuick.UseVisualStyleBackColor = true;
            this.btTaoMangQuick.Click += new System.EventHandler(this.btTaoMangQuick_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Số phần tử";
            // 
            // tbArrayLeghtQuick
            // 
            this.tbArrayLeghtQuick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbArrayLeghtQuick.Location = new System.Drawing.Point(101, 11);
            this.tbArrayLeghtQuick.Name = "tbArrayLeghtQuick";
            this.tbArrayLeghtQuick.Size = new System.Drawing.Size(100, 26);
            this.tbArrayLeghtQuick.TabIndex = 13;
            // 
            // btSorttingQuick
            // 
            this.btSorttingQuick.Enabled = false;
            this.btSorttingQuick.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSorttingQuick.Location = new System.Drawing.Point(361, 6);
            this.btSorttingQuick.Name = "btSorttingQuick";
            this.btSorttingQuick.Size = new System.Drawing.Size(108, 35);
            this.btSorttingQuick.TabIndex = 15;
            this.btSorttingQuick.Text = "Sắp xếp";
            this.btSorttingQuick.UseVisualStyleBackColor = true;
            this.btSorttingQuick.Click += new System.EventHandler(this.btSorttingQuick_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(967, 337);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Thuật toán Naive Bayes";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoScroll = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(229)))), ((int)(((byte)(230)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btTrainning);
            this.panel3.Controls.Add(this.btLoadData);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.gridviewdata);
            this.panel3.Controls.Add(this.gridviewthongtin);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(3, 6);
            this.panel3.MinimumSize = new System.Drawing.Size(961, 328);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(961, 328);
            this.panel3.TabIndex = 17;
            // 
            // btTrainning
            // 
            this.btTrainning.Enabled = false;
            this.btTrainning.Location = new System.Drawing.Point(269, 291);
            this.btTrainning.Name = "btTrainning";
            this.btTrainning.Size = new System.Drawing.Size(238, 34);
            this.btTrainning.TabIndex = 11;
            this.btTrainning.Text = "Trainning Data";
            this.btTrainning.UseVisualStyleBackColor = true;
            this.btTrainning.Click += new System.EventHandler(this.btTrainning_Click);
            // 
            // btLoadData
            // 
            this.btLoadData.Location = new System.Drawing.Point(72, 291);
            this.btLoadData.Name = "btLoadData";
            this.btLoadData.Size = new System.Drawing.Size(191, 34);
            this.btLoadData.TabIndex = 11;
            this.btLoadData.Text = "Load dữ liệu đầu vào";
            this.btLoadData.UseVisualStyleBackColor = true;
            this.btLoadData.Click += new System.EventHandler(this.btLoadData_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btCheck);
            this.groupBox2.Controls.Add(this.btKetqua);
            this.groupBox2.Controls.Add(this.lbRasult);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tbFootsize);
            this.groupBox2.Controls.Add(this.tbWeight);
            this.groupBox2.Controls.Add(this.tbHeight);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Location = new System.Drawing.Point(567, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 319);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // btCheck
            // 
            this.btCheck.Enabled = false;
            this.btCheck.Location = new System.Drawing.Point(16, 284);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(362, 34);
            this.btCheck.TabIndex = 20;
            this.btCheck.Text = "Kiểm tra";
            this.btCheck.UseVisualStyleBackColor = true;
            this.btCheck.Click += new System.EventHandler(this.btCheck_Click);
            // 
            // btKetqua
            // 
            this.btKetqua.BackColor = System.Drawing.Color.Transparent;
            this.btKetqua.BackgroundImage = global::Bub.Properties.Resources.sex;
            this.btKetqua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btKetqua.FlatAppearance.BorderSize = 0;
            this.btKetqua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btKetqua.Location = new System.Drawing.Point(248, 98);
            this.btKetqua.Name = "btKetqua";
            this.btKetqua.Size = new System.Drawing.Size(130, 108);
            this.btKetqua.TabIndex = 19;
            this.btKetqua.UseVisualStyleBackColor = false;
            // 
            // lbRasult
            // 
            this.lbRasult.AutoSize = true;
            this.lbRasult.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRasult.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbRasult.Location = new System.Drawing.Point(318, 211);
            this.lbRasult.Name = "lbRasult";
            this.lbRasult.Size = new System.Drawing.Size(0, 30);
            this.lbRasult.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(244, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 21);
            this.label9.TabIndex = 18;
            this.label9.Text = "Kết quả: ";
            // 
            // tbFootsize
            // 
            this.tbFootsize.Location = new System.Drawing.Point(78, 181);
            this.tbFootsize.Name = "tbFootsize";
            this.tbFootsize.Size = new System.Drawing.Size(81, 29);
            this.tbFootsize.TabIndex = 16;
            this.tbFootsize.TextChanged += new System.EventHandler(this.tbHeight_TextChanged);
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(78, 142);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(81, 29);
            this.tbWeight.TabIndex = 9;
            this.tbWeight.TextChanged += new System.EventHandler(this.tbHeight_TextChanged);
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(78, 103);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(81, 29);
            this.tbHeight.TabIndex = 7;
            this.tbHeight.TextChanged += new System.EventHandler(this.tbHeight_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(178, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "inches";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(178, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 21);
            this.label10.TabIndex = 11;
            this.label10.Text = "lbs";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 21);
            this.label11.TabIndex = 12;
            this.label11.Text = "FootSize";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(178, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 21);
            this.label12.TabIndex = 13;
            this.label12.Text = "feet";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 145);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 21);
            this.label13.TabIndex = 14;
            this.label13.Text = "Weight";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 106);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 21);
            this.label14.TabIndex = 15;
            this.label14.Text = "Height";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(93, 25);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(242, 37);
            this.label15.TabIndex = 8;
            this.label15.Text = "Dự đoán Giới tính ";
            // 
            // gridviewdata
            // 
            this.gridviewdata.AllowDrop = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(207)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridviewdata.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridviewdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewdata.Location = new System.Drawing.Point(11, 28);
            this.gridviewdata.Name = "gridviewdata";
            this.gridviewdata.Size = new System.Drawing.Size(550, 108);
            this.gridviewdata.TabIndex = 9;
            // 
            // gridviewthongtin
            // 
            this.gridviewthongtin.AllowDrop = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(207)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridviewthongtin.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridviewthongtin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewthongtin.Location = new System.Drawing.Point(8, 177);
            this.gridviewthongtin.Name = "gridviewthongtin";
            this.gridviewthongtin.Size = new System.Drawing.Size(550, 112);
            this.gridviewthongtin.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Bảng dữ liệu đầu vào";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "Bảng kết quả tính toán ";
            // 
            // BackGroudQuickSort
            // 
            this.BackGroudQuickSort.WorkerReportsProgress = true;
            this.BackGroudQuickSort.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackGroudQuickSort_DoWork);
            this.BackGroudQuickSort.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackGroudQuickSort_ProgressChanged);
            this.BackGroudQuickSort.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackGroudQuickSort_RunWorkerCompleted);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.MinimumSize = new System.Drawing.Size(975, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(975, 165);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Bub.Properties.Resources.algorithm;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 146);
            this.panel2.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Location = new System.Drawing.Point(355, 63);
            this.panel1.MaximumSize = new System.Drawing.Size(341, 3);
            this.panel1.MinimumSize = new System.Drawing.Size(341, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 3);
            this.panel1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(439, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 47);
            this.label5.TabIndex = 9;
            this.label5.Text = "Thuật toán";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 539);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 578);
            this.MinimumSize = new System.Drawing.Size(995, 535);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đồ án môn thuật toán";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.pnMophongBubbleSort.ResumeLayout(false);
            this.pnMophongBubbleSort.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.pnMpQuickSort.ResumeLayout(false);
            this.pnMpQuickSort.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewthongtin)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbArrLenght;
        private System.Windows.Forms.Button btTaomang;
        private System.Windows.Forms.Button btSort;
        private System.ComponentModel.BackgroundWorker BackGroundBubbleSort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel pnMophongBubbleSort;
        private System.Windows.Forms.TabPage tabPage2;
        private System.ComponentModel.BackgroundWorker BackGroudQuickSort;
        private System.Windows.Forms.Panel pnMpQuickSort;
        private System.Windows.Forms.Button btTaoMangQuick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbArrayLeghtQuick;
        private System.Windows.Forms.Button btSorttingQuick;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbKetqua;
        private System.Windows.Forms.Label lbBul0;
        private System.Windows.Forms.Label lbKetquaQ;
        private System.Windows.Forms.Label lbLQuic0;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView gridviewthongtin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView gridviewdata;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btCheck;
        private System.Windows.Forms.Button btKetqua;
        private System.Windows.Forms.Label lbRasult;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbFootsize;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btTrainning;
        private System.Windows.Forms.Button btLoadData;
        private System.Windows.Forms.Button button1;
    }
}

