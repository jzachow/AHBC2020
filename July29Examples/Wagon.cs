using System;
using System.Collections.Generic;
using System.Text;

namespace July29Examples
{
    public class Wagon : Automobile
    {
        public override string Make { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        protected override string Model { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Build()
        {
            throw new NotImplementedException();
        }
    }
}
