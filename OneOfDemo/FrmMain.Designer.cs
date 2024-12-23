namespace OneOfDemo
{
    partial class Form1
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
            gbCalculateDueDate = new GroupBox();
            lblResult = new Label();
            btnCalculate = new Button();
            dpSpecificDate = new DateTimePicker();
            rdoSpecificDate = new RadioButton();
            txtNumberOfDays = new TextBox();
            rdoNumberOfDaysFromToday = new RadioButton();
            rdoLastDayOfNextMonth = new RadioButton();
            rdoFirstDayOfNextMonth = new RadioButton();
            rdo90Days = new RadioButton();
            gbCalculateDueDate.SuspendLayout();
            SuspendLayout();
            // 
            // gbCalculateDueDate
            // 
            gbCalculateDueDate.Controls.Add(lblResult);
            gbCalculateDueDate.Controls.Add(btnCalculate);
            gbCalculateDueDate.Controls.Add(dpSpecificDate);
            gbCalculateDueDate.Controls.Add(rdoSpecificDate);
            gbCalculateDueDate.Controls.Add(txtNumberOfDays);
            gbCalculateDueDate.Controls.Add(rdoNumberOfDaysFromToday);
            gbCalculateDueDate.Controls.Add(rdoLastDayOfNextMonth);
            gbCalculateDueDate.Controls.Add(rdoFirstDayOfNextMonth);
            gbCalculateDueDate.Controls.Add(rdo90Days);
            gbCalculateDueDate.Location = new Point(14, 12);
            gbCalculateDueDate.Name = "gbCalculateDueDate";
            gbCalculateDueDate.Size = new Size(647, 363);
            gbCalculateDueDate.TabIndex = 1;
            gbCalculateDueDate.TabStop = false;
            gbCalculateDueDate.Text = "Calculate Due Date";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(23, 219);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(61, 15);
            lblResult.TabIndex = 8;
            lblResult.Text = "Due Date: ";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(19, 177);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 7;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // dpSpecificDate
            // 
            dpSpecificDate.Location = new Point(116, 133);
            dpSpecificDate.Name = "dpSpecificDate";
            dpSpecificDate.Size = new Size(200, 23);
            dpSpecificDate.TabIndex = 6;
            // 
            // rdoSpecificDate
            // 
            rdoSpecificDate.AutoSize = true;
            rdoSpecificDate.Location = new Point(16, 134);
            rdoSpecificDate.Name = "rdoSpecificDate";
            rdoSpecificDate.Size = new Size(93, 19);
            rdoSpecificDate.TabIndex = 5;
            rdoSpecificDate.TabStop = true;
            rdoSpecificDate.Text = "Specific Date";
            rdoSpecificDate.UseVisualStyleBackColor = true;
            // 
            // txtNumberOfDays
            // 
            txtNumberOfDays.Location = new Point(193, 104);
            txtNumberOfDays.Name = "txtNumberOfDays";
            txtNumberOfDays.Size = new Size(43, 23);
            txtNumberOfDays.TabIndex = 4;
            txtNumberOfDays.Text = "30";
            // 
            // rdoNumberOfDaysFromToday
            // 
            rdoNumberOfDaysFromToday.AutoSize = true;
            rdoNumberOfDaysFromToday.Location = new Point(16, 105);
            rdoNumberOfDaysFromToday.Name = "rdoNumberOfDaysFromToday";
            rdoNumberOfDaysFromToday.Size = new Size(176, 19);
            rdoNumberOfDaysFromToday.TabIndex = 3;
            rdoNumberOfDaysFromToday.TabStop = true;
            rdoNumberOfDaysFromToday.Text = "Number of Days From Today";
            rdoNumberOfDaysFromToday.UseVisualStyleBackColor = true;
            // 
            // rdoLastDayOfNextMonth
            // 
            rdoLastDayOfNextMonth.AutoSize = true;
            rdoLastDayOfNextMonth.Location = new Point(16, 77);
            rdoLastDayOfNextMonth.Name = "rdoLastDayOfNextMonth";
            rdoLastDayOfNextMonth.Size = new Size(150, 19);
            rdoLastDayOfNextMonth.TabIndex = 2;
            rdoLastDayOfNextMonth.TabStop = true;
            rdoLastDayOfNextMonth.Text = "Last Day of Next Month";
            rdoLastDayOfNextMonth.UseVisualStyleBackColor = true;
            // 
            // rdoFirstDayOfNextMonth
            // 
            rdoFirstDayOfNextMonth.AutoSize = true;
            rdoFirstDayOfNextMonth.Location = new Point(16, 49);
            rdoFirstDayOfNextMonth.Name = "rdoFirstDayOfNextMonth";
            rdoFirstDayOfNextMonth.Size = new Size(156, 19);
            rdoFirstDayOfNextMonth.TabIndex = 1;
            rdoFirstDayOfNextMonth.TabStop = true;
            rdoFirstDayOfNextMonth.Text = "First Day of Next Month\\";
            rdoFirstDayOfNextMonth.UseVisualStyleBackColor = true;
            // 
            // rdo90Days
            // 
            rdo90Days.AutoSize = true;
            rdo90Days.Location = new Point(16, 24);
            rdo90Days.Name = "rdo90Days";
            rdo90Days.Size = new Size(130, 19);
            rdo90Days.TabIndex = 0;
            rdo90Days.TabStop = true;
            rdo90Days.Text = "90 Days From Today";
            rdo90Days.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbCalculateDueDate);
            Name = "Form1";
            Text = "OnOfDemo";
            gbCalculateDueDate.ResumeLayout(false);
            gbCalculateDueDate.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbCalculateDueDate;
        private RadioButton rdoFirstDayOfNextMonth;
        private RadioButton rdo90Days;
        private Label lblResult;
        private Button btnCalculate;
        private DateTimePicker dpSpecificDate;
        private RadioButton rdoSpecificDate;
        private TextBox txtNumberOfDays;
        private RadioButton rdoNumberOfDaysFromToday;
        private RadioButton rdoLastDayOfNextMonth;
    }
}
