using OneOf;

namespace OneOfDemo;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {
        OneOf<DateOnly, string> result = null;

        if (this.rdo90Days.Checked)
        {
            result = DueDateCalculator.GetDueDate(DueOn.NinetyDaysFromToday);
        }
        else if (this.rdoFirstDayOfNextMonth.Checked)
        {
            result = DueDateCalculator.GetDueDate(DueOn.FirstDayOfNextMonth);
        }
        else if (this.rdoLastDayOfNextMonth.Checked)
        {
            result = DueDateCalculator.GetDueDate(DueOn.LastDayOfNextMonth);
        }
        else if (this.rdoNumberOfDaysFromToday.Checked)
        {
            if (Int32.TryParse(this.txtNumberOfDays.Text.Trim(), out var days))
                result = DueDateCalculator.GetDueDate(days);
            else
                this.lblResult.Text = "Please enter number of days";
        }
        else if (this.rdoSpecificDate.Checked)
        {
            result = DueDateCalculator.GetDueDate(this.dpSpecificDate.Value);
        }

       this.lblResult.Text = result.Match(
            date => $"Due Date: {date:dd MMM yyyyy}",
            message => message 
        );
    }
}