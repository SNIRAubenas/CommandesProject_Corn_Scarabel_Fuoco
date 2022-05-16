
namespace CommandesProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grilleInfos = new System.Windows.Forms.DataGridView();
            this.infoBox = new System.Windows.Forms.GroupBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.mailLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.postalCodeLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.adressLabel = new System.Windows.Forms.Label();
            this.phoneNumberBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.countryBox = new System.Windows.Forms.TextBox();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.postalCodeBox = new System.Windows.Forms.TextBox();
            this.adresseBox = new System.Windows.Forms.TextBox();
            this.cmdGrid = new System.Windows.Forms.DataGridView();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grilleInfos)).BeginInit();
            this.infoBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // grilleInfos
            // 
            this.grilleInfos.AllowUserToAddRows = false;
            this.grilleInfos.AllowUserToDeleteRows = false;
            this.grilleInfos.AllowUserToOrderColumns = true;
            this.grilleInfos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilleInfos.Location = new System.Drawing.Point(3, 2);
            this.grilleInfos.Name = "grilleInfos";
            this.grilleInfos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilleInfos.Size = new System.Drawing.Size(359, 446);
            this.grilleInfos.TabIndex = 0;
            this.grilleInfos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilleInfos_CellClick);
            // 
            // infoBox
            // 
            this.infoBox.Controls.Add(this.phoneNumberLabel);
            this.infoBox.Controls.Add(this.mailLabel);
            this.infoBox.Controls.Add(this.countryLabel);
            this.infoBox.Controls.Add(this.postalCodeLabel);
            this.infoBox.Controls.Add(this.cityLabel);
            this.infoBox.Controls.Add(this.adressLabel);
            this.infoBox.Controls.Add(this.phoneNumberBox);
            this.infoBox.Controls.Add(this.EmailBox);
            this.infoBox.Controls.Add(this.countryBox);
            this.infoBox.Controls.Add(this.cityBox);
            this.infoBox.Controls.Add(this.postalCodeBox);
            this.infoBox.Controls.Add(this.adresseBox);
            this.infoBox.Controls.Add(this.cmdGrid);
            this.infoBox.Controls.Add(this.firstNameLabel);
            this.infoBox.Controls.Add(this.nameLabel);
            this.infoBox.Controls.Add(this.firstNameBox);
            this.infoBox.Controls.Add(this.nameBox);
            this.infoBox.Location = new System.Drawing.Point(368, 2);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(433, 446);
            this.infoBox.TabIndex = 1;
            this.infoBox.TabStop = false;
            this.infoBox.Text = "Informations";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.Location = new System.Drawing.Point(264, 181);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(100, 15);
            this.phoneNumberLabel.TabIndex = 16;
            this.phoneNumberLabel.Text = "N° de téléphone";
            this.phoneNumberLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mailLabel
            // 
            this.mailLabel.Location = new System.Drawing.Point(7, 181);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(100, 15);
            this.mailLabel.TabIndex = 15;
            this.mailLabel.Text = "Adresse Email";
            this.mailLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // countryLabel
            // 
            this.countryLabel.Location = new System.Drawing.Point(264, 135);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(100, 15);
            this.countryLabel.TabIndex = 14;
            this.countryLabel.Text = "Pays";
            this.countryLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // postalCodeLabel
            // 
            this.postalCodeLabel.Location = new System.Drawing.Point(6, 135);
            this.postalCodeLabel.Name = "postalCodeLabel";
            this.postalCodeLabel.Size = new System.Drawing.Size(100, 15);
            this.postalCodeLabel.TabIndex = 13;
            this.postalCodeLabel.Text = "Code Postal";
            this.postalCodeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cityLabel
            // 
            this.cityLabel.Location = new System.Drawing.Point(137, 135);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(100, 15);
            this.cityLabel.TabIndex = 12;
            this.cityLabel.Text = "Ville";
            this.cityLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // adressLabel
            // 
            this.adressLabel.Location = new System.Drawing.Point(21, 90);
            this.adressLabel.Name = "adressLabel";
            this.adressLabel.Size = new System.Drawing.Size(70, 15);
            this.adressLabel.TabIndex = 11;
            this.adressLabel.Text = "Adresse";
            this.adressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phoneNumberBox
            // 
            this.phoneNumberBox.Location = new System.Drawing.Point(264, 199);
            this.phoneNumberBox.Name = "phoneNumberBox";
            this.phoneNumberBox.Size = new System.Drawing.Size(100, 20);
            this.phoneNumberBox.TabIndex = 10;
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(7, 199);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(230, 20);
            this.EmailBox.TabIndex = 9;
            // 
            // countryBox
            // 
            this.countryBox.Location = new System.Drawing.Point(264, 153);
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(100, 20);
            this.countryBox.TabIndex = 8;
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(137, 153);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(100, 20);
            this.cityBox.TabIndex = 7;
            // 
            // postalCodeBox
            // 
            this.postalCodeBox.Location = new System.Drawing.Point(6, 153);
            this.postalCodeBox.Name = "postalCodeBox";
            this.postalCodeBox.Size = new System.Drawing.Size(100, 20);
            this.postalCodeBox.TabIndex = 6;
            // 
            // adresseBox
            // 
            this.adresseBox.Location = new System.Drawing.Point(6, 108);
            this.adresseBox.Name = "adresseBox";
            this.adresseBox.Size = new System.Drawing.Size(358, 20);
            this.adresseBox.TabIndex = 5;
            // 
            // cmdGrid
            // 
            this.cmdGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cmdGrid.Location = new System.Drawing.Point(64, 283);
            this.cmdGrid.Name = "cmdGrid";
            this.cmdGrid.Size = new System.Drawing.Size(356, 153);
            this.cmdGrid.TabIndex = 4;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Location = new System.Drawing.Point(233, 31);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(70, 15);
            this.firstNameLabel.TabIndex = 3;
            this.firstNameLabel.Text = "Prenom";
            this.firstNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(21, 31);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(70, 15);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Nom";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(193, 49);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(171, 20);
            this.firstNameBox.TabIndex = 1;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(6, 49);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(135, 20);
            this.nameBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.grilleInfos);
            this.Name = "Form1";
            this.Text = resources.GetString("$this.Text");
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilleInfos)).EndInit();
            this.infoBox.ResumeLayout(false);
            this.infoBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grilleInfos;
        private System.Windows.Forms.DataGridView cmdGrid;
        
        private System.Windows.Forms.GroupBox infoBox;

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label mailLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label postalCodeLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label adressLabel;

        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox phoneNumberBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox countryBox;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.TextBox postalCodeBox;
        private System.Windows.Forms.TextBox adresseBox;
    }
}

