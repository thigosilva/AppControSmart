using Android.Telephony;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using static Android.Manifest;
using System.Threading.Tasks;

namespace AppControSmart.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();

            CarregarInfoDeviceAsync();
        }

        protected void CarregarInfoDeviceAsync()
        {
     

            //Get Imei
            lbl_Imei.Text = "IMEI = ";

            lbl_device.Text = "";
            lbl_manufacturer.Text = DeviceInfo.Manufacturer;
            lbl_deviceName.Text = DeviceInfo.Name;
            lbl_Version.Text = DeviceInfo.Version.ToString();
            lbl_platform.Text = DeviceInfo.Platform.ToString();
            lbl_idiom.Text = DeviceInfo.Idiom.ToString();
            lbl_deviceType.Text = DeviceInfo.DeviceType.ToString();

        }

    }
}