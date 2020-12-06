using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTestGit
{
    /// <summary>
    /// Класс описывающий пользователя.
    /// </summary>
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
