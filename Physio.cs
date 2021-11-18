public class Physio : Staff
{
    private string speciality;
    public string Speciality { get => speciality; set => speciality = value; }

    public Physio(string name, int wage, string dob, string email, string speciality) : base(name, wage, dob, email)
    {
        this.speciality = speciality;
    }
    public new string DisplayInfo()
    {
        string info = "\nPhysio Information Display:\n" + "Name: " + Name + "\nWage: £" + Wage + "\nDob: " + Dob + "\nEmail: " + Email + "\nSpeciality: " + speciality;
        return info;
    }

}
