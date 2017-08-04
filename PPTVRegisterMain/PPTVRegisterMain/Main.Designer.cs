namespace PPTVRegisterMain
{
    partial class Main
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.btnUnicodeTo = new System.Windows.Forms.Button();
            this.txbUnicode = new System.Windows.Forms.TextBox();
            this.txbChinese = new System.Windows.Forms.TextBox();
            this.btnSinaReg = new System.Windows.Forms.Button();
            this.txbUrl = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "第三方登录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUnicodeTo
            // 
            this.btnUnicodeTo.Location = new System.Drawing.Point(438, 43);
            this.btnUnicodeTo.Name = "btnUnicodeTo";
            this.btnUnicodeTo.Size = new System.Drawing.Size(120, 23);
            this.btnUnicodeTo.TabIndex = 1;
            this.btnUnicodeTo.Text = "unicode转码";
            this.btnUnicodeTo.UseVisualStyleBackColor = true;
            this.btnUnicodeTo.Click += new System.EventHandler(this.btnUnicodeTo_Click);
            // 
            // txbUnicode
            // 
            this.txbUnicode.Location = new System.Drawing.Point(13, 43);
            this.txbUnicode.Multiline = true;
            this.txbUnicode.Name = "txbUnicode";
            this.txbUnicode.Size = new System.Drawing.Size(419, 111);
            this.txbUnicode.TabIndex = 2;
            // 
            // txbChinese
            // 
            this.txbChinese.Location = new System.Drawing.Point(564, 43);
            this.txbChinese.Multiline = true;
            this.txbChinese.Name = "txbChinese";
            this.txbChinese.Size = new System.Drawing.Size(531, 111);
            this.txbChinese.TabIndex = 3;
            // 
            // btnSinaReg
            // 
            this.btnSinaReg.Location = new System.Drawing.Point(94, 13);
            this.btnSinaReg.Name = "btnSinaReg";
            this.btnSinaReg.Size = new System.Drawing.Size(91, 23);
            this.btnSinaReg.TabIndex = 4;
            this.btnSinaReg.Text = "注册PPTV";
            this.btnSinaReg.UseVisualStyleBackColor = true;
            this.btnSinaReg.Click += new System.EventHandler(this.btnSinaReg_Click);
            // 
            // txbUrl
            // 
            this.txbUrl.Location = new System.Drawing.Point(48, 161);
            this.txbUrl.Name = "txbUrl";
            this.txbUrl.Size = new System.Drawing.Size(1047, 21);
            this.txbUrl.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.Password});
            this.dataGridView1.Location = new System.Drawing.Point(13, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1082, 498);
            this.dataGridView1.TabIndex = 6;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "UserName";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 200;
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "代理";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 699);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txbUrl);
            this.Controls.Add(this.btnSinaReg);
            this.Controls.Add(this.txbChinese);
            this.Controls.Add(this.txbUnicode);
            this.Controls.Add(this.btnUnicodeTo);
            this.Controls.Add(this.button1);
            this.Name = "Main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUnicodeTo;
        private System.Windows.Forms.TextBox txbUnicode;
        private System.Windows.Forms.TextBox txbChinese;
        private System.Windows.Forms.Button btnSinaReg;
        private System.Windows.Forms.TextBox txbUrl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.Label label1;
    }
}

