using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecDescTool
{
    public partial class SecurityDescriptorGenerator : Form
    {
        [DllImport("user32", SetLastError = true)]
        static extern bool OpenClipboard(IntPtr hwndNewOwner);

        [DllImport("user32", SetLastError = true)]
        static extern bool CloseClipboard();

        [DllImport("user32", SetLastError = true)]
        static extern bool EmptyClipboard();

        [DllImport("user32", SetLastError = true)]
        static extern bool SetClipboardData(uint format, IntPtr data);

        [DllImport("user32", SetLastError = true)]
        static extern uint RegisterClipboardFormat(string format);

        [DllImport("kernel32")]
        static extern IntPtr GlobalAlloc(uint flags, UIntPtr bytes);

        [DllImport("kernel32")]
        static extern IntPtr GlobalLock(IntPtr hMem);

        [DllImport("kernel32")]
        static extern bool GlobalUnlock(IntPtr hMem);

        const uint GHND = 0x0042;

        private uint _hexDataClipboardFormat;
        private byte[] _bytes;

        public SecurityDescriptorGenerator()
        {
            _hexDataClipboardFormat = RegisterClipboardFormat("RegEdit_HexData");
            InitializeComponent();
        }

        private void _sddlText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var rawSd = new RawSecurityDescriptor(_sddlText.Text);
                _bytes = new byte[rawSd.BinaryLength];

                rawSd.GetBinaryForm(_bytes, 0);
                _sdBinary.Text = string.Join("", _bytes.Select(b => b.ToString("X2")));
                _copy.Enabled = true;
            }
            catch (Exception ex)
            {
                _sdBinary.Text = ex.ToString();
                _copy.Enabled = false;
            }
        }

        private void _copy_Click(object sender, EventArgs e)
        {
            var data = new byte[_bytes.Length + 7];

            data[0] = (byte)((uint)_bytes.Length & 0xFF);
            data[1] = (byte)(((uint)_bytes.Length >> 8) & 0xFF);
            data[2] = (byte)(((uint)_bytes.Length >> 16) & 0xFF);
            data[3] = (byte)(((uint)_bytes.Length >> 24) & 0xFF);
            Buffer.BlockCopy(_bytes, 0, data, 4, _bytes.Length);

            if (OpenClipboard(Handle))
            {
                var hMem = GlobalAlloc(GHND, (UIntPtr)data.Length);
                var ptr = GlobalLock(hMem);

                Marshal.Copy(data, 0, ptr, data.Length);
                GlobalUnlock(hMem);
                EmptyClipboard();
                SetClipboardData(_hexDataClipboardFormat, hMem);
                CloseClipboard();
            }
        }
    }
}
