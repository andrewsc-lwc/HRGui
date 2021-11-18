public class Player : Staff
{
    private string position;
    private int goals;
    private int value;
    public string Position { get => position; set => position = value; }
    public int Goals { get => goals; set => goals = value; }
    public int Value { get => value; set => this.value = value; }

    public Player(string name, int wage, string dob, string email, string position, int goals, int value) : base(name,wage,dob,email)
    {
        this.position = position;
        this.goals = goals;
        this.value = value;
    }
    public new string DisplayInfo()
    {
        string info = "\nPlayer Information Display:\n" + "Name: " + Name + "\nWage: £" + Wage + "\nDob: " + Dob + "\nEmail: " + Email + "\nPosition: " + Position + "\nGoals: " + Goals + "\nValue: £" + Value;
        return info;
    }

}
