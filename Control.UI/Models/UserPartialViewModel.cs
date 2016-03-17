using Control.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Control.UI.Models
{
    public class UserPartialViewModel
    {
        public User LoggedUser { get; set; }

        public bool IsLogged { get; set; }

        List<UserAlert> Alerts { get; set; }
        List<UserMessage> Messages { get; set; }
        List<UserTask> Tasks { get; set; }

        public int CountAlerts { get { return Alerts.Count; } }
        public int CountMessages { get { return Alerts.Count; } }
        public int CountTasks { get { return Alerts.Count; } }

        public UserPartialViewModel()
        {
            IsLogged = false;
            Alerts = new List<UserAlert>();
            Messages = new List<UserMessage>();
            Tasks = new List<UserTask>();
        }
    }

    public class UserAlert
    {
        public string Alert { get; set; }
        public string Link { get; set; }
    }

    public class UserMessage
    {
        public string Message { get; set; }
        public string Link { get; set; }
    }

    public class UserTask
    {
        public string Task { get; set; }
        public string Link { get; set; }
    }
}