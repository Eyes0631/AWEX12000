using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VisionCommunication
{
    internal class JMemoryMapped : IDisposable
    {
        private MemoryMappedFile m_ShareMem = null;
        private Mutex mShareMemMutex = null;
        private string m_MemName = string.Empty;
        private long m_MemSize = Int64.MaxValue;

        public JMemoryMapped()
        {
        }

        public void Dispose()
        {
            CloseMem();
        }

        public bool OpenMem(string _name, long _size)
        {
            bool bRet = false;
            try
            {
                m_ShareMem = MemoryMappedFile.CreateOrOpen(_name, _size, MemoryMappedFileAccess.ReadWrite);
                if (m_ShareMem != null)
                {
                    m_MemName = _name;
                    m_MemSize = _size;
                    mShareMemMutex = new Mutex(false, m_MemName + "_MUTEX");
                    if (mShareMemMutex != null)
                    {
                        bRet = true;
                    }
                }
            }
            catch (Exception )//ex)
            {
            }
            finally
            {
            }
            return bRet;
        }

        public void CloseMem()
        {
            m_ShareMem.Dispose();
            mShareMemMutex.Dispose();
        }

        public bool ReadBytes(ref byte[] _data, int _offset, int _size)
        {
            bool bRet = false;
            mShareMemMutex.WaitOne();
            try
            {
                using (MemoryMappedViewStream stream = m_ShareMem.CreateViewStream(_offset, _size))
                {
                    using (var br = new BinaryReader(stream))
                    {
                        _data = br.ReadBytes(_size);
                        bRet = true;
                    }
                }
            }
            catch (Exception )//ex)
            {
            }
            finally
            {
                mShareMemMutex.ReleaseMutex();
            }
            return bRet;
        }

        public bool WriteBytes(byte[] _data, int _offset, int _size)
        {
            bool bRet = false;
            mShareMemMutex.WaitOne();
            try
            {
                byte[] dataArray = new byte[_size];
                dataArray.Initialize();
                int dataArrayLength = Math.Min(_data.Length, _size);
                Array.Copy(_data, dataArray, dataArrayLength);
                using (MemoryMappedViewStream stream = m_ShareMem.CreateViewStream(_offset, _size))
                {
                    using (var bw = new BinaryWriter(stream))
                    {
                        bw.Write(dataArray);
                        bRet = true;
                    }
                }
            }
            catch (Exception )//ex)
            {
            }
            finally
            {
                mShareMemMutex.ReleaseMutex();
            }
            return bRet;
        }
    }
}