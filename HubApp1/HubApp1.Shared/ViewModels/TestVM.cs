
using Windows.Security.ExchangeActiveSyncProvisioning;
namespace HubApp1.ViewModels {
    public class TestVM : ViewModelBase {
        private string text = "Hello, world!";
        public string Text {
            get { return text; }
            set { SetProperty(ref text, value); }
        }
        private string deviceName;
        public string DeviceName {
            get { return deviceName; }
        }
        private string os;
        public string OS {
            get { return os; }
        }
        public TestVM() {
            var deviceInformation = new EasClientDeviceInformation();
            deviceName = deviceInformation.FriendlyName;
            os = deviceInformation.OperatingSystem;
        }
    }
}
