namespace CisESport
{
    public partial class Forminfo : Form
    {
        private Player _newPlayer;
        public Forminfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string lastname = tbLastName.Text;
            string studentid = tbID.Text;
            string mail = tbMail.Text;
            string phone = tbPhone.Text;
            string major = tbmajor.Text;
            string displayname = tbDisplayName.Text;
            int iAge = 0;
            try
            {
                string age = tbAge.Text;
                iAge = Int32.Parse(age);
            }
            catch (FormatException ex)
            {
                //Do something if have some exception
                MessageBox.Show("คุุณใส่ข้อมูลไม่ถูกต้อง");
                return;
            }
            catch (Exception ex)
            {
                //Do somrthing if have some exception
            }

            finally
            {
                Console.WriteLine("Final block");
            }
            _newPlayer = new Player (name,lastname, studentid,
            major, displayname, mail, phone, iAge);
        }
    }
}