using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace WifiBaglantiNoktasi
{
    public partial class Form1 : Form
    {
        private const string CREATE_NETWORK_COMMAND = "/C netsh wlan set hostednetwork mode=allow ssid={0} key={1}";
        private const string START_NETWORK_COMMAND = "/C netsh wlan start hostednetwork";
        private const string STOP_NETWORK_COMMAND = "/C netsh wlan stop hostednetwork";
        private const string RESET_NETWORK_COMMAND = "/C netsh wlan refresh hostednetwork key";
        private const string SHOW_NETWORK_INFO = "/C netsh wlan show hostednetwork";
        private string SSID;
        private string password;
        public Form1()
        {

            InitializeComponent();

            try
            {


                txtSSID.Text = getRegValue("hotspotSSID");
                txtPassword.Text = getRegValue("hotspotPassword");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }




        }

        private void setRegValue(string key, string value)
        {

            RegistryKey regKey = null;

            try
            {
                regKey = regKey = Registry.CurrentUser.CreateSubKey("hotspotWifi");
                regKey.SetValue(key, value);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                try
                {
                    regKey.Close();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
        }

        private string getRegValue(string key)
        {
            string value = null;
            RegistryKey regKey = null;

            try
            {
                bool subkeyControl = false;
                foreach (string item in Registry.CurrentUser.GetSubKeyNames())
                {
                    if (item == "hotspotWifi")
                        subkeyControl = true;
                }

                if (!subkeyControl)
                    return null;

                regKey = Registry.CurrentUser.OpenSubKey("hotspotWifi");

                value = regKey.GetValue(key) != null ? regKey.GetValue(key).ToString() : null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                regKey.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }





            return value;

        }

        private string CmdCommand(string command)
        {
            string strOutput = null;
            try
            {

                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = command;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.Start();
                strOutput = process.StandardOutput.ReadToEnd();
          

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            return strOutput;

        }
        private void btnCreateWifi_Click(object sender, EventArgs e)
        {

            try
            {
                SSID = txtSSID.Text;
                password = txtPassword.Text;
                MessageBox.Show(CmdCommand(string.Format(CREATE_NETWORK_COMMAND, SSID, password)));
                setRegValue("hotspotSSID", txtSSID.Text);
                setRegValue("hotspotPassword", txtPassword.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void btnStartWifi_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(CmdCommand(START_NETWORK_COMMAND));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnStopWifi_Click(object sender, EventArgs e)
        {
            try
            {

                MessageBox.Show(CmdCommand(STOP_NETWORK_COMMAND));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {

                MessageBox.Show(CmdCommand(RESET_NETWORK_COMMAND));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CmdCommand(SHOW_NETWORK_INFO));
        }
    }


}
