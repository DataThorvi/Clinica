using System;
using System.Data;
using System.IO;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using Xceed.Words.NET;

namespace Clinica
{
    public partial class Form1 : Form
    {
        private readonly string connectionString = @"Server=localhost;Database=ClinicRegistryDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public Form1()
        {
            InitializeComponent();

           
            textBox1.TextChanged += (s, e) => LoadPatients(textBox1.Text);
            textBox2.TextChanged += (s, e) => LoadDoctors(textBox2.Text);
            textBox3.TextChanged += (s, e) => LoadServices(textBox3.Text);

            LoadPatients();
            LoadDoctors();
            LoadServices();
            LoadAppointments();
            LoadMedicalRecords();
            LoadDispensaryObservations();

            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;

           
            LoadPatients1();
        }

        private void LoadPatients1(string filter = "")
        {
            string query = @"
                SELECT PatientID, LastName, FirstName, MiddleName, BirthDate 
                FROM Patients";

            if (!string.IsNullOrEmpty(filter))
                query += " WHERE LastName LIKE @filter OR FirstName LIKE @filter OR MiddleName LIKE @filter";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (!string.IsNullOrEmpty(filter))
                    cmd.Parameters.AddWithValue("@filter", $"%{filter}%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView10.DataSource = dt;

                
                dataGridView10.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

              
                dataGridView10.Enabled = true;
                dataGridView10.ReadOnly = false;

               
                if (dataGridView10.Parent != null)
                    dataGridView10.Parent.Enabled = true;
            }
        }

        private void LoadPatients(string filter = "")
        {
            string query = "SELECT PatientID, LastName, FirstName, MiddleName, BirthDate FROM Patients";
            if (!string.IsNullOrEmpty(filter))
                query += " WHERE LastName LIKE @filter OR FirstName LIKE @filter OR MiddleName LIKE @filter";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (!string.IsNullOrEmpty(filter))
                    cmd.Parameters.AddWithValue("@filter", $"%{filter}%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }

            dataGridView2.DataSource = null;
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                dataGridView2.DataSource = null;
                return;
            }

            if (int.TryParse(dataGridView1.CurrentRow.Cells["PatientID"].Value?.ToString(), out int patientId))
            {
                LoadPatientVisits(patientId);
            }
            else
            {
                dataGridView2.DataSource = null;
            }
        }

