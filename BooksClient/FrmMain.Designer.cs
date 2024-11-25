namespace BooksClient
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbQueryOptions = new GroupBox();
            btnOneOfApiClient = new Button();
            btnArdalisResultClient = new Button();
            btnNiaveApiClient = new Button();
            txtBookId = new TextBox();
            rdoGetBookById = new RadioButton();
            rdoGetAllBooks = new RadioButton();
            lblOutput = new Label();
            txtOutput = new TextBox();
            gbQueryOptions.SuspendLayout();
            SuspendLayout();
            // 
            // gbQueryOptions
            // 
            gbQueryOptions.Controls.Add(btnOneOfApiClient);
            gbQueryOptions.Controls.Add(btnArdalisResultClient);
            gbQueryOptions.Controls.Add(btnNiaveApiClient);
            gbQueryOptions.Controls.Add(txtBookId);
            gbQueryOptions.Controls.Add(rdoGetBookById);
            gbQueryOptions.Controls.Add(rdoGetAllBooks);
            gbQueryOptions.Location = new Point(3, 14);
            gbQueryOptions.Name = "gbQueryOptions";
            gbQueryOptions.Size = new Size(716, 143);
            gbQueryOptions.TabIndex = 0;
            gbQueryOptions.TabStop = false;
            gbQueryOptions.Text = "Query Options";
            // 
            // btnOneOfApiClient
            // 
            btnOneOfApiClient.Location = new Point(356, 109);
            btnOneOfApiClient.Name = "btnOneOfApiClient";
            btnOneOfApiClient.Size = new Size(144, 23);
            btnOneOfApiClient.TabIndex = 5;
            btnOneOfApiClient.Text = "Use OneOf API Client";
            btnOneOfApiClient.UseVisualStyleBackColor = true;
            btnOneOfApiClient.Click += btnOneOfApiClient_Click;
            // 
            // btnArdalisResultClient
            // 
            btnArdalisResultClient.Location = new Point(164, 107);
            btnArdalisResultClient.Name = "btnArdalisResultClient";
            btnArdalisResultClient.Size = new Size(172, 23);
            btnArdalisResultClient.TabIndex = 4;
            btnArdalisResultClient.Text = "Use Ardalis.Result API Client";
            btnArdalisResultClient.UseVisualStyleBackColor = true;
            btnArdalisResultClient.Click += btnArdalisResultClient_Click;
            // 
            // btnNiaveApiClient
            // 
            btnNiaveApiClient.Location = new Point(13, 106);
            btnNiaveApiClient.Name = "btnNiaveApiClient";
            btnNiaveApiClient.Size = new Size(134, 23);
            btnNiaveApiClient.TabIndex = 3;
            btnNiaveApiClient.Text = "Use Niave API Client";
            btnNiaveApiClient.UseVisualStyleBackColor = true;
            btnNiaveApiClient.Click += btnNiaveApiClient_Click;
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(135, 54);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(100, 23);
            txtBookId.TabIndex = 2;
            // 
            // rdoGetBookById
            // 
            rdoGetBookById.AutoSize = true;
            rdoGetBookById.Location = new Point(17, 54);
            rdoGetBookById.Name = "rdoGetBookById";
            rdoGetBookById.Size = new Size(103, 19);
            rdoGetBookById.TabIndex = 1;
            rdoGetBookById.TabStop = true;
            rdoGetBookById.Text = "Get Book by ID";
            rdoGetBookById.UseVisualStyleBackColor = true;
            // 
            // rdoGetAllBooks
            // 
            rdoGetAllBooks.AutoSize = true;
            rdoGetAllBooks.Location = new Point(17, 29);
            rdoGetAllBooks.Name = "rdoGetAllBooks";
            rdoGetAllBooks.Size = new Size(95, 19);
            rdoGetAllBooks.TabIndex = 0;
            rdoGetAllBooks.TabStop = true;
            rdoGetAllBooks.Text = "Get All Books";
            rdoGetAllBooks.UseVisualStyleBackColor = true;
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Location = new Point(12, 164);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(45, 15);
            lblOutput.TabIndex = 1;
            lblOutput.Text = "Output";
            // 
            // txtOutput
            // 
            txtOutput.Dock = DockStyle.Bottom;
            txtOutput.Location = new Point(0, 192);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.ScrollBars = ScrollBars.Both;
            txtOutput.Size = new Size(868, 442);
            txtOutput.TabIndex = 2;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 634);
            Controls.Add(txtOutput);
            Controls.Add(lblOutput);
            Controls.Add(gbQueryOptions);
            Name = "FrmMain";
            Text = "Books Client";
            gbQueryOptions.ResumeLayout(false);
            gbQueryOptions.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbQueryOptions;
        private TextBox txtBookId;
        private RadioButton rdoGetBookById;
        private RadioButton rdoGetAllBooks;
        private Button btnOneOfApiClient;
        private Button btnArdalisResultClient;
        private Button btnNiaveApiClient;
        private Label lblOutput;
        private TextBox txtOutput;
    }
}
