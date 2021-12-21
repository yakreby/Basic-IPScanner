using Microsoft.Data.Sqlite;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPScanner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Scanning IP's in 192.168.1 subnet
        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            string subnet = "192.168.1";
            progressBar1.Maximum = 254;
            progressBar1.Value = 0;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            listBox1.Items.Clear();
            label8.Text = "";

            Task.Factory.StartNew(new Action(() =>
            {
                for (int i = 2; i < 255; i++)
                {
                    string ip = $"{subnet}.{i}";
                    Ping ping = new Ping();
                    PingReply reply = ping.Send(ip, 100);
                    if (reply.Status == IPStatus.Success)
                    {
                        progressBar1.BeginInvoke(new Action(() =>
                        {
                            try
                            {
                                IPHostEntry host = Dns.GetHostEntry(IPAddress.Parse(ip));
                                if (host != null)
                                {
                                    var mac = GetMacAddress(ip);
                                    var vendor = GetVendor(mac);
                                    dataGridView1.Rows.Add("Aktif", host.HostName, ip, mac, vendor);
                                }
                                else
                                {
                                    dataGridView1.Rows.Add("Aktif", host.HostName, ip, "");
                                }
                            }
                            catch
                            {
                                var mac = GetMacAddress(ip);
                                var vendor = GetVendor(mac);
                                listBox1.Items.Add($"Host Adı Alınamadı. IP : {ip}");
                                dataGridView1.Rows.Add("Aktif", ip, ip, mac, "");
                            }
                            progressBar1.Value += 1;
                            label7.ForeColor = Color.Blue;
                            label7.Text = $"Taranıyor: {ip}";
                            if (progressBar1.Value == 253)
                            {
                                label8.Text = "Tamamlandı";
                                progressBar1.Value = 0;
                            } 
                        }));
                    }
                    else
                    {
                        progressBar1.BeginInvoke(new Action(() =>
                        {
                            progressBar1.Value += 1;
                            label7.ForeColor = Color.DarkGray;
                            label7.Text = $"Taranıyor: {ip}";
                            dataGridView1.Rows.Add("Pasif", "", ip);
                            if (progressBar1.Value == 253)
                            {
                                label8.Text = "Tamamlandı";
                                progressBar1.Value = 0;
                                listBox1.Items.Add("Tamamlandı");
                                listBox1.Items.Add($"Tamamlanma Tarihi : {DateTime.Now}");
                            }
                        }));
                    }
                }
            }));
        }

        //Scanning IP's in 192.168.2 subnet
        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            string subnet = "192.168.2";
            progressBar1.Maximum = 254;
            progressBar1.Value = 0;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            listBox1.Items.Clear();
            label8.Text = "";

            Task.Factory.StartNew(new Action(() =>
            {
                for (int i = 2; i < 255; i++)
                {
                    string ip = $"{subnet}.{i}";
                    Ping ping = new Ping();
                    PingReply reply = ping.Send(ip, 100);
                    if (reply.Status == IPStatus.Success)
                    {
                        progressBar1.BeginInvoke(new Action(() =>
                        {
                            try
                            {
                                IPHostEntry host = Dns.GetHostEntry(IPAddress.Parse(ip));
                                if (host != null)
                                {
                                    var mac = GetMacAddress(ip);
                                    var vendor = GetVendor(mac);
                                    dataGridView1.Rows.Add("Aktif", host.HostName, ip, mac, vendor);
                                }
                                else
                                {
                                    dataGridView1.Rows.Add("Aktif", host.HostName, ip, "", "");
                                }
                            }
                            catch
                            {
                                var mac = GetMacAddress(ip);
                                var vendor = GetVendor(mac);
                                listBox1.Items.Add($"Host Adı Alınamadı. IP : {ip}");
                                dataGridView1.Rows.Add("Aktif", ip, ip, mac, "");
                            }
                            progressBar1.Value += 1;
                            label8.ForeColor = Color.Blue;
                            label8.Text = $"Taranıyor: {ip}";
                            if (progressBar1.Value == 253)
                            {
                                label8.Text = "Tamamlandı";
                                progressBar1.Value = 0;
                            }
                        }));
                    }
                    else
                    {
                        progressBar1.BeginInvoke(new Action(() =>
                        {
                            progressBar1.Value += 1;
                            label7.ForeColor = Color.DarkGray;
                            label7.Text = $"Taranıyor: {ip}";
                            dataGridView1.Rows.Add("Pasif", "", ip);
                            if (progressBar1.Value == 253)
                            {
                                label7.Text = "Tamamlandı";
                                progressBar1.Value = 0;
                                listBox1.Items.Add("Tamamlandı");
                                listBox1.Items.Add($"Tamamlanma Tarihi : {DateTime.Now}");
                            }
                        }));
                    }
                }
            }));
        }

        //Scanning IP's in 192.168.3 subnet
        private void Button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            string subnet = "192.168.3";
            progressBar1.Maximum = 254;
            progressBar1.Value = 0;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            listBox1.Items.Clear();
            label8.Text = "";

            Task.Factory.StartNew(new Action(() =>
            {
                for (int i = 2; i < 255; i++)
                {
                    string ip = $"{subnet}.{i}";
                    Ping ping = new Ping();
                    PingReply reply = ping.Send(ip, 100);
                    if (reply.Status == IPStatus.Success)
                    {
                        progressBar1.BeginInvoke(new Action(() =>
                        {
                            try
                            {
                                IPHostEntry host = Dns.GetHostEntry(IPAddress.Parse(ip));
                                if (host != null)
                                {
                                    var mac = GetMacAddress(ip);
                                    var vendor = GetVendor(mac);
                                    dataGridView1.Rows.Add("Aktif", host.HostName, ip, mac, vendor);
                                }
                                else
                                {
                                    dataGridView1.Rows.Add("Aktif", host.HostName, ip, "", "");
                                }
                            }
                            catch
                            {
                                var mac = GetMacAddress(ip);
                                var vendor = GetVendor(mac);
                                listBox1.Items.Add($"Host Adı Alınamadı. IP : {ip}");
                                dataGridView1.Rows.Add("Aktif", ip, ip, mac, "");
                            }
                            progressBar1.Value += 1;
                            label7.ForeColor = Color.Blue;
                            label7.Text = $"Taranıyor: {ip}";
                            if (progressBar1.Value == 253)
                            {
                                label8.Text = "Tamamlandı";
                                progressBar1.Value = 0;
                                listBox1.Items.Add("Tamamlandı");
                                listBox1.Items.Add($"Tamamlanma Tarihi : {DateTime.Now}");
                            }
                        }));
                    }
                    else
                    {
                        progressBar1.BeginInvoke(new Action(() =>
                        {
                            progressBar1.Value += 1;
                            label7.ForeColor = Color.DarkGray;
                            label7.Text = $"Taranıyor: {ip}";
                            dataGridView1.Rows.Add(ip, "", "Pasif");
                            if (progressBar1.Value == 253)
                            {
                                label8.Text = "Tamamlandı";
                                progressBar1.Value = 0;
                            }
                        }));
                    }
                }
            }));
        }

        //Ping with IP's has 1
        private void Button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            string ip = $"192.168.1.{textBox1.Text}";
            if (textBox1.Text == "")
            {
                MessageBox.Show("Adres Değeri boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Ping ping = new Ping();
                try
                {
                    PingReply reply = ping.Send(ip, 100);
                    if (reply.Status == IPStatus.Success)
                    {
                        try
                        {
                            IPHostEntry host = Dns.GetHostEntry(IPAddress.Parse(ip));
                            textBox4.Text += host.HostName;
                            textBox5.Text += "Aktif";
                        }
                        catch
                        {
                            listBox1.Items.Add($"Bilgisayara Ulaşılamadı. IP : {ip}");
                            textBox4.Text += "Yok";
                            textBox5.Text += "Pasif";
                        }
                    }
                    else
                    {
                        textBox4.Text += "Yok";
                        textBox5.Text += "Pasif";
                    }
                }
                catch
                {
                    MessageBox.Show($"Bilinen böyle bir ana bilgisayar yok. IP : {ip}");
                }
            }
        }

        //Ping with IP's has 2
        private void Button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            string ip = $"192.168.2.{textBox2.Text}";
            if (textBox2.Text == "")
            {
                MessageBox.Show("Adres Değeri boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else{
                Ping ping = new Ping();
                PingReply reply = ping.Send(ip, 100);
                if (reply.Status == IPStatus.Success)
                {
                    IPHostEntry host = Dns.GetHostEntry(IPAddress.Parse(ip));
                    textBox4.Text += host.HostName;
                    textBox5.Text += "Aktif";
                }
                else
                {
                    textBox4.Text += "Yok";
                    textBox5.Text += "Pasif";
                }
            }
        }

        //Ping with IP's has 3
        private void Button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            string ip = $"192.168.3.{textBox3.Text}";
            if (textBox3.Text == "")
            {
                MessageBox.Show("Adres Değeri boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else{
                Ping ping = new Ping();
                PingReply reply = ping.Send(ip, 100);
                if (reply.Status == IPStatus.Success)
                {
                    IPHostEntry host = Dns.GetHostEntry(IPAddress.Parse(ip));
                    textBox4.Text += host.HostName;
                    textBox5.Text += "Aktif";
                }
                else
                {
                    textBox4.Text += "Yok";
                    textBox5.Text += "Pasif";
                }
            }
        }

        //Clear all inputs
        private void Button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        //Stop Execution
        public void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Getting MAC Address with given IP
        public static string GetMacAddress(string ip)
        {
            string macAddress = string.Empty;
            System.Diagnostics.Process pProcess = new System.Diagnostics.Process();
            //Command line command arp -a for finding mac addresses
            pProcess.StartInfo.FileName = "arp";
            pProcess.StartInfo.Arguments = "-a " + ip;
            pProcess.StartInfo.UseShellExecute = false;
            pProcess.StartInfo.RedirectStandardOutput = true;
            pProcess.StartInfo.CreateNoWindow = true;
            pProcess.Start();
            string strOutput = pProcess.StandardOutput.ReadToEnd();
            string[] substrings = strOutput.Split('-');
            if (substrings.Length >= 8)
            {
                macAddress = substrings[3].Substring(Math.Max(0, substrings[3].Length - 2)).ToUpper()
                         + ":" + substrings[4].ToUpper() + ":" + substrings[5].ToUpper() + ":" + substrings[6].ToUpper()
                         + ":" + substrings[7].ToUpper() + ":"
                         + substrings[8].Substring(0, 2).ToUpper();
                return macAddress;
            }
            //Mac not found
            else
            {
                return "MAC Adresi alınamadı";
            }
        }

        //Getting Vendor with specified MAC Address
        public static string GetVendor(string macAddress)
        {
            SqliteConnection sQLiteConnection;

            string vendorIdentifier = macAddress.Substring(0, 8).ToString();
            var connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=VendorList;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            var queryString = $"SELECT Vendor FROM VendorList WHERE @vendorIdentifier==Mac";
            var connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@vendorIdentifier", vendorIdentifier);
            connection.Open();
            command.ExecuteNonQuery();
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("\t{0}\t{1}\t{2}",
                        reader[0], reader[1], reader[2]);
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                Console.Write(ex.Message);
            }
            connection.Close();
            //var vendorList = k * from Vendors select k;
            //var vendor = _context.Vendors.Where(Contains(macAdress));
            //return vendor;
            //var path = Path.Combine(Directory.GetCurrentDirectory(), "\\mac-vendor.txt");
            return "";
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        Bitmap memoryImage;

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
            printDocument1.Print();
        }

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }
    }
}

//Other Options and Values

//Time to Live
//var timeToLive = reply.Options.Ttl.ToString();
//Don't Fragment
//var dontFragment = reply.Options.DontFragment.ToString();
//Roundtrip Time
//var roundTrip = reply.RoundtripTime.ToString();
//Buffer Size
//var bufferSize = reply.Buffer.Length.ToString();
//Address
//var address = reply.Address.ToString();

//var values = "Time to live " + timeToLive + ", Dont Fragment " + dontFragment +
//", Round Trip " + roundTrip + ", Buffer Size " + bufferSize + ", Address " + address;
//MessageBox.Show(values);