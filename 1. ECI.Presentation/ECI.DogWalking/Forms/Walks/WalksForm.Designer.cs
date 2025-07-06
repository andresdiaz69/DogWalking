namespace ECI.DogWalking.Forms.Walks
{
    partial class WalksForm
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            btnSearch = new Button();
            lblSearchBy = new Label();
            txtSearch = new TextBox();
            cbFilters = new ComboBox();
            dgWalks = new DataGridView();
            panel2 = new Panel();
            nudDurationWalk = new NumericUpDown();
            dtpDateWalk = new DateTimePicker();
            groupBox1 = new GroupBox();
            cbDog = new ComboBox();
            cbClient = new ComboBox();
            label2 = new Label();
            lblPhone = new Label();
            lblDuration = new Label();
            lblDate = new Label();
            label1 = new Label();
            btnClear = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            errorsWalk = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgWalks).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDurationWalk).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorsWalk).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(lblSearchBy);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(cbFilters);
            panel1.Controls.Add(dgWalks);
            panel1.Location = new Point(12, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(413, 438);
            panel1.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(14, 77);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(187, 23);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblSearchBy
            // 
            lblSearchBy.AutoSize = true;
            lblSearchBy.Location = new Point(16, 19);
            lblSearchBy.Name = "lblSearchBy";
            lblSearchBy.Size = new Size(58, 15);
            lblSearchBy.TabIndex = 8;
            lblSearchBy.Text = "Search By";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(207, 39);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(191, 23);
            txtSearch.TabIndex = 7;
            // 
            // cbFilters
            // 
            cbFilters.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilters.FormattingEnabled = true;
            cbFilters.Location = new Point(14, 39);
            cbFilters.Name = "cbFilters";
            cbFilters.Size = new Size(187, 23);
            cbFilters.TabIndex = 6;
            // 
            // dgWalks
            // 
            dgWalks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgWalks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgWalks.Location = new Point(14, 118);
            dgWalks.Name = "dgWalks";
            dgWalks.Size = new Size(384, 301);
            dgWalks.TabIndex = 5;
            dgWalks.CellClick += dgWalks_CellContentClick;
            dgWalks.CellContentClick += dgWalks_CellContentClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(nudDurationWalk);
            panel2.Controls.Add(dtpDateWalk);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(lblDuration);
            panel2.Controls.Add(lblDate);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnAdd);
            panel2.Location = new Point(461, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(413, 438);
            panel2.TabIndex = 1;
            // 
            // nudDurationWalk
            // 
            nudDurationWalk.Location = new Point(143, 129);
            nudDurationWalk.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            nudDurationWalk.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudDurationWalk.Name = "nudDurationWalk";
            nudDurationWalk.Size = new Size(250, 23);
            nudDurationWalk.TabIndex = 20;
            nudDurationWalk.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dtpDateWalk
            // 
            dtpDateWalk.Location = new Point(140, 67);
            dtpDateWalk.Name = "dtpDateWalk";
            dtpDateWalk.Size = new Size(253, 23);
            dtpDateWalk.TabIndex = 19;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbDog);
            groupBox1.Controls.Add(cbClient);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lblPhone);
            groupBox1.Location = new Point(22, 181);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(388, 139);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dog Info";
            // 
            // cbDog
            // 
            cbDog.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDog.FormattingEnabled = true;
            cbDog.Location = new Point(121, 80);
            cbDog.Name = "cbDog";
            cbDog.Size = new Size(250, 23);
            cbDog.TabIndex = 14;
            // 
            // cbClient
            // 
            cbClient.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClient.FormattingEnabled = true;
            cbClient.Location = new Point(121, 31);
            cbClient.Name = "cbClient";
            cbClient.Size = new Size(250, 23);
            cbClient.TabIndex = 13;
            cbClient.SelectedIndexChanged += cbClients_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 80);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 12;
            label2.Text = "Dog";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(6, 34);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(65, 15);
            lblPhone.TabIndex = 12;
            lblPhone.Text = "Dog owner";
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Location = new Point(22, 129);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(107, 15);
            lblDuration.TabIndex = 13;
            lblDuration.Text = "Duration (minutes)";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(22, 67);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(39, 15);
            lblDate.TabIndex = 14;
            lblDate.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 21);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 10;
            label1.Text = "Walks Administration";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(318, 395);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(170, 395);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(19, 395);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Add new";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // errorsWalk
            // 
            errorsWalk.ContainerControl = this;
            // 
            // WalksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 480);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "WalksForm";
            Text = "WalksForm";
            Activated += WalksForm_Load;
            Load += WalksForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgWalks).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDurationWalk).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorsWalk).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnSearch;
        private Label lblSearchBy;
        private TextBox txtSearch;
        private ComboBox cbFilters;
        private DataGridView dgWalks;
        private Label lblPhone;
        private Label lblDuration;
        private Label lblDate;
        private Label label1;
        private Button btnClear;
        private Button btnAdd;
        private GroupBox groupBox1;
        private Label label2;
        private DateTimePicker dtpDateWalk;
        private NumericUpDown nudDurationWalk;
        private ComboBox cbClient;
        private ComboBox cbDog;
        private Button btnDelete;
        private ErrorProvider errorsWalk;
    }
}