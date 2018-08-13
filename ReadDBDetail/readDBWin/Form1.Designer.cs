namespace readDBWin
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.query = new System.Windows.Forms.Button();
            this.outport = new System.Windows.Forms.Button();
            this.表名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.字段序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.字段名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.标识 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.主键 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.占用字节数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.长度 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.小数位数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.允许空 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.默认值 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.说明 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.表名,
            this.字段序号,
            this.字段名,
            this.标识,
            this.主键,
            this.类型,
            this.占用字节数,
            this.长度,
            this.小数位数,
            this.允许空,
            this.默认值,
            this.说明});
            this.dataGridView1.Location = new System.Drawing.Point(12, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(840, 386);
            this.dataGridView1.TabIndex = 0;
            // 
            // query
            // 
            this.query.Location = new System.Drawing.Point(12, 22);
            this.query.Name = "query";
            this.query.Size = new System.Drawing.Size(75, 23);
            this.query.TabIndex = 1;
            this.query.Text = "查询所有字段";
            this.query.UseVisualStyleBackColor = true;
            this.query.Click += new System.EventHandler(this.query_Click);
            // 
            // outport
            // 
            this.outport.Location = new System.Drawing.Point(93, 22);
            this.outport.Name = "outport";
            this.outport.Size = new System.Drawing.Size(81, 23);
            this.outport.TabIndex = 2;
            this.outport.Text = "导出";
            this.outport.UseVisualStyleBackColor = true;
            this.outport.Click += new System.EventHandler(this.outport_Click);
            // 
            // 表名
            // 
            this.表名.DataPropertyName = "表名";
            this.表名.HeaderText = "表名";
            this.表名.Name = "表名";
            this.表名.ReadOnly = true;
            // 
            // 字段序号
            // 
            this.字段序号.DataPropertyName = "字段序号";
            this.字段序号.HeaderText = "字段序号";
            this.字段序号.Name = "字段序号";
            this.字段序号.ReadOnly = true;
            // 
            // 字段名
            // 
            this.字段名.DataPropertyName = "字段名";
            this.字段名.HeaderText = "字段名";
            this.字段名.Name = "字段名";
            this.字段名.ReadOnly = true;
            // 
            // 标识
            // 
            this.标识.DataPropertyName = "标识";
            this.标识.HeaderText = "标识";
            this.标识.Name = "标识";
            this.标识.ReadOnly = true;
            // 
            // 主键
            // 
            this.主键.DataPropertyName = "主键";
            this.主键.HeaderText = "主键";
            this.主键.Name = "主键";
            this.主键.ReadOnly = true;
            // 
            // 类型
            // 
            this.类型.DataPropertyName = "类型";
            this.类型.HeaderText = "类型";
            this.类型.Name = "类型";
            this.类型.ReadOnly = true;
            // 
            // 占用字节数
            // 
            this.占用字节数.DataPropertyName = "占用字节数";
            this.占用字节数.HeaderText = "占用字节数";
            this.占用字节数.Name = "占用字节数";
            this.占用字节数.ReadOnly = true;
            // 
            // 长度
            // 
            this.长度.DataPropertyName = "长度";
            this.长度.HeaderText = "长度";
            this.长度.Name = "长度";
            this.长度.ReadOnly = true;
            // 
            // 小数位数
            // 
            this.小数位数.DataPropertyName = "小数位数";
            this.小数位数.HeaderText = "小数位数";
            this.小数位数.Name = "小数位数";
            this.小数位数.ReadOnly = true;
            // 
            // 允许空
            // 
            this.允许空.DataPropertyName = "允许空";
            this.允许空.HeaderText = "允许空";
            this.允许空.Name = "允许空";
            this.允许空.ReadOnly = true;
            // 
            // 默认值
            // 
            this.默认值.DataPropertyName = "默认值";
            this.默认值.HeaderText = "默认值";
            this.默认值.Name = "默认值";
            this.默认值.ReadOnly = true;
            // 
            // 说明
            // 
            this.说明.DataPropertyName = "说明";
            this.说明.HeaderText = "说明";
            this.说明.Name = "说明";
            this.说明.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 458);
            this.Controls.Add(this.outport);
            this.Controls.Add(this.query);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button query;
        private System.Windows.Forms.Button outport;
        private System.Windows.Forms.DataGridViewTextBoxColumn 表名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 字段序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 字段名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 标识;
        private System.Windows.Forms.DataGridViewTextBoxColumn 主键;
        private System.Windows.Forms.DataGridViewTextBoxColumn 类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 占用字节数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 长度;
        private System.Windows.Forms.DataGridViewTextBoxColumn 小数位数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 允许空;
        private System.Windows.Forms.DataGridViewTextBoxColumn 默认值;
        private System.Windows.Forms.DataGridViewTextBoxColumn 说明;
    }
}

