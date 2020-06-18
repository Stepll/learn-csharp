using System;

namespace RocketProgramm
{
    static class Data
    {
        public static Command[] CommandList = {
            new qCommand(),
            new NewRocketCommand(),
            new RocketListCommand(),
            new LaunchCommand(),
            new RocketInfoCommand(),
            new RocketListInOrbitCommand(),
            new LandingCommand(),
            new RefillCommand(),
            new GetFuelCommand(),
            new ChangeOrbitCommand()
        };

        public static Rocket[] RocketList = {
            new Rocket("Main"),
            new Rocket("Second")
        };

        public static Rocket[] RocketListInOrbit = {

        };

        public static RocketBody[] BodyList = {
            new BodyKyev(),
            new BodyKyev2(),
            new BodyF1()
        };

        public static RocketEngine[] EngineList = {
            new EngineHF450(),
            new EngineHF600(),
            new EnginePRP4(),
            new EngineRRP4()
        };

        public static RocketHeader[] HeaderList = {
            new HeaderA100(),
            new HeaderA150(),
            new HeaderA190(),
            new HeaderG1()
        };

        public static void DeleteRocket(Rocket rocket)
        {
            for (int i = 0; i < RocketList.Length; i++)
            {
                if (RocketList[i] == rocket) RocketList[i] = null;
            }
        }

        public static void AddRocket(Rocket rocket)
        {
            bool flag = true;
            int RocketIndex = 0;
            for (int i = 0; i < RocketList.Length; i++)
            {
                if (RocketList[i] == null && flag) 
                {
                    RocketIndex = i;
                    flag = false;
                } 
            }
            if (flag)
            {
                Array.Resize(ref RocketList, RocketList.Length + 1);
                RocketIndex = RocketList.Length - 1;
            }
            RocketList[RocketIndex] = rocket;
        }

        public static void DeleteRocketInOrbit(Rocket rocket)
        {
            for (int i = 0; i < RocketListInOrbit.Length; i++)
            {
                if (RocketListInOrbit[i] == rocket) RocketListInOrbit[i] = null;
            }
        }

        public static void AddRocketInOrbit(Rocket rocket)
        {
            bool flag = true;
            int RocketIndex = 0;
            for (int i = 0; i < RocketListInOrbit.Length; i++)
            {
                if (RocketListInOrbit[i] == null && flag) 
                {
                    RocketIndex = i;
                    flag = false;
                } 
            }
            if (flag)
            {
                Array.Resize(ref RocketListInOrbit, RocketListInOrbit.Length + 1);
                RocketIndex = RocketListInOrbit.Length - 1;
            }
            RocketListInOrbit[RocketIndex] = rocket;
        }
    }
}