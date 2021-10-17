using System;

namespace Abstract_Method
{
    abstract class Class1
    {
        public abstract void Show(); //abstract forces child to override
    }
    class Claass2 : Class1
    {
        public override void Show()
        {
            //Implementing Show() Method
        }
    }
}
