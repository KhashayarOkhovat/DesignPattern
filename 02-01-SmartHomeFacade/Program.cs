using _02_01_SmartHomeFacade.Service;

Light light = new Light();
SecuritySystem securitySystem = new SecuritySystem();
AirConditioner airConditioner = new AirConditioner();

SmartHomeFacade smartHome = new SmartHomeFacade(light, securitySystem, airConditioner);

smartHome.MorningRoutine();
smartHome.NightRoutine();