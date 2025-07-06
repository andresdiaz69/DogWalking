namespace ECI.DogWalking.Forms.Admin
{
    partial class ClientsForm
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
            dgClients = new DataGridView();
            panel2 = new Panel();
            lblPhone = new Label();
            lblLast = new Label();
            lblName = new Label();
            label1 = new Label();
            chActive = new CheckBox();
            txtPhone = new TextBox();
            txtLastName = new TextBox();
            txtName = new TextBox();
            btnClear = new Button();
            btnAddDogs = new Button();
            btnAdd = new Button();
            errorsClient = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgClients).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorsClient).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(lblSearchBy);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(cbFilters);
            panel1.Controls.Add(dgClients);
            panel1.Location = new Point(12, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(413, 438);
            panel1.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(13, 72);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(187, 23);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblSearchBy
            // 
            lblSearchBy.AutoSize = true;
            lblSearchBy.Location = new Point(15, 14);
            lblSearchBy.Name = "lblSearchBy";
            lblSearchBy.Size = new Size(58, 15);
            lblSearchBy.TabIndex = 3;
            lblSearchBy.Text = "Search By";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(206, 34);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(191, 23);
            txtSearch.TabIndex = 2;
            // 
            // cbFilters
            // 
            cbFilters.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilters.FormattingEnabled = true;
            cbFilters.Location = new Point(13, 34);
            cbFilters.Name = "cbFilters";
            cbFilters.Size = new Size(187, 23);
            cbFilters.TabIndex = 1;
            cbFilters.SelectedIndexChanged += cbFilters_SelectedIndexChanged;
            // 
            // dgClients
            // 
            dgClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgClients.Location = new Point(13, 113);
            dgClients.Name = "dgClients";
            dgClients.Size = new Size(384, 301);
            dgClients.TabIndex = 0;
            dgClients.CellClick += dgClients_CellContentClick;
            dgClients.CellContentClick += dgClients_CellContentClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblPhone);
            panel2.Controls.Add(lblLast);
            panel2.Controls.Add(lblName);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(chActive);
            panel2.Controls.Add(txtPhone);
            panel2.Controls.Add(txtLastName);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(btnAddDogs);
            panel2.Controls.Add(btnAdd);
            panel2.Location = new Point(461, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(413, 438);
            panel2.TabIndex = 3;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(22, 202);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(41, 15);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Phone";
            // 
            // lblLast
            // 
            lblLast.AutoSize = true;
            lblLast.Location = new Point(22, 133);
            lblLast.Name = "lblLast";
            lblLast.Size = new Size(63, 15);
            lblLast.TabIndex = 4;
            lblLast.Text = "Last Name";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(22, 71);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 4;
            lblName.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 25);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 3;
            label1.Text = "Client Administration";
            // 
            // chActive
            // 
            chActive.AutoSize = true;
            chActive.Location = new Point(140, 260);
            chActive.Name = "chActive";
            chActive.Size = new Size(70, 19);
            chActive.TabIndex = 4;
            chActive.Text = "Is Active";
            chActive.UseVisualStyleBackColor = true;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(137, 202);
            txtPhone.MaxLength = 10;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(256, 23);
            txtPhone.TabIndex = 3;
            txtPhone.KeyPress += txtPhone_KeyPress;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(137, 133);
            txtLastName.MaxLength = 30;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(256, 23);
            txtLastName.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(137, 68);
            txtName.MaxLength = 30;
            txtName.Name = "txtName";
            txtName.Size = new Size(256, 23);
            txtName.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(318, 399);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 0;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAddDogs
            // 
            btnAddDogs.Location = new Point(19, 296);
            btnAddDogs.Name = "btnAddDogs";
            btnAddDogs.Size = new Size(112, 23);
            btnAddDogs.TabIndex = 5;
            btnAddDogs.Text = "Manage Dogs";
            btnAddDogs.UseVisualStyleBackColor = true;
            btnAddDogs.Click += btnAddDogs_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(19, 399);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add new";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // errorsClient
            // 
            errorsClient.ContainerControl = this;
            // 
            // ClientsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 480);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "ClientsForm";
            Text = "ClientsForm";
            Activated += ClientsForm_Load;
            Load += ClientsForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgClients).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorsClient).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dgClients;
        private Label lblSearchBy;
        private TextBox txtSearch;
        private ComboBox cbFilters;
        private Button btnSearch;
        private Button btnClear;
        private Button btnAdd;
        private Label label1;
        private CheckBox chActive;
        private TextBox txtPhone;
        private TextBox txtLastName;
        private TextBox txtName;
        private Label lblPhone;
        private Label lblLast;
        private Label lblName;
        private ErrorProvider errorsClient;
        private Button btnAddDogs;
    }
}