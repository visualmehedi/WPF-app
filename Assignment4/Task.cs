using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Task
    {
        String des = "not defined";
        String dateTime = "not defined";
        String priority = "not defined";
        DateTime curDateTime = DateTime.Now;

        /// <summary>
        /// intialize constructor
        /// </summary>
        /// <param name="dt"></param>
        public Task(DateTime dt)
        {
            curDateTime = dt;
        }

        /// <summary>
        /// initialize vaiable by using set and get method
        /// </summary>
        /// <param name="des"></param>
        public void setDes(String des)
        {
            this.des = des;
        }

        public String getDes()
        {
            return des;
        }
        
        public void setTime(String dateTime)
        {
            this.dateTime = dateTime;
        }

        public String getTime()
        {
            return dateTime;
        }

        /// <summary>
        /// initialize vaiable by using set and get method
        /// </summary>
        /// <param name="priority"></param>
        public void setPriority(String priority)
        {
            this.priority = priority_format(priority);
        }

        public String getPriority()
        {
            return priority;
        }

        private String priority_format(String value)
        {
            return value.Replace("_"," ");
        }
    }
}