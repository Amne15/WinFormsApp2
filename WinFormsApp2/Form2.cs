namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        public string usuario = "amnellah";
        public string password = "1234";
        public string msgValido = "Bienvenido";
        public string msgError = "Datos no valido";

        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tboxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string users = tboxLogin.Text;
            string pwd = tboxPwd.Text;
            //tbMensaje.Text = users == usuario || pwd == password ? msgValido : msgError;

            if (users == usuario && pwd == password)
            {
                tbMensaje.Text = msgValido;
                //MessageBox.Show(msg);

            }
            else
            {
                tbMensaje.Text = msgError;
                //MessageBox.Show(msg_error);
            }
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            tboxLogin.Clear();
            tboxPwd.Clear();
            tbMensaje.Clear();
        }

        private void tboxPwd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}