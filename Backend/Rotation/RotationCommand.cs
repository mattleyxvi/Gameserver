using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Rotation
{
    public class RotationCommand : ICommand
    {
        private readonly IRotation _angle;
        public RotationCommand(IRotation angle) => _angle = angle;
        public void Execute() { _angle.angle += _angle.angspeed; }
    }
}
