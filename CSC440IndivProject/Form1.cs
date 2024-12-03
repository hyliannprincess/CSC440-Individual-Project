using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using OfficeOpenXml;
using static CSC440IndivProject.Form1;


namespace CSC440IndivProject
{
    public partial class Form1 : Form
    {
        
        private string coursePrefix;
        private int courseNum;
        private int year;
        private string semester;
        private int hours;
        private int CRN;
        private int studentID;
        private string name;
        private double overallGPA;
        public enum Grade
        {
            A,
            B,
            C,
            D,
            F
        }
        private Grade grade;
        private List<int> gradeID;

        public Form1()
        {
            InitializeComponent();
            panel1.Hide();
            panel2.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
            panel7.Hide();
        }




        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_DoubleCLick(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void importGrades_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Set filter for Excel files
                openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
                openFileDialog.Title = "Select an Excel File for Students";

                // Show the dialog and get the result
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    
                    try
                    {
                        ImportFromExcel(filePath);
                        MessageBox.Show("Students imported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error importing students: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void addGrade_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
            panel7.Hide();
            panel1.Show();
            

        }
        private void submitNewGrade_Click(object sender, EventArgs e)
        {
            addGrade();
        }


        private void editGrade_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            panel5.Hide();
            panel6.Hide();
            panel7.Hide();
            panel4.Show();
        }

        private void deleteGrade_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            panel4.Hide();
            panel5.Hide();
            panel7.Hide();
            panel6.Show();

           
        }

        private void deleteGradeSubmit_Click(object sender, EventArgs e)
        {
            int courseID = gradeID[deleteBox.SelectedIndex];
            int studentID = int.Parse(deleteIdTB.Text);
            DeleteGrade(studentID, courseID);
            List<string> grades;
            List<int> id;
            displayGrades(studentID, out grades, out id);
            gradeID = id;
            deleteBox.DataSource = grades;

        }

        private void printTranscript_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
            panel7.Show();

        }


