using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Telephony;
using Xamarin.Forms;

namespace AppControSmart.Droid
{
    public class IMEI
    {
        public string GetId()
        {
            var telephonyManager = (TelephonyManager)Forms.Context.GetSystemService(Context.TelephonyService);
            string id = telephonyManager.DeviceId;
                
            return id;
        }
    }
}