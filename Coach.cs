public class Coach : Staff
{
    private string position;
    public string Position { get => position; set => position = value; }


    public Coach(string name, int wage, string dob, string email, string position) : base(name, wage, dob, email)
    {
        this.position = position;

    }
    public new string DisplayInfo()
    {
        string info = "\nCoach Information Display:\n" + "Name: " + Name + "\nWage: £" + Wage + "\nDob: " + Dob + "\nEmail: " + Email + "\nPosition: " + Position + " coach";
        return info;
    }

}
