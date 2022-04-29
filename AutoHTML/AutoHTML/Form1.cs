using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Auteur: D3m0nZ
 * Date: 28.04.2022
 * But: simplifier la création dûn projet html
*/

namespace AutoHTML
{
    public partial class Form1 : Form
    {
        const string STRHTMLNAME = "index";
        const string STRCSSNAME = "style";
        const string STRJSNAME = "script";
        const string STRFOLDERNAME = "img";
        string strProjectName;
        const string FOLDER_PATH = @"..\..\..\..\..\ProjetsCrées\";
        string strFullPath;

        public Form1()
        {
            InitializeComponent();
            tbxHtmlName.Text = STRHTMLNAME;
            tbxCssName.Text = STRCSSNAME;
            tbxJsName.Text = STRJSNAME;
            tbxFolderName.Text = STRFOLDERNAME;
        }

        private void rbtnCustom_CheckedChanged(object sender, EventArgs e)
        {
            gbxCustoms.Enabled = true;
            lblDetails.Text = "Choisis les fichiers et dossiers que tu veux créer";
        }

        private void rbtnBasicMode_CheckedChanged(object sender, EventArgs e)
        {
            gbxCustoms.Enabled = false;
            lblDetails.Text = "Crée des fichiers: html, css, js.\nEt un dossier img";
            tbxHtmlName.Text = STRHTMLNAME;
            tbxCssName.Text = STRCSSNAME;
            tbxJsName.Text = STRJSNAME;
            tbxFolderName.Text = STRFOLDERNAME;
        }

        private void chkbHTML_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbHTML.Checked == true)
                tbxHtmlName.Enabled = true;
            else
                tbxHtmlName.Enabled = false;
        }

        private void chkbCss_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbCss.Checked == true)
                tbxCssName.Enabled = true;
            else
                tbxCssName.Enabled = false;
        }

        private void chkbJs_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbJs.Checked == true)
                tbxJsName.Enabled = true;
            else
                tbxJsName.Enabled = false;
        }

        private void chkbFolder_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbFolder.Checked == true)
                tbxFolderName.Enabled = true;
            else
                tbxFolderName.Enabled = false;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tbxNomProjet.Text != "")
            {
                if (rbtnBasicMode.Checked == true)
                {
                    CreerDossier(strProjectName);
                    CreerFichierHTML(strProjectName, STRHTMLNAME);
                    CreerFichierCss(strProjectName, STRCSSNAME);
                    CreerFichierJs(strProjectName, STRJSNAME);
                    CreerDossierData(strProjectName, STRFOLDERNAME);
                    strFullPath = Path.GetFullPath(FOLDER_PATH + strProjectName);
                    MessageBox.Show("Le projet " + strProjectName + " à bien été créé en : " + strFullPath, "Action Réussie !!");
                }
                else if (rbtnCustom.Checked == true)
                {
                    CreerDossier(strProjectName);
                    if (chkbHTML.Checked == true)
                    {
                        CreerFichierHTML(strProjectName, tbxHtmlName.Text);
                    }
                    if (chkbCss.Checked == true)
                    {
                        CreerFichierCss(strProjectName, tbxCssName.Text);
                    }
                    if (chkbJs.Checked == true)
                    {
                        CreerFichierJs(strProjectName, tbxJsName.Text);
                    }
                    if (chkbFolder.Checked == true)
                    {
                        CreerDossierData(strProjectName, tbxFolderName.Text);
                    }
                    strFullPath = Path.GetFullPath(FOLDER_PATH + strProjectName);
                    MessageBox.Show("Le projet " + strProjectName + " à bien été créé en : " + strFullPath, "Action Réussie !!");
                }
            }
            else
            {
                tbxNomProjet.BackColor = Color.LightPink;
                MessageBox.Show("Veuillez entrer un nom de projet !!", "Erreur!!");
            }
        }

        private void tbxNomProjet_TextChanged(object sender, EventArgs e)
        {
            if(tbxNomProjet.BackColor == Color.LightPink)
            {
                tbxNomProjet.BackColor = Color.White;
            }
            strProjectName = tbxNomProjet.Text;

        }

        private void tbxHtmlName_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbxCssName_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbxJsName_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbxFolderName_TextChanged(object sender, EventArgs e)
        {
        }

        static void CreerDossier(string strProjectName)
        {
            Directory.CreateDirectory(FOLDER_PATH + strProjectName);
        }
        static void CreerFichierHTML(string strProjectName, string strHtmlName)
        {
            using (FileStream fs = File.Create(FOLDER_PATH + strProjectName + @"\" + strHtmlName + ".html"))
            {
                byte[] info = new UTF8Encoding(true).GetBytes("<!DOCTYPE html>\n" +
                    "<html>\n" +
                    "\t<head>\n" +
                    "\t\t<title>" + strHtmlName + "</title>\n" +
                    "\t\t<meta charset='utf - 8'/>\n" +
                    "\t\t<meta name='author' content='" + Environment.UserName + "'>\n" +
                    "\t\t<meta name='viewport' content='width=device-width, initial-scale=1.0'>\n" +
                    "\t\t<link rel='stylesheet' href='style.css'>\n" +
                    "\t\t<script src='script.js'>\n" +
                    "\t</head>\n" +
                    "\t<body>\n" +
                    "\t\t<header>\n" +
                    "\t\t</header>\n" +
                    "\t\t<main>\n" +
                    "\t\t</main>\n" +
                    "\t\t<footer>\n" +
                    "\t\t</footer>\n" +
                    "\t</body>\n" +
                    "</html>");
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }
        }
        static void CreerFichierCss(string strProjectName, string strCssName)
        {
            using (FileStream fs = File.Create(FOLDER_PATH + strProjectName + @"\" + strCssName + ".css"))
            {
                byte[] info = new UTF8Encoding(true).GetBytes("");
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }
        }
        static void CreerFichierJs(string strProjectName, string strJsName)
        {
            using (FileStream fs = File.Create(FOLDER_PATH + strProjectName + @"\" + strJsName + ".js"))
            {
                byte[] info = new UTF8Encoding(true).GetBytes("");
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }
        }
        static void CreerDossierData(string strProjectName, string strFolderName)
        {
            Directory.CreateDirectory(FOLDER_PATH + strProjectName + @"\" + strFolderName);
        }
    }
}
