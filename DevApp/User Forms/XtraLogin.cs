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
using DevApp.SQLite.Queries;

namespace DevApp.User_Forms
{
    public partial class XtraLogin : DevExpress.XtraEditors.XtraForm
    {
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
                DataTable UserInfo = UserQueries.Login(txtLoginName.Text, editLoginPassword.Text);
                if (UserInfo.Rows.Count == 1)
                {
                    DataRow UserRow = UserInfo.Rows[0];

                    LogginedUser.Username = UserRow["name"].ToString();
                    LogginedUser.DisplayName = UserRow["displayname"].ToString();
                    LogginedUser.Level = Int32.Parse(UserRow["level"].ToString());
                    LogginedUser.LastActivity = UserRow["activity"].ToString();

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