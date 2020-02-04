namespace ezCPU
{
    public class Date
    {
        //This will take the 8 character string returned and convert it accordingly
        public string CustomDateTime(string s)
        {
            string year = s.Substring(0, 4);
            string yearRemoved = s.Remove(0, 4);

            string month = yearRemoved.Substring(0, 2);
            string monthRemoved = s.Remove(0, 6);

            string day = monthRemoved;

            return month + "-" + day + "-" + year;
        }
    }
}
