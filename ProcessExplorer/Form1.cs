using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessExplorer
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void Main_Form_Shown(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcesses();
            foreach (Process pr in processes)
            {
                long _hndl = -1;
                long _winhndl = -1;
                try
                {
                    _hndl = pr.Handle.ToInt64();
                }
                catch
                { }
                try
                {
                    _winhndl = pr.MainWindowHandle.ToInt64();
                }
                catch
                { }
                int _id = pr.Id;
                String _ppc = "(8) Normal";
                try
                {
                    _ppc = "("+ pr.BasePriority.ToString() + ") " + pr.PriorityClass.ToString();
                }
                catch
                { }
                int _threadsCnt = pr.Threads.Count;

                string _filename = "";
                try
                {
                    _filename = pr.VirtualMemorySize64.ToString() ;
                }
                catch
                { }


                Main_DGV.Rows.Add(_id,_hndl,_winhndl,pr.ProcessName, _filename,_ppc.ToString(), _threadsCnt);
            }
        }
    }
}
