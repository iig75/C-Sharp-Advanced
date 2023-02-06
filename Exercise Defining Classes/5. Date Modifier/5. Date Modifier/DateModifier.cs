namespace DateAndTime
{
    public class DateModifier
    {

        public DateModifier(DateTime date1, DateTime date2)
        {
            Date1 = date1;
            Date2 = date2;
        }

        public DateTime Date1 { get; set; }
        public DateTime Date2 { get; set; }

        public int CalculateDays()
        {
            return Math.Abs((this.Date1.Date - this.Date2.Date).Days);
        }
    }
}
