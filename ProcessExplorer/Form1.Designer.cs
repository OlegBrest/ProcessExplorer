namespace ProcessExplorer
{
    partial class Main_Form
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
            this.Main_splitContainer = new System.Windows.Forms.SplitContainer();
            this.Main_panel = new System.Windows.Forms.Panel();
            this.Main_DGV = new System.Windows.Forms.DataGridView();
            this.ID_clmn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.handle_clmn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.winhandle_clmn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filepath_clmn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priority_clmn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.threads_clmn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Main_splitContainer)).BeginInit();
            this.Main_splitContainer.Panel1.SuspendLayout();
            this.Main_splitContainer.SuspendLayout();
            this.Main_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Main_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Main_splitContainer
            // 
            this.Main_splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_splitContainer.Location = new System.Drawing.Point(0, 0);
            this.Main_splitContainer.Name = "Main_splitContainer";
            this.Main_splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // Main_splitContainer.Panel1
            // 
            this.Main_splitContainer.Panel1.Controls.Add(this.Main_panel);
            this.Main_splitContainer.Size = new System.Drawing.Size(800, 450);
            this.Main_splitContainer.SplitterDistance = 377;
            this.Main_splitContainer.TabIndex = 0;
            // 
            // Main_panel
            // 
            this.Main_panel.Controls.Add(this.Main_DGV);
            this.Main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_panel.Location = new System.Drawing.Point(0, 0);
            this.Main_panel.Name = "Main_panel";
            this.Main_panel.Size = new System.Drawing.Size(800, 377);
            this.Main_panel.TabIndex = 0;
            // 
            // Main_DGV
            // 
            this.Main_DGV.AllowUserToAddRows = false;
            this.Main_DGV.AllowUserToDeleteRows = false;
            this.Main_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Main_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Main_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_clmn,
            this.handle_clmn,
            this.winhandle_clmn,
            this.Name_column,
            this.filepath_clmn,
            this.priority_clmn,
            this.threads_clmn});
            this.Main_DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_DGV.Location = new System.Drawing.Point(0, 0);
            this.Main_DGV.Name = "Main_DGV";
            this.Main_DGV.ReadOnly = true;
            this.Main_DGV.Size = new System.Drawing.Size(800, 377);
            this.Main_DGV.TabIndex = 0;
            // 
            // ID_clmn
            // 
            this.ID_clmn.HeaderText = "ID";
            this.ID_clmn.Name = "ID_clmn";
            this.ID_clmn.ReadOnly = true;
            this.ID_clmn.Width = 43;
            // 
            // handle_clmn
            // 
            this.handle_clmn.HeaderText = "Хэндл";
            this.handle_clmn.Name = "handle_clmn";
            this.handle_clmn.ReadOnly = true;
            this.handle_clmn.Width = 63;
            // 
            // winhandle_clmn
            // 
            this.winhandle_clmn.HeaderText = "Хэндл окна";
            this.winhandle_clmn.Name = "winhandle_clmn";
            this.winhandle_clmn.ReadOnly = true;
            this.winhandle_clmn.Width = 90;
            // 
            // Name_column
            // 
            this.Name_column.HeaderText = "Процесс";
            this.Name_column.Name = "Name_column";
            this.Name_column.ReadOnly = true;
            this.Name_column.Width = 76;
            // 
            // filepath_clmn
            // 
            this.filepath_clmn.HeaderText = "Путь";
            this.filepath_clmn.Name = "filepath_clmn";
            this.filepath_clmn.ReadOnly = true;
            this.filepath_clmn.Width = 56;
            // 
            // priority_clmn
            // 
            this.priority_clmn.HeaderText = "Приоритет";
            this.priority_clmn.Name = "priority_clmn";
            this.priority_clmn.ReadOnly = true;
            this.priority_clmn.Width = 86;
            // 
            // threads_clmn
            // 
            this.threads_clmn.HeaderText = "Потоков";
            this.threads_clmn.Name = "threads_clmn";
            this.threads_clmn.ReadOnly = true;
            this.threads_clmn.Width = 75;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Main_splitContainer);
            this.Name = "Main_Form";
            this.Text = "ProcExplorer";
            this.Shown += new System.EventHandler(this.Main_Form_Shown);
            this.Main_splitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Main_splitContainer)).EndInit();
            this.Main_splitContainer.ResumeLayout(false);
            this.Main_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Main_DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer Main_splitContainer;
        private System.Windows.Forms.Panel Main_panel;
        private System.Windows.Forms.DataGridView Main_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_clmn;
        private System.Windows.Forms.DataGridViewTextBoxColumn handle_clmn;
        private System.Windows.Forms.DataGridViewTextBoxColumn winhandle_clmn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn filepath_clmn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priority_clmn;
        private System.Windows.Forms.DataGridViewTextBoxColumn threads_clmn;
    }
}

