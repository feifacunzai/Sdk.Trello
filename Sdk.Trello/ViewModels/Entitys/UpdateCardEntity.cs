using System.Collections.Generic;

namespace Sdk.Trello.ViewModels.Entitys
{
    public class UpdateCardEntity
    {
        public string name { get; set; }

        public string desc { get; set; }

        public bool closed { get; set; }

        public List<string> idMembers { get; set; }

        public string idAttachmentCover { get; set; }

        public string idList { get; set; }

        public string idBoard { get; set; }

        public float pos { get; set; }

        public string due { get; set; }

        public bool subscribed { get; set; }
    }
}
