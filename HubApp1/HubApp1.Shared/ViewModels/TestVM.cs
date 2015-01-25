
namespace HubApp1.ViewModels {
    public class TestVM : ViewModelBase {
        private string text = "Hello, world!";
        public string Text {
            get { return text; }
            set { SetProperty(ref text, value); }
        }
    }
}
