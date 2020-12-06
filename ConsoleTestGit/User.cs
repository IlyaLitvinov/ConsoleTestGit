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
                return name?? "Иннокентий";
            }
            set
            {
                if (value == "Джон")
                    name = "Джон Локк";
            }
        }
    }
}
