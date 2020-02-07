using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
            catch (Exception e1)
            {
                MessageBox.Show(this, e1.Message, "Connection Error", MessageBoxButtons.OK,    //1
                    MessageBoxIcon.Error);
                Connected = false;
            }

            if (Connected)
            {
                MessageBox.Show("Вы смогли подключиться!");
                //Відкриваєм доступ до управління виконуванням запитів:
                btnRequest.Enabled = true;
                tbRequest.Enabled = true;
                btnConnect.Enabled = true;
                datGridSQLResult.Enabled = true;
                DatGridDBTables.Enabled = true;
            }
            else
            {
                //Закриваємо доступ до управління виконуванням запитів:
                btnRequest.Enabled = false;
                tbRequest.Enabled = false;
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
            catch(Exception ex)
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

        private void MainForm_Load_1(object sender, EventArgs e)
        {
            //Створюємо класс взаємодії з БД
            UserReq = new DBRequest();
            //Створюємо таблицю і добавляєм в неї стовбці:
            StructTab = new DataTable(); //Таблиця StructTab установлюється в якості джерела даних для візуальної компоненти DatGridDBTables, яка буде відображати дані цієї таблиці в формі строки 242 243
            DataColumn NewDatCol = new DataColumn("Tables", Type.GetType("System.String"));
            NewDatCol.AllowDBNull = false;
            NewDatCol.Unique = true;
            StructTab.Columns.Add(NewDatCol);
            NewDatCol = new DataColumn("Fields", Type.GetType("System.String"));
            NewDatCol.AllowDBNull = false;
            NewDatCol.DefaultValue = "none;";
            StructTab.Columns.Add(NewDatCol);
            DatGridDBTables.DataSource = StructTab;
            DatGridDBTables.ReadOnly = false;
            datGridSQLResult.DataSource = RequestTab; //(Спочатку див. строку 233) В якості джерела тут також виступає StructTab
            //Підключаєм до таблиці оброблювач події зміни строки:
            StructTab.RowChanged += new DataRowChangeEventHandler(StructTab_OnRowChanged); //Підключення обробника подій зміни строки StructTab.RowChanged
        }

        private void StructTab_OnRowChanged(object sender, DataRowChangeEventArgs e)
        {
            try
            {
                if (LastTabName != (string)e.Row["Tables"])
                {
                    LastTabName = (string)e.Row["Tables"];
                    string Fields = UserReq.GetTableFields(LastTabName);
                    e.Row["Fields"] = Fields;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Connection Error", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }
    }
}
