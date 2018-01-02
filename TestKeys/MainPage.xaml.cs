using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Input.Preview.Injection;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TestKeys
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            
        }

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var uri = new Uri(@"ms-cortana://Reactive/?StartMode=Reactive&ListeningMode=True");
                //var uri = new Uri(@"bingmaps:?where=Paris");
                await Launcher.LaunchUriAsync(uri);
                //Windows.UI.Input.Preview.Injection.InputInjector _injector = InputInjector.TryCreate();

                //List<InjectedInputKeyboardInfo> inputs = new List<InjectedInputKeyboardInfo>();
                //InjectedInputKeyboardInfo _keywindown = new InjectedInputKeyboardInfo();
                //_keywindown.VirtualKey = 0x5B; //F1
                //_keywindown.KeyOptions = InjectedInputKeyOptions.None;
                //_keywindown.ScanCode = 0x00;
                //inputs.Add(_keywindown);

                //InjectedInputKeyboardInfo _keycdown = new InjectedInputKeyboardInfo();
                //_keycdown.VirtualKey = 0x43; //F1
                //_keycdown.KeyOptions = InjectedInputKeyOptions.None;
                //_keycdown.ScanCode = 0x00;
                //inputs.Add(_keycdown);

                //InjectedInputKeyboardInfo _keywinup = new InjectedInputKeyboardInfo();
                //_keywinup.VirtualKey = 0x5B; //F1
                //_keywinup.KeyOptions = InjectedInputKeyOptions.KeyUp;
                //_keywinup.ScanCode = 0x00;
                //inputs.Add(_keywinup);

                //InjectedInputKeyboardInfo _keycup = new InjectedInputKeyboardInfo();
                //_keycup.VirtualKey = 0x43; //F1
                //_keycup.KeyOptions = InjectedInputKeyOptions.KeyUp;
                //_keycup.ScanCode = 0x00;
                //inputs.Add(_keycup);

                //_injector.InjectKeyboardInput(inputs);

            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        
    }
}
