using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper;
using Engine;
using Engine.UserData;

namespace UI.Forms
{
    public partial class FormFacebookLogin : Form
    {
        private BasicUserData m_LoggedInUser;
        private FormFacebookWindow m_FacebookWindow;

        public FormFacebookLogin()
        {
            InitializeComponent();
            facebookLabel.BackColor = Color.Transparent;
            Text = "Log-In Window";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            closeForm();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            facebookLogin();
        }

        private void facebookLogin()
        {
            try
            {
                m_LoggedInUser = LoggedInUser.InstanceOfLoggedInUser.LoggedInUserInstance;
                Hide();
                m_FacebookWindow = new FormFacebookWindow();
                m_FacebookWindow.FormClosed += OnExitMainForm;
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to log-in");
            }
        }

        private void OnExitMainForm(object sender, EventArgs e)
        {
            if (m_FacebookWindow.DialogResult == DialogResult.OK)
            {
                LoggedInUser.InstanceOfLoggedInUser.LogOut();
            }

            Close();
        }

        private void closeForm()
        {
            Close();
        }
    }
}
