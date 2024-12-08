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
        // public Webapi webapi = new Webapi(this);

        /// <summary>
        /// 这个方法替换原有方法，用于初始化窗体
        /// 合并代码的时候，需要注意，不要把原有代码删除，而是注释掉，以免造成冲突
        /// </summary>

        public  MainWindow():this(0)
        {
            this.Title = "333333333";
            UpdateHandler(false, "99999999999");
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
            private MainWindow mainWindow;
            public Webapi(MainWindow mainWindow)
            {
                this.mainWindow = mainWindow;
                // mainWindow.UpdateHandler(false, "333333333333");
                // mainWindow.Title = "343241241";
            }
        }

    }


}