using System;
using System.Collections.ObjectModel;
using App1.Models;

using Xamarin.Forms;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace App1.ViewModels
{
    public class HomeViewModel : ContentPage, INotifyPropertyChanged
    {
        private NotificationModel _notificationModel = new NotificationModel();
        private ObservableCollection<NotificationModel> _notifications = new ObservableCollection<NotificationModel>();
        public ObservableCollection<NotificationModel> Notifications
        {
            get { return _notifications; }
            set
            {
                if (_notifications != value)
                {
                    _notifications = value;
                }
            }
        }


        private string notifs = "[{\"title\":\"Notification 1\",\"content\":\"Lorem Ipsum\",\"publishedAt\":\"" + DateTime.Now.ToUniversalTime().ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff'Z'") + "\",\"isRead\":false},{\"title\":\"Notification 2\",\"content\":\"Lorem Ipsum\",\"publishedAt\":\"" + DateTime.Now.ToUniversalTime().ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff'Z'") + "\",\"isRead\":false},{\"title\":\"Notification 3\",\"content\":\"Lorem Ipsum\",\"publishedAt\":\"" + DateTime.Now.ToUniversalTime().ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff'Z'") + "\",\"isRead\":false}]";




        public HomeViewModel()
        {
            _notifications = _notificationModel.fromJson(notifs);
        }
    }
}