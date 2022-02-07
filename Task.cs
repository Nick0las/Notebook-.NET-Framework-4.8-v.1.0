using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook_.NET_Framework_v._1._0
{
    internal class Task
    {
        public EnumTask typeTask;
        public string headerTask;
        public string textTask;
        public string dateTask;
        public string timeTask;

        public string TypeTask
        {
            get { return typeTask.ToString(); }
        }

        public string HeadTask
        {
            get { return headerTask; }
            set { headerTask = value; }
        }

        public string TextTask
        {
            get { return textTask; }
            set { textTask = value; }
        }

        public string DateTask
        {
            get { return dateTask; }
            set { dateTask = value; }
        }

        public string TimeTask
        {
            get { return timeTask; }
            set { timeTask = value; }
        }

        public Task(EnumTask _typeTask, string _headTask, string _textTask, string _dateTask, string _timeTask)
        {
            this.typeTask = _typeTask;
            HeadTask = _headTask;
            TextTask = _textTask;
            DateTask = _dateTask;
            TimeTask = _timeTask;
        }

    }
}
