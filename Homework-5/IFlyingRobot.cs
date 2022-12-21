using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_5
{
    internal interface IFlyingRobot : IRobot
    {
        new string GetRobotType()
        { 
            return "I am a flying robot.";
        }
    }
}
