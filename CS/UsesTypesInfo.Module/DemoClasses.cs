using System;
using System.ComponentModel;

using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace UsesTypesInfo.Module {

    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class MyCustomAttribute : Attribute { }

    [MyCustomAttribute]
    [DefaultClassOptions]
    public class DemoContact : BaseObject {
        public DemoContact(Session session) : base(session) { }
        public string Email {
            get { return GetPropertyValue<string>("Email"); }
            set { SetPropertyValue<string>("Email", value); }
        }
    }

    [DefaultClassOptions]
    public class DemoPerson : BaseObject {
        public DemoPerson(Session session) : base(session) { }
        public string Name {
            get { return GetPropertyValue<string>("Name"); }
            set { SetPropertyValue<string>("Name", value); }
        }
    }

}
