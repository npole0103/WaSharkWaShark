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
using System.Threading;

namespace WaSharkWaShark
{
    public partial class Form1 : Form
    {
        public delegate void MyEventHandler(string title, string content);
        public event MyEventHandler SendInfo; //MyEventHandler 생성

        public Form1()
        {
            InitializeComponent();

            InitializeFileDialog(); //ofd, sfd 설정
            lvwPacket.View = View.Details; //listView 설정
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
            public string uri;
        };

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExtract_Click(object sender, EventArgs e)

        {
            //Process -> Json

            pbState.Value = 1;

            string epPath = "extractPacket.py";
            ListViewItem listItem = new ListViewItem();

            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = "python.exe";
            start.Arguments = string.Format("{0}", epPath);
            start.UseShellExecute = false;
            start.CreateNoWindow = true;
            start.RedirectStandardOutput = true;
            start.RedirectStandardError = true;
            start.RedirectStandardInput = true;
            start.StandardOutputEncoding = Encoding.Default;
            start.StandardErrorEncoding = Encoding.Default;
            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {

                    string result = reader.ReadToEnd();

                    JArray json = (JArray)JToken.Parse(result);

                    PacketInfo pi = new PacketInfo();

                    pbState.Visible = true;
                    pbState.Minimum = 1;
                    pbState.Maximum = json.Count;
                    pbState.Value = 1;
                    pbState.Step = 1;

                    for (int i = 0; i < json.Count; i++)
                    {
                        lblPb.Text = "Wait.."; //왜 안될까?

                        pi.no = json[i]["No"].ToString();
                        pi.time = json[i]["Time"].ToString();

                        pi.srcIp = json[i]["SrcIp"].ToString();
                        pi.srcMac = json[i]["SrcMac"].ToString().ToUpper();
                        pi.srcDomain = json[i]["SrcDomain"].ToString();

                        pi.desIp = json[i]["DesIp"].ToString();
                        pi.desMac = json[i]["DesMac"].ToString().ToUpper();
                        pi.desDomain = json[i]["DesDomain"].ToString();

                        pi.length = json[i]["Length"].ToString();
                        pi.uri = json[i]["URI"].ToString();

                        listItem = new ListViewItem(new String[] { pi.no, pi.time, pi.srcIp, pi.srcMac, pi.srcDomain, pi.desIp, pi.desMac, pi.desDomain, pi.length, pi.uri});
                        lvwPacket.Items.Add(listItem);

                        pbState.PerformStep(); //progressbar State Update
                    }

                    lblPb.Text = "Complete";// 완료시

                    reader.Close();
                }
            }
        }

        //Save as json
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(lvwPacket.SelectedItems.Count != 0)
            {
                InitializeFileDialog();
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

                string epPath = "followStream.py";

                ProcessStartInfo start = new ProcessStartInfo();
                start.FileName = "python.exe";
                start.Arguments = string.Format("{0} {1}", epPath, selectRow);
                start.UseShellExecute = false;
                start.CreateNoWindow = true;
                start.RedirectStandardOutput = true;
                start.RedirectStandardError = true;
                start.RedirectStandardInput = true;
                start.StandardOutputEncoding = Encoding.Default;
                start.StandardErrorEncoding = Encoding.Default;
                using (Process process = Process.Start(start))
                {
                    using (StreamReader reader = process.StandardOutput)
                    {
                        string result = reader.ReadToEnd();

                        //대화형식 분할
                        string[] resultSplit = result.Split(new char[] {'@'});

                        for (int i = 0; i < resultSplit.Length - 1; i++)
                        {
                            //짝수일 때 빨간색, 홀수 일 때 파란색으로
                            txtDialog.SelectionColor = i % 2 == 0 ? Color.Red : Color.Blue;
                            txtDialog.AppendText(resultSplit[i]);
                        }

                        //richTextBox 자동 스크롤 설정
                        txtDialog.Select(txtDialog.Text.Length, 0);
                        txtDialog.ScrollToCaret();

                        reader.Close();
                    }
                }
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
                int selectRow = lvwPacket.SelectedItems[0].Index + 1;

                StreamReader SR = new StreamReader($"RawPacket/{selectRow}.txt");
                string rawPacket = SR.ReadToEnd();

                //Hex Code 분할
                string[] rpSplit = rawPacket.Split(new char[] {' '});

                rawPacket = string.Empty;

                //init display
                int j = 8;
                rawPacket += "OFFSET(h)".PadRight(8, ' ') + ": 00 01 02 03 04 05 06 07 | 08 09 0A 0B 0C 0D 0E 0F " + "\r\n";

                for(int i = 0; i < rpSplit.Length ; i++)
                {
                    rawPacket += rpSplit[i].ToUpper() + " "; //Hex 값 붙여넣기
                    
                    if(i == j) // 중간에 | 구분
                    {
                        rawPacket += "| ";
                        j += 16;
                    }
                    if (i % 16 == 0) //16 바이트 마다 개행 + offset 정보
                    {
                        rawPacket += "\r\n";
                        rawPacket += (i.ToString("X")).PadLeft(8, '0').ToString() + " : ";
                        //https://bitwizx.tistory.com/3 앞에 0채워서 표현
                    }
                }

                //Modaless 형식으로 Form2 생성
                Form2 f2 = new Form2();
                f2.Owner = this;
                f2.Show();

                //Raw Packet 전달
                SendInfo("Raw Packet", rawPacket);

                SR.Close();
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
                int selectRow = lvwPacket.SelectedItems[0].Index + 1;

                //JsonView 파일 읽기
                StreamReader SR = new StreamReader($"JsonView/{selectRow}.txt");
                string jsonView = SR.ReadToEnd();
                SR.Close();

                //Modaless 형식으로 Form2 생성
                Form2 f2 = new Form2();
                f2.Owner = this;
                f2.Show();

                //jsonView 전달
                SendInfo("Json View", jsonView);

                SR.Close();
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

        private void 패킷정보저장SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lvwPacket.Items.Count == 0)
            {
                MessageBox.Show("패킷이 존재하지 않습니다.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
                return;
            }
            string info = string.Empty;
            for(int i = 0; i < lvwPacket.Items.Count; i++)
            {
                info += (
                    lvwPacket.Items[i].SubItems[0].Text + " " +
                    lvwPacket.Items[i].SubItems[1].Text + " " +
                    lvwPacket.Items[i].SubItems[2].Text + " " +
                    lvwPacket.Items[i].SubItems[3].Text + " " +
                    lvwPacket.Items[i].SubItems[4].Text + " " +
                    lvwPacket.Items[i].SubItems[5].Text + " " +
                    lvwPacket.Items[i].SubItems[6].Text + " " +
                    lvwPacket.Items[i].SubItems[7].Text + " " +
                    lvwPacket.Items[i].SubItems[8].Text + " " +
                    lvwPacket.Items[i].SubItems[9].Text
                    );
                info += "\n";
            }
            InitializeFileDialog();
            saveJsonFile(info);
        }

