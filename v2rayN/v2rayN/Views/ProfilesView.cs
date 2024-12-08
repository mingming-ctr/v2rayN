using System;
using System.Net;

using System.Diagnostics;
using System.Threading.Tasks;


namespace v2rayN.Views
{
    public partial class ProfilesView
    {
        public ProfilesView() : this(0)
        {
            // this.startHttp();

            // string absolutePath = @"http://127.0.0.1:8181/api";
            // Process.Start(absolutePath);

        }

     
        // private void UpdateHandler(bool notify, string msg)
        // {
        //     NoticeHandler.Instance.SendMessage(msg);
        //     if (notify)
        //     {
        //         NoticeHandler.Instance.Enqueue(msg);
        //     }
        // }
        // HttpListener listener = new HttpListener();//解决订阅8181多次运行多次创建的问题
        // private void startHttp()
        // {
        //     //System.InvalidOperationException:“线程间操作无效: 从不是创建控件“lvServers”的线程访问它
        //     // System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;//设置该属性 为false
        //     try
        //     {
        //         if (listener.IsListening == true)//如果订阅8181端口已经运行，直接返回
        //             return;
        //         listener.Prefixes.Add("http://+:8181/");
        //         this.UpdateHandler(false, "111：准备启动服务8181");
        //         listener.Start();
        //         this.UpdateHandler(false, "111：成功启动服务8181");
        //         Console.WriteLine("Listening...");
        //         Task.Factory.StartNew((Action)(async () =>
        //         {
        //             while (listener.IsListening)
        //             {
        //                 try
        //                 {
        //                     HttpListenerContext context = listener.GetContext();
        //                     this.UpdateHandler(false, "111：访问8181端口");
        //                     HttpListenerRequest request = context.Request;
        //                     HttpListenerResponse response = context.Response;

        //                     //"/a/b"
        //                     //

        //                     //StreamWriter streamWriter = new StreamWriter(response.OutputStream);
        //                     System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(response.OutputStream, Encoding.UTF8);

        //                     string cmd = V2RayNAPI.UrlMatch(request.RawUrl);
        //                     switch (cmd)
        //                     {
        //                         case "api":

        //                             response.ContentType = "text/html; Charset=UTF-8";
        //                             streamWriter.WriteLine("<ul>");

        //                             streamWriter.WriteLine("<ol><a href='./'>不匹配</a>，默认获得base64编码</ol>");
        //                             streamWriter.WriteLine("<ol><a href='./api'>api</a>，列出所有接口</ol>");
        //                             streamWriter.WriteLine("<ol><a href='./selectFast'>selectFast</a>，测速，选择速度最快的</ol>");
        //                             streamWriter.WriteLine("<ol><a href='./refresh'>refresh</a>，更新订阅地址 + selectFast</ol>");
        //                             streamWriter.WriteLine("<ol><a href='./next'>next</a>，选择下个节点，最后一个后到第一个</ol>");
        //                             streamWriter.WriteLine("<ol><a href='./test?url=https://web.telegram.org/'>test</a>，测试链接是否同，返回1,0</ol>");
        //                             streamWriter.WriteLine("<ol><a href='./testuntil?url=https://web.telegram.org/'>testuntil</a>，测试链接是否同，返回1,0</ol>");

        //                             streamWriter.WriteLine("</ul>");

        //                             break;
        //                         case "test":
        //                             // var result1 = await test(request);

        //                             // if (result1 == null)
        //                             //     streamWriter.WriteLine(0);
        //                             // else
        //                             //     streamWriter.WriteLine(1);


        //                             //streamWriter.WriteLine(result);
        //                             break;
        //                         case "testuntil":
        //                             // string result = null;
        //                             // for (int i = 0; i < lstVmess.Count; i++)
        //                             // {
        //                             //     result = await test(request);
        //                             //     if (result == null)
        //                             //     {
        //                             //         next();
        //                             //     }
        //                             //     else
        //                             //     {
        //                             //         break;
        //                             //     }

        //                             // }
        //                             // if (result == null)
        //                             //     streamWriter.WriteLine(0);
        //                             // else
        //                             //     streamWriter.WriteLine(1);

        //                             break;
        //                         case "selectFast":
        //                             // this.selectFast();
        //                             break;
        //                         case "refresh":
        //                             // this.toolStripMenuItem1_Click((object)null, (EventArgs)null);//开机就运行
        //                             break;
        //                         case "next":
        //                             // next();

        //                             //lvServers.SelectedItems.
        //                             break;
        //                         default:
        //                             this.UpdateHandler(false, "111：8181端口回复数据");
        //                             // this.getBase64data();
        //                             // string base64data = this.base64data;
        //                             // streamWriter.WriteLine(base64data);
        //                             break;
        //                     }

        //                     streamWriter.Close();
        //                     streamWriter.Dispose();
        //                 }
        //                 catch (Exception ex)
        //                 {
        //                     this.UpdateHandler(false, "web访问订阅服务器时发生异常：" + ex.ToString());
        //                 }
        //             }
        //         }));
        //     }
        //     catch (Exception ex)
        //     {
        //         this.UpdateHandler(false, "添加订阅服务器时发生异常：" + ex.ToString());
        //     }
        // }


    }
}