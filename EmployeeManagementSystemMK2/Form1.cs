

namespace EmployeeManagementSystemMK2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee EmployeeInfo = new Employee();
            EmployeeInfo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeInfo EmployeeInfo = new EmployeeInfo();
            EmployeeInfo.Show();
        }
        

        private void button3_Click(object sender, EventArgs e) // Exit Button
        {
            
            this.Close();
            Environment.Exit(0);
        }
    }
}