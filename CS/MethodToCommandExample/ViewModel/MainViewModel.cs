using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using MethodToCommandExample.Common;

namespace MethodToCommandExample.ViewModel {
    public class MainViewModel {
        public MainViewModel() {
            Users = new ObservableCollection<User>() {
                User.Create(0, "Jack"),
                User.Create(1, "Ron"),
                User.Create(2, "John"),
                User.Create(3, "Antoni"),
                User.Create(4, "Paul"),
            };
        }

        public static MainViewModel Create() {
            return ViewModelSource.Create(() => new MainViewModel());
        }

        public virtual ObservableCollection<User> Users { get; set; }
    }
}
