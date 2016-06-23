using System.Collections.Generic;

namespace Sdk.Trello.ViewModels.Entitys
{
    public class CardEntity
    {
        public string id { get; set; }

        public string checkItemStates { get; set; }

        public bool closed { get; set; }

        public string dateLastActivity { get; set; }

        public string desc { get; set; }

        public string descData { get; set; }

        public string idBoard { get; set; }

        public string idList { get; set; }

        public List<string> idMembersVoted { get; set; }

        public int idShort { get; set; }

        public string idAttachmentCover { get; set; }

        public bool manualCoverAttachment { get; set; }

        public List<string> idLabels { get; set; }

        public string name { get; set; }

        public float pos { get; set; }

        public string shortLink { get; set; }

        public BadgeEntity badges { get; set; }

        public string due { get; set; }

        public List<string> idChecklists { get; set; }

        public List<string> idMembers { get; set; }

        public List<string> labels { get; set; }

        public string shortUrl { get; set; }

        public bool subscribed { get; set; }

        public string url { get; set; }
    }
}