        private void 도움말ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. File - 패킷정보저장 : ListView 내에 있는 모든 패킷 저장 \n" +
                "2. Extract Pcap : Main.json 형식의 패킷 정보 파일을 분석하여 추출함. \n " +
                "3. Follow Stream Save as Json : 대화 형식의 뷰를 Json 파일로 저장. \n" +
                "4. Raw Packet : 패킷 형태를 Hex View로 제공. \n" +
                "5. Json View : 패킷 형태를 Json View로 제공. \n" +
                "6. Filtering : 체크 박스 체크시 패킷 숨김 기능 제공. \n",
            "Information",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
            );
        }

        private void col_CheckedChanged(object sender, EventArgs e)
        {
            //60 300 100 120 120 100 120 120 80 300

            //No
            if (cbNo.Checked == false)
            {
                lvwPacket.Columns[0].Width = 0;
                cbNo.Text = "No(H)";
            }
            else if(cbNo.Checked == true)
            {
                lvwPacket.Columns[0].Width = 60;
                cbNo.Text = "No";
            }

            //Time
            if (cbTime.Checked == false)
            {
                lvwPacket.Columns[1].Width = 0;
                cbTime.Text = "Time(H)";
            }
            else if (cbTime.Checked == true)
            {
                lvwPacket.Columns[1].Width = 300;
                cbTime.Text = "Time";
            }

            //SrcIp
            if (cbSrcIp.Checked == false)
            {
                lvwPacket.Columns[2].Width = 0;
                cbSrcIp.Text = "SrcIp(H)";
            }
            else if (cbSrcIp.Checked == true)
            {
                lvwPacket.Columns[2].Width = 100;
                cbSrcIp.Text = "SrcIp";
            }

            //SrcMac
            if (cbSrcMac.Checked == false)
            {
                lvwPacket.Columns[3].Width = 0;
                cbSrcMac.Text = "SrcIp(H)";
            }
            else if (cbSrcMac.Checked == true)
            {
                lvwPacket.Columns[3].Width = 120;
                cbSrcMac.Text = "SrcIp";
            }

            //SrcDomain
            if (cbSrcDomain.Checked == false)
            {
                lvwPacket.Columns[4].Width = 0;
                cbSrcDomain.Text = "SrcDomain(H)";
            }
            else if (cbSrcDomain.Checked == true)
            {
                lvwPacket.Columns[4].Width = 120;
                cbSrcDomain.Text = "SrcDomain";
            }

            //DesIp
            if (cbDesIp.Checked == false)
            {
                lvwPacket.Columns[5].Width = 0;
                cbDesIp.Text = "DesIp(H)";
            }
            else if (cbDesIp.Checked == true)
            {
                lvwPacket.Columns[5].Width = 100;
                cbDesIp.Text = "DesIp";
            }

            //DesMac
            if (cbDesMac.Checked == false)
            {
                lvwPacket.Columns[6].Width = 0;
                cbDesMac.Text = "DesIp(H)";
            }
            else if (cbDesMac.Checked == true)
            {
                lvwPacket.Columns[6].Width = 120;
                cbDesMac.Text = "DesIp";
            }

            //DesDomain
            if (cbDesDomain.Checked == false)
            {
                lvwPacket.Columns[7].Width = 0;
                cbDesDomain.Text = "DesDomain(H)";
            }
            else if (cbDesDomain.Checked == true)
            {
                lvwPacket.Columns[7].Width = 120;
                cbDesDomain.Text = "DesDomain";
            }

            //Length
            if (cbLength.Checked == false)
            {
                lvwPacket.Columns[8].Width = 0;
                cbLength.Text = "Length(H)";
            }
            else if (cbLength.Checked == true)
            {
                lvwPacket.Columns[8].Width = 80;
                cbLength.Text = "Length";
            }

            //URI
            if (cbURI.Checked == false)
            {
                lvwPacket.Columns[9].Width = 0;
                cbURI.Text = "URI(H)";
            }
            else if (cbURI.Checked == true)
            {
                lvwPacket.Columns[9].Width = 300;
                cbURI.Text = "URI";
            }

        }
    }
}
