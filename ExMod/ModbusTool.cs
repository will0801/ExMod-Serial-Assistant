using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using log4net;
using Modbus.Device;    //for modbus master
using System.IO.Ports;  //for serial port

namespace ExMod
{
    public static class ModbusTool
    {
        private static readonly ILog _logger = LogManager.GetLogger(typeof(ModbusSlave));
        public static SerialPort serialPort = new SerialPort(); //create a new SerialPort object with default settings.
        static ModbusSerialMaster master;
        static byte slaveID = 1;
        readonly static int nOK = 1;
        readonly static int nFail = -1;
        public static bool bConnect = false;

        public static void SetAddress(byte Id)
        {
            slaveID = Id;
        }

        public static int SetComm(string portName, int baudRate, int dataBits, int nParity, int stopBits)
        {
            if (serialPort == null)//未初始化时允许设置串口来代替初始化
            {
                serialPort = new SerialPort();
            }
            serialPort.Close();//如果串口打开先关闭
            serialPort.PortName = portName;
            serialPort.BaudRate = baudRate;
            serialPort.DataBits = dataBits;
            //get parity
            if (nParity == 0)
                serialPort.Parity = Parity.None;
            else if (nParity == 1)
                serialPort.Parity = Parity.Even;
            else
                serialPort.Parity = Parity.Odd;
            //get stopBit 
            if (stopBits == 0)
                serialPort.StopBits = StopBits.One;
            else
                serialPort.StopBits = StopBits.Two;

            try
            {
                serialPort.Open();
                master = ModbusSerialMaster.CreateRtu(serialPort);
                master.Transport.Retries = 0;   //don't have to do retries
                master.Transport.ReadTimeout = 300; //milliseconds
                bConnect = true;
                _logger.Info(DateTime.Now.ToString() + " =>Open " + serialPort.PortName + " sucessfully!");
                return nOK;
            }
            catch (Exception ex)
            {
                _logger.Error("Error: " + ex.Message);
                return nFail;
            }

        }

        public static void CloseComm()
        {
            bConnect = false;
            serialPort.Close();
        }

        /// <summary>
        /// 发送任意串口数据
        /// </summary>
        public static void SendAny(byte[] comData, int offset, int count)
        {
            serialPort.Write(comData, offset, count);
        }

        public static ushort[] ReadHoldingRegisters(ushort startAddress, ushort numofPoints)
        {
            ushort[] uArr = new ushort[numofPoints];
            try
            {
                uArr = master.ReadHoldingRegisters(slaveID, startAddress, numofPoints);
            }
            catch (Exception ex)
            {
                _logger.Error("Error: " + ex.Message);
            }
            return uArr;
        }

        public static ushort[] ReadInputRegisters(ushort startAddress, ushort numofPoints)
        {
            ushort[] uArr = new ushort[numofPoints];
            try
            {
                uArr = master.ReadInputRegisters(slaveID, startAddress, numofPoints);
            }
            catch (Exception ex)
            {
                _logger.Error("Error: " + ex.Message);
            }
            return uArr;
        }

        public static int WriteMultipleRegisters(ushort startAddress, ushort[] data)
        {
            try
            {
                master.WriteMultipleRegisters(slaveID, startAddress, data);
                return nOK;
            }
            catch (Exception ex)
            {
                _logger.Error("Error: " + ex.Message);
                return nFail;
            }
        }


        #region Common:Write data
        public static int SetValue(int nValue, ushort startAddress)//int数据写入寄存器
        {
            ushort[] uArr = IntToUshort(nValue);
            try
            {
                master.WriteMultipleRegisters(slaveID, startAddress, uArr);
                return nOK;
            }
            catch (Exception ex)
            {
                _logger.Error("Error: " + ex.Message);
                return nFail;
            }
        }

        public static int SetValue(uint nValue, ushort startAddress)//int数据写入寄存器
        {
            ushort[] uArr = UIntToUshort(nValue);
            try
            {
                master.WriteMultipleRegisters(slaveID, startAddress, uArr);
                return nOK;
            }
            catch (Exception ex)
            {
                _logger.Error("Error: " + ex.Message);
                return nFail;
            }
        }

