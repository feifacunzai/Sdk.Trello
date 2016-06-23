using System.Collections.Generic;

namespace Sdk.Trello.ViewModels.Entitys
{
    public class BoardEntity
    {
        public string name { get; set; }

        public string desc { get; set; }

        public string descData { get; set; }

        public bool closed { get; set; }

        public string idOrganization { get; set; }

        public string pinned { get; set; }

        public string invitations { get; set; }

        public string shortLink { get; set; }

        public List<string> powerUps { get; set; }

        public string dateLastActivity { get; set; }

        public List<string> idTags { get; set; }

        public string id { get; set; }

        public bool invited { get; set; }

        public bool starred { get; set; }

        public string url { get; set; }

        public PrefEntity prefs { get; set; }

        public List<MembershipEntity> memberships { get; set; }

        public bool subscribed { get; set; }

        public LabelnameEntity labelNames { get; set; }

        public string dateLastView { get; set; }

        public string shortUrl { get; set; }
    }
}
