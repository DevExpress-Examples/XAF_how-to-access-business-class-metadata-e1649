using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;

namespace UsesTypesInfo.Module.Win {
    public partial class DemoViewController : ViewController {
        public DemoViewController() {
            InitializeComponent();
            RegisterActions(components);
        }

        private void DemoViewController_Activated(object sender, EventArgs e) {
            if (View.ObjectTypeInfo.FindAttribute<MyCustomAttribute>() != null) {
                // if the business class represented by currently active View has
                // the custom attribute applied, perform some actions
                //...
                System.Windows.Forms.MessageBox.Show("The custom attribute is applied");
            }
            else {
                System.Windows.Forms.MessageBox.Show("The custom attribute isn't applied");
            }
        }
    }
}
