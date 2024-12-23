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


    public static DateOnly GetDueDate(OneOf<DateTime, int, DueOn> input)
    {
        return input.Match<DateOnly>(
            dateTime => DateOnly.FromDateTime(dateTime),
            i => DateOnly.FromDateTime(DateTime.Today.AddDays(i)),
            dueOn =>
            {
                switch (dueOn)
                {
                    case DueOn.NinetyDaysFromToday:
                        return DateOnly.FromDateTime(DateTime.Today.AddDays(90));
                        break;
                    case DueOn.FirstDayOfNextMonth:
                        return GetFirstDayOfMonth(DateTime.Today.AddMonths(1));
                        break;
                    case DueOn.LastDayOfNextMonth:
                    default:
                        return GetLastDayOfMonth(DateTime.Today.AddMonths(1));
                        break;
                }
            }
        );
    }
}
