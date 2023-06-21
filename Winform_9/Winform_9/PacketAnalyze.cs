using System;
using System.Text;
using System.Windows.Forms;
using SharpPcap;
using SharpPcap.LibPcap;
using PacketDotNet;

namespace Winform_9
{
    public partial class PacketAnalyze : Form
    {
        private CaptureDeviceList devices;
        private LibPcapLiveDevice device;

        public PacketAnalyze()
        {
            InitializeComponent();
            GetDeviceList();
        }

        private void GetDeviceList()
        {
            devices = CaptureDeviceList.Instance;
            foreach (var dev in devices)
            {
                deviceListComboBox.Items.Add(dev.Description);
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (deviceListComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("장치를 선택해 주세요.");
                return;
            }

            device = devices[deviceListComboBox.SelectedIndex] as LibPcapLiveDevice;
            device.OnPacketArrival += new PacketArrivalEventHandler(device_OnPacketArrival);
            device.Open(DeviceMode.Promiscuous, 1000);
            device.StartCapture();
        }

        private void device_OnPacketArrival(object sender, CaptureEventArgs e)
        {
            var packet = Packet.ParsePacket(e.Packet.LinkLayerType, e.Packet.Data);
            var ipPacket = (IpPacket)packet.Extract(typeof(IpPacket));
            if (ipPacket == null) return;

            Invoke(new MethodInvoker(delegate
            {
                packetInfoListBox.Items.Add($"TTL: {ipPacket.TimeToLive}, Version: {ipPacket.Version}");
            }));
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            device.StopCapture();
            device.Close();
        }
    }
}