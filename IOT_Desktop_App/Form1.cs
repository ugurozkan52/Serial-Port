using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace IOT_Desktop_App
{
    public partial class Form1 : Form
    {

        private volatile string Receive_Data;                                                                        /* Alınan data Buffer */
        private volatile string[] Split_Data_1;                                                                        /* Data bölümleyici */
        //private string[] Split_Data_2; 

        DateTime myDateValue = DateTime.Now;                                                                /* Güncel zaman bilgisini al */
        
        public Form1()
        {
            InitializeComponent();
            int with = this.Width;    
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string[] ports = SerialPort.GetPortNames();                                                     /* Serial Port adları Port stringine aktarıldı */
            cBoxComPort.Items.AddRange(ports);

            TBoxInputData.ReadOnly = true;
            lbldatetime.Text = myDateValue.ToString();
            //serialPort1.DataReceived += new SerialDataReceivedEventHandler(SerialPort1_DataReceived);
        }

        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)                 /* Serial port okundu okunan veri buffera alındı */
        {
            try
            {
                Receive_Data = serialPort1.ReadLine();

                this.Invoke(new EventHandler(DisplayData_Event));                                               /* Serial port event oluşturuldu DisplayData */
                                                                                                                //serialPort1.DiscardInBuffer();
            }
            catch (System.IO.IOException err)
            {
                return;
            }
            catch (System.InvalidOperationException err)
            {
                return;
            }

        }

        private void DisplayData_Event(object sender, EventArgs e)                                          /* Serial port event oluşturuldu DisplayData */
        {
            serialPort1.DiscardInBuffer();

            if (Receive_Data[0] == '$')
            {

                Split_Data_1 = Receive_Data.Split('-');                                                           /* Serial port datası bölündü ve her data gerekli label yazıldı */

                lblOpenFrontSpeed.Text = Split_Data_1[1];
                lblOpenBackSpeed.Text = Split_Data_1[2];
                lblOpenCount.Text = Split_Data_1[3];

                lblCloseFrontSpeed.Text = Split_Data_1[4];
                lblCloseBackSpeed.Text = Split_Data_1[5];
                lblCloseCount.Text = Split_Data_1[6];

                TBoxInputData.Text +=
                    DateTime.Now.ToString() +   "\t\t"
                    + lblOpenFrontSpeed.Text +  "\t\t\t"
                    + lblOpenBackSpeed.Text +   "\t\t"
                    + lblOpenCount.Text +       "\t\t\t"
                    + lblCloseFrontSpeed.Text + "\t\t\t"
                    + lblCloseBackSpeed.Text +  "\t\t"
                    + lblCloseCount.Text + "\n"
                    ;

                /* Serial port datası bölündü grafik alana yazıldı */
                
                this.chart1.Series[0].Points.AddXY(myDateValue.ToString("d/M/yyyy HH:mm:ss"), lblOpenFrontSpeed.Text);
                this.chart1.Series[1].Points.AddXY(myDateValue.ToString("d/M/yyyy HH:mm:ss"), lblOpenBackSpeed.Text);
                this.chart1.Series[2].Points.AddXY(myDateValue.ToString("d/M/yyyy HH:mm:ss"), lblCloseFrontSpeed.Text);
                this.chart1.Series[3].Points.AddXY(myDateValue.ToString("d/M/yyyy HH:mm:ss"), lblCloseBackSpeed.Text);
                this.chart1.Series[4].Points.AddXY(myDateValue.ToString("d/M/yyyy HH:mm:ss"), lblOpenCount.Text);
                this.chart1.Series[5].Points.AddXY(myDateValue.ToString("d/M/yyyy HH:mm:ss"), lblCloseCount.Text);
                
                serialPort1.DiscardInBuffer();
                TBoxInputData.Clear();
            }

        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            try /* Port açıksa bağlanır */
            {
                serialPort1.PortName = cBoxComPort.Text;                                                    /* Bağlanılan portun adını port combo box'a yazar */
                serialPort1.BaudRate = Convert.ToInt32(cBoxBaudRate.Text);                                  /* Bağlanılan baudrate adını baudrate combo box'a yazar */

                serialPort1.Open();
                progressBar1.Value = 100;

                BtnOpen.Enabled = false;
                BtnClose.Enabled = true;
                //lblComStatus.Text = "ON";

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);          /* Error mesajı eklendi */

                BtnOpen.Enabled = true;
                BtnClose.Enabled = false;
                //lblComStatus.Text = "OFF";
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            
            if (serialPort1.IsOpen)                                                                         /* Port açıksa portu kapat ve bar'ı sıfırla  */
            {
                serialPort1.Close();
                progressBar1.Value = 0;
                
                BtnOpen.Enabled = true;                                                                     /* Port açıksa portu kapat ve Open tusunu ac close tusunu kapa */
                BtnClose.Enabled = false;
                //lblComStatus.Text = "OFF";                                                                /* Port açıksa portu kapat ve status OFF yaz */
            }
        }

        private void BtnTextSave_Click(object sender, EventArgs e)                                          /* Datalar Save text butonu ile texte kayıt edilir */
        {
            try
            {

                SaveFileDialog save = new SaveFileDialog();  
                save.InitialDirectory = @"C:\";
                save.RestoreDirectory = true;
                save.FileName = "*.txt";
                save.DefaultExt = "txt";
                save.Filter = "txt files (*.txt)|*.txt";

              if(save.ShowDialog() == DialogResult.OK){

                    Stream fileStream = save.OpenFile();
                    StreamWriter sw =new StreamWriter(fileStream);

                    sw.Write(
                        "Zaman\t\t\t" +
                        "Open_Front_Speed" +
                        "\tOpen_Back_Speed" +
                        "\t\tOpen_Count" +
                        "\tClose_Front_Speed" +
                        "\tClose_Back_Speed" +
                        "\tClose_Count\n" + DateTime.Now.ToString() + "\t\t" 
                        + lblOpenFrontSpeed.Text+ "\t\t\t"
                        + lblOpenBackSpeed.Text+ "\t\t" 
                        + lblOpenCount.Text+ "\t\t\t" 
                        + lblCloseFrontSpeed.Text+ "\t\t\t" 
                        + lblCloseBackSpeed.Text+ "\t\t"
                        + lblCloseCount.Text+ "\n"
                        );

                    sw.Close();
                    fileStream.Close();
                    MessageBox.Show("Dosya başarıyla kaydedildi", "Mesaj");                                 /* Dosya kaydedildiğinde kullanıcıya mesaj gönder */
                }
                save.OverwritePrompt = false;  
                save.CreatePrompt = true;
 
                
                //string filelocation = @"C:\Users\a\Documents\MEGAsync\";                                    /* Dosyanın kaydedileceği konumu belirliyoruz */
                //string filename = "Data.txt";                                                               /* Kaydedilecek dosyanın ismi */
                //System.IO.File.WriteAllText(save.InitialDirectory + save.FileName, "Zaman\t\t\t" +
                //    "Open_Front_Speed" +
                //    "\tOpen_Back_Speed" +
                //    "\t\tOpen_Count" +
                //    "\tClose_Front_Speed" +
                //    "\tClose_Back_Speed" +
                //    "\tClose_Count\n" + TBoxInputData.Text); //Dosya konumuna textBox1 üstündeki verilerden oluşan text dosyamızı kaydediyoruz
                                     
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Hata");                                                           /* Hata mesajı */
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TBoxInputData.Clear();
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
            chart1.Series[3].Points.Clear();
            chart1.Series[4].Points.Clear();
            chart1.Series[5].Points.Clear();
            //MessageBox.Show("Başlangıç");  

            /* kapı Similasyonu */
            //pBoxDoorStatus.Location = new Point(pBoxDoorStatus.Location.X + 120, pBoxDoorStatus.Location.Y);

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label14_Click(object sender, EventArgs e)
        {

        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void PBoxDoor_Click(object sender, EventArgs e)
        {

        }
    }
}

