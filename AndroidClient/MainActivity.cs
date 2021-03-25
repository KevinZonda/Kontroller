using System;
using System.Net;

using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;

using OtpNet;

namespace AndroidClient
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private EditText edtTarget,
            edtKey;

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
            edtKey = FindViewById<EditText>(Resource.Id.edtKey);
            btnTest = FindViewById<Button>(Resource.Id.btnTest);

            btnVolUp = FindViewById<Button>(Resource.Id.btnVolUp);
            btnVolDown = FindViewById<Button>(Resource.Id.btnVolDown);
            btnVolMute = FindViewById<Button>(Resource.Id.btnVolMute);

            btnMediaPrev = FindViewById<Button>(Resource.Id.btnMediaPrev);
            btnMediaPlay = FindViewById<Button>(Resource.Id.btnMediaPlay);
            btnMediaNext = FindViewById<Button>(Resource.Id.btnMediaNext);

            btnTest.Click += (s, e) => Action("test");
            btnVolUp.Click += (s, e) => Action("vol-up");
            btnVolDown.Click += (s, e) => Action("vol-down");
            btnVolMute.Click += (s, e) => Action("vol-mute");
            btnMediaPrev.Click += (s, e) => Action("media-prev");
            btnMediaPlay.Click += (s, e) => Action("media-play");
            btnMediaNext.Click += (s, e) => Action("media-next");

            FlashUI(IOHelper.ReadAllText("serv"));

            edtTarget.AfterTextChanged += EdtTarget_AfterTextChanged;
        }

        private void EdtTarget_AfterTextChanged(object sender, Android.Text.AfterTextChangedEventArgs e)
        {
            FlashUI(edtTarget.Text);
        }

        private void Action(string action)
        {
            ShowToast(RequestAPI(edtTarget.Text, edtKey.Text, action) ? "Action success!" : "Action failed!");
        }

        private void ShowToast(string text, ToastLength toastLength = ToastLength.Short)
            => Toast.MakeText(Application.Context, text, toastLength).Show();

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

        private void FlashUI(string m)
        {
            string t = TidyUrl(m);
            edtTarget.Text = t;
            IOHelper.WriteAllText("serv", t);
        }

        private static bool RequestAPI(string url, string otpKey, string action)
        {
            var token = string.Empty;
            if (!string.IsNullOrEmpty(otpKey))
                token = (new Totp(Base32Encoding.ToBytes(otpKey))).ComputeTotp();
            var result = GetHttpCode(url + $"/action?token={token}&want={action}");
            return result == 200;
        }

        private static int GetHttpCode(string url, int timeout = 10000)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Timeout = timeout;
                request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

                using var response = (HttpWebResponse)request.GetResponse();
                return (int)response.StatusCode;
            }
            catch
            {
                return 400;
            }
        }
    }
}