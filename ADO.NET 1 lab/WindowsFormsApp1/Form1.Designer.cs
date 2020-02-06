using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnRequest = new System.Windows.Forms.Button();
            this.DatGridDBTables = new System.Windows.Forms.DataGridView();
            this.ColTables = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFields = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datGridSQLResult = new System.Windows.Forms.DataGridView();
            this.tbDatSource = new System.Windows.Forms.TextBox();
            this.tblnitCat = new System.Windows.Forms.TextBox();
            this.tbRequest = new System.Windows.Forms.TextBox();
            this.labSQLReq = new System.Windows.Forms.Label();
            this.lablnitCat = new System.Windows.Forms.Label();
            this.labDatSource = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DatGridDBTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datGridSQLResult)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Location = new System.Drawing.Point(447, 41);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(85, 20);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect to DB";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnRequest
            // 
            this.btnRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRequest.Enabled = false;
            this.btnRequest.Location = new System.Drawing.Point(447, 198);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(85, 20);
            this.btnRequest.TabIndex = 1;
            this.btnRequest.Text = "Send Request";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // DatGridDBTables
            // 
            this.DatGridDBTables.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DatGridDBTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatGridDBTables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColTables,
            this.ColFields});
            this.DatGridDBTables.Enabled = false;
            this.DatGridDBTables.Location = new System.Drawing.Point(12, 67);
            this.DatGridDBTables.Name = "DatGridDBTables";
            this.DatGridDBTables.ReadOnly = true;
            this.DatGridDBTables.Size = new System.Drawing.Size(520, 121);
            this.DatGridDBTables.TabIndex = 2;
            this.DatGridDBTables.Click += new System.EventHandler(this.MainForm_Load);
            this.DatGridDBTables.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DatGridDBTables_MouseUp);
            this.DatGridDBTables.Resize += new System.EventHandler(this.DatGridDBTables_Resize);
            // 
            // ColTables
            // 
            this.ColTables.HeaderText = "Table Name";
            this.ColTables.Name = "ColTables";
            this.ColTables.ReadOnly = true;
            this.ColTables.Width = 80;
            // 
            // ColFields
            // 
            this.ColFields.HeaderText = "Field Names in Table";
            this.ColFields.Name = "ColFields";
            this.ColFields.ReadOnly = true;
            this.ColFields.Width = 280;
            // 
            // datGridSQLResult
            // 
            this.datGridSQLResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datGridSQLResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datGridSQLResult.Enabled = false;
            this.datGridSQLResult.Location = new System.Drawing.Point(12, 224);
            this.datGridSQLResult.Name = "datGridSQLResult";
            this.datGridSQLResult.ReadOnly = true;
            this.datGridSQLResult.Size = new System.Drawing.Size(520, 157);
            this.datGridSQLResult.TabIndex = 3;
            this.datGridSQLResult.Click += new System.EventHandler(this.MainForm_Load);
            this.datGridSQLResult.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DatGridDBTables_MouseUp);
            // 
            // tbDatSource
            // 
            this.tbDatSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDatSource.BackColor = System.Drawing.SystemColors.Info;
            this.tbDatSource.ForeColor = System.Drawing.Color.Green;
            this.tbDatSource.Location = new System.Drawing.Point(88, 12);
            this.tbDatSource.Name = "tbDatSource";
            this.tbDatSource.Size = new System.Drawing.Size(444, 20);
            this.tbDatSource.TabIndex = 4;
            this.tbDatSource.Text = "localhost\\VSdotNET";
            // 
            // tblnitCat
            // 
            this.tblnitCat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblnitCat.BackColor = System.Drawing.SystemColors.Info;
            this.tblnitCat.ForeColor = System.Drawing.Color.Green;
            this.tblnitCat.Location = new System.Drawing.Point(88, 41);
            this.tblnitCat.Name = "tblnitCat";
            this.tblnitCat.Size = new System.Drawing.Size(353, 20);
            this.tblnitCat.TabIndex = 5;
            this.tblnitCat.Text = "CompShop";
            // 
            // tbRequest
            // 
            this.tbRequest.BackColor = System.Drawing.SystemColors.Info;
            this.tbRequest.Enabled = false;
            this.tbRequest.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tbRequest.Location = new System.Drawing.Point(88, 198);
            this.tbRequest.Name = "tbRequest";
            this.tbRequest.Size = new System.Drawing.Size(353, 20);
            this.tbRequest.TabIndex = 6;
            this.tbRequest.Text = "SELECT * FROM Table";
            // 
            // labSQLReq
            // 
            this.labSQLReq.AutoSize = true;
            this.labSQLReq.Location = new System.Drawing.Point(12, 202);
            this.labSQLReq.Name = "labSQLReq";
            this.labSQLReq.Size = new System.Drawing.Size(74, 13);
            this.labSQLReq.TabIndex = 7;
            this.labSQLReq.Text = "SQL Request:";
            // 
            // lablnitCat
            // 
            this.lablnitCat.AutoSize = true;
            this.lablnitCat.Location = new System.Drawing.Point(12, 45);
            this.lablnitCat.Name = "lablnitCat";
            this.lablnitCat.Size = new System.Drawing.Size(73, 13);
            this.lablnitCat.TabIndex = 8;
            this.lablnitCat.Text = "Initial Catalog:";
            // 
            // labDatSource
            // 
            this.labDatSource.AutoSize = true;
            this.labDatSource.Location = new System.Drawing.Point(12, 15);
            this.labDatSource.Name = "labDatSource";
            this.labDatSource.Size = new System.Drawing.Size(70, 13);
            this.labDatSource.TabIndex = 9;
            this.labDatSource.Text = "Data Source:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 393);
            this.Controls.Add(this.labDatSource);
            this.Controls.Add(this.lablnitCat);
            this.Controls.Add(this.labSQLReq);
            this.Controls.Add(this.tbRequest);
            this.Controls.Add(this.tblnitCat);
            this.Controls.Add(this.tbDatSource);
            this.Controls.Add(this.datGridSQLResult);
            this.Controls.Add(this.DatGridDBTables);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.btnConnect);
            this.MinimumSize = new System.Drawing.Size(300, 350);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Base Request";
            ((System.ComponentModel.ISupportInitialize)(this.DatGridDBTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datGridSQLResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.DataGridView DatGridDBTables;
        private System.Windows.Forms.DataGridView datGridSQLResult;
        private System.Windows.Forms.TextBox tbDatSource;
        private System.Windows.Forms.TextBox tblnitCat;
        private System.Windows.Forms.TextBox tbRequest;
        private System.Windows.Forms.Label labSQLReq;
        private System.Windows.Forms.Label lablnitCat;
        private System.Windows.Forms.Label labDatSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTables;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFields;

        //Клас виконуючий зв'якзок з БД і запит до неї
        public DBRequest UserReq;

        //Таблиця-Результат виконання запиту
        private System.Data.DataTable RequestTab;

        //Таблиця структури таблиць із БД
        private System.Data.DataTable StructTab;

        //Назва таблиці, опрацьованої останній раз в StructTab_OnRowChanged
        private string LastTabName;

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            //Створюємо класс взаємодії з БД
            UserReq = new DBRequest();
            //Створюємо таблицю і добавляєм в неї стовбці:
            StructTab = new System.Data.DataTable("TabFiels"); //Таблиця StructTab установлюється в якості джерела даних для візуальної компоненти DatGridDBTables, яка буде відображати дані цієї таблиці в формі строки 242 243
            System.Data.DataColumn NewDatCol = new System.Data.DataColumn("Tables", System.Type.GetType("System.String"));
            NewDatCol.AllowDBNull = false;
            NewDatCol.Unique = true;
            StructTab.Columns.Add(NewDatCol);
            NewDatCol = new System.Data.DataColumn("Fields", System.Type.GetType("System.String"));
            NewDatCol.AllowDBNull = false;
            NewDatCol.DefaultValue = "none;";
            StructTab.Columns.Add(NewDatCol);
            DatGridDBTables.DataSource = StructTab;
            DatGridDBTables.ReadOnly = false;
            datGridSQLResult.DataSource = RequestTab; //(Спочатку див. строку 233) В якості джерела тут також виступає StructTab
            //Підключаєм до таблиці оброблювач події зміни строки:
            StructTab.RowChanged += new System.Data.DataRowChangeEventHandler(StructTab_OnRowChanged); //Підключення обробника подій зміни строки StructTab.RowChanged
        }

        private void StructTab_OnRowChanged(object sender, System.Data.DataRowChangeEventArgs e)
        {
            try
            {
                if(LastTabName != (string) e.Row["Tables"])
                {
                    LastTabName = (string)e.Row["Tables"];
                    string Fields = UserReq.GetTableFields(LastTabName);
                    e.Row["Fields"] = Fields;
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(this, ex.Message, "Connection Error", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }
    }
}