        public static float SetValue(float fValue, ushort startAddress)//float数据写入寄存器
        {
            ushort[] uArr = FloatToUshort(fValue);
            try
            {
                master.WriteMultipleRegisters(slaveID, startAddress, uArr);
                return nOK;
            }
            catch (Exception ex)
            {
                _logger.Error("Error: " + ex.Message);
                return nFail;
            }
        }
        #endregion

        #region Common:Read data
        public static int GetIntValueFromHolding(ushort startAddress)//从Holding寄存器读取int数据
        {
            ushort[] uArr = new ushort[2];
            try
            {
                uArr = master.ReadHoldingRegisters(slaveID, startAddress, 2);
                return nOK;
            }
            catch (Exception ex)
            {
                _logger.Error("Error: " + ex.Message);
            }
            return UshortToInt(uArr);
        }

        public static uint GetUintValueFromHolding(ushort startAddress)//从Holding寄存器读取uint数据
        {
            ushort[] uArr = new ushort[2];
            try
            {
                uArr = master.ReadHoldingRegisters(slaveID, startAddress, 2);

            }
            catch (Exception ex)
            {
                _logger.Error("Error: " + ex.Message);
            }
            return UshortToUInt(uArr);
        }

        public static float GetFloatValueFromHolding(ushort startAddress)//从Holding寄存器读取float数据
        {
            ushort[] uArr = new ushort[2];
            try
            {
                uArr = master.ReadHoldingRegisters(slaveID, startAddress, 2);

            }
            catch (Exception ex)
            {
                _logger.Error("Error: " + ex.Message);
            }
            return UshortToFloat(uArr);
        }

        public static int GetIntValueFromInput(ushort startAddress)//从Input寄存器读取int数据
        {
            ushort[] uArr = new ushort[2];
            try
            {
                uArr = master.ReadInputRegisters(slaveID, startAddress, 2);

            }
            catch (Exception ex)
            {
                _logger.Error("Error: " + ex.Message);
            }
            return UshortToInt(uArr);
        }

        public static uint GetUintValueFromInput(ushort startAddress)//从Input寄存器读取uint数据
        {
            ushort[] uArr = new ushort[2];
            try
            {
                uArr = master.ReadInputRegisters(slaveID, startAddress, 2);

            }
            catch (Exception ex)
            {
                _logger.Error("Error: " + ex.Message);
            }
            return UshortToUInt(uArr);
        }

        public static float GetFloatValueFromInput(ushort startAddress)//从Input寄存器读取float数据
        {
            ushort[] uArr = new ushort[2];
            try
            {
                uArr = master.ReadInputRegisters(slaveID, startAddress, 2);

            }
            catch (Exception ex)
            {
                _logger.Error("Error: " + ex.Message);
            }
            return UshortToFloat(uArr);
        }

        #endregion

        #region Data Conversion
        public static ushort[] IntToUshort(int nInput)
        {
            int[] nData = new int[1];
            nData[0] = nInput;
            ushort[] uArr = new ushort[2];
            Buffer.BlockCopy(nData, 0, uArr, 0, 4);
            return uArr;
        }

        public static ushort[] UIntToUshort(uint nInput)
        {
            uint[] nData = new uint[1];
            nData[0] = nInput;
            ushort[] uArr = new ushort[2];
            Buffer.BlockCopy(nData, 0, uArr, 0, 4);
            return uArr;
        }

        public static ushort[] FloatToUshort(float fInput)
        {
            float[] floatData = new float[1];
            floatData[0] = fInput;
            ushort[] uArr = new ushort[2];
            Buffer.BlockCopy(floatData, 0, uArr, 0, 4);
            return uArr;
        }

        public static int UshortToInt(ushort[] uArr)
        {
            int[] nData = new int[1];
            Buffer.BlockCopy(uArr, 0, nData, 0, 4);
            return nData[0];
        }

        public static uint UshortToUInt(ushort[] uArr)
        {
            uint[] nData = new uint[1];
            Buffer.BlockCopy(uArr, 0, nData, 0, 4);
            return nData[0];
        }

        public static float UshortToFloat(ushort[] uArr)
        {
            float[] floatData = new float[1];
            Buffer.BlockCopy(uArr, 0, floatData, 0, 4);
            return floatData[0];
        }
        #endregion

    }
}
