using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using Microsoft.VisualBasic;

// 12.20
using System.Timers;

namespace NE_PAM
{
    public partial class FormMain : Form
    {
        //------------------------------------------------------------------------
        // LPR제외
        //------------------------------------------------------------------------
        private String[] m_sAppPath = new String[5]; 
        private String[] m_sAppName = new String[5]; 
        private String[] m_sProcessName = new String[5]; 
        private String[] m_sProcessCode = new String[5];
        private String[] m_sTypeName = new String[5]; 
        private String[] m_sRestartName = new String[5];
        private String[] m_sRestartTime = new String[5];

        private bool[] m_bAliveFlag = new bool[]{ false,false, false, false, false};

        private TextBox[] PathTextBox;
        private TextBox[] CodeTextBox;
        private Button[] PathButton;
        private ComboBox[] TypeComboBox;
        private ComboBox[] RestartComboBox;
        private Button[] PlayButton;
        private Button[] StopButton;
        private Button[] EraseButton;
        private DateTimePicker[] RestartTimeComboBox;


        //------------------------------------------------------------------------
        // 기타
        //------------------------------------------------------------------------
        private int m_nInterval = 30; 

        public delegate void ActiveDelegate(String msg);
        private delegate void LogWriteDelegate(String msg);
        ToolTip toolTip = null;
        //------------------------------------------------------------------------

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // 툴팁생성
            toolTip = new ToolTip();

            toolTip.AutoPopDelay = 1500;
            toolTip.InitialDelay = 1000;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;
            toolTip.IsBalloon = true;

            toolTip.SetToolTip(cmbRestart1, "프로그램 재실행 간격을 설정합니다");
            toolTip.SetToolTip(dateTimePicker1, "프로그램 재실행 시간을 설정합니다");
            toolTip.SetToolTip(chkOnTop, "항상 모든 화면의 위에 위치시킵니다.");
            toolTip.SetToolTip(chkTrayStart, "프로그램 시작시 자동으로 트레이로 숨깁니다.");
            toolTip.SetToolTip(chkAutoStart, "프로그램 시작시 자동으로 모니터링을 실행합니다.");
            toolTip.SetToolTip(btnStart1, "프로그램을 즉시 실행합니다.");
            toolTip.SetToolTip(btnStop1, "프로그램을 즉시 종료합니다.");
            toolTip.SetToolTip(btnDel1, "등록한 정보를 삭제합니다.");
            toolTip.SetToolTip(cmbInterval, "검사 간격을 선택합니다.");
            toolTip.SetToolTip(lblInterval, "검사 간격을 선택합니다.");

            PathTextBox = new TextBox[] { txtPath1, txtPath2, txtPath3, txtPath4, txtPath5 };
            CodeTextBox = new TextBox[] { txtCode1, txtCode2, txtCode3, txtCode4, txtCode5 };
            PathButton = new Button[] { btnBrowse1, btnBrowse2, btnBrowse3, btnBrowse4, btnBrowse5 };
            TypeComboBox = new ComboBox[] { cmbType1, cmbType2, cmbType3, cmbType4, cmbType5 };
            RestartComboBox = new ComboBox[] { cmbRestart1, cmbRestart2, cmbRestart3, cmbRestart4, cmbRestart5 };
            PlayButton = new Button[] { btnStart1, btnStart2, btnStart3, btnStart4, btnStart5 };
            StopButton = new Button[] { btnStop1, btnStop2, btnStop3, btnStop4, btnStop5 };
            EraseButton = new Button[] { btnDel1, btnDel2, btnDel3, btnDel4, btnDel5 };
            RestartTimeComboBox = new DateTimePicker[] { dateTimePicker1,dateTimePicker2, dateTimePicker3, dateTimePicker4, dateTimePicker5};

            btnStartMonitor.Enabled = true; 
            btnStopMonitor.Enabled = false;

            // 환경설정
            Configuration();

			// 버젼(빌드시간)
			this.Text = "MONITORING V1.2";

            //---------------------------------------------------------------
            // 초기화
            //---------------------------------------------------------------
            timerINIT.Start();
        }

        private void timerINIT_Tick(object sender, EventArgs e)
        {
            timerINIT.Stop();

            if (m_sAppPath[0].Length > 0)
            {
                // 자동시작
                if(chkAutoStart.Checked) btnStartMonitor_Click(null, null);

                // 트레이에서 시작
                if(chkTrayStart.Checked) btnhide_Click(null, null);
            }
        }

