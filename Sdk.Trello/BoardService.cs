using RestSharp;
using Sdk.Trello.ViewModels;
using Sdk.Trello.ViewModels.Entitys;
using System.Collections.Generic;

namespace Sdk.Trello
{
    public class BoardService : BaseService
    {
        public BoardService(string key, string token) 
            : base(key, token)
        {
        }

        /// <summary>
        /// Get an array of Cards on a board
        /// GET /1/boards/[board_id]/cards
        /// </summary>
        /// <param name="boardId"></param>
        /// <returns></returns>
        public List<CardEntity> Cards(string boardId)
        {
            var client = new RestClient(
                string.Format("{0}1/boards/{1}/cards?key={2}&token={3}",
                Config.ApiUri,
                boardId,
                Config.Key,
                Config.Token));
            var request = new RestRequest(Method.GET);
            return ApiResponse(client.Execute<List<CardEntity>>(request));
        }

        /// <summary>
        /// Get an array of Lists on a board
        /// GET /1/boards/[board_id]/lists
        /// </summary>
        /// <param name="boardId"></param>
        /// <returns></returns>
        public List<ListsModel> Lists(string boardId)
        {
            var client = new RestClient(
                string.Format("{0}1/boards/{1}/lists?cards=open&card_fields=name&fields=name&key={2}&token={3}",
                Config.ApiUri,
                boardId,
                Config.Key,
                Config.Token));
            var request = new RestRequest(Method.GET);
            return ApiResponse(client.Execute<List<ListsModel>>(request));
        }
    }
}