        private void LoadPatientVisits(int patientId)
        {
            string query = "SELECT AppointmentID, PatientID, DoctorID, ServiceID, AppointmentDate, AppointmentTime, Diagnosis FROM Appointments WHERE PatientID = @patientId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@patientId", patientId);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView2.DataSource = dt;
            }
        }

        private void LoadDoctors(string filter = "")
        {
            string query = "SELECT DoctorID, LastName, FirstName, MiddleName, Specialization FROM Doctors";
            if (!string.IsNullOrEmpty(filter))
                query += " WHERE LastName LIKE @filter OR FirstName LIKE @filter OR MiddleName LIKE @filter";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (!string.IsNullOrEmpty(filter))
                    cmd.Parameters.AddWithValue("@filter", $"%{filter}%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView4.DataSource = dt;
            }

            dataGridView3.DataSource = null;
        }

        private void LoadServices(string filter = "")
        {
            string query = "SELECT ServiceID, ServiceName, Cost FROM Services";
            if (!string.IsNullOrEmpty(filter))
                query += " WHERE ServiceName LIKE @filter";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (!string.IsNullOrEmpty(filter))
                    cmd.Parameters.AddWithValue("@filter", $"%{filter}%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView6.DataSource = dt;
            }

            dataGridView5.DataSource = null;
        }

        private void LoadAppointments()
        {
            string query = "SELECT AppointmentID, PatientID, DoctorID, ServiceID, AppointmentDate, AppointmentTime, Diagnosis FROM Appointments";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView7.DataSource = dt;
            }
        }

        private void LoadMedicalRecords()
        {
            string query = "SELECT RecordID, PatientID, DoctorID, Diagnosis, Treatment, RecordDate FROM MedicalRecords";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView8.DataSource = dt;
            }
        }

        private void LoadDispensaryObservations()
        {
            string query = "SELECT ObservationID, PatientID, DoctorID, StartDate, EndDate, Diagnosis FROM DispensaryObservations";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView9.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM vw_PatientsLastAppointment";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                adapter.Fill(dt);

                dataGridView2.DataSource = dt;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM View_PatientAppointments";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                adapter.Fill(dt);

                dataGridView2.DataSource = dt;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM vw_ServiceDeals";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView5.DataSource = dt;
            }
        }

        private void GenerateWordReportFromTemplate(int patientId)
        {
            string templatePath = @"C:\Users\babes\Downloads\Template.docx";
            string outputPath = Path.Combine(Path.GetTempPath(), $"MedicalCard_{patientId}.docx");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string patientQuery = @"
                    SELECT LastName, FirstName, MiddleName, BirthDate, Address, Phone, Gender, SNILS, OMS
                    FROM Patients 
                    WHERE PatientID = @PatientID";

                string lastName = "", firstName = "", middleName = "", birthDate = "", address = "", phone = "", gender = "", snils = "", oms = "";

                using (SqlCommand patientCmd = new SqlCommand(patientQuery, connection))
                {
                    patientCmd.Parameters.AddWithValue("@PatientID", patientId);
                    using (SqlDataReader reader = patientCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lastName = reader["LastName"].ToString();
                            firstName = reader["FirstName"].ToString();
                            middleName = reader["MiddleName"].ToString();
                            birthDate = Convert.ToDateTime(reader["BirthDate"]).ToShortDateString();
                            address = reader["Address"].ToString();
                            phone = reader["Phone"].ToString();
                            gender = reader["Gender"].ToString();
                            snils = reader["SNILS"].ToString();
                            oms = reader["OMS"].ToString();
                        }
                    }
                }

                var doc = DocX.Load(templatePath);

                doc.ReplaceText("{{Фамилия}}", lastName);
                doc.ReplaceText("{{Имя}}", firstName);
                doc.ReplaceText("{{Отчество}}", middleName);
                doc.ReplaceText("{{ДатаРождения}}", birthDate);
                doc.ReplaceText("{{Адрес}}", address);
                doc.ReplaceText("{{Телефон}}", phone);
                doc.ReplaceText("{{Пол}}", gender);
                doc.ReplaceText("{{СНИЛС}}", snils);
                doc.ReplaceText("{{ОМС}}", oms);

                var table = doc.Tables[0];
                if (table.RowCount > 1)
                    table.RemoveRow(1);

                string diagQuery = @"
                    SELECT 
                        StartDate, 
                        EndDate, 
                        Diagnosis, 
                        ICDCode,
                        (SELECT FirstName + ' ' + LastName FROM Doctors WHERE Doctors.DoctorID = DispensaryObservations.DoctorID) AS DoctorName
                    FROM DispensaryObservations 
                    WHERE PatientID = @PatientID";

                using (SqlCommand diagCmd = new SqlCommand(diagQuery, connection))
                {
                    diagCmd.Parameters.AddWithValue("@PatientID", patientId);
                    using (SqlDataReader diagReader = diagCmd.ExecuteReader())
                    {
                        while (diagReader.Read())
                        {
                            string startDate = diagReader["StartDate"] != DBNull.Value
                                ? Convert.ToDateTime(diagReader["StartDate"]).ToShortDateString()
                                : "";
                            string endDate = diagReader["EndDate"] != DBNull.Value
                                ? Convert.ToDateTime(diagReader["EndDate"]).ToShortDateString()
                                : "";
                            string diagnosis = diagReader["Diagnosis"].ToString();
                            string icd10 = diagReader["ICDCode"].ToString();
                            string doctor = diagReader["DoctorName"].ToString();

                            var row = table.InsertRow();
                            row.Cells[0].Paragraphs[0].Append(startDate);
                            row.Cells[1].Paragraphs[0].Append(endDate);
                            row.Cells[2].Paragraphs[0].Append(diagnosis);
                            row.Cells[3].Paragraphs[0].Append(icd10);
                            row.Cells[4].Paragraphs[0].Append(doctor);
                        }
                    }
                }

                doc.SaveAs(outputPath);

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = outputPath,
                    UseShellExecute = true
                });
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView10.CurrentRow == null)
            {
                MessageBox.Show("Пожалуйста, выберите пациента из списка.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (int.TryParse(dataGridView10.CurrentRow.Cells["PatientID"].Value?.ToString(), out int patientId))
            {
                GenerateWordReportFromTemplate(patientId);
            }
            else
            {
                MessageBox.Show("Не удалось получить ID пациента.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