        //-------------------------------------------------------------
        // 환경설정
        //-------------------------------------------------------------
        private void Configuration()
        {
            try
            {
                String iniPath = Application.StartupPath + "\\config.monitoring.ini";

                /*READ INIFILE */

                // 처리간격
                cmbInterval.Text = IniFile.GetIniValue("OPTION", "INTERVAL", iniPath);
                if (cmbInterval.Text.Length == 0) cmbInterval.Text = "30";
                m_nInterval = Int32.Parse(cmbInterval.Text);

                // 항상위
                chkOnTop.Checked = IniFile.GetIniValue("OPTION", "ALWAYSONTOP", iniPath) == "Y" ? true : false;
                // 트레이시작
                chkTrayStart.Checked = IniFile.GetIniValue("OPTION", "TRAYSTART", iniPath) == "Y" ? true : false;
                // 자동시작
                chkAutoStart.Checked = IniFile.GetIniValue("OPTION", "AUTOSTART", iniPath) == "Y" ? true : false;
                // Mini시작
                chkMinimize.Checked = IniFile.GetIniValue("OPTION", "MINIMIZE", iniPath) == "Y" ? true : false;

                // 프로그램 및 코드
                for (int i = 0; i < 5; i++)
                {
                    // 프로그램
                    m_sAppPath[i] = IniFile.GetIniValue("MONITORING", "PNAME" + (i+1).ToString(), iniPath);  
                    PathTextBox[i].Text = m_sAppPath[i];
                    
                    if (m_sAppPath[i].Length > 0) m_sAppName[i] = Path.GetFileName(m_sAppPath[i]);
                    if (m_sAppName[i] != null && m_sAppName[i].Length > 0)
                    {
                        m_sProcessName[i] = m_sAppName[i].Substring(0, m_sAppName[i].Length - 4);

                        // 코드
                        m_sProcessCode[i] = IniFile.GetIniValue("MONITORING", "PCODE" + (i + 1).ToString(), iniPath);
                        CodeTextBox[i].Text = m_sProcessCode[i];

                        // 방식
                        m_sTypeName[i] = IniFile.GetIniValue("MONITORING", "TYPE" + (i + 1).ToString(), iniPath);
                        TypeComboBox[i].Text = m_sTypeName[i];

                        // 재실행
                        String sRestartName = IniFile.GetIniValue("MONITORING", "RESTART" + (i + 1).ToString(), iniPath);
                        RestartComboBox[i].Text = sRestartName;
                        m_sRestartName[i] = sRestartName.Replace("일", "");

                        // 재실행시간
                        String sRestartTime = IniFile.GetIniValue("MONITORING", "REASTART_TIME" + (i + 1).ToString(), iniPath);
                        m_sRestartTime[i] = sRestartTime;

                        String[] time = sRestartTime.Split(':');
                        DateTime date = DateTime.Today;
                        date = date.AddHours(Convert.ToDouble( time[0]));
                        date = date.AddMinutes(Convert.ToDouble(time[1]));
                        RestartTimeComboBox[i].Value = date;

                        // 코드설정
                        CodeTextBox[i].ReadOnly = false;
                    }
                    else
                    {
                        m_sProcessName[i] = "";
                        CodeTextBox[i].Text = m_sProcessCode[i];

                        // 방식
                        m_sTypeName[i] = "";
                        TypeComboBox[i].Text = m_sTypeName[i];

                        // 재실행
                        m_sRestartName[i] = "";
                        RestartComboBox[i].Text = "";

                        // 재실행시간
                        m_sRestartTime[i] = "";
                        RestartTimeComboBox[i].Text = "";

                        // 코드설정
                        CodeTextBox[i].ReadOnly = true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        //-------------------------------------------------------------
        // 모니터링 시작 & 종료
        //-------------------------------------------------------------
        private void btnStartMonitor_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_sAppPath[0].Length == 0)
                {
                    MessageBox.Show("모니터링 대상 프로그램을 선택하세요.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                for (int i = 0; i < 5; i++)
                {
                    if (TypeComboBox[i].Text == "DB" && CodeTextBox[i].Text == "")
                    {
                        MessageBox.Show("DB방식이면 코드를 입력하여야 합니다.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CodeTextBox[i].Focus();
                        return;
                    }
                    else if(TypeComboBox[i].Text == "" && PathTextBox[i].Text != "")
                    {
                        MessageBox.Show("대상 프로그램의 실행 방식을 선택하여야 합니다.","알림");
                        return;
                    }
                }

                for (int i = 0; i < 5; i++)
                {
                    PathTextBox[i].ReadOnly = true;
                    CodeTextBox[i].ReadOnly = true;
                    PathButton[i].Enabled = false;
                    TypeComboBox[i].Enabled = false;
                    RestartComboBox[i].Enabled = false;
                    PlayButton[i].Enabled = false;
                    StopButton[i].Enabled = false;
                    EraseButton[i].Enabled = false;
                    RestartTimeComboBox[i].Enabled = false;

                }

                // 모니터링 시작
                btnStartMonitor.Enabled = false;
                btnStopMonitor.Enabled = true;
                cmbInterval.Enabled = false;

                // 프로그램 시작여부 확인
                // 실행중인가 검사
                for (int i = 0; i < 5; i++)
                {
                    // 프로세스검사
                    Process[] ProcessName = Process.GetProcessesByName(m_sProcessName[i]);
                    if (ProcessName.Length == 0) startProgram(i);
                }

                // 프로그램 확인 시작
                timerActiveCheck.Interval = m_nInterval * 1000; 
                timerActiveCheck.Start();

                timer1.Start();

            }
            catch (Exception)
            {
            }
        }

        private void btnStopMonitor_Click(object sender, EventArgs e)
        {
            try
            {
                // 모니터링 중지
                timerActiveCheck.Stop();
                timerActiveBody1.Stop();
                timerActiveBody2.Stop();
                
                timer1.Stop();
                timer1.Enabled = false;

                btnStartMonitor.Enabled = true;
                btnStopMonitor.Enabled = false;

                cmbInterval.Enabled = true;

                for (int i = 0; i < 5; i++)
                {
                    PathTextBox[i].ReadOnly = false;
                    CodeTextBox[i].ReadOnly = false;
                    PathButton[i].Enabled = true;
                    TypeComboBox[i].Enabled = true;
                    RestartComboBox[i].Enabled = true;
                    PlayButton[i].Enabled = true;
                    StopButton[i].Enabled = true;
                    EraseButton[i].Enabled = true;
                    RestartTimeComboBox[i].Enabled= true;
                }
            }
            catch (Exception)
            {
            }
        }

        //-------------------------------------------------------------
        // 프로그램 선택
        //-------------------------------------------------------------
        private void selectPath(int inx)
        {
            try
            {
                // 프로그램 선택
                openFileDialog.FileName = m_sAppPath[inx];
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    m_sAppPath[inx] = openFileDialog.FileName;
                    PathTextBox[inx].Text = openFileDialog.FileName;

                    String iniPath = Application.StartupPath + "\\config.monitoring.ini";
                    IniFile.SetIniValue("MONITORING", "PNAME" + (inx + 1).ToString(), m_sAppPath[inx], iniPath);

                    // 환경설정
                    Configuration();

                    lblServerStatus.ForeColor = Color.Black;
                    btnStartMonitor.Enabled = true;
                }

                openFileDialog.Dispose();
            }
            catch (Exception)
            {
            }
        }

        private void btnBrowse1_Click(object sender, EventArgs e)
        {
            selectPath(0);
        }

        private void btnBrowse2_Click(object sender, EventArgs e)
        {
            selectPath(1);
        }

        private void btnBrowse3_Click(object sender, EventArgs e)
        {
            selectPath(2);
        }

        private void btnBrowse4_Click(object sender, EventArgs e)
        {
            selectPath(3);
        }

        private void btnBrowse5_Click(object sender, EventArgs e)
        {
            selectPath(4);
        }

        //-------------------------------------------------------------
        // 프로그램 선택
        //-------------------------------------------------------------
        private void selectProgram(int inx)
        {
            try
            {
                String iniPath = Application.StartupPath + "\\config.monitoring.ini";
                IniFile.SetIniValue("MONITORING", "PNAME" + (inx + 1).ToString(), PathTextBox[inx].Text, iniPath);

                // 환경설정
                Configuration();

                lblServerStatus.ForeColor = Color.Black;
                btnStartMonitor.Enabled = true;
            }
            catch (Exception)
            {
            }
        }

        private void txtPath1_TextChanged(object sender, EventArgs e)
        {
            selectProgram(0);
        }

        private void txtPath2_TextChanged(object sender, EventArgs e)
        {
            selectProgram(1);
        }

        private void txtPath3_TextChanged(object sender, EventArgs e)
        {
            selectProgram(2);
        }

        private void txtPath4_TextChanged(object sender, EventArgs e)
        {
            selectProgram(3);
        }

        private void txtPath5_TextChanged(object sender, EventArgs e)
        {
            selectProgram(4);
        }

        //-------------------------------------------------------------
        // 코드선택
        //-------------------------------------------------------------
        private void selectCode(int inx)
        {
            try
            {
                String iniPath = Application.StartupPath + "\\config.monitoring.ini";
                IniFile.SetIniValue("MONITORING", "PCODE" + (inx + 1).ToString(), CodeTextBox[inx].Text, iniPath);

                // 환경설정
                Configuration();

                lblServerStatus.ForeColor = Color.Black;
                btnStartMonitor.Enabled = true;
            }
            catch (Exception)
            {
            }
        }

        private void txtCode1_TextChanged(object sender, EventArgs e)
        {
            selectCode(0);
        }

        private void txtCode2_TextChanged(object sender, EventArgs e)
        {
            selectCode(1);
        }

        private void txtCode3_TextChanged(object sender, EventArgs e)
        {
            selectCode(2);
        }

        private void txtCode4_TextChanged(object sender, EventArgs e)
        {
            selectCode(3);
        }

        private void txtCode5_TextChanged(object sender, EventArgs e)
        {
            selectCode(4);
        }

        //-------------------------------------------------------------
        // 방식선택
        //-------------------------------------------------------------
        private void selectType(int inx)
        {
            try
            {
                String iniPath = Application.StartupPath + "\\config.monitoring.ini";
                IniFile.SetIniValue("MONITORING", "TYPE" + (inx + 1).ToString(), TypeComboBox[inx].Text, iniPath);

                // 환경설정
                Configuration();

                lblServerStatus.ForeColor = Color.Black;
                btnStartMonitor.Enabled = true;
            }
            catch (Exception)
            {
            }
        }

        private void cmbType1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectType(0);
        }

        private void cmbType2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectType(1);
        }

        private void cmbType3_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectType(2);
        }

