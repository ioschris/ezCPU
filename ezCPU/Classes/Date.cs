namespace ezCPU
{
    public class Date
    {
        //This will take the 8 character string returned and convert it accordingly (Dean Edit)
        public string CustomDateTime(string s)
        {
            string year = s.Substring(0, 4);
            string month = s.Substring(4, 2);
            string day = s.Substring(6, 2);

            return month + "-" + day + "-" + year;
        }
    }
}
