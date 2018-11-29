namespace InheritanceExample
{
    class CEO : Employee
    {
        public double Bonus;

        public CEO(string name, double bonus) : base(name)
        {
            Bonus = bonus;
        }
    }
}
