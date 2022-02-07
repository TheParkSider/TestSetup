using System.Windows.Forms;
using System.ComponentModel;
using System.Collections;

namespace CustomAction1
{
    [RunInstaller(true)]
    public class CustomAction1 : System.Configuration.Install.Installer
    {
        public override void Install(IDictionary stateSaver)
        {
            base.Install(stateSaver);
            MessageBox.Show(GetType().Name + ": Install");
        }

        public override void Commit(IDictionary savedState)
        {
            base.Commit(savedState);
            MessageBox.Show(GetType().Name + ": Commit");
        }

        public override void Rollback(IDictionary savedState)
        {
            base.Rollback(savedState);
            MessageBox.Show(GetType().Name + ": Rollback");
        }

        public override void Uninstall(IDictionary savedState)
        {
            base.Uninstall(savedState);
            MessageBox.Show(GetType().Name + ": Uninstall");
        }

        protected override void OnBeforeInstall(IDictionary savedState)
        {
            base.OnBeforeInstall(savedState);
            MessageBox.Show(GetType().Name + ": OnBefore");
            throw new System.Configuration.Install.InstallException("Errorだあああああ");

        }
    }
}
