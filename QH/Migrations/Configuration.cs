namespace QH.Migrations
{
    using System.Data.Entity.Migrations;
    using QH.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<QH.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(QH.Models.ApplicationDbContext context)
        {
            // add motors 
            Motor motor = new Motor()
            {
                Name = "G2306-2200KV Racing Edition Brushless Motor (CW)",
                Url = "http://www.hobbyking.com/hobbyking/store/__107879__G2306_2200KV_Racing_Edition_Brushless_Motor_CW_.html",
                Price = 13.00,
                Kv = 2200,
                Weight = 32,
                MaxCurrent = 33,
                MaxVoltage = 15,
                Shaft = 5,
                Length = 21,
                Diameter = 28,
                CanLength = 8,
                TotalLength = 35
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "4010-485KV Turnigy Multistar 22 Pole Brushless Multi-Rotor Motor With Extra Long Leads",
                Url = "http://www.hobbyking.com/hobbyking/store/__41619__4010_485KV_Turnigy_Multistar_22_Pole_Brushless_Multi_Rotor_Motor_With_Extra_Long_Leads.html",
                Price = 41.16,
                Kv = 485,
                Weight = 128,
                MaxCurrent = 26,
                MaxVoltage = 0,
                Shaft = 4,
                Length = 28,
                Diameter = 45,
                CanLength = 13,
                TotalLength = 39
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Turnigy Multistar 3525-850Kv 14Pole Multi-Rotor Outrunner",
                Url = "http://www.hobbyking.com/hobbyking/store/__36767__Turnigy_Multistar_3525_850Kv_14Pole_Multi_Rotor_Outrunner.html",
                Price = 27.60,
                Kv = 850,
                Weight = 58,
                MaxCurrent = 23,
                MaxVoltage = 11,
                Shaft = 4,
                Length = 25,
                Diameter = 35,
                CanLength = 10,
                TotalLength = 36
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "T1104-4000KV Brushless Motor",
                Url = "http://www.hobbyking.com/hobbyking/store/__107825__T1104_4000KV_Brushless_Motor.html",
                Price = 8.45,
                Kv = 4000,
                Weight = 4.7,
                MaxCurrent = 3.5,
                MaxVoltage = 8,
                Shaft = 1.5,
                Length = 11,
                Diameter = 14,
                CanLength = 5,
                TotalLength = 15
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "ZTW Spider PRO Premium SP2206-2550KV Brushless Motor",
                Url = "http://www.hobbyking.com/hobbyking/store/__107747__ZTW_Spider_PRO_Premium_SP2206_2550KV_Brushless_Motor.html",
                Price = 21.99,
                Kv = 2550,
                Weight = 33,
                MaxCurrent = 0,
                MaxVoltage = 0,
                Shaft = 5,
                Length = 18,
                Diameter = 28,
                CanLength = 7,
                TotalLength = 33
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Turnigy Multistar 2213-980Kv 14 Pole Multi-Rotor Outrunner V2",
                Url = "http://www.hobbyking.com/hobbyking/store/__66416__Turnigy_Multistar_2213_980Kv_14_Pole_Multi_Rotor_Outrunner_V2.html",
                Price = 16.37,
                Kv = 980,
                Weight = 59,
                MaxCurrent = 15,
                MaxVoltage = 11,
                Shaft = 2,
                Length = 31,
                Diameter = 28,
                CanLength = 16,
                TotalLength = 34
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Quanum MT Series 2227 800KV Brushless Multirotor Motor Built by DYS",
                Url = "http://www.hobbyking.com/hobbyking/store/__67016__Quanum_MT_Series_2227_800KV_Brushless_Multirotor_Motor_Built_by_DYS.html",
                Price = 19.43,
                Kv = 800,
                Weight = 59,
                MaxCurrent = 15,
                MaxVoltage = 19,
                Length = 32,
                Diameter = 28,
                CanLength = 20,
                TotalLength = 37
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "LDPOWER MT2204-2300KV Brushless Multicopter Motor (CW)",
                Url = "http://www.hobbyking.com/hobbyking/store/__86642__LDPOWER_MT2204_2300KV_Brushless_Multicopter_Motor_CW_.html",
                Price = 11.26,
                Kv = 2300,
                Weight = 28,
                MaxCurrent = 18.1,
                MaxVoltage = 12,
                Shaft = 5,
                Length = 17,
                Diameter = 28,
                CanLength = 0,
                TotalLength = 27
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();
            context.ThrustDataPoints.AddOrUpdate(t => t.Id,
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 7.4,
                        PropDiameter = 6,
                        PropPitch = 3,
                        Current = 1.7,
                        Thrust = 80,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 7.4,
                        PropDiameter = 6,
                        PropPitch = 3,
                        Current = 2.6,
                        Thrust = 114,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 7.4,
                        PropDiameter = 6,
                        PropPitch = 3,
                        Current = 3.5,
                        Thrust = 155,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 7.4,
                        PropDiameter = 6,
                        PropPitch = 3,
                        Current = 6.3,
                        Thrust = 255,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 7.4,
                        PropDiameter = 6,
                        PropPitch = 4.5,
                        Current = 2.2,
                        Thrust = 94,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 7.4,
                        PropDiameter = 6,
                        PropPitch = 4.5,
                        Current = 3.5,
                        Thrust = 145,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 7.4,
                        PropDiameter = 6,
                        PropPitch = 4.5,
                        Current = 4.9,
                        Thrust = 192,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 7.4,
                        PropDiameter = 6,
                        PropPitch = 4.5,
                        Current = 10.1,
                        Thrust = 329,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 11.1,
                        PropDiameter = 6,
                        PropPitch = 3,
                        Current = 2.6,
                        Thrust = 151,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 11.1,
                        PropDiameter = 6,
                        PropPitch = 3,
                        Current = 4.1,
                        Thrust = 223,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 11.1,
                        PropDiameter = 6,
                        PropPitch = 3,
                        Current = 6,
                        Thrust = 294,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 11.1,
                        PropDiameter = 6,
                        PropPitch = 3,
                        Current = 11.6,
                        Thrust = 500,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 11.1,
                        PropDiameter = 6,
                        PropPitch = 4.5,
                        Current = 3.4,
                        Thrust = 178,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 11.1,
                        PropDiameter = 6,
                        PropPitch = 4.5,
                        Current = 5.5,
                        Thrust = 253,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 11.1,
                        PropDiameter = 6,
                        PropPitch = 4.5,
                        Current = 7.8,
                        Thrust = 334,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 11.1,
                        PropDiameter = 6,
                        PropPitch = 4.5,
                        Current = 16.6,
                        Thrust = 545,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 14.8,
                        PropDiameter = 5,
                        PropPitch = 3,
                        Current = 1.7,
                        Thrust = 104,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 14.8,
                        PropDiameter = 5,
                        PropPitch = 3,
                        Current = 3.4,
                        Thrust = 184,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 14.8,
                        PropDiameter = 5,
                        PropPitch = 3,
                        Current = 5.4,
                        Thrust = 257,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 14.8,
                        PropDiameter = 5,
                        PropPitch = 3,
                        Current = 12.2,
                        Thrust = 480,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 14.8,
                        PropDiameter = 6,
                        PropPitch = 3,
                        Current = 1.9,
                        Thrust = 133,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 14.8,
                        PropDiameter = 6,
                        PropPitch = 3,
                        Current = 4.8,
                        Thrust = 266,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 14.8,
                        PropDiameter = 6,
                        PropPitch = 3,
                        Current = 8,
                        Thrust = 390,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 14.8,
                        PropDiameter = 6,
                        PropPitch = 3,
                        Current = 18.2,
                        Thrust = 650,
                    }
                );



            motor = new Motor()
            {
                Name = "4112-400KV Turnigy Multistar 22 Pole Brushless Multi-Rotor Motor With Extra Long Leads",
                Url = "http://www.hobbyking.com/hobbyking/store/__41627__4112_400KV_Turnigy_Multistar_22_Pole_Brushless_Multi_Rotor_Motor_With_Extra_Long_Leads.html",
                Price = 39.76,
                Kv = 400,
                Weight = 147,
                MaxCurrent = 24,
                MaxVoltage = 0,
                Shaft = 5,
                Length = 30,
                Diameter = 47,
                CanLength = 15,
                TotalLength = 40
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Quanum MT Series 3508 700KV Brushless Multirotor Motor Built by DYS",
                Url = "http://www.hobbyking.com/hobbyking/store/__67020__Quanum_MT_Series_3508_700KV_Brushless_Multirotor_Motor_Built_by_DYS.html",
                Price = 29.16,
                Kv = 700,
                Weight = 76,
                MaxCurrent = 25,
                MaxVoltage = 22,
                Shaft = 4,
                Length = 26,
                Diameter = 42,
                CanLength = 11,
                TotalLength = 33
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Turnigy Multistar 5130-570Kv 16Pole Multi-Rotor Outrunner",
                Url = "http://www.hobbyking.com/hobbyking/store/__36776__Turnigy_Multistar_5130_570Kv_16Pole_Multi_Rotor_Outrunner.html",
                Price = 52.14,
                Kv = 570,
                Weight = 152,
                MaxCurrent = 27,
                MaxVoltage = 14,
                Shaft = 4,
                Length = 30,
                Diameter = 52,
                CanLength = 20,
                TotalLength = 35
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Quanum MT Series 4108 475KV Brushless Multirotor Motor Built by DYS",
                Url = "http://www.hobbyking.com/hobbyking/store/__67030__Quanum_MT_Series_4108_475KV_Brushless_Multirotor_Motor_Built_by_DYS.html",
                Price = 30.16,
                Kv = 475,
                Weight = 88,
                MaxCurrent = 22,
                MaxVoltage = 22,
                Shaft = 4,
                Length = 29,
                Diameter = 46,
                CanLength = 10,
                TotalLength = 34
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Quanum MT Series 4010 475KV Brushless Multirotor Motor Built by DYS",
                Url = "http://www.hobbyking.com/hobbyking/store/__67025__Quanum_MT_Series_4010_475KV_Brushless_Multirotor_Motor_Built_by_DYS.html",
                Price = 24.31,
                Kv = 475,
                Weight = 124,
                MaxCurrent = 26,
                MaxVoltage = 19,
                Shaft = 4,
                Length = 29,
                Diameter = 47,
                CanLength = 12,
                TotalLength = 36
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Quanum MT Series 1806 2300KV Brushless Multirotor Motor Built by DYS",
                Url = "http://www.hobbyking.com/hobbyking/store/__66404__Quanum_MT_Series_1806_2300KV_Brushless_Multirotor_Motor_Built_by_DYS.html",
                Price = 8.67,
                Kv = 2300,
                Weight = 19,
                MaxCurrent = 7.6,
                MaxVoltage = 12,
                Shaft = 2,
                Length = 15,
                Diameter = 24,
                CanLength = 6,
                TotalLength = 20
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "6135-330KV Turnigy Multistar Brushless Multi-Rotor Motors CW/CCW (2 pcs)",
                Url = "http://www.hobbyking.com/hobbyking/store/__45362__6135_330KV_Turnigy_Multistar_Brushless_Multi_Rotor_Motors_CW_CCW_2_pcs_.html",
                Price = 221.90,
                Kv = 330,
                Weight = 230,
                MaxCurrent = 39,
                MaxVoltage = 24,
                Shaft = 7.8,
                Length = 36,
                Diameter = 61,
                CanLength = 25,
                TotalLength = 36
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Turnigy Multistar 4822-490Kv 22Pole Multi-Rotor Outrunner",
                Url = "http://www.hobbyking.com/hobbyking/store/__26958__Turnigy_Multistar_4822_490Kv_22Pole_Multi_Rotor_Outrunner.html",
                Price = 31.99,
                Kv = 490,
                Weight = 98,
                MaxCurrent = 17,
                MaxVoltage = 22,
                Length = 25,
                Diameter = 48,
                CanLength = 10,
                TotalLength = 34
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "QAV2206-1900KV Brushless Motor (CW)",
                Url = "http://www.hobbyking.com/hobbyking/store/__107867__QAV2206_1900KV_Brushless_Motor_CW_.html",
                Price = 9.75,
                Kv = 1900,
                Weight = 29,
                MaxCurrent = 18,
                MaxVoltage = 15,
                Length = 20,
                Diameter = 28,
                CanLength = 8,
                TotalLength = 30
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "LDPower Brushless Outrunner 35x34mm (2814-1100KV)",
                Url = "http://www.hobbyking.com/hobbyking/store/__88478__LDPower_Brushless_Outrunner_35x34mm_2814_1100KV_.html",
                Price = 19.36,
                Kv = 1100,
                Weight = 102,
                MaxCurrent = 54,
                MaxVoltage = 0,
                Shaft = 4,
                Length = 34,
                Diameter = 35,
                CanLength = 0,
                TotalLength = 40
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "4014-320KV Turnigy Multistar 22 Pole Brushless Multi-Rotor Motor With Extra Long Leads",
                Url = "http://www.hobbyking.com/hobbyking/store/__41621__4014_320KV_Turnigy_Multistar_22_Pole_Brushless_Multi_Rotor_Motor_With_Extra_Long_Leads.html",
                Price = 48.16,
                Kv = 320,
                Weight = 163,
                MaxCurrent = 26,
                MaxVoltage = 0,
                Shaft = 5,
                Length = 32,
                Diameter = 45,
                CanLength = 16,
                TotalLength = 42
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Turnigy Multistar 2209-980Kv 14Pole Multi-Rotor Outrunner V2",
                Url = "http://www.hobbyking.com/hobbyking/store/__66415__Turnigy_Multistar_2209_980Kv_14Pole_Multi_Rotor_Outrunner_V2.html",
                Price = 14.36,
                Kv = 980,
                Weight = 48,
                MaxCurrent = 9,
                MaxVoltage = 11,
                Length = 27,
                Diameter = 28,
                CanLength = 12,
                TotalLength = 31
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Multistar Elite 5010-274KV Multi-Rotor Motor",
                Url = "http://www.hobbyking.com/hobbyking/store/__74762__Multistar_Elite_5010_274KV_Multi_Rotor_Motor.html",
                Price = 55.02,
                Kv = 274,
                Weight = 211,
                MaxCurrent = 28,
                MaxVoltage = 22,
                Shaft = 4,
                Length = 30,
                Diameter = 58,
                CanLength = 13,
                TotalLength = 37
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Quanum MT Series 2814 880KV Brushless Multirotor Motor Built by DYS",
                Url = "http://www.hobbyking.com/hobbyking/store/__67017__Quanum_MT_Series_2814_880KV_Brushless_Multirotor_Motor_Built_by_DYS.html",
                Price = 29.03,
                Kv = 880,
                Weight = 78,
                MaxCurrent = 24,
                MaxVoltage = 19,
                Shaft = 4,
                Length = 32,
                Diameter = 35,
                CanLength = 17,
                TotalLength = 37
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "6340-230KV Turnigy Multistar Brushless Multi-Rotor Motors Set (2 pcs)",
                Url = "http://www.hobbyking.com/hobbyking/store/__54883__6340_230KV_Turnigy_Multistar_Brushless_Multi_Rotor_Motors_Set_2_pcs_.html",
                Price = 245.84,
                Kv = 230,
                Weight = 322,
                MaxCurrent = 50,
                MaxVoltage = 24,
                Shaft = 8,
                Length = 40,
                Diameter = 63,
                CanLength = 17,
                TotalLength = 40
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "3508-700KV Turnigy Multistar 14 Pole Brushless Multi-Rotor Motor With Extra Long Leads",
                Url = "http://www.hobbyking.com/hobbyking/store/__41617__3508_700KV_Turnigy_Multistar_14_Pole_Brushless_Multi_Rotor_Motor_With_Extra_Long_Leads.html",
                Price = 31.86,
                Kv = 700,
                Weight = 102,
                MaxCurrent = 28,
                MaxVoltage = 0,
                Shaft = 4,
                Length = 26,
                Diameter = 42,
                CanLength = 10,
                TotalLength = 36
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Quanum MT Series 4108 700KV Brushless Multirotor Motor Built by DYS",
                Url = "http://www.hobbyking.com/hobbyking/store/__67033__Quanum_MT_Series_4108_700KV_Brushless_Multirotor_Motor_Built_by_DYS.html",
                Price = 34.76,
                Kv = 700,
                Weight = 88,
                MaxCurrent = 30,
                MaxVoltage = 22,
                Shaft = 4,
                Length = 27,
                Diameter = 46,
                CanLength = 10,
                TotalLength = 34
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Quanum MT Series 4108 370KV Brushless Multirotor Motor Built by DYS",
                Url = "http://www.hobbyking.com/hobbyking/store/__67031__Quanum_MT_Series_4108_370KV_Brushless_Multirotor_Motor_Built_by_DYS.html",
                Price = 32.48,
                Kv = 370,
                Weight = 91,
                MaxCurrent = 16,
                MaxVoltage = 22,
                Shaft = 4,
                Length = 27,
                Diameter = 46,
                CanLength = 10,
                TotalLength = 33
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Quanum MT Series 3510 360KV Brushless Multirotor Motor Built by DYS",
                Url = "http://www.hobbyking.com/hobbyking/store/__67021__Quanum_MT_Series_3510_360KV_Brushless_Multirotor_Motor_Built_by_DYS.html",
                Price = 24.65,
                Kv = 360,
                Weight = 80,
                MaxCurrent = 26,
                MaxVoltage = 22,
                Shaft = 4,
                Length = 28,
                Diameter = 42,
                CanLength = 13,
                TotalLength = 35
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Turnigy Multistar 2213-980Kv 14Pole Multi-Rotor Outrunner",
                Url = "http://www.hobbyking.com/hobbyking/store/__39036__Turnigy_Multistar_2213_980Kv_14Pole_Multi_Rotor_Outrunner.html",
                Price = 15.95,
                Kv = 980,
                Weight = 58,
                MaxCurrent = 15,
                MaxVoltage = 11,
                Shaft = 0,
                Length = 31,
                Diameter = 28,
                CanLength = 16,
                TotalLength = 31
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "QAV1306-3100KV Brushless Motor (CW)",
                Url = "http://www.hobbyking.com/hobbyking/store/__107831__QAV1306_3100KV_Brushless_Motor_CW_.html",
                Price = 7.80,
                Kv = 3100,
                Weight = 12,
                MaxCurrent = 10,
                MaxVoltage = 15,
                Shaft = 5,
                Length = 15,
                Diameter = 18,
                CanLength = 7,
                TotalLength = 26
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "KINGKONG 2204-2300KV Multi Copter Motor CW",
                Url = "http://www.hobbyking.com/hobbyking/store/__89473__KINGKONG_2204_2300KV_Multi_Copter_Motor_CW.html",
                Price = 8.16,
                Kv = 2300,
                Weight = 26,
                MaxCurrent = 0,
                MaxVoltage = 15,
                Shaft = 5,
                Length = 18,
                Diameter = 28,
                CanLength = 0,
                TotalLength = 31
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Turnigy 250 size 1806-2280kv (Set Of 4 CW/CCW)",
                Url = "http://www.hobbyking.com/hobbyking/store/__62751__Turnigy_250_size_1806_2280kv_Set_Of_4_CW_CCW_.html",
                Price = 39.99,
                Kv = 2280,
                Weight = 19,
                MaxCurrent = 10,
                MaxVoltage = 13,
                Shaft = 5,
                Length = 15,
                Diameter = 23,
                CanLength = 8,
                TotalLength = 25
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "DYS 1306-3100KV BX Series Set of Two CW/CCW Motors",
                Url = "http://www.hobbyking.com/hobbyking/store/__66403__DYS_1306_3100KV_BX_Series_Set_of_Two_CW_CCW_Motors.html",
                Price = 20.00,
                Kv = 3100,
                Weight = 13,
                MaxCurrent = 8,
                MaxVoltage = 12,
                Shaft = 5,
                Length = 15,
                Diameter = 18,
                CanLength = 6,
                TotalLength = 26
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Quanum BE1806-2300kv Race Edition Brushless Motor 3~4S (CCW)",
                Url = "http://www.hobbyking.com/hobbyking/store/__104744__Quanum_BE1806_2300kv_Race_Edition_Brushless_Motor_3_4S_CCW_.html",
                Price = 10.69,
                Kv = 2300,
                Weight = 21,
                MaxCurrent = 13.6,
                MaxVoltage = 15,
                Length = 18,
                Diameter = 23,
                CanLength = 8,
                TotalLength = 23
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Quanum MT Series 3110 470KV Brushless Multirotor Motor Built by DYS",
                Url = "http://www.hobbyking.com/hobbyking/store/__67018__Quanum_MT_Series_3110_470KV_Brushless_Multirotor_Motor_Built_by_DYS.html",
                Price = 19.87,
                Kv = 470,
                Weight = 81,
                MaxCurrent = 17,
                MaxVoltage = 22,
                Shaft = 4,
                Length = 28,
                Diameter = 38,
                CanLength = 13,
                TotalLength = 35
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Emax PM1806-2300Kv Brushless Multi-Rotor Motor Set (1xCW 1xCCW)",
                Url = "http://www.hobbyking.com/hobbyking/store/__69296__Emax_PM1806_2300Kv_Brushless_Multi_Rotor_Motor_Set_1xCW_1xCCW_.html",
                Price = 14.98,
                Kv = 2300,
                Weight = 19,
                MaxCurrent = 8,
                MaxVoltage = 11,
                Shaft = 5,
                Length = 15,
                Diameter = 25,
                CanLength = 10,
                TotalLength = 0
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Multistar Elite 2204-2300KV Multi-Rotor Motor 3-4S (CCW Prop Adapter)",
                Url = "http://www.hobbyking.com/hobbyking/store/__63064__Multistar_Elite_2204_2300KV_Multi_Rotor_Motor_3_4S_CCW_Prop_Adapter_.html",
                Price = 13.49,
                Kv = 2300,
                Weight = 24,
                MaxCurrent = 20,
                MaxVoltage = 15,
                Length = 16,
                Diameter = 28,
                CanLength = 6,
                TotalLength = 22
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();
            context.ThrustDataPoints.AddOrUpdate(t => t.Id,
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 11.1,
                        PropDiameter = 5,
                        PropPitch = 3,
                        Thrust = 224,
                        Current = 3.7,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 11.1,
                        PropDiameter = 5,
                        PropPitch = 3,
                        Thrust = 371,
                        Current = 7.5,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 7.4,
                        PropDiameter = 5,
                        PropPitch = 2,
                        Thrust = 120,
                        Current = 2.2,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 7.4,
                        PropDiameter = 5,
                        PropPitch = 2,
                        Thrust = 200,
                        Current = 4.3,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 11.1,
                        PropDiameter = 5,
                        PropPitch = 3,
                        Thrust = 232,
                        Current = 4.7,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 11.1,
                        PropDiameter = 5,
                        PropPitch = 3,
                        Thrust = 392,
                        Current = 9.9,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 7.4,
                        PropDiameter = 5,
                        PropPitch = 3,
                        Thrust = 134,
                        Current = 2.7,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 7.4,
                        PropDiameter = 5,
                        PropPitch = 3,
                        Thrust = 211,
                        Current = 6.7,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 11.1,
                        PropDiameter = 6,
                        PropPitch = 4,
                        Thrust = 385,
                        Current = 7.5,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 11.1,
                        PropDiameter = 6,
                        PropPitch = 4,
                        Thrust = 591,
                        Current = 9.9,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 7.4,
                        PropDiameter = 6,
                        PropPitch = 4,
                        Thrust = 134,
                        Current = 4.8,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 7.4,
                        PropDiameter = 6,
                        PropPitch = 4,
                        Thrust = 211,
                        Current = 9.7,
                    }
                );



            motor = new Motor()
            {
                Name = "Turnigy Multistar 3525-650Kv 14Pole Multi-Rotor Outrunner",
                Url = "http://www.hobbyking.com/hobbyking/store/__36765__Turnigy_Multistar_3525_650Kv_14Pole_Multi_Rotor_Outrunner.html",
                Price = 25.65,
                Kv = 650,
                Weight = 58,
                MaxCurrent = 17,
                MaxVoltage = 15,
                Shaft = 4,
                Length = 25,
                Diameter = 35,
                CanLength = 10,
                TotalLength = 25
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "DYS Brushless Motor (8610) BE8108-16 100KV for Multi-Rotors & Gimbals",
                Url = "http://www.hobbyking.com/hobbyking/store/__61431__DYS_Brushless_Motor_8610_BE8108_16_100KV_for_Multi_Rotors_Gimbals.html",
                Price = 145.18,
                Kv = 100,
                Weight = 240,
                MaxCurrent = 8.6,
                MaxVoltage = 44,
                Shaft = 8,
                Length = 27,
                Diameter = 86,
                CanLength = 10,
                TotalLength = 27
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Multistar 350QX Blade Motor set 4pcs/Box 2209 1200KV",
                Url = "http://www.hobbyking.com/hobbyking/store/__54277__Multistar_350QX_Blade_Motor_set_4pcs_Box_2209_1200KV.html",
                Price = 61.74,
                Kv = 1200,
                Weight = 39,
                MaxCurrent = 20,
                MaxVoltage = 15,
                Shaft = 3.17,
                Length = 21,
                Diameter = 28,
                CanLength = 12,
                TotalLength = 31
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Quanum BE1806-2700kv Race Edition Brushless Motor 3~4S (CCW)",
                Url = "http://www.hobbyking.com/hobbyking/store/__104758__Quanum_BE1806_2700kv_Race_Edition_Brushless_Motor_3_4S_CCW_.html",
                Price = 11.89,
                Kv = 2700,
                Weight = 21,
                MaxCurrent = 18.2,
                MaxVoltage = 15,
                Length = 18,
                Diameter = 23,
                CanLength = 8,
                TotalLength = 23
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "LDPOWER MT2213-920KV Brushless Multicopter Motor (CCW)",
                Url = "http://www.hobbyking.com/hobbyking/store/__86647__LDPOWER_MT2213_920KV_Brushless_Multicopter_Motor_CCW_.html",
                Price = 16.99,
                Kv = 920,
                Weight = 55.3,
                MaxCurrent = 18,
                MaxVoltage = 14,
                Shaft = 6,
                Length = 27,
                Diameter = 28,
                CanLength = 14,
                TotalLength = 41
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();
            context.ThrustDataPoints.AddOrUpdate(t => t.Id,
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 7.4,
                        PropDiameter = 10,
                        PropPitch = 3.3,
                        Current = 0.7,
                        Thrust = 66,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 7.4,
                        PropDiameter = 10,
                        PropPitch = 3.3,
                        Current = 2.5,
                        Thrust = 165,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 7.4,
                        PropDiameter = 10,
                        PropPitch = 3.3,
                        Current = 6.7,
                        Thrust = 345,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 7.4,
                        PropDiameter = 10,
                        PropPitch = 3.3,
                        Current = 6.8,
                        Thrust = 342,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 7.4,
                        PropDiameter = 11,
                        PropPitch = 3.7,
                        Current = 0.8,
                        Thrust = 80,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 7.4,
                        PropDiameter = 11,
                        PropPitch = 3.7,
                        Current = 2.7,
                        Thrust = 202,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 7.4,
                        PropDiameter = 11,
                        PropPitch = 3.7,
                        Current = 7.4,
                        Thrust = 430,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 7.4,
                        PropDiameter = 11,
                        PropPitch = 3.7,
                        Current = 7.4,
                        Thrust = 430,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 7.4,
                        PropDiameter = 12,
                        PropPitch = 4,
                        Current = 0.6,
                        Thrust = 83,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 7.4,
                        PropDiameter = 12,
                        PropPitch = 4,
                        Current = 3.1,
                        Thrust = 226,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 7.4,
                        PropDiameter = 12,
                        PropPitch = 4,
                        Current = 8.9,
                        Thrust = 496,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 7.4,
                        PropDiameter = 12,
                        PropPitch = 4,
                        Current = 9,
                        Thrust = 500,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 11.1,
                        PropDiameter = 10,
                        PropPitch = 3.3,
                        Current = 1.2,
                        Thrust = 124,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 11.1,
                        PropDiameter = 10,
                        PropPitch = 3.3,
                        Current = 4.4,
                        Thrust = 322,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 11.1,
                        PropDiameter = 10,
                        PropPitch = 3.3,
                        Current = 12.1,
                        Thrust = 640,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 11.1,
                        PropDiameter = 10,
                        PropPitch = 3.3,
                        Current = 12.2,
                        Thrust = 6451,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 11.1,
                        PropDiameter = 11,
                        PropPitch = 3.7,
                        Current = 1.3,
                        Thrust = 152,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 11.1,
                        PropDiameter = 11,
                        PropPitch = 3.7,
                        Current = 4.8,
                        Thrust = 385,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 11.1,
                        PropDiameter = 11,
                        PropPitch = 3.7,
                        Current = 12.9,
                        Thrust = 772,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 11.1,
                        PropDiameter = 11,
                        PropPitch = 3.7,
                        Current = 12.9,
                        Thrust = 772,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 11.1,
                        PropDiameter = 12,
                        PropPitch = 4,
                        Current = 1.4,
                        Thrust = 151,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 11.1,
                        PropDiameter = 12,
                        PropPitch = 4,
                        Current = 5.7,
                        Thrust = 438,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 11.1,
                        PropDiameter = 12,
                        PropPitch = 4,
                        Current = 15.2,
                        Thrust = 855,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 11.1,
                        PropDiameter = 12,
                        PropPitch = 4,
                        Current = 15.2,
                        Thrust = 855,
                    }
                );



            motor = new Motor()
            {
                Name = "3508-580KV Turnigy Multistar 14 Pole Brushless Multi-Rotor Motor With Extra Long Leads",
                Url = "http://www.hobbyking.com/hobbyking/store/__41616__3508_580KV_Turnigy_Multistar_14_Pole_Brushless_Multi_Rotor_Motor_With_Extra_Long_Leads.html",
                Price = 31.86,
                Kv = 580,
                Weight = 102,
                MaxCurrent = 26,
                MaxVoltage = 0,
                Shaft = 4,
                Length = 26,
                Diameter = 42,
                CanLength = 10,
                TotalLength = 36
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Quanum MT Series 4114 340KV Brushless Multirotor Motor Built by DYS",
                Url = "http://www.hobbyking.com/hobbyking/store/__67034__Quanum_MT_Series_4114_340KV_Brushless_Multirotor_Motor_Built_by_DYS.html",
                Price = 34.76,
                Kv = 340,
                Weight = 141,
                MaxCurrent = 30,
                MaxVoltage = 22,
                Shaft = 4,
                Length = 32,
                Diameter = 46,
                CanLength = 16,
                TotalLength = 38
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "G2306-2200KV Racing Edition Brushless Motor (CCW)",
                Url = "http://www.hobbyking.com/hobbyking/store/__107885__G2306_2200KV_Racing_Edition_Brushless_Motor_CCW_.html",
                Price = 13.00,
                Kv = 2200,
                Weight = 32,
                MaxCurrent = 33,
                MaxVoltage = 15,
                Shaft = 5,
                Length = 21,
                Diameter = 28,
                CanLength = 8,
                TotalLength = 35
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "QAV2206-1900KV Brushless Motor (CCW)",
                Url = "http://www.hobbyking.com/hobbyking/store/__107873__QAV2206_1900KV_Brushless_Motor_CCW_.html",
                Price = 9.75,
                Kv = 1900,
                Weight = 29,
                MaxCurrent = 18,
                MaxVoltage = 15,
                Length = 20,
                Diameter = 28,
                CanLength = 8,
                TotalLength = 30
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Turnigy Multistar 2834-800Kv 14 Pole Multi-Rotor Outrunner V2",
                Url = "http://www.hobbyking.com/hobbyking/store/__66419__Turnigy_Multistar_2834_800Kv_14_Pole_Multi_Rotor_Outrunner_V2.html",
                Price = 38.35,
                Kv = 800,
                Weight = 198,
                MaxCurrent = 45,
                MaxVoltage = 15,
                Shaft = 4,
                Length = 56,
                Diameter = 35,
                CanLength = 38,
                TotalLength = 62
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "LDPOWER MT1806-2280KV Brushless Multicopter Motor (CCW)",
                Url = "http://www.hobbyking.com/hobbyking/store/__86641__LDPOWER_MT1806_2280KV_Brushless_Multicopter_Motor_CCW_.html",
                Price = 7.96,
                Kv = 2280,
                Weight = 25,
                MaxCurrent = 13.7,
                MaxVoltage = 12,
                Shaft = 5,
                Length = 15,
                Diameter = 24,
                CanLength = 9,
                TotalLength = 28
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();
            context.ThrustDataPoints.AddOrUpdate(t => t.Id,
                    new ThrustDataPoint()
                    {
                        PropDiameter = 6,
                        MotorId = motor.Id,
                        PropPitch = 3,
                        Voltage = 11.1,
                        Current = 1.7,
                        Thrust = 106,
                    },
                    new ThrustDataPoint()
                    {
                        PropDiameter = 6,
                        MotorId = motor.Id,
                        PropPitch = 3,
                        Voltage = 11.1,
                        Current = 2.8,
                        Thrust = 155,
                    },
                    new ThrustDataPoint()
                    {
                        PropDiameter = 6,
                        MotorId = motor.Id,
                        PropPitch = 3,
                        Voltage = 11.1,
                        Current = 3.8,
                        Thrust = 206,
                    },
                    new ThrustDataPoint()
                    {
                        PropDiameter = 6,
                        MotorId = motor.Id,
                        PropPitch = 3,
                        Voltage = 11.1,
                        Current = 6.5,
                        Thrust = 309,
                    },
                    new ThrustDataPoint()
                    {
                        PropDiameter = 6,
                        MotorId = motor.Id,
                        PropPitch = 3,
                        Voltage = 11.1,
                        Current = 8,
                        Thrust = 355,
                    },
                    new ThrustDataPoint()
                    {
                        PropDiameter = 6,
                        MotorId = motor.Id,
                        PropPitch = 4.5,
                        Voltage = 11.1,
                        Current = 1.9,
                        Thrust = 115,
                    },
                    new ThrustDataPoint()
                    {
                        PropDiameter = 6,
                        MotorId = motor.Id,
                        PropPitch = 4.5,
                        Voltage = 11.1,
                        Current = 3.2,
                        Thrust = 170,
                    },
                    new ThrustDataPoint()
                    {
                        PropDiameter = 6,
                        MotorId = motor.Id,
                        PropPitch = 4.5,
                        Voltage = 11.1,
                        Current = 4.8,
                        Thrust = 232,
                    },
                    new ThrustDataPoint()
                    {
                        PropDiameter = 6,
                        MotorId = motor.Id,
                        PropPitch = 4.5,
                        Voltage = 11.1,
                        Current = 8,
                        Thrust = 328,
                    },
                    new ThrustDataPoint()
                    {
                        PropDiameter = 6,
                        MotorId = motor.Id,
                        PropPitch = 4.5,
                        Voltage = 11.1,
                        Current = 9.7,
                        Thrust = 370,
                    }
                );



            motor = new Motor()
            {
                Name = "Multistar Elite 2308-1400 Multi-Rotor Motor (CW/CCW)",
                Url = "http://www.hobbyking.com/hobbyking/store/__86407__Multistar_Elite_2308_1400_Multi_Rotor_Motor_CW_CCW_.html",
                Price = 18.27,
                Kv = 1400,
                Weight = 45,
                MaxCurrent = 0,
                MaxVoltage = 12,
                Shaft = 4,
                Length = 0,
                Diameter = 23,
                CanLength = 0,
                TotalLength = 0
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Black Widow 4108-390Kv With Built-In ESC CW/CCW",
                Url = "http://www.hobbyking.com/hobbyking/store/__82881__Black_Widow_4108_390Kv_With_Built_In_ESC_CW_CCW.html",
                Price = 40.20,
                Kv = 390,
                Weight = 196,
                MaxCurrent = 40,
                MaxVoltage = 23,
                Shaft = 4,
                Length = 36,
                Diameter = 47,
                CanLength = 10,
                TotalLength = 42
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();
            context.ThrustDataPoints.AddOrUpdate(t => t.Id,
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 14.8,
                        PropDiameter = 14,
                        PropPitch = 4.7,
                        Current = 10,
                        Thrust = 1154,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 14.8,
                        PropDiameter = 15,
                        PropPitch = 5.5,
                        Current = 12,
                        Thrust = 1213,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 14.8,
                        PropDiameter = 16,
                        PropPitch = 5.5,
                        Current = 14,
                        Thrust = 1179,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 22.2,
                        PropDiameter = 14,
                        PropPitch = 4.7,
                        Current = 18,
                        Thrust = 2013,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 22.2,
                        PropDiameter = 15,
                        PropPitch = 5.5,
                        Current = 20,
                        Thrust = 1974,
                    }
                );



            motor = new Motor()
            {
                Name = "Black Widow 4108-320Kv With Built-In ESC CW/CCW",
                Url = "http://www.hobbyking.com/hobbyking/store/__82880__Black_Widow_4108_320Kv_With_Built_In_ESC_CW_CCW.html",
                Price = 50.68,
                Kv = 320,
                Weight = 196,
                MaxCurrent = 40,
                MaxVoltage = 23,
                Shaft = 4,
                Length = 36,
                Diameter = 47,
                CanLength = 10,
                TotalLength = 42
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();
            context.ThrustDataPoints.AddOrUpdate(t => t.Id,
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 14.8,
                        PropDiameter = 14,
                        PropPitch = 4.7,
                        Current = 6,
                        Thrust = 845,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 14.8,
                        PropDiameter = 15,
                        PropPitch = 5.5,
                        Current = 7,
                        Thrust = 930,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 14.8,
                        PropDiameter = 16,
                        PropPitch = 5.5,
                        Current = 9,
                        Thrust = 940,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 22.2,
                        PropDiameter = 14,
                        PropPitch = 4.7,
                        Current = 11,
                        Thrust = 1586,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 22.2,
                        PropDiameter = 15,
                        PropPitch = 5.5,
                        Current = 13,
                        Thrust = 1652,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 22.2,
                        PropDiameter = 16,
                        PropPitch = 5.5,
                        Current = 15,
                        Thrust = 1525,
                    }
                );



            motor = new Motor()
            {
                Name = "Turnigy 5017 620kv Brushless Multi-Rotor Motor",
                Url = "http://www.hobbyking.com/hobbyking/store/__56934__Turnigy_5017_620kv_Brushless_Multi_Rotor_Motor.html",
                Price = 21.89,
                Kv = 620,
                Weight = 125,
                MaxCurrent = 30,
                MaxVoltage = 16,
                Shaft = 6,
                Length = 22,
                Diameter = 50,
                CanLength = 11,
                TotalLength = 30
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "LDPower Brushless Outrunner 35x40mm (2820-920KV)",
                Url = "http://www.hobbyking.com/hobbyking/store/__88485__LDPower_Brushless_Outrunner_35x40mm_2820_920KV_.html",
                Price = 16.78,
                Kv = 920,
                Weight = 137,
                MaxCurrent = 77,
                MaxVoltage = 0,
                Shaft = 5,
                Length = 40,
                Diameter = 35,
                CanLength = 0,
                TotalLength = 46
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Turnigy Multistar 3508-640Kv 14 Pole Multi-Rotor Outrunner V2",
                Url = "http://www.hobbyking.com/hobbyking/store/__66420__Turnigy_Multistar_3508_640Kv_14_Pole_Multi_Rotor_Outrunner_V2.html",
                Price = 29.96,
                Kv = 640,
                Weight = 97,
                MaxCurrent = 30,
                MaxVoltage = 19,
                Shaft = 4,
                Length = 26,
                Diameter = 42,
                CanLength = 11,
                TotalLength = 31
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Turnigy Multistar 3525-750Kv 14Pole Multi-Rotor Outrunner",
                Url = "http://www.hobbyking.com/hobbyking/store/__39041__Turnigy_Multistar_3525_750Kv_14Pole_Multi_Rotor_Outrunner.html",
                Price = 34.92,
                Kv = 750,
                Weight = 233,
                MaxCurrent = 50,
                MaxVoltage = 19,
                Shaft = 0,
                Length = 48,
                Diameter = 42,
                CanLength = 28,
                TotalLength = 48
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Turnigy Multistar 4822-690Kv 22Pole Multi-Rotor Outrunner",
                Url = "http://www.hobbyking.com/hobbyking/store/__26960__Turnigy_Multistar_4822_690Kv_22Pole_Multi_Rotor_Outrunner.html",
                Price = 27.16,
                Kv = 690,
                Weight = 95,
                MaxCurrent = 22,
                MaxVoltage = 15,
                Length = 25,
                Diameter = 48,
                CanLength = 10,
                TotalLength = 29
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "ZTW Spider PRO Premium SP2205-2600KV Brushless Motor",
                Url = "http://www.hobbyking.com/hobbyking/store/__107735__ZTW_Spider_PRO_Premium_SP2205_2600KV_Brushless_Motor.html",
                Price = 19.99,
                Kv = 2600,
                Weight = 26,
                MaxCurrent = 0,
                MaxVoltage = 0,
                Shaft = 5,
                Length = 16,
                Diameter = 28,
                CanLength = 6,
                TotalLength = 31
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Quanum MT Series 4012 340KV Brushless Multirotor Motor Built by DYS",
                Url = "http://www.hobbyking.com/hobbyking/store/__67027__Quanum_MT_Series_4012_340KV_Brushless_Multirotor_Motor_Built_by_DYS.html",
                Price = 24.78,
                Kv = 340,
                Weight = 134,
                MaxCurrent = 15,
                MaxVoltage = 22,
                Shaft = 4,
                Length = 31,
                Diameter = 47,
                CanLength = 13,
                TotalLength = 38
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Multistar Elite 2216 920KV Multirotor Motor (CCW)",
                Url = "http://www.hobbyking.com/hobbyking/store/__74758__Multistar_Elite_2216_920KV_Multirotor_Motor_CCW_.html",
                Price = 19.11,
                Kv = 920,
                Weight = 58,
                MaxCurrent = 18,
                MaxVoltage = 15,
                Shaft = 8,
                Length = 31,
                Diameter = 28,
                CanLength = 19,
                TotalLength = 44
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Multistar Elite 2312 980KV Motor Set CW/CCW EZO Bearings, 4mm Main Shaft, N45SH Magnets (2 Motors)",
                Url = "http://www.hobbyking.com/hobbyking/store/__72506__Multistar_Elite_2312_980KV_Motor_Set_CW_CCW_EZO_Bearings_4mm_Main_Shaft_N45SH_Magnets_2_Motors_.html",
                Price = 36.54,
                Kv = 980,
                Weight = 58,
                MaxCurrent = 18,
                MaxVoltage = 14,
                Shaft = 4,
                Length = 26,
                Diameter = 28,
                CanLength = 14,
                TotalLength = 40
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "HobbyKing AP-02 7000kv Brushless Micro Motor (2.3g)",
                Url = "http://www.hobbyking.com/hobbyking/store/__9666__HobbyKing_AP_02_7000kv_Brushless_Micro_Motor_2_3g_.html",
                Price = 19.99,
                Kv = 7000,
                Weight = 2.3,
                MaxCurrent = 2.5,
                MaxVoltage = 4,
                Shaft = 2,
                Length = 8,
                Diameter = 13,
                CanLength = 2,
                TotalLength = 13
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Quanum MT Series 4012 480KV Brushless Multirotor Motor Built by DYS",
                Url = "http://www.hobbyking.com/hobbyking/store/__67029__Quanum_MT_Series_4012_480KV_Brushless_Multirotor_Motor_Built_by_DYS.html",
                Price = 35.53,
                Kv = 580,
                Weight = 142,
                MaxCurrent = 16,
                MaxVoltage = 22,
                Shaft = 4,
                Length = 31,
                Diameter = 47,
                CanLength = 14,
                TotalLength = 38
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "AX-4008Q-620KV Brushless Quadcopter Motor",
                Url = "http://www.hobbyking.com/hobbyking/store/__25555__AX_4008Q_620KV_Brushless_Quadcopter_Motor.html",
                Price = 30.10,
                Kv = 620,
                Weight = 88,
                MaxCurrent = 30,
                MaxVoltage = 19,
                Shaft = 4,
                Length = 23,
                Diameter = 45,
                CanLength = 11,
                TotalLength = 43
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Turnigy Aerodrive 2206 34T 1620KV 8.5A Brushless Outrunner",
                Url = "http://www.hobbyking.com/hobbyking/store/__51879__Turnigy_Aerodrive_2206_34T_1620KV_8_5A_Brushless_Outrunner.html",
                Price = 12.00,
                Kv = 1620,
                Weight = 32,
                MaxCurrent = 11,
                MaxVoltage = 11,
                Shaft = 3.175,
                Length = 22,
                Diameter = 28,
                CanLength = 8,
                TotalLength = 37
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Turnigy Multistar 2216-800Kv 14Pole Multi-Rotor Outrunner V2",
                Url = "http://www.hobbyking.com/hobbyking/store/__66417__Turnigy_Multistar_2216_800Kv_14Pole_Multi_Rotor_Outrunner_V2.html",
                Price = 16.25,
                Kv = 800,
                Weight = 83,
                MaxCurrent = 20,
                MaxVoltage = 12,
                Length = 34,
                Diameter = 28,
                CanLength = 18,
                TotalLength = 38
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "5008-340KV Turnigy Multistar Multi-Rotor Motor With 3.5mm Bullet Connector Installed",
                Url = "http://www.hobbyking.com/hobbyking/store/__45282__5008_340KV_Turnigy_Multistar_Multi_Rotor_Motor_With_3_5mm_Bullet_Connector_Installed.html",
                Price = 39.99,
                Kv = 340,
                Weight = 163,
                MaxCurrent = 40,
                MaxVoltage = 22,
                Shaft = 4,
                Length = 28,
                Diameter = 59,
                CanLength = 12,
                TotalLength = 28
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "4108-380KV Turnigy Multistar 22 Pole Brushless Multi-Rotor Motor With Extra Long Leads",
                Url = "http://www.hobbyking.com/hobbyking/store/__41623__4108_380KV_Turnigy_Multistar_22_Pole_Brushless_Multi_Rotor_Motor_With_Extra_Long_Leads.html",
                Price = 31.86,
                Kv = 380,
                Weight = 111,
                MaxCurrent = 17,
                MaxVoltage = 0,
                Shaft = 4,
                Length = 26,
                Diameter = 47,
                CanLength = 12,
                TotalLength = 36
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Multistar Elite 2306-2150KV 'MINI MONSTER' Quad Racing Motor (CW)",
                Url = "http://www.hobbyking.com/hobbyking/store/__80475__Multistar_Elite_2306_2150KV_39_MINI_MONSTER_39_Quad_Racing_Motor_CW_.html",
                Price = 16.09,
                Kv = 2150,
                Weight = 37.5,
                MaxCurrent = 20,
                MaxVoltage = 0,
                Length = 0,
                Diameter = 0,
                CanLength = 0,
                TotalLength = 0
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "LDPOWER MT1806-2280KV Brushless Multicopter Motor (CW)",
                Url = "http://www.hobbyking.com/hobbyking/store/__86640__LDPOWER_MT1806_2280KV_Brushless_Multicopter_Motor_CW_.html",
                Price = 7.96,
                Kv = 2280,
                Weight = 25,
                MaxCurrent = 13.7,
                MaxVoltage = 12,
                Shaft = 5,
                Length = 15,
                Diameter = 24,
                CanLength = 9,
                TotalLength = 28
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();
            context.ThrustDataPoints.AddOrUpdate(t => t.Id,
                    new ThrustDataPoint()
                    {
                        PropDiameter = 6,
                        MotorId = motor.Id,
                        PropPitch = 3,
                        Voltage = 11.1,
                        Current = 1.7,
                        Thrust = 106,
                    },
                    new ThrustDataPoint()
                    {
                        PropDiameter = 6,
                        MotorId = motor.Id,
                        PropPitch = 3,
                        Voltage = 11.1,
                        Current = 2.8,
                        Thrust = 155,
                    },
                    new ThrustDataPoint()
                    {
                        PropDiameter = 6,
                        MotorId = motor.Id,
                        PropPitch = 3,
                        Voltage = 11.1,
                        Current = 3.8,
                        Thrust = 206,
                    },
                    new ThrustDataPoint()
                    {
                        PropDiameter = 6,
                        MotorId = motor.Id,
                        PropPitch = 3,
                        Voltage = 11.1,
                        Current = 6.5,
                        Thrust = 309,
                    },
                    new ThrustDataPoint()
                    {
                        PropDiameter = 6,
                        MotorId = motor.Id,
                        PropPitch = 3,
                        Voltage = 11.1,
                        Current = 8,
                        Thrust = 355,
                    },
                    new ThrustDataPoint()
                    {
                        PropDiameter = 6,
                        MotorId = motor.Id,
                        PropPitch = 4.5,
                        Voltage = 11.1,
                        Current = 1.9,
                        Thrust = 115,
                    },
                    new ThrustDataPoint()
                    {
                        PropDiameter = 6,
                        MotorId = motor.Id,
                        PropPitch = 4.5,
                        Voltage = 11.1,
                        Current = 3.2,
                        Thrust = 170,
                    },
                    new ThrustDataPoint()
                    {
                        PropDiameter = 6,
                        MotorId = motor.Id,
                        PropPitch = 4.5,
                        Voltage = 11.1,
                        Current = 4.8,
                        Thrust = 232,
                    },
                    new ThrustDataPoint()
                    {
                        PropDiameter = 6,
                        MotorId = motor.Id,
                        PropPitch = 4.5,
                        Voltage = 11.1,
                        Current = 8,
                        Thrust = 328,
                    },
                    new ThrustDataPoint()
                    {
                        PropDiameter = 6,
                        MotorId = motor.Id,
                        PropPitch = 4.5,
                        Voltage = 11.1,
                        Current = 9.7,
                        Thrust = 370,
                    }
                );



            motor = new Motor()
            {
                Name = "QAV2206-2200KV Brushless Motor (CCW)",
                Url = "http://www.hobbyking.com/hobbyking/store/__107861__QAV2206_2200KV_Brushless_Motor_CCW_.html",
                Price = 9.75,
                Kv = 2200,
                Weight = 29,
                MaxCurrent = 16,
                MaxVoltage = 15,
                Shaft = 5,
                Length = 19,
                Diameter = 28,
                CanLength = 8,
                TotalLength = 30
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "LDPOWER M2810-720KV Brushless Multicopter Motor (CW)",
                Url = "http://www.hobbyking.com/hobbyking/store/__86650__LDPOWER_M2810_720KV_Brushless_Multicopter_Motor_CW_.html",
                Price = 19.99,
                Kv = 720,
                Weight = 88,
                MaxCurrent = 27,
                MaxVoltage = 15,
                Shaft = 4,
                Length = 28,
                Diameter = 35,
                CanLength = 12,
                TotalLength = 35
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();
            context.ThrustDataPoints.AddOrUpdate(t => t.Id,
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 14.8,
                        PropDiameter = 10,
                        PropPitch = 3.3,
                        Current = 4.95,
                        Thrust = 6544,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 14.8,
                        PropDiameter = 10,
                        PropPitch = 3.3,
                        Current = 10.55,
                        Thrust = 8583,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 14.8,
                        PropDiameter = 11,
                        PropPitch = 5,
                        Current = 1.9,
                        Thrust = 4399,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 14.8,
                        PropDiameter = 11,
                        PropPitch = 5,
                        Current = 3.2,
                        Thrust = 5404,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 14.8,
                        PropDiameter = 11,
                        PropPitch = 5,
                        Current = 10.8,
                        Thrust = 8156,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 14.8,
                        PropDiameter = 11,
                        PropPitch = 5,
                        Current = 12.3,
                        Thrust = 8442,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 14.8,
                        PropDiameter = 12,
                        PropPitch = 4,
                        Current = 2.1,
                        Thrust = 4113,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 14.8,
                        PropDiameter = 12,
                        PropPitch = 4,
                        Current = 3.8,
                        Thrust = 5215,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 14.8,
                        PropDiameter = 12,
                        PropPitch = 4,
                        Current = 12.3,
                        Thrust = 7854,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 14.8,
                        PropDiameter = 12,
                        PropPitch = 4,
                        Current = 14.2,
                        Thrust = 8193,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 14.8,
                        PropDiameter = 13,
                        PropPitch = 4.5,
                        Current = 0.5,
                        Thrust = 1917,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 14.8,
                        PropDiameter = 13,
                        PropPitch = 4.5,
                        Current = 2.8,
                        Thrust = 3846,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 14.8,
                        PropDiameter = 13,
                        PropPitch = 4.5,
                        Current = 6.1,
                        Thrust = 5069,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 14.8,
                        PropDiameter = 13,
                        PropPitch = 4.5,
                        Current = 8.6,
                        Thrust = 5738,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 14.8,
                        PropDiameter = 13,
                        PropPitch = 4.5,
                        Current = 13.9,
                        Thrust = 6673,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 14.8,
                        PropDiameter = 13,
                        PropPitch = 4.5,
                        Current = 18.5,
                        Thrust = 7232,
                    }
                );



            motor = new Motor()
            {
                Name = "QAV RT2206-2000KV Quad Racing Motor (CCW)",
                Url = "http://www.hobbyking.com/hobbyking/store/__101603__QAV_RT2206_2000KV_Quad_Racing_Motor_CCW_.html",
                Price = 12.75,
                Kv = 2000,
                Weight = 29.1,
                MaxCurrent = 25,
                MaxVoltage = 12,
                Shaft = 5,
                Length = 18,
                Diameter = 28,
                CanLength = 8,
                TotalLength = 30
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "9235-100KV Turnigy Multistar Brushless Multi-Rotor Motor",
                Url = "http://www.hobbyking.com/hobbyking/store/__54888__9235_100KV_Turnigy_Multistar_Brushless_Multi_Rotor_Motor.html",
                Price = 167.18,
                Kv = 100,
                Weight = 674,
                MaxCurrent = 57,
                MaxVoltage = 45,
                Length = 38,
                Diameter = 92,
                CanLength = 22,
                TotalLength = 43
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "DYS Series BE 4715-330KV Brushless Outrunner for Multirotors",
                Url = "http://www.hobbyking.com/hobbyking/store/__77171__DYS_Series_BE_4715_330KV_Brushless_Outrunner_for_Multirotors.html",
                Price = 38.78,
                Kv = 330,
                Weight = 215,
                MaxCurrent = 33.8,
                MaxVoltage = 22,
                Shaft = 4,
                Length = 36,
                Diameter = 54,
                CanLength = 19,
                TotalLength = 43
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Quanum MT Series 4108 580KV Brushless Multirotor Motor Built by DYS",
                Url = "http://www.hobbyking.com/hobbyking/store/__67032__Quanum_MT_Series_4108_580KV_Brushless_Multirotor_Motor_Built_by_DYS.html",
                Price = 29.76,
                Kv = 580,
                Weight = 88,
                MaxCurrent = 27,
                MaxVoltage = 22,
                Shaft = 4,
                Length = 27,
                Diameter = 46,
                CanLength = 9,
                TotalLength = 34
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "DYS 1804-2300KV BX Series Set of Two CW/CCW Motors",
                Url = "http://www.hobbyking.com/hobbyking/store/__66399__DYS_1804_2300KV_BX_Series_Set_of_Two_CW_CCW_Motors.html",
                Price = 19.66,
                Kv = 2300,
                Weight = 16,
                MaxCurrent = 8,
                MaxVoltage = 12,
                Shaft = 5,
                Length = 13,
                Diameter = 23,
                CanLength = 4,
                TotalLength = 24
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Turnigy Multistar 1704-2300Kv 12 Pole Multirotor Outrunner V2",
                Url = "http://www.hobbyking.com/hobbyking/store/__66424__Turnigy_Multistar_1704_2300Kv_12_Pole_Multirotor_Outrunner_V2.html",
                Price = 11.66,
                Kv = 2300,
                Weight = 15.5,
                MaxCurrent = 4.5,
                MaxVoltage = 11,
                Shaft = 2,
                Length = 16,
                Diameter = 21,
                CanLength = 6,
                TotalLength = 21
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "LDPOWER Racing series 2206-2200KV CW",
                Url = "http://www.hobbyking.com/hobbyking/store/__100156__LDPOWER_Racing_series_2206_2200KV_CW.html",
                Price = 9.99,
                Kv = 2200,
                Weight = 30,
                MaxCurrent = 27,
                MaxVoltage = 0,
                Length = 17,
                Diameter = 28,
                CanLength = 13,
                TotalLength = 32
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Multistar Elite 2204-2300KV Multi-Rotor Motor 3-4S (CW Prop Adapter)",
                Url = "http://www.hobbyking.com/hobbyking/store/__63063__Multistar_Elite_2204_2300KV_Multi_Rotor_Motor_3_4S_CW_Prop_Adapter_.html",
                Price = 13.49,
                Kv = 2300,
                Weight = 24,
                MaxCurrent = 20,
                MaxVoltage = 15,
                Length = 17,
                Diameter = 28,
                CanLength = 6,
                TotalLength = 22
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Multistar Elite 4006-740KV Multi-Rotor Motor",
                Url = "http://www.hobbyking.com/hobbyking/store/__63643__Multistar_Elite_4006_740KV_Multi_Rotor_Motor.html",
                Price = 36.86,
                Kv = 740,
                Weight = 93,
                MaxCurrent = 28,
                MaxVoltage = 17,
                Shaft = 4,
                Length = 22,
                Diameter = 45,
                CanLength = 8,
                TotalLength = 30
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Multistar Elite 2216 920KV Multirotor Motor (CW)",
                Url = "http://www.hobbyking.com/hobbyking/store/__74757__Multistar_Elite_2216_920KV_Multirotor_Motor_CW_.html",
                Price = 19.11,
                Kv = 920,
                Weight = 58,
                MaxCurrent = 18,
                MaxVoltage = 15,
                Shaft = 8,
                Length = 31,
                Diameter = 28,
                CanLength = 19,
                TotalLength = 44
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Multistar Elite 2204-2300KV 3-4s 4 pack (2/CCW 2/CW)",
                Url = "http://www.hobbyking.com/hobbyking/store/__63065__Multistar_Elite_2204_2300KV_3_4s_4_pack_2_CCW_2_CW_.html",
                Price = 51.10,
                Kv = 2300,
                Weight = 24,
                MaxCurrent = 20,
                MaxVoltage = 15,
                Length = 17,
                Diameter = 28,
                CanLength = 6,
                TotalLength = 22
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();
            context.ThrustDataPoints.AddOrUpdate(t => t.Id,
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 11.1,
                        PropDiameter = 5,
                        PropPitch = 3,
                        Thrust = 224,
                        Current = 3.7,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 11.1,
                        PropDiameter = 5,
                        PropPitch = 3,
                        Thrust = 371,
                        Current = 7.5,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 7.4,
                        PropDiameter = 5,
                        PropPitch = 2,
                        Thrust = 120,
                        Current = 2.2,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 7.4,
                        PropDiameter = 5,
                        PropPitch = 2,
                        Thrust = 200,
                        Current = 4.3,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 11.1,
                        PropDiameter = 5,
                        PropPitch = 3,
                        Thrust = 232,
                        Current = 4.7,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 11.1,
                        PropDiameter = 5,
                        PropPitch = 3,
                        Thrust = 392,
                        Current = 9.9,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 7.4,
                        PropDiameter = 5,
                        PropPitch = 3,
                        Thrust = 134,
                        Current = 2.7,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 7.4,
                        PropDiameter = 5,
                        PropPitch = 3,
                        Thrust = 211,
                        Current = 6.7,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 11.1,
                        PropDiameter = 6,
                        PropPitch = 4,
                        Thrust = 385,
                        Current = 7.5,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 11.1,
                        PropDiameter = 6,
                        PropPitch = 4,
                        Thrust = 591,
                        Current = 9.9,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 7.4,
                        PropDiameter = 6,
                        PropPitch = 4,
                        Thrust = 134,
                        Current = 4.8,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 7.4,
                        PropDiameter = 6,
                        PropPitch = 4,
                        Thrust = 211,
                        Current = 9.7,
                    }
                );



            motor = new Motor()
            {
                Name = "4014-400KV Turnigy Multistar 22 Pole Brushless Multi-Rotor Motor With Extra Long Leads",
                Url = "http://www.hobbyking.com/hobbyking/store/__41622__4014_400KV_Turnigy_Multistar_22_Pole_Brushless_Multi_Rotor_Motor_With_Extra_Long_Leads.html",
                Price = 48.16,
                Kv = 400,
                Weight = 163,
                MaxCurrent = 30,
                MaxVoltage = 0,
                Shaft = 5,
                Length = 32,
                Diameter = 45,
                CanLength = 17,
                TotalLength = 42
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Quanum MT Series 4010 370KV Brushless Multirotor Motor Built by DYS",
                Url = "http://www.hobbyking.com/hobbyking/store/__67024__Quanum_MT_Series_4010_370KV_Brushless_Multirotor_Motor_Built_by_DYS.html",
                Price = 22.44,
                Kv = 370,
                Weight = 0,
                MaxCurrent = 11,
                MaxVoltage = 19,
                Shaft = 4,
                Length = 29,
                Diameter = 48,
                CanLength = 11,
                TotalLength = 36
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "3508-380KV Turnigy Multistar 14 Pole Brushless Multi-Rotor Motor With Extra Long Leads",
                Url = "http://www.hobbyking.com/hobbyking/store/__41615__3508_380KV_Turnigy_Multistar_14_Pole_Brushless_Multi_Rotor_Motor_With_Extra_Long_Leads.html",
                Price = 31.86,
                Kv = 380,
                Weight = 102,
                MaxCurrent = 14,
                MaxVoltage = 0,
                Shaft = 4,
                Length = 26,
                Diameter = 42,
                CanLength = 10,
                TotalLength = 36
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "4112-485KV Turnigy Multistar 22 Pole Brushless Multi-Rotor Motor With Extra Long Leads",
                Url = "http://www.hobbyking.com/hobbyking/store/__41628__4112_485KV_Turnigy_Multistar_22_Pole_Brushless_Multi_Rotor_Motor_With_Extra_Long_Leads.html",
                Price = 39.76,
                Kv = 485,
                Weight = 147,
                MaxCurrent = 28,
                MaxVoltage = 0,
                Shaft = 5,
                Length = 30,
                Diameter = 47,
                CanLength = 15,
                TotalLength = 40
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Turnigy Multistar 3508-640Kv 14Pole Multi-Rotor Outrunner",
                Url = "http://www.hobbyking.com/hobbyking/store/__39040__Turnigy_Multistar_3508_640Kv_14Pole_Multi_Rotor_Outrunner.html",
                Price = 29.92,
                Kv = 640,
                Weight = 98,
                MaxCurrent = 30,
                MaxVoltage = 19,
                Shaft = 0,
                Length = 26,
                Diameter = 42,
                CanLength = 11,
                TotalLength = 26
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Turnigy Multistar 1704-1900Kv 12 Pole Multirotor Outrunner V2",
                Url = "http://www.hobbyking.com/hobbyking/store/__66414__Turnigy_Multistar_1704_1900Kv_12_Pole_Multirotor_Outrunner_V2.html",
                Price = 9.99,
                Kv = 1900,
                Weight = 15.5,
                MaxCurrent = 4.5,
                MaxVoltage = 11,
                Shaft = 2,
                Length = 16,
                Diameter = 21,
                CanLength = 6,
                TotalLength = 21
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Quanum MT Series 5208 335KV Brushless Multirotor Motor Built by DYS",
                Url = "http://www.hobbyking.com/hobbyking/store/__67036__Quanum_MT_Series_5208_335KV_Brushless_Multirotor_Motor_Built_by_DYS.html",
                Price = 37.52,
                Kv = 335,
                Weight = 174,
                MaxCurrent = 28,
                MaxVoltage = 22,
                Shaft = 4,
                Length = 27,
                Diameter = 63,
                CanLength = 10,
                TotalLength = 33
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Turnigy Multistar 4225-390Kv 16Pole Multi-Rotor Outrunner",
                Url = "http://www.hobbyking.com/hobbyking/store/__26963__Turnigy_Multistar_4225_390Kv_16Pole_Multi_Rotor_Outrunner.html",
                Price = 29.99,
                Kv = 390,
                Weight = 86,
                MaxCurrent = 15,
                MaxVoltage = 22,
                Length = 25,
                Diameter = 42,
                CanLength = 5,
                TotalLength = 24
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "LDPOWER MT1306-3100KV Brushless Multicopter Motor (CW)",
                Url = "http://www.hobbyking.com/hobbyking/store/__86638__LDPOWER_MT1306_3100KV_Brushless_Multicopter_Motor_CW_.html",
                Price = 12.90,
                Kv = 3100,
                Weight = 16,
                MaxCurrent = 14,
                MaxVoltage = 8,
                Shaft = 5,
                Length = 15,
                Diameter = 18,
                CanLength = 13,
                TotalLength = 26
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();
            context.ThrustDataPoints.AddOrUpdate(t => t.Id,
                    new ThrustDataPoint()
                    {
                        PropDiameter = 4,
                        MotorId = motor.Id,
                        PropPitch = 4.5,
                        Voltage = 7.4,
                        Current = 1.1,
                        Thrust = 37,
                    },
                    new ThrustDataPoint()
                    {
                        PropDiameter = 4,
                        MotorId = motor.Id,
                        PropPitch = 4.5,
                        Voltage = 7.4,
                        Current = 1.6,
                        Thrust = 57,
                    },
                    new ThrustDataPoint()
                    {
                        PropDiameter = 4,
                        MotorId = motor.Id,
                        PropPitch = 4.5,
                        Voltage = 7.4,
                        Current = 2.1,
                        Thrust = 73,
                    },
                    new ThrustDataPoint()
                    {
                        PropDiameter = 4,
                        MotorId = motor.Id,
                        PropPitch = 4.5,
                        Voltage = 7.4,
                        Current = 3,
                        Thrust = 98,
                    },
                    new ThrustDataPoint()
                    {
                        PropDiameter = 4,
                        MotorId = motor.Id,
                        PropPitch = 4.5,
                        Voltage = 7.4,
                        Current = 3.7,
                        Thrust = 120,
                    }
                );



            motor = new Motor()
            {
                Name = "Quanum MT Series 5008 335KV Brushless Multirotor Motor Built by DYS",
                Url = "http://www.hobbyking.com/hobbyking/store/__67038__Quanum_MT_Series_5008_335KV_Brushless_Multirotor_Motor_Built_by_DYS.html",
                Price = 19.99,
                Kv = 335,
                Weight = 155,
                MaxCurrent = 19,
                MaxVoltage = 22,
                Shaft = 4,
                Length = 27,
                Diameter = 59,
                CanLength = 10,
                TotalLength = 33
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Turnigy 4206 530kv Brushless Multi-Rotor Motor",
                Url = "http://www.hobbyking.com/hobbyking/store/__56937__Turnigy_4206_530kv_Brushless_Multi_Rotor_Motor.html",
                Price = 18.99,
                Kv = 530,
                Weight = 68,
                MaxCurrent = 20,
                MaxVoltage = 16,
                Shaft = 6,
                Length = 21,
                Diameter = 42,
                CanLength = 11,
                TotalLength = 28
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "4010-375KV Turnigy Multistar 22 Pole Brushless Multi-Rotor Motor With Extra Long Leads",
                Url = "http://www.hobbyking.com/hobbyking/store/__41618__4010_375KV_Turnigy_Multistar_22_Pole_Brushless_Multi_Rotor_Motor_With_Extra_Long_Leads.html",
                Price = 41.16,
                Kv = 375,
                Weight = 128,
                MaxCurrent = 20,
                MaxVoltage = 0,
                Shaft = 4,
                Length = 28,
                Diameter = 45,
                CanLength = 13,
                TotalLength = 39
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "DYS BE1104-4000KV Multi-rotor Motor (Black)",
                Url = "http://www.hobbyking.com/hobbyking/store/__91896__DYS_BE1104_4000KV_Multi_rotor_Motor_Black_.html",
                Price = 10.00,
                Kv = 4000,
                Weight = 5.6,
                MaxCurrent = 3.5,
                MaxVoltage = 15,
                Shaft = 1.5,
                Length = 12,
                Diameter = 14,
                CanLength = 0,
                TotalLength = 17
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();
            context.ThrustDataPoints.AddOrUpdate(t => t.Id,
                    new ThrustDataPoint()
                    {
                        PropDiameter = 3,
                        MotorId = motor.Id,
                        PropPitch = 2,
                        Voltage = 11.1,
                        Current = 1.1,
                        Thrust = 50,
                    },
                    new ThrustDataPoint()
                    {
                        PropDiameter = 3,
                        MotorId = motor.Id,
                        PropPitch = 2,
                        Voltage = 11.1,
                        Current = 2.9,
                        Thrust = 100,
                    },
                    new ThrustDataPoint()
                    {
                        PropDiameter = 3,
                        MotorId = motor.Id,
                        PropPitch = 2,
                        Voltage = 11.1,
                        Current = 4.3,
                        Thrust = 144,
                    },
                    new ThrustDataPoint()
                    {
                        PropDiameter = 3,
                        MotorId = motor.Id,
                        PropPitch = 2,
                        Voltage = 14.8,
                        Current = 1.2,
                        Thrust = 60,
                    },
                    new ThrustDataPoint()
                    {
                        PropDiameter = 3,
                        MotorId = motor.Id,
                        PropPitch = 2,
                        Voltage = 14.8,
                        Current = 2.8,
                        Thrust = 120,
                    },
                    new ThrustDataPoint()
                    {
                        PropDiameter = 3,
                        MotorId = motor.Id,
                        PropPitch = 2,
                        Voltage = 14.8,
                        Current = 5.5,
                        Thrust = 190,
                    }
                );



            motor = new Motor()
            {
                Name = "Turnigy Multistar 4220-880Kv 16Pole Multi-Rotor Outrunner",
                Url = "http://www.hobbyking.com/hobbyking/store/__38455__Turnigy_Multistar_4220_880Kv_16Pole_Multi_Rotor_Outrunner.html",
                Price = 22.95,
                Kv = 880,
                Weight = 65,
                MaxCurrent = 22,
                MaxVoltage = 11,
                Length = 21,
                Diameter = 42,
                CanLength = 21,
                TotalLength = 25
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "4108-600KV Turnigy Multistar 22 Pole Brushless Multi-Rotor Motor With Extra Long Leads",
                Url = "http://www.hobbyking.com/hobbyking/store/__41625__4108_600KV_Turnigy_Multistar_22_Pole_Brushless_Multi_Rotor_Motor_With_Extra_Long_Leads.html",
                Price = 31.86,
                Kv = 600,
                Weight = 111,
                MaxCurrent = 26,
                MaxVoltage = 0,
                Shaft = 4,
                Length = 26,
                Diameter = 47,
                CanLength = 12,
                TotalLength = 37
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Quanum MT Series 4012 400KV Brushless Multirotor Motor Built by DYS",
                Url = "http://www.hobbyking.com/hobbyking/store/__67028__Quanum_MT_Series_4012_400KV_Brushless_Multirotor_Motor_Built_by_DYS.html",
                Price = 35.53,
                Kv = 400,
                Weight = 134,
                MaxCurrent = 16,
                MaxVoltage = 22,
                Shaft = 4,
                Length = 31,
                Diameter = 47,
                CanLength = 13,
                TotalLength = 38
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "LDPOWER MT1306-3100KV Brushless Multicopter Motor (CCW)",
                Url = "http://www.hobbyking.com/hobbyking/store/__86639__LDPOWER_MT1306_3100KV_Brushless_Multicopter_Motor_CCW_.html",
                Price = 12.90,
                Kv = 3100,
                Weight = 16,
                MaxCurrent = 14,
                MaxVoltage = 8,
                Shaft = 5,
                Length = 15,
                Diameter = 18,
                CanLength = 13,
                TotalLength = 26
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();
            context.ThrustDataPoints.AddOrUpdate(t => t.Id,
                    new ThrustDataPoint()
                    {
                        PropDiameter = 4,
                        MotorId = motor.Id,
                        PropPitch = 4.5,
                        Voltage = 7.4,
                        Current = 1.1,
                        Thrust = 37,
                    },
                    new ThrustDataPoint()
                    {
                        PropDiameter = 4,
                        MotorId = motor.Id,
                        PropPitch = 4.5,
                        Voltage = 7.4,
                        Current = 1.6,
                        Thrust = 57,
                    },
                    new ThrustDataPoint()
                    {
                        PropDiameter = 4,
                        MotorId = motor.Id,
                        PropPitch = 4.5,
                        Voltage = 7.4,
                        Current = 2.1,
                        Thrust = 73,
                    },
                    new ThrustDataPoint()
                    {
                        PropDiameter = 4,
                        MotorId = motor.Id,
                        PropPitch = 4.5,
                        Voltage = 7.4,
                        Current = 3,
                        Thrust = 98,
                    },
                    new ThrustDataPoint()
                    {
                        PropDiameter = 4,
                        MotorId = motor.Id,
                        PropPitch = 4.5,
                        Voltage = 7.4,
                        Current = 3.7,
                        Thrust = 120,
                    }
                );



            motor = new Motor()
            {
                Name = "QAV1806-2300KV Brushless Motor (CCW)",
                Url = "http://www.hobbyking.com/hobbyking/store/__107849__QAV1806_2300KV_Brushless_Motor_CCW_.html",
                Price = 7.80,
                Kv = 2300,
                Weight = 20,
                MaxCurrent = 12,
                MaxVoltage = 12,
                Shaft = 5,
                Length = 19,
                Diameter = 23,
                CanLength = 8,
                TotalLength = 30
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Quanum BE1806-2700kv Race Edition Brushless Motor 3~4S (CW)",
                Url = "http://www.hobbyking.com/hobbyking/store/__104751__Quanum_BE1806_2700kv_Race_Edition_Brushless_Motor_3_4S_CW_.html",
                Price = 11.89,
                Kv = 2700,
                Weight = 21,
                MaxCurrent = 18.2,
                MaxVoltage = 15,
                Length = 18,
                Diameter = 23,
                CanLength = 8,
                TotalLength = 23
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Quanum MT Series 2206 2000KV Brushless Multirotor Motor Built by DYS",
                Url = "http://www.hobbyking.com/hobbyking/store/__67013__Quanum_MT_Series_2206_2000KV_Brushless_Multirotor_Motor_Built_by_DYS.html",
                Price = 12.95,
                Kv = 2000,
                Weight = 32,
                MaxCurrent = 8,
                MaxVoltage = 11,
                Shaft = 2,
                Length = 20,
                Diameter = 28,
                CanLength = 8,
                TotalLength = 25
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "9225-160KV Turnigy Multistar Brushless Multi-Rotor Motor",
                Url = "http://www.hobbyking.com/hobbyking/store/__54886__9225_160KV_Turnigy_Multistar_Brushless_Multi_Rotor_Motor.html",
                Price = 159.04,
                Kv = 160,
                Weight = 339,
                MaxCurrent = 48,
                MaxVoltage = 35,
                Shaft = 12,
                Length = 28,
                Diameter = 92,
                CanLength = 12,
                TotalLength = 34
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Quanum MT Series 2208 1800KV Brushless Multirotor Motor Built by DYS",
                Url = "http://www.hobbyking.com/hobbyking/store/__67014__Quanum_MT_Series_2208_1800KV_Brushless_Multirotor_Motor_Built_by_DYS.html",
                Price = 15.93,
                Kv = 1800,
                Weight = 39,
                MaxCurrent = 13,
                MaxVoltage = 11,
                Length = 24,
                Diameter = 28,
                CanLength = 11,
                TotalLength = 28
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Quanum MT Series 2204 2300KV Brushless Multirotor Motor Built by DYS",
                Url = "http://www.hobbyking.com/hobbyking/store/__67012__Quanum_MT_Series_2204_2300KV_Brushless_Multirotor_Motor_Built_by_DYS.html",
                Price = 16.39,
                Kv = 2300,
                Weight = 25,
                MaxCurrent = 9,
                MaxVoltage = 8,
                Shaft = 2,
                Length = 17,
                Diameter = 28,
                CanLength = 6,
                TotalLength = 21
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Turnigy 4208 620kv Brushless Multi-Rotor Motor",
                Url = "http://www.hobbyking.com/hobbyking/store/__56936__Turnigy_4208_620kv_Brushless_Multi_Rotor_Motor.html",
                Price = 20.45,
                Kv = 620,
                Weight = 84,
                MaxCurrent = 25,
                MaxVoltage = 16,
                Shaft = 6,
                Length = 23,
                Diameter = 42,
                CanLength = 12,
                TotalLength = 30
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "KINGKONG 2204-2300KV Multi Copter Motor CCW",
                Url = "http://www.hobbyking.com/hobbyking/store/__91954__KINGKONG_2204_2300KV_Multi_Copter_Motor_CCW.html",
                Price = 8.16,
                Kv = 2300,
                Weight = 26,
                MaxCurrent = 0,
                MaxVoltage = 15,
                Shaft = 5,
                Length = 18,
                Diameter = 28,
                CanLength = 0,
                TotalLength = 31
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "4112-320KV Turnigy Multistar 22 Pole Brushless Multi-Rotor Motor With Extra Long Leads",
                Url = "http://www.hobbyking.com/hobbyking/store/__41626__4112_320KV_Turnigy_Multistar_22_Pole_Brushless_Multi_Rotor_Motor_With_Extra_Long_Leads.html",
                Price = 39.76,
                Kv = 320,
                Weight = 147,
                MaxCurrent = 20,
                MaxVoltage = 0,
                Shaft = 5,
                Length = 30,
                Diameter = 47,
                CanLength = 15,
                TotalLength = 40
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Quanum MT Series 3510 630KV Brushless Multirotor Motor Built by DYS",
                Url = "http://www.hobbyking.com/hobbyking/store/__67022__Quanum_MT_Series_3510_630KV_Brushless_Multirotor_Motor_Built_by_DYS.html",
                Price = 24.65,
                Kv = 630,
                Weight = 80,
                MaxCurrent = 26,
                MaxVoltage = 22,
                Shaft = 4,
                Length = 28,
                Diameter = 42,
                CanLength = 13,
                TotalLength = 35
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "QAV1806-2300KV Brushless Motor (CW)",
                Url = "http://www.hobbyking.com/hobbyking/store/__107843__QAV1806_2300KV_Brushless_Motor_CW_.html",
                Price = 7.80,
                Kv = 2300,
                Weight = 20,
                MaxCurrent = 12,
                MaxVoltage = 12,
                Shaft = 5,
                Length = 19,
                Diameter = 23,
                CanLength = 8,
                TotalLength = 30
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "DYS Brushless Motor (86x10)  BE8108-12 135KV for Multi-Rotors",
                Url = "http://www.hobbyking.com/hobbyking/store/__61432__DYS_Brushless_Motor_86x10_BE8108_12_135KV_for_Multi_Rotors.html",
                Price = 145.18,
                Kv = 135,
                Weight = 240,
                MaxCurrent = 16,
                MaxVoltage = 44,
                Shaft = 8,
                Length = 27,
                Diameter = 86,
                CanLength = 10,
                TotalLength = 27
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Quanum MT Series 3508 580KV Brushless Multirotor Motor Built by DYS",
                Url = "http://www.hobbyking.com/hobbyking/store/__67019__Quanum_MT_Series_3508_580KV_Brushless_Multirotor_Motor_Built_by_DYS.html",
                Price = 29.16,
                Kv = 580,
                Weight = 76,
                MaxCurrent = 20,
                MaxVoltage = 19,
                Shaft = 4,
                Length = 26,
                Diameter = 42,
                CanLength = 11,
                TotalLength = 33
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "4010-580KV Turnigy Multistar 22 Pole Brushless Multi-Rotor Motor With Extra Long Leads",
                Url = "http://www.hobbyking.com/hobbyking/store/__41620__4010_580KV_Turnigy_Multistar_22_Pole_Brushless_Multi_Rotor_Motor_With_Extra_Long_Leads.html",
                Price = 41.16,
                Kv = 580,
                Weight = 128,
                MaxCurrent = 32,
                MaxVoltage = 0,
                Shaft = 4,
                Length = 28,
                Diameter = 45,
                CanLength = 13,
                TotalLength = 39
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Turnigy Multistar 4230-400Kv 16Pole Multi-Rotor Outrunner",
                Url = "http://www.hobbyking.com/hobbyking/store/__36773__Turnigy_Multistar_4230_400Kv_16Pole_Multi_Rotor_Outrunner.html",
                Price = 40.18,
                Kv = 400,
                Weight = 138,
                MaxCurrent = 25,
                MaxVoltage = 15,
                Shaft = 5,
                Length = 32,
                Diameter = 42,
                CanLength = 17,
                TotalLength = 36
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Quanum MT Series 5208 360KV Brushless Multirotor Motor Built by DYS",
                Url = "http://www.hobbyking.com/hobbyking/store/__67037__Quanum_MT_Series_5208_360KV_Brushless_Multirotor_Motor_Built_by_DYS.html",
                Price = 29.48,
                Kv = 360,
                Weight = 178,
                MaxCurrent = 30,
                MaxVoltage = 22,
                Shaft = 4,
                Length = 28,
                Diameter = 63,
                CanLength = 10,
                TotalLength = 35
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Turnigy 9014 105kv Brushless Multi-Rotor Motor (BLDC)",
                Url = "http://www.hobbyking.com/hobbyking/store/__56935__Turnigy_9014_105kv_Brushless_Multi_Rotor_Motor_BLDC_.html",
                Price = 94.22,
                Kv = 105,
                Weight = 420,
                MaxCurrent = 0,
                MaxVoltage = 22,
                Shaft = 0,
                Length = 29,
                Diameter = 90,
                CanLength = 13,
                TotalLength = 29
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Emax PM1306-2800Kv Brushless Multi-Rotor Motor Set (CW/CW)",
                Url = "http://www.hobbyking.com/hobbyking/store/__69295__Emax_PM1306_2800Kv_Brushless_Multi_Rotor_Motor_Set_CW_CW_.html",
                Price = 12.95,
                Kv = 2800,
                Weight = 12.8,
                MaxCurrent = 0,
                MaxVoltage = 7,
                Shaft = 2,
                Length = 12,
                Diameter = 16,
                CanLength = 10,
                TotalLength = 30
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Turnigy Multistar 4220-650Kv 16Pole Multi-Rotor Outrunner",
                Url = "http://www.hobbyking.com/hobbyking/store/__38456__Turnigy_Multistar_4220_650Kv_16Pole_Multi_Rotor_Outrunner.html",
                Price = 23.30,
                Kv = 650,
                Weight = 65,
                MaxCurrent = 17,
                MaxVoltage = 15,
                Length = 21,
                Diameter = 42,
                CanLength = 14,
                TotalLength = 25
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Turnigy Multistar 2814-700Kv 14 Pole Multi-Rotor Outrunner V2",
                Url = "http://www.hobbyking.com/hobbyking/store/__66418__Turnigy_Multistar_2814_700Kv_14_Pole_Multi_Rotor_Outrunner_V2.html",
                Price = 28.13,
                Kv = 700,
                Weight = 102,
                MaxCurrent = 23,
                MaxVoltage = 15,
                Shaft = 4,
                Length = 35,
                Diameter = 35,
                CanLength = 17,
                TotalLength = 41
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "LDPOWER MT2213-920KV Brushless Multicopter Motor (CW)",
                Url = "http://www.hobbyking.com/hobbyking/store/__86646__LDPOWER_MT2213_920KV_Brushless_Multicopter_Motor_CW_.html",
                Price = 16.99,
                Kv = 920,
                Weight = 55.3,
                MaxCurrent = 18,
                MaxVoltage = 15,
                Shaft = 6,
                Length = 27,
                Diameter = 28,
                CanLength = 14,
                TotalLength = 41
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();
            context.ThrustDataPoints.AddOrUpdate(t => t.Id,
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 7.4,
                        PropDiameter = 10,
                        PropPitch = 3.3,
                        Current = 0.7,
                        Thrust = 66,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 7.4,
                        PropDiameter = 10,
                        PropPitch = 3.3,
                        Current = 2.5,
                        Thrust = 165,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 7.4,
                        PropDiameter = 10,
                        PropPitch = 3.3,
                        Current = 6.7,
                        Thrust = 345,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 7.4,
                        PropDiameter = 10,
                        PropPitch = 3.3,
                        Current = 6.8,
                        Thrust = 342,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 7.4,
                        PropDiameter = 11,
                        PropPitch = 3.7,
                        Current = 0.8,
                        Thrust = 80,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 7.4,
                        PropDiameter = 11,
                        PropPitch = 3.7,
                        Current = 2.7,
                        Thrust = 202,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 7.4,
                        PropDiameter = 11,
                        PropPitch = 3.7,
                        Current = 7.4,
                        Thrust = 430,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 7.4,
                        PropDiameter = 11,
                        PropPitch = 3.7,
                        Current = 7.4,
                        Thrust = 430,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 7.4,
                        PropDiameter = 12,
                        PropPitch = 4,
                        Current = 0.6,
                        Thrust = 83,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 7.4,
                        PropDiameter = 12,
                        PropPitch = 4,
                        Current = 3.1,
                        Thrust = 226,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 7.4,
                        PropDiameter = 12,
                        PropPitch = 4,
                        Current = 8.9,
                        Thrust = 496,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 7.4,
                        PropDiameter = 12,
                        PropPitch = 4,
                        Current = 9,
                        Thrust = 500,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 11.1,
                        PropDiameter = 10,
                        PropPitch = 3.3,
                        Current = 1.2,
                        Thrust = 124,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 11.1,
                        PropDiameter = 10,
                        PropPitch = 3.3,
                        Current = 4.4,
                        Thrust = 322,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 11.1,
                        PropDiameter = 10,
                        PropPitch = 3.3,
                        Current = 12.1,
                        Thrust = 640,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 11.1,
                        PropDiameter = 10,
                        PropPitch = 3.3,
                        Current = 12.2,
                        Thrust = 6451,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 11.1,
                        PropDiameter = 11,
                        PropPitch = 3.7,
                        Current = 1.3,
                        Thrust = 152,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 11.1,
                        PropDiameter = 11,
                        PropPitch = 3.7,
                        Current = 4.8,
                        Thrust = 385,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 11.1,
                        PropDiameter = 11,
                        PropPitch = 3.7,
                        Current = 12.9,
                        Thrust = 772,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 11.1,
                        PropDiameter = 11,
                        PropPitch = 3.7,
                        Current = 12.9,
                        Thrust = 772,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 11.1,
                        PropDiameter = 12,
                        PropPitch = 4,
                        Current = 1.4,
                        Thrust = 151,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 11.1,
                        PropDiameter = 12,
                        PropPitch = 4,
                        Current = 5.7,
                        Thrust = 438,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 11.1,
                        PropDiameter = 12,
                        PropPitch = 4,
                        Current = 15.2,
                        Thrust = 855,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 11.1,
                        PropDiameter = 12,
                        PropPitch = 4,
                        Current = 15.2,
                        Thrust = 855,
                    }
                );



            motor = new Motor()
            {
                Name = "9225-90KV Turnigy Multistar Brushless Multi-Rotor Motor",
                Url = "http://www.hobbyking.com/hobbyking/store/__54885__9225_90KV_Turnigy_Multistar_Brushless_Multi_Rotor_Motor.html",
                Price = 159.04,
                Kv = 90,
                Weight = 401,
                MaxCurrent = 36,
                MaxVoltage = 45,
                Length = 28,
                Diameter = 92,
                CanLength = 12,
                TotalLength = 43
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "DYS BE1806-2300kv Brushless Multirotor Motor 3S~4S",
                Url = "http://www.hobbyking.com/hobbyking/store/__61433__DYS_BE1806_2300kv_Brushless_Multirotor_Motor_3S_4S.html",
                Price = 7.99,
                Kv = 2300,
                Weight = 24,
                MaxCurrent = 8,
                MaxVoltage = 11,
                Shaft = 2,
                Length = 18,
                Diameter = 21,
                CanLength = 8,
                TotalLength = 21
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Black Widow 4110-350Kv With Built-In ESC CW/CCW",
                Url = "http://www.hobbyking.com/hobbyking/store/__82882__Black_Widow_4110_350Kv_With_Built_In_ESC_CW_CCW.html",
                Price = 40.20,
                Kv = 350,
                Weight = 196,
                MaxCurrent = 40,
                MaxVoltage = 23,
                Shaft = 4,
                Length = 38,
                Diameter = 47,
                CanLength = 12,
                TotalLength = 44
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "DYS 1306-2300KV BX Series Set of Two CW/CCW Motors",
                Url = "http://www.hobbyking.com/hobbyking/store/__66402__DYS_1306_2300KV_BX_Series_Set_of_Two_CW_CCW_Motors.html",
                Price = 19.66,
                Kv = 2300,
                Weight = 13,
                MaxCurrent = 8,
                MaxVoltage = 12,
                Shaft = 5,
                Length = 15,
                Diameter = 18,
                CanLength = 6,
                TotalLength = 26
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "LDPOWER MT2206-1900KV Brushless Multicopter Motor (CW)",
                Url = "http://www.hobbyking.com/hobbyking/store/__86644__LDPOWER_MT2206_1900KV_Brushless_Multicopter_Motor_CW_.html",
                Price = 9.34,
                Kv = 1900,
                Weight = 34.7,
                MaxCurrent = 25.7,
                MaxVoltage = 12,
                Shaft = 5,
                Length = 17,
                Diameter = 28,
                CanLength = 8,
                TotalLength = 30
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();
            context.ThrustDataPoints.AddOrUpdate(t => t.Id,
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 7.4,
                        PropDiameter = 6,
                        PropPitch = 3,
                        Current = 1.8,
                        Thrust = 85,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 7.4,
                        PropDiameter = 6,
                        PropPitch = 3,
                        Current = 2.7,
                        Thrust = 123,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 7.4,
                        PropDiameter = 6,
                        PropPitch = 3,
                        Current = 3.9,
                        Thrust = 171,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 7.4,
                        PropDiameter = 6,
                        PropPitch = 3,
                        Current = 5.3,
                        Thrust = 228,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 7.4,
                        PropDiameter = 6,
                        PropPitch = 4.5,
                        Current = 2.5,
                        Thrust = 115,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 7.4,
                        PropDiameter = 6,
                        PropPitch = 4.5,
                        Current = 3.7,
                        Thrust = 164,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 7.4,
                        PropDiameter = 6,
                        PropPitch = 4.5,
                        Current = 6,
                        Thrust = 240,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 7.4,
                        PropDiameter = 6,
                        PropPitch = 4.5,
                        Current = 9.2,
                        Thrust = 335,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 11.1,
                        PropDiameter = 6,
                        PropPitch = 3,
                        Current = 3.1,
                        Thrust = 180,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 11.1,
                        PropDiameter = 6,
                        PropPitch = 3,
                        Current = 4.6,
                        Thrust = 249,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 11.1,
                        PropDiameter = 6,
                        PropPitch = 3,
                        Current = 6.9,
                        Thrust = 350,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 11.1,
                        PropDiameter = 6,
                        PropPitch = 3,
                        Current = 10.3,
                        Thrust = 480,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 11.1,
                        PropDiameter = 6,
                        PropPitch = 4.5,
                        Current = 3.8,
                        Thrust = 210,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 11.1,
                        PropDiameter = 6,
                        PropPitch = 4.5,
                        Current = 5.8,
                        Thrust = 292,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 11.1,
                        PropDiameter = 6,
                        PropPitch = 4.5,
                        Current = 10.1,
                        Thrust = 430,
                    },
                    new ThrustDataPoint()
                    {
                        MotorId = motor.Id,
                        Voltage = 11.1,
                        PropDiameter = 6,
                        PropPitch = 4.5,
                        Current = 16.2,
                        Thrust = 594,
                    }
                );



            motor = new Motor()
            {
                Name = "Quanum BE1806-2300kv Race Edition Brushless Motor 3~4S (CW)",
                Url = "http://www.hobbyking.com/hobbyking/store/__104737__Quanum_BE1806_2300kv_Race_Edition_Brushless_Motor_3_4S_CW_.html",
                Price = 10.69,
                Kv = 2300,
                Weight = 21,
                MaxCurrent = 13.6,
                MaxVoltage = 15,
                Length = 18,
                Diameter = 23,
                CanLength = 8,
                TotalLength = 23
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "QAV RT2206-2000KV Quad Racing Motor (CW)",
                Url = "http://www.hobbyking.com/hobbyking/store/__100597__QAV_RT2206_2000KV_Quad_Racing_Motor_CW_.html",
                Price = 12.75,
                Kv = 2000,
                Weight = 29.1,
                MaxCurrent = 25,
                MaxVoltage = 12,
                Shaft = 5,
                Length = 18,
                Diameter = 28,
                CanLength = 8,
                TotalLength = 30
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Multistar Elite 5008-330KV Multi-Rotor Motor",
                Url = "http://www.hobbyking.com/hobbyking/store/__74761__Multistar_Elite_5008_330KV_Multi_Rotor_Motor.html",
                Price = 53.48,
                Kv = 330,
                Weight = 183,
                MaxCurrent = 0.3,
                MaxVoltage = 22,
                Shaft = 4,
                Length = 27,
                Diameter = 57,
                CanLength = 10,
                TotalLength = 35
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Multistar Elite 3508-268KV High Voltage Endurance Motor",
                Url = "http://www.hobbyking.com/hobbyking/store/__63642__Multistar_Elite_3508_268KV_High_Voltage_Endurance_Motor.html",
                Price = 34.99,
                Kv = 268,
                Weight = 83,
                MaxCurrent = 12,
                MaxVoltage = 35,
                Shaft = 4,
                Length = 21,
                Diameter = 42,
                CanLength = 10,
                TotalLength = 31
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Multistar Elite 2306-2150KV 'MINI MONSTER' Quad Racing Motor (CCW)",
                Url = "http://www.hobbyking.com/hobbyking/store/__80476__Multistar_Elite_2306_2150KV_39_MINI_MONSTER_39_Quad_Racing_Motor_CCW_.html",
                Price = 16.09,
                Kv = 2150,
                Weight = 37.5,
                MaxCurrent = 20,
                MaxVoltage = 0,
                Length = 0,
                Diameter = 0,
                CanLength = 0,
                TotalLength = 0
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "4114-320KV Turnigy Multistar Multi-Rotor Motor With 3.5mm Bullet Connector",
                Url = "http://www.hobbyking.com/hobbyking/store/__45281__4114_320KV_Turnigy_Multistar_Multi_Rotor_Motor_With_3_5mm_Bullet_Connector.html",
                Price = 37.94,
                Kv = 320,
                Weight = 148,
                MaxCurrent = 30,
                MaxVoltage = 22,
                Shaft = 4,
                Length = 31,
                Diameter = 46,
                CanLength = 16,
                TotalLength = 38
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "AX-2810Q-750KV Brushless Quadcopter Motor",
                Url = "http://www.hobbyking.com/hobbyking/store/__25556__AX_2810Q_750KV_Brushless_Quadcopter_Motor.html",
                Price = 19.73,
                Kv = 750,
                Weight = 70,
                MaxCurrent = 30,
                MaxVoltage = 15,
                Shaft = 4,
                Length = 26,
                Diameter = 35,
                CanLength = 14,
                TotalLength = 46
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Quanum MT Series 2212 1000KV Brushless Multirotor Motor Built by DYS",
                Url = "http://www.hobbyking.com/hobbyking/store/__67015__Quanum_MT_Series_2212_1000KV_Brushless_Multirotor_Motor_Built_by_DYS.html",
                Price = 15.68,
                Kv = 1000,
                Weight = 51,
                MaxCurrent = 18,
                MaxVoltage = 15,
                Length = 28,
                Diameter = 28,
                CanLength = 14,
                TotalLength = 32
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Turnigy Multistar 2834-800Kv 14Pole Multi-Rotor Outrunner",
                Url = "http://www.hobbyking.com/hobbyking/store/__39039__Turnigy_Multistar_2834_800Kv_14Pole_Multi_Rotor_Outrunner.html",
                Price = 33.40,
                Kv = 800,
                Weight = 195,
                MaxCurrent = 45,
                MaxVoltage = 15,
                Shaft = 0,
                Length = 56,
                Diameter = 35,
                CanLength = 37,
                TotalLength = 56
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Turnigy Multistar 4225-610Kv 16Pole Multi-Rotor Outrunner",
                Url = "http://www.hobbyking.com/hobbyking/store/__26964__Turnigy_Multistar_4225_610Kv_16Pole_Multi_Rotor_Outrunner.html",
                Price = 29.99,
                Kv = 610,
                Weight = 86,
                MaxCurrent = 22,
                MaxVoltage = 15,
                Length = 25,
                Diameter = 42,
                CanLength = 10,
                TotalLength = 28
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Multistar Elite 4114 330KV With Built In Folding Prop Adapter, EZO Bearings",
                Url = "http://www.hobbyking.com/hobbyking/store/__74760__Multistar_Elite_4114_330KV_With_Built_In_Folding_Prop_Adapter_EZO_Bearings.html",
                Price = 54.66,
                Kv = 330,
                Weight = 152,
                MaxCurrent = 22.5,
                MaxVoltage = 26,
                Shaft = 5,
                Length = 31,
                Diameter = 46,
                CanLength = 16,
                TotalLength = 38
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "QAV2206-2200KV Brushless Motor (CW)",
                Url = "http://www.hobbyking.com/hobbyking/store/__107855__QAV2206_2200KV_Brushless_Motor_CW_.html",
                Price = 9.75,
                Kv = 2200,
                Weight = 29,
                MaxCurrent = 16,
                MaxVoltage = 15,
                Shaft = 5,
                Length = 19,
                Diameter = 28,
                CanLength = 8,
                TotalLength = 30
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Quanum MT Series 5206 320KV Brushless Multirotor Motor Built by DYS",
                Url = "http://www.hobbyking.com/hobbyking/store/__67035__Quanum_MT_Series_5206_320KV_Brushless_Multirotor_Motor_Built_by_DYS.html",
                Price = 32.76,
                Kv = 320,
                Weight = 131,
                MaxCurrent = 17,
                MaxVoltage = 22,
                Shaft = 4,
                Length = 25,
                Diameter = 63,
                CanLength = 8,
                TotalLength = 31
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "LDPOWER Racing series 2206-2200KV CCW",
                Url = "http://www.hobbyking.com/hobbyking/store/__100157__LDPOWER_Racing_series_2206_2200KV_CCW.html",
                Price = 9.99,
                Kv = 2200,
                Weight = 30,
                MaxCurrent = 27,
                MaxVoltage = 0,
                Length = 17,
                Diameter = 28,
                CanLength = 13,
                TotalLength = 32
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "Black Widow 4110-400Kv With Built-In ESC CW/CCW",
                Url = "http://www.hobbyking.com/hobbyking/store/__82883__Black_Widow_4110_400Kv_With_Built_In_ESC_CW_CCW.html",
                Price = 53.48,
                Kv = 400,
                Weight = 196,
                MaxCurrent = 40,
                MaxVoltage = 23,
                Shaft = 4,
                Length = 38,
                Diameter = 47,
                CanLength = 12,
                TotalLength = 44
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            motor = new Motor()
            {
                Name = "4108-480KV Turnigy Multistar 22 Pole Brushless Multi-Rotor Motor With Extra Long Leads",
                Url = "http://www.hobbyking.com/hobbyking/store/__41624__4108_480KV_Turnigy_Multistar_22_Pole_Brushless_Multi_Rotor_Motor_With_Extra_Long_Leads.html",
                Price = 31.86,
                Kv = 480,
                Weight = 111,
                MaxCurrent = 22,
                MaxVoltage = 0,
                Shaft = 4,
                Length = 26,
                Diameter = 27,
                CanLength = 12,
                TotalLength = 36
            };
            context.Motors.AddOrUpdate(m => m.Id, motor);
            context.SaveChanges();


            // seed batteries
            context.Batteries.AddOrUpdate(x => x.Id,
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__7565__ZIPPY_50mAh_20C_single_cell.html",
                    Capacity = 50,
                    Weight = 2,
                    Length = 19,
                    Height = 14,
                    Width = 5,
                    Price = 2.60,
                    Config = 1,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "ZIPPY 50mAh 20C single cell"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__7566__ZIPPY_70mAh_20C_Single_Cell.html",
                    Capacity = 70,
                    Weight = 2,
                    Length = 18,
                    Height = 14,
                    Width = 6,
                    Price = 2.14,
                    Config = 1,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "ZIPPY 70mAh 20C Single Cell"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__23310__Turnigy_nano_tech_90mah_1S_15C_Round_Cell.html",
                    Capacity = 90,
                    Weight = 3,
                    Length = 36,
                    Height = 6,
                    Width = 6,
                    Price = 0.99,
                    Config = 1,
                    MaxDischarge = 15,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 90mah 1S 15C Round Cell"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__11857__Turnigy_nano_tech_130mah_1S_25_40C_Lipo_Pack_Kyosho_Eflite_Parkzone_.html",
                    Capacity = 130,
                    Weight = 4,
                    Length = 39,
                    Height = 12,
                    Width = 7,
                    Price = 1.34,
                    Config = 1,
                    MaxDischarge = 25,
                    MaxCharge = 10,
                    Name = "Turnigy nano-tech 130mah 1S 25~40C Lipo Pack (Kyosho, Eflite, Parkzone)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__14890__Nine_Eagles_replacement_High_Cap_150mAh_1S_LiPo.html",
                    Capacity = 150,
                    Weight = 4,
                    Length = 39,
                    Height = 12,
                    Width = 6,
                    Price = 0.64,
                    Config = 1,
                    MaxDischarge = 10,
                    MaxCharge = 5,
                    Name = "Nine Eagles replacement High-Cap 150mAh 1S LiPo"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__11893__Turnigy_nano_tech_160mah_1S_25_40C_Lipo.html",
                    Capacity = 160,
                    Weight = 5,
                    Length = 39,
                    Height = 12,
                    Width = 8,
                    Price = 1.49,
                    Config = 1,
                    MaxDischarge = 25,
                    MaxCharge = 10,
                    Name = "Turnigy nano-tech 160mah 1S 25~40C Lipo"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__19419__Turnigy_nano_tech_160mah_1S_25_40C_Lipo_Pack_Fits_Align_Trex_100_.html",
                    Capacity = 160,
                    Weight = 4,
                    Length = 39,
                    Height = 7,
                    Width = 11,
                    Price = 1.17,
                    Config = 1,
                    MaxDischarge = 25,
                    MaxCharge = 10,
                    Name = "Turnigy nano-tech 160mah 1S 25~40C Lipo Pack (Fits Align Trex 100)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__19418__Turnigy_nano_tech_160mah_1S_25C_Lipo_Pack_NE_Style_T1_Single_Rail_for_2010plus_.html",
                    Capacity = 160,
                    Weight = 5,
                    Length = 46,
                    Height = 6,
                    Width = 11,
                    Price = 0.90,
                    Config = 1,
                    MaxDischarge = 25,
                    MaxCharge = 10,
                    Name = "Turnigy nano-tech 160mah 1S 25C Lipo Pack (NE Style - T1 Single Rail for 2010plus)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__23314__Turnigy_nano_tech_180mAh_1S_15c_Round_Cell.html",
                    Capacity = 180,
                    Weight = 4,
                    Length = 38,
                    Height = 8,
                    Width = 8,
                    Price = 1.20,
                    Config = 1,
                    MaxDischarge = 15,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 180mAh 1S 15c Round Cell"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__23339__Turnigy_nano_tech_180mah_3S_25_40C_Lipo_Pack.html",
                    Capacity = 180,
                    Weight = 19,
                    Length = 35,
                    Height = 20,
                    Width = 15,
                    Price = 6.25,
                    Config = 3,
                    MaxDischarge = 25,
                    MaxCharge = 2,
                    Name = "Turnigy nano-tech 180mah 3S 25~40C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__23135__Turnigy_nano_tech_180mah_2S_25_40C_Lipo_Pack.html",
                    Capacity = 180,
                    Weight = 13,
                    Length = 35,
                    Height = 20,
                    Width = 10,
                    Price = 4.19,
                    Config = 2,
                    MaxDischarge = 25,
                    MaxCharge = 2,
                    Name = "Turnigy nano-tech 180mah 2S 25~40C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__89386__Turnigy_nano_tech_180mAh_2S_25C_LiPoly_Pack_Compatible_LOSB0863_.html",
                    Capacity = 180,
                    Weight = 12,
                    Length = 35.5,
                    Height = 21,
                    Width = 11,
                    Price = 4.99,
                    Config = 2,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 180mAh 2S 25C LiPoly Pack (Compatible LOSB0863)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__19423__Turnigy_nano_tech_180mAh_2S_25C_Lipo_Pack_E_flite_Compatible_EFLB1802S20_.html",
                    Capacity = 180,
                    Weight = 12,
                    Length = 34,
                    Height = 10,
                    Width = 21,
                    Price = 4.99,
                    Config = 2,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 180mAh 2S 25C Lipo Pack (E-flite Compatible EFLB1802S20)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__76879__Turnigy_Nano_Tech_200mah_1S_35_70C_LiPoly_Battery.html",
                    Capacity = 200,
                    Weight = 5,
                    Length = 47,
                    Height = 13,
                    Width = 8,
                    Price = 3.84,
                    Config = 1,
                    MaxDischarge = 35,
                    MaxCharge = 2,
                    Name = "Turnigy Nano-Tech 200mah 1S 35~70C LiPoly Battery"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__23313__Turnigy_nano_tech_200mah_1S_15C_Round_Lipo.html",
                    Capacity = 200,
                    Weight = 5,
                    Length = 52,
                    Height = 7,
                    Width = 7,
                    Price = 0.99,
                    Config = 1,
                    MaxDischarge = 15,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 200mah 1S 15C Round Lipo"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__11870__ZIPPY_240mAh_30C_Single_Cell.html",
                    Capacity = 240,
                    Weight = 10,
                    Length = 63,
                    Height = 26,
                    Width = 3,
                    Price = 3.05,
                    Config = 1,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "ZIPPY 240mAh 30C Single Cell"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__7568__ZIPPY_240mAh_20C_Single_Cell.html",
                    Capacity = 240,
                    Weight = 6,
                    Length = 24,
                    Height = 19,
                    Width = 5,
                    Price = 1.78,
                    Config = 1,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "ZIPPY 240mAh 20C Single Cell"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__26742__Turnigy_nano_tech_260mah_2S_35_70C_Lipo_Pack.html",
                    Capacity = 260,
                    Weight = 16,
                    Length = 33,
                    Height = 20,
                    Width = 14,
                    Price = 4.99,
                    Config = 2,
                    MaxDischarge = 35,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 260mah 2S 35~70C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__24920__Turnigy_nano_tech_260mAh_1S_35_70C_Lipo_Pack_QR_Ladybird_Genius_CP_Mini_CP_.html",
                    Capacity = 260,
                    Weight = 8,
                    Length = 32,
                    Height = 20,
                    Width = 7,
                    Price = 2.99,
                    Config = 1,
                    MaxDischarge = 35,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 260mAh 1S 35-70C Lipo Pack (QR Ladybird/Genius CP/Mini CP)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__26741__Turnigy_nano_tech_260mah_2S_35_70C_Lipo_Pack_E_flite_Compatible_EFLB2002S25_.html",
                    Capacity = 260,
                    Weight = 14,
                    Length = 33,
                    Height = 20,
                    Width = 14,
                    Price = 4.99,
                    Config = 2,
                    MaxDischarge = 35,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 260mah 2S 35~70C Lipo Pack (E-flite Compatible EFLB2002S25)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__23315__Turnigy_nano_tech_270mah_1S_15C_Round_Cell.html",
                    Capacity = 270,
                    Weight = 6,
                    Length = 56,
                    Height = 8,
                    Width = 8,
                    Price = 1.20,
                    Config = 1,
                    MaxDischarge = 15,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 270mah 1S 15C Round Cell"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__22906__Turnigy_nano_tech_300mah_2S_35_70C_Lipo_Pack.html",
                    Capacity = 300,
                    Weight = 17,
                    Length = 44,
                    Height = 17,
                    Width = 12,
                    Price = 4.38,
                    Config = 2,
                    MaxDischarge = 35,
                    MaxCharge = 2,
                    Name = "Turnigy nano-tech 300mah 2S 35~70C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__28444__Turnigy_nano_tech_300mah_2S_35_70C_Lipo_Pack_E_flite_EFLB2002S25_micro_series_compatible_.html",
                    Capacity = 300,
                    Weight = 16,
                    Length = 44,
                    Height = 18,
                    Width = 12,
                    Price = 5.89,
                    Config = 2,
                    MaxDischarge = 35,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 300mah 2S 35~70C Lipo Pack (E-flite EFLB2002S25 micro series compatible)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__26738__Turnigy_nano_tech_300mah_1S_45_90C_Lipo_Pack_Fits_Nine_Eagles_Solo_Pro_100_.html",
                    Capacity = 300,
                    Weight = 9,
                    Length = 43,
                    Height = 17,
                    Width = 6,
                    Price = 2.77,
                    Config = 1,
                    MaxDischarge = 45,
                    MaxCharge = 2,
                    Name = "Turnigy nano-tech 300mah 1S 45~90C Lipo Pack (Fits Nine Eagles Solo-Pro 100)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__88955__Turnigy_nano_tech_300mAh_1S_20_40C_Lipo_Pack_Losi_Mini_Compatible_.html",
                    Capacity = 300,
                    Weight = 8,
                    Length = 34,
                    Height = 20,
                    Width = 8,
                    Price = 1.99,
                    Config = 1,
                    MaxDischarge = 20,
                    MaxCharge = 1,
                    Name = "Turnigy nano-tech 300mAh 1S 20~40C Lipo Pack (Losi Mini Compatible)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__17808__Turnigy_nano_tech_300mah_1S_35c_Lipo_Pack_Suits_FBL100_and_Blade_mCPx_.html",
                    Capacity = 300,
                    Weight = 7,
                    Length = 48,
                    Height = 19,
                    Width = 7,
                    Price = 3.99,
                    Config = 1,
                    MaxDischarge = 35,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 300mah 1S 35c Lipo Pack (Suits FBL100 and Blade mCPx)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__26739__Turnigy_nano_tech_300mah_2S_45_90C_Lipo_Pack.html",
                    Capacity = 300,
                    Weight = 19,
                    Length = 45,
                    Height = 17,
                    Width = 12,
                    Price = 5.40,
                    Config = 2,
                    MaxDischarge = 45,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 300mah 2S 45~90C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__26736__Turnigy_nano_tech_300mah_1S_45C_Lipo_Pack_Suits_FBL100_and_Blade_mCPx_.html",
                    Capacity = 300,
                    Weight = 8,
                    Length = 44,
                    Height = 6,
                    Width = 17,
                    Price = 4.49,
                    Config = 1,
                    MaxDischarge = 45,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 300mah 1S 45C Lipo Pack (Suits FBL100 and Blade mCPx)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__19116__Turnigy_nano_tech_350mah_1S_65_130C_Lipo_Pack.html",
                    Capacity = 350,
                    Weight = 15,
                    Length = 52,
                    Height = 30,
                    Width = 5,
                    Price = 4.41,
                    Config = 1,
                    MaxDischarge = 65,
                    MaxCharge = 8,
                    Name = "Turnigy nano-tech 350mah 1S 65~130C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9028__ZIPPY_Flightmax_350mAh_2S_20C.html",
                    Capacity = 350,
                    Weight = 21,
                    Length = 40,
                    Height = 20,
                    Width = 15,
                    Price = 3.98,
                    Config = 2,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "ZIPPY Flightmax 350mAh 2S 20C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__11895__Turnigy_nano_tech_370mah_3S_25_40C_Lipo_Pack.html",
                    Capacity = 370,
                    Weight = 39,
                    Length = 60,
                    Height = 31,
                    Width = 13,
                    Price = 5.85,
                    Config = 3,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 370mah 3S 25~40C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__11894__Turnigy_nano_tech_370mah_2S_25_40C_Lipo_Pack.html",
                    Capacity = 370,
                    Weight = 27,
                    Length = 63,
                    Height = 32,
                    Width = 9,
                    Price = 3.88,
                    Config = 2,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 370mah 2S 25~40C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__7570__ZIPPY_400mAh_20C_Single_Cell.html",
                    Capacity = 400,
                    Weight = 10,
                    Length = 39,
                    Height = 23,
                    Width = 7,
                    Price = 2.42,
                    Config = 1,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "ZIPPY 400mAh 20C Single Cell"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__64210__Turnigy_nano_tech_450mAh_3S_65C_Lipo_E_flite_Compatible_Blade_180CFX_EFLB4503SJ30_.html",
                    Capacity = 450,
                    Weight = 40,
                    Length = 49,
                    Height = 28.5,
                    Width = 16,
                    Price = 7.99,
                    Config = 3,
                    MaxDischarge = 65,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 450mAh 3S 65C Lipo (E-flite Compatible Blade 180CFX EFLB4503SJ30)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__7571__ZIPPY_450mAh_20C_single_cell.html",
                    Capacity = 450,
                    Weight = 13,
                    Length = 49,
                    Height = 30,
                    Width = 5,
                    Price = 2.39,
                    Config = 1,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "ZIPPY 450mAh 20C single cell"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__26734__Turnigy_nano_tech_450mAh_2S_65C_Lipo_E_flite_Compatible_Blade_130X_EFLB3002S35_.html",
                    Capacity = 450,
                    Weight = 26,
                    Length = 48,
                    Height = 29,
                    Width = 11,
                    Price = 7.99,
                    Config = 2,
                    MaxDischarge = 65,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 450mAh 2S 65C Lipo (E-flite Compatible - Blade 130X EFLB3002S35)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__11897__Turnigy_nano_tech_460mah_3S_25_40C_Lipo_Pack.html",
                    Capacity = 460,
                    Weight = 45,
                    Length = 67,
                    Height = 30,
                    Width = 15,
                    Price = 6.45,
                    Config = 3,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 460mah 3S 25~40C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__11896__Turnigy_nano_tech_460mah_2S_25_40C_Lipo_Pack.html",
                    Capacity = 460,
                    Weight = 31,
                    Length = 55,
                    Height = 30,
                    Width = 10,
                    Price = 4.36,
                    Config = 2,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 460mah 2S 25~40C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__87953__Turnigy_Bolt_500mAh_3S_11_4V_65_130C_High_Voltage_Lipoly_Pack_LiHV_.html",
                    Capacity = 500,
                    Weight = 47,
                    Length = 56,
                    Height = 30,
                    Width = 16,
                    Price = 12.05,
                    Config = 3,
                    MaxDischarge = 65,
                    MaxCharge = 2,
                    Name = "Turnigy Bolt 500mAh 3S 11.4V 65~130C High Voltage Lipoly Pack (LiHV)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9275__Turnigy_500mAh_3S_20C_Lipo_Pack.html",
                    Capacity = 500,
                    Weight = 49,
                    Length = 56,
                    Height = 30,
                    Width = 19,
                    Price = 6.64,
                    Config = 3,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "Turnigy 500mAh 3S 20C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__25505__ZIPPY_Compact_500mAh_3S_35C_Lipo_Pack.html",
                    Capacity = 500,
                    Weight = 49,
                    Length = 56,
                    Height = 31,
                    Width = 19,
                    Price = 9.09,
                    Config = 3,
                    MaxDischarge = 35,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 500mAh 3S 35C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__88962__Turnigy_nano_tech_500mAh_1S_25_50C_Lipo_Pack_Losi_Mini_Compatible_.html",
                    Capacity = 500,
                    Weight = 15,
                    Length = 39,
                    Height = 25,
                    Width = 9,
                    Price = 3.49,
                    Config = 1,
                    MaxDischarge = 25,
                    MaxCharge = 1,
                    Name = "Turnigy nano-tech 500mAh 1S 25~50C Lipo Pack (Losi Mini Compatible)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__101320__Turnigy_Graphene_500mAh_4S_65C_Lipo_Pack_Short_lead_.html",
                    Capacity = 500,
                    Weight = 74,
                    Length = 56,
                    Height = 31,
                    Width = 29,
                    Price = 23.23,
                    Config = 4,
                    MaxDischarge = 65,
                    MaxCharge = 10,
                    Name = "Turnigy Graphene 500mAh 4S 65C Lipo Pack (Short lead)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__87947__Turnigy_Bolt_500mAh_2S_7_6V_65_130C_High_Voltage_Lipoly_Pack_LiHV_.html",
                    Capacity = 500,
                    Weight = 33,
                    Length = 55,
                    Height = 30,
                    Width = 11,
                    Price = 6.17,
                    Config = 2,
                    MaxDischarge = 65,
                    MaxCharge = 2,
                    Name = "Turnigy Bolt 500mAh 2S 7.6V 65~130C High Voltage Lipoly Pack (LiHV)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__101319__Turnigy_Graphene_500mah_3S_65C_Lipo_Pack_Short_Lead_.html",
                    Capacity = 500,
                    Weight = 58,
                    Length = 56,
                    Height = 31,
                    Width = 22,
                    Price = 17.25,
                    Config = 3,
                    MaxDischarge = 65,
                    MaxCharge = 10,
                    Name = "Turnigy Graphene 500mah 3S 65C Lipo Pack (Short Lead)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9187__Turnigy_500mAh_2S_20C_Lipo_Pack.html",
                    Capacity = 500,
                    Weight = 36,
                    Length = 55,
                    Height = 30,
                    Width = 14,
                    Price = 4.77,
                    Config = 2,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "Turnigy 500mAh 2S 20C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__20385__Turnigy_nano_tech_600mah_1S_35_70C_Lipo_Nine_Eagles_Solo_Pro_328_Eflite_MQX_120SR_.html",
                    Capacity = 600,
                    Weight = 16,
                    Length = 79,
                    Height = 7,
                    Width = 19,
                    Price = 2.94,
                    Config = 1,
                    MaxDischarge = 35,
                    MaxCharge = 2,
                    Name = "Turnigy nano-tech 600mah 1S 35~70C Lipo (Nine Eagles Solo Pro 328, Eflite MQX, 120SR)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__90416__Turnigy_Graphene_600mAh_1S_LiPo_Pack_w_JST.html",
                    Capacity = 600,
                    Weight = 15,
                    Length = 60,
                    Height = 20,
                    Width = 9,
                    Price = 6.78,
                    Config = 1,
                    MaxDischarge = 65,
                    MaxCharge = 10,
                    Name = "Turnigy Graphene 600mAh 1S LiPo Pack w/JST"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__35300__Walkera_600mAh_1S_20C_Lipo_Battery_Pack_Suits_QR_Infra_X_V120D02S_.html",
                    Capacity = 600,
                    Weight = 18,
                    Length = 42,
                    Height = 24,
                    Width = 10,
                    Price = 4.29,
                    Config = 1,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "Walkera 600mAh 1S 20C Lipo Battery Pack (Suits QR Infra X, V120D02S)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__7305__Rhino_610mAh_2S_7_4v_20C_Lipoly_Pack.html",
                    Capacity = 610,
                    Weight = 40,
                    Length = 56,
                    Height = 30,
                    Width = 15,
                    Price = 4.82,
                    Config = 2,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "Rhino 610mAh 2S 7.4v 20C Lipoly Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__92448__Turnigy_700mAh_3S_60C_Lipo_Pack_XT30_.html",
                    Capacity = 700,
                    Weight = 80,
                    Length = 73,
                    Height = 35,
                    Width = 18,
                    Price = 8.06,
                    Config = 3,
                    MaxDischarge = 60,
                    MaxCharge = 3,
                    Name = "Turnigy 700mAh 3S 60C Lipo Pack (XT30)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__92447__Turnigy_700mAh_3S_30C_Lipo_Pack_XT30_.html",
                    Capacity = 700,
                    Weight = 77,
                    Length = 73,
                    Height = 35,
                    Width = 17,
                    Price = 6.08,
                    Config = 3,
                    MaxDischarge = 30,
                    MaxCharge = 3,
                    Name = "Turnigy 700mAh 3S 30C Lipo Pack (XT30)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__7573__ZIPPY_740mAh_20C_Single_Cell.html",
                    Capacity = 740,
                    Weight = 20,
                    Length = 64,
                    Height = 35,
                    Width = 5,
                    Price = 1.99,
                    Config = 1,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "ZIPPY 740mAh 20C Single Cell"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__90417__Turnigy_Graphene_750mAh_1S_Lipo_Pack_w_2pin_Molex_Connector.html",
                    Capacity = 750,
                    Weight = 18,
                    Length = 45,
                    Height = 25,
                    Width = 10,
                    Price = 6.32,
                    Config = 1,
                    MaxDischarge = 65,
                    MaxCharge = 10,
                    Name = "Turnigy Graphene 750mAh 1S Lipo Pack w/ 2pin Molex Connector"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__20386__Turnigy_nano_tech_750mah_1S_35_70C_Lipo_Pack_Fits_Nine_Eagles_Solo_Pro_180_.html",
                    Capacity = 750,
                    Weight = 18,
                    Length = 43,
                    Height = 24,
                    Width = 9,
                    Price = 3.10,
                    Config = 1,
                    MaxDischarge = 35,
                    MaxCharge = 2,
                    Name = "Turnigy nano-tech 750mah 1S 35~70C Lipo Pack (Fits Nine Eagles Solo-Pro 180)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__90418__Turnigy_Graphene_750mAh_LiPo_Pack_1S_w_JST_SYP_2P.html",
                    Capacity = 750,
                    Weight = 19,
                    Length = 45,
                    Height = 25,
                    Width = 10,
                    Price = 6.32,
                    Config = 1,
                    MaxDischarge = 65,
                    MaxCharge = 10,
                    Name = "Turnigy Graphene 750mAh LiPo Pack 1S w/ JST-SYP-2P"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__41271__Turnigy_nano_tech_750mAh_1S_35_70C_Lipo_Pack_Walkera_V120D02S_QR_Infra_X_QR_W100S_.html",
                    Capacity = 750,
                    Weight = 20,
                    Length = 43,
                    Height = 24,
                    Width = 10,
                    Price = 2.99,
                    Config = 1,
                    MaxDischarge = 35,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 750mAh 1S 35-70C Lipo Pack (Walkera V120D02S/QR Infra X/QR W100S)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__101322__Turnigy_Graphene_750mah_4S_65C_Lipo_Pack_Short_Lead_.html",
                    Capacity = 750,
                    Weight = 113,
                    Length = 74,
                    Height = 36,
                    Width = 23,
                    Price = 23.51,
                    Config = 4,
                    MaxDischarge = 65,
                    MaxCharge = 10,
                    Name = "Turnigy Graphene 750mah 4S 65C Lipo Pack (Short Lead)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__101321__Turnigy_Graphene_750mAh_3S_65C_Lipo_Pack_Short_lead_.html",
                    Capacity = 750,
                    Weight = 84,
                    Length = 74,
                    Height = 36,
                    Width = 18,
                    Price = 18.47,
                    Config = 3,
                    MaxDischarge = 65,
                    MaxCharge = 10,
                    Name = "Turnigy Graphene 750mAh 3S 65C Lipo Pack (Short lead)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__18846__Turnigy_800mAh_2S_30C_Lipo_Pack.html",
                    Capacity = 800,
                    Weight = 59,
                    Length = 55,
                    Height = 30,
                    Width = 18,
                    Price = 6.67,
                    Config = 2,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "Turnigy 800mAh 2S 30C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__92327__Turnigy_14500_Li_ion_800Mah_2s_7_4v.html",
                    Capacity = 800,
                    Weight = 43,
                    Length = 50,
                    Height = 29,
                    Width = 14,
                    Price = 6.12,
                    Config = 2,
                    MaxDischarge = 1,
                    MaxCharge = 1,
                    Name = "Turnigy 14500 Li-ion 800Mah 2s 7.4v"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__6784__ZIPPY_Flightmax_800mAh_3S1P_20C_E_flight_Compatible_EFLB0995_.html",
                    Capacity = 800,
                    Weight = 70,
                    Length = 56,
                    Height = 31,
                    Width = 26,
                    Price = 6.90,
                    Config = 3,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "ZIPPY Flightmax 800mAh 3S1P 20C (E-flight Compatible EFLB0995)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__104439__Turnigy_Graphene_800mAh_2S_20C_Lipo_Pack_Suitable_For_BSR_1000R_Bike_.html",
                    Capacity = 800,
                    Weight = 58,
                    Length = 56,
                    Height = 20,
                    Width = 31,
                    Price = 7.93,
                    Config = 2,
                    MaxDischarge = 20,
                    MaxCharge = 10,
                    Name = "Turnigy Graphene 800mAh 2S 20C Lipo Pack (Suitable For BSR 1000R Bike)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__90419__Turnigy_Graphene_800mAh_3S_45C_Lipo_Pack_w_XT60.html",
                    Capacity = 800,
                    Weight = 80,
                    Length = 57,
                    Height = 31,
                    Width = 26,
                    Price = 10.23,
                    Config = 3,
                    MaxDischarge = 45,
                    MaxCharge = 10,
                    Name = "Turnigy Graphene 800mAh 3S 45C Lipo Pack w/XT60"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__6786__ZIPPY_Flightmax_800mAh_2S1P_20C.html",
                    Capacity = 800,
                    Weight = 49,
                    Length = 54,
                    Height = 30,
                    Width = 18,
                    Price = 5.28,
                    Config = 2,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "ZIPPY Flightmax 800mAh 2S1P 20C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__18847__Turnigy_800mAh_3S_30C_Lipo_Pack.html",
                    Capacity = 800,
                    Weight = 81,
                    Length = 57,
                    Height = 30,
                    Width = 25,
                    Price = 8.52,
                    Config = 3,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "Turnigy 800mAh 3S 30C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9276__Turnigy_800mAh_2S_20C_Lipo_Pack_Parkzone_Compatible_PKZ1032_.html",
                    Capacity = 800,
                    Weight = 50,
                    Length = 55,
                    Height = 30,
                    Width = 18,
                    Price = 5.86,
                    Config = 2,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "Turnigy 800mAh 2S 20C Lipo Pack (Parkzone Compatible PKZ1032)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__18851__Turnigy_800mAh_2S_40C_Lipo_Pack.html",
                    Capacity = 800,
                    Weight = 59,
                    Length = 55,
                    Height = 30,
                    Width = 18,
                    Price = 8.33,
                    Config = 2,
                    MaxDischarge = 40,
                    MaxCharge = 2,
                    Name = "Turnigy 800mAh 2S 40C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__64534__Turnigy_800mAh_3S_20C_Lipo_Pack.html",
                    Capacity = 800,
                    Weight = 80,
                    Length = 57,
                    Height = 30,
                    Width = 25,
                    Price = 7.72,
                    Config = 3,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "Turnigy 800mAh 3S 20C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9173__Turnigy_800mAh_3S_20C_Lipo_Pack_E_flight_Compatible_EFLB0995_.html",
                    Capacity = 800,
                    Weight = 72,
                    Length = 55,
                    Height = 30,
                    Width = 25,
                    Price = 7.74,
                    Config = 3,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "Turnigy 800mAh 3S 20C Lipo Pack (E-flight Compatible EFLB0995)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__18852__Turnigy_800mAh_3S_40C_Lipo_Pack.html",
                    Capacity = 800,
                    Weight = 80,
                    Length = 55,
                    Height = 30,
                    Width = 25,
                    Price = 11.90,
                    Config = 3,
                    MaxDischarge = 40,
                    MaxCharge = 2,
                    Name = "Turnigy 800mAh 3S 40C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__11899__Turnigy_nano_tech_850mah_3S_25_40C_Lipo_Pack.html",
                    Capacity = 850,
                    Weight = 74,
                    Length = 60,
                    Height = 32,
                    Width = 25,
                    Price = 7.50,
                    Config = 3,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 850mah 3S 25~40C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__18203__Turnigy_nano_tech_850mAh_3S_45_90C_Lipo_Pack.html",
                    Capacity = 850,
                    Weight = 73,
                    Length = 55,
                    Height = 31,
                    Width = 25,
                    Price = 10.25,
                    Config = 3,
                    MaxDischarge = 45,
                    MaxCharge = 10,
                    Name = "Turnigy nano-tech 850mAh 3S 45~90C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__7649__ZIPPY_850mAh_20C_single_cell.html",
                    Capacity = 850,
                    Weight = 20,
                    Length = 49,
                    Height = 30,
                    Width = 8,
                    Price = 3.26,
                    Config = 1,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "ZIPPY 850mAh 20C single cell"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__18204__Turnigy_nano_tech_850mAh_4S_45_90C_Lipo_Pack.html",
                    Capacity = 850,
                    Weight = 99,
                    Length = 56,
                    Height = 31,
                    Width = 33,
                    Price = 13.69,
                    Config = 4,
                    MaxDischarge = 45,
                    MaxCharge = 10,
                    Name = "Turnigy nano-tech 850mAh 4S 45~90C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21331__ZIPPY_Compact_850mAh_2S_25C_Lipo_Pack.html",
                    Capacity = 850,
                    Weight = 51,
                    Length = 54,
                    Height = 30,
                    Width = 18,
                    Price = 5.44,
                    Config = 2,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 850mAh 2S 25C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__18200__Turnigy_nano_tech_850mah_4S_25_50C_Lipo_Pack.html",
                    Capacity = 850,
                    Weight = 94,
                    Length = 56,
                    Height = 31,
                    Width = 30,
                    Price = 10.00,
                    Config = 4,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 850mah 4S 25~50C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__25506__ZIPPY_Compact_850mAh_2S_35C_Lipo_Pack.html",
                    Capacity = 850,
                    Weight = 50,
                    Length = 55,
                    Height = 30,
                    Width = 18,
                    Price = 6.40,
                    Config = 2,
                    MaxDischarge = 35,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 850mAh 2S 35C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__87965__Turnigy_Bolt_850mAh_4S_15_2V_65_130C_High_Voltage_Lipoly_Pack_LiHV_.html",
                    Capacity = 850,
                    Weight = 105,
                    Length = 72,
                    Height = 34,
                    Width = 23,
                    Price = 16.85,
                    Config = 4,
                    MaxDischarge = 65,
                    MaxCharge = 2,
                    Name = "Turnigy Bolt 850mAh 4S 15.2V 65~130C High Voltage Lipoly Pack (LiHV)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__106211__Walkera_Rodeo_150_Li_Poly_Battery_7_4V_850mAh_30C.html",
                    Capacity = 850,
                    Weight = 0,
                    Length = 0,
                    Height = 0,
                    Width = 0,
                    Price = 12.86,
                    Config = 1,
                    MaxDischarge = 30,
                    MaxCharge = 0,
                    Name = "Walkera Rodeo 150 - Li-Poly Battery 7.4V 850mAh 30C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__25507__ZIPPY_Compact_850mAh_3S_35C_Lipo_Pack.html",
                    Capacity = 850,
                    Weight = 71,
                    Length = 54,
                    Height = 30,
                    Width = 26,
                    Price = 9.98,
                    Config = 3,
                    MaxDischarge = 35,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 850mAh 3S 35C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__87959__Turnigy_Bolt_850mAh_3S_11_4V_65_130C_High_Voltage_Lipoly_Pack_LiHV_.html",
                    Capacity = 850,
                    Weight = 80,
                    Length = 70,
                    Height = 34,
                    Width = 17,
                    Price = 11.94,
                    Config = 3,
                    MaxDischarge = 65,
                    MaxCharge = 2,
                    Name = "Turnigy Bolt 850mAh 3S 11.4V 65~130C High Voltage Lipoly Pack (LiHV)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__90421__Turnigy_Graphene_950mAh_2S_65C_LiPo_Pack_w_JST_SYP_2P.html",
                    Capacity = 850,
                    Weight = 48,
                    Length = 72,
                    Height = 26,
                    Width = 15,
                    Price = 8.09,
                    Config = 2,
                    MaxDischarge = 65,
                    MaxCharge = 10,
                    Name = "Turnigy Graphene 950mAh 2S 65C LiPo Pack w/ JST-SYP-2P"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__11898__Turnigy_nano_tech_850mah_2S_25_40C_Lipo_Pack.html",
                    Capacity = 850,
                    Weight = 49,
                    Length = 60,
                    Height = 31,
                    Width = 16,
                    Price = 5.99,
                    Config = 2,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 850mah 2S 25~40C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__23318__Turnigy_nano_tech_900mah_1S_15C_Round_Lipo.html",
                    Capacity = 900,
                    Weight = 18,
                    Length = 58,
                    Height = 12,
                    Width = 12,
                    Price = 2.41,
                    Config = 1,
                    MaxDischarge = 15,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 900mah 1S 15C Round Lipo"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__20388__Turnigy_nano_tech_950mah_2S_25_50C_Lipo_Pack.html",
                    Capacity = 950,
                    Weight = 46,
                    Length = 71,
                    Height = 25,
                    Width = 14,
                    Price = 6.40,
                    Config = 2,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 950mah 2S 25~50C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__20389__Turnigy_nano_tech_950mah_3S_25_50C_Lipo_Pack.html",
                    Capacity = 950,
                    Weight = 69,
                    Length = 72,
                    Height = 25,
                    Width = 20,
                    Price = 9.60,
                    Config = 3,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 950mah 3S 25~50C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__90420__Turnigy_Graphene_950mAh_1S_65C_LiPo_Pack_w_JST_SYP_2P.html",
                    Capacity = 950,
                    Weight = 25,
                    Length = 70,
                    Height = 26,
                    Width = 7,
                    Price = 5.97,
                    Config = 1,
                    MaxDischarge = 65,
                    MaxCharge = 10,
                    Name = "Turnigy Graphene 950mAh 1S 65C LiPo Pack w/ JST-SYP-2P"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__20387__Turnigy_nano_tech_950mah_1S_25_50C_Lipo_Pack_Walkera_V120_X100_.html",
                    Capacity = 950,
                    Weight = 25,
                    Length = 68,
                    Height = 7,
                    Width = 25,
                    Price = 3.80,
                    Config = 1,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 950mah 1S 25~50C Lipo Pack (Walkera V120, X100)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__18201__Turnigy_nano_tech_1000mah_4S_25_50C_Lipo_Pack.html",
                    Capacity = 1000,
                    Weight = 110,
                    Length = 71,
                    Height = 34,
                    Width = 22,
                    Price = 11.95,
                    Config = 4,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 1000mah 4S 25~50C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__18557__Turnigy_1000mAh_1S_20C_Lipoly_Single_Cell_.html",
                    Capacity = 1000,
                    Weight = 24,
                    Length = 67,
                    Height = 34,
                    Width = 6,
                    Price = 2.67,
                    Config = 1,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "Turnigy 1000mAh 1S 20C Lipoly (Single Cell)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21333__ZIPPY_Compact_1000mAh_2S_25C_Lipo_Pack.html",
                    Capacity = 1000,
                    Weight = 67,
                    Length = 72,
                    Height = 34,
                    Width = 15,
                    Price = 5.15,
                    Config = 2,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 1000mAh 2S 25C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21390__ZIPPY_Compact_1000mAh_4S_35C_Lipo_Pack.html",
                    Capacity = 1000,
                    Weight = 121,
                    Length = 75,
                    Height = 34,
                    Width = 27,
                    Price = 11.64,
                    Config = 4,
                    MaxDischarge = 35,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 1000mAh 4S 35C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__37833__Turnigy_nano_tech_1000mAh_3S_20_40C_Lipo_AIRSOFT_Pack.html",
                    Capacity = 1000,
                    Weight = 72,
                    Length = 101,
                    Height = 20,
                    Width = 16,
                    Price = 10.71,
                    Config = 3,
                    MaxDischarge = 20,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 1000mAh 3S 20-40C Lipo AIRSOFT Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21389__ZIPPY_Compact_1000mAh_3S_35C_Lipo_Pack.html",
                    Capacity = 1000,
                    Weight = 95,
                    Length = 74,
                    Height = 34,
                    Width = 21,
                    Price = 6.56,
                    Config = 3,
                    MaxDischarge = 35,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 1000mAh 3S 35C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9170__Turnigy_1000mAh_2S_20C_Lipo_Pack.html",
                    Capacity = 1000,
                    Weight = 59,
                    Length = 72,
                    Height = 34,
                    Width = 14,
                    Price = 4.73,
                    Config = 2,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "Turnigy 1000mAh 2S 20C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__87971__Turnigy_Bolt_1000mAh_3S_11_4V_65_130C_High_Voltage_Lipoly_Pack_LiHV_.html",
                    Capacity = 1000,
                    Weight = 94,
                    Length = 71,
                    Height = 33,
                    Width = 20,
                    Price = 15.14,
                    Config = 3,
                    MaxDischarge = 65,
                    MaxCharge = 2,
                    Name = "Turnigy Bolt 1000mAh 3S 11.4V 65~130C High Voltage Lipoly Pack (LiHV)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9491__Turnigy_1000mAh_3S_30C_Lipo_Pack.html",
                    Capacity = 1000,
                    Weight = 97,
                    Length = 74,
                    Height = 34,
                    Width = 21,
                    Price = 10.07,
                    Config = 3,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "Turnigy 1000mAh 3S 30C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__91171__Turnigy_Graphene_1000mAh_3S_45C_LiPo_Pack_w_XT60.html",
                    Capacity = 1000,
                    Weight = 105,
                    Length = 76,
                    Height = 35,
                    Width = 22,
                    Price = 14.21,
                    Config = 3,
                    MaxDischarge = 45,
                    MaxCharge = 10,
                    Name = "Turnigy Graphene 1000mAh 3S 45C LiPo Pack w/XT60"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__11900__Turnigy_nano_tech_1000mah_2S_25_50C_Lipo_Pack.html",
                    Capacity = 1000,
                    Weight = 60,
                    Length = 71,
                    Height = 35,
                    Width = 12,
                    Price = 6.70,
                    Config = 2,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 1000mah 2S 25~50C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__91172__Turnigy_Graphene_1000mAh_3S_65C_Lipo_Pack_w_XT60.html",
                    Capacity = 1000,
                    Weight = 114,
                    Length = 74,
                    Height = 35,
                    Width = 23,
                    Price = 16.95,
                    Config = 3,
                    MaxDischarge = 65,
                    MaxCharge = 10,
                    Name = "Turnigy Graphene 1000mAh 3S 65C Lipo Pack w/XT60"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__23319__Turnigy_nano_tech_1000mah_1S_15C_Round_Cell.html",
                    Capacity = 1000,
                    Weight = 20,
                    Length = 70,
                    Height = 13,
                    Width = 12,
                    Price = 2.56,
                    Config = 1,
                    MaxDischarge = 15,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 1000mah 1S 15C Round Cell"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__91170__Turnigy_Graphene_1000mAh_2S_65C_LiPo_Pack_w_XT60.html",
                    Capacity = 1000,
                    Weight = 84,
                    Length = 76,
                    Height = 35,
                    Width = 16,
                    Price = 8.64,
                    Config = 2,
                    MaxDischarge = 65,
                    MaxCharge = 10,
                    Name = "Turnigy Graphene 1000mAh 2S 65C LiPo Pack w/ XT60"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__63375__ZIPPY_Compact_1000mAh_2s_40c_Lipo_Pack.html",
                    Capacity = 1000,
                    Weight = 66,
                    Length = 75,
                    Height = 34,
                    Width = 14,
                    Price = 7.13,
                    Config = 2,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 1000mAh 2s 40c Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__34530__Turnigy_nano_tech_1000mah_2S_20_40C_Lipo_AIRSOFT_Pack.html",
                    Capacity = 1000,
                    Weight = 51,
                    Length = 101,
                    Height = 20,
                    Width = 11,
                    Price = 7.14,
                    Config = 2,
                    MaxDischarge = 20,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 1000mah 2S 20~40C Lipo AIRSOFT Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__6470__ZIPPY_Flightmax_1000mAh_3S1P_25C.html",
                    Capacity = 1000,
                    Weight = 84,
                    Length = 73,
                    Height = 34,
                    Width = 20,
                    Price = 5.95,
                    Config = 3,
                    MaxDischarge = 25,
                    MaxCharge = 2,
                    Name = "ZIPPY Flightmax 1000mAh 3S1P 25C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9492__Turnigy_1000mAh_4S_30C_Lipo_Pack.html",
                    Capacity = 1000,
                    Weight = 122,
                    Length = 74,
                    Height = 34,
                    Width = 27,
                    Price = 11.04,
                    Config = 4,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "Turnigy 1000mAh 4S 30C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__6474__ZIPPY_Flightmax_1000mAh_2S1P_20C.html",
                    Capacity = 1000,
                    Weight = 60,
                    Length = 71,
                    Height = 34,
                    Width = 15,
                    Price = 6.28,
                    Config = 2,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "ZIPPY Flightmax 1000mAh 2S1P 20C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__87977__Turnigy_Bolt_1000mAh_4S_15_2V_65_130C_High_Voltage_Lipoly_Pack_LiHV_.html",
                    Capacity = 1000,
                    Weight = 118,
                    Length = 72,
                    Height = 34,
                    Width = 24,
                    Price = 16.94,
                    Config = 4,
                    MaxDischarge = 65,
                    MaxCharge = 2,
                    Name = "Turnigy Bolt 1000mAh 4S 15.2V 65~130C High Voltage Lipoly Pack (LiHV)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9490__Turnigy_1000mAh_2S_30C_Lipo_Pack.html",
                    Capacity = 1000,
                    Weight = 70,
                    Length = 73,
                    Height = 34,
                    Width = 15,
                    Price = 6.47,
                    Config = 2,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "Turnigy 1000mAh 2S 30C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__91173__Turnigy_Graphene_1000mAh_4S_65C_Lipo_Pack_w_XT60.html",
                    Capacity = 1000,
                    Weight = 145,
                    Length = 75,
                    Height = 35,
                    Width = 29,
                    Price = 18.93,
                    Config = 4,
                    MaxDischarge = 65,
                    MaxCharge = 10,
                    Name = "Turnigy Graphene 1000mAh 4S 65C Lipo Pack w/ XT60"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__18205__Turnigy_nano_tech_1000mAh_3S_45_90C_Lipo_Pack.html",
                    Capacity = 1000,
                    Weight = 93,
                    Length = 71,
                    Height = 35,
                    Width = 19,
                    Price = 11.30,
                    Config = 3,
                    MaxDischarge = 45,
                    MaxCharge = 10,
                    Name = "Turnigy nano-tech 1000mAh 3S 45~90C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__37837__Turnigy_nano_tech_1000mAh_3S_20_40C_Lipo_AIRSOFT_Pack.html",
                    Capacity = 1000,
                    Weight = 78,
                    Length = 100,
                    Height = 20,
                    Width = 6,
                    Price = 10.85,
                    Config = 3,
                    MaxDischarge = 20,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 1000mAh 3S 20-40C Lipo AIRSOFT Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21334__ZIPPY_Compact_1000mAh_3S_25C_Lipo_Pack.html",
                    Capacity = 1000,
                    Weight = 91,
                    Length = 74,
                    Height = 34,
                    Width = 20,
                    Price = 5.50,
                    Config = 3,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 1000mAh 3S 25C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__18206__Turnigy_nano_tech_1000mAh_4S_45_90C_Lipo_Pack.html",
                    Capacity = 1000,
                    Weight = 124,
                    Length = 73,
                    Height = 35,
                    Width = 25,
                    Price = 13.95,
                    Config = 4,
                    MaxDischarge = 45,
                    MaxCharge = 10,
                    Name = "Turnigy nano-tech 1000mAh 4S 45~90C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__11901__Turnigy_nano_tech_1000mah_3S_25_50C_Lipo_Pack.html",
                    Capacity = 1000,
                    Weight = 79,
                    Length = 77,
                    Height = 35,
                    Width = 17,
                    Price = 10.69,
                    Config = 3,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 1000mah 3S 25~50C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__67732__Turnigy_nano_tech_1000mAh_3S_20_40C_Lipo_AIRSOFT_Pack_T_connector_.html",
                    Capacity = 1000,
                    Weight = 72,
                    Length = 101,
                    Height = 20,
                    Width = 16,
                    Price = 10.13,
                    Config = 3,
                    MaxDischarge = 20,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 1000mAh 3S 20~40C Lipo AIRSOFT Pack(T-connector)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9163__Turnigy_1000mAh_3S_20C_Lipo_Pack.html",
                    Capacity = 1000,
                    Weight = 87,
                    Length = 77,
                    Height = 33,
                    Width = 20,
                    Price = 5.57,
                    Config = 3,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "Turnigy 1000mAh 3S 20C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9608__Rhino_1050mAh_3S_11_1v_40C_Lipoly_Pack.html",
                    Capacity = 1050,
                    Weight = 106,
                    Length = 73,
                    Height = 35,
                    Width = 21,
                    Price = 10.61,
                    Config = 3,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "Rhino 1050mAh 3S 11.1v 40C Lipoly Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9607__Rhino_1050mAh_2S_7_4v_40C_Lipoly_Pack.html",
                    Capacity = 1050,
                    Weight = 75,
                    Length = 72,
                    Height = 39,
                    Width = 12,
                    Price = 4.23,
                    Config = 2,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "Rhino 1050mAh 2S 7.4v 40C Lipoly Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__37846__Turnigy_nano_tech_1200mAh_2S_25_50C_Lipo_AIRSOFT_Pack.html",
                    Capacity = 1200,
                    Weight = 59,
                    Length = 118,
                    Height = 16,
                    Width = 7,
                    Price = 7.10,
                    Config = 2,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 1200mAh 2S 25-50C Lipo AIRSOFT Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__67729__Turnigy_nano_tech_1200mAh_2S_15_30C_Lipo_AIRSOFT_Pack_T_Connector_.html",
                    Capacity = 1200,
                    Weight = 64,
                    Length = 127,
                    Height = 20,
                    Width = 12,
                    Price = 6.14,
                    Config = 2,
                    MaxDischarge = 15,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 1200mAh 2S 15~30C Lipo AIRSOFT Pack (T-Connector)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__67730__Turnigy_nano_tech_1200mAh_3S_15_30C_Lipo_AIRSOFT_Pack_T_Connector_.html",
                    Capacity = 1200,
                    Weight = 94,
                    Length = 128,
                    Height = 17,
                    Width = 20,
                    Price = 9.11,
                    Config = 3,
                    MaxDischarge = 15,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 1200mAh 3S 15~30C Lipo AIRSOFT Pack (T-Connector)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__17278__Turnigy_nano_tech_1200mah_3S_15_25C_Lipo_AIRSOFT_Pack.html",
                    Capacity = 1200,
                    Weight = 99,
                    Length = 125,
                    Height = 21,
                    Width = 6,
                    Price = 9.30,
                    Config = 3,
                    MaxDischarge = 15,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 1200mah 3S 15~25C Lipo AIRSOFT Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__37845__Turnigy_nano_tech_1200mAh_3S_25_50C_Lipo_AIRSOFT_Pack.html",
                    Capacity = 1200,
                    Weight = 80,
                    Length = 116,
                    Height = 16,
                    Width = 19,
                    Price = 10.50,
                    Config = 3,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 1200mAh 3S 25-50C Lipo AIRSOFT Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__17277__Turnigy_nano_tech_1200mah_2S_15_25C_Lipo_AIRSOFT_Pack.html",
                    Capacity = 1200,
                    Weight = 68,
                    Length = 125,
                    Height = 20,
                    Width = 6,
                    Price = 6.19,
                    Config = 2,
                    MaxDischarge = 15,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 1200mah 2S 15~25C Lipo AIRSOFT Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__23320__Turnigy_nano_tech_1200mah_1S_15C_Round_Cell.html",
                    Capacity = 1200,
                    Weight = 23,
                    Length = 58,
                    Height = 15,
                    Width = 15,
                    Price = 2.80,
                    Config = 1,
                    MaxDischarge = 15,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 1200mah 1S 15C Round Cell"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__37844__Turnigy_nano_tech_1200mAh_2S_25_50C_Lipo_AIRSOFT_Pack.html",
                    Capacity = 1200,
                    Weight = 55,
                    Length = 116,
                    Height = 17,
                    Width = 13,
                    Price = 7.00,
                    Config = 2,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 1200mAh 2S 25-50C Lipo AIRSOFT Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__67731__Turnigy_nano_tech_1200mAh_2S_25_50C_Lipo_AIRSOFT_Pack_T_Connector_.html",
                    Capacity = 1200,
                    Weight = 55,
                    Length = 116,
                    Height = 17,
                    Width = 13,
                    Price = 7.01,
                    Config = 2,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 1200mAh 2S 25~50C Lipo AIRSOFT Pack (T-Connector)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__17276__Turnigy_nano_tech_1200mah_3S_15_25C_Lipo_AIRSOFT_Pack.html",
                    Capacity = 1200,
                    Weight = 94,
                    Length = 128,
                    Height = 17,
                    Width = 20,
                    Price = 9.00,
                    Config = 3,
                    MaxDischarge = 15,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 1200mah 3S 15~25C Lipo AIRSOFT Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__37847__Turnigy_nano_tech_1200mAh_3S_25_50C_Lipo_AIRSOFT_Pack.html",
                    Capacity = 1200,
                    Weight = 85,
                    Length = 116,
                    Height = 16,
                    Width = 6,
                    Price = 10.65,
                    Config = 3,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 1200mAh 3S 25-50C Lipo AIRSOFT Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__17275__Turnigy_nano_tech_1200mah_2S_15_25C_Lipo_AIRSOFT_Pack.html",
                    Capacity = 1200,
                    Weight = 64,
                    Length = 127,
                    Height = 20,
                    Width = 12,
                    Price = 6.00,
                    Config = 2,
                    MaxDischarge = 15,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 1200mah 2S 15~25C Lipo AIRSOFT Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9325__Rhino_1250mAh_2S_7_4v_30C_Lipoly_Pack.html",
                    Capacity = 1250,
                    Weight = 81,
                    Length = 91,
                    Height = 34,
                    Width = 12,
                    Price = 8.09,
                    Config = 2,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "Rhino 1250mAh 2S 7.4v 30C Lipoly Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__7343__Rhino_1250mAh_3S1P_20C_Lipoly_Pack_.html",
                    Capacity = 1250,
                    Weight = 116,
                    Length = 90,
                    Height = 35,
                    Width = 18,
                    Price = 7.48,
                    Config = 3,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "Rhino 1250mAh 3S1P 20C Lipoly Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__7310__Rhino_1250mAh_2S_7_4v_20C_Lipoly_Pack_.html",
                    Capacity = 1250,
                    Weight = 82,
                    Length = 88,
                    Height = 34,
                    Width = 11,
                    Price = 5.92,
                    Config = 2,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "Rhino 1250mAh 2S 7.4v 20C Lipoly Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__86188__Turnigy_1250mAh_2S_20C_LiPoly_Pack_w_EC3_E_flite_Compatible_EFLB12502S_.html",
                    Capacity = 1250,
                    Weight = 76,
                    Length = 92,
                    Height = 36,
                    Width = 15,
                    Price = 6.85,
                    Config = 2,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "Turnigy 1250mAh 2S 20C LiPoly Pack w/ EC3 (E-flite Compatible EFLB12502S)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__87995__Turnigy_Bolt_1300mAh_6S_22_8V_65_130C_High_Voltage_Lipoly_Pack_LiHV_.html",
                    Capacity = 1300,
                    Weight = 225,
                    Length = 88,
                    Height = 35,
                    Width = 38,
                    Price = 32.38,
                    Config = 6,
                    MaxDischarge = 65,
                    MaxCharge = 2,
                    Name = "Turnigy Bolt 1300mAh 6S 22.8V 65~130C High Voltage Lipoly Pack (LiHV)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__11903__Turnigy_nano_tech_1300mah_3S_25_50C_Lipo_Pack.html",
                    Capacity = 1300,
                    Weight = 119,
                    Length = 70,
                    Height = 34,
                    Width = 22,
                    Price = 12.73,
                    Config = 3,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 1300mah 3S 25~50C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__91174__Turnigy_Graphene_1300mAh_3S_45C_LiPo_Pack_w_XT60.html",
                    Capacity = 1300,
                    Weight = 137,
                    Length = 75,
                    Height = 36,
                    Width = 27,
                    Price = 15.99,
                    Config = 3,
                    MaxDischarge = 45,
                    MaxCharge = 10,
                    Name = "Turnigy Graphene 1300mAh 3S 45C LiPo Pack w/ XT60"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__6469__ZIPPY_Flightmax_1300mAh_2S1P_20C.html",
                    Capacity = 1300,
                    Weight = 80,
                    Length = 71,
                    Height = 35,
                    Width = 17,
                    Price = 6.32,
                    Config = 2,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "ZIPPY Flightmax 1300mAh 2S1P 20C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9493__Turnigy_1300mAh_3S_30C_Lipo_Pack.html",
                    Capacity = 1300,
                    Weight = 107,
                    Length = 78,
                    Height = 34,
                    Width = 23,
                    Price = 11.08,
                    Config = 3,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "Turnigy 1300mAh 3S 30C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__17290__Turnigy_nano_tech_1300mah_3S_25_50C_Lipo_AIRSOFT_Pack.html",
                    Capacity = 1300,
                    Weight = 122,
                    Length = 167,
                    Height = 18,
                    Width = 7,
                    Price = 10.79,
                    Config = 3,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 1300mah 3S 25~50C Lipo AIRSOFT Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__91176__Turnigy_Graphene_1300mAh_4S_45C_Lipo_Pack_w_XT60.html",
                    Capacity = 1300,
                    Weight = 165,
                    Length = 73,
                    Height = 35,
                    Width = 34,
                    Price = 18.99,
                    Config = 4,
                    MaxDischarge = 45,
                    MaxCharge = 10,
                    Name = "Turnigy Graphene 1300mAh 4S 45C Lipo Pack w/ XT60"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__11902__Turnigy_nano_tech_1300mah_2S_25_50C_Lipo_Pack.html",
                    Capacity = 1300,
                    Weight = 86,
                    Length = 85,
                    Height = 34,
                    Width = 16,
                    Price = 7.09,
                    Config = 2,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 1300mah 2S 25~50C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__102678__Turnigy_1300mAh_4S_45C_Lipo_Pack.html",
                    Capacity = 1300,
                    Weight = 153,
                    Length = 74,
                    Height = 34,
                    Width = 33,
                    Price = 21.08,
                    Config = 4,
                    MaxDischarge = 45,
                    MaxCharge = 2,
                    Name = "Turnigy 1300mAh 4S 45C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__23818__Turnigy_nano_tech_1300mAh_2S1P_20_40C_Lipo_Receiver_Pack.html",
                    Capacity = 1300,
                    Weight = 67,
                    Length = 71,
                    Height = 34,
                    Width = 14,
                    Price = 8.49,
                    Config = 2,
                    MaxDischarge = 20,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 1300mAh 2S1P 20~40C Lipo Receiver Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__18207__Turnigy_nano_tech_1300mAh_3S_45_90C_Lipo_Pack.html",
                    Capacity = 1300,
                    Weight = 119,
                    Length = 72,
                    Height = 35,
                    Width = 23,
                    Price = 15.50,
                    Config = 3,
                    MaxDischarge = 45,
                    MaxCharge = 10,
                    Name = "Turnigy nano-tech 1300mAh 3S 45~90C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__17288__Turnigy_nano_tech_1300mah_3S_25_50C_Lipo_AIRSOFT_Pack.html",
                    Capacity = 1300,
                    Weight = 113,
                    Length = 168,
                    Height = 18,
                    Width = 18,
                    Price = 10.50,
                    Config = 3,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 1300mah 3S 25~50C Lipo AIRSOFT Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__63379__ZIPPY_Compact_1300mAh_4s_40c_Lipo_Pack.html",
                    Capacity = 1300,
                    Weight = 148,
                    Length = 77,
                    Height = 34,
                    Width = 31,
                    Price = 15.47,
                    Config = 4,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 1300mAh 4s 40c Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9165__Turnigy_1300mAh_2S_20C_Lipo_Pack.html",
                    Capacity = 1300,
                    Weight = 81,
                    Length = 73,
                    Height = 35,
                    Width = 17,
                    Price = 6.70,
                    Config = 2,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "Turnigy 1300mAh 2S 20C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21337__ZIPPY_Compact_1300mAh_2S_25C_Lipo_Pack.html",
                    Capacity = 1300,
                    Weight = 81,
                    Length = 73,
                    Height = 34,
                    Width = 17,
                    Price = 7.25,
                    Config = 2,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 1300mAh 2S 25C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__20963__Turnigy_1300mAh_6S_35C_Lipo_Pack_450_helicopter_HK_Trex_Rave_E4_etc_.html",
                    Capacity = 1300,
                    Weight = 218,
                    Length = 76,
                    Height = 35,
                    Width = 46,
                    Price = 21.45,
                    Config = 6,
                    MaxDischarge = 35,
                    MaxCharge = 2,
                    Name = "Turnigy 1300mAh 6S 35C Lipo Pack (450 helicopter HK/Trex/Rave/E4 etc)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__91177__Turnigy_Graphene_1300mAh_4S_65C_Lipo_Pack_w_XT60.html",
                    Capacity = 1300,
                    Weight = 176,
                    Length = 75,
                    Height = 36,
                    Width = 36,
                    Price = 25.38,
                    Config = 4,
                    MaxDischarge = 65,
                    MaxCharge = 10,
                    Name = "Turnigy Graphene 1300mAh 4S 65C Lipo Pack w/XT60"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__18208__Turnigy_nano_tech_1300mAh_4S_45_90C_Lipo_Pack.html",
                    Capacity = 1300,
                    Weight = 155,
                    Length = 73,
                    Height = 35,
                    Width = 31,
                    Price = 19.48,
                    Config = 4,
                    MaxDischarge = 45,
                    MaxCharge = 10,
                    Name = "Turnigy nano-tech 1300mAh 4S 45~90C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__22907__Turnigy_nano_tech_1300mah_6S_45_90C_Lipo_Pack_450_helicopter_HK_Trex_Rave_E4_etc_.html",
                    Capacity = 1300,
                    Weight = 216,
                    Length = 71,
                    Height = 34,
                    Width = 41,
                    Price = 28.40,
                    Config = 6,
                    MaxDischarge = 45,
                    MaxCharge = 10,
                    Name = "Turnigy nano-tech 1300mah 6S 45~90C Lipo Pack (450 helicopter HK/Trex/Rave/E4 etc)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__87983__Turnigy_Bolt_1300mAh_3S_11_4V_65_130C_High_Voltage_Lipoly_Pack_LiHV_.html",
                    Capacity = 1300,
                    Weight = 119,
                    Length = 88,
                    Height = 34,
                    Width = 19,
                    Price = 19.27,
                    Config = 3,
                    MaxDischarge = 65,
                    MaxCharge = 2,
                    Name = "Turnigy Bolt 1300mAh 3S 11.4V 65~130C High Voltage Lipoly Pack (LiHV)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__63377__ZIPPY_Compact_1300mAh_2s_40c_Lipo_Pack.html",
                    Capacity = 1300,
                    Weight = 82,
                    Length = 76,
                    Height = 35,
                    Width = 16,
                    Price = 7.71,
                    Config = 2,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 1300mAh 2s 40c Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__67727__Turnigy_nano_tech_1300mAh_2S_25_50C_Lipo_AIRSOFT_Pack_T_connector_.html",
                    Capacity = 1300,
                    Weight = 79,
                    Length = 168,
                    Height = 18,
                    Width = 12,
                    Price = 7.55,
                    Config = 2,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 1300mAh 2S 25~50C Lipo AIRSOFT Pack(T-connector)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__15087__Turnigy_1300mAh_2S_20C_Lipo_Pack_Suit_1_18th_Truck_.html",
                    Capacity = 1300,
                    Weight = 76,
                    Length = 90,
                    Height = 30,
                    Width = 14,
                    Price = 9.50,
                    Config = 2,
                    MaxDischarge = 20,
                    MaxCharge = 5,
                    Name = "Turnigy 1300mAh 2S 20C Lipo Pack (Suit 1/18th Truck)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__87989__Turnigy_Bolt_1300mAh_4S_15_2V_65_130C_High_Voltage_Lipoly_Pack_LiHV_.html",
                    Capacity = 1300,
                    Weight = 154,
                    Length = 88,
                    Height = 35,
                    Width = 25,
                    Price = 26.44,
                    Config = 4,
                    MaxDischarge = 65,
                    MaxCharge = 2,
                    Name = "Turnigy Bolt 1300mAh 4S 15.2V 65~130C High Voltage Lipoly Pack (LiHV)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__91175__Turnigy_Graphene_1300mAh_3S_65C_LiPo_Pack_w_XT60.html",
                    Capacity = 1300,
                    Weight = 138,
                    Length = 74,
                    Height = 35,
                    Width = 27,
                    Price = 17.99,
                    Config = 3,
                    MaxDischarge = 65,
                    MaxCharge = 10,
                    Name = "Turnigy Graphene 1300mAh 3S 65C LiPo Pack w/ XT60"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21338__ZIPPY_Compact_1300mAh_3S_25C_Lipo_Pack.html",
                    Capacity = 1300,
                    Weight = 111,
                    Length = 73,
                    Height = 35,
                    Width = 24,
                    Price = 10.67,
                    Config = 3,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 1300mAh 3S 25C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__17287__Turnigy_nano_tech_1300mah_2S_25_50C_Lipo_AIRSOFT_Pack.html",
                    Capacity = 1300,
                    Weight = 79,
                    Length = 168,
                    Height = 18,
                    Width = 12,
                    Price = 7.05,
                    Config = 2,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 1300mah 2S 25~50C Lipo AIRSOFT Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__17289__Turnigy_nano_tech_1300mah_2S_25_50C_Lipo_AIRSOFT_Pack.html",
                    Capacity = 1300,
                    Weight = 80,
                    Length = 166,
                    Height = 18,
                    Width = 7,
                    Price = 7.29,
                    Config = 2,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 1300mah 2S 25~50C Lipo AIRSOFT Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21339__ZIPPY_Compact_1300mAh_4S_25C_Lipo_Pack.html",
                    Capacity = 1300,
                    Weight = 142,
                    Length = 73,
                    Height = 35,
                    Width = 31,
                    Price = 12.44,
                    Config = 4,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 1300mAh 4S 25C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__66874__MultiStar_Racer_Series_1400mAh_3S_40_80C_Multi_Rotor_Lipo_Pack_For_FPV_Minis.html",
                    Capacity = 1400,
                    Weight = 115,
                    Length = 86,
                    Height = 34,
                    Width = 20,
                    Price = 14.86,
                    Config = 3,
                    MaxDischarge = 40,
                    MaxCharge = 2,
                    Name = "MultiStar Racer Series 1400mAh 3S 40-80C Multi-Rotor Lipo Pack For FPV Minis"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__17279__Turnigy_nano_tech_1400mah_2S_15_25C_Lipo_AIRSOFT_Pack.html",
                    Capacity = 1400,
                    Weight = 76,
                    Length = 126,
                    Height = 22,
                    Width = 13,
                    Price = 6.99,
                    Config = 2,
                    MaxDischarge = 15,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 1400mah 2S 15~25C Lipo AIRSOFT Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__103015__MultiStar_1400mAh_4S_40C_Multi_Rotor_Lipo_Pack_with_LED_indicator_.html",
                    Capacity = 1400,
                    Weight = 156,
                    Length = 89,
                    Height = 34,
                    Width = 25,
                    Price = 21.98,
                    Config = 0,
                    MaxDischarge = 40,
                    MaxCharge = 2,
                    Name = "MultiStar 1400mAh 4S 40C Multi-Rotor Lipo Pack (with LED indicator)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__88833__MultiStar_Racer_Series_1400mAh_3S_65C_Lipo_Pack_For_FPV_Minis_Gold_Spec_.html",
                    Capacity = 1400,
                    Weight = 139,
                    Length = 90,
                    Height = 34,
                    Width = 23,
                    Price = 18.88,
                    Config = 3,
                    MaxDischarge = 65,
                    MaxCharge = 5,
                    Name = "MultiStar Racer Series 1400mAh 3S 65C Lipo Pack For FPV Minis (Gold Spec)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__103001__MultiStar_1400mAh_3S_40C_Multi_Rotor_Lipo_Pack_with_LED_indicator_.html",
                    Capacity = 1400,
                    Weight = 121,
                    Length = 89,
                    Height = 34,
                    Width = 19,
                    Price = 16.14,
                    Config = 0,
                    MaxDischarge = 40,
                    MaxCharge = 2,
                    Name = "MultiStar 1400mAh 3S 40C Multi-Rotor Lipo Pack (with LED indicator)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__17282__Turnigy_nano_tech_1400mah_3S_15_25C_Lipo_AIRSOFT_Pack.html",
                    Capacity = 1400,
                    Weight = 115,
                    Length = 128,
                    Height = 20,
                    Width = 7,
                    Price = 10.80,
                    Config = 3,
                    MaxDischarge = 15,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 1400mah 3S 15~25C Lipo AIRSOFT Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__103022__MultiStar_1400mAh_4S_65C_Multi_Rotor_Lipo_Pack_with_LED_indicator_.html",
                    Capacity = 1400,
                    Weight = 182,
                    Length = 89,
                    Height = 34,
                    Width = 31,
                    Price = 23.99,
                    Config = 0,
                    MaxDischarge = 65,
                    MaxCharge = 2,
                    Name = "MultiStar 1400mAh 4S 65C Multi-Rotor Lipo Pack (with LED indicator)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__17280__Turnigy_nano_tech_1400mah_3S_15_25C_Lipo_AIRSOFT_Pack.html",
                    Capacity = 1400,
                    Weight = 110,
                    Length = 127,
                    Height = 21,
                    Width = 20,
                    Price = 10.50,
                    Config = 3,
                    MaxDischarge = 15,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 1400mah 3S 15~25C Lipo AIRSOFT Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__103008__MultiStar_Racer_Series_1400mAh_3S_65C_Multi_Rotor_Lipo_Pack_with_LED_indicator_.html",
                    Capacity = 1400,
                    Weight = 141,
                    Length = 89,
                    Height = 34,
                    Width = 23,
                    Price = 19.50,
                    Config = 0,
                    MaxDischarge = 65,
                    MaxCharge = 2,
                    Name = "MultiStar Racer Series 1400mAh 3S 65C  Multi-Rotor Lipo Pack (with LED indicator)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__17281__Turnigy_nano_tech_1400mah_2S_15_25C_Lipo_AIRSOFT_Pack.html",
                    Capacity = 1400,
                    Weight = 79,
                    Length = 125,
                    Height = 21,
                    Width = 7,
                    Price = 7.30,
                    Config = 2,
                    MaxDischarge = 15,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 1400mah 2S 15~25C Lipo AIRSOFT Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9787__Turnigy_1450mAh_3S_11_1v_Transmitter_Lipoly_Pack.html",
                    Capacity = 1450,
                    Weight = 95,
                    Length = 93,
                    Height = 40,
                    Width = 14,
                    Price = 11.70,
                    Config = 3,
                    MaxDischarge = 1,
                    MaxCharge = 1,
                    Name = "Turnigy 1450mAh 3S 11.1v Transmitter Lipoly Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__26564__Turnigy_1500mAh_2S_25C_Lipoly_Battery.html",
                    Capacity = 1500,
                    Weight = 84,
                    Length = 71,
                    Height = 33,
                    Width = 19,
                    Price = 9.10,
                    Config = 2,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy 1500mAh 2S 25C Lipoly Battery"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__63380__ZIPPY_Compact_1500mAh_2s_40c_Lipo_Pack.html",
                    Capacity = 1500,
                    Weight = 99,
                    Length = 107,
                    Height = 24,
                    Width = 13,
                    Price = 10.13,
                    Config = 2,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 1500mAh 2s 40c Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__91178__Turnigy_Graphene_1500mAh_3S_65C_LiPo_Pack_w_XT60.html",
                    Capacity = 1500,
                    Weight = 163,
                    Length = 109,
                    Height = 35,
                    Width = 23,
                    Price = 18.25,
                    Config = 3,
                    MaxDischarge = 65,
                    MaxCharge = 10,
                    Name = "Turnigy Graphene 1500mAh 3S 65C LiPo Pack w/ XT60"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__26450__Turnigy_nano_tech_1500mah_2S_25_50C_Lipo_Pack.html",
                    Capacity = 1500,
                    Weight = 86,
                    Length = 87,
                    Height = 33,
                    Width = 15,
                    Price = 8.85,
                    Config = 2,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 1500mah 2S 25~50C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__25510__ZIPPY_Compact_1500mAh_3S_35C_Lipo_Pack.html",
                    Capacity = 1500,
                    Weight = 138,
                    Length = 108,
                    Height = 34,
                    Width = 18,
                    Price = 14.08,
                    Config = 3,
                    MaxDischarge = 35,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 1500mAh 3S 35C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__91179__Turnigy_Graphene_1500mAh_4S_45C_LiPo_Pack_w_XT60.html",
                    Capacity = 1500,
                    Weight = 201,
                    Length = 107,
                    Height = 35,
                    Width = 28,
                    Price = 22.53,
                    Config = 4,
                    MaxDischarge = 45,
                    MaxCharge = 10,
                    Name = "Turnigy Graphene 1500mAh 4S 45C LiPo Pack w/ XT60"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__37839__Turnigy_nano_tech_1500mAh_2S_20_40C_Lipo_AIRSOFT_Pack.html",
                    Capacity = 1500,
                    Weight = 80,
                    Length = 97,
                    Height = 30,
                    Width = 14,
                    Price = 7.80,
                    Config = 2,
                    MaxDischarge = 20,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 1500mAh 2S 20-40C Lipo AIRSOFT Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__6307__ZIPPY_Flightmax_1500mAh_3S1P_20C.html",
                    Capacity = 1500,
                    Weight = 141,
                    Length = 105,
                    Height = 35,
                    Width = 21,
                    Price = 8.30,
                    Config = 3,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "ZIPPY Flightmax 1500mAh 3S1P 20C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__64938__Turnigy_1500mAh_3S_30C_Lipo_E_flite_Compatible_EFLB15003S_Losi_Mini_8ight_.html",
                    Capacity = 1500,
                    Weight = 118,
                    Length = 96,
                    Height = 19,
                    Width = 29,
                    Price = 13.84,
                    Config = 3,
                    MaxDischarge = 30,
                    MaxCharge = 5,
                    Name = "Turnigy 1500mAh 3S 30C Lipo (E-flite Compatible EFLB15003S & Losi Mini 8ight)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__26451__Turnigy_nano_tech_1500mah_3S_25_50C_Lipo_Pack.html",
                    Capacity = 1500,
                    Weight = 124,
                    Length = 87,
                    Height = 34,
                    Width = 21,
                    Price = 13.25,
                    Config = 3,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 1500mah 3S 25~50C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__26453__Turnigy_nano_tech_1500mah_3S_35_70C_Lipo_Pack.html",
                    Capacity = 1500,
                    Weight = 129,
                    Length = 88,
                    Height = 34,
                    Width = 21,
                    Price = 15.90,
                    Config = 3,
                    MaxDischarge = 35,
                    MaxCharge = 8,
                    Name = "Turnigy nano-tech 1500mah 3S 35~70C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__26452__Turnigy_nano_tech_1500mah_2S_35_70C_Lipo_Pack.html",
                    Capacity = 1500,
                    Weight = 91,
                    Length = 85,
                    Height = 35,
                    Width = 14,
                    Price = 10.60,
                    Config = 2,
                    MaxDischarge = 35,
                    MaxCharge = 8,
                    Name = "Turnigy nano-tech 1500mah 2S 35~70C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9273__Turnigy_1500mAh_3S_20C_Lipo_Pack.html",
                    Capacity = 1500,
                    Weight = 128,
                    Length = 73,
                    Height = 34,
                    Width = 28,
                    Price = 11.00,
                    Config = 3,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "Turnigy 1500mAh 3S 20C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__74310__Quanum_FPV_Headset_Battery_7_4V_1500mAh_3C.html",
                    Capacity = 1500,
                    Weight = 60,
                    Length = 66,
                    Height = 32,
                    Width = 13,
                    Price = 8.99,
                    Config = 2,
                    MaxDischarge = 3,
                    MaxCharge = 1,
                    Name = "Quanum FPV Headset Battery 7.4V 1500mAh 3C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__23819__Turnigy_nano_tech_1500mAh_2S1P_20_40C_Lipo_Receiver_Pack.html",
                    Capacity = 1500,
                    Weight = 75,
                    Length = 87,
                    Height = 34,
                    Width = 13,
                    Price = 8.99,
                    Config = 2,
                    MaxDischarge = 20,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 1500mAh 2S1P 20~40C Lipo Receiver Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__63381__ZIPPY_Compact_1500mAh_3s_40c_Lipo_Pack.html",
                    Capacity = 1500,
                    Weight = 139,
                    Length = 107,
                    Height = 34,
                    Width = 20,
                    Price = 14.92,
                    Config = 3,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 1500mAh 3s 40c Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__26565__Turnigy_1500mAh_3S_25C_Lipo_Pack.html",
                    Capacity = 1500,
                    Weight = 127,
                    Length = 73,
                    Height = 33,
                    Width = 27,
                    Price = 12.65,
                    Config = 3,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy 1500mAh 3S 25C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__37841__Turnigy_nano_tech_1500mAh_3S_20_40C_Lipo_AIRSOFT_Pack.html",
                    Capacity = 1500,
                    Weight = 116,
                    Length = 98,
                    Height = 31,
                    Width = 20,
                    Price = 11.70,
                    Config = 3,
                    MaxDischarge = 20,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 1500mAh 3S 20-40C Lipo AIRSOFT Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__86189__Turnigy_1500mAh_3S_20C_LiPoly_Pack_w_EC3_E_flite_Compatible_.html",
                    Capacity = 1500,
                    Weight = 125,
                    Length = 108,
                    Height = 36,
                    Width = 21,
                    Price = 8.02,
                    Config = 3,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "Turnigy 1500mAh 3S 20C LiPoly Pack w/ EC3 (E-flite Compatible)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21340__ZIPPY_Compact_1500mAh_3S_25C_Lipo_Pack.html",
                    Capacity = 1500,
                    Weight = 143,
                    Length = 106,
                    Height = 34,
                    Width = 21,
                    Price = 9.50,
                    Config = 3,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 1500mAh 3S 25C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__91180__Turnigy_Graphene_1500mAh_4S_65C_LiPo_Pack_w_XT60.html",
                    Capacity = 1500,
                    Weight = 208,
                    Length = 107,
                    Height = 35,
                    Width = 30,
                    Price = 28.39,
                    Config = 4,
                    MaxDischarge = 65,
                    MaxCharge = 10,
                    Name = "Turnigy Graphene 1500mAh 4S 65C LiPo Pack w/ XT60"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__51445__Turnigy_nano_tech_1550mah_6S_65_130C_Lipo_Pack_450L_Heli_.html",
                    Capacity = 1550,
                    Weight = 247,
                    Length = 120,
                    Height = 34,
                    Width = 27,
                    Price = 34.65,
                    Config = 6,
                    MaxDischarge = 65,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 1550mah 6S 65~130C Lipo Pack (450L Heli)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9167__Turnigy_1600mAh_3S_20C_Lipo_Pack.html",
                    Capacity = 1600,
                    Weight = 142,
                    Length = 105,
                    Height = 35,
                    Width = 21,
                    Price = 11.02,
                    Config = 3,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "Turnigy 1600mAh 3S 20C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9455__Turnigy_1600mAh_2S_30C_Lipo_Pack.html",
                    Capacity = 1600,
                    Weight = 91,
                    Length = 107,
                    Height = 35,
                    Width = 14,
                    Price = 8.72,
                    Config = 2,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "Turnigy 1600mAh 2S 30C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21391__ZIPPY_Compact_1600mAh_4S_35C_Lipo_Pack.html",
                    Capacity = 1600,
                    Weight = 178,
                    Length = 106,
                    Height = 34,
                    Width = 23,
                    Price = 17.34,
                    Config = 4,
                    MaxDischarge = 35,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 1600mAh 4S 35C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__91593__Multistar_Racer_Series_1600mAh_4S_40C_Multi_Rotor_LiPo_Pack.html",
                    Capacity = 1600,
                    Weight = 190,
                    Length = 105,
                    Height = 35,
                    Width = 27,
                    Price = 19.22,
                    Config = 4,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "Multistar Racer Series 1600mAh 4S 40C Multi-Rotor LiPo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__7370__ZIPPY_Flightmax_1600mAh_2S1P_20C.html",
                    Capacity = 1600,
                    Weight = 102,
                    Length = 104,
                    Height = 34,
                    Width = 15,
                    Price = 6.80,
                    Config = 2,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "ZIPPY Flightmax 1600mAh 2S1P 20C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__11905__Turnigy_nano_tech_1600mah_3S_25_50C_Lipo_Pack.html",
                    Capacity = 1600,
                    Weight = 143,
                    Length = 120,
                    Height = 34,
                    Width = 18,
                    Price = 14.01,
                    Config = 3,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 1600mah 3S 25~50C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__91592__MultiStar_Racer_Series_1600mAh_3S_40C_Multi_Rotor_LiPo_Pack.html",
                    Capacity = 1600,
                    Weight = 150,
                    Length = 105,
                    Height = 35,
                    Width = 21,
                    Price = 14.50,
                    Config = 3,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "MultiStar Racer Series 1600mAh 3S 40C Multi-Rotor LiPo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__19952__Turnigy_1600mAh_2S_20C_Lipo_Pack_Losi_Mini_Compatible_.html",
                    Capacity = 1600,
                    Weight = 81,
                    Length = 89,
                    Height = 30,
                    Width = 16,
                    Price = 7.79,
                    Config = 2,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "Turnigy 1600mAh 2S 20C Lipo Pack (Losi Mini Compatible)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9495__Turnigy_1600mAh_4S_20C_Lipo_Pack.html",
                    Capacity = 1600,
                    Weight = 154,
                    Length = 89,
                    Height = 34,
                    Width = 26,
                    Price = 14.69,
                    Config = 4,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "Turnigy 1600mAh 4S 20C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9457__Turnigy_1600mAh_4S_30C_Lipo_Pack.html",
                    Capacity = 1600,
                    Weight = 177,
                    Length = 90,
                    Height = 35,
                    Width = 30,
                    Price = 18.63,
                    Config = 4,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "Turnigy 1600mAh 4S 30C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__105540__Turnigy_1650mAh_2S_35C_LiPo_Pack.html",
                    Capacity = 1650,
                    Weight = 100,
                    Length = 74,
                    Height = 15,
                    Width = 45,
                    Price = 10.71,
                    Config = 2,
                    MaxDischarge = 35,
                    MaxCharge = 10,
                    Name = "Turnigy 1650mAh 2S 35C LiPo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__15088__Turnigy_1700mAh_2S_20C_Lipo_Pack_Suits_1_16th_Monster_Beatle_SCT_Buggy_.html",
                    Capacity = 1700,
                    Weight = 92,
                    Length = 91,
                    Height = 26.5,
                    Width = 18,
                    Price = 8.73,
                    Config = 2,
                    MaxDischarge = 20,
                    MaxCharge = 5,
                    Name = "Turnigy 1700mAh 2S 20C Lipo Pack (Suits 1/16th Monster Beatle, SCT & Buggy)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__7312__Rhino_1750mAh_2S_7_4v_20C_Lipoly_Pack.html",
                    Capacity = 1750,
                    Weight = 110,
                    Length = 94,
                    Height = 33,
                    Width = 14,
                    Price = 6.77,
                    Config = 2,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "Rhino 1750mAh 2S 7.4v 20C Lipoly Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__7345__Rhino_1750mAh_4S_14_8v_20C_Lipoly_Pack.html",
                    Capacity = 1750,
                    Weight = 175,
                    Length = 90,
                    Height = 34,
                    Width = 30,
                    Price = 13.27,
                    Config = 4,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "Rhino 1750mAh 4S 14.8v 20C Lipoly Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__63385__ZIPPY_Compact_1800mAh_6s_40c_Lipo_Pack.html",
                    Capacity = 1800,
                    Weight = 298,
                    Length = 106,
                    Height = 35,
                    Width = 44,
                    Price = 29.89,
                    Config = 6,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 1800mAh 6s 40c Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9937__ZIPPY_Flightmax_1800mAh_3S1P_40C.html",
                    Capacity = 1800,
                    Weight = 158,
                    Length = 105,
                    Height = 35,
                    Width = 21,
                    Price = 15.04,
                    Config = 3,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "ZIPPY Flightmax 1800mAh 3S1P 40C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__88001__Turnigy_Bolt_1800mAh_3S_11_4V_65_130C_High_Voltage_Lipoly_Pack_LiHV_.html",
                    Capacity = 1800,
                    Weight = 160,
                    Length = 104,
                    Height = 34,
                    Width = 20,
                    Price = 23.82,
                    Config = 3,
                    MaxDischarge = 65,
                    MaxCharge = 2,
                    Name = "Turnigy Bolt 1800mAh 3S 11.4V 65~130C High Voltage Lipoly Pack (LiHV)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__11942__Turnigy_nano_tech_1800mah_4S_35_70C_Lipo_Pack.html",
                    Capacity = 1800,
                    Weight = 207,
                    Length = 103,
                    Height = 35,
                    Width = 29,
                    Price = 19.35,
                    Config = 4,
                    MaxDischarge = 35,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 1800mah 4S 35~70C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__17296__Turnigy_nano_tech_1800mah_3S_25_50C_Lipo_AIRSOFT_Pack.html",
                    Capacity = 1800,
                    Weight = 147,
                    Length = 103,
                    Height = 20,
                    Width = 35,
                    Price = 14.95,
                    Config = 3,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 1800mah 3S 25~50C Lipo AIRSOFT Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__88007__Turnigy_Bolt_1800mAh_4S_15_2V_65_130C_High_Voltage_Lipoly_Pack_LiHV_.html",
                    Capacity = 1800,
                    Weight = 206,
                    Length = 104,
                    Height = 34,
                    Width = 27,
                    Price = 30.38,
                    Config = 4,
                    MaxDischarge = 65,
                    MaxCharge = 2,
                    Name = "Turnigy Bolt 1800mAh 4S 15.2V 65~130C High Voltage Lipoly Pack (LiHV)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__91182__Turnigy_Graphene_1800mAh_4S_65C_LiPo_Pack_w_XT60.html",
                    Capacity = 1800,
                    Weight = 240,
                    Length = 106,
                    Height = 36,
                    Width = 34,
                    Price = 31.15,
                    Config = 4,
                    MaxDischarge = 65,
                    MaxCharge = 10,
                    Name = "Turnigy Graphene 1800mAh 4S 65C LiPo Pack w/ XT60"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__88026__Fatshark_FPV_Headset_Battery_7_4v_1800mAh.html",
                    Capacity = 1800,
                    Weight = 0,
                    Length = 0,
                    Height = 0,
                    Width = 0,
                    Price = 24.99,
                    Config = 2,
                    MaxDischarge = 0,
                    MaxCharge = 0,
                    Name = "Fatshark FPV - Headset Battery 7.4v 1800mAh"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__17298__Turnigy_nano_tech_1800mah_3S_25_50C_Lipo_AIRSOFT_Pack.html",
                    Capacity = 1800,
                    Weight = 152,
                    Length = 101,
                    Height = 35,
                    Width = 7,
                    Price = 14.85,
                    Config = 3,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 1800mah 3S 25~50C Lipo AIRSOFT Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__11907__Turnigy_nano_tech_1800mah_2S_25_50C_Lipo_Pack.html",
                    Capacity = 1800,
                    Weight = 113,
                    Length = 115,
                    Height = 35,
                    Width = 15,
                    Price = 8.70,
                    Config = 2,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 1800mah 2S 25~50C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__17292__Turnigy_nano_tech_1800mah_3S_20_40C_Lipo_AIRSOFT_Pack.html",
                    Capacity = 1800,
                    Weight = 148,
                    Length = 105,
                    Height = 20,
                    Width = 35,
                    Price = 13.27,
                    Config = 3,
                    MaxDischarge = 20,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 1800mah 3S 20~40C Lipo AIRSOFT Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__19119__Turnigy_nano_tech_1800mah_2S_65C_130C_Lipo_Pack.html",
                    Capacity = 1800,
                    Weight = 124,
                    Length = 104,
                    Height = 35,
                    Width = 16,
                    Price = 13.98,
                    Config = 2,
                    MaxDischarge = 65,
                    MaxCharge = 8,
                    Name = "Turnigy nano-tech 1800mah 2S 65C~130C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__63384__ZIPPY_Compact_1800mAh_4s_40c_Lipo_Pack.html",
                    Capacity = 1800,
                    Weight = 208,
                    Length = 109,
                    Height = 35,
                    Width = 29,
                    Price = 19.98,
                    Config = 4,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 1800mAh 4s 40c Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__6541__ZIPPY_Flightmax_1800mAh_2S1P_20C.html",
                    Capacity = 1800,
                    Weight = 109,
                    Length = 104,
                    Height = 34,
                    Width = 16,
                    Price = 8.27,
                    Config = 2,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "ZIPPY Flightmax 1800mAh 2S1P 20C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9761__Turnigy_1800mAh_4S_20C_Lipo_Pack.html",
                    Capacity = 1800,
                    Weight = 196,
                    Length = 104,
                    Height = 34,
                    Width = 30,
                    Price = 16.51,
                    Config = 4,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "Turnigy 1800mAh 4S 20C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9936__ZIPPY_Flightmax_1800mAh_2S1P_40C.html",
                    Capacity = 1800,
                    Weight = 116,
                    Length = 103,
                    Height = 35,
                    Width = 15,
                    Price = 8.90,
                    Config = 2,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "ZIPPY Flightmax 1800mAh 2S1P 40C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21342__ZIPPY_Compact_1800mAh_2S_25C_Lipo_Pack.html",
                    Capacity = 1800,
                    Weight = 110,
                    Length = 105,
                    Height = 34,
                    Width = 16,
                    Price = 8.40,
                    Config = 2,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 1800mAh 2S 25C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__19121__Turnigy_nano_tech_1800mah_4S_65_130C_Lipo_Pack.html",
                    Capacity = 1800,
                    Weight = 228,
                    Length = 103,
                    Height = 35,
                    Width = 31,
                    Price = 27.60,
                    Config = 4,
                    MaxDischarge = 65,
                    MaxCharge = 8,
                    Name = "Turnigy nano-tech 1800mah 4S 65~130C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__86185__Turnigy_1800mAh_3S_20C_LiPoly_Pack_w_EC3_E_flite_Compatible_EFLB32003S_.html",
                    Capacity = 1800,
                    Weight = 150,
                    Length = 108,
                    Height = 36,
                    Width = 20,
                    Price = 11.25,
                    Config = 3,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "Turnigy 1800mAh 3S 20C LiPoly Pack w/ EC3 (E-flite Compatible EFLB32003S)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21343__ZIPPY_Compact_1800mAh_3S_25C_Lipo_Pack.html",
                    Capacity = 1800,
                    Weight = 153,
                    Length = 105,
                    Height = 35,
                    Width = 23,
                    Price = 12.55,
                    Config = 3,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 1800mAh 3S 25C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9458__Turnigy_1800mAh_4S_30C_Lipo_Pack.html",
                    Capacity = 1800,
                    Weight = 185,
                    Length = 105,
                    Height = 35,
                    Width = 26,
                    Price = 23.35,
                    Config = 4,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "Turnigy 1800mAh 4S 30C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__45128__Turnigy_nano_tech_A_SPEC_G2_1800mah_4S_65_130C_Lipo_Pack.html",
                    Capacity = 1800,
                    Weight = 205,
                    Length = 102,
                    Height = 31,
                    Width = 33,
                    Price = 35.80,
                    Config = 4,
                    MaxDischarge = 65,
                    MaxCharge = 8,
                    Name = "Turnigy nano-tech A-SPEC G2 1800mah 4S 65~130C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__6293__ZIPPY_Flightmax_1800mAh_3S1P_20C.html",
                    Capacity = 1800,
                    Weight = 152,
                    Length = 105,
                    Height = 34,
                    Width = 23,
                    Price = 12.31,
                    Config = 3,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "ZIPPY Flightmax 1800mAh 3S1P 20C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__11908__Turnigy_nano_tech_1800mah_3S_25_50C_Lipo_Pack.html",
                    Capacity = 1800,
                    Weight = 161,
                    Length = 115,
                    Height = 35,
                    Width = 21,
                    Price = 15.69,
                    Config = 3,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 1800mah 3S 25~50C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__19120__Turnigy_nano_tech_1800mah_3S_65_130C_Lipo_Pack.html",
                    Capacity = 1800,
                    Weight = 180,
                    Length = 103,
                    Height = 35,
                    Width = 25,
                    Price = 20.70,
                    Config = 3,
                    MaxDischarge = 65,
                    MaxCharge = 8,
                    Name = "Turnigy nano-tech 1800mah 3S 65~130C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__63383__ZIPPY_Compact_1800mAh_3s_40c_Lipo_Pack.html",
                    Capacity = 1800,
                    Weight = 161,
                    Length = 108,
                    Height = 35,
                    Width = 22,
                    Price = 15.01,
                    Config = 3,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 1800mAh 3s 40c Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__17295__Turnigy_nano_tech_1800mah_2S_25_50C_Lipo_AIRSOFT_Pack.html",
                    Capacity = 1800,
                    Weight = 100,
                    Length = 103,
                    Height = 13,
                    Width = 35,
                    Price = 10.38,
                    Config = 2,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 1800mah 2S 25~50C Lipo AIRSOFT Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9938__ZIPPY_Flightmax_1800mAh_4S1P_40C.html",
                    Capacity = 1800,
                    Weight = 222,
                    Length = 105,
                    Height = 35,
                    Width = 28,
                    Price = 17.00,
                    Config = 4,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "ZIPPY Flightmax 1800mAh 4S1P 40C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9169__Turnigy_1800mAh_2S_20C_Lipo_Pack.html",
                    Capacity = 1800,
                    Weight = 110,
                    Length = 105,
                    Height = 34,
                    Width = 16,
                    Price = 8.94,
                    Config = 2,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "Turnigy 1800mAh 2S 20C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__91181__Turnigy_Graphene_1800mAh_3S_65C_LiPo_Pack_w_XT60.html",
                    Capacity = 1800,
                    Weight = 188,
                    Length = 107,
                    Height = 36,
                    Width = 26,
                    Price = 24.49,
                    Config = 3,
                    MaxDischarge = 65,
                    MaxCharge = 10,
                    Name = "Turnigy Graphene 1800mAh 3S 65C LiPo Pack w/ XT60"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__28005__Turnigy_1800mAh_2S_12C_Lipo_Receiver_Pack.html",
                    Capacity = 1800,
                    Weight = 92,
                    Length = 64,
                    Height = 50,
                    Width = 14,
                    Price = 9.94,
                    Config = 2,
                    MaxDischarge = 12,
                    MaxCharge = 2,
                    Name = "Turnigy 1800mAh 2S 12C Lipo Receiver Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__10289__Turnigy_1800mAh_2S_40C_Lipo_Pack.html",
                    Capacity = 1800,
                    Weight = 125,
                    Length = 107,
                    Height = 35,
                    Width = 17,
                    Price = 11.06,
                    Config = 2,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "Turnigy 1800mAh 2S 40C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21344__ZIPPY_Compact_1800mAh_4S_25C_Lipo_Pack.html",
                    Capacity = 1800,
                    Weight = 196,
                    Length = 105,
                    Height = 34,
                    Width = 30,
                    Price = 16.70,
                    Config = 4,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 1800mAh 4S 25C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9368__Turnigy_1800mAh_2S_30C_Lipo_Pack.html",
                    Capacity = 1800,
                    Weight = 115,
                    Length = 102,
                    Height = 35,
                    Width = 15,
                    Price = 11.03,
                    Config = 2,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "Turnigy 1800mAh 2S 30C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__10291__Turnigy_1800mAh_4S_40C_Lipo_Pack.html",
                    Capacity = 1800,
                    Weight = 213,
                    Length = 110,
                    Height = 34,
                    Width = 27,
                    Price = 23.93,
                    Config = 4,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "Turnigy 1800mAh 4S 40C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__17293__Turnigy_nano_tech_1800mah_2S_20_40C_Lipo_AIRSOFT_Pack.html",
                    Capacity = 1800,
                    Weight = 103,
                    Length = 99,
                    Height = 35,
                    Width = 7,
                    Price = 8.55,
                    Config = 2,
                    MaxDischarge = 20,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 1800mah 2S 20~40C Lipo AIRSOFT Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__10290__Turnigy_1800mAh_3S_40C_Lipo_Pack.html",
                    Capacity = 1800,
                    Weight = 168,
                    Length = 109,
                    Height = 34,
                    Width = 21,
                    Price = 16.03,
                    Config = 3,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "Turnigy 1800mAh 3S 40C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9274__Turnigy_1800mAh_3S_20C_Lipo_Pack.html",
                    Capacity = 1800,
                    Weight = 153,
                    Length = 104,
                    Height = 34,
                    Width = 23,
                    Price = 11.88,
                    Config = 3,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "Turnigy 1800mAh 3S 20C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__17291__Turnigy_nano_tech_1800mah_2S_20_40C_Lipo_AIRSOFT_Pack.html",
                    Capacity = 1800,
                    Weight = 100,
                    Length = 103,
                    Height = 14,
                    Width = 34,
                    Price = 8.30,
                    Config = 2,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 1800mah 2S 20~40C Lipo AIRSOFT Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__25513__ZIPPY_Compact_1800mAh_4S_35C_Lipo_Pack.html",
                    Capacity = 1800,
                    Weight = 205,
                    Length = 108,
                    Height = 34,
                    Width = 29,
                    Price = 18.07,
                    Config = 4,
                    MaxDischarge = 35,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 1800mAh 4S 35C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__17294__Turnigy_nano_tech_1800mah_3S_20_40C_Lipo_AIRSOFT_Pack.html",
                    Capacity = 1800,
                    Weight = 150,
                    Length = 103,
                    Height = 7,
                    Width = 35,
                    Price = 12.70,
                    Config = 3,
                    MaxDischarge = 20,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 1800mah 3S 20~40C Lipo AIRSOFT Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__17297__Turnigy_nano_tech_1800mah_2S_25_50C_Lipo_AIRSOFT_Pack.html",
                    Capacity = 1800,
                    Weight = 103,
                    Length = 100,
                    Height = 35,
                    Width = 7,
                    Price = 10.00,
                    Config = 2,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 1800mah 2S 25~50C Lipo AIRSOFT Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__11909__Turnigy_nano_tech_1800mah_4S_25_50C_Lipo_Pack.html",
                    Capacity = 1800,
                    Weight = 188,
                    Length = 107,
                    Height = 35,
                    Width = 25,
                    Price = 17.35,
                    Config = 4,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 1800mah 4S 25~50C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__17284__Turnigy_nano_tech_2000mah_3S_15_25C_Lipo_AIRSOFT_Pack.html",
                    Capacity = 2000,
                    Weight = 155,
                    Length = 126,
                    Height = 21,
                    Width = 29,
                    Price = 14.95,
                    Config = 3,
                    MaxDischarge = 15,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 2000mah 3S 15~25C Lipo AIRSOFT Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__17286__Turnigy_nano_tech_2000mah_3S_15_25C_Lipo_AIRSOFT_Pack.html",
                    Capacity = 2000,
                    Weight = 162,
                    Length = 125,
                    Height = 20,
                    Width = 10,
                    Price = 15.30,
                    Config = 3,
                    MaxDischarge = 15,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 2000mah 3S 15~25C Lipo AIRSOFT Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__16472__ZIPPY_Flightmax_2000mAh_2S1P_45C.html",
                    Capacity = 2000,
                    Weight = 136,
                    Length = 102,
                    Height = 36,
                    Width = 16,
                    Price = 9.68,
                    Config = 2,
                    MaxDischarge = 45,
                    MaxCharge = 2,
                    Name = "ZIPPY Flightmax 2000mAh 2S1P 45C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__23820__Turnigy_nano_tech_2000mAh_2S1P_20_40C_Lipo_Receiver_Pack.html",
                    Capacity = 2000,
                    Weight = 98,
                    Length = 87,
                    Height = 34,
                    Width = 17,
                    Price = 12.45,
                    Config = 2,
                    MaxDischarge = 20,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 2000mAh 2S1P 20~40C Lipo Receiver Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__16474__ZIPPY_Flightmax_2000mAh_4S1P_45C.html",
                    Capacity = 2000,
                    Weight = 250,
                    Length = 103,
                    Height = 36,
                    Width = 32,
                    Price = 21.02,
                    Config = 4,
                    MaxDischarge = 45,
                    MaxCharge = 2,
                    Name = "ZIPPY Flightmax 2000mAh 4S1P 45C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__17283__Turnigy_nano_tech_2000mah_2S_15_25C_Lipo_AIRSOFT_Pack.html",
                    Capacity = 2000,
                    Weight = 106,
                    Length = 127,
                    Height = 21,
                    Width = 19,
                    Price = 10.00,
                    Config = 2,
                    MaxDischarge = 15,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 2000mah 2S 15~25C Lipo AIRSOFT Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__17285__Turnigy_nano_tech_2000mah_2S_15_25C_Lipo_AIRSOFT_Pack.html",
                    Capacity = 2000,
                    Weight = 109,
                    Length = 125,
                    Height = 21,
                    Width = 10,
                    Price = 10.60,
                    Config = 2,
                    MaxDischarge = 15,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 2000mah 2S 15~25C Lipo AIRSOFT Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__67728__Turnigy_nano_tech_2000mAh_2S_15_30C_Lipo_AIRSOFT_Pack_T_Connector_.html",
                    Capacity = 2000,
                    Weight = 109,
                    Length = 125,
                    Height = 21,
                    Width = 10,
                    Price = 10.42,
                    Config = 2,
                    MaxDischarge = 15,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 2000mAh 2S 15~30C Lipo AIRSOFT Pack (T-Connector)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__8272__ZIPPY_Flightmax_2100mAh_2S3P_7_4v_Receiver_Pack.html",
                    Capacity = 2100,
                    Weight = 94,
                    Length = 62,
                    Height = 35,
                    Width = 28,
                    Price = 12.80,
                    Config = 2,
                    MaxDischarge = 6,
                    MaxCharge = 2,
                    Name = "ZIPPY Flightmax 2100mAh 2S3P 7.4v Receiver Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__12613__Zippy_Flightmax_2100mAh_3S_35C_Lipo_Pack.html",
                    Capacity = 2100,
                    Weight = 200,
                    Length = 107,
                    Height = 34,
                    Width = 26,
                    Price = 11.87,
                    Config = 3,
                    MaxDischarge = 35,
                    MaxCharge = 2,
                    Name = "Zippy Flightmax 2100mAh 3S 35C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9312__Rhino_2150mAh_2S_7_4v_25C_Lipoly_Pack.html",
                    Capacity = 2150,
                    Weight = 122,
                    Length = 105,
                    Height = 34,
                    Width = 16,
                    Price = 8.38,
                    Config = 2,
                    MaxDischarge = 25,
                    MaxCharge = 2,
                    Name = "Rhino 2150mAh 2S 7.4v 25C Lipoly Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__7363__Rhino_2150mAh_3S1P_20C_Lipoly_Pack.html",
                    Capacity = 2150,
                    Weight = 160,
                    Length = 107,
                    Height = 34,
                    Width = 22,
                    Price = 10.41,
                    Config = 3,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "Rhino 2150mAh 3S1P 20C Lipoly Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9320__Rhino_2150mAh_4S_14_8v_30C_Lipoly_Pack.html",
                    Capacity = 2150,
                    Weight = 234,
                    Length = 106,
                    Height = 34,
                    Width = 33,
                    Price = 18.27,
                    Config = 4,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "Rhino 2150mAh 4S 14.8v 30C Lipoly Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9316__Rhino_2150mAh_2S_7_4v_30C_Lipoly_Pack.html",
                    Capacity = 2150,
                    Weight = 129,
                    Length = 111,
                    Height = 40,
                    Width = 16,
                    Price = 13.89,
                    Config = 2,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "Rhino 2150mAh 2S 7.4v 30C Lipoly Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__7362__Rhino_2150mAh_2S1P_20C_Lipoly_Pack.html",
                    Capacity = 2150,
                    Weight = 112,
                    Length = 104,
                    Height = 34,
                    Width = 16,
                    Price = 8.26,
                    Config = 2,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "Rhino 2150mAh 2S1P 20C Lipoly Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9319__Rhino_2150mAh_4S_14_8v_25C_Lipoly_Pack.html",
                    Capacity = 2150,
                    Weight = 223,
                    Length = 106,
                    Height = 34,
                    Width = 31,
                    Price = 16.05,
                    Config = 4,
                    MaxDischarge = 25,
                    MaxCharge = 2,
                    Name = "Rhino 2150mAh 4S 14.8v 25C Lipoly Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__11952__Turnigy_nano_tech_2200mah_4S_45_90C_Lipo_Pack.html",
                    Capacity = 2200,
                    Weight = 257,
                    Length = 109,
                    Height = 35,
                    Width = 33,
                    Price = 26.45,
                    Config = 4,
                    MaxDischarge = 45,
                    MaxCharge = 10,
                    Name = "Turnigy nano-tech 2200mah 4S 45~90C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__18559__Turnigy_2200mAh_1S_40C_Lipoly_Single_Cell_.html",
                    Capacity = 2200,
                    Weight = 58,
                    Length = 99,
                    Height = 34,
                    Width = 8,
                    Price = 4.45,
                    Config = 1,
                    MaxDischarge = 40,
                    MaxCharge = 2,
                    Name = "Turnigy 2200mAh 1S 40C Lipoly (Single Cell)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__11910__Turnigy_nano_tech_2200mah_2S_25_50C_Lipo_Pack.html",
                    Capacity = 2200,
                    Weight = 133,
                    Length = 112,
                    Height = 35,
                    Width = 18,
                    Price = 11.23,
                    Config = 2,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 2200mah 2S 25~50C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9942__ZIPPY_Flightmax_2200mAh_3S1P_40C.html",
                    Capacity = 2200,
                    Weight = 207,
                    Length = 105,
                    Height = 35,
                    Width = 26,
                    Price = 13.73,
                    Config = 3,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "ZIPPY Flightmax 2200mAh 3S1P 40C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__11951__Turnigy_nano_tech_2200mah_3S_45_90C_Lipo_Pack.html",
                    Capacity = 2200,
                    Weight = 201,
                    Length = 112,
                    Height = 36,
                    Width = 26,
                    Price = 19.99,
                    Config = 3,
                    MaxDischarge = 45,
                    MaxCharge = 10,
                    Name = "Turnigy nano-tech 2200mah 3S 45~90C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__45131__Turnigy_nano_tech_A_SPEC_G2_2200mah_4S_65_130C_Lipo_Pack.html",
                    Capacity = 2200,
                    Weight = 249,
                    Length = 103,
                    Height = 34,
                    Width = 33,
                    Price = 34.38,
                    Config = 4,
                    MaxDischarge = 65,
                    MaxCharge = 8,
                    Name = "Turnigy nano-tech A-SPEC G2 2200mah 4S 65~130C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__10279__Turnigy_2200mAh_3S_40C_Lipo_Pack.html",
                    Capacity = 2200,
                    Weight = 204,
                    Length = 104,
                    Height = 35,
                    Width = 27,
                    Price = 14.15,
                    Config = 3,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "Turnigy 2200mAh 3S 40C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__25430__Turnigy_nano_tech_A_SPEC_2200mah_6S_65_130C_Lipo_Pack.html",
                    Capacity = 2200,
                    Weight = 380,
                    Length = 105,
                    Height = 35,
                    Width = 52,
                    Price = 58.31,
                    Config = 6,
                    MaxDischarge = 65,
                    MaxCharge = 8,
                    Name = "Turnigy nano-tech A-SPEC 2200mah 6S 65~130C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__63391__ZIPPY_Compact_2200mAh_3s_60c_Lipo_Pack.html",
                    Capacity = 2200,
                    Weight = 208,
                    Length = 109,
                    Height = 35,
                    Width = 28,
                    Price = 16.00,
                    Config = 3,
                    MaxDischarge = 60,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 2200mAh 3s 60c Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__53680__Turnigy_Heavy_Duty_2200mAh_4S_60C_Lipo_Pack.html",
                    Capacity = 2200,
                    Weight = 257,
                    Length = 107,
                    Height = 34,
                    Width = 35,
                    Price = 25.02,
                    Config = 4,
                    MaxDischarge = 60,
                    MaxCharge = 2,
                    Name = "Turnigy Heavy Duty 2200mAh 4S 60C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9944__ZIPPY_Flightmax_2200mAh_5S1P_40C.html",
                    Capacity = 2200,
                    Weight = 305,
                    Length = 107,
                    Height = 35,
                    Width = 44,
                    Price = 23.54,
                    Config = 5,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "ZIPPY Flightmax 2200mAh 5S1P 40C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__91594__Multistar_Racer_Series_2200mAh_3S_40C_Multi_Rotor_LiPo_Pack.html",
                    Capacity = 2200,
                    Weight = 195,
                    Length = 105,
                    Height = 35,
                    Width = 27,
                    Price = 17.68,
                    Config = 3,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "Multistar Racer Series 2200mAh 3S 40C Multi-Rotor LiPo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__91183__Turnigy_Graphene_2200mAh_3S_45C_LiPo_Pack_w_XT60.html",
                    Capacity = 2200,
                    Weight = 211,
                    Length = 106,
                    Height = 35,
                    Width = 30,
                    Price = 25.19,
                    Config = 3,
                    MaxDischarge = 45,
                    MaxCharge = 10,
                    Name = "Turnigy Graphene 2200mAh 3S 45C LiPo Pack w/ XT60"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__8935__Turnigy_2200mAh_2S_25C_Lipo_Pack.html",
                    Capacity = 2200,
                    Weight = 134,
                    Length = 105,
                    Height = 33,
                    Width = 17,
                    Price = 9.99,
                    Config = 2,
                    MaxDischarge = 25,
                    MaxCharge = 2,
                    Name = "Turnigy 2200mAh 2S 25C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__63392__ZIPPY_Compact_2200mAh_4s_60c_Lipo_Pack.html",
                    Capacity = 2200,
                    Weight = 263,
                    Length = 105,
                    Height = 35,
                    Width = 37,
                    Price = 23.27,
                    Config = 4,
                    MaxDischarge = 60,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 2200mAh 4s 60c Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__8932__Turnigy_2200mAh_3S_20C_Lipo_Pack.html",
                    Capacity = 2200,
                    Weight = 188,
                    Length = 103,
                    Height = 33,
                    Width = 24,
                    Price = 9.99,
                    Config = 3,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "Turnigy 2200mAh 3S 20C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__63388__ZIPPY_Compact_2200mAh_4s_40c_Lipo_Pack.html",
                    Capacity = 2200,
                    Weight = 248,
                    Length = 105,
                    Height = 34,
                    Width = 34,
                    Price = 21.09,
                    Config = 4,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 2200mAh 4s 40c Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__8934__Turnigy_2200mAh_3S_25C_Lipo_Pack.html",
                    Capacity = 2200,
                    Weight = 188,
                    Length = 105,
                    Height = 33,
                    Width = 24,
                    Price = 11.69,
                    Config = 3,
                    MaxDischarge = 25,
                    MaxCharge = 4,
                    Name = "Turnigy 2200mAh 3S 25C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__18558__Turnigy_2200mAh_1S_20C_Lipoly_Single_Cell_.html",
                    Capacity = 2200,
                    Weight = 55,
                    Length = 97,
                    Height = 34,
                    Width = 8,
                    Price = 4.21,
                    Config = 1,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "Turnigy 2200mAh 1S 20C Lipoly (Single Cell)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__63387__ZIPPY_Compact_2200mAh_3s_40c_Lipo_Pack.html",
                    Capacity = 2200,
                    Weight = 196,
                    Length = 109,
                    Height = 34,
                    Width = 27,
                    Price = 19.43,
                    Config = 3,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 2200mAh 3s 40c Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9461__Turnigy_2200mAh_5S_30C_Lipo_Pack.html",
                    Capacity = 2200,
                    Weight = 316,
                    Length = 108,
                    Height = 34,
                    Width = 45,
                    Price = 26.03,
                    Config = 5,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "Turnigy 2200mAh 5S 30C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__31315__Turnigy_9XR_Safety_Protected_11_1v_3s_2200mAh_1_5C_Transmitter_Pack.html",
                    Capacity = 2200,
                    Weight = 139,
                    Length = 100,
                    Height = 33,
                    Width = 19,
                    Price = 13.84,
                    Config = 3,
                    MaxDischarge = 1.5,
                    MaxCharge = 1,
                    Name = "Turnigy 9XR Safety Protected 11.1v (3s) 2200mAh 1.5C Transmitter Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__6540__ZIPPY_Flightmax_2200mAh_2S1P_20C.html",
                    Capacity = 2200,
                    Weight = 133,
                    Length = 104,
                    Height = 34,
                    Width = 17,
                    Price = 7.57,
                    Config = 2,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "ZIPPY Flightmax 2200mAh 2S1P 20C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21345__ZIPPY_Compact_2200mAh_2S_25C_Lipo_Pack.html",
                    Capacity = 2200,
                    Weight = 113,
                    Length = 104,
                    Height = 35,
                    Width = 14,
                    Price = 10.40,
                    Config = 2,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 2200mAh 2S 25C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9459__Turnigy_2200mAh_2S_30C_Lipo_Pack.html",
                    Capacity = 2200,
                    Weight = 135,
                    Length = 105,
                    Height = 34,
                    Width = 16,
                    Price = 9.98,
                    Config = 2,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "Turnigy 2200mAh 2S 30C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__91186__Turnigy_Graphene_2200mAh_4S_65C_Lipo_Pack_w_XT60.html",
                    Capacity = 2200,
                    Weight = 295,
                    Length = 106,
                    Height = 35,
                    Width = 41,
                    Price = 34.38,
                    Config = 4,
                    MaxDischarge = 65,
                    MaxCharge = 10,
                    Name = "Turnigy Graphene 2200mAh 4S 65C Lipo Pack w/XT60"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__83447__Turnigy_nano_tech_2200mah_6S_45_90C_LiPoly_Battery.html",
                    Capacity = 2200,
                    Weight = 365,
                    Length = 105,
                    Height = 42,
                    Width = 38,
                    Price = 39.73,
                    Config = 6,
                    MaxDischarge = 45,
                    MaxCharge = 8,
                    Name = "Turnigy nano-tech 2200mah 6S 45~90C LiPoly Battery"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__10383__Turnigy_2200mAh_3S_35C_Lipo_Pack.html",
                    Capacity = 2200,
                    Weight = 199,
                    Length = 108,
                    Height = 34,
                    Width = 26,
                    Price = 13.34,
                    Config = 3,
                    MaxDischarge = 35,
                    MaxCharge = 2,
                    Name = "Turnigy 2200mAh 3S 35C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21393__ZIPPY_Compact_2200mAh_3S_35C_Lipo_Pack.html",
                    Capacity = 2200,
                    Weight = 181,
                    Length = 114,
                    Height = 34,
                    Width = 21,
                    Price = 14.84,
                    Config = 3,
                    MaxDischarge = 35,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 2200mAh 3S 35C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9162__ZIPPY_Flightmax_2200mAh_4S1P_30C.html",
                    Capacity = 2200,
                    Weight = 233,
                    Length = 103,
                    Height = 35,
                    Width = 34,
                    Price = 22.03,
                    Config = 4,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "ZIPPY Flightmax 2200mAh 4S1P 30C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__16479__ZIPPY_Flightmax_2200mAh_4S1P_45C.html",
                    Capacity = 2200,
                    Weight = 248,
                    Length = 104,
                    Height = 34,
                    Width = 34,
                    Price = 23.05,
                    Config = 4,
                    MaxDischarge = 45,
                    MaxCharge = 2,
                    Name = "ZIPPY Flightmax 2200mAh 4S1P 45C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__10280__Turnigy_2200mAh_4S_40C_Lipo_Pack.html",
                    Capacity = 2200,
                    Weight = 248,
                    Length = 105,
                    Height = 34,
                    Width = 34,
                    Price = 24.39,
                    Config = 4,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "Turnigy 2200mAh 4S 40C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__91184__Turnigy_Graphene_2200mAh_3S_65C_LiPo_Pack_w_XT60.html",
                    Capacity = 2200,
                    Weight = 225,
                    Length = 106,
                    Height = 35,
                    Width = 31,
                    Price = 25.99,
                    Config = 3,
                    MaxDischarge = 65,
                    MaxCharge = 10,
                    Name = "Turnigy Graphene 2200mAh 3S 65C LiPo Pack w/ XT60"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__63390__ZIPPY_Compact_2200mAh_2s_60c_Lipo_Pack.html",
                    Capacity = 2200,
                    Weight = 145,
                    Length = 106,
                    Height = 35,
                    Width = 19,
                    Price = 12.10,
                    Config = 2,
                    MaxDischarge = 60,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 2200mAh 2s 60c Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__11911__Turnigy_nano_tech_2200mah_3S_25_50C_Lipo_Pack.html",
                    Capacity = 2200,
                    Weight = 187,
                    Length = 106,
                    Height = 35,
                    Width = 24,
                    Price = 16.84,
                    Config = 3,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 2200mah 3S 25~50C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21347__ZIPPY_Compact_2200mAh_4S_25C_Lipo_Pack.html",
                    Capacity = 2200,
                    Weight = 210,
                    Length = 107,
                    Height = 28,
                    Width = 34,
                    Price = 15.80,
                    Config = 4,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 2200mAh 4S 25C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9460__Turnigy_2200mAh_4S_30C_Lipo_Pack.html",
                    Capacity = 2200,
                    Weight = 258,
                    Length = 105,
                    Height = 34,
                    Width = 35,
                    Price = 24.08,
                    Config = 4,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "Turnigy 2200mAh 4S 30C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9270__Turnigy_2200mAh_4S1P_20C_Lipo_Pack.html",
                    Capacity = 2200,
                    Weight = 247,
                    Length = 105,
                    Height = 34,
                    Width = 33,
                    Price = 17.65,
                    Config = 4,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "Turnigy 2200mAh 4S1P 20C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9943__ZIPPY_Flightmax_2200mAh_4S1P_40C.html",
                    Capacity = 2200,
                    Weight = 250,
                    Length = 105,
                    Height = 35,
                    Width = 30,
                    Price = 20.00,
                    Config = 4,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "ZIPPY Flightmax 2200mAh 4S1P 40C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__38516__Turnigy_Heavy_Duty_2200mAh_3S_60C_Lipo_Pack.html",
                    Capacity = 2200,
                    Weight = 198,
                    Length = 107,
                    Height = 34,
                    Width = 27,
                    Price = 18.20,
                    Config = 3,
                    MaxDischarge = 60,
                    MaxCharge = 2,
                    Name = "Turnigy Heavy Duty 2200mAh 3S 60C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__45130__Turnigy_nano_tech_A_SPEC_G2_2200mah_3S_65_130C_Lipo_Pack.html",
                    Capacity = 2200,
                    Weight = 192,
                    Length = 103,
                    Height = 34,
                    Width = 26,
                    Price = 29.99,
                    Config = 3,
                    MaxDischarge = 65,
                    MaxCharge = 8,
                    Name = "Turnigy nano-tech A-SPEC G2 2200mah 3S 65~130C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__11945__Turnigy_nano_tech_2200mah_4S_35_70C_Lipo_Pack.html",
                    Capacity = 2200,
                    Weight = 253,
                    Length = 117,
                    Height = 36,
                    Width = 35,
                    Price = 23.25,
                    Config = 4,
                    MaxDischarge = 35,
                    MaxCharge = 8,
                    Name = "Turnigy nano-tech 2200mah 4S 35~70C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__54360__Turnigy_2200mAh_3S_30C_Lipo_Pack_with_EC3_plug_E_Flite_Compatible_EFLB21003S_.html",
                    Capacity = 2200,
                    Weight = 199,
                    Length = 108,
                    Height = 34,
                    Width = 26,
                    Price = 13.50,
                    Config = 3,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "Turnigy 2200mAh 3S 30C Lipo Pack with EC3 plug (E-Flite Compatible EFLB21003S)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__11944__Turnigy_nano_tech_2200mah_3S_35_70C_Lipo_Pack.html",
                    Capacity = 2200,
                    Weight = 199,
                    Length = 115,
                    Height = 35,
                    Width = 27,
                    Price = 18.99,
                    Config = 3,
                    MaxDischarge = 35,
                    MaxCharge = 8,
                    Name = "Turnigy nano-tech 2200mah 3S 35~70C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__10278__Turnigy_2200mAh_2S_40C_Lipo_Pack.html",
                    Capacity = 2200,
                    Weight = 140,
                    Length = 105,
                    Height = 34,
                    Width = 17,
                    Price = 11.99,
                    Config = 2,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "Turnigy 2200mAh 2S 40C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9394__Turnigy_2200mAh_3S_30C_Lipo_Pack.html",
                    Capacity = 2200,
                    Weight = 197,
                    Length = 108,
                    Height = 34,
                    Width = 27,
                    Price = 12.96,
                    Config = 3,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "Turnigy 2200mAh 3S 30C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__11912__Turnigy_nano_tech_2200mah_4S_25_50C_Lipo_Pack.html",
                    Capacity = 2200,
                    Weight = 239,
                    Length = 119,
                    Height = 35,
                    Width = 32,
                    Price = 19.65,
                    Config = 4,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 2200mah 4S 25~50C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9941__ZIPPY_Flightmax_2200mAh_2S1P_40C.html",
                    Capacity = 2200,
                    Weight = 143,
                    Length = 105,
                    Height = 35,
                    Width = 18,
                    Price = 10.37,
                    Config = 2,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "ZIPPY Flightmax 2200mAh 2S1P 40C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__7636__ZIPPY_Flightmax_2200mAh_3S1P_25C.html",
                    Capacity = 2200,
                    Weight = 173,
                    Length = 104,
                    Height = 36,
                    Width = 25,
                    Price = 11.81,
                    Config = 3,
                    MaxDischarge = 25,
                    MaxCharge = 2,
                    Name = "ZIPPY Flightmax 2200mAh 3S1P 25C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__89421__Turnigy_Bolt_2200mAh_3S_11_4V_65_130C_High_Voltage_Lipoly_Pack_LiHV_.html",
                    Capacity = 2200,
                    Weight = 203,
                    Length = 113,
                    Height = 36,
                    Width = 26,
                    Price = 28.87,
                    Config = 3,
                    MaxDischarge = 65,
                    MaxCharge = 2,
                    Name = "Turnigy Bolt 2200mAh 3S 11.4V 65~130C High Voltage Lipoly Pack (LiHV)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__91185__Turnigy_Graphene_2200mAh_4S_45C_Lipo_Pack_w_XT60.html",
                    Capacity = 2200,
                    Weight = 273,
                    Length = 106,
                    Height = 35,
                    Width = 39,
                    Price = 30.48,
                    Config = 4,
                    MaxDischarge = 45,
                    MaxCharge = 10,
                    Name = "Turnigy Graphene 2200mAh 4S 45C Lipo Pack w/XT60"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21392__ZIPPY_Compact_2200mAh_2S_35C_Lipo_Pack.html",
                    Capacity = 2200,
                    Weight = 125,
                    Length = 111,
                    Height = 35,
                    Width = 15,
                    Price = 9.57,
                    Config = 2,
                    MaxDischarge = 35,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 2200mAh 2S 35C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__16478__ZIPPY_Flightmax_2200mAh_3S1P_45C.html",
                    Capacity = 2200,
                    Weight = 198,
                    Length = 107,
                    Height = 37,
                    Width = 24,
                    Price = 18.69,
                    Config = 3,
                    MaxDischarge = 45,
                    MaxCharge = 4,
                    Name = "ZIPPY Flightmax 2200mAh 3S1P 45C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__8933__Turnigy_2200mAh_2S_20C_Lipo_Pack_.html",
                    Capacity = 2200,
                    Weight = 130,
                    Length = 105,
                    Height = 33,
                    Width = 16,
                    Price = 8.93,
                    Config = 2,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "Turnigy 2200mAh 2S 20C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__16477__ZIPPY_Flightmax_2200mAh_2S1P_45C.html",
                    Capacity = 2200,
                    Weight = 148,
                    Length = 101,
                    Height = 37,
                    Width = 18,
                    Price = 12.46,
                    Config = 2,
                    MaxDischarge = 45,
                    MaxCharge = 2,
                    Name = "ZIPPY Flightmax 2200mAh 2S1P 45C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9611__Rhino_2250mAh_4S_14_8v_40C_Lipoly_Pack.html",
                    Capacity = 2250,
                    Weight = 243,
                    Length = 104,
                    Height = 35,
                    Width = 34,
                    Price = 19.57,
                    Config = 4,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "Rhino 2250mAh 4S 14.8v 40C Lipoly Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__19124__Turnigy_nano_tech_2250mah_4S_65_130C_Lipo_Pack.html",
                    Capacity = 2250,
                    Weight = 268,
                    Length = 103,
                    Height = 35,
                    Width = 36,
                    Price = 34.97,
                    Config = 4,
                    MaxDischarge = 65,
                    MaxCharge = 8,
                    Name = "Turnigy nano-tech 2250mah 4S 65~130C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__19122__Turnigy_nano_tech_2250mah_2S_65_130C_Lipo_Pack.html",
                    Capacity = 2250,
                    Weight = 142,
                    Length = 103,
                    Height = 35,
                    Width = 19,
                    Price = 17.25,
                    Config = 2,
                    MaxDischarge = 65,
                    MaxCharge = 8,
                    Name = "Turnigy nano-tech 2250mah 2S 65~130C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__19123__Turnigy_nano_tech_2250mah_3S_65_130C_Lipo_Pack.html",
                    Capacity = 2250,
                    Weight = 207,
                    Length = 104,
                    Height = 35,
                    Width = 27,
                    Price = 29.94,
                    Config = 3,
                    MaxDischarge = 65,
                    MaxCharge = 8,
                    Name = "Turnigy nano-tech 2250mah 3S 65~130C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9612__Rhino_2250mAh_3S_11_1v_40C_Lipoly_Pack.html",
                    Capacity = 2250,
                    Weight = 191,
                    Length = 107,
                    Height = 34,
                    Width = 26,
                    Price = 16.06,
                    Config = 3,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "Rhino 2250mAh 3S 11.1v 40C Lipoly Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__7314__Rhino_2250mAh_3S_11_1v_25C_Lipoly_Pack.html",
                    Capacity = 2250,
                    Weight = 190,
                    Length = 114,
                    Height = 35,
                    Width = 23,
                    Price = 13.03,
                    Config = 3,
                    MaxDischarge = 25,
                    MaxCharge = 2,
                    Name = "Rhino 2250mAh 3S 11.1v 25C Lipoly Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__7361__Rhino_2350mAh_4S1P_20C_Lipoly_Pack.html",
                    Capacity = 2350,
                    Weight = 257,
                    Length = 138,
                    Height = 45,
                    Width = 22,
                    Price = 16.96,
                    Config = 4,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "Rhino 2350mAh 4S1P 20C Lipoly Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__51500__Turnigy_Bolt_2400mAh_4S_15_2V_65_130C_High_Voltage_Lipoly_Pack_LiHV_.html",
                    Capacity = 2400,
                    Weight = 248,
                    Length = 114,
                    Height = 33,
                    Width = 34,
                    Price = 35.25,
                    Config = 4,
                    MaxDischarge = 65,
                    MaxCharge = 2,
                    Name = "Turnigy Bolt 2400mAh 4S 15.2V 65~130C High Voltage Lipoly Pack (LiHV)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__51499__Turnigy_Bolt_2400mAh_3S_11_4V_65_130C_High_Voltage_Lipoly_Pack.html",
                    Capacity = 2400,
                    Weight = 197,
                    Length = 114,
                    Height = 25.4,
                    Width = 34,
                    Price = 28.34,
                    Config = 3,
                    MaxDischarge = 65,
                    MaxCharge = 2,
                    Name = "Turnigy Bolt 2400mAh 3S 11.4V 65~130C High Voltage Lipoly Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__10274__Turnigy_2450mAh_3S_30C_Lipo_Pack.html",
                    Capacity = 2450,
                    Weight = 218,
                    Length = 138,
                    Height = 43,
                    Width = 18,
                    Price = 16.14,
                    Config = 3,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "Turnigy 2450mAh 3S 30C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9928__ZIPPY_Flightmax_2450mAh_4S1P_30C.html",
                    Capacity = 2450,
                    Weight = 295,
                    Length = 137,
                    Height = 45,
                    Width = 23,
                    Price = 22.03,
                    Config = 4,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "ZIPPY Flightmax 2450mAh 4S1P 30C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__25514__ZIPPY_Compact_2450mAh_3S_35C_Lipo_Pack.html",
                    Capacity = 2450,
                    Weight = 210,
                    Length = 114,
                    Height = 34,
                    Width = 25,
                    Price = 20.68,
                    Config = 3,
                    MaxDischarge = 35,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 2450mAh 3S 35C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__25515__ZIPPY_Compact_2450mAh_4S_35C_Lipo_Pack.html",
                    Capacity = 2450,
                    Weight = 265,
                    Length = 114,
                    Height = 34,
                    Width = 32,
                    Price = 27.09,
                    Config = 4,
                    MaxDischarge = 35,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 2450mAh 4S 35C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__10275__Turnigy_2450mAh_4S_30C_Lipo_Pack.html",
                    Capacity = 2450,
                    Weight = 286,
                    Length = 136,
                    Height = 43,
                    Width = 24,
                    Price = 24.08,
                    Config = 4,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "Turnigy 2450mAh 4S 30C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__23814__Turnigy_nano_tech_2500mAh_3S1P_5_10C_Transmitter_Lipo_Pack_Futaba_6EX_and_3PKS_.html",
                    Capacity = 2500,
                    Weight = 155,
                    Length = 106,
                    Height = 50,
                    Width = 14,
                    Price = 15.99,
                    Config = 3,
                    MaxDischarge = 5,
                    MaxCharge = 2,
                    Name = "Turnigy nano-tech 2500mAh 3S1P 5~10C Transmitter Lipo Pack (Futaba 6EX and 3PKS)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__23813__Turnigy_nano_tech_2500mAh_3S1P_5_10C_Transmitter_Lipo_Pack.html",
                    Capacity = 2500,
                    Weight = 147,
                    Length = 95,
                    Height = 30,
                    Width = 24,
                    Price = 15.99,
                    Config = 3,
                    MaxDischarge = 5,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 2500mAh 3S1P 5~10C Transmitter Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__6955__ZIPPY_Flightmax_2500mAh_Transmitter_Pack_Futaba_JR_.html",
                    Capacity = 2500,
                    Weight = 156,
                    Length = 99,
                    Height = 31,
                    Width = 26,
                    Price = 16.07,
                    Config = 3,
                    MaxDischarge = 3,
                    MaxCharge = 2,
                    Name = "ZIPPY Flightmax 2500mAh Transmitter Pack (Futaba/JR)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__86191__Turnigy_2500mAh_3S_30C_LiPoly_Pack_w_EC3_E_flite_Compatible_EFLB25003S30_.html",
                    Capacity = 2500,
                    Weight = 215,
                    Length = 139,
                    Height = 45,
                    Width = 19,
                    Price = 17.10,
                    Config = 3,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "Turnigy 2500mAh 3S 30C LiPoly Pack w/ EC3 (E-flite Compatible EFLB25003S30)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__84046__Turnigy_nano_tech_A_SPEC_G2_2600mah_6S_60_90C_Lipoly_Pack.html",
                    Capacity = 2600,
                    Weight = 447,
                    Length = 132,
                    Height = 40,
                    Width = 42,
                    Price = 66.43,
                    Config = 6,
                    MaxDischarge = 60,
                    MaxCharge = 2,
                    Name = "Turnigy nano-tech A-SPEC G2 2600mah 6S 60~90C Lipoly Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__7346__Rhino_2620mAh_3S_11_1v_Low_Discharge_Transmitter_Lipoly_Pack.html",
                    Capacity = 2620,
                    Weight = 160,
                    Length = 102,
                    Height = 30,
                    Width = 26,
                    Price = 18.00,
                    Config = 3,
                    MaxDischarge = 3,
                    MaxCharge = 2,
                    Name = "Rhino 2620mAh 3S 11.1v Low-Discharge Transmitter Lipoly Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__11948__Turnigy_nano_tech_2650mAh_6S_35_70C_Lipo_Pack.html",
                    Capacity = 2650,
                    Weight = 417,
                    Length = 146,
                    Height = 44,
                    Width = 33,
                    Price = 41.13,
                    Config = 6,
                    MaxDischarge = 35,
                    MaxCharge = 8,
                    Name = "Turnigy nano-tech 2650mAh 6S 35~70C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9268__Turnigy_2650mAh_6S_30C_Lipo_Pack.html",
                    Capacity = 2650,
                    Weight = 430,
                    Length = 140,
                    Height = 45,
                    Width = 35,
                    Price = 31.69,
                    Config = 6,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "Turnigy 2650mAh 6S 30C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9947__ZIPPY_Flightmax_2650mAh_3S1P_40C.html",
                    Capacity = 2650,
                    Weight = 228,
                    Length = 135,
                    Height = 45,
                    Width = 19,
                    Price = 19.71,
                    Config = 3,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "ZIPPY Flightmax 2650mAh 3S1P 40C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__11917__Turnigy_nano_tech_2650mah_6S_25_50C_Lipo_Pack.html",
                    Capacity = 2650,
                    Weight = 399,
                    Length = 149,
                    Height = 44,
                    Width = 31,
                    Price = 27.37,
                    Config = 6,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 2650mah 6S 25~50C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__17259__Turnigy_nano_tech_2650mah_6S_45_90C_Lipo_Pack.html",
                    Capacity = 2650,
                    Weight = 427,
                    Length = 135,
                    Height = 44,
                    Width = 33,
                    Price = 50.26,
                    Config = 6,
                    MaxDischarge = 45,
                    MaxCharge = 10,
                    Name = "Turnigy nano-tech 2650mah 6S 45~90C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9267__Turnigy_2650mAh_3S_30C_Lipo_Pack.html",
                    Capacity = 2650,
                    Weight = 247,
                    Length = 140,
                    Height = 44,
                    Width = 19,
                    Price = 15.64,
                    Config = 3,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "Turnigy 2650mAh 3S 30C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__11947__Turnigy_nano_tech_2650mah_4S_35_70C_Lipo_Pack_.html",
                    Capacity = 2650,
                    Weight = 291,
                    Length = 145,
                    Height = 45,
                    Width = 22,
                    Price = 29.99,
                    Config = 4,
                    MaxDischarge = 35,
                    MaxCharge = 8,
                    Name = "Turnigy nano-tech 2650mah 4S 35~70C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__10296__Turnigy_2650mAh_6S_40C_Lipo_Pack.html",
                    Capacity = 2650,
                    Weight = 468,
                    Length = 138,
                    Height = 44,
                    Width = 38,
                    Price = 38.00,
                    Config = 6,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "Turnigy 2650mAh 6S 40C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9181__Turnigy_2650mAh_6S_20C_Lipo_Pack.html",
                    Capacity = 2650,
                    Weight = 380,
                    Length = 139,
                    Height = 44,
                    Width = 31,
                    Price = 22.98,
                    Config = 6,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "Turnigy 2650mAh 6S 20C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9271__Turnigy_2650mAh_3S_20C_Lipo_Pack_.html",
                    Capacity = 2650,
                    Weight = 213,
                    Length = 137,
                    Height = 43,
                    Width = 17,
                    Price = 12.35,
                    Config = 3,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "Turnigy 2650mAh 3S 20C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9948__ZIPPY_Flightmax_2650mAh_4S1P_40C.html",
                    Capacity = 2650,
                    Weight = 318,
                    Length = 137,
                    Height = 45,
                    Width = 24,
                    Price = 26.19,
                    Config = 4,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "ZIPPY Flightmax 2650mAh 4S1P 40C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__11916__Turnigy_nano_tech_2650mah_4S_25_50C_Lipo_Pack_.html",
                    Capacity = 2650,
                    Weight = 275,
                    Length = 145,
                    Height = 44,
                    Width = 22,
                    Price = 26.54,
                    Config = 4,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 2650mah 4S 25~50C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__16529__Turnigy_2650mAh_3S_1C_Lipoly_Tx_Pack_Futaba_JR_.html",
                    Capacity = 2650,
                    Weight = 157,
                    Length = 98,
                    Height = 30,
                    Width = 27,
                    Price = 12.79,
                    Config = 3,
                    MaxDischarge = 1,
                    MaxCharge = 1,
                    Name = "Turnigy 2650mAh 3S 1C Lipoly Tx Pack (Futaba/JR)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__11946__Turnigy_nano_tech_2650mah_3S_35_70C_Lipo_Pack_.html",
                    Capacity = 2650,
                    Weight = 220,
                    Length = 134,
                    Height = 44,
                    Width = 17,
                    Price = 22.99,
                    Config = 3,
                    MaxDischarge = 35,
                    MaxCharge = 8,
                    Name = "Turnigy nano-tech 2650mah 3S 35~70C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__11915__Turnigy_nano_tech_2650mah_3S_25_50C_Lipo_Pack.html",
                    Capacity = 2650,
                    Weight = 215,
                    Length = 148,
                    Height = 44,
                    Width = 18,
                    Price = 17.45,
                    Config = 3,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 2650mah 3S 25~50C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__16484__ZIPPY_Flightmax_2650mAh_4S1P_45C.html",
                    Capacity = 2650,
                    Weight = 329,
                    Length = 137,
                    Height = 45,
                    Width = 25,
                    Price = 25.90,
                    Config = 4,
                    MaxDischarge = 45,
                    MaxCharge = 2,
                    Name = "ZIPPY Flightmax 2650mAh 4S1P 45C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__16486__ZIPPY_Flightmax_2650mAh_6S1P_45C.html",
                    Capacity = 2650,
                    Weight = 484,
                    Length = 137,
                    Height = 45,
                    Width = 37,
                    Price = 39.04,
                    Config = 6,
                    MaxDischarge = 45,
                    MaxCharge = 2,
                    Name = "ZIPPY Flightmax 2650mAh 6S1P 45C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9182__Turnigy_2650mAh_4S_20C_Lipo_Pack.html",
                    Capacity = 2650,
                    Weight = 265,
                    Length = 137,
                    Height = 44,
                    Width = 22,
                    Price = 16.48,
                    Config = 4,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "Turnigy 2650mAh 4S 20C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9950__ZIPPY_Flightmax_2650mAh_6S1P_40C.html",
                    Capacity = 2650,
                    Weight = 420,
                    Length = 140,
                    Height = 45,
                    Width = 34,
                    Price = 35.02,
                    Config = 6,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "ZIPPY Flightmax 2650mAh 6S1P 40C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__19128__Turnigy_nano_tech_2700mah_3S_65_130C_Lipo_Pack.html",
                    Capacity = 2700,
                    Weight = 252,
                    Length = 134,
                    Height = 43,
                    Width = 20,
                    Price = 31.51,
                    Config = 3,
                    MaxDischarge = 65,
                    MaxCharge = 8,
                    Name = "Turnigy nano-tech 2700mah 3S 65~130C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__19131__Turnigy_nano_tech_2700mah_6S_65_130C_Lipo_Pack.html",
                    Capacity = 2700,
                    Weight = 483,
                    Length = 135,
                    Height = 43,
                    Width = 40,
                    Price = 63.01,
                    Config = 6,
                    MaxDischarge = 65,
                    MaxCharge = 8,
                    Name = "Turnigy nano-tech 2700mah 6S 65~130C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21352__ZIPPY_Compact_2700mAh_6S_25C_Lipo_Pack.html",
                    Capacity = 2700,
                    Weight = 380,
                    Length = 137,
                    Height = 30,
                    Width = 45,
                    Price = 30.38,
                    Config = 6,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 2700mAh 6S 25C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21351__ZIPPY_Compact_2700mAh_5S_25C_Lipo_Pack.html",
                    Capacity = 2700,
                    Weight = 320,
                    Length = 136,
                    Height = 24,
                    Width = 44,
                    Price = 23.55,
                    Config = 5,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 2700mAh 5S 25C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__19129__Turnigy_nano_tech_2700mah_4S_65_130C_Lipo_Pack.html",
                    Capacity = 2700,
                    Weight = 332,
                    Length = 134,
                    Height = 44,
                    Width = 27,
                    Price = 41.37,
                    Config = 4,
                    MaxDischarge = 65,
                    MaxCharge = 8,
                    Name = "Turnigy nano-tech 2700mah 4S 65~130C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__63393__ZIPPY_Compact_2700mAh_3s_40c_Lipo_Pack.html",
                    Capacity = 2700,
                    Weight = 235,
                    Length = 137,
                    Height = 45,
                    Width = 20,
                    Price = 20.64,
                    Config = 3,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 2700mAh 3s 40c Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21350__ZIPPY_Compact_2700mAh_4S_25C_Lipo_Pack.html",
                    Capacity = 2700,
                    Weight = 278,
                    Length = 137,
                    Height = 44,
                    Width = 23,
                    Price = 20.30,
                    Config = 4,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 2700mAh 4S 25C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__19130__Turnigy_nano_tech_2700mah_5S_65_130C_Lipo_Pack.html",
                    Capacity = 2700,
                    Weight = 404,
                    Length = 135,
                    Height = 43,
                    Width = 34,
                    Price = 51.69,
                    Config = 5,
                    MaxDischarge = 65,
                    MaxCharge = 8,
                    Name = "Turnigy nano-tech 2700mah 5S 65~130C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__56095__Turnigy_2700mAh_3S_20C_Lipo_Pack_Suitable_for_Quanum_Nova_Phantom_QR_X350_.html",
                    Capacity = 2700,
                    Weight = 198,
                    Length = 102,
                    Height = 35,
                    Width = 28,
                    Price = 19.40,
                    Config = 3,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "Turnigy 2700mAh 3S 20C Lipo Pack (Suitable for Quanum Nova, Phantom, QR X350)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__63396__ZIPPY_Compact_2700mAh_4s_60c_Lipo_Pack.html",
                    Capacity = 2700,
                    Weight = 317,
                    Length = 139,
                    Height = 45,
                    Width = 27,
                    Price = 30.77,
                    Config = 4,
                    MaxDischarge = 60,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 2700mAh 4s 60c Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21396__ZIPPY_Compact_2700mAh_3S_35C_Lipo_Pack.html",
                    Capacity = 2700,
                    Weight = 222,
                    Length = 139,
                    Height = 44,
                    Width = 16,
                    Price = 19.50,
                    Config = 3,
                    MaxDischarge = 35,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 2700mAh 3S 35C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__63394__ZIPPY_Compact_2700mAh_4s_40c_Lipo_Pack.html",
                    Capacity = 2700,
                    Weight = 306,
                    Length = 138,
                    Height = 45,
                    Width = 26,
                    Price = 25.84,
                    Config = 4,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 2700mAh 4s 40c Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21349__ZIPPY_Compact_2700mAh_3S_25C_Lipo_Pack.html",
                    Capacity = 2700,
                    Weight = 199,
                    Length = 137,
                    Height = 15,
                    Width = 44,
                    Price = 15.30,
                    Config = 3,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 2700mAh 3S 25C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21398__ZIPPY_Compact_2700mAh_5S_35C_Lipo_Pack.html",
                    Capacity = 2700,
                    Weight = 357,
                    Length = 139,
                    Height = 45,
                    Width = 27,
                    Price = 30.04,
                    Config = 5,
                    MaxDischarge = 35,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 2700mAh 5S 35C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21348__ZIPPY_Compact_2700mAh_2S_25C_Lipo_Pack.html",
                    Capacity = 2700,
                    Weight = 157,
                    Length = 136,
                    Height = 43,
                    Width = 15,
                    Price = 11.71,
                    Config = 2,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 2700mAh 2S 25C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__63395__ZIPPY_Compact_2700mAh_3s_60c_Lipo_Pack.html",
                    Capacity = 2700,
                    Weight = 242,
                    Length = 137,
                    Height = 45,
                    Width = 20,
                    Price = 22.99,
                    Config = 3,
                    MaxDischarge = 60,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 2700mAh 3s 60c Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21399__ZIPPY_Compact_2700mAh_6S_35C_Lipo_Pack.html",
                    Capacity = 2700,
                    Weight = 430,
                    Length = 138,
                    Height = 45,
                    Width = 32,
                    Price = 36.00,
                    Config = 6,
                    MaxDischarge = 35,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 2700mAh 6S 35C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__86192__Turnigy_2800mAh_4S_30C_LiPoly_Pack_w_EC3_E_flite_Compatible_EFLB28004S30_.html",
                    Capacity = 2800,
                    Weight = 285,
                    Length = 115,
                    Height = 36,
                    Width = 40,
                    Price = 23.07,
                    Config = 4,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "Turnigy 2800mAh 4S 30C LiPoly Pack w/ EC3 (E-flite Compatible EFLB28004S30)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__51502__Turnigy_Bolt_2800mAh_4S_15_2V_65_130C_High_Voltage_Lipoly_Pack.html",
                    Capacity = 2800,
                    Weight = 314,
                    Length = 142,
                    Height = 24,
                    Width = 44,
                    Price = 42.60,
                    Config = 4,
                    MaxDischarge = 65,
                    MaxCharge = 2,
                    Name = "Turnigy Bolt 2800mAh 4S 15.2V 65~130C High Voltage Lipoly Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__14058__ZIPPY_Flightmax_2800mAh_4S1P_30C.html",
                    Capacity = 2800,
                    Weight = 288,
                    Length = 109,
                    Height = 35,
                    Width = 38,
                    Price = 23.48,
                    Config = 4,
                    MaxDischarge = 30,
                    MaxCharge = 3,
                    Name = "ZIPPY Flightmax 2800mAh 4S1P 30C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__51501__Turnigy_Bolt_2800mAh_3S_11_4V_65_130C_High_Voltage_Lipoly_Pack_LiHV_.html",
                    Capacity = 2800,
                    Weight = 256,
                    Length = 142,
                    Height = 18.3,
                    Width = 44,
                    Price = 28.64,
                    Config = 3,
                    MaxDischarge = 65,
                    MaxCharge = 2,
                    Name = "Turnigy Bolt 2800mAh 3S 11.4V 65~130C High Voltage Lipoly Pack (LiHV)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__14057__ZIPPY_Flightmax_2800mAh_3S1P_30C.html",
                    Capacity = 2800,
                    Weight = 215,
                    Length = 112,
                    Height = 34,
                    Width = 27,
                    Price = 20.35,
                    Config = 3,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "ZIPPY Flightmax 2800mAh 3S1P 30C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__91189__Turnigy_Graphene_3000mAh_4S_65C_Lipo_Pack_w_XT90.html",
                    Capacity = 3000,
                    Weight = 393,
                    Length = 136,
                    Height = 45,
                    Width = 32,
                    Price = 58.08,
                    Config = 4,
                    MaxDischarge = 65,
                    MaxCharge = 10,
                    Name = "Turnigy Graphene 3000mAh 4S 65C Lipo Pack w/XT90"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__10298__Turnigy_3000mAh_3S_40C_Lipo_Pack.html",
                    Capacity = 3000,
                    Weight = 278,
                    Length = 145,
                    Height = 43,
                    Width = 21,
                    Price = 23.80,
                    Config = 3,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "Turnigy 3000mAh 3S 40C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9263__Turnigy_3000mAh_5S_20C_Lipo_Pack.html",
                    Capacity = 3000,
                    Weight = 414,
                    Length = 142,
                    Height = 44,
                    Width = 33,
                    Price = 22.70,
                    Config = 5,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "Turnigy 3000mAh 5S 20C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__23821__Turnigy_nano_tech_3000mAh_2S2P_20_40C_Lipo_Receiver_Pack.html",
                    Capacity = 3000,
                    Weight = 146,
                    Length = 88,
                    Height = 34,
                    Width = 25,
                    Price = 18.68,
                    Config = 2,
                    MaxDischarge = 20,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 3000mAh 2S2P 20~40C Lipo Receiver Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9488__Turnigy_3000mAh_5S_30C_Lipo_Pack.html",
                    Capacity = 3000,
                    Weight = 429,
                    Length = 137,
                    Height = 43,
                    Width = 32,
                    Price = 34.76,
                    Config = 5,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "Turnigy 3000mAh 5S 30C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__63534__MultiStar_High_Capacity_3S_3000mAh_Multi_Rotor_Lipo_Pack.html",
                    Capacity = 3000,
                    Weight = 195,
                    Length = 107,
                    Height = 34,
                    Width = 26,
                    Price = 18.56,
                    Config = 3,
                    MaxDischarge = 10,
                    MaxCharge = 2,
                    Name = "MultiStar High Capacity 3S 3000mAh Multi-Rotor Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__10300__Turnigy_3000mAh_6S_40C_Lipo_Pack.html",
                    Capacity = 3000,
                    Weight = 522,
                    Length = 137,
                    Height = 43,
                    Width = 43,
                    Price = 39.94,
                    Config = 6,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "Turnigy 3000mAh 6S 40C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__10297__Turnigy_3000mAh_2S_40C_Lipo_Pack.html",
                    Capacity = 3000,
                    Weight = 198,
                    Length = 136,
                    Height = 42,
                    Width = 15,
                    Price = 14.64,
                    Config = 2,
                    MaxDischarge = 40,
                    MaxCharge = 4,
                    Name = "Turnigy 3000mAh 2S 40C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__91190__Turnigy_Graphene_3000mAh_6S_65C_Lipo_Pack_w_XT90.html",
                    Capacity = 3000,
                    Weight = 566,
                    Length = 138,
                    Height = 45,
                    Width = 48,
                    Price = 76.03,
                    Config = 6,
                    MaxDischarge = 65,
                    MaxCharge = 10,
                    Name = "Turnigy Graphene 3000mAh 6S 65C Lipo Pack w/XT90"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9954__ZIPPY_Flightmax_3000mAh_5S1P_40C.html",
                    Capacity = 3000,
                    Weight = 442,
                    Length = 137,
                    Height = 45,
                    Width = 33,
                    Price = 35.84,
                    Config = 5,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "ZIPPY Flightmax 3000mAh 5S1P 40C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__11920__Turnigy_nano_tech_3000mah_4S_25_50C_Lipo_Pack.html",
                    Capacity = 3000,
                    Weight = 299,
                    Length = 150,
                    Height = 45,
                    Width = 24,
                    Price = 33.14,
                    Config = 4,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 3000mah 4S 25~50C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__91187__Turnigy_Graphene_3000mAh_3S_65C_Lipo_Pack_w_XT90.html",
                    Capacity = 3000,
                    Weight = 301,
                    Length = 136,
                    Height = 45,
                    Width = 25,
                    Price = 40.12,
                    Config = 3,
                    MaxDischarge = 65,
                    MaxCharge = 10,
                    Name = "Turnigy Graphene 3000mAh 3S 65C Lipo Pack w/XT90"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__11918__Turnigy_nano_tech_3000mah_2S_25_50C_Lipo_Pack_.html",
                    Capacity = 3000,
                    Weight = 165,
                    Length = 147,
                    Height = 57,
                    Width = 16,
                    Price = 13.99,
                    Config = 2,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 3000mah 2S 25~50C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9489__Turnigy_3000mAh_6S_30C_Lipo_Pack.html",
                    Capacity = 3000,
                    Weight = 507,
                    Length = 139,
                    Height = 43,
                    Width = 39,
                    Price = 34.96,
                    Config = 6,
                    MaxDischarge = 30,
                    MaxCharge = 3,
                    Name = "Turnigy 3000mAh 6S 30C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__10299__Turnigy_3000mAh_4S_40C_Lipo_Pack.html",
                    Capacity = 3000,
                    Weight = 330,
                    Length = 137,
                    Height = 44,
                    Width = 26,
                    Price = 28.24,
                    Config = 4,
                    MaxDischarge = 40,
                    MaxCharge = 4,
                    Name = "Turnigy 3000mAh 4S 40C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9952__ZIPPY_Flightmax_3000mAh_3S1P_40C.html",
                    Capacity = 3000,
                    Weight = 264,
                    Length = 135,
                    Height = 45,
                    Width = 21,
                    Price = 28.11,
                    Config = 3,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "ZIPPY Flightmax 3000mAh 3S1P 40C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__8918__ZIPPY_Flightmax_3000mAh_6S1P_20C.html",
                    Capacity = 3000,
                    Weight = 480,
                    Length = 138,
                    Height = 44,
                    Width = 39,
                    Price = 26.50,
                    Config = 6,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "ZIPPY Flightmax 3000mAh 6S1P 20C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9497__Turnigy_3000mAh_3S_30C_Lipo_Pack.html",
                    Capacity = 3000,
                    Weight = 269,
                    Length = 136,
                    Height = 43,
                    Width = 19,
                    Price = 20.12,
                    Config = 3,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "Turnigy 3000mAh 3S 30C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__8851__ZIPPY_Flightmax_3000mAh_3S1P_20C.html",
                    Capacity = 3000,
                    Weight = 224,
                    Length = 136,
                    Height = 44,
                    Width = 18,
                    Price = 14.88,
                    Config = 3,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "ZIPPY Flightmax 3000mAh 3S1P 20C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__91188__Turnigy_Graphene_3000mAh_4S_45C_Lipo_Pack_w_XT90.html",
                    Capacity = 3000,
                    Weight = 376,
                    Length = 136,
                    Height = 45,
                    Width = 30,
                    Price = 48.33,
                    Config = 4,
                    MaxDischarge = 45,
                    MaxCharge = 10,
                    Name = "Turnigy Graphene 3000mAh 4S 45C Lipo Pack w/XT90"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__84094__Multistar_LiHV_High_Capacity_3000mAh_3S_Multi_Rotor_Lipo_Pack.html",
                    Capacity = 3000,
                    Weight = 188,
                    Length = 107,
                    Height = 36,
                    Width = 28,
                    Price = 20.04,
                    Config = 3,
                    MaxDischarge = 10,
                    MaxCharge = 5,
                    Name = "Multistar  LiHV High Capacity 3000mAh 3S Multi-Rotor Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__8852__ZIPPY_Flightmax_3000mAh_4S1P_20C.html",
                    Capacity = 3000,
                    Weight = 313,
                    Length = 139,
                    Height = 46,
                    Width = 25,
                    Price = 16.95,
                    Config = 4,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "ZIPPY Flightmax 3000mAh 4S1P 20C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__89605__Turnigy_Graphene_Professional_3000mAh_3S_15C_LiPo_Pack_w_XT60.html",
                    Capacity = 3000,
                    Weight = 214,
                    Length = 105,
                    Height = 35,
                    Width = 30,
                    Price = 27.37,
                    Config = 3,
                    MaxDischarge = 15,
                    MaxCharge = 5,
                    Name = "Turnigy Graphene Professional 3000mAh 3S 15C LiPo Pack w/XT60"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9265__Turnigy_3000mAh_3S_20C_Lipo_Pack.html",
                    Capacity = 3000,
                    Weight = 238,
                    Length = 137,
                    Height = 43,
                    Width = 19,
                    Price = 14.73,
                    Config = 3,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "Turnigy 3000mAh 3S 20C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__8853__ZIPPY_Flightmax_3000mAh_5S1P_20C.html",
                    Capacity = 3000,
                    Weight = 379,
                    Length = 137,
                    Height = 46,
                    Width = 32,
                    Price = 19.98,
                    Config = 5,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "ZIPPY Flightmax 3000mAh 5S1P 20C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9498__Turnigy_3000mAh_4S_30C_Lipo_Pack.html",
                    Capacity = 3000,
                    Weight = 346,
                    Length = 143,
                    Height = 43,
                    Width = 28,
                    Price = 24.70,
                    Config = 4,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "Turnigy 3000mAh 4S 30C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__11919__Turnigy_nano_tech_3000mah_3S_25_50C_Lipo_Pack.html",
                    Capacity = 3000,
                    Weight = 231,
                    Length = 150,
                    Height = 43,
                    Width = 17,
                    Price = 26.25,
                    Config = 3,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 3000mah 3S 25~50C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__86193__Turnigy_3200mAh_4S_20C_LiPoly_Pack_w_EC3_E_flite_Compatible_EFLB32004S_.html",
                    Capacity = 3200,
                    Weight = 345,
                    Length = 139,
                    Height = 45,
                    Width = 30,
                    Price = 21.31,
                    Config = 4,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "Turnigy 3200mAh 4S 20C LiPoly Pack w/ EC3 (E-flite Compatible EFLB32004S)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__86187__Turnigy_3200mAh_4S_30C_LiPoly_Pack_w_EC3_E_flite_Compatible_EFLB32004S30_.html",
                    Capacity = 3200,
                    Weight = 338,
                    Length = 139,
                    Height = 45,
                    Width = 29,
                    Price = 27.25,
                    Config = 4,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "Turnigy 3200mAh 4S 30C LiPoly Pack w/ EC3 (E-flite Compatible EFLB32004S30)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__86186__Turnigy_3200mAh_3S_30C_LiPoly_Pack_w_EC3_E_flite_Compatible_EFLB32003S30_.html",
                    Capacity = 3200,
                    Weight = 265,
                    Length = 139,
                    Height = 45,
                    Width = 22,
                    Price = 20.00,
                    Config = 3,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "Turnigy 3200mAh 3S 30C LiPoly Pack w/ EC3 (E-flite Compatible EFLB32003S30)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__63400__ZIPPY_Compact_3300mAh_3s_60c_Lipo_Pack.html",
                    Capacity = 3300,
                    Weight = 288,
                    Length = 139,
                    Height = 42,
                    Width = 24,
                    Price = 29.92,
                    Config = 3,
                    MaxDischarge = 60,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 3300mAh 3s 60c Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21406__ZIPPY_Compact_3300mAh_6S_35C_Lipo_Pack.html",
                    Capacity = 3300,
                    Weight = 548,
                    Length = 149,
                    Height = 44,
                    Width = 43,
                    Price = 46.75,
                    Config = 6,
                    MaxDischarge = 35,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 3300mAh 6S 35C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__63398__ZIPPY_Compact_3300mAh_4s_40c_Lipo_Pack.html",
                    Capacity = 3300,
                    Weight = 359,
                    Length = 139,
                    Height = 45,
                    Width = 30,
                    Price = 31.50,
                    Config = 4,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 3300mAh 4s 40c Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21405__ZIPPY_Compact_3300mAh_5S_35C_Lipo_Pack.html",
                    Capacity = 3300,
                    Weight = 433,
                    Length = 148,
                    Height = 44,
                    Width = 32,
                    Price = 38.98,
                    Config = 5,
                    MaxDischarge = 35,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 3300mAh 5S 35C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__11925__Turnigy_nano_tech_3300mah_6S_25_50C_Lipo_Pack.html",
                    Capacity = 3300,
                    Weight = 489,
                    Length = 145,
                    Height = 53,
                    Width = 37,
                    Price = 44.33,
                    Config = 6,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 3300mah 6S 25~50C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__63402__ZIPPY_Compact_3300mAh_6s_60c_Lipo_Pack.html",
                    Capacity = 3300,
                    Weight = 558,
                    Length = 141,
                    Height = 45,
                    Width = 48,
                    Price = 52.16,
                    Config = 6,
                    MaxDischarge = 60,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 3300mAh 6s 60c Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9500__Turnigy_3300mAh_3S_30C_Lipo_Pack.html",
                    Capacity = 3300,
                    Weight = 297,
                    Length = 137,
                    Height = 43,
                    Width = 22,
                    Price = 25.90,
                    Config = 3,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "Turnigy 3300mAh 3S 30C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__19134__Turnigy_nano_tech_3300mah_4S_65_130C_Lipo_Pack_.html",
                    Capacity = 3300,
                    Weight = 409,
                    Length = 134,
                    Height = 43,
                    Width = 32,
                    Price = 50.55,
                    Config = 4,
                    MaxDischarge = 65,
                    MaxCharge = 8,
                    Name = "Turnigy nano-tech 3300mah 4S 65~130C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__63401__ZIPPY_Compact_3300mAh_4s_60c_Lipo_Pack.html",
                    Capacity = 3300,
                    Weight = 382,
                    Length = 139,
                    Height = 45,
                    Width = 32,
                    Price = 37.98,
                    Config = 4,
                    MaxDischarge = 60,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 3300mAh 4s 60c Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__53686__Turnigy_Heavy_Duty_3300mAh_3S_60C_Lipo_Pack.html",
                    Capacity = 3300,
                    Weight = 312,
                    Length = 138,
                    Height = 43,
                    Width = 24,
                    Price = 30.78,
                    Config = 3,
                    MaxDischarge = 60,
                    MaxCharge = 2,
                    Name = "Turnigy Heavy Duty 3300mAh 3S 60C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__11924__Turnigy_nano_tech_3300mah_4S_25_50C_Lipo_Pack.html",
                    Capacity = 3300,
                    Weight = 337,
                    Length = 135,
                    Height = 44,
                    Width = 26,
                    Price = 42.92,
                    Config = 4,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 3300mah 4S 25~50C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__17239__Turnigy_nano_tech_3300mah_6S_35_70C_Lipo_Pack.html",
                    Capacity = 3300,
                    Weight = 522,
                    Length = 136,
                    Height = 44,
                    Width = 43,
                    Price = 53.60,
                    Config = 6,
                    MaxDischarge = 35,
                    MaxCharge = 8,
                    Name = "Turnigy nano-tech 3300mah 6S 35~70C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__17238__Turnigy_nano_tech_3300mah_2S_35_70C_Lipo_Pack.html",
                    Capacity = 3300,
                    Weight = 191,
                    Length = 132,
                    Height = 43,
                    Width = 15,
                    Price = 19.65,
                    Config = 2,
                    MaxDischarge = 35,
                    MaxCharge = 8,
                    Name = "Turnigy nano-tech 3300mah 2S 35~70C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9501__Turnigy_3300mAh_4S_30C_Lipo_Pack.html",
                    Capacity = 3300,
                    Weight = 385,
                    Length = 137,
                    Height = 43,
                    Width = 30,
                    Price = 28.08,
                    Config = 4,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "Turnigy 3300mAh 4S 30C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__19133__Turnigy_nano_tech_3300mah_3S_65_130C_Lipo_Pack.html",
                    Capacity = 3300,
                    Weight = 311,
                    Length = 133,
                    Height = 44,
                    Width = 24,
                    Price = 37.90,
                    Config = 3,
                    MaxDischarge = 65,
                    MaxCharge = 8,
                    Name = "Turnigy nano-tech 3300mah 3S 65~130C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__11950__Turnigy_nano_tech_3300mah_4S_35_70C_Lipo_Pack.html",
                    Capacity = 3300,
                    Weight = 361,
                    Length = 145,
                    Height = 45,
                    Width = 26,
                    Price = 43.63,
                    Config = 4,
                    MaxDischarge = 35,
                    MaxCharge = 8,
                    Name = "Turnigy nano-tech 3300mah 4S 35~70C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21404__ZIPPY_Compact_3300mAh_4S_35C_Lipo_Pack.html",
                    Capacity = 3300,
                    Weight = 372,
                    Length = 147,
                    Height = 44,
                    Width = 29,
                    Price = 28.98,
                    Config = 4,
                    MaxDischarge = 35,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 3300mAh 4S 35C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__19136__Turnigy_nano_tech_3300mah_6S_65_130C_Lipo_Pack.html",
                    Capacity = 3300,
                    Weight = 595,
                    Length = 134,
                    Height = 44,
                    Width = 49,
                    Price = 71.51,
                    Config = 6,
                    MaxDischarge = 65,
                    MaxCharge = 8,
                    Name = "Turnigy nano-tech 3300mah 6S 65~130C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9499__Turnigy_3300mAh_2S_30C_Lipo_Pack.html",
                    Capacity = 3300,
                    Weight = 204,
                    Length = 134,
                    Height = 43,
                    Width = 15,
                    Price = 15.03,
                    Config = 2,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "Turnigy 3300mAh 2S 30C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__19135__Turnigy_nano_tech_3300mah_5S_65_130C_Lipo_Pack.html",
                    Capacity = 3300,
                    Weight = 500,
                    Length = 135,
                    Height = 44,
                    Width = 40,
                    Price = 63.15,
                    Config = 5,
                    MaxDischarge = 65,
                    MaxCharge = 8,
                    Name = "Turnigy nano-tech 3300mah 5S 65~130C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__17261__Turnigy_nano_tech_3300mah_6S_45_90C_Lipo_Pack.html",
                    Capacity = 3300,
                    Weight = 565,
                    Length = 135,
                    Height = 45,
                    Width = 44,
                    Price = 62.61,
                    Config = 6,
                    MaxDischarge = 45,
                    MaxCharge = 10,
                    Name = "Turnigy nano-tech 3300mah 6S 45~90C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9503__Turnigy_3300mAh_6S_30C_Lipo_Pack.html",
                    Capacity = 3300,
                    Weight = 505,
                    Length = 136,
                    Height = 45,
                    Width = 43,
                    Price = 36.90,
                    Config = 6,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "Turnigy 3300mAh 6S 30C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9502__Turnigy_3300mAh_5S_30C_Lipo_Pack.html",
                    Capacity = 3300,
                    Weight = 480,
                    Length = 139,
                    Height = 43,
                    Width = 35,
                    Price = 36.88,
                    Config = 5,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "Turnigy 3300mAh 5S 30C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__63397__ZIPPY_Compact_3300mAh_3s_40c_Lipo_Pack.html",
                    Capacity = 3300,
                    Weight = 277,
                    Length = 138,
                    Height = 45,
                    Width = 23,
                    Price = 27.56,
                    Config = 3,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 3300mAh 3s 40c Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__53687__Turnigy_Heavy_Duty_3300mAh_4S_60C_Lipo_Pack.html",
                    Capacity = 3300,
                    Weight = 400,
                    Length = 138,
                    Height = 43,
                    Width = 32,
                    Price = 36.14,
                    Config = 4,
                    MaxDischarge = 60,
                    MaxCharge = 2,
                    Name = "Turnigy Heavy Duty 3300mAh 4S 60C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__51503__Turnigy_Bolt_3450mAh_3S_11_4V_65_130C_High_Voltage_Lipoly_Pack_LiHV_.html",
                    Capacity = 3450,
                    Weight = 301,
                    Length = 145,
                    Height = 22.2,
                    Width = 49,
                    Price = 32.99,
                    Config = 3,
                    MaxDischarge = 65,
                    MaxCharge = 2,
                    Name = "Turnigy Bolt 3450mAh 3S 11.4V 65~130C High Voltage Lipoly Pack (LiHV)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__51504__Turnigy_Bolt_3450mAh_4S_15_2V_65_130C_High_Voltage_Lipoly_Pack_LiHV_.html",
                    Capacity = 3450,
                    Weight = 374,
                    Length = 145,
                    Height = 29.2,
                    Width = 49,
                    Price = 50.68,
                    Config = 4,
                    MaxDischarge = 65,
                    MaxCharge = 2,
                    Name = "Turnigy Bolt 3450mAh 4S 15.2V 65~130C High Voltage Lipoly Pack (LiHV)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__28006__Turnigy_3600mAh_2S_12C_Lipo_Receiver_Pack.html",
                    Capacity = 3600,
                    Weight = 165,
                    Length = 65,
                    Height = 50,
                    Width = 28,
                    Price = 19.45,
                    Config = 2,
                    MaxDischarge = 12,
                    MaxCharge = 2,
                    Name = "Turnigy 3600mAh 2S 12C Lipo Receiver Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9508__Turnigy_3600mAh_6S_30C_Lipo_Pack.html",
                    Capacity = 3600,
                    Weight = 577,
                    Length = 137,
                    Height = 43,
                    Width = 43,
                    Price = 46.44,
                    Config = 6,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "Turnigy 3600mAh 6S 30C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9505__Turnigy_3600mAh_3S_30C_Lipo_Pack.html",
                    Capacity = 3600,
                    Weight = 321,
                    Length = 137,
                    Height = 43,
                    Width = 24,
                    Price = 24.79,
                    Config = 3,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "Turnigy 3600mAh 3S 30C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9506__Turnigy_3600mAh_4S_30C_Lipo_Pack.html",
                    Capacity = 3600,
                    Weight = 395,
                    Length = 136,
                    Height = 47,
                    Width = 33,
                    Price = 35.30,
                    Config = 4,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "Turnigy 3600mAh 4S 30C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__63403__ZIPPY_Compact_3700mAh_3s_40c_Lipo_Pack.html",
                    Capacity = 3700,
                    Weight = 317,
                    Length = 148,
                    Height = 44,
                    Width = 25,
                    Price = 26.53,
                    Config = 3,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 3700mAh 3s 40c Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21355__ZIPPY_Compact_3700mAh_3S_25C_Lipo_Pack.html",
                    Capacity = 3700,
                    Weight = 264,
                    Length = 146,
                    Height = 19,
                    Width = 43,
                    Price = 22.91,
                    Config = 3,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 3700mAh 3S 25C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__63406__ZIPPY_Compact_3700mAh_4s_60c_Lipo_Pack.html",
                    Capacity = 3700,
                    Weight = 442,
                    Length = 149,
                    Height = 44,
                    Width = 35,
                    Price = 41.58,
                    Config = 4,
                    MaxDischarge = 60,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 3700mAh 4s 60c Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21356__ZIPPY_Compact_3700mAh_4S_25C_Lipo_Pack.html",
                    Capacity = 3700,
                    Weight = 343,
                    Length = 146,
                    Height = 27,
                    Width = 44,
                    Price = 27.69,
                    Config = 4,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 3700mAh 4S 25C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9338__Rhino_3700mAh_4S_14_8v_25C_Lipoly_Pack.html",
                    Capacity = 3700,
                    Weight = 342,
                    Length = 144,
                    Height = 44,
                    Width = 27,
                    Price = 26.91,
                    Config = 4,
                    MaxDischarge = 25,
                    MaxCharge = 2,
                    Name = "Rhino 3700mAh 4S 14.8v 25C Lipoly Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21358__ZIPPY_Compact_3700mAh_6S_25C_Lipo_Pack.html",
                    Capacity = 3700,
                    Weight = 519,
                    Length = 148,
                    Height = 43,
                    Width = 37,
                    Price = 39.90,
                    Config = 6,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 3700mAh 6S 25C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21415__ZIPPY_Compact_3700mAh_6S_35C_Lipo_Pack.html",
                    Capacity = 3700,
                    Weight = 593,
                    Length = 147,
                    Height = 44,
                    Width = 45,
                    Price = 56.00,
                    Config = 6,
                    MaxDischarge = 35,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 3700mAh 6S 35C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21357__ZIPPY_Compact_3700mAh_5S_25C_Lipo_Pack_.html",
                    Capacity = 3700,
                    Weight = 424,
                    Length = 146,
                    Height = 43,
                    Width = 31,
                    Price = 38.66,
                    Config = 5,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 3700mAh 5S 25C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__15520__Turnigy_3800mAh_2S1P_7_4v_25C_Hardcase_Pack.html",
                    Capacity = 3800,
                    Weight = 235,
                    Length = 136,
                    Height = 45,
                    Width = 22,
                    Price = 16.95,
                    Config = 2,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy 3800mAh 2S1P 7.4v 25C Hardcase Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__19140__Turnigy_nano_tech_3850mah_4S_65_130C_Lipo_Pack.html",
                    Capacity = 3850,
                    Weight = 454,
                    Length = 136,
                    Height = 43,
                    Width = 37,
                    Price = 58.97,
                    Config = 4,
                    MaxDischarge = 65,
                    MaxCharge = 8,
                    Name = "Turnigy nano-tech 3850mah 4S 65~130C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21363__ZIPPY_Compact_4000mAh_6S_25C_Lipo_Pack.html",
                    Capacity = 4000,
                    Weight = 562,
                    Length = 147,
                    Height = 45,
                    Width = 45,
                    Price = 51.04,
                    Config = 6,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 4000mAh 6S 25C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9510__Turnigy_4000mAh_3S_30C_Lipo_Pack.html",
                    Capacity = 4000,
                    Weight = 347,
                    Length = 144,
                    Height = 50,
                    Width = 22,
                    Price = 26.34,
                    Config = 3,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "Turnigy 4000mAh 3S 30C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__89607__Turnigy_Graphene_Professional_4000mAh_4S_15C_LiPo_Pack_w_XT60.html",
                    Capacity = 4000,
                    Weight = 396,
                    Length = 108,
                    Height = 35,
                    Width = 54,
                    Price = 38.00,
                    Config = 4,
                    MaxDischarge = 15,
                    MaxCharge = 5,
                    Name = "Turnigy Graphene Professional 4000mAh 4S 15C LiPo Pack w/XT60"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__11927__Turnigy_nano_tech_4000mah_3S_25_50C_Lipo_Pack.html",
                    Capacity = 4000,
                    Weight = 333,
                    Length = 173,
                    Height = 49,
                    Width = 20,
                    Price = 26.90,
                    Config = 3,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 4000mah 3S 25~50C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__10302__Turnigy_4000mAh_3S_40C_Lipo_Pack_.html",
                    Capacity = 4000,
                    Weight = 372,
                    Length = 144,
                    Height = 50,
                    Width = 22,
                    Price = 28.27,
                    Config = 3,
                    MaxDischarge = 40,
                    MaxCharge = 4,
                    Name = "Turnigy 4000mAh 3S 40C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9511__Turnigy_4000mAh_4S_30C_Lipo_Pack.html",
                    Capacity = 4000,
                    Weight = 452,
                    Length = 148,
                    Height = 50,
                    Width = 29,
                    Price = 33.62,
                    Config = 4,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "Turnigy 4000mAh 4S 30C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__17244__Turnigy_nano_tech_4000mah_6S_35_70C_Lipo_Pack.html",
                    Capacity = 4000,
                    Weight = 630,
                    Length = 153,
                    Height = 49,
                    Width = 39,
                    Price = 67.17,
                    Config = 6,
                    MaxDischarge = 35,
                    MaxCharge = 8,
                    Name = "Turnigy nano-tech 4000mah 6S 35~70C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__11929__Turnigy_nano_tech_4000mah_6S_25_50C_Lipo_Pack.html",
                    Capacity = 4000,
                    Weight = 623,
                    Length = 163,
                    Height = 49,
                    Width = 39,
                    Price = 53.73,
                    Config = 6,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 4000mah 6S 25~50C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__91194__Turnigy_Graphene_4000mAh_4S_65C_Lipo_Pack_w_XT90.html",
                    Capacity = 4000,
                    Weight = 506,
                    Length = 144,
                    Height = 51,
                    Width = 36,
                    Price = 65.84,
                    Config = 4,
                    MaxDischarge = 65,
                    MaxCharge = 10,
                    Name = "Turnigy Graphene 4000mAh 4S 65C Lipo Pack w/XT90"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__91195__Turnigy_Graphene_4000mAh_6S_45C_Lipo_Pack_w_XT90.html",
                    Capacity = 4000,
                    Weight = 698,
                    Length = 146,
                    Height = 51,
                    Width = 49,
                    Price = 85.00,
                    Config = 6,
                    MaxDischarge = 45,
                    MaxCharge = 10,
                    Name = "Turnigy Graphene 4000mAh 6S 45C Lipo Pack w/XT90"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9509__Turnigy_4000mAh_2S_30C_Lipo_Pack.html",
                    Capacity = 4000,
                    Weight = 245,
                    Length = 143,
                    Height = 50,
                    Width = 15,
                    Price = 17.57,
                    Config = 2,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "Turnigy 4000mAh 2S 30C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__17240__Turnigy_nano_tech_4000mah_2S_35_70C_Lipo_Pack.html",
                    Capacity = 4000,
                    Weight = 234,
                    Length = 152,
                    Height = 49,
                    Width = 14,
                    Price = 21.95,
                    Config = 2,
                    MaxDischarge = 35,
                    MaxCharge = 8,
                    Name = "Turnigy nano-tech 4000mah 2S 35~70C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__56846__Multistar_High_Capacity_3S_4000mAh_Multi_Rotor_Lipo_Pack.html",
                    Capacity = 4000,
                    Weight = 244,
                    Length = 112,
                    Height = 34,
                    Width = 30,
                    Price = 19.96,
                    Config = 3,
                    MaxDischarge = 10,
                    MaxCharge = 2,
                    Name = "Multistar High Capacity 3S 4000mAh Multi-Rotor Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21360__ZIPPY_Compact_4000mAh_3S_25C_Lipo_Pack.html",
                    Capacity = 4000,
                    Weight = 286,
                    Length = 148,
                    Height = 43,
                    Width = 20,
                    Price = 25.60,
                    Config = 3,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 4000mAh 3S 25C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__14612__Turnigy_nano_tech_4000mah_6S_45_90C_Lipo_Pack.html",
                    Capacity = 4000,
                    Weight = 684,
                    Length = 163,
                    Height = 50,
                    Width = 42,
                    Price = 75.83,
                    Config = 6,
                    MaxDischarge = 45,
                    MaxCharge = 10,
                    Name = "Turnigy nano-tech 4000mah 6S 45~90C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__11926__Turnigy_nano_tech_4000mah_2S_25_50C_Lipo_Pack.html",
                    Capacity = 4000,
                    Weight = 233,
                    Length = 172,
                    Height = 49,
                    Width = 14,
                    Price = 19.29,
                    Config = 2,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 4000mah 2S 25~50C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__17243__Turnigy_nano_tech_4000mah_5S_35_70C_Lipo_Pack.html",
                    Capacity = 4000,
                    Weight = 537,
                    Length = 154,
                    Height = 49,
                    Width = 34,
                    Price = 53.79,
                    Config = 5,
                    MaxDischarge = 35,
                    MaxCharge = 8,
                    Name = "Turnigy nano-tech 4000mah 5S 35~70C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__53691__Turnigy_Heavy_Duty_4000mAh_6S_60C_Lipo_Pack.html",
                    Capacity = 4000,
                    Weight = 683,
                    Length = 147,
                    Height = 49,
                    Width = 47,
                    Price = 61.73,
                    Config = 6,
                    MaxDischarge = 60,
                    MaxCharge = 2,
                    Name = "Turnigy Heavy Duty 4000mAh 6S 60C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__11955__Turnigy_nano_tech_4000mah_4S_45_90C_Lipo_Pack.html",
                    Capacity = 4000,
                    Weight = 485,
                    Length = 168,
                    Height = 49,
                    Width = 29,
                    Price = 54.45,
                    Config = 4,
                    MaxDischarge = 45,
                    MaxCharge = 10,
                    Name = "Turnigy nano-tech 4000mah 4S 45~90C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9513__Turnigy_4000mAh_6S_30C_Lipo_Pack.html",
                    Capacity = 4000,
                    Weight = 663,
                    Length = 143,
                    Height = 50,
                    Width = 43,
                    Price = 49.41,
                    Config = 6,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "Turnigy 4000mAh 6S 30C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21004__Turnigy_4000mAh_2S_30C_Hardcase_Pack_ROAR_APPROVED_.html",
                    Capacity = 4000,
                    Weight = 254,
                    Length = 135,
                    Height = 45,
                    Width = 21,
                    Price = 19.95,
                    Config = 2,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "Turnigy 4000mAh 2S 30C Hardcase Pack (ROAR APPROVED)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__91192__Turnigy_Graphene_4000mAh_3S_65C_Lipo_Pack_w_XT90.html",
                    Capacity = 4000,
                    Weight = 394,
                    Length = 144,
                    Height = 51,
                    Width = 28,
                    Price = 47.08,
                    Config = 3,
                    MaxDischarge = 65,
                    MaxCharge = 10,
                    Name = "Turnigy Graphene 4000mAh 3S 65C Lipo Pack w/XT90"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__14610__Turnigy_nano_tech_4000mah_5S_25_50C_Lipo_Pack.html",
                    Capacity = 4000,
                    Weight = 525,
                    Length = 161,
                    Height = 49,
                    Width = 33,
                    Price = 44.79,
                    Config = 5,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 4000mah 5S 25~50C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21364__ZIPPY_Compact_4000mAh_7S_25C_Lipo_Pack.html",
                    Capacity = 4000,
                    Weight = 641,
                    Length = 148,
                    Height = 44,
                    Width = 46,
                    Price = 52.08,
                    Config = 7,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 4000mAh 7S 25C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__14080__ZIPPY_4000mAh_2S1P_30C_Hardcase_Pack.html",
                    Capacity = 4000,
                    Weight = 256,
                    Length = 137,
                    Height = 47,
                    Width = 25,
                    Price = 19.75,
                    Config = 2,
                    MaxDischarge = 30,
                    MaxCharge = 3,
                    Name = "ZIPPY 4000mAh 2S1P 30C Hardcase Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__91191__Turnigy_Graphene_4000mAh_3S_45C_Lipo_Pack_w_XT90.html",
                    Capacity = 4000,
                    Weight = 381,
                    Length = 144,
                    Height = 51,
                    Width = 27,
                    Price = 42.59,
                    Config = 3,
                    MaxDischarge = 45,
                    MaxCharge = 10,
                    Name = "Turnigy Graphene 4000mAh 3S 45C Lipo Pack w/XT90"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__63408__ZIPPY_Compact_4000mAh_3s_40c_Lipo_Pack.html",
                    Capacity = 4000,
                    Weight = 345,
                    Length = 148,
                    Height = 44,
                    Width = 26,
                    Price = 28.72,
                    Config = 3,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 4000mAh 3s 40c Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21367__ZIPPY_Compact_4000mAh_10S_25C_Lipo_Pack.html",
                    Capacity = 4000,
                    Weight = 908,
                    Length = 150,
                    Height = 44,
                    Width = 66,
                    Price = 67.44,
                    Config = 10,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 4000mAh 10S 25C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21359__ZIPPY_Compact_4000mAh_2S_25C_Lipo_Pack.html",
                    Capacity = 4000,
                    Weight = 197,
                    Length = 145,
                    Height = 14,
                    Width = 43,
                    Price = 15.00,
                    Config = 2,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 4000mAh 2S 25C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__56847__Multistar_High_Capacity_4S_4000mAh_Multi_Rotor_Lipo_Pack.html",
                    Capacity = 4000,
                    Weight = 320,
                    Length = 112,
                    Height = 34,
                    Width = 40,
                    Price = 27.76,
                    Config = 4,
                    MaxDischarge = 10,
                    MaxCharge = 2,
                    Name = "Multistar High Capacity 4S 4000mAh Multi-Rotor Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__53689__Turnigy_Heavy_Duty_4000mAh_3S_60C_Lipo_Pack.html",
                    Capacity = 4000,
                    Weight = 371,
                    Length = 147,
                    Height = 49,
                    Width = 24,
                    Price = 32.28,
                    Config = 3,
                    MaxDischarge = 60,
                    MaxCharge = 2,
                    Name = "Turnigy Heavy Duty 4000mAh 3S 60C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9959__ZIPPY_Flightmax_4000mAh_5S1P_40C.html",
                    Capacity = 4000,
                    Weight = 581,
                    Length = 147,
                    Height = 51,
                    Width = 33,
                    Price = 38.51,
                    Config = 5,
                    MaxDischarge = 40,
                    MaxCharge = 2,
                    Name = "ZIPPY Flightmax 4000mAh 5S1P 40C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__11928__Turnigy_nano_tech_4000mah_4S_25_50C_Lipo_Pack.html",
                    Capacity = 4000,
                    Weight = 430,
                    Length = 153,
                    Height = 49,
                    Width = 27,
                    Price = 38.98,
                    Config = 4,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 4000mah 4S 25~50C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9512__Turnigy_4000mAh_5S_30C_Lipo_Pack.html",
                    Capacity = 4000,
                    Weight = 565,
                    Length = 145,
                    Height = 50,
                    Width = 35,
                    Price = 36.93,
                    Config = 5,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "Turnigy 4000mAh 5S 30C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__14084__ZIPPY_4000mAh_3S1P_30C_Hardcase_Pack.html",
                    Capacity = 4000,
                    Weight = 342,
                    Length = 137,
                    Height = 47,
                    Width = 39,
                    Price = 29.08,
                    Config = 3,
                    MaxDischarge = 30,
                    MaxCharge = 3,
                    Name = "ZIPPY 4000mAh 3S1P 30C Hardcase Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__91196__Turnigy_Graphene_4000mAh_6S_65C_Lipo_Pack_w_XT90.html",
                    Capacity = 4000,
                    Weight = 733,
                    Length = 146,
                    Height = 51,
                    Width = 52,
                    Price = 98.64,
                    Config = 6,
                    MaxDischarge = 65,
                    MaxCharge = 10,
                    Name = "Turnigy Graphene 4000mAh 6S 65C Lipo Pack w/XT90"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__20998__ZIPPY_4000mAh_2S1P_25C_Car_Lipoly_ROAR_APPROVED_.html",
                    Capacity = 4000,
                    Weight = 235,
                    Length = 138,
                    Height = 47,
                    Width = 23,
                    Price = 15.85,
                    Config = 2,
                    MaxDischarge = 25,
                    MaxCharge = 2,
                    Name = "ZIPPY 4000mAh 2S1P 25C Car Lipoly (ROAR APPROVED)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__84096__Multistar_LiHV_High_Capacity_4000Mah_4S_Multi_Rotor_Lipo_Pack.html",
                    Capacity = 4000,
                    Weight = 345,
                    Length = 110,
                    Height = 36,
                    Width = 52,
                    Price = 31.99,
                    Config = 4,
                    MaxDischarge = 10,
                    MaxCharge = 5,
                    Name = "Multistar LiHV High Capacity 4000Mah 4S Multi-Rotor Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9960__ZIPPY_Flightmax_4000mAh_6S1P_40C.html",
                    Capacity = 4000,
                    Weight = 690,
                    Length = 147,
                    Height = 50,
                    Width = 44,
                    Price = 56.16,
                    Config = 6,
                    MaxDischarge = 40,
                    MaxCharge = 2,
                    Name = "ZIPPY Flightmax 4000mAh 6S1P 40C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__19481__Turnigy_4000mAh_Spektrum_Compatible_DX9_DX8_DX7S_Intelligent_Transmitter_Pack.html",
                    Capacity = 4000,
                    Weight = 133,
                    Length = 71,
                    Height = 50,
                    Width = 19,
                    Price = 18.01,
                    Config = 2,
                    MaxDischarge = 2,
                    MaxCharge = 1,
                    Name = "Turnigy 4000mAh Spektrum Compatible DX9 DX8 DX7S Intelligent Transmitter Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__89606__Turnigy_Graphene_Professional_4000mAh_3S_15C_LiPo_Pack_w_XT60.html",
                    Capacity = 4000,
                    Weight = 296,
                    Length = 107,
                    Height = 35,
                    Width = 41,
                    Price = 30.28,
                    Config = 3,
                    MaxDischarge = 15,
                    MaxCharge = 5,
                    Name = "Turnigy Graphene Professional 4000mAh 3S 15C LiPo Pack w/XT60"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__53690__Turnigy_Heavy_Duty_4000mAh_4S_60C_Lipo_Pack.html",
                    Capacity = 4000,
                    Weight = 476,
                    Length = 147,
                    Height = 49,
                    Width = 32,
                    Price = 44.82,
                    Config = 4,
                    MaxDischarge = 60,
                    MaxCharge = 2,
                    Name = "Turnigy Heavy Duty 4000mAh 4S 60C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__17241__Turnigy_nano_tech_4000mah_3S_35_70C_Lipo_Pack.html",
                    Capacity = 4000,
                    Weight = 335,
                    Length = 152,
                    Height = 49,
                    Width = 21,
                    Price = 32.29,
                    Config = 3,
                    MaxDischarge = 35,
                    MaxCharge = 8,
                    Name = "Turnigy nano-tech 4000mah 3S 35~70C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__89933__Turnigy_nano_tech_4200mAh_2S_25C_Hardcase_Lipo_Pack.html",
                    Capacity = 4200,
                    Weight = 222,
                    Length = 138,
                    Height = 47,
                    Width = 25,
                    Price = 20.02,
                    Config = 2,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 4200mAh 2S 25C Hardcase Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__19692__Turnigy_nano_tech_4200mah_2S2P_40_80C_Hardcase_Stick_Pack_.html",
                    Capacity = 4200,
                    Weight = 230,
                    Length = 138,
                    Height = 47,
                    Width = 23,
                    Price = 27.95,
                    Config = 2,
                    MaxDischarge = 40,
                    MaxCharge = 8,
                    Name = "Turnigy nano-tech 4200mah 2S2P 40~80C (Hardcase Stick Pack)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__23134__Turnigy_nano_tech_Shorty_4200mah_2S2P_65_130C_Hardcase_Lipo_Pack_ROAR_APPROVED_.html",
                    Capacity = 4200,
                    Weight = 190,
                    Length = 96,
                    Height = 46,
                    Width = 25,
                    Price = 36.62,
                    Config = 2,
                    MaxDischarge = 65,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech Shorty 4200mah 2S2P 65~130C Hardcase Lipo Pack (ROAR APPROVED)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__19145__Turnigy_nano_tech_4400mah_3S_65_130C_Lipo_Pack.html",
                    Capacity = 4400,
                    Weight = 399,
                    Length = 150,
                    Height = 48,
                    Width = 25,
                    Price = 50.54,
                    Config = 3,
                    MaxDischarge = 65,
                    MaxCharge = 8,
                    Name = "Turnigy nano-tech 4400mah 3S 65~130C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__19146__Turnigy_nano_tech_4400mah_4S_65_130C_Lipo_Pack.html",
                    Capacity = 4400,
                    Weight = 527,
                    Length = 153,
                    Height = 49,
                    Width = 33,
                    Price = 67.41,
                    Config = 4,
                    MaxDischarge = 65,
                    MaxCharge = 8,
                    Name = "Turnigy nano-tech 4400mah 4S 65~130C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__19147__Turnigy_nano_tech_4400mah_5S_65_130C_Lipo_Pack.html",
                    Capacity = 4400,
                    Weight = 650,
                    Length = 154,
                    Height = 49,
                    Width = 41,
                    Price = 84.20,
                    Config = 5,
                    MaxDischarge = 65,
                    MaxCharge = 8,
                    Name = "Turnigy nano-tech 4400mah 5S 65~130C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__10283__Turnigy_4500mAh_3S_30C_Lipo_Pack.html",
                    Capacity = 4500,
                    Weight = 386,
                    Length = 147,
                    Height = 49,
                    Width = 29,
                    Price = 30.10,
                    Config = 3,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "Turnigy 4500mAh 3S 30C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__17247__Turnigy_nano_tech_4500mah_3S_35_70C_Lipo_Pack.html",
                    Capacity = 4500,
                    Weight = 372,
                    Length = 151,
                    Height = 49,
                    Width = 23,
                    Price = 36.85,
                    Config = 3,
                    MaxDischarge = 35,
                    MaxCharge = 8,
                    Name = "Turnigy nano-tech 4500mah 3S 35~70C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__17662__Turnigy_nano_tech_4500mah_6S_45_90C_Lipo_Pack.html",
                    Capacity = 4500,
                    Weight = 750,
                    Length = 154,
                    Height = 49,
                    Width = 47,
                    Price = 87.07,
                    Config = 6,
                    MaxDischarge = 45,
                    MaxCharge = 10,
                    Name = "Turnigy nano-tech 4500mah 6S 45~90C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__63415__ZIPPY_Compact_4500mAh_3s_40c_Lipo_Pack.html",
                    Capacity = 4500,
                    Weight = 378,
                    Length = 156,
                    Height = 45,
                    Width = 27,
                    Price = 26.19,
                    Config = 3,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 4500mAh 3s 40c Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21424__ZIPPY_Compact_4500mAh_6S_35C_Lipo_Pack.html",
                    Capacity = 4500,
                    Weight = 696,
                    Length = 163,
                    Height = 46,
                    Width = 44,
                    Price = 61.90,
                    Config = 6,
                    MaxDischarge = 35,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 4500mAh 6S 35C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__11933__Turnigy_nano_tech_4500mah_6S_25_50C_Lipo_Pack.html",
                    Capacity = 4500,
                    Weight = 687,
                    Length = 168,
                    Height = 49,
                    Width = 44,
                    Price = 60.45,
                    Config = 6,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 4500mah 6S 25~50C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__10284__Turnigy_4500mAh_6S_30C_Lipo_Pack.html",
                    Capacity = 4500,
                    Weight = 745,
                    Length = 149,
                    Height = 49,
                    Width = 48,
                    Price = 51.97,
                    Config = 6,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "Turnigy 4500mAh 6S 30C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21003__Turnigy_4500mAh_4S_30C_Hardcase_Pack_ROAR_APPROVED_.html",
                    Capacity = 4500,
                    Weight = 528,
                    Length = 138,
                    Height = 45,
                    Width = 44,
                    Price = 42.00,
                    Config = 4,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "Turnigy 4500mAh 4S 30C Hardcase Pack (ROAR APPROVED)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21423__ZIPPY_Compact_4500mAh_5S_35C_Lipo_Pack.html",
                    Capacity = 4500,
                    Weight = 581,
                    Length = 164,
                    Height = 45,
                    Width = 45,
                    Price = 51.18,
                    Config = 5,
                    MaxDischarge = 35,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 4500mAh 5S 35C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__17248__Turnigy_nano_tech_4500mah_4S_35_70C_Lipo_Pack.html",
                    Capacity = 4500,
                    Weight = 485,
                    Length = 153,
                    Height = 49,
                    Width = 30,
                    Price = 48.46,
                    Config = 4,
                    MaxDischarge = 35,
                    MaxCharge = 8,
                    Name = "Turnigy nano-tech 4500mah 4S 35~70C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21422__ZIPPY_Compact_4500mAh_4S_35C_Lipo_Pack.html",
                    Capacity = 4500,
                    Weight = 496,
                    Length = 1,
                    Height = 46,
                    Width = 38,
                    Price = 37.04,
                    Config = 4,
                    MaxDischarge = 35,
                    MaxCharge = 159,
                    Name = "ZIPPY Compact 4500mAh 4S 35C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__16494__ZIPPY_Flightmax_4500mAh_4S1P_45C.html",
                    Capacity = 4500,
                    Weight = 527,
                    Length = 146,
                    Height = 52,
                    Width = 34,
                    Price = 45.90,
                    Config = 4,
                    MaxDischarge = 45,
                    MaxCharge = 2,
                    Name = "ZIPPY Flightmax 4500mAh 4S1P 45C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__17249__Turnigy_nano_tech_4500mah_5S_35_70C_Lipo_Pack.html",
                    Capacity = 4500,
                    Weight = 574,
                    Length = 154,
                    Height = 49,
                    Width = 34,
                    Price = 60.55,
                    Config = 5,
                    MaxDischarge = 35,
                    MaxCharge = 8,
                    Name = "Turnigy nano-tech 4500mah 5S 35~70C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__51840__Turnigy_nano_tech_Ultimate_4600mah_2S2P_90C_Hardcase_Lipo_Short_Pack_ROAR_BRCA_Approved_.html",
                    Capacity = 4600,
                    Weight = 237,
                    Length = 96,
                    Height = 25,
                    Width = 47,
                    Price = 41.02,
                    Config = 2,
                    MaxDischarge = 90,
                    MaxCharge = 2,
                    Name = "Turnigy nano-tech Ultimate 4600mah 2S2P 90C Hardcase Lipo Short Pack (ROAR & BRCA Approved)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__91206__Turnigy_Graphene_4600mAh_2S2P_Hardcase_Lipo_Shorty_Pack_ROAR_APPROVED_.html",
                    Capacity = 4600,
                    Weight = 206,
                    Length = 96,
                    Height = 47,
                    Width = 26,
                    Price = 51.21,
                    Config = 2,
                    MaxDischarge = 90,
                    MaxCharge = 10,
                    Name = "Turnigy Graphene 4600mAh 2S2P Hardcase Lipo Shorty Pack (ROAR APPROVED)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9315__Rhino_4900mAh_6S_22_2v_25C_Lipoly_Pack.html",
                    Capacity = 4900,
                    Weight = 730,
                    Length = 173,
                    Height = 50,
                    Width = 42,
                    Price = 55.76,
                    Config = 6,
                    MaxDischarge = 25,
                    MaxCharge = 2,
                    Name = "Rhino 4900mAh 6S 22.2v 25C Lipoly Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9259__Rhino_4900mAh_3S1P_25C_Lipoly_Pack.html",
                    Capacity = 4900,
                    Weight = 376,
                    Length = 154,
                    Height = 44,
                    Width = 26,
                    Price = 26.19,
                    Config = 3,
                    MaxDischarge = 25,
                    MaxCharge = 2,
                    Name = "Rhino 4900mAh 3S1P 25C Lipoly Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__15521__Turnigy_5000mAh_4S1P_14_8v_20C_Hardcase_Pack.html",
                    Capacity = 5000,
                    Weight = 528,
                    Length = 139,
                    Height = 45,
                    Width = 44,
                    Price = 25.85,
                    Config = 4,
                    MaxDischarge = 20,
                    MaxCharge = 5,
                    Name = "Turnigy 5000mAh 4S1P 14.8v 20C Hardcase Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__90675__Turnigy_LiHV_5000mAh_4S_15_2V_35C_Hardcase_Pack.html",
                    Capacity = 5000,
                    Weight = 670,
                    Length = 165,
                    Height = 52,
                    Width = 44,
                    Price = 35.99,
                    Config = 4,
                    MaxDischarge = 35,
                    MaxCharge = 5,
                    Name = "Turnigy LiHV 5000mAh 4S 15.2V 35C Hardcase Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__14085__ZIPPY_5000mAh_3S1P_30C_Hardcase_pack.html",
                    Capacity = 5000,
                    Weight = 429,
                    Length = 137,
                    Height = 46,
                    Width = 40,
                    Price = 37.06,
                    Config = 3,
                    MaxDischarge = 30,
                    MaxCharge = 3,
                    Name = "ZIPPY 5000mAh 3S1P 30C Hardcase pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9517__Turnigy_5000mAh_5S_30C_Lipo_Pack.html",
                    Capacity = 5000,
                    Weight = 620,
                    Length = 145,
                    Height = 50,
                    Width = 41,
                    Price = 55.05,
                    Config = 5,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "Turnigy 5000mAh 5S 30C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__53694__Turnigy_Heavy_Duty_5000mAh_7S_60C_Lipo_Pack.html",
                    Capacity = 5000,
                    Weight = 985,
                    Length = 152,
                    Height = 50,
                    Width = 52,
                    Price = 71.24,
                    Config = 7,
                    MaxDischarge = 60,
                    MaxCharge = 5,
                    Name = "Turnigy Heavy Duty 5000mAh 7S 60C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__17253__Turnigy_nano_tech_5000mah_3S_35_70C_Lipo_Pack.html",
                    Capacity = 5000,
                    Weight = 409,
                    Length = 150,
                    Height = 49,
                    Width = 26,
                    Price = 43.53,
                    Config = 3,
                    MaxDischarge = 35,
                    MaxCharge = 8,
                    Name = "Turnigy nano-tech 5000mah 3S 35~70C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__99484__Turnigy_5000mAh_4S_40C_Lipo_Pack_with_XT90.html",
                    Capacity = 5000,
                    Weight = 550,
                    Length = 143,
                    Height = 51,
                    Width = 38,
                    Price = 46.55,
                    Config = 4,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "Turnigy 5000mAh 4S 40C Lipo Pack with XT90"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__8590__ZIPPY_Flightmax_5000mAh_6S1P_30C.html",
                    Capacity = 5000,
                    Weight = 730,
                    Length = 145,
                    Height = 51,
                    Width = 51,
                    Price = 54.76,
                    Config = 6,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "ZIPPY Flightmax 5000mAh 6S1P 30C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9961__ZIPPY_Flightmax_5000mAh_2S1P_40C.html",
                    Capacity = 5000,
                    Weight = 290,
                    Length = 145,
                    Height = 50,
                    Width = 17,
                    Price = 23.93,
                    Config = 2,
                    MaxDischarge = 40,
                    MaxCharge = 3,
                    Name = "ZIPPY Flightmax 5000mAh 2S1P 40C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__91202__Turnigy_Graphene_5000mAh_6S_65C_LiPo_Pack_w_XT90.html",
                    Capacity = 5000,
                    Weight = 886,
                    Length = 146,
                    Height = 51,
                    Width = 63,
                    Price = 129.01,
                    Config = 6,
                    MaxDischarge = 65,
                    MaxCharge = 10,
                    Name = "Turnigy Graphene 5000mAh 6S 65C LiPo Pack w/ XT90"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__14079__ZIPPY_5000mAh_2S1P_20C_Hardcase_Pack.html",
                    Capacity = 5000,
                    Weight = 279,
                    Length = 137,
                    Height = 46,
                    Width = 25,
                    Price = 21.58,
                    Config = 2,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "ZIPPY 5000mAh 2S1P 20C Hardcase Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__91209__Turnigy_Graphene_5000mAh_4S_Hardcase_Lipo_Pack_ROAR_APPROVED_.html",
                    Capacity = 5000,
                    Weight = 599,
                    Length = 165,
                    Height = 52,
                    Width = 44,
                    Price = 109.84,
                    Config = 4,
                    MaxDischarge = 90,
                    MaxCharge = 10,
                    Name = "Turnigy Graphene 5000mAh 4S Hardcase Lipo Pack (ROAR APPROVED)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__17264__Turnigy_nano_tech_5000mah_2S_45_90C_Lipo_Pack.html",
                    Capacity = 5000,
                    Weight = 279,
                    Length = 152,
                    Height = 49,
                    Width = 17,
                    Price = 31.67,
                    Config = 2,
                    MaxDischarge = 45,
                    MaxCharge = 10,
                    Name = "Turnigy nano-tech 5000mah 2S 45~90C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__53693__Turnigy_Heavy_Duty_5000mAh_4S_60C_Lipo_Pack.html",
                    Capacity = 5000,
                    Weight = 602,
                    Length = 147,
                    Height = 50,
                    Width = 40,
                    Price = 58.48,
                    Config = 4,
                    MaxDischarge = 60,
                    MaxCharge = 2,
                    Name = "Turnigy Heavy Duty 5000mAh 4S 60C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__38498__Turnigy_5000mAh_2S_7_4V_60C_Hardcase_Pack.html",
                    Capacity = 5000,
                    Weight = 315,
                    Length = 139,
                    Height = 25,
                    Width = 46,
                    Price = 27.03,
                    Config = 2,
                    MaxDischarge = 60,
                    MaxCharge = 5,
                    Name = "Turnigy 5000mAh 2S 7.4V 60C Hardcase Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21371__ZIPPY_Compact_5000mAh_4S_25C_Lipo_Pack.html",
                    Capacity = 5000,
                    Weight = 488,
                    Length = 162,
                    Height = 46,
                    Width = 29,
                    Price = 38.42,
                    Config = 4,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 5000mAh 4S 25C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21373__ZIPPY_Compact_5000mAh_6S_25C_Lipo_Pack.html",
                    Capacity = 5000,
                    Weight = 703,
                    Length = 161,
                    Height = 46,
                    Width = 45,
                    Price = 55.44,
                    Config = 6,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 5000mAh 6S 25C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__88019__Turnigy_Bolt_5000mAh_4S_15_2V_65_130C_High_Voltage_Lipoly_Pack_LiHV_.html",
                    Capacity = 5000,
                    Weight = 548,
                    Length = 165,
                    Height = 45,
                    Width = 37,
                    Price = 73.58,
                    Config = 4,
                    MaxDischarge = 65,
                    MaxCharge = 2,
                    Name = "Turnigy Bolt 5000mAh 4S 15.2V 65~130C High Voltage Lipoly Pack (LiHV)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__16501__ZIPPY_Flightmax_5000mAh_6S1P_45C.html",
                    Capacity = 5000,
                    Weight = 888,
                    Length = 144,
                    Height = 52,
                    Width = 58,
                    Price = 74.37,
                    Config = 6,
                    MaxDischarge = 45,
                    MaxCharge = 2,
                    Name = "ZIPPY Flightmax 5000mAh 6S1P 45C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__8578__ZIPPY_Flightmax_5000mAh_2S1P_20C.html",
                    Capacity = 5000,
                    Weight = 270,
                    Length = 144,
                    Height = 51,
                    Width = 17,
                    Price = 15.40,
                    Config = 2,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "ZIPPY Flightmax 5000mAh 2S1P 20C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__85857__ZIPPY_Compact_5000mAh_7S_25C_Lipo_Pack_Single_Balance_Tab_Version_.html",
                    Capacity = 5000,
                    Weight = 752,
                    Length = 158,
                    Height = 45,
                    Width = 53,
                    Price = 71.47,
                    Config = 7,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 5000mAh 7S 25C Lipo Pack (Single Balance Tab Version)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21006__Turnigy_5000mAh_2S2P_40C_Hardcase_Pack_ROAR_APPROVED_.html",
                    Capacity = 5000,
                    Weight = 326,
                    Length = 137,
                    Height = 46,
                    Width = 25,
                    Price = 26.80,
                    Config = 2,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "Turnigy 5000mAh 2S2P 40C Hardcase Pack (ROAR APPROVED)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9515__Turnigy_5000mAh_3S_30C_Lipo_Pack.html",
                    Capacity = 5000,
                    Weight = 414,
                    Length = 145,
                    Height = 49,
                    Width = 27,
                    Price = 32.94,
                    Config = 3,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "Turnigy 5000mAh 3S 30C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__14613__Turnigy_nano_tech_5000mah_5S_25_50C_Lipo_Pack.html",
                    Capacity = 5000,
                    Weight = 643,
                    Length = 160,
                    Height = 50,
                    Width = 41,
                    Price = 55.98,
                    Config = 5,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 5000mah 5S 25~50C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__17256__Turnigy_nano_tech_5000mah_6S_35_70C_Lipo_Pack.html",
                    Capacity = 5000,
                    Weight = 786,
                    Length = 154,
                    Height = 50,
                    Width = 49,
                    Price = 82.24,
                    Config = 6,
                    MaxDischarge = 35,
                    MaxCharge = 8,
                    Name = "Turnigy nano-tech 5000mah 6S 35~70C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__91208__Turnigy_Graphene_5000mAh_2S3P_90C_Hardcase_Lipo_Saddle_Pack_ROAR_APPROVED_.html",
                    Capacity = 5000,
                    Weight = 266,
                    Length = 69,
                    Height = 47,
                    Width = 26,
                    Price = 48.95,
                    Config = 2,
                    MaxDischarge = 90,
                    MaxCharge = 10,
                    Name = "Turnigy Graphene 5000mAh 2S3P 90C Hardcase Lipo Saddle Pack (ROAR APPROVED)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__91207__Turnigy_Graphene_5000mAh_2S2P_Hardcase_Lipo_Pack_ROAR_APPROVED_.html",
                    Capacity = 5000,
                    Weight = 291,
                    Length = 139,
                    Height = 47,
                    Width = 26,
                    Price = 55.54,
                    Config = 2,
                    MaxDischarge = 90,
                    MaxCharge = 10,
                    Name = "Turnigy Graphene 5000mAh 2S2P Hardcase Lipo Pack (ROAR APPROVED)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__14616__Turnigy_nano_tech_5000mah_6S_45_90C_Lipo_Pack.html",
                    Capacity = 5000,
                    Weight = 813,
                    Length = 157,
                    Height = 49,
                    Width = 50,
                    Price = 94.81,
                    Config = 6,
                    MaxDischarge = 45,
                    MaxCharge = 10,
                    Name = "Turnigy nano-tech 5000mah 6S 45~90C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__91201__Turnigy_Graphene_5000mAh_6S_45C_LiPo_Pack_w_XT90.html",
                    Capacity = 5000,
                    Weight = 858,
                    Length = 146,
                    Height = 51,
                    Width = 60,
                    Price = 111.70,
                    Config = 6,
                    MaxDischarge = 45,
                    MaxCharge = 10,
                    Name = "Turnigy Graphene 5000mAh 6S 45C LiPo Pack w/ XT90"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__18560__Turnigy_5000mAh_1S_20C_Lipoly_Single_Cell_.html",
                    Capacity = 5000,
                    Weight = 114,
                    Length = 128,
                    Height = 42,
                    Width = 10,
                    Price = 7.38,
                    Config = 1,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "Turnigy 5000mAh 1S 20C Lipoly (Single Cell)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9179__Turnigy_5000mAh_4S_25C_Lipo_Pack.html",
                    Capacity = 5000,
                    Weight = 552,
                    Length = 147,
                    Height = 49,
                    Width = 33,
                    Price = 29.84,
                    Config = 4,
                    MaxDischarge = 25,
                    MaxCharge = 2,
                    Name = "Turnigy 5000mAh 4S 25C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9514__Turnigy_5000mAh_2S_30C_Lipo_Pack.html",
                    Capacity = 5000,
                    Weight = 301,
                    Length = 143,
                    Height = 50,
                    Width = 19,
                    Price = 21.26,
                    Config = 2,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "Turnigy 5000mAh 2S 30C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9518__Turnigy_5000mAh_6S_30C_Lipo_Pack.html",
                    Capacity = 5000,
                    Weight = 805,
                    Length = 145,
                    Height = 50,
                    Width = 50,
                    Price = 53.93,
                    Config = 6,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "Turnigy 5000mAh 6S 30C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9175__Turnigy_5000mAh_5S_25C_Lipo_Pack.html",
                    Capacity = 5000,
                    Weight = 677,
                    Length = 144,
                    Height = 49,
                    Width = 41,
                    Price = 44.21,
                    Config = 5,
                    MaxDischarge = 25,
                    MaxCharge = 2,
                    Name = "Turnigy 5000mAh 5S 25C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__91200__Turnigy_Graphene_5000mAh_4S_65C_Lipo_Pack_w_XT90.html",
                    Capacity = 5000,
                    Weight = 612,
                    Length = 144,
                    Height = 51,
                    Width = 43,
                    Price = 82.23,
                    Config = 4,
                    MaxDischarge = 65,
                    MaxCharge = 10,
                    Name = "Turnigy Graphene 5000mAh 4S 65C Lipo Pack w/XT90"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__8579__ZIPPY_Flightmax_5000mAh_3S1P_20C.html",
                    Capacity = 5000,
                    Weight = 404,
                    Length = 145,
                    Height = 52,
                    Width = 25,
                    Price = 23.28,
                    Config = 3,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "ZIPPY Flightmax 5000mAh 3S1P 20C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__14081__ZIPPY_5000mAh_2S1P_30C_Hardcase_Pack.html",
                    Capacity = 5000,
                    Weight = 301,
                    Length = 138,
                    Height = 47,
                    Width = 25,
                    Price = 23.66,
                    Config = 2,
                    MaxDischarge = 30,
                    MaxCharge = 3,
                    Name = "ZIPPY 5000mAh 2S1P 30C Hardcase Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21369___ZIPPY_Compact_5000mAh_2S_25C_Lipo_Pack.html",
                    Capacity = 5000,
                    Weight = 237,
                    Length = 162,
                    Height = 14,
                    Width = 46,
                    Price = 18.65,
                    Config = 2,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 5000mAh 2S 25C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__17255__Turnigy_nano_tech_5000mah_5S_35_70C_Lipo_Pack.html",
                    Capacity = 5000,
                    Weight = 659,
                    Length = 154,
                    Height = 49,
                    Width = 41,
                    Price = 67.42,
                    Config = 5,
                    MaxDischarge = 35,
                    MaxCharge = 8,
                    Name = "Turnigy nano-tech 5000mah 5S 35~70C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21372__ZIPPY_Compact_5000mAh_5S_25C_Lipo_Pack.html",
                    Capacity = 5000,
                    Weight = 590,
                    Length = 163,
                    Height = 38,
                    Width = 46,
                    Price = 46.34,
                    Config = 5,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 5000mAh 5S 25C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__17274__Turnigy_nano_tech_5000mah_2S3P_30_60C_Hardcase_Saddle_Lipo_Pack_ROAR_APPROVED_.html",
                    Capacity = 5000,
                    Weight = 285,
                    Length = 70,
                    Height = 47,
                    Width = 25,
                    Price = 26.50,
                    Config = 2,
                    MaxDischarge = 30,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 5000mah 2S3P 30~60C Hardcase Saddle Lipo Pack (ROAR APPROVED)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__8587__ZIPPY_Flightmax_5000mAh_3S1P_30C.html",
                    Capacity = 5000,
                    Weight = 408,
                    Length = 144,
                    Height = 51,
                    Width = 27,
                    Price = 30.22,
                    Config = 3,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "ZIPPY Flightmax 5000mAh 3S1P 30C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__10306__Turnigy_5000mAh_3S_40C_Lipo_Pack.html",
                    Capacity = 5000,
                    Weight = 443,
                    Length = 145,
                    Height = 50,
                    Width = 27,
                    Price = 35.78,
                    Config = 3,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "Turnigy 5000mAh 3S 40C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__8583__ZIPPY_Flightmax_5000mAh_3S1P_25C.html",
                    Capacity = 5000,
                    Weight = 342,
                    Length = 143,
                    Height = 50,
                    Width = 22,
                    Price = 25.38,
                    Config = 3,
                    MaxDischarge = 25,
                    MaxCharge = 2,
                    Name = "ZIPPY Flightmax 5000mAh 3S1P 25C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__10308__Turnigy_5000mAh_6S_40C_Lipo_Pack.html",
                    Capacity = 5000,
                    Weight = 836,
                    Length = 150,
                    Height = 49,
                    Width = 52,
                    Price = 56.77,
                    Config = 6,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "Turnigy 5000mAh 6S 40C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__63419__ZIPPY_Compact_5000mAh_3s_40c_Lipo_Pack.html",
                    Capacity = 5000,
                    Weight = 420,
                    Length = 156,
                    Height = 45,
                    Width = 30,
                    Price = 35.86,
                    Config = 3,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 5000mAh 3s 40c Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__24303__Turnigy_nano_tech_A_SPEC_5000mah_7S_65_130C_Lipo_Pack.html",
                    Capacity = 5000,
                    Weight = 978,
                    Length = 154,
                    Height = 49,
                    Width = 63,
                    Price = 99.99,
                    Config = 7,
                    MaxDischarge = 65,
                    MaxCharge = 8,
                    Name = "Turnigy nano-tech A-SPEC 5000mah 7S 65~130C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__14083__ZIPPY_5000mAh_3S1P_20C_Hardcase_Pack_.html",
                    Capacity = 5000,
                    Weight = 418,
                    Length = 137,
                    Height = 47,
                    Width = 40,
                    Price = 29.00,
                    Config = 3,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "ZIPPY 5000mAh 3S1P 20C Hardcase Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__19152__Turnigy_nano_tech_5000mah_2S_65_130C_Lipo_Pack.html",
                    Capacity = 5000,
                    Weight = 304,
                    Length = 151,
                    Height = 48,
                    Width = 19,
                    Price = 38.76,
                    Config = 2,
                    MaxDischarge = 65,
                    MaxCharge = 8,
                    Name = "Turnigy nano-tech 5000mah 2S 65~130C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__20999__ZIPPY_5000mAh_2S1P_30C_Hardcase_Pack_ROAR_APPROVED_.html",
                    Capacity = 5000,
                    Weight = 278,
                    Length = 137,
                    Height = 47,
                    Width = 24,
                    Price = 28.39,
                    Config = 2,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "ZIPPY 5000mAh 2S1P 30C Hardcase Pack (ROAR APPROVED)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9184__Turnigy_5000mAh_3S_20C_Lipo_Pack.html",
                    Capacity = 5000,
                    Weight = 346,
                    Length = 143,
                    Height = 51,
                    Width = 23,
                    Price = 23.28,
                    Config = 3,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "Turnigy 5000mAh 3S 20C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__91199__Turnigy_Graphene_5000mAh_4S_45C_Lipo_Pack_w_XT90.html",
                    Capacity = 5000,
                    Weight = 586,
                    Length = 143,
                    Height = 51,
                    Width = 40,
                    Price = 70.86,
                    Config = 4,
                    MaxDischarge = 45,
                    MaxCharge = 10,
                    Name = "Turnigy Graphene 5000mAh 4S 45C Lipo Pack w/XT90"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__91197__Turnigy_Graphene_5000mAh_3S_45C_LiPo_Pack_w_XT90.html",
                    Capacity = 5000,
                    Weight = 455,
                    Length = 144,
                    Height = 51,
                    Width = 32,
                    Price = 53.19,
                    Config = 3,
                    MaxDischarge = 45,
                    MaxCharge = 10,
                    Name = "Turnigy Graphene 5000mAh 3S 45C LiPo Pack w/XT90"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__11957__Turnigy_nano_tech_5000mah_4S_45_90C_Lipo_Pack.html",
                    Capacity = 5000,
                    Weight = 585,
                    Length = 166,
                    Height = 50,
                    Width = 37,
                    Price = 63.19,
                    Config = 4,
                    MaxDischarge = 45,
                    MaxCharge = 10,
                    Name = "Turnigy nano-tech 5000mah 4S 45~90C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21001__Turnigy_5000mAh_2S1P_20C_Hardcase_Pack_ROAR_APPROVED_.html",
                    Capacity = 5000,
                    Weight = 276,
                    Length = 135,
                    Height = 45,
                    Width = 22,
                    Price = 19.79,
                    Config = 2,
                    MaxDischarge = 20,
                    MaxCharge = 5,
                    Name = "Turnigy 5000mAh 2S1P 20C Hardcase Pack (ROAR APPROVED)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__63424__ZIPPY_Compact_5000mAh_4s_60c_Lipo_Pack.html",
                    Capacity = 5000,
                    Weight = 578,
                    Length = 158,
                    Height = 46,
                    Width = 41,
                    Price = 58.26,
                    Config = 4,
                    MaxDischarge = 60,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 5000mAh 4s 60c Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__10307__Turnigy_5000mAh_4S_40C_Lipo_Pack.html",
                    Capacity = 5000,
                    Weight = 578,
                    Length = 149,
                    Height = 49,
                    Width = 37,
                    Price = 46.60,
                    Config = 4,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "Turnigy 5000mAh 4S 40C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9176__Turnigy_5000mAh_6S_20C_Lipo_Pack.html",
                    Capacity = 5000,
                    Weight = 765,
                    Length = 145,
                    Height = 50,
                    Width = 50,
                    Price = 40.43,
                    Config = 6,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "Turnigy 5000mAh 6S 20C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__11956__Turnigy_nano_tech_5000mah_3S_45_90C_Lipo_Pack.html",
                    Capacity = 5000,
                    Weight = 425,
                    Length = 150,
                    Height = 48,
                    Width = 27,
                    Price = 50.95,
                    Config = 3,
                    MaxDischarge = 45,
                    MaxCharge = 10,
                    Name = "Turnigy nano-tech 5000mah 3S 45~90C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21370__ZIPPY_Compact_5000mAh_3S_25C_Lipo_Pack.html",
                    Capacity = 5000,
                    Weight = 361,
                    Length = 155,
                    Height = 26,
                    Width = 44,
                    Price = 29.86,
                    Config = 3,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 5000mAh 3S 25C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__10305__Turnigy_5000mAh_2S_40C_Lipo_Pack.html",
                    Capacity = 5000,
                    Weight = 308,
                    Length = 147,
                    Height = 49,
                    Width = 18,
                    Price = 24.45,
                    Config = 2,
                    MaxDischarge = 40,
                    MaxCharge = 4,
                    Name = "Turnigy 5000mAh 2S 40C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__11935__Turnigy_nano_tech_5000mah_3S_25_50C_Lipo_Pack.html",
                    Capacity = 5000,
                    Weight = 403,
                    Length = 169,
                    Height = 48,
                    Width = 25,
                    Price = 36.18,
                    Config = 3,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 5000mah 3S 25~50C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__19158__Turnigy_nano_tech_5000mah_8S_65_130C_Lipo_Pack.html",
                    Capacity = 5000,
                    Weight = 1106,
                    Length = 154,
                    Height = 49,
                    Width = 72,
                    Price = 157.30,
                    Config = 8,
                    MaxDischarge = 65,
                    MaxCharge = 8,
                    Name = "Turnigy nano-tech 5000mah 8S 65~130C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9964__ZIPPY_Flightmax_5000mAh_5S1P_40C.html",
                    Capacity = 5000,
                    Weight = 704,
                    Length = 147,
                    Height = 51,
                    Width = 45,
                    Price = 53.39,
                    Config = 5,
                    MaxDischarge = 40,
                    MaxCharge = 3,
                    Name = "ZIPPY Flightmax 5000mAh 5S1P 40C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__63425__ZIPPY_Compact_5000mAh_6s_60c_Lipo_Pack.html",
                    Capacity = 5000,
                    Weight = 845,
                    Length = 165,
                    Height = 47,
                    Width = 61,
                    Price = 78.90,
                    Config = 6,
                    MaxDischarge = 60,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 5000mAh 6s 60c Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__11934__Turnigy_nano_tech_5000mah_2S_25_50C_Lipo_Pack.html",
                    Capacity = 5000,
                    Weight = 279,
                    Length = 173,
                    Height = 49,
                    Width = 16,
                    Price = 22.39,
                    Config = 2,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 5000mah 2S 25~50C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__53692__Turnigy_Heavy_Duty_5000mAh_3S_60C_Lipo_Pack.html",
                    Capacity = 5000,
                    Weight = 464,
                    Length = 147,
                    Height = 50,
                    Width = 30,
                    Price = 40.57,
                    Config = 3,
                    MaxDischarge = 60,
                    MaxCharge = 2,
                    Name = "Turnigy Heavy Duty 5000mAh 3S 60C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__11936__Turnigy_nano_tech_5000mah_4S_25_50C_Lipo_Pack.html",
                    Capacity = 5000,
                    Weight = 523,
                    Length = 159,
                    Height = 49,
                    Width = 33,
                    Price = 49.95,
                    Config = 4,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 5000mah 4S 25~50C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__17252__Turnigy_nano_tech_5000mah_2S_35_70C_Lipo_Pack.html",
                    Capacity = 5000,
                    Weight = 286,
                    Length = 150,
                    Height = 49,
                    Width = 17,
                    Price = 26.95,
                    Config = 2,
                    MaxDischarge = 35,
                    MaxCharge = 8,
                    Name = "Turnigy nano-tech 5000mah 2S 35~70C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__38515__Turnigy_Heavy_Duty_Series_5000mAh_6S_60C_Lipo_Pack.html",
                    Capacity = 5000,
                    Weight = 864,
                    Length = 143,
                    Height = 50,
                    Width = 59,
                    Price = 67.68,
                    Config = 6,
                    MaxDischarge = 60,
                    MaxCharge = 2,
                    Name = "Turnigy Heavy Duty Series 5000mAh 6S 60C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__63422__ZIPPY_Compact_5000mAh_2s_60c_Lipo_Pack.html",
                    Capacity = 5000,
                    Weight = 308,
                    Length = 154,
                    Height = 45,
                    Width = 22,
                    Price = 30.19,
                    Config = 2,
                    MaxDischarge = 60,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 5000mAh 2s 60c Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__19153__Turnigy_nano_tech_5000mah_3S_65_130C_Lipo_Pack.html",
                    Capacity = 5000,
                    Weight = 442,
                    Length = 152,
                    Height = 49,
                    Width = 28,
                    Price = 57.44,
                    Config = 3,
                    MaxDischarge = 65,
                    MaxCharge = 8,
                    Name = "Turnigy nano-tech 5000mah 3S 65~130C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9962__ZIPPY_Flightmax_5000mAh_3S1P_40C.html",
                    Capacity = 5000,
                    Weight = 440,
                    Length = 145,
                    Height = 50,
                    Width = 28,
                    Price = 35.98,
                    Config = 3,
                    MaxDischarge = 40,
                    MaxCharge = 2,
                    Name = "ZIPPY Flightmax 5000mAh 3S1P 40C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__16497__ZIPPY_Flightmax_5000mAh_2S1P_45C.html",
                    Capacity = 5000,
                    Weight = 308,
                    Length = 143,
                    Height = 52,
                    Width = 19,
                    Price = 25.91,
                    Config = 2,
                    MaxDischarge = 45,
                    MaxCharge = 2,
                    Name = "ZIPPY Flightmax 5000mAh 2S1P 45C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__99479__ZIPPY_Flightmax_5000mAh_4S1P_30C_with_XT90.html",
                    Capacity = 5000,
                    Weight = 490,
                    Length = 143,
                    Height = 51,
                    Width = 34,
                    Price = 35.61,
                    Config = 4,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "ZIPPY Flightmax 5000mAh 4S1P 30C with XT90"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9516__Turnigy_5000mAh_4S_30C_Lipo_Pack.html",
                    Capacity = 5000,
                    Weight = 556,
                    Length = 144,
                    Height = 49,
                    Width = 36,
                    Price = 35.34,
                    Config = 4,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "Turnigy 5000mAh 4S 30C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9183__Turnigy_5000mAh_3S_25C_Lipo_Pack.html",
                    Capacity = 5000,
                    Weight = 412,
                    Length = 146,
                    Height = 50,
                    Width = 25,
                    Price = 25.41,
                    Config = 3,
                    MaxDischarge = 25,
                    MaxCharge = 2,
                    Name = "Turnigy 5000mAh 3S 25C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9172__Turnigy_5000mAh_2S_20C_Lipo_Pack.html",
                    Capacity = 5000,
                    Weight = 282,
                    Length = 148,
                    Height = 49,
                    Width = 16,
                    Price = 16.63,
                    Config = 2,
                    MaxDischarge = 20,
                    MaxCharge = 2,
                    Name = "Turnigy 5000mAh 2S 20C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__17266__Turnigy_nano_tech_5100mah_2S3P_65_135C_Hardcase_Saddle_Pack.html",
                    Capacity = 5100,
                    Weight = 290,
                    Length = 69,
                    Height = 47,
                    Width = 25,
                    Price = 37.95,
                    Config = 2,
                    MaxDischarge = 65,
                    MaxCharge = 10,
                    Name = "Turnigy nano-tech 5100mah 2S3P 65~135C Hardcase Saddle Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21000__ZIPPY_5200mAh_2S2P_30C_hardcase_pack_ROAR_APPROVED_.html",
                    Capacity = 5200,
                    Weight = 314,
                    Length = 137,
                    Height = 46,
                    Width = 25,
                    Price = 21.20,
                    Config = 2,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "ZIPPY 5200mAh 2S2P 30C hardcase pack (ROAR APPROVED)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21002__Turnigy_5200mAh_2S_30C_Hard_Case_Car_Lipo_Pack_ROAR_APPROVED_.html",
                    Capacity = 5200,
                    Weight = 336,
                    Length = 137,
                    Height = 46,
                    Width = 25,
                    Price = 23.95,
                    Config = 2,
                    MaxDischarge = 30,
                    MaxCharge = 5,
                    Name = "Turnigy 5200mAh 2S 30C Hard-Case Car Lipo Pack (ROAR APPROVED)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__84099__MultiStar_LiHV_High_Capacity_6S_5200mAh_Multi_Rotor_Lipo_Pack.html",
                    Capacity = 5200,
                    Weight = 618,
                    Length = 106,
                    Height = 35,
                    Width = 90,
                    Price = 55.84,
                    Config = 6,
                    MaxDischarge = 10,
                    MaxCharge = 5,
                    Name = "MultiStar LiHV High Capacity 6S 5200mAh Multi-Rotor Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__62884__MultiStar_High_Capacity_3S_5200mAh_Multi_Rotor_Lipo_Pack.html",
                    Capacity = 5200,
                    Weight = 325,
                    Length = 108,
                    Height = 44,
                    Width = 34,
                    Price = 25.97,
                    Config = 3,
                    MaxDischarge = 10,
                    MaxCharge = 2,
                    Name = "MultiStar High Capacity 3S 5200mAh Multi-Rotor Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__56839__Multistar_High_Capacity_3S_5200mAh_Multi_Rotor_Lipo_Pack.html",
                    Capacity = 5200,
                    Weight = 331,
                    Length = 142,
                    Height = 49,
                    Width = 22,
                    Price = 31.79,
                    Config = 3,
                    MaxDischarge = 10,
                    MaxCharge = 2,
                    Name = "Multistar High Capacity 3S 5200mAh Multi-Rotor Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__89608__Turnigy_Graphene_Professional_5200mAh_3S_15C_LiPo_Pack_w_XT60.html",
                    Capacity = 5200,
                    Weight = 363,
                    Length = 107,
                    Height = 35,
                    Width = 51,
                    Price = 32.99,
                    Config = 3,
                    MaxDischarge = 15,
                    MaxCharge = 5,
                    Name = "Turnigy Graphene Professional 5200mAh 3S 15C LiPo Pack w/XT60"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__56840__Multistar_High_Capacity_4S_5200mAh_Multi_Rotor_Lipo_Pack.html",
                    Capacity = 5200,
                    Weight = 433,
                    Length = 142,
                    Height = 49,
                    Width = 29,
                    Price = 20.99,
                    Config = 4,
                    MaxDischarge = 10,
                    MaxCharge = 2,
                    Name = "Multistar High Capacity 4S 5200mAh Multi-Rotor Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__56841__Multistar_High_Capacity_6S_5200mAh_Multi_Rotor_Lipo_Pack.html",
                    Capacity = 5200,
                    Weight = 643,
                    Length = 142,
                    Height = 49,
                    Width = 43,
                    Price = 27.99,
                    Config = 6,
                    MaxDischarge = 10,
                    MaxCharge = 2,
                    Name = "Multistar High Capacity 6S 5200mAh Multi-Rotor Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__62885__MultiStar_High_Capacity_3S_5200mAh_Multi_Rotor_Lipo_Pack_for_QR_X350_PRO.html",
                    Capacity = 5200,
                    Weight = 325,
                    Length = 106,
                    Height = 44,
                    Width = 34,
                    Price = 28.10,
                    Config = 3,
                    MaxDischarge = 10,
                    MaxCharge = 5,
                    Name = "MultiStar High Capacity 3S 5200mAh Multi-Rotor Lipo Pack for QR X350 PRO"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__17273__Turnigy_nano_tech_5300mah_2S2P_30_60C_Hardcase_Lipo_Pack_ROAR_APPROVED_.html",
                    Capacity = 5300,
                    Weight = 271,
                    Length = 138,
                    Height = 46,
                    Width = 25,
                    Price = 29.57,
                    Config = 2,
                    MaxDischarge = 30,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 5300mah 2S2P 30~60C Hardcase Lipo Pack (ROAR APPROVED)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__17269__Turnigy_nano_tech_5300mah_2S2P_50_100C_Hardcase_Lipo_Pack.html",
                    Capacity = 5300,
                    Weight = 295,
                    Length = 138,
                    Height = 47,
                    Width = 25,
                    Price = 32.93,
                    Config = 2,
                    MaxDischarge = 50,
                    MaxCharge = 8,
                    Name = "Turnigy nano-tech 5300mah 2S2P 50~100C Hardcase Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__51506__Turnigy_Bolt_5400mAh_6S_22_8V_65_130C_High_Voltage_Lipoly_Pack_LiHV_.html",
                    Capacity = 5400,
                    Weight = 821,
                    Length = 167,
                    Height = 56.1,
                    Width = 49,
                    Price = 123.22,
                    Config = 6,
                    MaxDischarge = 65,
                    MaxCharge = 2,
                    Name = "Turnigy Bolt 5400mAh 6S 22.8V 65~130C High Voltage Lipoly Pack (LiHV)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__51505__Turnigy_Bolt_5400mAh_3S_11_4V_65_130C_High_Voltage_Lipoly_Pack_LiHV_.html",
                    Capacity = 5400,
                    Weight = 439,
                    Length = 167,
                    Height = 28.6,
                    Width = 49,
                    Price = 61.61,
                    Config = 3,
                    MaxDischarge = 65,
                    MaxCharge = 2,
                    Name = "Turnigy Bolt 5400mAh 3S 11.4V 65~130C High Voltage Lipoly Pack (LiHV)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__89915__Basher_5600mAh_2S2P_60C_Hardcase_LiHV_Pack.html",
                    Capacity = 5600,
                    Weight = 294,
                    Length = 139,
                    Height = 25,
                    Width = 47,
                    Price = 47.17,
                    Config = 2,
                    MaxDischarge = 60,
                    MaxCharge = 2,
                    Name = "Basher 5600mAh 2S2P 60C Hardcase LiHV Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__17268__Turnigy_nano_tech_5600mah_2S2P_50_100C_Hardcase_Lipo_Pack_ROAR_APPROVED_.html",
                    Capacity = 5600,
                    Weight = 294,
                    Length = 138,
                    Height = 47,
                    Width = 25,
                    Price = 37.95,
                    Config = 2,
                    MaxDischarge = 50,
                    MaxCharge = 8,
                    Name = "Turnigy nano-tech 5600mah 2S2P 50~100C Hardcase Lipo Pack (ROAR APPROVED)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__91210__Turnigy_Graphene_5600mAh_2S2P_Hardcase_Lipo_Pack_ROAR_APPROVED_.html",
                    Capacity = 5600,
                    Weight = 295,
                    Length = 139,
                    Height = 47,
                    Width = 26,
                    Price = 62.05,
                    Config = 2,
                    MaxDischarge = 90,
                    MaxCharge = 10,
                    Name = "Turnigy Graphene 5600mAh 2S2P Hardcase Lipo Pack (ROAR APPROVED)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__18607__ZIPPY_5700mah_2S2P_50C_Hardcase_Pack.html",
                    Capacity = 5700,
                    Weight = 324,
                    Length = 138,
                    Height = 46,
                    Width = 25,
                    Price = 29.78,
                    Config = 2,
                    MaxDischarge = 50,
                    MaxCharge = 1,
                    Name = "ZIPPY 5700mah 2S2P 50C Hardcase Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9967__ZIPPY_5700mAh_2S3P_25C_Saddle_Pack.html",
                    Capacity = 5700,
                    Weight = 154,
                    Length = 69,
                    Height = 46,
                    Width = 31,
                    Price = 23.20,
                    Config = 2,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "ZIPPY 5700mAh 2S3P 25C Saddle Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21385__ZIPPY_Compact_5800mAh_8S_25C_Lipo_Pack.html",
                    Capacity = 5800,
                    Weight = 1020,
                    Length = 167,
                    Height = 46,
                    Width = 64,
                    Price = 83.32,
                    Config = 8,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 5800mAh 8S 25C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21380__ZIPPY_Compact_5800mAh_3S_25C_Lipo_Pack.html",
                    Capacity = 5800,
                    Weight = 411,
                    Length = 154,
                    Height = 45,
                    Width = 29,
                    Price = 34.94,
                    Config = 3,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 5800mAh 3S 25C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21384__ZIPPY_Compact_5800mAh_7S_25C_Lipo_Pack.html",
                    Capacity = 5800,
                    Weight = 913,
                    Length = 160,
                    Height = 46,
                    Width = 57,
                    Price = 78.54,
                    Config = 7,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 5800mAh 7S 25C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__63426__ZIPPY_Compact_5800mAh_4s_40c_Lipo_Pack.html",
                    Capacity = 5800,
                    Weight = 562,
                    Length = 158,
                    Height = 45,
                    Width = 40,
                    Price = 52.52,
                    Config = 4,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 5800mAh 4s 40c Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21382__ZIPPY_Compact_5800mAh_5S_25C_Lipo_Pack_.html",
                    Capacity = 5800,
                    Weight = 655,
                    Length = 160,
                    Height = 45,
                    Width = 41,
                    Price = 64.16,
                    Config = 5,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 5800mAh 5S 25C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9932__ZIPPY_Flightmax_5800mAh_3S1P_30C.html",
                    Capacity = 5800,
                    Weight = 425,
                    Length = 143,
                    Height = 51,
                    Width = 28,
                    Price = 37.02,
                    Config = 3,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "ZIPPY Flightmax 5800mAh 3S1P 30C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21383__ZIPPY_Compact_5800mAh_6S_25C_Lipo_Pack.html",
                    Capacity = 5800,
                    Weight = 843,
                    Length = 163,
                    Height = 46,
                    Width = 53,
                    Price = 67.33,
                    Config = 6,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 5800mAh 6S 25C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9931__ZIPPY_Flightmax_5800mAh_2S1P_30C.html",
                    Capacity = 5800,
                    Weight = 289,
                    Length = 140,
                    Height = 50,
                    Width = 19,
                    Price = 21.99,
                    Config = 2,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "ZIPPY Flightmax 5800mAh 2S1P 30C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__21381__ZIPPY_Compact_5800mAh_4S_25C_Lipo_Pack.html",
                    Capacity = 5800,
                    Weight = 531,
                    Length = 153,
                    Height = 45,
                    Width = 38,
                    Price = 44.94,
                    Config = 4,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 5800mAh 4S 25C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__63429__ZIPPY_Compact_5800mAh_4s_60c_Lipo_Pack.html",
                    Capacity = 5800,
                    Weight = 576,
                    Length = 152,
                    Height = 46,
                    Width = 41,
                    Price = 61.08,
                    Config = 4,
                    MaxDischarge = 60,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 5800mAh 4s 60c Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__63428__ZIPPY_Compact_5800mAh_3s_60c_Lipo_Pack.html",
                    Capacity = 5800,
                    Weight = 448,
                    Length = 158,
                    Height = 45,
                    Width = 32,
                    Price = 49.66,
                    Config = 3,
                    MaxDischarge = 60,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 5800mAh 3s 60c Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__9934__ZIPPY_Flightmax_5800mAh_5S1P_30C.html",
                    Capacity = 5800,
                    Weight = 776,
                    Length = 145,
                    Height = 50,
                    Width = 49,
                    Price = 69.42,
                    Config = 5,
                    MaxDischarge = 30,
                    MaxCharge = 2,
                    Name = "ZIPPY Flightmax 5800mAh 5S1P 30C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__17272__Turnigy_nano_tech_5800mah_2S2P_30_60C_Hardcase_Lipo_Pack_ROAR_APPROVED_.html",
                    Capacity = 5800,
                    Weight = 296,
                    Length = 138,
                    Height = 46,
                    Width = 25,
                    Price = 33.20,
                    Config = 2,
                    MaxDischarge = 30,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 5800mah 2S2P 30~60C Hardcase Lipo Pack (ROAR APPROVED)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__19636__ZIPPY_5800mah_1S2P_60C_Hardcase_Pack.html",
                    Capacity = 5800,
                    Weight = 177,
                    Length = 92,
                    Height = 46,
                    Width = 19,
                    Price = 20.08,
                    Config = 1,
                    MaxDischarge = 60,
                    MaxCharge = 1,
                    Name = "ZIPPY 5800mah 1S2P 60C Hardcase Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__18611__ZIPPY_5900mah_2S2P_60C_Hardcase_Pack.html",
                    Capacity = 5900,
                    Weight = 320,
                    Length = 138,
                    Height = 46,
                    Width = 25,
                    Price = 33.05,
                    Config = 2,
                    MaxDischarge = 60,
                    MaxCharge = 1,
                    Name = "ZIPPY 5900mah 2S2P 60C Hardcase Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__91204__Turnigy_Graphene_6000mAh_4S_65C_Lipo_Pack_w_XT90.html",
                    Capacity = 6000,
                    Weight = 744,
                    Length = 168,
                    Height = 70,
                    Width = 33,
                    Price = 98.63,
                    Config = 4,
                    MaxDischarge = 65,
                    MaxCharge = 10,
                    Name = "Turnigy Graphene 6000mAh 4S 65C Lipo Pack w/XT90"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__18608__ZIPPY_6000mah_2S2P_50C_Hardcase_Pack.html",
                    Capacity = 6000,
                    Weight = 309,
                    Length = 138,
                    Height = 46,
                    Width = 25,
                    Price = 31.31,
                    Config = 2,
                    MaxDischarge = 50,
                    MaxCharge = 1,
                    Name = "ZIPPY 6000mah 2S2P 50C Hardcase Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__89369__Turnigy_nano_tech_A_SPEC_G2_6000mah_4S_45C_Lipo_Pack.html",
                    Capacity = 6000,
                    Weight = 633,
                    Length = 166,
                    Height = 51,
                    Width = 36,
                    Price = 77.87,
                    Config = 4,
                    MaxDischarge = 45,
                    MaxCharge = 6,
                    Name = "Turnigy nano-tech A-SPEC G2 6000mah 4S 45C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__17265__Turnigy_nano_tech_6000mah_2S2P_65_130C_Hardcase_Lipo_Pack.html",
                    Capacity = 6000,
                    Weight = 313,
                    Length = 138,
                    Height = 46,
                    Width = 25,
                    Price = 41.28,
                    Config = 2,
                    MaxDischarge = 65,
                    MaxCharge = 10,
                    Name = "Turnigy nano-tech 6000mah 2S2P 65~130C Hardcase Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__11941__Turnigy_nano_tech_6000mah_6S_25_50C_Lipo_Pack.html",
                    Capacity = 6000,
                    Weight = 908,
                    Length = 167,
                    Height = 49,
                    Width = 55,
                    Price = 80.61,
                    Config = 6,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 6000mah 6S 25~50C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__11940__Turnigy_nano_tech_6000mah_4S_25_50C_Lipo_Pack.html",
                    Capacity = 6000,
                    Weight = 623,
                    Length = 175,
                    Height = 49,
                    Width = 38,
                    Price = 60.02,
                    Config = 4,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 6000mah 4S 25~50C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__11939__Turnigy_nano_tech_6000mah_3S_25_50C_Lipo_Pack.html",
                    Capacity = 6000,
                    Weight = 468,
                    Length = 153,
                    Height = 48,
                    Width = 30,
                    Price = 49.62,
                    Config = 3,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 6000mah 3S 25~50C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__91205__Turnigy_Graphene_6000mAh_6S_65C_LiPo_Pack_w_XT90.html",
                    Capacity = 6000,
                    Weight = 1075,
                    Length = 170,
                    Height = 69,
                    Width = 48,
                    Price = 147.78,
                    Config = 6,
                    MaxDischarge = 65,
                    MaxCharge = 10,
                    Name = "Turnigy Graphene 6000mAh 6S 65C LiPo Pack w/ XT90"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__51838__Turnigy_nano_tech_Ultimate_6000mah_2S2P_90C_Hardcase_Lipo_Pack_ROAR_BRCA_Approved_.html",
                    Capacity = 6000,
                    Weight = 340,
                    Length = 139,
                    Height = 25,
                    Width = 47,
                    Price = 51.73,
                    Config = 2,
                    MaxDischarge = 90,
                    MaxCharge = 2,
                    Name = "Turnigy nano-tech Ultimate 6000mah 2S2P 90C Hardcase Lipo Pack (ROAR & BRCA Approved)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__11938__Turnigy_nano_tech_6000mah_2S_25_50C_Lipo_Pack.html",
                    Capacity = 6000,
                    Weight = 333,
                    Length = 155,
                    Height = 49,
                    Width = 20,
                    Price = 28.95,
                    Config = 2,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 6000mah 2S 25~50C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__91211__Turnigy_Graphene_6000mAh_2S2P_Hardcase_Lipo_Pack_ROAR_APPROVAL_.html",
                    Capacity = 6000,
                    Weight = 299,
                    Length = 139,
                    Height = 47,
                    Width = 26,
                    Price = 66.41,
                    Config = 2,
                    MaxDischarge = 90,
                    MaxCharge = 10,
                    Name = "Turnigy Graphene 6000mAh 2S2P Hardcase Lipo Pack (ROAR APPROVAL)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__18610__ZIPPY_6000mah_2S2P_35C_Hardcase_Pack.html",
                    Capacity = 6000,
                    Weight = 313,
                    Length = 138,
                    Height = 46,
                    Width = 25,
                    Price = 27.39,
                    Config = 2,
                    MaxDischarge = 35,
                    MaxCharge = 1,
                    Name = "ZIPPY 6000mah 2S2P 35C Hardcase Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__89370__Turnigy_nano_tech_A_SPEC_G2_6000mah_6S_45C_Lipo_Pack.html",
                    Capacity = 6000,
                    Weight = 930,
                    Length = 166,
                    Height = 51,
                    Width = 54,
                    Price = 122.99,
                    Config = 6,
                    MaxDischarge = 45,
                    MaxCharge = 6,
                    Name = "Turnigy nano-tech A-SPEC G2 6000mah 6S 45C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__51839__Turnigy_nano_tech_Ultimate_6000mah_2S3P_90C_Hardcase_Lipo_Saddle_Pack_ROAR_BRCA_Approved_.html",
                    Capacity = 6000,
                    Weight = 324,
                    Length = 70,
                    Height = 25,
                    Width = 47,
                    Price = 54.82,
                    Config = 2,
                    MaxDischarge = 90,
                    MaxCharge = 2,
                    Name = "Turnigy nano-tech Ultimate 6000mah 2S3P 90C Hardcase Lipo Saddle Pack (ROAR & BRCA Approved)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__55804__Multistar_High_Capacity_Lightweight_4S_6000mAh_2C_Multi_Rotor_Lipo_Pack.html",
                    Capacity = 6000,
                    Weight = 364,
                    Length = 132,
                    Height = 44,
                    Width = 28,
                    Price = 24.90,
                    Config = 4,
                    MaxDischarge = 2,
                    MaxCharge = 1,
                    Name = "Multistar High Capacity Lightweight 4S 6000mAh 2C Multi-Rotor Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__63431__ZIPPY_Compact_6200mAh_4s_40c_Lipo_Pack.html",
                    Capacity = 6200,
                    Weight = 589,
                    Length = 158,
                    Height = 46,
                    Width = 41,
                    Price = 59.09,
                    Config = 4,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 6200mAh 4s 40c Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__63430__ZIPPY_Compact_6200mAh_3s_40c_Lipo_Pack.html",
                    Capacity = 6200,
                    Weight = 451,
                    Length = 158,
                    Height = 45,
                    Width = 32,
                    Price = 45.75,
                    Config = 3,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 6200mAh 3s 40c Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__63432__ZIPPY_Compact_6200mAh_6s_40c_Lipo_Pack.html",
                    Capacity = 6200,
                    Weight = 872,
                    Length = 158,
                    Height = 45,
                    Width = 62,
                    Price = 82.99,
                    Config = 6,
                    MaxDischarge = 40,
                    MaxCharge = 5,
                    Name = "ZIPPY Compact 6200mAh 6s 40c Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__51842__Turnigy_nano_tech_Ultimate_6400mah_2S2P_90C_Hardcase_Lipo_Square_Pack.html",
                    Capacity = 6400,
                    Weight = 326,
                    Length = 93,
                    Height = 25,
                    Width = 68,
                    Price = 60.80,
                    Config = 2,
                    MaxDischarge = 90,
                    MaxCharge = 2,
                    Name = "Turnigy nano-tech Ultimate 6400mah 2S2P 90C Hardcase Lipo Square Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__51841__Turnigy_nano_tech_Ultimate_6400mah_1S2P_90C_Hardcase_Pack_ROAR_BRCA_Approved_.html",
                    Capacity = 6400,
                    Weight = 170,
                    Length = 93,
                    Height = 18,
                    Width = 47,
                    Price = 28.55,
                    Config = 1,
                    MaxDischarge = 90,
                    MaxCharge = 2,
                    Name = "Turnigy nano-tech Ultimate 6400mah 1S2P 90C Hardcase Pack (ROAR & BRCA Approved)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__56849__Multistar_High_Capacity_6S_6600mAh_Multi_Rotor_Lipo_Pack.html",
                    Capacity = 6600,
                    Weight = 794,
                    Length = 143,
                    Height = 50,
                    Width = 53,
                    Price = 60.54,
                    Config = 6,
                    MaxDischarge = 10,
                    MaxCharge = 2,
                    Name = "Multistar High Capacity 6S 6600mAh Multi-Rotor Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__51837__Turnigy_nano_tech_Ultimate_6600mah_2S2P_90C_Hardcase_Lipo_Pack_ROAR_BRCA_Approved_.html",
                    Capacity = 6600,
                    Weight = 340,
                    Length = 139,
                    Height = 25,
                    Width = 47,
                    Price = 58.85,
                    Config = 2,
                    MaxDischarge = 90,
                    MaxCharge = 2,
                    Name = "Turnigy nano-tech Ultimate 6600mah 2S2P 90C Hardcase Lipo Pack (ROAR & BRCA Approved)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__20585__Turnigy_nano_tech_6600mah_2S2P_65_130C_Hardcase_Lipo_Pack.html",
                    Capacity = 6600,
                    Weight = 320,
                    Length = 138,
                    Height = 46,
                    Width = 25,
                    Price = 48.90,
                    Config = 2,
                    MaxDischarge = 65,
                    MaxCharge = 10,
                    Name = "Turnigy nano-tech 6600mah 2S2P 65~130C Hardcase Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__89909__Basher_6600mAh_2S2P_40C_Hardcase_LiHV_Pack.html",
                    Capacity = 6600,
                    Weight = 296,
                    Length = 139,
                    Height = 25,
                    Width = 47,
                    Price = 41.99,
                    Config = 2,
                    MaxDischarge = 40,
                    MaxCharge = 2,
                    Name = "Basher 6600mAh 2S2P 40C Hardcase LiHV Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__56848__Multistar_High_Capacity_4S_6600mAh_Multi_Rotor_Lipo_Pack.html",
                    Capacity = 6600,
                    Weight = 537,
                    Length = 142,
                    Height = 49,
                    Width = 35,
                    Price = 42.75,
                    Config = 4,
                    MaxDischarge = 10,
                    MaxCharge = 2,
                    Name = "Multistar High Capacity 4S 6600mAh Multi-Rotor Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__84101__MultiStar_LiHV_High_Capacity_6S_6600mAh_Multi_Rotor_Lipo_Pack.html",
                    Capacity = 6600,
                    Weight = 769,
                    Length = 142,
                    Height = 51,
                    Width = 55,
                    Price = 68.56,
                    Config = 6,
                    MaxDischarge = 10,
                    MaxCharge = 5,
                    Name = "MultiStar LiHV High Capacity 6S 6600mAh Multi-Rotor Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__89610__Turnigy_Graphene_Professional_6600mAh_4S_15C_LiPo_Pack_w_XT60.html",
                    Capacity = 6600,
                    Weight = 605,
                    Length = 144,
                    Height = 51,
                    Width = 41,
                    Price = 60.06,
                    Config = 4,
                    MaxDischarge = 15,
                    MaxCharge = 5,
                    Name = "Turnigy Graphene Professional 6600mAh 4S 15C LiPo Pack w/ XT60"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__38502__Turnigy_7200mAh_4S_14_8V_40C_Hardcase_Pack.html",
                    Capacity = 7200,
                    Weight = 840,
                    Length = 165,
                    Height = 52,
                    Width = 52,
                    Price = 66.89,
                    Config = 4,
                    MaxDischarge = 40,
                    MaxCharge = 2,
                    Name = "Turnigy 7200mAh 4S 14.8V 40C Hardcase Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__91213__Turnigy_Graphene_7500mAh_2S2P_Hardcase_Lipo_Pack_ROAR_APPROVED_.html",
                    Capacity = 7500,
                    Weight = 314,
                    Length = 130,
                    Height = 47,
                    Width = 26,
                    Price = 77.26,
                    Config = 2,
                    MaxDischarge = 90,
                    MaxCharge = 10,
                    Name = "Turnigy Graphene 7500mAh 2S2P Hardcase Lipo Pack (ROAR APPROVED)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__49509__Turnigy_nano_tech_Ultimate_7500mah_2S2P_90C_Hardcase_Lipo_Pack_ROAR_BRCA_Approved_.html",
                    Capacity = 7500,
                    Weight = 350,
                    Length = 138,
                    Height = 25,
                    Width = 47,
                    Price = 65.34,
                    Config = 2,
                    MaxDischarge = 90,
                    MaxCharge = 2,
                    Name = "Turnigy nano-tech Ultimate 7500mah 2S2P 90C Hardcase Lipo Pack (ROAR & BRCA Approved)"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__16225__ZIPPY_Flightmax_8000mAh_3S1P_30C_Lipo_Pack.html",
                    Capacity = 8000,
                    Weight = 644,
                    Length = 169,
                    Height = 69,
                    Width = 27,
                    Price = 44.21,
                    Config = 3,
                    MaxDischarge = 30,
                    MaxCharge = 5,
                    Name = "ZIPPY Flightmax 8000mAh 3S1P 30C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__16226__ZIPPY_Flightmax_8000mAh_4S1P_30C.html",
                    Capacity = 8000,
                    Weight = 845,
                    Length = 166,
                    Height = 69,
                    Width = 35,
                    Price = 63.42,
                    Config = 4,
                    MaxDischarge = 30,
                    MaxCharge = 5,
                    Name = "ZIPPY Flightmax 8000mAh 4S1P 30C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__56842__Multistar_High_Capacity_4S_8000mAh_Multi_Rotor_Lipo_Pack.html",
                    Capacity = 8000,
                    Weight = 643,
                    Length = 142,
                    Height = 49,
                    Width = 43,
                    Price = 43.68,
                    Config = 4,
                    MaxDischarge = 10,
                    MaxCharge = 2,
                    Name = "Multistar High Capacity 4S 8000mAh Multi-Rotor Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__89612__Turnigy_Graphene_Professional_8000mAh_6S_15C_LiPo_Pack_w_XT60.html",
                    Capacity = 8000,
                    Weight = 1110,
                    Length = 170,
                    Height = 69,
                    Width = 48,
                    Price = 79.99,
                    Config = 6,
                    MaxDischarge = 15,
                    MaxCharge = 5,
                    Name = "Turnigy Graphene Professional 8000mAh 6S 15C LiPo Pack w/XT60"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__56843__Multistar_High_Capacity_6S_8000mAh_Multi_Rotor_Lipo_Pack.html",
                    Capacity = 8000,
                    Weight = 956,
                    Length = 142,
                    Height = 49,
                    Width = 63,
                    Price = 77.18,
                    Config = 6,
                    MaxDischarge = 10,
                    MaxCharge = 2,
                    Name = "Multistar High Capacity 6S 8000mAh Multi-Rotor Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__89611__Turnigy_Graphene_Professional_8000mAh_4S_15C_LiPo_Pack_w_XT60.html",
                    Capacity = 8000,
                    Weight = 762,
                    Length = 168,
                    Height = 69,
                    Width = 34,
                    Price = 49.99,
                    Config = 4,
                    MaxDischarge = 15,
                    MaxCharge = 5,
                    Name = "Turnigy Graphene Professional 8000mAh 4S 15C LiPo Pack w/XT60"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__16227__ZIPPY_Flightmax_8000mAh_5S1P_30C.html",
                    Capacity = 8000,
                    Weight = 1054,
                    Length = 170,
                    Height = 69,
                    Width = 44,
                    Price = 73.59,
                    Config = 5,
                    MaxDischarge = 30,
                    MaxCharge = 5,
                    Name = "ZIPPY Flightmax 8000mAh 5S1P 30C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__18210__Turnigy_nano_tech_8000mAh_6S_25_50C_Lipo_Pack.html",
                    Capacity = 8000,
                    Weight = 1105,
                    Length = 195,
                    Height = 50,
                    Width = 55,
                    Price = 116.37,
                    Config = 6,
                    MaxDischarge = 25,
                    MaxCharge = 5,
                    Name = "Turnigy nano-tech 8000mAh 6S 25~50C Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__16224__ZIPPY_Flightmax_8000mAh_2S1P_30C.html",
                    Capacity = 8000,
                    Weight = 415,
                    Length = 166,
                    Height = 69,
                    Width = 15,
                    Price = 32.91,
                    Config = 2,
                    MaxDischarge = 30,
                    MaxCharge = 5,
                    Name = "ZIPPY Flightmax 8000mAh 2S1P 30C"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__84105__MultiStar_LiHV_High_Capacity_6S_10000mAh_Multi_Rotor_Lipo_Pack.html",
                    Capacity = 10000,
                    Weight = 1183,
                    Length = 168,
                    Height = 69,
                    Width = 54,
                    Price = 103.81,
                    Config = 6,
                    MaxDischarge = 10,
                    MaxCharge = 5,
                    Name = "MultiStar LiHV High Capacity 6S 10000mAh Multi-Rotor Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__61692__Turnigy_Power_Bank_10000mAh_w_Dual_USB_Output_2_1A.html",
                    Capacity = 10000,
                    Weight = 0,
                    Length = 0,
                    Height = 0,
                    Width = 0,
                    Price = 14.44,
                    Config = 1,
                    MaxDischarge = 0,
                    MaxCharge = 0,
                    Name = "Turnigy Power Bank 10000mAh w/Dual USB Output 2.1A"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__56844__Multistar_High_Capacity_4S_10000mAh_Multi_Rotor_Lipo_Pack.html",
                    Capacity = 10000,
                    Weight = 804,
                    Length = 160,
                    Height = 65,
                    Width = 36,
                    Price = 58.39,
                    Config = 4,
                    MaxDischarge = 10,
                    MaxCharge = 2,
                    Name = "Multistar High Capacity 4S 10000mAh Multi-Rotor Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__89613__Turnigy_Graphene_Professional_10000mAh_4S_15C_LiPo_Pack_w_5_5mm_Bullet_Connector.html",
                    Capacity = 10000,
                    Weight = 936,
                    Length = 168,
                    Height = 69,
                    Width = 40,
                    Price = 78.85,
                    Config = 4,
                    MaxDischarge = 15,
                    MaxCharge = 5,
                    Name = "Turnigy Graphene Professional 10000mAh 4S 15C LiPo Pack w/5.5mm Bullet Connector"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__89614__Turnigy_Graphene_Professional_10000mAh_6S_15C_LiPo_Pack_w_5_5mm_Bullet_Connector.html",
                    Capacity = 10000,
                    Weight = 1370,
                    Length = 170,
                    Height = 77,
                    Width = 59,
                    Price = 111.06,
                    Config = 6,
                    MaxDischarge = 15,
                    MaxCharge = 5,
                    Name = "Turnigy Graphene Professional 10000mAh 6S 15C LiPo Pack w/5.5mm Bullet Connector"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__56845__Multistar_High_Capacity_6S_10000mAh_Multi_Rotor_Lipo_Pack.html",
                    Capacity = 10000,
                    Weight = 1189,
                    Length = 156,
                    Height = 65,
                    Width = 53,
                    Price = 89.67,
                    Config = 6,
                    MaxDischarge = 10,
                    MaxCharge = 2,
                    Name = "Multistar High Capacity 6S 10000mAh Multi-Rotor Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__89615__Turnigy_Graphene_Professional_12000mAh_6S_15C_LiPo_Pack_w_5_5mm_Bullet_Connector.html",
                    Capacity = 12000,
                    Weight = 1610,
                    Length = 183,
                    Height = 77,
                    Width = 57,
                    Price = 122.17,
                    Config = 6,
                    MaxDischarge = 15,
                    MaxCharge = 5,
                    Name = "Turnigy Graphene Professional 12000mAh 6S 15C LiPo Pack w/5.5mm Bullet Connector"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__74096__MultiStar_High_Capacity_6S_12000mAh_Multi_Rotor_Lipo_Pack.html",
                    Capacity = 12000,
                    Weight = 1525,
                    Length = 180,
                    Height = 70,
                    Width = 55,
                    Price = 103.33,
                    Config = 6,
                    MaxDischarge = 10,
                    MaxCharge = 2,
                    Name = "MultiStar High Capacity 6S 12000mAh Multi-Rotor Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__84107__MultiStar_LiHV_High_Capacity_4S_16000mAh_Multi_Rotor_Lipo_Pack.html",
                    Capacity = 16000,
                    Weight = 1181,
                    Length = 181,
                    Height = 77,
                    Width = 43,
                    Price = 110.72,
                    Config = 4,
                    MaxDischarge = 10,
                    MaxCharge = 5,
                    Name = "MultiStar LiHV High Capacity 4S 16000mAh Multi-Rotor Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__61509__Multistar_High_Capacity_4S_16000mAh_Multi_Rotor_Lipo_Pack.html",
                    Capacity = 16000,
                    Weight = 1290,
                    Length = 173,
                    Height = 74,
                    Width = 45,
                    Price = 79.64,
                    Config = 4,
                    MaxDischarge = 10,
                    MaxCharge = 5,
                    Name = "Multistar High Capacity 4S 16000mAh Multi-Rotor Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__89616__Turnigy_Graphene_Professional_16000mAh_6S_15C_LiPo_Pack_w_5_5mm_Bullet_Connector.html",
                    Capacity = 16000,
                    Weight = 2082,
                    Length = 183,
                    Height = 77,
                    Width = 72,
                    Price = 180.53,
                    Config = 6,
                    MaxDischarge = 15,
                    MaxCharge = 5,
                    Name = "Turnigy Graphene Professional 16000mAh 6S 15C LiPo Pack w/5.5mm Bullet Connector"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__61510__Multistar_High_Capacity_6S_16000mAh_Multi_Rotor_Lipo_Pack.html",
                    Capacity = 16000,
                    Weight = 1920,
                    Length = 173,
                    Height = 74,
                    Width = 68,
                    Price = 119.86,
                    Config = 6,
                    MaxDischarge = 10,
                    MaxCharge = 2,
                    Name = "Multistar High Capacity 6S 16000mAh Multi-Rotor Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__80907__Multistar_High_Capacity_6S_20000mAh_Multi_Rotor_Lipo_Pack.html",
                    Capacity = 20000,
                    Weight = 2405,
                    Length = 200,
                    Height = 90,
                    Width = 60,
                    Price = 145.92,
                    Config = 6,
                    MaxDischarge = 10,
                    MaxCharge = 2,
                    Name = "Multistar High Capacity 6S 20000mAh Multi-Rotor Lipo Pack"
                },
                new Battery()
                {
                    Url = "http://www.hobbyking.com/hobbyking/store/__80900__Multistar_High_Capacity_4S_20000mAh_Multi_Rotor_Lipo_Pack.html",
                    Capacity = 20000,
                    Weight = 1610,
                    Length = 200,
                    Height = 90,
                    Width = 40,
                    Price = 130.23,
                    Config = 4,
                    MaxDischarge = 10,
                    MaxCharge = 2,
                    Name = "Multistar High Capacity 4S 20000mAh Multi-Rotor Lipo Pack"
                });
        }

    }
}
