// Copyright 2007-2012 Chris Patterson, Dru Sellers, Travis Smith, et. al.
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace MassTransit.RequestResponse.Configurators
{
    using System;

    public interface InlineRequestConfigurator<TRequest> :
        RequestConfigurator<TRequest>
        where TRequest : class
    {
        /// <summary>
        /// Configures a handler to be called if a response of the specified type
        /// is received. Once received, the request completes by default unless
        /// overridden by calling Continue on the request.
        /// </summary>
        /// <typeparam name="TResponse">The message type of the response</typeparam>
        /// <param name="handler">The handler to call with the response message</param>
        void Handle<TResponse>(Action<TResponse> handler)
            where TResponse : class;

        /// <summary>
        /// Configures a handler to be called if a response of the specified type
        /// is received. Once received, the request completes by default unless
        /// overridden by calling Continue on the request.
        /// </summary>
        /// <typeparam name="TResponse">The message type of the response</typeparam>
        /// <param name="handler">The handler to call with the response message</param>
        void Handle<TResponse>(Action<IConsumeContext<TResponse>, TResponse> handler)
            where TResponse : class;
    }
}