using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.Mvvm.POCO;

namespace MethodToCommandExample.Common {
    public class User {
        protected User(string name, int iD) {
            Name = name;
            ID = iD;
        }
        public static User Create(int id, string name) {
            return ViewModelSource.Create(()=> new User(name, id));
        }

        public string Name { get; set; }
        public int ID { get; set; }
    }
}
