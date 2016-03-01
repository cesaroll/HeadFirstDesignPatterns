using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH04_Command
{
    class RemoteControlTest
    {
        static void Main(string[] args)
        {
            /*
            SimpleRemoteControl remote = new SimpleRemoteControl();

            LightOnCommand lightOn = new LightOnCommand(new Light());
            GarageDoorOpenCommand garageDoor = new GarageDoorOpenCommand(new GarageDoor());

            remote.Slot = lightOn;
            remote.ButtonWasPressed();
            remote.Slot = garageDoor;
            remote.ButtonWasPressed();
            */

            RemoteControl remote = new RemoteControl();

            Light livingRoomLight = new Light("Living Room");
            LightOnCommand lightOnCommandLR = new LightOnCommand(livingRoomLight);
            LightOffCommand lightOffCommandLR = new LightOffCommand(livingRoomLight);
            remote.SetCommand(0, lightOnCommandLR, lightOffCommandLR);

            Light kitchenLight = new Light("Kitchen");
            LightOnCommand lightOnCommandK = new LightOnCommand(kitchenLight);
            LightOffCommand lightOffCommandK = new LightOffCommand(kitchenLight);
            remote.SetCommand(1, lightOnCommandK, lightOffCommandK);

            GarageDoor garageDoor = new GarageDoor();
            remote.SetCommand(2, new GarageDoorOpenCommand(garageDoor), new GarageDoorCloseCommand(garageDoor));

            Stereo stereo = new Stereo();
            StereoOnWithCDCommand stereoOnWithCDCommand = new StereoOnWithCDCommand(stereo);
            StereoOffCommand stereoOffCommand = new StereoOffCommand(stereo);
            remote.SetCommand(3, stereoOnWithCDCommand, stereoOffCommand);

            CeilingFan ceilingFan = new CeilingFan("Living Room");
            CeilingFanHighCommand ceilingFanHighCommand = new CeilingFanHighCommand(ceilingFan);
            CeilingFanOffCommand ceilingFanOffCommand = new CeilingFanOffCommand(ceilingFan);
            remote.SetCommand(4, ceilingFanHighCommand, ceilingFanOffCommand);

            Console.WriteLine(remote);


            //Test Cycle
            for (int i = 0; i < 5; i++)
            {
                remote.OnButtonWasPushed(i);
                remote.OffButtonWasPushed(i);

                if (i == 1)
                {
                    Console.WriteLine(remote);

                    remote.UndoButtonWasPushed();
                }

            }

            remote.UndoButtonWasPushed();

            /* Party Mode  */

            remote.SetCommand(5, new MacroCommand(lightOnCommandLR, lightOnCommandK, stereoOnWithCDCommand, ceilingFanHighCommand), 
                                new MacroCommand(lightOffCommandLR, lightOffCommandK, stereoOffCommand, ceilingFanOffCommand) );

            Console.WriteLine(remote);

            Console.WriteLine("\n\n *************  PARTY MODE ON  ****************\n\n");

            remote.OnButtonWasPushed(5);

            Console.WriteLine("\n\n *************  PARTY MODE OFF  ****************\n\n");

            remote.OffButtonWasPushed(5);

            Console.WriteLine("\n\n *************  Undo Button  ****************\n\n");

            remote.UndoButtonWasPushed();


        }
    }
}
