using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            bool Connected = false;
            Cursor = Cursors.WaitCursor;
            //Пробуємо зв'язатись з БД
            try
            {
                UserReq.Disconnect();
                UserReq.ConnectTo(tbDatSource.Text, tblnitCat.Text); //Метод підключення до БД, приймає значення назви сервера, та назви БД
                Connected = true;
            }
            catch (SqlException e1)
            {
                MessageBox.Show(this, e1.Message, "Connection Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Connected = false;
            }

            if (Connected)
            {
                //Відкриваєм доступ до управління виконуванням запитів:
                tbRequest.Enabled = true;
                btnConnect.Enabled = true;
                datGridSQLResult.Enabled = true;
                DatGridDBTables.Enabled = true;
            }
            else
            {
                //Закриваємо доступ до управління виконуванням запитів:
                tbRequest.Enabled = false;
                btnConnect.Enabled = false;
                datGridSQLResult.Enabled = false;
                DatGridDBTables.Enabled = false;
            }

            Cursor = Cursors.Arrow;

            try
            {
                StructTab.Clear();
                RequestTab.Clear();
            }
            catch
            { }
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            try
            {
                RequestTab = UserReq.SQLRequest(tbRequest.Text); //Присвоєння RequstTab значення вводимого запиту
                datGridSQLResult.DataSource = RequestTab;
            }
            catch(SqlException ex)
            {
                MessageBox.Show(this, ex.Message, "Request Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor = Cursors.Arrow;
        }

        private void DatGridDBTables_MouseUp(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo HitInfo = DatGridDBTables.HitTest(e.X, e.Y);
            if((HitInfo.RowIndex >= 0) && (HitInfo.RowIndex < StructTab.Rows.Count))
            {
                tbRequest.Text = "SELECT * FROM " + (string)StructTab.Rows[HitInfo.RowIndex]["Tables"]; //?
                btnRequest_Click(this, null);
            }
        }

        private void DatGridDBTables_Resize(object sender, EventArgs e)
        {
          //??
        }
    }
}
