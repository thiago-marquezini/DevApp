using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DevApp.Global;
using DevApp.SQLite;

namespace DevApp.User_Forms
{
    public partial class XtraLogin : DevExpress.XtraEditors.XtraForm
    {
        private SQLiteCipher UserLoginConnection = new SQLiteCipher();
        private clsUserQueries UserQueries = new clsUserQueries();

        private frmMain Main;
        public XtraLogin(frmMain _Main)
        {
            InitializeComponent();
            this.Main = _Main;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((txtLoginName.Text.Length >= 5) && (editLoginPassword.Text.Length >= 5))
            {
                List<UserObj> UserInfo = UserQueries.Login(UserLoginConnection.Connection(), txtLoginName.Text, editLoginPassword.Text);
                if (UserInfo.Count == 1)
                {
                    LogginedUser.Username = UserInfo[0].Name;
                    LogginedUser.DisplayName = UserInfo[0].DisplayName;
                    LogginedUser.Level = Int32.Parse(UserInfo[0].Level);
                    LogginedUser.LastActivity = UserInfo[0].Activity;

                    LogginedUser.Loggined = true;

                    this.Main.SetLogginedUser();
                    this.Close();

                } else
                {
                    XtraMessageBox.Show("Usuario ou Senha incorretos.", "Login de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } else
            {
                XtraMessageBox.Show("Usuario ou Senha incorretos.", "Login de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSair_MouseEnter(object sender, EventArgs e)
        {
            btnSair.ForeColor = Color.Black;
        }

        private void btnSair_MouseLeave(object sender, EventArgs e)
        {
            btnSair.ForeColor = Color.White;
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.Black;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.White;
        }
    }
}