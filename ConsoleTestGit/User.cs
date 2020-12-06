using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTestGit
{
    class User
    {
        private string name;

        public string Name
        {
            get
            {
                if (name == String.Empty)
                    return "Иннокентий";
                else return name;
            }
            set
            {
                if (value == "Джон")
                    name = "Джон Локк";
                else name = value;
            }
        }
    }
}
