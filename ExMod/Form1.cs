using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Threading;

namespace ExMod
{
    public partial class FrmMaster : Form
    {
        byte slaveID;
        ushort RegisterAddress = 1;
        readonly static int nOK = 1;
        readonly static int nFail = -1;
        List<string> ltStrAddress;
        List<string> ltStr;
        bool bShowReceived = true;
        bool bShowSend = true;

        public FrmMaster()
        {
            InitializeComponent();
        }

        private void FrmMaster_Load(object sender, EventArgs e)
        {
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();

            foreach (string port in ports)
            {
                cmbCom.Items.Add(port);
            }
            cmbCom.SelectedIndex = 0;
            string[] baudrates = { "9600", "19200", "38400", "57600", "115200", "230400" };

            foreach (string baudrate in baudrates)
            {
                cmbBaud.Items.Add(baudrate);
            }

            cmbBaud.SelectedIndex = 0;
            cmbDataBit.SelectedIndex = 0;
            cmbParity.SelectedIndex = 1;
            cmbStopBit.SelectedIndex = 0;
            chkHEX.Checked = true;
            chkHexShow.Checked = true;
            txtDeviceAddr.Text = "1"; //设备地址缺省为1
            ModbusTool.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(comDataReceived);
            chkReceived.Checked = true;
            chkSend.Checked = true;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (ModbusTool.SetComm(cmbCom.SelectedItem.ToString(), int.Parse(cmbBaud.SelectedItem.ToString()), int.Parse(cmbDataBit.SelectedItem.ToString()), cmbParity.SelectedIndex, cmbStopBit.SelectedIndex) == nOK)
            {
                btnOpen.Enabled = false;
                btnClose.Enabled = true;
            }
            else
            {
                MessageBox.Show("设置失败！");
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ModbusTool.CloseComm();
            btnOpen.Enabled = true;
            btnClose.Enabled = false;
        }

        private void cmbCom_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModbusTool.CloseComm();
            btnOpen.Enabled = true;
            btnClose.Enabled = false;
        }

        private void btnSetAddress_Click(object sender, EventArgs e)
        {
            ModbusTool.SetAddress(byte.Parse(txtDeviceAddr.Text));
        }

        private void btnReadHoldingRegister_Click(object sender, EventArgs e)
        {
            if (!ModbusTool.bConnect)
            {
                MessageBox.Show("请先打开串口!");
                return;
            }
            txtWrong.Text = "";
            string strData = "";

            try
            {
                ushort startAddress;
                try
                {
                    startAddress = Convert.ToUInt16(txtStartAddr.Text, 16);
                }
                catch (Exception)
                {
                    MessageBox.Show("请输入正确的起始地址！");
                    return;
                }
                ushort numofPoints;
                bool isValid = ushort.TryParse(txtAmount.Text, out numofPoints);
                if (isValid == false)
                {
                    MessageBox.Show("请输入正确的数量！");
                    return;
                }

                ushort[] register = ModbusTool.ReadHoldingRegisters(startAddress, numofPoints);
                //for (int i = 0; i < numofPoints; i++)
                //{
                //    strData = strData + register[i].ToString() + " ";
                //}
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < numofPoints; i++)
                {
                    sb.Append(register[i].ToString("X4"));
                    if ((i + 1) % 2 == 0)
                    {
                        sb.Append(" ");
                    }
                }
                txtRead.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                //Connection exception
                //No response from server.
                //The server maybe close the com port, or response timeout.
                if (ex.Source.Equals("System"))
                {
                    txtWrong.Text = DateTime.Now.ToString() + " " + ex.Message;
                }
                //The server return error code.
                //You can get the function code and exception code.
                if (ex.Source.Equals("Modbus"))
                {
                    string str = ex.Message;
                    int FunctionCode;
                    string ExceptionCode;

                    str = str.Remove(0, str.IndexOf("\r\n") + 17);
                    FunctionCode = Convert.ToInt16(str.Remove(str.IndexOf("\r\n")));
                    Console.WriteLine("Function Code: " + FunctionCode.ToString("X"));

                    str = str.Remove(0, str.IndexOf("\r\n") + 17);
                    ExceptionCode = str.Remove(str.IndexOf("-"));
                    switch (ExceptionCode.Trim())
                    {
                        case "1":
                            txtWrong.Text = "Exception Code: " + ExceptionCode.Trim() + "----> Illegal function!";
                            break;
                        case "2":
                            txtWrong.Text = "Exception Code: " + ExceptionCode.Trim() + "----> Illegal data address!";
                            break;
                        case "3":
                            txtWrong.Text = "Exception Code: " + ExceptionCode.Trim() + "----> Illegal data value!";
                            break;
                        case "4":
                            txtWrong.Text = "Exception Code: " + ExceptionCode.Trim() + "----> Slave device failure!";
                            break;
                        default:
                            txtWrong.Text = "Exception Code: " + ExceptionCode.Trim() + "----> Read failure!";
                            break;
                    }
                }
            }
        }

