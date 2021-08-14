using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Diagnostics; //Process

namespace WaSharkWaShark
{
    public partial class Form1 : Form
    {
        public delegate void MyEventHandler(string title, string content);
        public event MyEventHandler SendInfo; //MyEventHandler 생성

        public Form1()
        {
            InitializeComponent();

            //ofd, sfd 설정
            InitializeFileDialog();

            //listView 설정
            lvwPacket.View = View.Details;
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

        class PacketInfo
        {
            public string no;
            public string time;

            public string srcIp;
            public string srcMac;
            public string srcDomain;

            public string desIp;
            public string desMac;
            public string desDomain;

            public string length;
            public string url;

            public string rawPacket;
            public string jsonView;
        };

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            //Process -> Json
            //Python 코드 완성되면 적용하기

            string jsonPath = @"Main.json";
            ListViewItem listItem = new ListViewItem();

            using (StreamReader file = File.OpenText(jsonPath))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                //JObject json = (JObject)JToken.ReadFrom(reader);
                JArray json = (JArray)JToken.ReadFrom(reader);
                Console.WriteLine(json);

                //txtDialog.AppendText(json.ToString()); //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

                PacketInfo pi = new PacketInfo();

                for(int i = 0; i < json.Count; i++)
                {
                    pi.no = json[i]["No"].ToString();
                    pi.time = json[i]["Time"].ToString();

                    pi.srcIp = json[i]["SrcIp"].ToString();
                    pi.srcMac = json[i]["SrcMac"].ToString();
                    pi.srcDomain = json[i]["SrcDomain"].ToString();

                    pi.desIp = json[i]["DesIp"].ToString();
                    pi.desMac = json[i]["DesMac"].ToString();
                    pi.desDomain = json[i]["DesDomain"].ToString();

                    pi.length = json[i]["Length"].ToString();
                    pi.url = json[i]["URL"].ToString();

                    pi.rawPacket = "01:20:30:40:50:60";
                    pi.jsonView = json.ToString();

                    listItem = new ListViewItem(new String[] {pi.no, pi.time, pi.srcIp, pi.srcMac, pi.srcDomain, pi.desIp, pi.desMac, pi.desDomain, pi.length, pi.url, pi.rawPacket, pi.jsonView});
                    lvwPacket.Items.Add(listItem);
                }
            }
        }

        //Save as json
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(lvwPacket.SelectedItems.Count != 0)
            {
                saveJsonFile(txtDialog.Text);
            }
            else
            {
                MessageBox.Show("패킷을 선택해주십시오",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                            );
            }
        }

        //대화형식 표시
        private void lvwPacket_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtDialog 초기화
            txtDialog.Clear();

            if (lvwPacket.SelectedItems.Count != 0)
            {
                int selectRow = lvwPacket.SelectedItems[0].Index;

                string rawPacket = lvwPacket.Items[selectRow].SubItems[10].Text;
                string jsonView = lvwPacket.Items[selectRow].SubItems[11].Text;

                txtDialog.SelectionColor = Color.Red;
                txtDialog.AppendText(rawPacket + "\r\n");

                txtDialog.SelectionColor = Color.Blue;
                txtDialog.AppendText(jsonView + "\r\n");

                //richTextBox 자동 스크롤 설정
                txtDialog.Select(txtDialog.Text.Length, 0);
                txtDialog.ScrollToCaret();
            }
        }

        //json 파일 저장 함수
        public void saveJsonFile(string jsonView)
        {
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                ofd.FileName = sfd.FileName;

                Stream stream = sfd.OpenFile();
                StreamWriter sw = new StreamWriter(stream);

                sw.Write(jsonView);

                sw.Close();
                stream.Close();
            }
        }

        //Raw Packet Modaless
        private void btnHexView_Click(object sender, EventArgs e)
        {
            if (lvwPacket.SelectedItems.Count != 0)
            {
                int selectRow = lvwPacket.SelectedItems[0].Index;
                string rawPacket = lvwPacket.Items[selectRow].SubItems[10].Text;

                //Modaless 형식으로 Form2 생성
                Form2 f2 = new Form2();
                f2.Owner = this;
                f2.Show();

                //Raw Packet 전달
                SendInfo("Raw Packet", rawPacket);
            }
            else
            {
                MessageBox.Show("패킷을 선택해주십시오",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                            );
            }
        }

        //JsonView Modaless
        private void btnJsonView_Click(object sender, EventArgs e)
        {
            if (lvwPacket.SelectedItems.Count != 0)
            {
                int selectRow = lvwPacket.SelectedItems[0].Index;
                string jsonView = lvwPacket.Items[selectRow].SubItems[11].Text;

                //Modaless 형식으로 Form2 생성
                Form2 f2 = new Form2();
                f2.Owner = this;
                f2.Show();

                //jsonView 전달
                SendInfo("Json View", jsonView);
            }
            else
            {
                MessageBox.Show("패킷을 선택해주십시오",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                            );
            }
        }
    }
}
