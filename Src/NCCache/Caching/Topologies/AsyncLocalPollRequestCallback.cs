﻿// Copyright (c) 2018 Alachisoft
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//    http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Alachisoft.NCache.Common.Threading;
using EventType = Alachisoft.NCache.Runtime.Events.EventType;

namespace Alachisoft.NCache.Caching.Topologies
{
    /// <summary>
    ///Asynchronous notification dispatcher. 
    /// </summary>
    internal class AsyncLocalPollRequestCallback : AsyncProcessor.IAsyncTask
    {
        /// <summary> The listener class </summary>
        private ICacheEventsListener _listener;

        /// <summary> Message to broadcast </summary>
        private string _clientId;

        private short _callbackId;
        private EventType _eventType;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="listener"></param>
        /// <param name="data"></param>
        public AsyncLocalPollRequestCallback(ICacheEventsListener listener, string clientId, short callbackId, EventType eventType)
        {
            _listener = listener;
            _clientId = clientId;
            _callbackId = callbackId;
            _eventType = eventType;
        }

        /// <summary>
        /// Implementation of message sending.
        /// </summary>
        void AsyncProcessor.IAsyncTask.Process()
        {
            _listener.OnPollNotify(_clientId, _callbackId, _eventType);
        }
    }

}
