using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading1
{
    class Que
    {
        private const int count = 10;
        private Form1 form;

        public bool isBusy = false;
        public List<string> List;
        public delegate void SetValue(string value, int count);
        public delegate void AddToLogs(string value);

        public Que(Form1 _form)
        {
            List = new List<string>();
            form = _form;
        }

        public bool isReady()
        {
            return (!isBusy && (List.Count < 10));
        }

        public void Add(string value)
        {
            if(List.Count < 10)
            {
                isBusy = true;
                SetValue set = form.LoadValue;
                List.Add(value);
                form.BeginInvoke(set, new object[] { value, List.Count });
                AddToLogs log = form.AddToLogs;
                form.BeginInvoke(log, new object[] { "QUE: " + DateTime.Now.ToLongTimeString() + 
                    "Add to list value: " + value });
                isBusy = false;
            }
        }
    }
}
