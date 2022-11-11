namespace Project_v3._0
{
    public class StaticResources
    {
        public static int ThreadDelay { get; set; } = 60;
        public static System.Drawing.Color DefaultColorBall { get; set; } = System.Drawing.Color.Red;
        public static System.Drawing.Color DefaultColorBall1 { get; set; } = System.Drawing.Color.Tomato;
        public static System.Drawing.Color DefaultColorBall2 { get; set; } = System.Drawing.Color.Cyan;
        public static System.Drawing.Color DefaultTrackColor { get; set; } = System.Drawing.Color.Purple;
        public static System.Drawing.Color DefaultColorVector { get; set; } = System.Drawing.Color.Black;

        public static int ChartPointsMax { get; set; } = 20;


        public static int BallMinMass { get; } = 10;
        public static int BallMaxMass { get; } = 100;
        public static int BallMinRadius { get; } = 10;
        public static int BallMaxRadius { get; } = 25;
        public static Point BallMinPosition { get; set; } = new Point(50, 50);
        public static Point BallMinSpeed { get; set; } = new Point(-100, -50);
        public static Point BallMaxSpeed { get; set; } = new Point(100, 50);

        public static double Dt { get; set; } = DefaultDt;
        public static double DefaultDt { get; } = 0.01;
    }
}
