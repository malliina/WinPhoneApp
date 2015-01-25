using Windows.Security.ExchangeActiveSyncProvisioning;

namespace WinPhoneApp.ViewModels {
    public class TestVM : ViewModelBase {
        private string deviceName;
        public string DeviceName { get { return deviceName; } }
        public TestVM() {
            var deviceInfo = new EasClientDeviceInformation();
            deviceName = deviceInfo.FriendlyName;
        }
    }
}
