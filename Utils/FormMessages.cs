namespace TSP2025.Utils
{
    public class FormMessages
    {
        public static void ShowError(string message)
        {
            MessageBox.Show(message, "TSP2025", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowConfirm(string message)
        {
            MessageBox.Show(message, "TSP2025", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
