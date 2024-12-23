namespace OneOfDemo;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {
        DateOnly? date = null;

        if (this.rdo90Days.Checked)
        {
            date = DueDateCalculator.GetDueDate(DueOn.NinetyDaysFromToday);
        }
        else if (this.rdoFirstDayOfNextMonth.Checked)
        {
            date = DueDateCalculator.GetDueDate(DueOn.FirstDayOfNextMonth);
        }
        else if (this.rdoLastDayOfNextMonth.Checked)
        {
            date = DueDateCalculator.GetDueDate(DueOn.LastDayOfNextMonth);
        }
        else if (this.rdoNumberOfDaysFromToday.Checked)
        {
            if (Int32.TryParse(this.txtNumberOfDays.Text.Trim(), out var days)
                date = DueDateCalculator.GetDueDate(days);
            else
                this.lblResult.Text = "Please enter number of days";
        }
        else if (this.rdoSpecificDate.Checked)
        {
            date = DueDateCalculator.GetDueDate(this.dpSpecificDate.Value);
        }

        if (date.HasValue)
            this.lblResult.Text = $"Due Date: {date:dd MMM yyyyy}";
    }
}