﻿using Telegram.Bot.Types;

// ReSharper disable once CheckNamespace
namespace Telegram.Bot.Requests
{
    /// <summary>
    /// Use this request to approve a chat join request. The bot must be an administrator in the chat for this to
    /// work and must have the <see cref="ChatPermissions.CanInviteUsers"/> administrator right.
    /// Returns <c>true</c> on success.
    /// </summary>
    public class ApproveChatJoinRequest : RequestBase<bool>
    {
        /// <summary>
        /// Unique identifier for the target chat or username of the target channel (in the format @channelusername)
        /// </summary>
        public ChatId ChatId { get; }

        /// <summary>
        /// Unique identifier of the target user
        /// </summary>
        public long UserId { get; }

        /// <summary>
        /// Initializes a new request with chatId and userId
        /// </summary>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel
        /// (in the format <c>@channelusername</c>)
        /// </param>
        /// <param name="userId">Unique identifier of the target user</param>
        public ApproveChatJoinRequest(ChatId chatId, long userId)
            : base("approveChatJoinRequest")
        {
            ChatId = chatId;
            UserId = userId;
        }
    }
}
