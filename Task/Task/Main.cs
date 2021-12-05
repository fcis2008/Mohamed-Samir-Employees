using System;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

namespace Task
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void ButtonBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                textBoxEmployeeFilePath.Text = openFileDialog.FileName;
        }

        private void ButtonLoadEmployees_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxEmployeeFilePath.Text))
            {
                MessageBox.Show("Select employee file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonBrowse.Focus();
                return;
            }

            List<Employee> employeesList = ReadEmployeesData(File.ReadAllLines(textBoxEmployeeFilePath.Text));

            var employeesWorkedTogther = employeesList.GroupBy(employee => employee.ProjectID).OrderBy(o => o.Key);

            List<PairEmployee> pairEmployeesList = new List<PairEmployee>();

            foreach (var group in employeesWorkedTogther)
                pairEmployeesList.Add(CalculateLongestOverlappedTwoTeams(group.ToList()));

            dataGridView1.DataSource = pairEmployeesList;
        }

        private PairEmployee CalculateLongestOverlappedTwoTeams(List<Employee> employees)
        {
            List<PairEmployee> pairEmployeesList = new List<PairEmployee>();

            if (employees.Count == 1)
            {
                pairEmployeesList.Add(new PairEmployee
                {
                    Employee1ID = employees[0].EmployeeID,
                    Employee2ID = employees[0].EmployeeID,
                    CommonProjectID = employees[0].ProjectID,
                    DaysWorked = GetOverlapBetweenTwoTeam(employees[0].StartDate, employees[0].EndDate, employees[0].StartDate, employees[0].EndDate)
                });
            }
            else
            {
                for (int i = 0; i < employees.Count - 1; i++)
                {
                    for (int j = i + 1; j < employees.Count; j++)
                    {
                        pairEmployeesList.Add(new PairEmployee
                        {
                            Employee1ID = employees[i].EmployeeID,
                            Employee2ID = employees[j].EmployeeID,
                            CommonProjectID = employees[i].ProjectID,
                            DaysWorked = GetOverlapBetweenTwoTeam(employees[i].StartDate, employees[i].EndDate, employees[j].StartDate, employees[j].EndDate)
                        });
                    }
                }
            }
            return pairEmployeesList.Aggregate((x, y) => x.DaysWorked > y.DaysWorked ? x : y);
        }

        private List<Employee> ReadEmployeesData(string[] lines)
        {
            List<Employee> employeesList = new List<Employee>();

            foreach (var line in lines)
            {
                string[] temp = line.Split(',');

                employeesList.Add(new Employee()
                {
                    EmployeeID = int.Parse(temp[0]),
                    ProjectID = int.Parse(temp[1]),
                    StartDate = DateTime.Parse(temp[2]),
                    EndDate = temp[3].ToUpper() == "NULL" ? DateTime.Now.Date : DateTime.Parse(temp[3])
                });
            }
            return employeesList;
        }

        int GetOverlapBetweenTwoTeam(DateTime employee1StartDate, DateTime employee1EndDate, DateTime employee2StartDate, DateTime employee2EndDate)
        {
            DateTime start = employee1StartDate < employee2StartDate ? employee2StartDate : employee1StartDate;
            DateTime end = employee1EndDate < employee2EndDate ? employee1EndDate : employee2EndDate;

            if (end >= start)
                return end.Date.Subtract(start.Date).Days;
            else
                return 0;
        }
    }
}
