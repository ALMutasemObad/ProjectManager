using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using ProjectManager.Module.BusinessObjects;

namespace ProjectManager.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class TasksCompletedController : ViewController
    {
        SimpleAction Complete;
        public TasksCompletedController()
        {
            InitializeComponent();
            TargetObjectType = typeof(ProjectTask);
            Complete = new SimpleAction(this, "Complete ", PredefinedCategory.Edit);
            Complete.SelectionDependencyType = SelectionDependencyType.RequireMultipleObjects;
            Complete.Execute += Complete_Execute;
            // Target required Views (via the TargetXXX properties) and create their Actions.
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }

        void Complete_Execute(object sender , SimpleActionExecuteEventArgs e)
        {
            var currentObj = e.CurrentObject as ProjectTask;
            if (currentObj !=null)
            {
                currentObj.Status = Status.Completed;
            }
            if (this.ObjectSpace.IsModified)
                this.ObjectSpace.CommitChanges();

        }
        
    }
}
