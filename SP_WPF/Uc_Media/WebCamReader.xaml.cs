using FFmpeg.AutoGen;
using SP_WPF.FFmpeg;
using SP_WPF.FFmpeg.Decoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace SP_WPF.Uc_Media
{
    /// <summary>
    /// Interaction logic for WebCamReader.xaml
    /// </summary>
    public partial class WebCamReader : UserControl
    {
        Thread thread;
        ThreadStart ts;
        Dispatcher dispatcher = Application.Current.Dispatcher;

        private bool activeThread;      //thread 활성화 유무
        public WebCamReader()
        {
            InitializeComponent();

            //비디오 프레임 디코딩 thread 생성
            ts = new ThreadStart(DecodeAllFramesToImages);
            thread = new Thread(ts);

            //FFmpeg dll 파일 참조 경로 설정
            FFmpegBinariesHelper.RegisterFFmpegBinaries();

            activeThread = true;
        }

        private void Btn_capture_Click(object sender, RoutedEventArgs e)
        {
            if (thread.ThreadState == ThreadState.Unstarted)
            {
                thread.Start();
            }
            else
            {
                activeThread = false;
                thread.Join();
            }
            //im_Capture.Source
        }

        private unsafe void DecodeAllFramesToImages()
        {
            //video="웹캠 디바이스 이름"
            string device = "video=AVerMedia GC550 Video Capture";
            using (var vsd = new VideoStreamDecoder(device))
            {
                //Console.WriteLine($"codec name: {vsd.CodecName}");

                var info = vsd.GetContextInfo();
                info.ToList().ForEach(x => Console.WriteLine($"{x.Key} = {x.Value}"));

                var sourceSize = vsd.FrameSize;
                var sourcePixelFormat = vsd.PixelFormat;
                var destinationSize = sourceSize;
                var destinationPixelFormat = AVPixelFormat.AV_PIX_FMT_BGR24;
                using (var vfc = new VideoFrameConverter(sourceSize, sourcePixelFormat, destinationSize, destinationPixelFormat))
                {
                    var frameNumber = 0;
                    while (vsd.TryDecodeNextFrame(out var frame) && activeThread)
                    {
                        var convertedFrame = vfc.Convert(frame);

                        Bitmap bitmap;

                        bitmap = new Bitmap(convertedFrame.width, convertedFrame.height, convertedFrame.linesize[0], System.Drawing.Imaging.PixelFormat.Format24bppRgb, (IntPtr)convertedFrame.data[0]);
                        BitmapToImageSource(bitmap);

                        frameNumber++;
                    }
                }
            }
        }

        void BitmapToImageSource(Bitmap bitmap)
        {
            //UI thread에 접근하기 위해 dispatcher 사용
            dispatcher.BeginInvoke((Action)(() =>
            {
                using (MemoryStream memory = new MemoryStream())
                {
                    //if (thread.IsAlive)
                    //{
                    bitmap.Save(memory, System.Drawing.Imaging.ImageFormat.Bmp);
                    memory.Position = 0;
                    BitmapImage bitmapimage = new BitmapImage();
                    bitmapimage.BeginInit();
                    bitmapimage.CacheOption = BitmapCacheOption.OnLoad;
                    //bitmapimage.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
                    bitmapimage.StreamSource = memory;
                    bitmapimage.EndInit();

                    im_Capture.Source = bitmapimage;     //image 컨트롤에 웹캠 이미지 표시
                    //}
                }
            }));

        }
    }
}
