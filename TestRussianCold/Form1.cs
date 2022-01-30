using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestRussianCold
{
    public partial class Form1 : Form
    {
        Service service;
        public Form1()
        {
            service = new Service();
            InitializeComponent();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateFormat dateFrom = DateFormat.FromString(DateFromTextBox.Text);
                TimeFormat timeFrom = TimeFormat.FromString(TimeFromTextBox.Text);

                DateFormat dateTo = DateFormat.FromString(DateToTextBox.Text);
                TimeFormat timeTo = TimeFormat.FromString(TimeToTextBox.Text);

                DateFormat dateTest = DateFormat.FromString(DateTestTextBox.Text);
                TimeFormat timeTest = TimeFormat.FromString(TimeTestTextBox.Text);

                MessageBox.Show(dateFrom.ToString() + " " + timeFrom.ToString());
                MessageBox.Show(dateTo.ToString() + " " + timeTo.ToString());
                MessageBox.Show(dateTest.ToString() + " " + timeTest.ToString());

                if (dateFrom.IsValid() && timeFrom.IsValid() && dateTo.IsValid() && timeTo.IsValid() && dateTest.IsValid() && timeTest.IsValid())
                    throw new Exception("Возникла проблема с правильностью данных!");
                if (service.DateTimeInRange(dateFrom, timeFrom, dateTo, timeTo, dateTest, timeTest))
                    MessageBox.Show("Указанные дата и время попадают в интервал!");
                else
                    MessageBox.Show("Указанные дата и время НЕ попадают в интервал!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
