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

    }
}
