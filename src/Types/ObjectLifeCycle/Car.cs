namespace Types.ObjectLifeCycle
{
    public class Car
    {
        public int CurrentSpeed { get; private set; }

        public string Brand { get; private set; }

        public Car(string brand, int currentSpeed)
        {
            CurrentSpeed = currentSpeed;
            Brand = brand;
        }

        public override string ToString()
        {
            return $"{Brand} is going {CurrentSpeed} KM/h";
        }
    }
}