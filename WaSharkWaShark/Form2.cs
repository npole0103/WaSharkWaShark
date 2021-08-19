using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace WaSharkWaShark
{
    public partial class Form2 : Form
    {
        //Send Info from Form1
        Form1 f1;

        public Form2()
        {
            InitializeComponent();
            InitializeFileDialog();
        }
        private void InitializeFileDialog()
        {
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofd.Filter = "json (*.json)|*.json|" + "All files (*.*)|*.*"; ;
            ofd.FileName = "";

            sfd.InitialDirectory = ofd.InitialDirectory;
            sfd.Filter = ofd.Filter;
            sfd.FileName = "*.json";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            f1 = (Form1)Owner;
            f1.SendInfo += new Form1.MyEventHandler(updateInfo);
        }

        //json 파일 저장 메소드
        public void saveJsonFile(string content)
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ofd.FileName = sfd.FileName;

                Stream stream = sfd.OpenFile();
                StreamWriter sw = new StreamWriter(stream);

                sw.Write(content);

                sw.Close();
                stream.Close();
            }
        }

        void updateInfo(string title, string content)
        {
            lblText.Text = title;
            if (title.Equals("Raw Packet"))
            {
                txtLog.TextAlign = HorizontalAlignment.Center;
                txtLog.Font = new Font(txtLog.Font.FontFamily, 14);
            }
            else if (title.Equals("Json View"))
                txtLog.TextAlign = HorizontalAlignment.Left;

            txtLog.Text = content;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveJsonFile(txtLog.Text);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
