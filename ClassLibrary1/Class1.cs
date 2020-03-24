using System;

namespace ClassLibrary1
{
    public class Class1
    {
        public Class1() { }

        // A handful refactorings and codefixes to verify

        // Check `add null checks` lightbulb
        public void AddNullChecks(string a, string b, string c)
        {

        }

        // Check `Convert a switch statement to a switch expression`
        public void SwitchExpression()
        {
            int line = 1;
            int foo;

            switch (line)
            {
                case 0: foo = 5; break;
                case 1: foo = 4; break;
                default: foo = 0; break;

            }
            Console.WriteLine(foo);
        }

        // Check `Generate a parameter`
        public void GenerateParameter()
        {
            //x = 53;
        }

        // Go To Base command
        // You can now use the Go To Base command to navigate up the inheritance chain.
        // Go To Base command is available on the context (right-click) menu of the element
        // you want to navigate the inheritance hierarchy or 
        // type the keyboard shortcut (Alt + Home)
        // Place your cursor on class D and press (Alt + Home)
        // If there is more than one result a tool window will open with all of the results
        internal interface I
        {
        }

        // Check `go to base` command and inherit doc
        class C : I
        {
            // Methods that have no XML documentation can now automatically inherit 
            // XML documentation from the method it is overriding
            // Place your cursor over the undocumented method that implements a documented interface method
            // Quick Info will then display the XML documentation from the interface method
            /// <summary>
            /// This method does something
            /// </summary>
            public virtual void Method()
            {

            }

            class D : C, I
            {
                public override void Method() // Hover over `Method` to view inherited quick info
                {
                }
            }
        }
    }
}
