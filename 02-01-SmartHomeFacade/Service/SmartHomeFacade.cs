namespace _02_01_SmartHomeFacade.Service
{
    public class SmartHomeFacade
    {
        private Light _light;
        private SecuritySystem _securitySystem;
        private AirConditioner _airConditioner;

        public SmartHomeFacade(Light light, SecuritySystem securitySystem, AirConditioner airConditioner)
        {
            _light = light;
            _securitySystem = securitySystem;
            _airConditioner = airConditioner;
        }

        public void MorningRoutine()
        {
            _light.On();
            _airConditioner.SetTemperature(22);
            _securitySystem.Disarm();
            Console.WriteLine("Good morning! Your home is ready.");
        }

        public void NightRoutine()
        {
            _light.Off();
            _airConditioner.SetTemperature(18);
            _securitySystem.Arm();
            Console.WriteLine("Good night! Your home is secured.");
        }
    }
}
