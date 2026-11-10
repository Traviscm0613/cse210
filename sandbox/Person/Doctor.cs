class Doctor : Person
{
    private string _tools;
    public Doctor(string firstName, string lastName, int age, double weight, string tools)
    : base(firstName, lastName, age, weight)
    {
        _tools = tools;
    }

    // overide is after virtual for polymorphism
    public override string GetPersonInformation()
    {
        return $"Tools: {_tools}: {base.GetPersonInformation()}";
    }
}