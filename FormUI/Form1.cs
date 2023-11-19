using Business.Concretes;
using DataAccess.Concretes.EntityFramework;

namespace FormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var context = new TobetoContext())
            {
                // Veritabanýndan veri çekme örneði
                var coursesList = context.Courses.ToList();

                // DataGridView kontrolünü doldurma
                dataGridView1.DataSource = coursesList;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}