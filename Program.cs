abstract class Doctor
{
    public abstract void Heal();
}

class Surgeon : Doctor
{
    public override void Heal()
    {
        Console.WriteLine("Хирург лечит пациента");
    }
}

class Therapist : Doctor
{
    public override void Heal()
    {
        Console.WriteLine("Терапевт лечит пациента");
    }
}

class Dentist : Doctor
{
    public override void Heal()
    {
        Console.WriteLine("Дантист лечит пациента");
    }
}

class Patient
{
    public string Name { get; set; }
    public int Age { get; set; }
    public TreatmentPlan TreatmentPlan { get; }

    public Patient(string name, int age, TreatmentPlan treatmentPlan)
    {
        Name = name;
        Age = age;
        TreatmentPlan = treatmentPlan;
    }

    public void GetTreatment()
    {
        Doctor doctor;
        if (TreatmentPlan.Code == 1)
        {
            doctor = new Surgeon();
        }
        else if (TreatmentPlan.Code == 2)
        {
            doctor = new Dentist();
        }
        else
        {
            doctor = new Therapist();
        }

        Console.WriteLine($"Пациент {Name}, Возраст: {Age}");
        doctor.Heal();
    }
}

class TreatmentPlan
{
    public int Code { get; }

    public TreatmentPlan(int code)
    {
        Code = code;
    }
}

class Program
{
    static void Main(string[] args)
    {
        TreatmentPlan plan = new TreatmentPlan(2);
        Patient patient = new Patient("Иванов", 30, plan);

       patient.GetTreatment();

        Console.ReadLine();
    }
}