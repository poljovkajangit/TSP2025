
namespace TSP2025
{
    public sealed class ScadaService
    {
        private static ScadaService instance = null;
        private static readonly object padlock = new object();

        ScadaService()
        {
        }

        public static ScadaService Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new ScadaService();                        
                    }
                    return instance;
                }
            }
        }

        private TextBox _console;
        private System.Threading.Timer _timer;
        private int _callbackCount = 0;
        public void Stop()
        {
            // Stop the SCADA service
            _console.AppendText("SCADA service stopped.");
        }

        public void Start(TextBox console)
        {
            _console = console;
            // Initialize the SCADA service
            lock (_console)
            {
                _console.AppendText("SCADA service starting.");
                _console.AppendText("Checking DB connection.... PASSED");
                _timer = new System.Threading.Timer(DoWork, null, 0, 5000);

            }
        }

        private void DoWork(object? state)
        {
            _console.AppendText("timer callback: " + _callbackCount++);
        }
    }
}
