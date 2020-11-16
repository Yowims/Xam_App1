using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace App1.Models
{
    public class NotificationModel
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PublishedAt { get; set; }
        public bool IsRead { get; set; }

        public ObservableCollection<NotificationModel> fromJson(string json)
        {
            ObservableCollection<NotificationModel> test = JsonConvert.DeserializeObject<ObservableCollection<NotificationModel>>(json);
            return test;
        }

    }
}