        private void cmbType4_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectType(3);
        }

        private void cmbType5_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectType(4);
        }

        //-------------------------------------------------------------
        // 재실행선택
        //-------------------------------------------------------------
        private void selectRestart(int inx)
        {
            try
            {
                String iniPath = Application.StartupPath + "\\config.monitoring.ini";
                IniFile.SetIniValue("MONITORING", "RESTART" + (inx + 1).ToString(), RestartComboBox[inx].Text, iniPath);

                // 환경설정
                Configuration();

                lblServerStatus.ForeColor = Color.Black;
                btnStartMonitor.Enabled = true;
            }
            catch (Exception)
            {
            }
        }

        private void cmbRestart1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectRestart(0);
        }

        private void cmbRestart2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectRestart(1);
        }

        private void cmbRestart3_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectRestart(2);
        }

        private void cmbRestart4_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectRestart(3);
        }

        private void cmbRestart5_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectRestart(4);
        }

        //-------------------------------------------------------------
        // 프로그램 시작
        //-------------------------------------------------------------
        public void startProgram(int inx)
        {
            try
            {
                // 프로그램 시작
                if (m_sProcessName[inx].Length > 0)
                {
                    ProcessStartInfo psi = new ProcessStartInfo();
                    psi.FileName = Path.GetFileName(m_sAppPath[inx]);
                    psi.WorkingDirectory = Path.GetDirectoryName(m_sAppPath[inx]);

                    if(m_sProcessCode[inx] != "")
                        psi.Arguments = m_sProcessCode[inx];

                    // 시작화면형태
                    if(chkMinimize.Checked)
                        psi.WindowStyle = ProcessWindowStyle.Minimized;
                    else
                        psi.WindowStyle = ProcessWindowStyle.Normal;

                    // 프로그램시작 
                    Process.Start(psi);

                    m_bAliveFlag[inx] = true;

                    // 로그출력
                    LogWrite("PROCESS START : " + m_sProcessName[inx]);
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnStart1_Click(object sender, EventArgs e)
        {
            startProgram(0);
        }

        private void btnStart2_Click(object sender, EventArgs e)
        {
            startProgram(1);
        }

        private void btnStart3_Click(object sender, EventArgs e)
        {
            startProgram(2);
        }

        private void btnStart4_Click(object sender, EventArgs e)
        {
            startProgram(3);
        }

        private void btnStart5_Click(object sender, EventArgs e)
        {
            startProgram(4);
        }

        //-------------------------------------------------------------
        // 프로그램 종료
        //-------------------------------------------------------------
        public void stopProgram(int inx)
        {
            try
            {
                Process[] server = Process.GetProcessesByName(m_sProcessName[inx]);
                if (server.Length != 0)
                {
                    server[0].Kill();
                    m_bAliveFlag[inx] = false;

                    // 로그출력
                    LogWrite("PROCESS KILL : " + m_sProcessName[inx]);
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnStop1_Click(object sender, EventArgs e)
        {
            stopProgram(0);
        }

        private void btnStop2_Click(object sender, EventArgs e)
        {
            stopProgram(1);
        }

        private void btnStop3_Click(object sender, EventArgs e)
        {
            stopProgram(2);
        }

        private void btnStop4_Click(object sender, EventArgs e)
        {
            stopProgram(3);
        }

        private void btnStop5_Click(object sender, EventArgs e)
        {
            stopProgram(4);
        }


        //-------------------------------------------------------------
        // 검사처리
        //-------------------------------------------------------------
        private void timerActiveCheck_Tick(object sender, EventArgs e)
        {
            try
            {
                // 타이머 중지
                timerActiveCheck.Stop();


                // 실행중인가 검사
                for(int i=0; i<5; i++) 
                {
                    if (m_sTypeName[i] == "FILE")
                    {
                        // 파일방식
                        pamFileCheck(i);
                        if (!m_bAliveFlag[i]) stopProgram(i);
                    }
                    else if (m_sTypeName[i] == "PROCESS")
                    {
                        // 프로세스검사
                        Process[] ProcessName = Process.GetProcessesByName(m_sProcessName[i]);
                        if (ProcessName.Length == 0)
                        {
                            m_bAliveFlag[i] = false;
                            LogWrite("PROCESS STOPPED " + m_sProcessName[i]);
                        }
                        else
                            ActiveMessage("PROCESS ACTIVE " + m_sProcessName[i]);
                    }
                }

                for(int i=0; i<5; i++) 
                {
                    if (m_bAliveFlag[i] == false) 
                    {
                        // 10초간 대기
                        timerActiveBody1.Interval = 10 * 1000;
                        timerActiveBody1.Start();
                    }
                    else
                    {
                        // 타이머 재시작
                        timerActiveCheck.Interval = m_nInterval * 1000;
                        timerActiveCheck.Start();
                    }
                }

            }
            catch (Exception)
            {
            }
        }

        // 파일 체크 방식이면 파일 읽기
        private void pamFileCheckOld(int inx)
        {
            try
            {
                m_bAliveFlag[inx] = false;

                // 파일읽기
                using (FileStream fs = new FileStream(m_sAppPath[inx] + ".pam", FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    using(StreamReader sr = new StreamReader(fs))
                    {
                        if (sr != null)
                        {
                            String sActiveTime = sr.ReadToEnd();

                            // 파일에 기록된 시간 비교
                            if (sActiveTime.Length >= 19)
                            {
                                DateTime dt;

                                sActiveTime = sActiveTime.Substring(0, 19);
                                if (DateTime.TryParse(sActiveTime, out dt))
                                {
                                    TimeSpan timeDiff = DateTime.Now - dt;
                                    if (timeDiff.Minutes * 60 + timeDiff.Seconds < m_nInterval)
                                    {
                                        ActiveMessage("ACTIVE " + m_sProcessName[inx]);
                                        m_bAliveFlag[inx] = true;
                                    }
                                }
                            }
                        }
                    }
                }

                if (m_bAliveFlag[inx] == false)
                {
                    LogWrite("PROCESS STOPPED : " + m_sProcessName[inx]);
                }
            }
            catch (IOException)
            {
                // 로그출력
                LogWrite("FILE(PAM) LOCKED : " + m_sProcessName[inx]);
                m_bAliveFlag[inx] = true;
            }
        }

        // 파일 체크 방식이면 파일 읽기
        private void pamFileCheck(int inx)
        {
            try
            {
                m_bAliveFlag[inx] = false;

                // 파일읽기
                using (FileStream fs = new FileStream(m_sAppPath[inx] + ".pam", FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        if (sr != null)
                        {
                            String sActiveTime = sr.ReadToEnd();

                            // 파일에 기록된 시간 비교
                            if (sActiveTime.Length >= 52)
                            {
                                DateTime dt;

                                // 시작시간
                                String sStartTime = sActiveTime.Substring(6, 19);
                                bool bRestart = false;

                                // 자동재실행검사
                                if (m_sRestartName[inx] != "안함")
                                {
                                    if (DateTime.TryParse(sStartTime, out dt))
                                    {
                                        TimeSpan timeDiff = DateTime.Now - dt;
                                        if (timeDiff.TotalMinutes > (Int32.Parse(m_sRestartName[inx]) * 60 * 24))
                                        {
                                            // 자동재실행 설정기간이 지났음
                                            bRestart = true;
                                            LogWrite("RESTART(" + m_sRestartName[inx] + "일 경과 재실행) : " + m_sProcessName[inx]);
                                        }
                                    }
                                }

                                // 자동재실행 대상이 아니면 ALIVE 검사
                                if (bRestart == false)
                                {
                                    // 체크시간
                                    String sCheckTime = sActiveTime.Substring(34, 19);
                                    if (DateTime.TryParse(sCheckTime, out dt))
                                    {
                                        TimeSpan timeDiff = DateTime.Now - dt;
                                        if (timeDiff.Minutes * 60 + timeDiff.Seconds < m_nInterval)
                                        {
                                            ActiveMessage("ACTIVE " + m_sProcessName[inx]);
                                            m_bAliveFlag[inx] = true;
                                        }
                                    }
                                }
                            }
                            // 이전버젼이면(프로그램 시작시간없음)
                            else if (sActiveTime.Length >= 19 && sActiveTime.Substring(0,5) != "START")
                            {
                                DateTime dt;

                                String sCheckTime = sActiveTime.Substring(0, 19);
                                if (DateTime.TryParse(sCheckTime, out dt))
                                {
                                    TimeSpan timeDiff = DateTime.Now - dt;
                                    if (timeDiff.Minutes * 60 + timeDiff.Seconds < m_nInterval)
                                    {
                                        ActiveMessage("ACTIVE " + m_sProcessName[inx]);
                                        m_bAliveFlag[inx] = true;
                                    }
                                }
                            }
                        }
                    }
                }

                if (m_bAliveFlag[inx] == false)
                {
                    LogWrite("PROCESS STOPPED : " + m_sProcessName[inx]);
                }
            }
            catch (IOException ex)
            {
                // 로그출력
                LogWrite("FILE(PAM) LOCKED : " + m_sProcessName[inx]);
                m_bAliveFlag[inx] = true;
            }
        }

        //-------------------------------------------------------------
        // 프로그램 재실행
        //-------------------------------------------------------------
        private void timerActiveBody1_Tick(object sender, EventArgs e)
        {
            try
            {
                timerActiveBody1.Stop();

                // 프로그램 재실행
                for(int i=0; i<5; i++)
                {
                    if (!m_bAliveFlag[i])
                    {
                        ProcessStartInfo psi = new ProcessStartInfo();
                        psi.FileName = Path.GetFileName(m_sAppPath[i]);
                        psi.WorkingDirectory = Path.GetDirectoryName(m_sAppPath[i]);

                        if (m_sProcessCode[i] != "")
                            psi.Arguments = m_sProcessCode[i];

                        // 프로세스 시작
                        Process.Start(psi);

                        m_bAliveFlag[i] = true;

                        LogWrite("RESTART " + m_sProcessName[i]);

                        // 10초간 대기
                        timerActiveBody2.Interval = 10 * 1000;
                        timerActiveBody2.Start();
                    }
                }
            }
            catch (Exception)
            {
                timerActiveBody2.Stop();
                timerActiveCheck.Start();
            }
        }

        private void timerActiveBody2_Tick(object sender, EventArgs e)
        {
            try
            {
                timerActiveBody2.Stop();

                // 타이머 재시작
                timerActiveCheck.Interval = m_nInterval * 1000;
                timerActiveCheck.Start();
            }
            catch (Exception)
            {
            }
        }

        //-------------------------------------------------------------
        // 설정
        //-------------------------------------------------------------
        private void cmbInterval_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String iniPath = Application.StartupPath + "\\config.monitoring.ini";
                IniFile.SetIniValue("OPTION", "INTERVAL", cmbInterval.Text, iniPath);
                m_nInterval = Int32.Parse(cmbInterval.Text);
            }
            catch (Exception) 
            {
            }
        }

        private void chkOnTop_CheckedChanged(object sender, EventArgs e)
        {            
            this.TopMost = chkOnTop.Checked;

            String iniPath = Application.StartupPath + "\\config.monitoring.ini";
            IniFile.SetIniValue("OPTION", "ALWAYSONTOP", chkOnTop.Checked ? "Y" : "N", iniPath);
        }

        private void chkTrayStart_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                String iniPath = Application.StartupPath + "\\config.monitoring.ini";
                IniFile.SetIniValue("OPTION", "TRAYSTART", chkTrayStart.Checked ? "Y" : "N", iniPath);
            }
            catch (Exception)
            {
            }
        }

        private void chkAutoStart_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                String iniPath = Application.StartupPath + "\\config.monitoring.ini";
                IniFile.SetIniValue("OPTION", "AUTOSTART", chkAutoStart.Checked ? "Y" : "N", iniPath);
            }
            catch (Exception)
            {
            }
        }

        private void chkMinimize_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                String iniPath = Application.StartupPath + "\\config.monitoring.ini";
                IniFile.SetIniValue("OPTION", "MINIMIZE", chkMinimize.Checked ? "Y" : "N", iniPath);
            }
            catch (Exception)
            {
            }
        }

        //-------------------------------------------------------------
        // 기타처리
        //-------------------------------------------------------------
        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }
        
        private void btnhide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("종료하시겠습니까?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
            else
                notifyIcon1.Dispose(); 
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }
            catch (Exception)
            {
            }
        }

        //-------------------------------------------------------------
        // 삭제처리
        //-------------------------------------------------------------
        private void deleteData(int inx)
        {
            try
            {
                PathTextBox[inx].Text = "";
                CodeTextBox[inx].Text = "";
                TypeComboBox[inx].SelectedIndex = 0;
                RestartComboBox[inx].SelectedIndex = 0;
                RestartTimeComboBox[inx].Text = "";
            }
            catch (Exception)
            {
            }
        }

        private void btnDel1_Click(object sender, EventArgs e)
        {
            deleteData(0);
        }

        private void btnDel2_Click(object sender, EventArgs e)
        {
            deleteData(1);
        }

        private void btnDel3_Click(object sender, EventArgs e)
        {
            deleteData(2);
        }

        private void btnDel4_Click(object sender, EventArgs e)
        {
            deleteData(3);
        }

        private void btnDel5_Click(object sender, EventArgs e)
        {
            deleteData(4);
        }

        private void mnuStart_Click(object sender, EventArgs e)
        {

        }

        //--------------------------------------------------------------------
        // 화면 로그창에 메세지를 출력한다.
        //--------------------------------------------------------------------
        public void LogWrite(String msg)
        {
            LogWriteDelegate deleLogWirte = new LogWriteDelegate(LogWriteBody);
            this.Invoke(deleLogWirte, msg);
        }

        public void LogWriteBody(String msg)
        {
            try
            {
                // 화면에 표시함
                lblServerStatus.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "> " + msg;

                DateTime now = DateTime.Now;
                String sMessage = now.ToString("[yyyy-MM-dd HH:mm:ss] ") + msg;

                // 파일로 저장한다.
                String sPathName = Application.StartupPath + "\\log";
                Directory.CreateDirectory(sPathName);

                String sFileName = String.Format("{0}\\ViVACheck {1}.log", sPathName, DateTime.Now.ToString("yyyy-MM-dd"));

                StreamWriter sw = new StreamWriter(sFileName, true, Encoding.Default);
                sw.WriteLine(sMessage);
                sw.Close();
            }
            catch (Exception ex)
            {
                LogWrite("ERROR(LogWriteBody):" + ex.Message);
            }
        }

        //-------------------------------------------------------------
        // 최종수신시간 표시
        //-------------------------------------------------------------
        public void ActiveMessage(String msg)
        {
            try
            {
                // 소켓 쓰레드와 어플리케이션 쓰레드와 충돌되지 않도록 델리게이트 이용 
                ActiveDelegate deleActive = new ActiveDelegate(ActiveBody);
                this.Invoke(deleActive, msg);
            }
            catch (Exception)
            {
            }
        }

        public void ActiveBody(String msg)
        {
            try
            {
                lblServerStatus.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "> " + msg;
            }
            catch (Exception)
            {
            }
        }

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			/// this.WindowState = FormWindowState.Normal;
			notifyIcon1.Visible = true;
		}


        //-------------------------------------------------------------
        // 재실행시간 설정
        //-------------------------------------------------------------

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
            m_sRestartTime[0] = dateTimePicker1.Value.ToString("HH:mm");
            String iniPath = Application.StartupPath + "\\config.monitoring.ini";
            if (m_sRestartName[0] != "안함")

            {
                IniFile.SetIniValue("MONITORING", "REASTART_TIME" + 1.ToString(), m_sRestartTime[0], iniPath);
            }
            else
                IniFile.SetIniValue("MONITORING", "REASTART_TIME" + 1.ToString(), "00:00", iniPath);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            m_sRestartTime[1] = dateTimePicker2.Value.ToString("HH:mm");
            String iniPath = Application.StartupPath + "\\config.monitoring.ini";
            if (m_sRestartName[1] != "안함")
            {
                IniFile.SetIniValue("MONITORING", "REASTART_TIME" + 2.ToString(), m_sRestartTime[1], iniPath);
            }
            else
                IniFile.SetIniValue("MONITORING", "REASTART_TIME" + 2.ToString(), "00:00", iniPath);
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            m_sRestartTime[2] = dateTimePicker3.Value.ToString("HH:mm");
            String iniPath = Application.StartupPath + "\\config.monitoring.ini";
            if (m_sRestartName[2] != "안함")
            {
                IniFile.SetIniValue("MONITORING", "REASTART_TIME" + 3.ToString(), m_sRestartTime[2], iniPath);
            }
            else
                IniFile.SetIniValue("MONITORING", "REASTART_TIME" + 3.ToString(), "00:00", iniPath);
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {
            m_sRestartTime[3] = dateTimePicker4.Value.ToString("HH:mm");
            String iniPath = Application.StartupPath + "\\config.monitoring.ini";
            if (m_sRestartName[3] != "안함")
            {
                IniFile.SetIniValue("MONITORING", "REASTART_TIME" + 4.ToString(), m_sRestartTime[3], iniPath);
            }
            else
                IniFile.SetIniValue("MONITORING", "REASTART_TIME" + 4.ToString(), "00:00", iniPath);
        }

        private void dateTimePicker5_ValueChanged(object sender, EventArgs e)
        {
            m_sRestartTime[4] = dateTimePicker5.Value.ToString("HH:mm");
            String iniPath = Application.StartupPath + "\\config.monitoring.ini";
            if (m_sRestartName[4] != "안함")
            {
                IniFile.SetIniValue("MONITORING", "REASTART_TIME" + 5.ToString(), m_sRestartTime[4], iniPath);
            }
            else
                IniFile.SetIniValue("MONITORING", "REASTART_TIME" + 5.ToString(), "00:00", iniPath);
        }

        //-------------------------------------------------------------
        // 재실행시간 검사처리
        //-------------------------------------------------------------
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 10000;
            DateTime nowTime = DateTime.ParseExact(DateTime.Now.ToString("HHmm"), "HHmm", System.Globalization.CultureInfo.InvariantCulture);

            for (int i = 0; i < 5;i++)
            {
                if (m_sRestartTime[i] == DateTime.Now.ToString("HH:mm") && m_sRestartName[i] != "안함" && m_sProcessName[i].Length > 0)
                {
                    LogWrite(m_sProcessName[i] + " > 재실행" );
                    stopProgram(i);
                    startProgram(i);

                    // 대기 (60초)
                    timer1.Interval = 60 * 1000;
                }
            }
            
        }

        private void notifyIcon1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {

        }
    }
}
