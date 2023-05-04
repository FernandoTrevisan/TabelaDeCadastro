using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quarto_designer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvAlunos.Rows.Add(txtNome.Text,txtCurso.Text);

            txtNome.Clear();
            txtCurso.Clear();

            MessageBox.Show("Aluno Incluido com sucesso" , "Inclusão", 
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            Total.Text = dgvAlunos.RowCount.ToString();


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvAlunos.RowCount > 0)

                dgvAlunos.Rows.RemoveAt(dgvAlunos.CurrentCell.RowIndex);

            MessageBox.Show("Aluno Excluido com sucesso", "Exclusão",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            Total.Text = dgvAlunos.RowCount.ToString();



        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dgvAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAlunos.RowCount > 0)




                txtAlterar.Text = dgvAlunos.CurrentRow.Cells[0].Value.ToString();
            


        }

        private void button5_Click(object sender, EventArgs e)
        {
            dgvAlunos.RowCount = 0;
            
            Total.Text = dgvAlunos.RowCount.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
