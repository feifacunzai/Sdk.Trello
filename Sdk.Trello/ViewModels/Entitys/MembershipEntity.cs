namespace Sdk.Trello.ViewModels.Entitys
{
    public class MembershipEntity
    {
        public string id { get; set; }

        public string idMember { get; set; }

        public string memberType { get; set; }

        public bool unconfirmed { get; set; }

        public bool deactivated { get; set; }

        public string orgMemberType { get; set; }
    }
}