using TSP2025.Data;

namespace TSP2025.Utils
{
    public class FormMessages
    {
        public static void ShowError(string message)
        {
            MessageBox.Show(message, "TSP2025", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void ShowInformation(string message)
        {
            MessageBox.Show(message, "TSP2025", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ShowExclamation(string message)
        {
            MessageBox.Show(message, "TSP2025", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public static DialogResult AreYouSure()
        {
            return MessageBox.Show("Da li ste sigurni?", "TSP2025", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public static DataSourceMode AskForDataSource()
        {
            switch (MessageBox.Show($"Izaberite izvor podataka:{Environment.NewLine}{Environment.NewLine}Yes - Nasumične vrednosti{Environment.NewLine}No - TSP2025 baza podataka", "Izvor podataka?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1))
            {

                case DialogResult.Yes: return DataSourceMode.FromRAM;
                case DialogResult.No: return DataSourceMode.FromDatabase;
                default:
                    return DataSourceMode.None;
            }
        }
    }
}