        private void btnReadInputRegister_Click(object sender, EventArgs e)
        {
            if (!ModbusTool.bConnect)
            {
                MessageBox.Show("请先打开串口!");
                return;
            }
            txtWrong.Text = "";
            string strData = "";

            try
            {
                ushort startAddress;
                try
                {
                    startAddress = Convert.ToUInt16(txtStartAddr.Text, 16);
                }
                catch (Exception)
                {
                    MessageBox.Show("请输入正确的起始地址！");
                    return;
                }
                ushort numofPoints;
                bool isValid = ushort.TryParse(txtAmount.Text, out numofPoints);
                if (isValid == false)
                {
                    MessageBox.Show("请输入正确的数量！");
                    return;
                }

                ushort[] register = ModbusTool.ReadInputRegisters(startAddress, numofPoints);
                //for (int i = 0; i < numofPoints; i++)
                //{
                //    strData = strData + "," + register[i].ToString();
                //}
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < numofPoints; i++)
                {
                    sb.Append(register[i].ToString("X4"));
                    if ((i + 1) % 2 == 0)
                    {
                        sb.Append(" ");
                    }
                }
                txtRead.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                string str = ex.Message;
                txtWrong.Text = ex.ToString();
            }
        }

        private void btnWriteRegisters_Click(object sender, EventArgs e)
        {
            if (!ModbusTool.bConnect)
            {
                MessageBox.Show("请先打开串口!");
                return;
            }
            txtWrong.Text = "";
            try
            {
                String str = txtWrite.Text.ToString();
                String data = str.Replace(" ", "");
                if (data.Length % 4 != 0)
                {
                    data = "000" + data;
                }
                int dataCount = data.Length / 4;
                int[] arr = new int[dataCount];
                ushort[] uArr = new ushort[dataCount];
                for (int i = dataCount; i > 0; i--)
                {
                    uArr[dataCount - i] = (Convert.ToUInt16(data.Substring(data.Length - 4 * i, 4), 16));
                }
                //for (int i = 0; i < dataCount; i++)
                //{
                //    Buffer.BlockCopy(arr, 4 * i, uArr, 4 * i, 4);
                //}
                //List<ushort> listData = new List<ushort>();
                ushort startAddress;
                try
                {
                    startAddress = Convert.ToUInt16(txtStartAddr.Text, 16);
                }
                catch (Exception)
                {
                    MessageBox.Show("请输入正确的起始地址！");
                    return;
                }
                ModbusTool.WriteMultipleRegisters(startAddress, uArr);
            }
            catch (Exception ex)
            {
                string str = ex.Message;
                txtWrong.Text = ex.ToString();
            }
        }

        private void btnCRC_Click(object sender, EventArgs e)
        {
            String str = txtComData.Text.ToString();
            byte[] arr = null;
            try
            {
                arr = StrToHexByte(str);
            }
            catch (Exception)
            {
                //txtWrong.Text = "请输入16进制格式数据!";
                MessageBox.Show("非16进制格式数据!");
                return;
            }
            byte[] crc;
            crc = BytesCheck.GetCRC16(arr, true);
            txtCRC.Text = crc[0].ToString("X2") + crc[1].ToString("X2");
            if (!ModbusTool.bConnect)
            {
                MessageBox.Show("请先打开串口!");
                return;
            }

            str += txtCRC.Text;
            byte[] arrCRC = arr.Concat(crc).ToArray(); ;
            if (arrCRC.Length > 0)
            {
                ModbusTool.serialPort.Write(arrCRC, 0, arrCRC.Length);
                if (bShowSend)
                {
                    txtSend.AppendText(str + "\r\n");
                    txtSend.ScrollToCaret();
                }
            }
        }

        private void btnSendAny_Click(object sender, EventArgs e)
        {
            txtWrong.Text = "";
            if (!ModbusTool.bConnect)
            {
                MessageBox.Show("请先打开串口!");
                return;
            }
            String str = txtComData.Text.ToString();
            if (chkHEX.Checked)
            {
                byte[] arr = null;
                try
                {
                    arr = StrToHexByte(str);
                }
                catch (Exception)
                {
                    //txtWrong.Text = "请输入16进制格式数据!";
                    MessageBox.Show("非16进制格式数据!");
                    return;
                }
                ModbusTool.serialPort.Write(arr, 0, arr.Length);
            }
            else
            {
                ModbusTool.serialPort.Write(str);
            }
            if (bShowSend)
            {
                txtSend.AppendText(str + "\r\n");
                txtSend.ScrollToCaret();
            }
        }

        /// <summary>
        /// 字符串转16进制字节数组
        /// </summary>
        /// <param name="HexStr"></param>
        /// <returns></returns>
        private byte[] StrToHexByte(string HexStr)
        {
            HexStr = HexStr.Replace(" ", "");
            if (HexStr.Length % 2 != 0)
            {
                HexStr = "0" + HexStr;
            }
            byte[] bytes = new byte[(HexStr.Length) / 2];
            for (int i = 0; i < (HexStr.Length) / 2; i++)
            {
                bytes[i] = Convert.ToByte(HexStr.Substring(2 * i, 2), 16);
            }
            return bytes;
        }

        /// <summary>
        /// 字节数组转16进制字符串
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static string byteToHexStr(byte[] bytes)
        {
            string HexStr = "";
            if (bytes != null)
            {
                for (int i = 0; i < bytes.Length; i++)
                {
                    HexStr += bytes[i].ToString("X2");
                }
            }
            return HexStr;
        }

        private void lnkHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("Help.txt");
        }
        string FileOpened;
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            btnSendFile.Enabled = false;
            var dlg = new OpenFileDialog();
            dlg.RestoreDirectory = true;
            dlg.Filter = "Files(*.xlsx *.csv *.txt)|*.xlsx;*.csv;*.txt"; //|CSV files(*.csv)||Text files(*.txt)|
            var r = dlg.ShowDialog(this);
            if (r == DialogResult.OK)
            {
                var path = dlg.FileName;
                txtPath.Text = path;
                string ext = Path.GetExtension(path);
                if (ext == ".xlsx")
                {
                    ReadExcel(txtPath.Text); //读取Excel文件
                }
                else
                {
                    ReadCsv(txtPath.Text); //读取CSV、文本文件
                }
            }
            btnSendFile.Enabled = true;
        }

        bool bManualStop;
        private void btnSendFile_Click(object sender, EventArgs e)
        {
            if (!ModbusTool.bConnect)
            {
                MessageBox.Show("请先打开串口!");
                return;
            }
            int nRet;
            if (string.IsNullOrEmpty(txtPath.Text))
            {
                MessageBox.Show("Please select an excel file first!");
                return;
            }
            if (FileOpened != txtPath.Text.Trim()) //允许手动编辑文件路径
            {
                if (File.Exists(txtPath.Text))
                {
                    if (Path.GetExtension(txtPath.Text.Trim()) == ".xlsx")
                    {
                        ReadExcel(txtPath.Text); //读取Excel文件
                    }
                    else
                    {
                        ReadCsv(txtPath.Text); //读取CSV、文本文件
                    }
                }
                else
                {
                    MessageBox.Show("The file does not exist!");
                    return;
                }
            }

            try
            {
                bool bModbus = chkModbus.Checked;
                bool bWithAddr = chkAddressColumn.Checked;
                bool bHex = chkHEX.Checked;
                int nDelay, nFrom, nTo;
                int.TryParse(txtDelay.Text, out nDelay);
                int.TryParse(txtFrom.Text, out nFrom);
                int.TryParse(txtTo.Text, out nTo);
                if (bModbus && !bWithAddr)
                {
                    try
                    {
                        RegisterAddress = Convert.ToUInt16(txtRegAddr.Text, 16);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("请输入正确的寄存器起始地址！");
                        return;
                    }
                }
                if (!chkLine.Checked)
                {
                    if (nFrom < 1)
                    {
                        nFrom = 1;
                    }
                    if (nTo < 1)
                    {
                        nTo = ltStrAddress.Count;
                    }
                    bManualStop = false;
                    btnSendFile.Enabled = false;
                    for (int i = nFrom; i <= nTo && !bManualStop; i++)
                    {
                        txtCurLine.Text = i.ToString();
                        nRet = SendLine(i, bModbus, bWithAddr, bHex);
                        if (nRet == 1)
                        {
                            MessageBox.Show("数据非16进制格式!");
                            return;
                        }
                        else if (nRet == 2)
                        {
                            MessageBox.Show("地址非16进制格式!");
                            return;
                        }
                        Thread.Sleep(nDelay);
                        Application.DoEvents();
                    }
                    btnSendFile.Enabled = true;
                }
                else //单行手动
                {
                    int nId;
                    int.TryParse(txtFrom.Text, out nId);
                    if (nId < 1)
                    {
                        nId = 1;
                        txtFrom.Text = "1";
                    }
                    nRet = SendLine(nId, bModbus, bWithAddr, bHex);
                    if (nRet == 1)
                    {
                        MessageBox.Show("数据非16进制格式!");
                        return;
                    }
                    else if (nRet == 2)
                    {
                        MessageBox.Show("地址非16进制格式!");
                        return;
                    }
                    nId++;
                    txtFrom.Text = nId.ToString();
                }
            }
            catch (Exception ex)
            {
                txtWrong.Text = ex.ToString();
            }
        }

        //发送一行数据，一行内容中包括地址和数据，如果不选择“第一列为地址”，则地址也作为数据发送
        private int SendLine(int nLineId, bool bModbus, bool bWithAddress, bool bHex)
        {
            string address = ltStrAddress[nLineId - 1].Replace(" ", "");
            String str = "";
            String data = "";
            if (ltStr.Count >= nLineId)
            {
                str = ltStr[nLineId - 1].Replace(" ", "");
            }
            if (bWithAddress)
            {
                data = str;
            }
            else
            {
                data = address + str; //如果不选择“第一列为地址”，则地址也作为数据发送
            }
            if (bModbus)
            {
                if (data.Length % 2 != 0)
                {
                    data = "0" + data;
                }
                if (data.Length % 4 != 0) //发送以字为单位，即ushort
                {
                    data = "00" + data;
                }
                int dataCount = (data.Length) / 2;
                ushort[] uArr = new ushort[dataCount / 2];
                string subStr;
                for (int i = 0; i < dataCount / 2; i++)
                {
                    subStr = data.Substring(4 * i, 4);
                    uArr[i] = Convert.ToUInt16(subStr, 16);
                }
                ushort startAddress = 0;
                if (bWithAddress)
                {
                    try
                    {
                        startAddress = Convert.ToUInt16(address, 16);
                    }
                    catch (Exception)
                    {
                        return 2;
                    }
                }
                else
                {
                    startAddress = RegisterAddress;
                }
                ModbusTool.WriteMultipleRegisters(startAddress, uArr);
                if (txtSend.Text.Length > 1000000)
                {
                    txtSend.Text = "";
                }
                if (bShowSend)
                {
                    if (bWithAddress)
                    {
                        data = address + "," + data;
                    }
                    txtSend.AppendText(data + "\r\n");
                    txtSend.ScrollToCaret();
                }
            }
            else //如果不是Modbus才考虑是否16进制发送
            {
                if (!bHex) //ASCII码发送Excel中内容
                {
                    if (data.Length > 0)
                    {
                        ModbusTool.serialPort.Write(data);
                        if (txtSend.Text.Length > 1000000)
                        {
                            txtSend.Text = "";
                        }
                        if (bShowSend)
                        {
                            txtSend.AppendText(data + "\r\n");
                            txtSend.ScrollToCaret();
                        }
                    }
                }
                else
                {
                    byte[] arr = null;
                    try
                    {
                        arr = StrToHexByte(data);
                    }
                    catch (Exception)
                    {
                        return 1;
                    }
                    if (data.Length > 0)
                    {
                        ModbusTool.SendAny(arr, 0, arr.Length);
                        if (txtSend.Text.Length > 1000000)
                        {
                            txtSend.Text = "";
                        }
                        if (bShowSend)
                        {
                            txtSend.AppendText(data + "\r\n");
                            txtSend.ScrollToCaret();
                        }
                    }
                }
            }
            return 0;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            bManualStop = true;
            btnSendFile.Enabled = true;
        }

        //Excel工作表数据转为DataTable，未引用，仅保留
        DataTable ReadByExcelLibrary(string excelFilePath) //Stream xlsStream
        {
            DataTable table = new DataTable();
            FileInfo fi = new FileInfo(excelFilePath);
            using (ExcelPackage package = new ExcelPackage(fi))
            {
                ExcelWorksheet sheet = package.Workbook.Worksheets[1];

                int colCount = sheet.Dimension.End.Column;
                int rowCount = sheet.Dimension.End.Row;

                for (ushort j = 1; j <= colCount; j++)
                {
                    table.Columns.Add(new DataColumn(j.ToString()));
                    //table.Columns.Add(new DataColumn(sheet.Cells[1, j].Value.ToString()));
                }

                for (ushort i = 1; i <= rowCount; i++)
                {
                    DataRow row = table.NewRow();
                    for (ushort j = 1; j <= colCount; j++)
                    {
                        row[j - 1] = sheet.Cells[i, j].Value;
                    }
                    table.Rows.Add(row);
                }
            }

            return table;
        }

        //读Excel文件，第1列放到ltStrAddress中，第2列及后面的所有数据都放到ltStr中，如果只有第1列有数据，则ltStr无数据
        void ReadExcel(string filePath)
        {
            FileInfo fi = new FileInfo(filePath);
            ltStrAddress = new List<string>();
            ltStr = new List<string>();
            try
            {
                using (ExcelPackage package = new ExcelPackage(fi))
                {
                    ExcelWorksheet sheet = package.Workbook.Worksheets[1];

                    int colCount = sheet.Dimension.End.Column;
                    int rowCount = sheet.Dimension.End.Row;

                    string strAddress, strData;
                    string str;
                    for (int i = 1; i <= rowCount; i++)
                    {
                        strAddress = "";
                        strData = "";
                        for (int j = 1; j <= colCount; j++)
                        {
                            if (sheet.Cells[i, j].Value != null)
                            {
                                if (j == 1) //第1列保存为寄存器地址
                                {
                                    strAddress = sheet.Cells[i, j].Value.ToString();
                                }
                                else
                                {
                                    str = sheet.Cells[i, j].Value.ToString();
                                    str = str.Replace(" ", "");
                                    if (str.Length % 2 > 0) //单元格内数据位数格式化为偶数位，即字节数据
                                    {
                                        str = "0" + str;
                                    }
                                    strData += str;
                                }
                            }
                        }
                        if (strAddress.Length > 0) //如果第一列单元格中有数据
                        {
                            ltStrAddress.Add(strAddress);
                            if (strData != "")
                            {
                                ltStr.Add(strData);
                            }
                        }
                    }
                }

                FileOpened = filePath;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //读CSV或文本文件，文本文件也按照CSV格式处理。处理方式与Excel类似。第1个逗号之前的数据放到ltStrAddress中，后面的所有数据都放到ltStr中，如果此行没有逗号，则ltStr无数据
        void ReadCsv(string filePath)
        {
            ltStr = new List<string>();
            ltStrAddress = new List<string>();
            Encoding encoding = GetType(filePath); //Encoding.ASCII;//
            DataTable dt = new DataTable();
            FileStream fs = new FileStream(filePath, System.IO.FileMode.Open, System.IO.FileAccess.Read);

            //StreamReader sr = new StreamReader(fs, Encoding.UTF8);
            StreamReader sr = new StreamReader(fs, encoding);
            string strLine = "", str = "";
            string strData = "";
            string strAddress = "";
            while ((strLine = sr.ReadLine()) != null)
            {
                var arrStr = strLine.Split(',');
                if (arrStr.Length > 0)
                {
                    strAddress = arrStr[0];
                    ltStrAddress.Add(strAddress);
                }

                strData = "";
                if (arrStr.Length > 1)
                {
                    for (int i = 1; i < arrStr.Length; i++)
                    {
                        arrStr[i]=arrStr[i].Replace(" ", "");
                        if (arrStr[i].Length % 2 > 0) //一组内数据位数格式化为偶数位，即字节数据
                        {
                            arrStr[i] = "0" + arrStr[i];
                        }
                        strData += arrStr[i];
                    }
                    if (strData != "")
                    {
                        ltStr.Add(strData);
                    }
                }
            }
            FileOpened = filePath;
            sr.Close();
            fs.Close();
        }
        /// 给定文件的路径，读取文件的二进制数据，判断文件的编码类型
        /// <param name="FILE_NAME">文件路径</param>
        /// <returns>文件的编码类型</returns>

        public static System.Text.Encoding GetType(string FILE_NAME)
        {
            System.IO.FileStream fs = new System.IO.FileStream(FILE_NAME, System.IO.FileMode.Open,
                System.IO.FileAccess.Read);
            System.Text.Encoding r = GetType(fs);
            fs.Close();
            return r;
        }

        /// 通过给定的文件流，判断文件的编码类型
        /// <param name="fs">文件流</param>
        /// <returns>文件的编码类型</returns>
        public static System.Text.Encoding GetType(System.IO.FileStream fs)
        {
            byte[] Unicode = new byte[] { 0xFF, 0xFE, 0x41 };
            byte[] UnicodeBIG = new byte[] { 0xFE, 0xFF, 0x00 };
            byte[] UTF8 = new byte[] { 0xEF, 0xBB, 0xBF }; //带BOM
            System.Text.Encoding reVal = System.Text.Encoding.Default;

            System.IO.BinaryReader r = new System.IO.BinaryReader(fs, System.Text.Encoding.Default);
            int i;
            int.TryParse(fs.Length.ToString(), out i);
            byte[] ss = r.ReadBytes(i);
            if (IsUTF8Bytes(ss) || (ss[0] == 0xEF && ss[1] == 0xBB && ss[2] == 0xBF))
            {
                reVal = System.Text.Encoding.UTF8;
            }
            else if (ss[0] == 0xFE && ss[1] == 0xFF && ss[2] == 0x00)
            {
                reVal = System.Text.Encoding.BigEndianUnicode;
            }
            else if (ss[0] == 0xFF && ss[1] == 0xFE && ss[2] == 0x41)
            {
                reVal = System.Text.Encoding.Unicode;
            }
            r.Close();
            return reVal;
        }

        /// 判断是否是不带 BOM 的 UTF8 格式
        /// <param name="data"></param>
        /// <returns></returns>
        private static bool IsUTF8Bytes(byte[] data)
        {
            int charByteCounter = 1;　 //计算当前正分析的字符应还有的字节数
            byte curByte; //当前分析的字节.
            for (int i = 0; i < data.Length; i++)
            {
                curByte = data[i];
                if (charByteCounter == 1)
                {
                    if (curByte >= 0x80)
                    {
                        //判断当前
                        while (((curByte <<= 1) & 0x80) != 0)
                        {
                            charByteCounter++;
                        }
                        //标记位首位若为非0 则至少以2个1开始 如:110XXXXX...........1111110X　
                        if (charByteCounter == 1 || charByteCounter > 6)
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    //若是UTF-8 此时第一位必须为1
                    if ((curByte & 0xC0) != 0x80)
                    {
                        return false;
                    }
                    charByteCounter--;
                }
            }
            if (charByteCounter > 1)
            {
                throw new Exception("非预期的byte格式");
            }
            return true;
        }

        private void comDataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            Invoke((EventHandler)(delegate
            {
                int nRead = ModbusTool.serialPort.BytesToRead;
                var arrData = new byte[nRead];
                ModbusTool.serialPort.Read(arrData, 0, nRead);
                string str = "";
                if (chkHexShow.Checked)
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < nRead; i++)
                    {
                        sb.Append(arrData[i].ToString("X2"));
                        if ((i + 1) % 4 == 0)
                        {
                            sb.Append(" ");
                        }
                    }
                    if (bShowReceived)
                    {
                        txtReceived.AppendText(sb.ToString() + "\r\n");
                        txtReceived.ScrollToCaret();
                    }
                }
                else //非16进制显示方式1，可选择编码方式
                {
                    Encoding encode = Encoding.UTF8;
                    str = encode.GetString(arrData);
                    //str = ModbusTool.serialPort.ReadExisting(); //非16进制显示方式2
                    if (bShowReceived)
                    {
                        txtReceived.AppendText(str + "\r\n");
                        txtReceived.ScrollToCaret();
                    }
                }
                if (txtReceived.Text.Length > 100000)
                {
                    string rxStr = txtReceived.Text;
                    txtReceived.Text = "";
                    Thread th = new Thread(() =>
                    {
                        string fName = DateTime.Now.ToString("yyMMddHHmmss");
                        FileStream fs = new FileStream(fName + ".txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                        StreamWriter sw = new StreamWriter(fs);
                        sw.WriteLine(rxStr);
                        sw.Close(); //关闭文件                
                    });
                    th.IsBackground = true;
                    th.Start();
                }
            }));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtReceived.Text = "";
            txtSend.Text = "";
        }

        private void chkReceived_CheckedChanged(object sender, EventArgs e)
        {
            bShowReceived = chkReceived.Checked;
        }

        private void chkSend_CheckedChanged(object sender, EventArgs e)
        {
            bShowSend = chkSend.Checked;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

        }
    }
}
