namespace ATM_Machine
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPin.Clear();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //Challenge sourced from https://edabit.com/challenge/gBYEFXeD9G2JMZ9dD

            //Check if PIN is 4-6 digits
            int txtLength = txtPin.Text.Length;
            if (txtLength > 6 || txtLength < 4)
            {
                MessageBox.Show("PIN must be 4-6 numbers in length.", "PIN Not Accepted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPin.Clear();
                return; //Early return if PIN is not 4-6 digits
            }

            //Check if PIN is numeric
            if (!int.TryParse(txtPin.Text, out int pin))
            {
                MessageBox.Show("PIN must be numeric and contain no spaces.", "PIN Not Accepted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPin.Clear();
                return; //Early return if PIN is not numeric
            }

            //Create alert box that your PIN was accepted
            MessageBox.Show($"PIN {pin} is valid.", "PIN Accepted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}