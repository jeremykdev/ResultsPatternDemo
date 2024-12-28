using OneOf;
using System.Reflection.Metadata.Ecma335;

namespace OneOfDemo;

public static class DueDateCalculator
{
    private static DateOnly GetFirstDayOfMonth(DateTime dt)
    {
        int month = dt.Month;
        int year = dt.Year;

        return new DateOnly(year, month, 1);
    }

    private static DateOnly GetLastDayOfMonth(DateTime dt)
    {
        int month = dt.Month;
        int year = dt.Year;

        return new DateOnly(year, month, 1).AddMonths(1).AddDays(-1);
    }

     
    public static OneOf<DateOnly, string> GetDueDate(OneOf<DateTime, int, DueOn> input)
    {
        DateOnly? date = null;
        string? message = null;
        
        input.Switch(
             dateTime => date = DateOnly.FromDateTime(dateTime),
             i => {
                 if (i < 1)
                     message = "Must provide a postive number of days";
                 else
                     date = DateOnly.FromDateTime(DateTime.Today.AddDays(i));
                 },
             dueOn =>
             {
                 switch (dueOn)
                 {
                     case DueOn.NinetyDaysFromToday:
                         date = DateOnly.FromDateTime(DateTime.Today.AddDays(90));
                         break;
                     case DueOn.FirstDayOfNextMonth:
                         date = GetFirstDayOfMonth(DateTime.Today.AddMonths(1));
                         break;
                     case DueOn.LastDayOfNextMonth:
                     default:
                         date = GetLastDayOfMonth(DateTime.Today.AddMonths(1));
                         break;
                 }
             }
         );

        if (message is not null)
            return message;

        if (date.HasValue)
        {
            if (date.Value < DateOnly.FromDateTime(DateTime.Today.AddDays(1)))
                return "Date must be in the future";
            else
                return date.Value;
        }

        return "Unable to calculate";
    }
}
