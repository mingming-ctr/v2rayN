using MaterialDesignThemes.Wpf;
using ReactiveUI;
using Splat;
using System.ComponentModel;
using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Threading;
using v2rayN.Handler;

namespace v2rayN.Views
{
    public partial class MainWindow
    {
        public Webapi webapi = new Webapi(this);

        public void ChangeTitle(string title = "v2rayN1111111111")
        {
            this.Title = "v2rayN1111111111111111";
            UpdateHandler(false, "ChangeTitle22222222222222");
        }


        private void UpdateHandler(bool notify, string msg)
        {
            NoticeHandler.Instance.SendMessage(msg);
            if (notify)
            {
                NoticeHandler.Instance.Enqueue(msg);
            }
        }


        public class Webapi
        {
            public Webapi(MainWindow mainWindow)
            {
                // mainWindow.UpdateHandler(false, "333333333333");
                mainWindow. Title = "343241241";
            }
        }
    }


}