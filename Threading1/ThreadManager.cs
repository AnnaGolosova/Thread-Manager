using StringLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading1
{
    class ThreadManager
    {
        private Que que;
        private Form1 form;

        public bool isBusy
        {
            set
            {
                que.isBusy = value;
            }
        }

        public int Count
        {
            get
            {
                return que.List.Count;
            }
        }

        public ThreadManager(Form1 _form)
        {
            form = _form;
            que = new Que(form);
        }

        public void FirstProcess()
        {
            while(true)
            {
                if(que.isReady())
                {
                    string result = StringManager.Add("s1", "s2");
                    que.Add(result);
                }
                System.Threading.Thread.Sleep(500);
            }
        }

        public void SecondProcess()
        {
            while (true)
            {
                if(que.isReady())
                {
                    string result = StringManager.Replace("ssss33ss3", "s3", "!");
                    que.Add(result);
                }
                System.Threading.Thread.Sleep(500);
            }
        }

        public delegate void ShowNextValue();
        public delegate void SetValue(string value);

        public void ShowResult()
        {
            while(true)
            {
                if (que.List.Count != 0)
                {
                    isBusy = true;
                    ShowNextValue show = form.ShowNextResult;
                    form.BeginInvoke(show);
                    que.List.RemoveAt(0);
                    isBusy = false;
                    SetValue log = form.AddToLogs;
                    form.BeginInvoke(log, new object[] { "QUE: " + DateTime.Now.ToShortTimeString() + " delete value" });

                    System.Threading.Thread.Sleep(1000);
                }
            }
        }

        public bool isReady()
        {
            return que.isReady();
        }
    }
}
