
namespace AutoHTML
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
            this.gbxModeDeCreation = new System.Windows.Forms.GroupBox();
            this.rbtnCustom = new System.Windows.Forms.RadioButton();
            this.rbtnBasicMode = new System.Windows.Forms.RadioButton();
            this.gbxDetails = new System.Windows.Forms.GroupBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.gbxCustoms = new System.Windows.Forms.GroupBox();
            this.tbxFolderName = new System.Windows.Forms.TextBox();
            this.chkbFolder = new System.Windows.Forms.CheckBox();
            this.tbxJsName = new System.Windows.Forms.TextBox();
            this.chkbJs = new System.Windows.Forms.CheckBox();
            this.tbxCssName = new System.Windows.Forms.TextBox();
            this.chkbCss = new System.Windows.Forms.CheckBox();
            this.lblNomsFichiers = new System.Windows.Forms.Label();
            this.tbxHtmlName = new System.Windows.Forms.TextBox();
            this.chkbHTML = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNomProjet = new System.Windows.Forms.Label();
            this.tbxNomProjet = new System.Windows.Forms.TextBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.tbxFilePath = new System.Windows.Forms.TextBox();
            this.btnParcourir = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.gbxModeDeCreation.SuspendLayout();
            this.gbxDetails.SuspendLayout();
            this.gbxCustoms.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxModeDeCreation
            // 
            this.gbxModeDeCreation.Controls.Add(this.rbtnCustom);
            this.gbxModeDeCreation.Controls.Add(this.rbtnBasicMode);
            this.gbxModeDeCreation.Location = new System.Drawing.Point(12, 12);
            this.gbxModeDeCreation.Name = "gbxModeDeCreation";
            this.gbxModeDeCreation.Size = new System.Drawing.Size(200, 101);
            this.gbxModeDeCreation.TabIndex = 0;
            this.gbxModeDeCreation.TabStop = false;
            this.gbxModeDeCreation.Text = "Mode de création";
            // 
            // rbtnCustom
            // 
            this.rbtnCustom.AutoSize = true;
            this.rbtnCustom.Location = new System.Drawing.Point(7, 66);
            this.rbtnCustom.Name = "rbtnCustom";
            this.rbtnCustom.Size = new System.Drawing.Size(85, 19);
            this.rbtnCustom.TabIndex = 1;
            this.rbtnCustom.TabStop = true;
            this.rbtnCustom.Text = "Customiser";
            this.rbtnCustom.UseVisualStyleBackColor = true;
            this.rbtnCustom.CheckedChanged += new System.EventHandler(this.rbtnCustom_CheckedChanged);
            // 
            // rbtnBasicMode
            // 
            this.rbtnBasicMode.AutoSize = true;
            this.rbtnBasicMode.Location = new System.Drawing.Point(7, 40);
            this.rbtnBasicMode.Name = "rbtnBasicMode";
            this.rbtnBasicMode.Size = new System.Drawing.Size(87, 19);
            this.rbtnBasicMode.TabIndex = 0;
            this.rbtnBasicMode.TabStop = true;
            this.rbtnBasicMode.Text = "Basic HTML";
            this.rbtnBasicMode.UseVisualStyleBackColor = true;
            this.rbtnBasicMode.CheckedChanged += new System.EventHandler(this.rbtnBasicMode_CheckedChanged);
            // 
            // gbxDetails
            // 
            this.gbxDetails.Controls.Add(this.lblDetails);
            this.gbxDetails.Location = new System.Drawing.Point(219, 13);
            this.gbxDetails.Name = "gbxDetails";
            this.gbxDetails.Size = new System.Drawing.Size(200, 100);
            this.gbxDetails.TabIndex = 1;
            this.gbxDetails.TabStop = false;
            this.gbxDetails.Text = "Détails";
            // 
            // lblDetails
            // 
            this.lblDetails.Location = new System.Drawing.Point(6, 19);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(188, 77);
            this.lblDetails.TabIndex = 0;
            // 
            // gbxCustoms
            // 
            this.gbxCustoms.Controls.Add(this.tbxFolderName);
            this.gbxCustoms.Controls.Add(this.chkbFolder);
            this.gbxCustoms.Controls.Add(this.tbxJsName);
            this.gbxCustoms.Controls.Add(this.chkbJs);
            this.gbxCustoms.Controls.Add(this.tbxCssName);
            this.gbxCustoms.Controls.Add(this.chkbCss);
            this.gbxCustoms.Controls.Add(this.lblNomsFichiers);
            this.gbxCustoms.Controls.Add(this.tbxHtmlName);
            this.gbxCustoms.Controls.Add(this.chkbHTML);
            this.gbxCustoms.Enabled = false;
            this.gbxCustoms.Location = new System.Drawing.Point(12, 162);
            this.gbxCustoms.Name = "gbxCustoms";
            this.gbxCustoms.Size = new System.Drawing.Size(251, 164);
            this.gbxCustoms.TabIndex = 2;
            this.gbxCustoms.TabStop = false;
            this.gbxCustoms.Text = "Customs";
            // 
            // tbxFolderName
            // 
            this.tbxFolderName.Enabled = false;
            this.tbxFolderName.Location = new System.Drawing.Point(130, 129);
            this.tbxFolderName.Name = "tbxFolderName";
            this.tbxFolderName.Size = new System.Drawing.Size(100, 23);
            this.tbxFolderName.TabIndex = 8;
            this.tbxFolderName.TextChanged += new System.EventHandler(this.tbxFolderName_TextChanged);
            // 
            // chkbFolder
            // 
            this.chkbFolder.AutoSize = true;
            this.chkbFolder.Location = new System.Drawing.Point(8, 131);
            this.chkbFolder.Name = "chkbFolder";
            this.chkbFolder.Size = new System.Drawing.Size(63, 19);
            this.chkbFolder.TabIndex = 7;
            this.chkbFolder.Text = "dossier";
            this.chkbFolder.UseVisualStyleBackColor = true;
            this.chkbFolder.CheckedChanged += new System.EventHandler(this.chkbFolder_CheckedChanged);
            // 
            // tbxJsName
            // 
            this.tbxJsName.Enabled = false;
            this.tbxJsName.Location = new System.Drawing.Point(130, 100);
            this.tbxJsName.Name = "tbxJsName";
            this.tbxJsName.Size = new System.Drawing.Size(100, 23);
            this.tbxJsName.TabIndex = 6;
            this.tbxJsName.TextChanged += new System.EventHandler(this.tbxJsName_TextChanged);
            // 
            // chkbJs
            // 
            this.chkbJs.AutoSize = true;
            this.chkbJs.Location = new System.Drawing.Point(8, 102);
            this.chkbJs.Name = "chkbJs";
            this.chkbJs.Size = new System.Drawing.Size(70, 19);
            this.chkbJs.TabIndex = 5;
            this.chkbJs.Text = "fichier js";
            this.chkbJs.UseVisualStyleBackColor = true;
            this.chkbJs.CheckedChanged += new System.EventHandler(this.chkbJs_CheckedChanged);
            // 
            // tbxCssName
            // 
            this.tbxCssName.Enabled = false;
            this.tbxCssName.Location = new System.Drawing.Point(130, 71);
            this.tbxCssName.Name = "tbxCssName";
            this.tbxCssName.Size = new System.Drawing.Size(100, 23);
            this.tbxCssName.TabIndex = 4;
            this.tbxCssName.TextChanged += new System.EventHandler(this.tbxCssName_TextChanged);
            // 
            // chkbCss
            // 
            this.chkbCss.AutoSize = true;
            this.chkbCss.Location = new System.Drawing.Point(8, 73);
            this.chkbCss.Name = "chkbCss";
            this.chkbCss.Size = new System.Drawing.Size(78, 19);
            this.chkbCss.TabIndex = 3;
            this.chkbCss.Text = "fichier css";
            this.chkbCss.UseVisualStyleBackColor = true;
            this.chkbCss.CheckedChanged += new System.EventHandler(this.chkbCss_CheckedChanged);
            // 
            // lblNomsFichiers
            // 
            this.lblNomsFichiers.AutoSize = true;
            this.lblNomsFichiers.Location = new System.Drawing.Point(145, 19);
            this.lblNomsFichiers.Name = "lblNomsFichiers";
            this.lblNomsFichiers.Size = new System.Drawing.Size(73, 15);
            this.lblNomsFichiers.TabIndex = 2;
            this.lblNomsFichiers.Text = "nom fichiers";
            // 
            // tbxHtmlName
            // 
            this.tbxHtmlName.Enabled = false;
            this.tbxHtmlName.Location = new System.Drawing.Point(130, 42);
            this.tbxHtmlName.Name = "tbxHtmlName";
            this.tbxHtmlName.Size = new System.Drawing.Size(100, 23);
            this.tbxHtmlName.TabIndex = 1;
            this.tbxHtmlName.TextChanged += new System.EventHandler(this.tbxHtmlName_TextChanged);
            // 
            // chkbHTML
            // 
            this.chkbHTML.AutoSize = true;
            this.chkbHTML.Location = new System.Drawing.Point(8, 44);
            this.chkbHTML.Name = "chkbHTML";
            this.chkbHTML.Size = new System.Drawing.Size(87, 19);
            this.chkbHTML.TabIndex = 0;
            this.chkbHTML.Text = "fichier html";
            this.chkbHTML.UseVisualStyleBackColor = true;
            this.chkbHTML.CheckedChanged += new System.EventHandler(this.chkbHTML_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(301, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Créer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNomProjet
            // 
            this.lblNomProjet.AutoSize = true;
            this.lblNomProjet.Location = new System.Drawing.Point(313, 179);
            this.lblNomProjet.Name = "lblNomProjet";
            this.lblNomProjet.Size = new System.Drawing.Size(85, 15);
            this.lblNomProjet.TabIndex = 4;
            this.lblNomProjet.Text = "Nom du projet";
            // 
            // tbxNomProjet
            // 
            this.tbxNomProjet.BackColor = System.Drawing.Color.White;
            this.tbxNomProjet.Location = new System.Drawing.Point(301, 197);
            this.tbxNomProjet.Name = "tbxNomProjet";
            this.tbxNomProjet.Size = new System.Drawing.Size(112, 23);
            this.tbxNomProjet.TabIndex = 5;
            this.tbxNomProjet.TextChanged += new System.EventHandler(this.tbxNomProjet_TextChanged);
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnQuitter.Location = new System.Drawing.Point(301, 291);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(112, 35);
            this.btnQuitter.TabIndex = 6;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // tbxFilePath
            // 
            this.tbxFilePath.Location = new System.Drawing.Point(12, 126);
            this.tbxFilePath.Name = "tbxFilePath";
            this.tbxFilePath.Size = new System.Drawing.Size(229, 23);
            this.tbxFilePath.TabIndex = 7;
            this.tbxFilePath.TextChanged += new System.EventHandler(this.tbxFilePath_TextChanged);
            // 
            // btnParcourir
            // 
            this.btnParcourir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnParcourir.Location = new System.Drawing.Point(240, 126);
            this.btnParcourir.Name = "btnParcourir";
            this.btnParcourir.Size = new System.Drawing.Size(75, 23);
            this.btnParcourir.TabIndex = 8;
            this.btnParcourir.Text = "Parcourir";
            this.btnParcourir.UseVisualStyleBackColor = true;
            this.btnParcourir.Click += new System.EventHandler(this.btnParcourir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 338);
            this.Controls.Add(this.btnParcourir);
            this.Controls.Add(this.tbxFilePath);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.tbxNomProjet);
            this.Controls.Add(this.lblNomProjet);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbxCustoms);
            this.Controls.Add(this.gbxDetails);
            this.Controls.Add(this.gbxModeDeCreation);
            this.Name = "Form1";
            this.Text = "Auto HTML";
            this.gbxModeDeCreation.ResumeLayout(false);
            this.gbxModeDeCreation.PerformLayout();
            this.gbxDetails.ResumeLayout(false);
            this.gbxCustoms.ResumeLayout(false);
            this.gbxCustoms.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxModeDeCreation;
        private System.Windows.Forms.RadioButton rbtnCustom;
        private System.Windows.Forms.RadioButton rbtnBasicMode;
        private System.Windows.Forms.GroupBox gbxDetails;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.GroupBox gbxCustoms;
        private System.Windows.Forms.TextBox tbxHtmlName;
        private System.Windows.Forms.CheckBox chkbHTML;
        private System.Windows.Forms.TextBox tbxCssName;
        private System.Windows.Forms.CheckBox chkbCss;
        private System.Windows.Forms.Label lblNomsFichiers;
        private System.Windows.Forms.TextBox tbxJsName;
        private System.Windows.Forms.CheckBox chkbJs;
        private System.Windows.Forms.TextBox tbxFolderName;
        private System.Windows.Forms.CheckBox chkbFolder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNomProjet;
        private System.Windows.Forms.TextBox tbxNomProjet;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.TextBox tbxFilePath;
        private System.Windows.Forms.Button btnParcourir;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

