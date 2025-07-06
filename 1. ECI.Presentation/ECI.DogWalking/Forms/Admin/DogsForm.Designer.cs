namespace ECI.DogWalking.Forms.Admin
{
    partial class DogsForm
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
            panel1 = new Panel();
            dgDogs = new DataGridView();
            panel2 = new Panel();
            btnClear = new Button();
            btnAddDog = new Button();
            cbBreed = new ComboBox();
            txtName = new TextBox();
            lblBreed = new Label();
            lblAge = new Label();
            lblName = new Label();
            label1 = new Label();
            nudAge = new NumericUpDown();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgDogs).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAge).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dgDogs);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(303, 282);
            panel1.TabIndex = 0;
            // 
            // dgDogs
            // 
            dgDogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDogs.Location = new Point(15, 43);
            dgDogs.Name = "dgDogs";
            dgDogs.Size = new Size(268, 199);
            dgDogs.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(nudAge);
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(btnAddDog);
            panel2.Controls.Add(cbBreed);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(lblBreed);
            panel2.Controls.Add(lblAge);
            panel2.Controls.Add(lblName);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(347, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(303, 282);
            panel2.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(214, 246);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnAddDog
            // 
            btnAddDog.Location = new Point(22, 246);
            btnAddDog.Name = "btnAddDog";
            btnAddDog.Size = new Size(75, 23);
            btnAddDog.TabIndex = 5;
            btnAddDog.Text = "Add new";
            btnAddDog.UseVisualStyleBackColor = true;
            // 
            // cbBreed
            // 
            cbBreed.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBreed.FormattingEnabled = true;
            cbBreed.Location = new Point(87, 110);
            cbBreed.Name = "cbBreed";
            cbBreed.Size = new Size(202, 23);
            cbBreed.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(87, 65);
            txtName.Name = "txtName";
            txtName.Size = new Size(202, 23);
            txtName.TabIndex = 2;
            // 
            // lblBreed
            // 
            lblBreed.AutoSize = true;
            lblBreed.Location = new Point(22, 113);
            lblBreed.Name = "lblBreed";
            lblBreed.Size = new Size(37, 15);
            lblBreed.TabIndex = 1;
            lblBreed.Text = "Breed";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(22, 156);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(28, 15);
            lblAge.TabIndex = 1;
            lblAge.Text = "Age";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(22, 68);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 18);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 0;
            label1.Text = "Dogs Administration";
            // 
            // nudAge
            // 
            nudAge.Location = new Point(87, 156);
            nudAge.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            nudAge.Name = "nudAge";
            nudAge.Size = new Size(120, 23);
            nudAge.TabIndex = 6;
            // 
            // DogsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 314);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "DogsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DogsForm";
            Load += DogsForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgDogs).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAge).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dgDogs;
        private Label label1;
        private Label lblName;
        private Label lblBreed;
        private Label lblAge;
        private TextBox txtName;
        private ComboBox cbBreed;
        private Button btnAddDog;
        private Button btnClear;
        private NumericUpDown nudAge;
    }
}