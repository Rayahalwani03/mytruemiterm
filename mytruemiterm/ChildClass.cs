namespace mytruemiterm
{
    internal class ChildClass
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string DOB_Day { get; set; }
        public string DOB_Month { get; set; }
        public string DOB_Year { get; set; }
        public string Gender { get; set; }

        public ChildClass(string name,
                          string lastName,
                          string dobDay,
                          string dobMonth,
                          string dobYear,
                          string gender)
        {
            Name = name;
            LastName = lastName;
            DOB_Day = dobDay;
            DOB_Month = dobMonth;
            DOB_Year = dobYear;
            Gender = gender;
        }
    }
}
