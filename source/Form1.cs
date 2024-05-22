using Microsoft.Toolkit.Uwp.Notifications;
using Windows.UI.Notifications;
using WinFormsApp3.Properties;
namespace CombinedApp
{
    public partial class Form1 : Form
    {
        private const int ClockWidth = 300;
        private const int ClockHeight = 300;
        private DateTime now; // Declare now at the class level

        public Form1()
        {
            InitializeComponent();
            InitializeClock();
      

        }

        private void InitializeClock()
        {
            var clockTimer = new System.Windows.Forms.Timer();
            var clockBitmap = new Bitmap(ClockWidth + 1, ClockHeight + 1);

            clockTimer.Interval = 1000; // in milliseconds
            clockTimer.Tick += (sender, e) =>
            {
                now = DateTime.Now; // Assign the current time to now
                using (var clockGraphics = Graphics.FromImage(clockBitmap))
                {
                    clockGraphics.Clear(Color.Transparent);
                    DrawClockFace(clockGraphics);
                    DrawClockHands(clockGraphics, now.Second, now.Minute, now.Hour);
                }

                pictureBox1.Image = clockBitmap;
                this.Text = $"MedRemind - {now:hh:mm:ss}";
            };
            clockTimer.Start();
        }

        private void DrawClockFace(Graphics graphics)
        {
            var centerX = ClockWidth / 2;
            var centerY = ClockHeight / 2;

            for (int i = 0; i < 12; i++)
            {
                var angle = (i - 3) * Math.PI / 6;
                var numX = (int)(centerX + Math.Cos(angle) * (ClockWidth / 2 - 30)) - 10;
                var numY = (int)(centerY + Math.Sin(angle) * (ClockHeight / 2 - 30)) - 10;
                graphics.DrawString((i == 0 ? 12 : i).ToString(), new Font("Arial", 12), Brushes.Black, new PointF(numX, numY));
            }
        }

        private void DrawClockHands(Graphics graphics, int seconds, int minutes, int hours)
        {
            var centerX = ClockWidth / 2;
            var centerY = ClockHeight / 2;

            DrawHand(graphics, Color.Red, seconds, 6, centerX, centerY, 100);
            DrawHand(graphics, Color.Black, minutes, 6, centerX, centerY, 80);
            DrawHand(graphics, Color.Gray, hours * 5 + minutes / 12, 30, centerX, centerY, 60);
        }

        private void DrawHand(Graphics graphics, Color color, int value, int degreeFactor, int centerX, int centerY, int length)
        {
            var angle = (value - 15) * Math.PI / 30;
            var x = centerX + (int)(length * Math.Cos(angle));
            var y = centerY + (int)(length * Math.Sin(angle));
            graphics.DrawLine(new Pen(color, 2f), centerX, centerY, x, y);
        }

        private void SendReminder_Click(object sender, EventArgs e)
        {
            var reminderDateTime = PickDate.Value;

            var timeUntilReminder = reminderDateTime - now; // Use now instead of DateTime.Now

            if (timeUntilReminder.TotalMilliseconds <= 0)
            {
                MessageBox.Show("Date must be in the future", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var toastContentBuilder = new ToastContentBuilder()
                .AddText("Medication Reminder")
                .AddText("Time to take your medication! Dont forget to get it down with water");

            var toastContent = toastContentBuilder.GetToastContent();

            var notification = new ScheduledToastNotification(toastContent.GetXml(), reminderDateTime);
            ToastNotificationManagerCompat.CreateToastNotifier().AddToSchedule(notification);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
