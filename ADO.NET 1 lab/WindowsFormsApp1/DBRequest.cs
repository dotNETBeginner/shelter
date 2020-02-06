using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public class DBRequest
    {
        private SqlConnection DbCon = new SqlConnection(); //Створення змінної для строки підключення

        ~DBRequest()    //Деструктор класу, деструкутор буде відключати зв'язок з БД
        { Disconnect(); }

        public void ConnectTo(string DataSource, string InitialCatalog) //Метод підключення до БД
        {
            DbCon.ConnectionString = $@"Data Source={DataSource};Initial Catalog={InitialCatalog};Integrated Security = True "; //Ініціалізація строки підключення

            try
            { DbCon.Open(); }
            catch(SqlException ex)
            { throw ex; }
        }

        public void Disconnect() //Метод відключення
        {
            try
            {
               if(DbCon.State == System.Data.ConnectionState.Open) //Перевірка на те чи є зв'язок з БД
                { DbCon.Close(); } //Якщо є, то зв'язок закінчується
            }
            catch
            { }
        }

        public string GetTableFields(string TableName)
        {
            if(DbCon.State == System.Data.ConnectionState.Open) //Перевірка чи відкрите підключення з БД
            {
                System.Data.DataTable CurTable = new System.Data.DataTable("ConnectedTab"); //Даний об'єкт представляє деяку таблицю
                SqlDataAdapter DBAdapt; //об'єкт класу SqlDataAdapter який реалізує обробку всеможливих SQL запитів

                try
                {
                    DBAdapt = new SqlDataAdapter("SELECT * FROM " + TableName, DbCon); //В конструктор передається запит який виконує вибірку
                    DBAdapt.Fill(CurTable);  //всіх рядків з таблиці TableName, та посилання на об'єкт підключення з БД 
                }                            //Метод Fill заповнює створений нами об'єкт CurTable даними таблиці БД, завантаженими з сервера
                catch(SqlException ex)
                { throw ex; }

                string ResStr = "";
                int ColCount = CurTable.Columns.Count;


                for(int i = 0; i < ColCount; i++) //В цьому циклі виробляєтсья формування строки ResStr зі списком полів завантаженої нами таблиці
                {                                  //Доступ до полів виробляється через поле Columns класа DataTable
                    string StrCon = ", ";

                    if(i == ColCount - 1) { StrCon = ";"; }

                    ResStr += CurTable.Columns[i].ColumnName + "[" +
                        CurTable.Columns[i].DataType.Name + "]" + StrCon;
                }

                return ResStr;
            }

            else { return null; }
        }

        public System.Data.DataTable SQLRequest(string RequestStr)
        {
            if(DbCon.State == System.Data.ConnectionState.Open) //Перевірка зв'язку з БД
            {
                System.Data.DataTable ResultTab = new System.Data.DataTable("SQLresult"); //Створення таблиці для виводу результату введеного запиту
                SqlDataAdapter DBAdapt;

                try
                {
                    DBAdapt = new SqlDataAdapter(RequestStr, DbCon); //Додавання в адаптер строки з запитом, та строки підключення до БД
                    DBAdapt.Fill(ResultTab); //Виконання запиту до таблиці
                }
                catch(SqlException ex)
                { throw ex; }

                return ResultTab; //Вивід результату
            }
            else { return null; }
        }
    }
}