        public static void ImportFromExcel(string filePath)
        {
            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?";
            
            try
            {
                using (var conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    
                    using (var package = new ExcelPackage(new FileInfo(filePath)))
                    {
                        var worksheet = package.Workbook.Worksheets["Sheet1"];
                        if (worksheet != null)
                        {
                            for (int row = 2; row <= worksheet.Dimension.End.Row; row++) // Start from row 2 to skip headers
                            {
                                try
                                {
                                    int studentID = int.Parse(worksheet.Cells[row, 1]?.Value?.ToString());
                                    int CRN = int.Parse(worksheet.Cells[row, 2]?.Value?.ToString());
                                    Grade grade = (Grade)Enum.Parse(typeof(Grade), worksheet.Cells[row, 3]?.Value?.ToString(), true);
                                    string coursePrefix = worksheet.Cells[row, 4]?.Value?.ToString();
                                    int courseNum = int.Parse(worksheet.Cells[row, 5]?.Value?.ToString());

                                    string sql = "INSERT INTO adams_grade (StudentID, Grade, CRN, CoursePrefix, CourseNum) " +
                                                 "VALUES (@StudentID, @Grade, @CRN, @CoursePrefix, @CourseNum)";

                                    using (var cmd = new MySqlCommand(sql, conn))
                                    {
                                        cmd.Parameters.AddWithValue("@StudentID", studentID);
                                        cmd.Parameters.AddWithValue("@grade", grade.ToString()); // Convert enum to string due to us using the 5 letters
                                        cmd.Parameters.AddWithValue("@CRN", CRN);
                                        cmd.Parameters.AddWithValue("@CoursePrefix", coursePrefix);
                                        cmd.Parameters.AddWithValue("@CourseNum", courseNum);
                                        cmd.ExecuteNonQuery();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"Error processing row {row}: {ex.Message}");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Worksheet 'Grades' not found in the Excel file.");
                        }
                    }
                }
                Console.WriteLine("Grades data imported successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error importing grades: {ex.Message}");
            }
        }

        public void SaveGradeToDatabase(int studentID, Grade grade, int CRN)
        {
            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?";
            using (var conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string sql = "INSERT INTO adams_grade (StudentID, Grade, CRN) " + "VALUES (@StudentID, @Grade, @CRN)";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", studentID);
                        cmd.Parameters.AddWithValue("@Grade", grade.ToString()); // Convert enum to string due to us using the 5 letters
                        cmd.Parameters.AddWithValue("@CRN", CRN);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        public void SaveStudentToDatabase()
        {
            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?";
            using (var conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string sql = "INSERT INTO adams_studentinfo (StudentID, Name, OverallGPA) VALUES (@StudentID, @Name, @OverallGPA)";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", studentID);
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@OverallGPA", overallGPA);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        public void SaveCourseToDatabase()
        {
            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?";
            using (var conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string sql = "INSERT INTO adams_courseinfo (CoursePrefix, CourseNum, Year, Semester, Hours, CRN) VALUES (@CoursePrefix, @CourseNum, @Year, @Semester, @Hours, @CRN)";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@CoursePrefix", coursePrefix);
                        cmd.Parameters.AddWithValue("@CourseNum", courseNum);
                        cmd.Parameters.AddWithValue("@Year", year);
                        cmd.Parameters.AddWithValue("@Semester", semester);
                        cmd.Parameters.AddWithValue("@Hours", hours);
                        cmd.Parameters.AddWithValue("@CRN", CRN);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        public void DeleteGrade(int StuID, int CRN)
        {

            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?";

            try
            {
                using (var conn = new MySql.Data.MySqlClient.MySqlConnection(connStr))
                {
                    conn.Open();

                    // SQL query to delete the grade
                    string deleteQuery = "DELETE FROM adams_grade WHERE StudentID = @StudentID AND CRN = @CRN";

                    using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(deleteQuery, conn))
                    {
                        // Replace placeholders with actual values
                        cmd.Parameters.AddWithValue("@StudentID", StuID);
                        cmd.Parameters.AddWithValue("@CRN", CRN);

                        int rowsAffected = cmd.ExecuteNonQuery(); // Executes the query

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Grade deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No matching grade found to delete.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void addGrade()
        {
            try
            {
                // Split the StuID.Text to extract the StudentID
                if (!int.TryParse(StuID.Text, out int studentID))
                {
                    // Successfully extracted StudentID
                    MessageBox.Show("Invalid Student ID format. Please select a valid entry.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                // Validate and check CoursePrefix
                string coursePrefix = coursePre.Text.Trim();
                if (string.IsNullOrWhiteSpace(coursePrefix))
                {
                    MessageBox.Show("Course Prefix cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate and parse CourseNum
                if (!int.TryParse(courseAddNum.Text, out int courseNum))
                {
                    MessageBox.Show("Invalid Course Number. Please enter a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate and parse Grade
                string gradeInput = gradeAdd.Text.Trim();
                if (!Enum.TryParse(gradeInput, true, out Grade grade))
                {
                    MessageBox.Show("Invalid grade. Please use A, B, C, D, or F.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(crnAdd.Text, out int CRN))
                {
                    MessageBox.Show("Invalid CRN.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Save the data to the database
                try
                {
                    SaveGradeToDatabase(studentID, grade, CRN);
                    MessageBox.Show("Grade successfully added to the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    StuID.Clear();
                    coursePre.Clear();
                    courseAddNum.Clear();
                    crnAdd.Clear();
                    gradeAdd.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while saving data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void printTranscript(int studentID, out string studentInfo, out string gradeInfo)
        {
            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?";
            studentInfo = "";
            gradeInfo = "";
            try
            {
                using (var conn = new MySql.Data.MySqlClient.MySqlConnection(connStr))
                {
                    conn.Open();

                    // SQL query to delete the grade
                    string query = "SELECT * FROM adams_student WHERE StudentID = @StudentID";

                    using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
                    {
                        // Replace placeholders with actual values
                        cmd.Parameters.AddWithValue("@StudentID", studentID);
                        using (MySqlDataReader myReader = cmd.ExecuteReader())
                        {

                            if (myReader.Read())
                            {
                                string name = myReader["Name"].ToString();
                                string gpa = myReader["OverallGPA"].ToString();

                                studentInfo = $"Name: {name}   Student ID: {studentID}   GPA: {gpa}\n";
                            }
                        }

                        
                    }

                    query = "SELECT * FROM adams_grade WHERE StudentID = @StudentID";

                    using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
                    {
                        // Replace placeholders with actual values
                        cmd.Parameters.AddWithValue("@StudentID", studentID);
                        using (MySqlDataReader myReader = cmd.ExecuteReader())
                        {

                            while (myReader.Read())
                            {
                                string coursePrefix = myReader["CoursePrefix"].ToString();
                                string courseNum = myReader["CourseNum"].ToString();
                                string grade = myReader["Grade"].ToString();

                                gradeInfo += $"{coursePrefix}   {courseNum}          Grade: {grade}\n";
                            }
                        }


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gpaLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void submitTranscript_Click(object sender, EventArgs e)
        {
            int sid = int.Parse(transcriptTB.Text);
            string studentInfo, gradeInfo;
            printTranscript(sid, out studentInfo, out gradeInfo);
            infoLabel.Text = studentInfo;
            gradesLabel.Text = gradeInfo;
        }

        private void displayGrades(int studentID, out List<string> grades, out List<int> id)
        {
            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?";

            grades = new List<string>();
            id = new List<int>();

            using (var conn = new MySql.Data.MySqlClient.MySqlConnection(connStr))
            {
                conn.Open();

                // SQL query to delete the grade
                string query = "SELECT * FROM adams_grade WHERE StudentID = @StudentID";

                using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
                {
                    // Replace placeholders with actual values
                    cmd.Parameters.AddWithValue("@StudentID", studentID);
                    using (MySqlDataReader myReader = cmd.ExecuteReader())
                    {

                        while (myReader.Read())
                        {
                            string coursePrefix = myReader["CoursePrefix"].ToString();
                            string courseNum = myReader["CourseNum"].ToString();
                            string grade = myReader["Grade"].ToString();
                            int crn = int.Parse(myReader["CRN"].ToString());

                            grades.Add($"{coursePrefix}   {courseNum}          Grade: {grade}\n");
                            id.Add(crn);
                        }
                        
                    }


                }
            }
            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteGradeIDSubmit_Click_1(object sender, EventArgs e)
        {
            int studentId = int.Parse(deleteIdTB.Text);
            List<string> grades;
            List<int> id;
            displayGrades(studentId, out grades, out id);
            gradeID = id;
            deleteBox.DataSource = grades;

        }

        private void editGrade(int studentID, Grade grade, int crn)
        {
            string connStr = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?";
            using (var conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string sql = "UPDATE adams_grade SET Grade=@Grade WHERE StudentID=@StudentID AND CRN=@CRN";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", studentID);
                        cmd.Parameters.AddWithValue("@Grade", grade.ToString()); // Convert enum to string due to us using the 5 letters
                        cmd.Parameters.AddWithValue("@CRN", crn);
                        cmd.ExecuteNonQuery();

                        int rowsAffected = cmd.ExecuteNonQuery(); // Executes the query
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Grade updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No matching grade found to update.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        private void editSubmitButton_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            panel6.Hide();
            panel7.Hide();
            panel5.Show();
            int studentId = int.Parse(studentIDEditBox.Text);
            List<string> grades;
            List<int> id;
            displayGrades(studentId, out grades, out id);
            gradeID = id;
            editBox.DataSource = grades;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int courseID = gradeID[editBox.SelectedIndex];
            int studentID = int.Parse(studentIDEditBox.Text);
            Grade grade = (Grade)Enum.Parse(typeof(Grade), newGradeBox.Text.ToString());
            System.Diagnostics.Debug.WriteLine(grade);
            editGrade(studentID, grade, courseID);
            List<string> grades;
            List<int> id;
            displayGrades(studentID, out grades, out id);
            gradeID = id;
            editBox.DataSource = grades;
        }
    }

}


