using Newtonsoft.Json;
using RestSharp;
using Sdk.Trello.ViewModels.Entitys;
using System.Collections.Generic;

namespace Sdk.Trello
{
    public class CardService : BaseService
    {
        public CardService(string key, string token) 
            : base(key, token)
        {
        }

        /// <summary>
        /// Get the contents of a Card
        /// GET /1/cards/[card id or shortlink]
        /// </summary>
        /// <param name="cardId"></param>
        /// <returns></returns>
        public CardEntity Get(string cardId)
        {
            var client = new RestClient(
                string.Format("{0}1/cards/{1}?key={2}&token={3}",
                Config.ApiUri,
                cardId,
                Config.Key,
                Config.Token));
            var request = new RestRequest(Method.GET);
            return ApiResponse(client.Execute<CardEntity>(request));
        }

        /// <summary>
        /// Create a new Card
        /// POST /1/cards
        /// </summary>
        /// <param name="idList"></param>
        /// <param name="card"></param>
        /// <returns></returns>
        public CardEntity Create(CreateCardEntity card)
        {
            var client = new RestClient(
                string.Format("{0}1/cards?key={1}&token={2}",
                Config.ApiUri,
                Config.Key,
                Config.Token));
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json", JsonConvert.SerializeObject(card), ParameterType.RequestBody);
            return ApiResponse(client.Execute<CardEntity>(request));
        }

        /// <summary>
        /// Update the contents of a Card
        /// PUT /1/cards/[card id or shortlink]
        /// </summary>
        /// <param name="cardId"></param>
        /// <returns></returns>
        public CardEntity Update(string cardId, UpdateCardEntity card)
        {
            var client = new RestClient(
                string.Format("{0}1/cards/{1}?key={2}&token={3}",
                Config.ApiUri,
                cardId,
                Config.Key,
                Config.Token));
            var request = new RestRequest(Method.PUT);
            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json", JsonConvert.SerializeObject(card), ParameterType.RequestBody);
            return ApiResponse(client.Execute<CardEntity>(request));
        }

        /// <summary>
        /// Add a comment to a Card
        /// POST /1/cards/[card id or shortlink]/actions/comments
        /// </summary>
        /// <param name="cardId"></param>
        /// <param name="comment"></param>
        /// <returns></returns>
        public CardEntity Comments(string cardId, CommentEntity comment)
        {
            var client = new RestClient(
                string.Format("{0}1/cards/{1}/actions/comments?key={2}&token={3}",
                Config.ApiUri,
                cardId,
                Config.Key,
                Config.Token));
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json", JsonConvert.SerializeObject(comment), ParameterType.RequestBody);
            return ApiResponse(client.Execute<CardEntity>(request));
        }

        /// <summary>
        /// Add a member to a Card
        /// POST /1/cards/[card id or shortlink]/idMembers
        /// </summary>
        /// <param name="cardId"></param>
        /// <param name="idMember"></param>
        /// <returns></returns>
        public CardEntity IdMembers(string cardId, IdMemberEntity idMember)
        {
            var client = new RestClient(
                string.Format("{0}1/cards/{1}/idMembers?key={2}&token={3}",
                Config.ApiUri,
                cardId,
                Config.Key,
                Config.Token));
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json", JsonConvert.SerializeObject(idMember), ParameterType.RequestBody);
            return ApiResponse(client.Execute<CardEntity>(request));
        }

        /// <summary>
        /// Add a Label to a Card
        /// POST /1/cards/[card id or shortlink]/idLabels
        /// </summary>
        /// <param name="cardId"></param>
        /// <param name="idMember"></param>
        /// <returns></returns>
        public CardEntity IdLabels(string cardId, AddLabelEntity addLabelEntity)
        {
            var client = new RestClient(
                string.Format("{0}1/cards/{1}/idLabels?key={2}&token={3}",
                Config.ApiUri,
                cardId,
                Config.Key,
                Config.Token));
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json", JsonConvert.SerializeObject(addLabelEntity), ParameterType.RequestBody);
            return ApiResponse(client.Execute<CardEntity>(request));
        }

        /// <summary>
        /// Delete a Label to a Card
        /// DELETE /1/cards/[card id or shortlink]/idLabels
        /// </summary>
        /// <param name="cardId"></param>
        /// <param name="idMember"></param>
        /// <returns></returns>
        public CardEntity DeleteLabel(string cardId, string idLabel)
        {
            var client = new RestClient(
                string.Format("{0}1/cards/{1}/idLabels/{4}?key={2}&token={3}",
                Config.ApiUri,
                cardId,
                Config.Key,
                Config.Token,
                idLabel));
            var request = new RestRequest(Method.DELETE);
            return ApiResponse(client.Execute<CardEntity>(request));
        }
    }
}
