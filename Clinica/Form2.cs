using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Clinica;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clinica
{
    public partial class Form2 : Form
{
    private readonly string connectionString = @"Server=localhost;Database=ClinicRegistryDB;Trusted_Connection=True;TrustServerCertificate=True;";

    public Form2()
    {
        InitializeComponent();

       
        textBox2.PasswordChar = '*';

       
        comboBox1.Items.Add("Администратор");
        comboBox1.Items.Add("Врач");
        comboBox1.Items.Add("Регистратор");
        comboBox1.SelectedIndex = 0;
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
        string username = textBox1.Text.Trim();
        string password = textBox2.Text;
        string selectedRole = comboBox1.SelectedItem.ToString();

        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
        {
            label5.ForeColor = System.Drawing.Color.Red;
            label5.Text = "Введите логин и пароль.";
            return;
        }

        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password AND role = @role";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@role", selectedRole);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        label5.ForeColor = System.Drawing.Color.Green;
                        label5.Text = "Успешный вход!";


                            Form1 form = new Form1(selectedRole);
                            form.Show();
                            this.Hide();
                        }
                    else
                    {
                        label5.ForeColor = System.Drawing.Color.Red;
                        label5.Text = "Неверный логин, пароль или роль.";
                    }
                }
            }
        }
        catch (Exception ex)
        {
            label5.ForeColor = System.Drawing.Color.Red;
            label5.Text = "Ошибка подключения: " + ex.Message;
        }
    }
}
}
