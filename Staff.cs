using System;

public class Staff
{
    private string name;
    private int wage;
    private string dob;
    private string email;

    public string Name { get => name; set => name = value; }
    public int Wage { get => wage; set => wage = value; }
    public string Dob { get => dob; set => dob = value; }
    public string Email { get => email; set => email = value; }

    public Staff(string name, int wage, string dob, string email)
    {
        this.name = name;
        this.wage = wage;
        this.dob = dob;
        this.email = email;
    }

    public string DisplayInfo()
    {
        string info = "\nStaff Information Display:\n"+"Name: " + Name + "\nWage: £" + Wage + "\nDob: " + Dob + "\nEmail: " + Email;
        return info;
    }


}
