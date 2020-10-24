using System;
using System.IO;
using System.Net;
using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace AndroidClient
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private EditText edtTarget;

        private Button btnTest,
            btnVolUp,
            btnVolDown,
            btnVolMute,
            btnMediaPrev,
            btnMediaPlay,
            btnMediaNext;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            edtTarget = FindViewById<EditText>(Resource.Id.edtTarget);

            btnTest = FindViewById<Button>(Resource.Id.btnTest);

            btnVolUp = FindViewById<Button>(Resource.Id.btnVolUp);
            btnVolDown = FindViewById<Button>(Resource.Id.btnVolDown);
            btnVolMute = FindViewById<Button>(Resource.Id.btnVolMute);

            btnMediaPrev = FindViewById<Button>(Resource.Id.btnMediaPrev);
            btnMediaPlay = FindViewById<Button>(Resource.Id.btnMediaPlay);
            btnMediaNext = FindViewById<Button>(Resource.Id.btnMediaNext);
        }

        private static string TidyUrl(string url)
        {
            url = url.ToLower().Trim();

            string prefix = "http";
            string suffix = string.Empty;
            var v = url.Split("://");
            switch (v.Length)
            {
                case 2:
                    suffix = v[1];
                    if (v[0].Is("http", "https"))
                    {
                        prefix = v[0];
                    }
                    else
                    {
                        throw new ArgumentException("Scheme can be only http and https.\n" +
                                                    "Yours is" + v[0]);
                    }
                    break;
                case 1:
                    if (v[0].Is("http", "https") && url.EndsWith("://"))
                    {
                        prefix = v[0];
                    }
                    else
                    {
                        suffix = v[0];
                    }
                    break;
                default:
                    return string.Empty;
            }

            suffix = suffix.Split("/")[0];
            return prefix + "://" + suffix;
        }

        private static int GetHttpCode(string url, int timeout = 10000)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest) WebRequest.Create(url);
                request.Timeout = timeout;
                request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

                using var response = (HttpWebResponse) request.GetResponse();
                return (int) response.StatusCode;
            }
            catch
            {
                return 400;
            }
        }
    }
}