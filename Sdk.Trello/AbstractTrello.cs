namespace Sdk.Trello
{
    public abstract class AbstractTrello
    {
        public string Key { get; set; }

        public string Token { get; set; }

        public string BoardId { get; set; }

        public AbstractTrello(string key, string token, string boardId)
        {
            Key = key;
            Token = token;
            BoardId = boardId;
        }
    }
}
