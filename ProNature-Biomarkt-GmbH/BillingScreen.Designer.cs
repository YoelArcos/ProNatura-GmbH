namespace ProNature_Biomarkt_GmbH
{
    partial class BillingScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillingScreen));
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.dataGridViewBilling = new System.Windows.Forms.DataGridView();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnClearField = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.textBoxCustomerAdress = new System.Windows.Forms.TextBox();
            this.lblCustomerAdress = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCustomerBillingPrice = new System.Windows.Forms.TextBox();
            this.btnBackToMainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBilling)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(123, 12);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(221, 22);
            this.textBoxCustomerName.TabIndex = 0;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.ForeColor = System.Drawing.Color.White;
            this.lblCustomerName.Location = new System.Drawing.Point(12, 18);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(60, 16);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Namen:";
            // 
            // dataGridViewBilling
            // 
            this.dataGridViewBilling.AllowUserToAddRows = false;
            this.dataGridViewBilling.AllowUserToDeleteRows = false;
            this.dataGridViewBilling.AllowUserToResizeColumns = false;
            this.dataGridViewBilling.AllowUserToResizeRows = false;
            this.dataGridViewBilling.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewBilling.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewBilling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBilling.Location = new System.Drawing.Point(12, 160);
            this.dataGridViewBilling.MultiSelect = false;
            this.dataGridViewBilling.Name = "dataGridViewBilling";
            this.dataGridViewBilling.ReadOnly = true;
            this.dataGridViewBilling.RowHeadersWidth = 51;
            this.dataGridViewBilling.RowTemplate.Height = 24;
            this.dataGridViewBilling.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBilling.Size = new System.Drawing.Size(776, 278);
            this.dataGridViewBilling.TabIndex = 13;
            this.dataGridViewBilling.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBilling_CellContentClick);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(78, 121);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(101, 23);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Erstellen";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnClearField
            // 
            this.btnClearField.Location = new System.Drawing.Point(292, 121);
            this.btnClearField.Name = "btnClearField";
            this.btnClearField.Size = new System.Drawing.Size(97, 23);
            this.btnClearField.TabIndex = 4;
            this.btnClearField.Text = "Feld leeren";
            this.btnClearField.UseVisualStyleBackColor = true;
            this.btnClearField.Click += new System.EventHandler(this.btnClearField_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(185, 121);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Löschen";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // textBoxCustomerAdress
            // 
            this.textBoxCustomerAdress.Location = new System.Drawing.Point(123, 45);
            this.textBoxCustomerAdress.Name = "textBoxCustomerAdress";
            this.textBoxCustomerAdress.Size = new System.Drawing.Size(221, 22);
            this.textBoxCustomerAdress.TabIndex = 6;
            // 
            // lblCustomerAdress
            // 
            this.lblCustomerAdress.AutoSize = true;
            this.lblCustomerAdress.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerAdress.ForeColor = System.Drawing.Color.White;
            this.lblCustomerAdress.Location = new System.Drawing.Point(12, 48);
            this.lblCustomerAdress.Name = "lblCustomerAdress";
            this.lblCustomerAdress.Size = new System.Drawing.Size(69, 16);
            this.lblCustomerAdress.TabIndex = 7;
            this.lblCustomerAdress.Text = "Adresse:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Einkaufspreis:";
            // 
            // textBoxCustomerBillingPrice
            // 
            this.textBoxCustomerBillingPrice.Location = new System.Drawing.Point(123, 78);
            this.textBoxCustomerBillingPrice.Name = "textBoxCustomerBillingPrice";
            this.textBoxCustomerBillingPrice.Size = new System.Drawing.Size(221, 22);
            this.textBoxCustomerBillingPrice.TabIndex = 9;
            // 
            // btnBackToMainMenu
            // 
            this.btnBackToMainMenu.Location = new System.Drawing.Point(601, 18);
            this.btnBackToMainMenu.Name = "btnBackToMainMenu";
            this.btnBackToMainMenu.Size = new System.Drawing.Size(157, 49);
            this.btnBackToMainMenu.TabIndex = 10;
            this.btnBackToMainMenu.Text = "Zurück zum Hauptmenü";
            this.btnBackToMainMenu.UseVisualStyleBackColor = true;
            this.btnBackToMainMenu.Click += new System.EventHandler(this.btnBackToMainMenu_Click);
            // 
            // BillingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackToMainMenu);
            this.Controls.Add(this.textBoxCustomerBillingPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCustomerAdress);
            this.Controls.Add(this.textBoxCustomerAdress);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClearField);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dataGridViewBilling);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.textBoxCustomerName);
            this.Name = "BillingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BillingScreen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBilling)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.DataGridView dataGridViewBilling;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnClearField;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox textBoxCustomerAdress;
        private System.Windows.Forms.Label lblCustomerAdress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCustomerBillingPrice;
        private System.Windows.Forms.Button btnBackToMainMenu;
    }
}