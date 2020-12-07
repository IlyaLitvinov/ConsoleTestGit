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
        public delegate void AccountHandler(string message);
        static public event AccountHandler Notify;              // 1.Определение события

        private string name;

        private static int counter = 0;
        
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

        public User()
        {
            counter+=1;
            Notify($"Ну охренеть теперь! Создан пользователь №:{counter}");
        }
    }
}
