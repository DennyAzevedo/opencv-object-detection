using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DirectShowLib;
using Emgu.CV.UI;
using Emgu.CV.Util;
using Emgu.Util;
using System.Windows.Forms;

namespace ObjectDetection
{
    class videoUtility

    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cbDanhSachCamera"></param>
        public void getAllCamera(ComboBox cbDanhSachCamera)
        {
            List<KeyValuePair<int, string>> ListCamerasData = new List<KeyValuePair<int, string>>();
            DsDevice[] _SystemCamereas = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);
            int _DeviceIndex = 0;
            foreach (DirectShowLib.DsDevice _Camera in _SystemCamereas)
            {
                ListCamerasData.Add(new KeyValuePair<int, string>(_DeviceIndex, _Camera.Name));
                _DeviceIndex++;
                cbDanhSachCamera.Items.Add(_DeviceIndex.ToString() + "-" + _Camera.Name);
            }
            cbDanhSachCamera.SelectedIndex = 0;
        }
    }
}
