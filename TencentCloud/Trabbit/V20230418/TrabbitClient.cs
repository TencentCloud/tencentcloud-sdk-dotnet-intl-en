/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Trabbit.V20230418
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Trabbit.V20230418.Models;

   public class TrabbitClient : AbstractClient{

       private const string endpoint = "trabbit.intl.tencentcloudapi.com";
       private const string version = "2023-04-18";
       private const string sdkVersion = "SDK_NET_3.0.1128";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TrabbitClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TrabbitClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to create RabbitMQ binding relationships.
        /// </summary>
        /// <param name="req"><see cref="CreateRabbitMQServerlessBindingRequest"/></param>
        /// <returns><see cref="CreateRabbitMQServerlessBindingResponse"/></returns>
        public Task<CreateRabbitMQServerlessBindingResponse> CreateRabbitMQServerlessBinding(CreateRabbitMQServerlessBindingRequest req)
        {
            return InternalRequestAsync<CreateRabbitMQServerlessBindingResponse>(req, "CreateRabbitMQServerlessBinding");
        }

        /// <summary>
        /// This API is used to create RabbitMQ binding relationships.
        /// </summary>
        /// <param name="req"><see cref="CreateRabbitMQServerlessBindingRequest"/></param>
        /// <returns><see cref="CreateRabbitMQServerlessBindingResponse"/></returns>
        public CreateRabbitMQServerlessBindingResponse CreateRabbitMQServerlessBindingSync(CreateRabbitMQServerlessBindingRequest req)
        {
            return InternalRequestAsync<CreateRabbitMQServerlessBindingResponse>(req, "CreateRabbitMQServerlessBinding")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a RabbitMQ exchange.
        /// </summary>
        /// <param name="req"><see cref="CreateRabbitMQServerlessExchangeRequest"/></param>
        /// <returns><see cref="CreateRabbitMQServerlessExchangeResponse"/></returns>
        public Task<CreateRabbitMQServerlessExchangeResponse> CreateRabbitMQServerlessExchange(CreateRabbitMQServerlessExchangeRequest req)
        {
            return InternalRequestAsync<CreateRabbitMQServerlessExchangeResponse>(req, "CreateRabbitMQServerlessExchange");
        }

        /// <summary>
        /// This API is used to create a RabbitMQ exchange.
        /// </summary>
        /// <param name="req"><see cref="CreateRabbitMQServerlessExchangeRequest"/></param>
        /// <returns><see cref="CreateRabbitMQServerlessExchangeResponse"/></returns>
        public CreateRabbitMQServerlessExchangeResponse CreateRabbitMQServerlessExchangeSync(CreateRabbitMQServerlessExchangeRequest req)
        {
            return InternalRequestAsync<CreateRabbitMQServerlessExchangeResponse>(req, "CreateRabbitMQServerlessExchange")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an RabbitMQ queue.
        /// </summary>
        /// <param name="req"><see cref="CreateRabbitMQServerlessQueueRequest"/></param>
        /// <returns><see cref="CreateRabbitMQServerlessQueueResponse"/></returns>
        public Task<CreateRabbitMQServerlessQueueResponse> CreateRabbitMQServerlessQueue(CreateRabbitMQServerlessQueueRequest req)
        {
            return InternalRequestAsync<CreateRabbitMQServerlessQueueResponse>(req, "CreateRabbitMQServerlessQueue");
        }

        /// <summary>
        /// This API is used to create an RabbitMQ queue.
        /// </summary>
        /// <param name="req"><see cref="CreateRabbitMQServerlessQueueRequest"/></param>
        /// <returns><see cref="CreateRabbitMQServerlessQueueResponse"/></returns>
        public CreateRabbitMQServerlessQueueResponse CreateRabbitMQServerlessQueueSync(CreateRabbitMQServerlessQueueRequest req)
        {
            return InternalRequestAsync<CreateRabbitMQServerlessQueueResponse>(req, "CreateRabbitMQServerlessQueue")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a user for RabbitMQ.
        /// </summary>
        /// <param name="req"><see cref="CreateRabbitMQServerlessUserRequest"/></param>
        /// <returns><see cref="CreateRabbitMQServerlessUserResponse"/></returns>
        public Task<CreateRabbitMQServerlessUserResponse> CreateRabbitMQServerlessUser(CreateRabbitMQServerlessUserRequest req)
        {
            return InternalRequestAsync<CreateRabbitMQServerlessUserResponse>(req, "CreateRabbitMQServerlessUser");
        }

        /// <summary>
        /// This API is used to create a user for RabbitMQ.
        /// </summary>
        /// <param name="req"><see cref="CreateRabbitMQServerlessUserRequest"/></param>
        /// <returns><see cref="CreateRabbitMQServerlessUserResponse"/></returns>
        public CreateRabbitMQServerlessUserResponse CreateRabbitMQServerlessUserSync(CreateRabbitMQServerlessUserRequest req)
        {
            return InternalRequestAsync<CreateRabbitMQServerlessUserResponse>(req, "CreateRabbitMQServerlessUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a vhost for RabbitMQ.
        /// </summary>
        /// <param name="req"><see cref="CreateRabbitMQServerlessVirtualHostRequest"/></param>
        /// <returns><see cref="CreateRabbitMQServerlessVirtualHostResponse"/></returns>
        public Task<CreateRabbitMQServerlessVirtualHostResponse> CreateRabbitMQServerlessVirtualHost(CreateRabbitMQServerlessVirtualHostRequest req)
        {
            return InternalRequestAsync<CreateRabbitMQServerlessVirtualHostResponse>(req, "CreateRabbitMQServerlessVirtualHost");
        }

        /// <summary>
        /// This API is used to create a vhost for RabbitMQ.
        /// </summary>
        /// <param name="req"><see cref="CreateRabbitMQServerlessVirtualHostRequest"/></param>
        /// <returns><see cref="CreateRabbitMQServerlessVirtualHostResponse"/></returns>
        public CreateRabbitMQServerlessVirtualHostResponse CreateRabbitMQServerlessVirtualHostSync(CreateRabbitMQServerlessVirtualHostRequest req)
        {
            return InternalRequestAsync<CreateRabbitMQServerlessVirtualHostResponse>(req, "CreateRabbitMQServerlessVirtualHost")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unbind RabbitMQ binding relationships.
        /// </summary>
        /// <param name="req"><see cref="DeleteRabbitMQServerlessBindingRequest"/></param>
        /// <returns><see cref="DeleteRabbitMQServerlessBindingResponse"/></returns>
        public Task<DeleteRabbitMQServerlessBindingResponse> DeleteRabbitMQServerlessBinding(DeleteRabbitMQServerlessBindingRequest req)
        {
            return InternalRequestAsync<DeleteRabbitMQServerlessBindingResponse>(req, "DeleteRabbitMQServerlessBinding");
        }

        /// <summary>
        /// This API is used to unbind RabbitMQ binding relationships.
        /// </summary>
        /// <param name="req"><see cref="DeleteRabbitMQServerlessBindingRequest"/></param>
        /// <returns><see cref="DeleteRabbitMQServerlessBindingResponse"/></returns>
        public DeleteRabbitMQServerlessBindingResponse DeleteRabbitMQServerlessBindingSync(DeleteRabbitMQServerlessBindingRequest req)
        {
            return InternalRequestAsync<DeleteRabbitMQServerlessBindingResponse>(req, "DeleteRabbitMQServerlessBinding")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the RabbitMQ exchange.
        /// </summary>
        /// <param name="req"><see cref="DeleteRabbitMQServerlessExchangeRequest"/></param>
        /// <returns><see cref="DeleteRabbitMQServerlessExchangeResponse"/></returns>
        public Task<DeleteRabbitMQServerlessExchangeResponse> DeleteRabbitMQServerlessExchange(DeleteRabbitMQServerlessExchangeRequest req)
        {
            return InternalRequestAsync<DeleteRabbitMQServerlessExchangeResponse>(req, "DeleteRabbitMQServerlessExchange");
        }

        /// <summary>
        /// This API is used to delete the RabbitMQ exchange.
        /// </summary>
        /// <param name="req"><see cref="DeleteRabbitMQServerlessExchangeRequest"/></param>
        /// <returns><see cref="DeleteRabbitMQServerlessExchangeResponse"/></returns>
        public DeleteRabbitMQServerlessExchangeResponse DeleteRabbitMQServerlessExchangeSync(DeleteRabbitMQServerlessExchangeRequest req)
        {
            return InternalRequestAsync<DeleteRabbitMQServerlessExchangeResponse>(req, "DeleteRabbitMQServerlessExchange")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the permission of RabbitMQ.
        /// </summary>
        /// <param name="req"><see cref="DeleteRabbitMQServerlessPermissionRequest"/></param>
        /// <returns><see cref="DeleteRabbitMQServerlessPermissionResponse"/></returns>
        public Task<DeleteRabbitMQServerlessPermissionResponse> DeleteRabbitMQServerlessPermission(DeleteRabbitMQServerlessPermissionRequest req)
        {
            return InternalRequestAsync<DeleteRabbitMQServerlessPermissionResponse>(req, "DeleteRabbitMQServerlessPermission");
        }

        /// <summary>
        /// This API is used to delete the permission of RabbitMQ.
        /// </summary>
        /// <param name="req"><see cref="DeleteRabbitMQServerlessPermissionRequest"/></param>
        /// <returns><see cref="DeleteRabbitMQServerlessPermissionResponse"/></returns>
        public DeleteRabbitMQServerlessPermissionResponse DeleteRabbitMQServerlessPermissionSync(DeleteRabbitMQServerlessPermissionRequest req)
        {
            return InternalRequestAsync<DeleteRabbitMQServerlessPermissionResponse>(req, "DeleteRabbitMQServerlessPermission")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an RabbitMQ queue.
        /// </summary>
        /// <param name="req"><see cref="DeleteRabbitMQServerlessQueueRequest"/></param>
        /// <returns><see cref="DeleteRabbitMQServerlessQueueResponse"/></returns>
        public Task<DeleteRabbitMQServerlessQueueResponse> DeleteRabbitMQServerlessQueue(DeleteRabbitMQServerlessQueueRequest req)
        {
            return InternalRequestAsync<DeleteRabbitMQServerlessQueueResponse>(req, "DeleteRabbitMQServerlessQueue");
        }

        /// <summary>
        /// This API is used to delete an RabbitMQ queue.
        /// </summary>
        /// <param name="req"><see cref="DeleteRabbitMQServerlessQueueRequest"/></param>
        /// <returns><see cref="DeleteRabbitMQServerlessQueueResponse"/></returns>
        public DeleteRabbitMQServerlessQueueResponse DeleteRabbitMQServerlessQueueSync(DeleteRabbitMQServerlessQueueRequest req)
        {
            return InternalRequestAsync<DeleteRabbitMQServerlessQueueResponse>(req, "DeleteRabbitMQServerlessQueue")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the user of RabbitMQ.
        /// </summary>
        /// <param name="req"><see cref="DeleteRabbitMQServerlessUserRequest"/></param>
        /// <returns><see cref="DeleteRabbitMQServerlessUserResponse"/></returns>
        public Task<DeleteRabbitMQServerlessUserResponse> DeleteRabbitMQServerlessUser(DeleteRabbitMQServerlessUserRequest req)
        {
            return InternalRequestAsync<DeleteRabbitMQServerlessUserResponse>(req, "DeleteRabbitMQServerlessUser");
        }

        /// <summary>
        /// This API is used to delete the user of RabbitMQ.
        /// </summary>
        /// <param name="req"><see cref="DeleteRabbitMQServerlessUserRequest"/></param>
        /// <returns><see cref="DeleteRabbitMQServerlessUserResponse"/></returns>
        public DeleteRabbitMQServerlessUserResponse DeleteRabbitMQServerlessUserSync(DeleteRabbitMQServerlessUserRequest req)
        {
            return InternalRequestAsync<DeleteRabbitMQServerlessUserResponse>(req, "DeleteRabbitMQServerlessUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a vhost for RabbitMQ.
        /// </summary>
        /// <param name="req"><see cref="DeleteRabbitMQServerlessVirtualHostRequest"/></param>
        /// <returns><see cref="DeleteRabbitMQServerlessVirtualHostResponse"/></returns>
        public Task<DeleteRabbitMQServerlessVirtualHostResponse> DeleteRabbitMQServerlessVirtualHost(DeleteRabbitMQServerlessVirtualHostRequest req)
        {
            return InternalRequestAsync<DeleteRabbitMQServerlessVirtualHostResponse>(req, "DeleteRabbitMQServerlessVirtualHost");
        }

        /// <summary>
        /// This API is used to delete a vhost for RabbitMQ.
        /// </summary>
        /// <param name="req"><see cref="DeleteRabbitMQServerlessVirtualHostRequest"/></param>
        /// <returns><see cref="DeleteRabbitMQServerlessVirtualHostResponse"/></returns>
        public DeleteRabbitMQServerlessVirtualHostResponse DeleteRabbitMQServerlessVirtualHostSync(DeleteRabbitMQServerlessVirtualHostRequest req)
        {
            return InternalRequestAsync<DeleteRabbitMQServerlessVirtualHostResponse>(req, "DeleteRabbitMQServerlessVirtualHost")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to retrieve the binding relationship list.
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQServerlessBindingsRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQServerlessBindingsResponse"/></returns>
        public Task<DescribeRabbitMQServerlessBindingsResponse> DescribeRabbitMQServerlessBindings(DescribeRabbitMQServerlessBindingsRequest req)
        {
            return InternalRequestAsync<DescribeRabbitMQServerlessBindingsResponse>(req, "DescribeRabbitMQServerlessBindings");
        }

        /// <summary>
        /// This API is used to retrieve the binding relationship list.
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQServerlessBindingsRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQServerlessBindingsResponse"/></returns>
        public DescribeRabbitMQServerlessBindingsResponse DescribeRabbitMQServerlessBindingsSync(DescribeRabbitMQServerlessBindingsRequest req)
        {
            return InternalRequestAsync<DescribeRabbitMQServerlessBindingsResponse>(req, "DescribeRabbitMQServerlessBindings")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query RabbitMQ connection list.
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQServerlessConnectionRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQServerlessConnectionResponse"/></returns>
        public Task<DescribeRabbitMQServerlessConnectionResponse> DescribeRabbitMQServerlessConnection(DescribeRabbitMQServerlessConnectionRequest req)
        {
            return InternalRequestAsync<DescribeRabbitMQServerlessConnectionResponse>(req, "DescribeRabbitMQServerlessConnection");
        }

        /// <summary>
        /// This API is used to query RabbitMQ connection list.
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQServerlessConnectionRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQServerlessConnectionResponse"/></returns>
        public DescribeRabbitMQServerlessConnectionResponse DescribeRabbitMQServerlessConnectionSync(DescribeRabbitMQServerlessConnectionRequest req)
        {
            return InternalRequestAsync<DescribeRabbitMQServerlessConnectionResponse>(req, "DescribeRabbitMQServerlessConnection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query RabbitMQ queue consumer list.
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQServerlessConsumersRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQServerlessConsumersResponse"/></returns>
        public Task<DescribeRabbitMQServerlessConsumersResponse> DescribeRabbitMQServerlessConsumers(DescribeRabbitMQServerlessConsumersRequest req)
        {
            return InternalRequestAsync<DescribeRabbitMQServerlessConsumersResponse>(req, "DescribeRabbitMQServerlessConsumers");
        }

        /// <summary>
        /// This API is used to query RabbitMQ queue consumer list.
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQServerlessConsumersRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQServerlessConsumersResponse"/></returns>
        public DescribeRabbitMQServerlessConsumersResponse DescribeRabbitMQServerlessConsumersSync(DescribeRabbitMQServerlessConsumersRequest req)
        {
            return InternalRequestAsync<DescribeRabbitMQServerlessConsumersResponse>(req, "DescribeRabbitMQServerlessConsumers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query RabbitMQ exchange details.
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQServerlessExchangeDetailRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQServerlessExchangeDetailResponse"/></returns>
        public Task<DescribeRabbitMQServerlessExchangeDetailResponse> DescribeRabbitMQServerlessExchangeDetail(DescribeRabbitMQServerlessExchangeDetailRequest req)
        {
            return InternalRequestAsync<DescribeRabbitMQServerlessExchangeDetailResponse>(req, "DescribeRabbitMQServerlessExchangeDetail");
        }

        /// <summary>
        /// This API is used to query RabbitMQ exchange details.
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQServerlessExchangeDetailRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQServerlessExchangeDetailResponse"/></returns>
        public DescribeRabbitMQServerlessExchangeDetailResponse DescribeRabbitMQServerlessExchangeDetailSync(DescribeRabbitMQServerlessExchangeDetailRequest req)
        {
            return InternalRequestAsync<DescribeRabbitMQServerlessExchangeDetailResponse>(req, "DescribeRabbitMQServerlessExchangeDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of RabbitMQ exchanges.
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQServerlessExchangesRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQServerlessExchangesResponse"/></returns>
        public Task<DescribeRabbitMQServerlessExchangesResponse> DescribeRabbitMQServerlessExchanges(DescribeRabbitMQServerlessExchangesRequest req)
        {
            return InternalRequestAsync<DescribeRabbitMQServerlessExchangesResponse>(req, "DescribeRabbitMQServerlessExchanges");
        }

        /// <summary>
        /// This API is used to query the list of RabbitMQ exchanges.
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQServerlessExchangesRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQServerlessExchangesResponse"/></returns>
        public DescribeRabbitMQServerlessExchangesResponse DescribeRabbitMQServerlessExchangesSync(DescribeRabbitMQServerlessExchangesRequest req)
        {
            return InternalRequestAsync<DescribeRabbitMQServerlessExchangesResponse>(req, "DescribeRabbitMQServerlessExchanges")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to retrieve dedicated instance information for a single RabbitMQ.
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQServerlessInstanceRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQServerlessInstanceResponse"/></returns>
        public Task<DescribeRabbitMQServerlessInstanceResponse> DescribeRabbitMQServerlessInstance(DescribeRabbitMQServerlessInstanceRequest req)
        {
            return InternalRequestAsync<DescribeRabbitMQServerlessInstanceResponse>(req, "DescribeRabbitMQServerlessInstance");
        }

        /// <summary>
        /// This API is used to retrieve dedicated instance information for a single RabbitMQ.
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQServerlessInstanceRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQServerlessInstanceResponse"/></returns>
        public DescribeRabbitMQServerlessInstanceResponse DescribeRabbitMQServerlessInstanceSync(DescribeRabbitMQServerlessInstanceRequest req)
        {
            return InternalRequestAsync<DescribeRabbitMQServerlessInstanceResponse>(req, "DescribeRabbitMQServerlessInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query RabbitMQ permission list.
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQServerlessPermissionRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQServerlessPermissionResponse"/></returns>
        public Task<DescribeRabbitMQServerlessPermissionResponse> DescribeRabbitMQServerlessPermission(DescribeRabbitMQServerlessPermissionRequest req)
        {
            return InternalRequestAsync<DescribeRabbitMQServerlessPermissionResponse>(req, "DescribeRabbitMQServerlessPermission");
        }

        /// <summary>
        /// This API is used to query RabbitMQ permission list.
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQServerlessPermissionRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQServerlessPermissionResponse"/></returns>
        public DescribeRabbitMQServerlessPermissionResponse DescribeRabbitMQServerlessPermissionSync(DescribeRabbitMQServerlessPermissionRequest req)
        {
            return InternalRequestAsync<DescribeRabbitMQServerlessPermissionResponse>(req, "DescribeRabbitMQServerlessPermission")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query RabbitMQ queue details.
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQServerlessQueueDetailRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQServerlessQueueDetailResponse"/></returns>
        public Task<DescribeRabbitMQServerlessQueueDetailResponse> DescribeRabbitMQServerlessQueueDetail(DescribeRabbitMQServerlessQueueDetailRequest req)
        {
            return InternalRequestAsync<DescribeRabbitMQServerlessQueueDetailResponse>(req, "DescribeRabbitMQServerlessQueueDetail");
        }

        /// <summary>
        /// This API is used to query RabbitMQ queue details.
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQServerlessQueueDetailRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQServerlessQueueDetailResponse"/></returns>
        public DescribeRabbitMQServerlessQueueDetailResponse DescribeRabbitMQServerlessQueueDetailSync(DescribeRabbitMQServerlessQueueDetailRequest req)
        {
            return InternalRequestAsync<DescribeRabbitMQServerlessQueueDetailResponse>(req, "DescribeRabbitMQServerlessQueueDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query a RabbitMQ queue list.
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQServerlessQueuesRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQServerlessQueuesResponse"/></returns>
        public Task<DescribeRabbitMQServerlessQueuesResponse> DescribeRabbitMQServerlessQueues(DescribeRabbitMQServerlessQueuesRequest req)
        {
            return InternalRequestAsync<DescribeRabbitMQServerlessQueuesResponse>(req, "DescribeRabbitMQServerlessQueues");
        }

        /// <summary>
        /// This API is used to query a RabbitMQ queue list.
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQServerlessQueuesRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQServerlessQueuesResponse"/></returns>
        public DescribeRabbitMQServerlessQueuesResponse DescribeRabbitMQServerlessQueuesSync(DescribeRabbitMQServerlessQueuesRequest req)
        {
            return InternalRequestAsync<DescribeRabbitMQServerlessQueuesResponse>(req, "DescribeRabbitMQServerlessQueues")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query RabbitMQ user list.
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQServerlessUserRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQServerlessUserResponse"/></returns>
        public Task<DescribeRabbitMQServerlessUserResponse> DescribeRabbitMQServerlessUser(DescribeRabbitMQServerlessUserRequest req)
        {
            return InternalRequestAsync<DescribeRabbitMQServerlessUserResponse>(req, "DescribeRabbitMQServerlessUser");
        }

        /// <summary>
        /// This API is used to query RabbitMQ user list.
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQServerlessUserRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQServerlessUserResponse"/></returns>
        public DescribeRabbitMQServerlessUserResponse DescribeRabbitMQServerlessUserSync(DescribeRabbitMQServerlessUserRequest req)
        {
            return InternalRequestAsync<DescribeRabbitMQServerlessUserResponse>(req, "DescribeRabbitMQServerlessUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query a RabbitMQ vhost list.
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQServerlessVirtualHostRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQServerlessVirtualHostResponse"/></returns>
        public Task<DescribeRabbitMQServerlessVirtualHostResponse> DescribeRabbitMQServerlessVirtualHost(DescribeRabbitMQServerlessVirtualHostRequest req)
        {
            return InternalRequestAsync<DescribeRabbitMQServerlessVirtualHostResponse>(req, "DescribeRabbitMQServerlessVirtualHost");
        }

        /// <summary>
        /// This API is used to query a RabbitMQ vhost list.
        /// </summary>
        /// <param name="req"><see cref="DescribeRabbitMQServerlessVirtualHostRequest"/></param>
        /// <returns><see cref="DescribeRabbitMQServerlessVirtualHostResponse"/></returns>
        public DescribeRabbitMQServerlessVirtualHostResponse DescribeRabbitMQServerlessVirtualHostSync(DescribeRabbitMQServerlessVirtualHostRequest req)
        {
            return InternalRequestAsync<DescribeRabbitMQServerlessVirtualHostResponse>(req, "DescribeRabbitMQServerlessVirtualHost")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain instance lists.
        /// </summary>
        /// <param name="req"><see cref="ListRabbitMQServerlessInstancesRequest"/></param>
        /// <returns><see cref="ListRabbitMQServerlessInstancesResponse"/></returns>
        public Task<ListRabbitMQServerlessInstancesResponse> ListRabbitMQServerlessInstances(ListRabbitMQServerlessInstancesRequest req)
        {
            return InternalRequestAsync<ListRabbitMQServerlessInstancesResponse>(req, "ListRabbitMQServerlessInstances");
        }

        /// <summary>
        /// This API is used to obtain instance lists.
        /// </summary>
        /// <param name="req"><see cref="ListRabbitMQServerlessInstancesRequest"/></param>
        /// <returns><see cref="ListRabbitMQServerlessInstancesResponse"/></returns>
        public ListRabbitMQServerlessInstancesResponse ListRabbitMQServerlessInstancesSync(ListRabbitMQServerlessInstancesRequest req)
        {
            return InternalRequestAsync<ListRabbitMQServerlessInstancesResponse>(req, "ListRabbitMQServerlessInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the RabbitMQ exchange.
        /// </summary>
        /// <param name="req"><see cref="ModifyRabbitMQServerlessExchangeRequest"/></param>
        /// <returns><see cref="ModifyRabbitMQServerlessExchangeResponse"/></returns>
        public Task<ModifyRabbitMQServerlessExchangeResponse> ModifyRabbitMQServerlessExchange(ModifyRabbitMQServerlessExchangeRequest req)
        {
            return InternalRequestAsync<ModifyRabbitMQServerlessExchangeResponse>(req, "ModifyRabbitMQServerlessExchange");
        }

        /// <summary>
        /// This API is used to modify the RabbitMQ exchange.
        /// </summary>
        /// <param name="req"><see cref="ModifyRabbitMQServerlessExchangeRequest"/></param>
        /// <returns><see cref="ModifyRabbitMQServerlessExchangeResponse"/></returns>
        public ModifyRabbitMQServerlessExchangeResponse ModifyRabbitMQServerlessExchangeSync(ModifyRabbitMQServerlessExchangeRequest req)
        {
            return InternalRequestAsync<ModifyRabbitMQServerlessExchangeResponse>(req, "ModifyRabbitMQServerlessExchange")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify cluster information.
        /// </summary>
        /// <param name="req"><see cref="ModifyRabbitMQServerlessInstanceRequest"/></param>
        /// <returns><see cref="ModifyRabbitMQServerlessInstanceResponse"/></returns>
        public Task<ModifyRabbitMQServerlessInstanceResponse> ModifyRabbitMQServerlessInstance(ModifyRabbitMQServerlessInstanceRequest req)
        {
            return InternalRequestAsync<ModifyRabbitMQServerlessInstanceResponse>(req, "ModifyRabbitMQServerlessInstance");
        }

        /// <summary>
        /// This API is used to modify cluster information.
        /// </summary>
        /// <param name="req"><see cref="ModifyRabbitMQServerlessInstanceRequest"/></param>
        /// <returns><see cref="ModifyRabbitMQServerlessInstanceResponse"/></returns>
        public ModifyRabbitMQServerlessInstanceResponse ModifyRabbitMQServerlessInstanceSync(ModifyRabbitMQServerlessInstanceRequest req)
        {
            return InternalRequestAsync<ModifyRabbitMQServerlessInstanceResponse>(req, "ModifyRabbitMQServerlessInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the permission of RabbitMQ.
        /// </summary>
        /// <param name="req"><see cref="ModifyRabbitMQServerlessPermissionRequest"/></param>
        /// <returns><see cref="ModifyRabbitMQServerlessPermissionResponse"/></returns>
        public Task<ModifyRabbitMQServerlessPermissionResponse> ModifyRabbitMQServerlessPermission(ModifyRabbitMQServerlessPermissionRequest req)
        {
            return InternalRequestAsync<ModifyRabbitMQServerlessPermissionResponse>(req, "ModifyRabbitMQServerlessPermission");
        }

        /// <summary>
        /// This API is used to modify the permission of RabbitMQ.
        /// </summary>
        /// <param name="req"><see cref="ModifyRabbitMQServerlessPermissionRequest"/></param>
        /// <returns><see cref="ModifyRabbitMQServerlessPermissionResponse"/></returns>
        public ModifyRabbitMQServerlessPermissionResponse ModifyRabbitMQServerlessPermissionSync(ModifyRabbitMQServerlessPermissionRequest req)
        {
            return InternalRequestAsync<ModifyRabbitMQServerlessPermissionResponse>(req, "ModifyRabbitMQServerlessPermission")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify an RabbitMQ queue.
        /// </summary>
        /// <param name="req"><see cref="ModifyRabbitMQServerlessQueueRequest"/></param>
        /// <returns><see cref="ModifyRabbitMQServerlessQueueResponse"/></returns>
        public Task<ModifyRabbitMQServerlessQueueResponse> ModifyRabbitMQServerlessQueue(ModifyRabbitMQServerlessQueueRequest req)
        {
            return InternalRequestAsync<ModifyRabbitMQServerlessQueueResponse>(req, "ModifyRabbitMQServerlessQueue");
        }

        /// <summary>
        /// This API is used to modify an RabbitMQ queue.
        /// </summary>
        /// <param name="req"><see cref="ModifyRabbitMQServerlessQueueRequest"/></param>
        /// <returns><see cref="ModifyRabbitMQServerlessQueueResponse"/></returns>
        public ModifyRabbitMQServerlessQueueResponse ModifyRabbitMQServerlessQueueSync(ModifyRabbitMQServerlessQueueRequest req)
        {
            return InternalRequestAsync<ModifyRabbitMQServerlessQueueResponse>(req, "ModifyRabbitMQServerlessQueue")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the user of RabbitMQ.
        /// </summary>
        /// <param name="req"><see cref="ModifyRabbitMQServerlessUserRequest"/></param>
        /// <returns><see cref="ModifyRabbitMQServerlessUserResponse"/></returns>
        public Task<ModifyRabbitMQServerlessUserResponse> ModifyRabbitMQServerlessUser(ModifyRabbitMQServerlessUserRequest req)
        {
            return InternalRequestAsync<ModifyRabbitMQServerlessUserResponse>(req, "ModifyRabbitMQServerlessUser");
        }

        /// <summary>
        /// This API is used to modify the user of RabbitMQ.
        /// </summary>
        /// <param name="req"><see cref="ModifyRabbitMQServerlessUserRequest"/></param>
        /// <returns><see cref="ModifyRabbitMQServerlessUserResponse"/></returns>
        public ModifyRabbitMQServerlessUserResponse ModifyRabbitMQServerlessUserSync(ModifyRabbitMQServerlessUserRequest req)
        {
            return InternalRequestAsync<ModifyRabbitMQServerlessUserResponse>(req, "ModifyRabbitMQServerlessUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a vhost for RabbitMQ.
        /// </summary>
        /// <param name="req"><see cref="ModifyRabbitMQServerlessVirtualHostRequest"/></param>
        /// <returns><see cref="ModifyRabbitMQServerlessVirtualHostResponse"/></returns>
        public Task<ModifyRabbitMQServerlessVirtualHostResponse> ModifyRabbitMQServerlessVirtualHost(ModifyRabbitMQServerlessVirtualHostRequest req)
        {
            return InternalRequestAsync<ModifyRabbitMQServerlessVirtualHostResponse>(req, "ModifyRabbitMQServerlessVirtualHost");
        }

        /// <summary>
        /// This API is used to modify a vhost for RabbitMQ.
        /// </summary>
        /// <param name="req"><see cref="ModifyRabbitMQServerlessVirtualHostRequest"/></param>
        /// <returns><see cref="ModifyRabbitMQServerlessVirtualHostResponse"/></returns>
        public ModifyRabbitMQServerlessVirtualHostResponse ModifyRabbitMQServerlessVirtualHostSync(ModifyRabbitMQServerlessVirtualHostRequest req)
        {
            return InternalRequestAsync<ModifyRabbitMQServerlessVirtualHostResponse>(req, "ModifyRabbitMQServerlessVirtualHost")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
