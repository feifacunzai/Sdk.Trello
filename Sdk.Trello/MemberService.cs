using RestSharp;
using Sdk.Trello.ViewModels.Entitys;
using System.Collections.Generic;

namespace Sdk.Trello
{
    public class MemberService : BaseService
    {
        public MemberService(string key, string token) 
            : base(key, token)
        {
        }

        /// <summary>
        /// Get an array of the Boards of a user
        /// GET /1/members/me/boards
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public List<BoardEntity> Boards(string username)
        {
            var client = new RestClient(
                string.Format("{0}1/members/{1}/boards?key={2}&token={3}",
                Config.ApiUri,
                username,
                Config.Key,
                Config.Token));
            var request = new RestRequest(Method.GET);
            return ApiResponse(client.Execute<List<BoardEntity>>(request));
        }
    }
}
