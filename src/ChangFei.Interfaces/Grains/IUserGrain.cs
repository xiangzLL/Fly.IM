﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChangFei.Interfaces.Grains
{
    /// <summary>
    /// User Grain
    /// </summary>
    public interface IUserGrain:IMessageSender, IMessageSubscriber,IGroupMessageSender,IGroupMessageSubscriber
    {
        Task LoginAsync(IMessageViewer viewer);

        Task LogoutAsync();

        /// <summary>
        /// User subscribe group message
        /// </summary>
        /// <param name="groupIds">Group id list</param>
        /// <returns></returns>
        Task SubscribeAsync(List<string> groupIds);

        /// <summary>
        /// User unsubscribe group message
        /// </summary>
        /// <param name="groupIds">Group id list</param>
        /// <returns></returns>
        Task UnsubscribeAsync(List<string> groupIds);
    }
}
