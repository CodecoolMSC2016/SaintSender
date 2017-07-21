using MaterialSkin.Controls;
using SaintSender.Control;
using SaintSender.Model;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaintSender.View
{
    public partial class LoginWindow : MaterialForm
    {

        public LoginWindow()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void LoginWindow_Load(object sender, EventArgs e)
        {
            Owner.Enabled = false;
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            var button = sender as MaterialRaisedButton;
            button.Enabled = false;

            string userName = materialSingleLineTextField1.Text;
            string password = materialSingleLineTextField2.Text;

            ConnectionInfo imapInfo = new ConnectionInfo("imap.gmail.com", 993);
            ConnectionInfo smtpInfo = new ConnectionInfo("smtp.gmail.com", 465);

            IClient client = SaintClient.INSTANCE;

            client.ImapInfo = imapInfo;
            client.SmtpInfo = smtpInfo;
            client.UserName = userName;
            client.Password = password;

            Task.Run(() =>
            {
                if (client.Login())
                {
                    Invoke(new Close((login, main) => {
                        string name = userName.Split('@')[0].ToUpper();
                        main.Text = name + "(" + userName + ")";
                        login.Close();
                        }), this, Owner);
                }else
                {
                    button.Invoke(new Action(() => button.Enabled = true));
                }
            });
        }

        private delegate void Close(MaterialForm login, MaterialForm main);

        private void LoginWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Enabled = true;
        }
    }
}
