using System;
using System.Collections.Generic;

namespace CustomListViewDemo
{
    public class Messenger
    {
        public string FromUser { get; set; }
        public string ToUser { get; set; }
        public string Message { get; set; }
        public DateTime DateSent { get; set; }
        public string ImageUrl { get; set; }
        public string Status { get; set; }

        public List<Messenger> GetMessages()
        {
            List<Messenger> messages = new List<Messenger>
            {
                new Messenger {FromUser = "Devlin", ToUser = "Ruby", Message = "Hey Ruby", ImageUrl = "http://lorempixel.com/120/120/people/3/", DateSent = DateTime.Now, Status = "Received"},
                new Messenger {FromUser = "Ruby", ToUser = "Devlin", Message = "Hello Dev", ImageUrl = "http://lorempixel.com/120/120/people/1/", DateSent = DateTime.Now, Status = "Sent"},
                new Messenger {FromUser = "Devlin", ToUser = "Ruby", Message = "How are you?", ImageUrl = "http://lorempixel.com/120/120/people/3/", DateSent = DateTime.Now, Status = "Received"},
                new Messenger {FromUser = "Ruby", ToUser = "Devlin", Message = "Not much. Where are you?", ImageUrl = "http://lorempixel.com/120/120/people/1/", DateSent = DateTime.Now, Status = "Sent"},
                new Messenger {FromUser = "Devlin", ToUser = "Ruby", Message = "Here in Reykjavík. Iceland.", ImageUrl = "http://lorempixel.com/120/120/people/3/", DateSent = DateTime.Now, Status = "Received"},
            };

            return messages;
        }
    }
}