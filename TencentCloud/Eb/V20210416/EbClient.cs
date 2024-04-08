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

namespace TencentCloud.Eb.V20210416
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Eb.V20210416.Models;

   public class EbClient : AbstractClient{

       private const string endpoint = "eb.tencentcloudapi.com";
       private const string version = "2021-04-16";
       private const string sdkVersion = "SDK_NET_3.0.873";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public EbClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public EbClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to check a rule.
        /// </summary>
        /// <param name="req"><see cref="CheckRuleRequest"/></param>
        /// <returns><see cref="CheckRuleResponse"/></returns>
        public Task<CheckRuleResponse> CheckRule(CheckRuleRequest req)
        {
            return InternalRequestAsync<CheckRuleResponse>(req, "CheckRule");
        }

        /// <summary>
        /// This API is used to check a rule.
        /// </summary>
        /// <param name="req"><see cref="CheckRuleRequest"/></param>
        /// <returns><see cref="CheckRuleResponse"/></returns>
        public CheckRuleResponse CheckRuleSync(CheckRuleRequest req)
        {
            return InternalRequestAsync<CheckRuleResponse>(req, "CheckRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to test rules and data on the ETL configuration page.
        /// </summary>
        /// <param name="req"><see cref="CheckTransformationRequest"/></param>
        /// <returns><see cref="CheckTransformationResponse"/></returns>
        public Task<CheckTransformationResponse> CheckTransformation(CheckTransformationRequest req)
        {
            return InternalRequestAsync<CheckTransformationResponse>(req, "CheckTransformation");
        }

        /// <summary>
        /// This API is used to test rules and data on the ETL configuration page.
        /// </summary>
        /// <param name="req"><see cref="CheckTransformationRequest"/></param>
        /// <returns><see cref="CheckTransformationResponse"/></returns>
        public CheckTransformationResponse CheckTransformationSync(CheckTransformationRequest req)
        {
            return InternalRequestAsync<CheckTransformationResponse>(req, "CheckTransformation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an event connector.
        /// </summary>
        /// <param name="req"><see cref="CreateConnectionRequest"/></param>
        /// <returns><see cref="CreateConnectionResponse"/></returns>
        public Task<CreateConnectionResponse> CreateConnection(CreateConnectionRequest req)
        {
            return InternalRequestAsync<CreateConnectionResponse>(req, "CreateConnection");
        }

        /// <summary>
        /// This API is used to create an event connector.
        /// </summary>
        /// <param name="req"><see cref="CreateConnectionRequest"/></param>
        /// <returns><see cref="CreateConnectionResponse"/></returns>
        public CreateConnectionResponse CreateConnectionSync(CreateConnectionRequest req)
        {
            return InternalRequestAsync<CreateConnectionResponse>(req, "CreateConnection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an event bus.
        /// </summary>
        /// <param name="req"><see cref="CreateEventBusRequest"/></param>
        /// <returns><see cref="CreateEventBusResponse"/></returns>
        public Task<CreateEventBusResponse> CreateEventBus(CreateEventBusRequest req)
        {
            return InternalRequestAsync<CreateEventBusResponse>(req, "CreateEventBus");
        }

        /// <summary>
        /// This API is used to create an event bus.
        /// </summary>
        /// <param name="req"><see cref="CreateEventBusRequest"/></param>
        /// <returns><see cref="CreateEventBusResponse"/></returns>
        public CreateEventBusResponse CreateEventBusSync(CreateEventBusRequest req)
        {
            return InternalRequestAsync<CreateEventBusResponse>(req, "CreateEventBus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an event rule.
        /// </summary>
        /// <param name="req"><see cref="CreateRuleRequest"/></param>
        /// <returns><see cref="CreateRuleResponse"/></returns>
        public Task<CreateRuleResponse> CreateRule(CreateRuleRequest req)
        {
            return InternalRequestAsync<CreateRuleResponse>(req, "CreateRule");
        }

        /// <summary>
        /// This API is used to create an event rule.
        /// </summary>
        /// <param name="req"><see cref="CreateRuleRequest"/></param>
        /// <returns><see cref="CreateRuleResponse"/></returns>
        public CreateRuleResponse CreateRuleSync(CreateRuleRequest req)
        {
            return InternalRequestAsync<CreateRuleResponse>(req, "CreateRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a delivery target.
        /// </summary>
        /// <param name="req"><see cref="CreateTargetRequest"/></param>
        /// <returns><see cref="CreateTargetResponse"/></returns>
        public Task<CreateTargetResponse> CreateTarget(CreateTargetRequest req)
        {
            return InternalRequestAsync<CreateTargetResponse>(req, "CreateTarget");
        }

        /// <summary>
        /// This API is used to create a delivery target.
        /// </summary>
        /// <param name="req"><see cref="CreateTargetRequest"/></param>
        /// <returns><see cref="CreateTargetResponse"/></returns>
        public CreateTargetResponse CreateTargetSync(CreateTargetRequest req)
        {
            return InternalRequestAsync<CreateTargetResponse>(req, "CreateTarget")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a transformer.
        /// </summary>
        /// <param name="req"><see cref="CreateTransformationRequest"/></param>
        /// <returns><see cref="CreateTransformationResponse"/></returns>
        public Task<CreateTransformationResponse> CreateTransformation(CreateTransformationRequest req)
        {
            return InternalRequestAsync<CreateTransformationResponse>(req, "CreateTransformation");
        }

        /// <summary>
        /// This API is used to create a transformer.
        /// </summary>
        /// <param name="req"><see cref="CreateTransformationRequest"/></param>
        /// <returns><see cref="CreateTransformationResponse"/></returns>
        public CreateTransformationResponse CreateTransformationSync(CreateTransformationRequest req)
        {
            return InternalRequestAsync<CreateTransformationResponse>(req, "CreateTransformation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an event connector.
        /// </summary>
        /// <param name="req"><see cref="DeleteConnectionRequest"/></param>
        /// <returns><see cref="DeleteConnectionResponse"/></returns>
        public Task<DeleteConnectionResponse> DeleteConnection(DeleteConnectionRequest req)
        {
            return InternalRequestAsync<DeleteConnectionResponse>(req, "DeleteConnection");
        }

        /// <summary>
        /// This API is used to delete an event connector.
        /// </summary>
        /// <param name="req"><see cref="DeleteConnectionRequest"/></param>
        /// <returns><see cref="DeleteConnectionResponse"/></returns>
        public DeleteConnectionResponse DeleteConnectionSync(DeleteConnectionRequest req)
        {
            return InternalRequestAsync<DeleteConnectionResponse>(req, "DeleteConnection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an event bus.
        /// </summary>
        /// <param name="req"><see cref="DeleteEventBusRequest"/></param>
        /// <returns><see cref="DeleteEventBusResponse"/></returns>
        public Task<DeleteEventBusResponse> DeleteEventBus(DeleteEventBusRequest req)
        {
            return InternalRequestAsync<DeleteEventBusResponse>(req, "DeleteEventBus");
        }

        /// <summary>
        /// This API is used to delete an event bus.
        /// </summary>
        /// <param name="req"><see cref="DeleteEventBusRequest"/></param>
        /// <returns><see cref="DeleteEventBusResponse"/></returns>
        public DeleteEventBusResponse DeleteEventBusSync(DeleteEventBusRequest req)
        {
            return InternalRequestAsync<DeleteEventBusResponse>(req, "DeleteEventBus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an event rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteRuleRequest"/></param>
        /// <returns><see cref="DeleteRuleResponse"/></returns>
        public Task<DeleteRuleResponse> DeleteRule(DeleteRuleRequest req)
        {
            return InternalRequestAsync<DeleteRuleResponse>(req, "DeleteRule");
        }

        /// <summary>
        /// This API is used to delete an event rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteRuleRequest"/></param>
        /// <returns><see cref="DeleteRuleResponse"/></returns>
        public DeleteRuleResponse DeleteRuleSync(DeleteRuleRequest req)
        {
            return InternalRequestAsync<DeleteRuleResponse>(req, "DeleteRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a delivery target.
        /// </summary>
        /// <param name="req"><see cref="DeleteTargetRequest"/></param>
        /// <returns><see cref="DeleteTargetResponse"/></returns>
        public Task<DeleteTargetResponse> DeleteTarget(DeleteTargetRequest req)
        {
            return InternalRequestAsync<DeleteTargetResponse>(req, "DeleteTarget");
        }

        /// <summary>
        /// This API is used to delete a delivery target.
        /// </summary>
        /// <param name="req"><see cref="DeleteTargetRequest"/></param>
        /// <returns><see cref="DeleteTargetResponse"/></returns>
        public DeleteTargetResponse DeleteTargetSync(DeleteTargetRequest req)
        {
            return InternalRequestAsync<DeleteTargetResponse>(req, "DeleteTarget")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a transformer.
        /// </summary>
        /// <param name="req"><see cref="DeleteTransformationRequest"/></param>
        /// <returns><see cref="DeleteTransformationResponse"/></returns>
        public Task<DeleteTransformationResponse> DeleteTransformation(DeleteTransformationRequest req)
        {
            return InternalRequestAsync<DeleteTransformationResponse>(req, "DeleteTransformation");
        }

        /// <summary>
        /// This API is used to delete a transformer.
        /// </summary>
        /// <param name="req"><see cref="DeleteTransformationRequest"/></param>
        /// <returns><see cref="DeleteTransformationResponse"/></returns>
        public DeleteTransformationResponse DeleteTransformationSync(DeleteTransformationRequest req)
        {
            return InternalRequestAsync<DeleteTransformationResponse>(req, "DeleteTransformation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query log searching metric values.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogTagValueRequest"/></param>
        /// <returns><see cref="DescribeLogTagValueResponse"/></returns>
        public Task<DescribeLogTagValueResponse> DescribeLogTagValue(DescribeLogTagValueRequest req)
        {
            return InternalRequestAsync<DescribeLogTagValueResponse>(req, "DescribeLogTagValue");
        }

        /// <summary>
        /// This API is used to query log searching metric values.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogTagValueRequest"/></param>
        /// <returns><see cref="DescribeLogTagValueResponse"/></returns>
        public DescribeLogTagValueResponse DescribeLogTagValueSync(DescribeLogTagValueRequest req)
        {
            return InternalRequestAsync<DescribeLogTagValueResponse>(req, "DescribeLogTagValue")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the details of an event bus.
        /// </summary>
        /// <param name="req"><see cref="GetEventBusRequest"/></param>
        /// <returns><see cref="GetEventBusResponse"/></returns>
        public Task<GetEventBusResponse> GetEventBus(GetEventBusRequest req)
        {
            return InternalRequestAsync<GetEventBusResponse>(req, "GetEventBus");
        }

        /// <summary>
        /// This API is used to get the details of an event bus.
        /// </summary>
        /// <param name="req"><see cref="GetEventBusRequest"/></param>
        /// <returns><see cref="GetEventBusResponse"/></returns>
        public GetEventBusResponse GetEventBusSync(GetEventBusRequest req)
        {
            return InternalRequestAsync<GetEventBusResponse>(req, "GetEventBus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the details of an event rule.
        /// </summary>
        /// <param name="req"><see cref="GetRuleRequest"/></param>
        /// <returns><see cref="GetRuleResponse"/></returns>
        public Task<GetRuleResponse> GetRule(GetRuleRequest req)
        {
            return InternalRequestAsync<GetRuleResponse>(req, "GetRule");
        }

        /// <summary>
        /// This API is used to get the details of an event rule.
        /// </summary>
        /// <param name="req"><see cref="GetRuleRequest"/></param>
        /// <returns><see cref="GetRuleResponse"/></returns>
        public GetRuleResponse GetRuleSync(GetRuleRequest req)
        {
            return InternalRequestAsync<GetRuleResponse>(req, "GetRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the details of a transformer.
        /// </summary>
        /// <param name="req"><see cref="GetTransformationRequest"/></param>
        /// <returns><see cref="GetTransformationResponse"/></returns>
        public Task<GetTransformationResponse> GetTransformation(GetTransformationRequest req)
        {
            return InternalRequestAsync<GetTransformationResponse>(req, "GetTransformation");
        }

        /// <summary>
        /// This API is used to get the details of a transformer.
        /// </summary>
        /// <param name="req"><see cref="GetTransformationRequest"/></param>
        /// <returns><see cref="GetTransformationResponse"/></returns>
        public GetTransformationResponse GetTransformationSync(GetTransformationRequest req)
        {
            return InternalRequestAsync<GetTransformationResponse>(req, "GetTransformation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of event connectors.
        /// </summary>
        /// <param name="req"><see cref="ListConnectionsRequest"/></param>
        /// <returns><see cref="ListConnectionsResponse"/></returns>
        public Task<ListConnectionsResponse> ListConnections(ListConnectionsRequest req)
        {
            return InternalRequestAsync<ListConnectionsResponse>(req, "ListConnections");
        }

        /// <summary>
        /// This API is used to get the list of event connectors.
        /// </summary>
        /// <param name="req"><see cref="ListConnectionsRequest"/></param>
        /// <returns><see cref="ListConnectionsResponse"/></returns>
        public ListConnectionsResponse ListConnectionsSync(ListConnectionsRequest req)
        {
            return InternalRequestAsync<ListConnectionsResponse>(req, "ListConnections")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of event buses.
        /// </summary>
        /// <param name="req"><see cref="ListEventBusesRequest"/></param>
        /// <returns><see cref="ListEventBusesResponse"/></returns>
        public Task<ListEventBusesResponse> ListEventBuses(ListEventBusesRequest req)
        {
            return InternalRequestAsync<ListEventBusesResponse>(req, "ListEventBuses");
        }

        /// <summary>
        /// This API is used to get the list of event buses.
        /// </summary>
        /// <param name="req"><see cref="ListEventBusesRequest"/></param>
        /// <returns><see cref="ListEventBusesResponse"/></returns>
        public ListEventBusesResponse ListEventBusesSync(ListEventBusesRequest req)
        {
            return InternalRequestAsync<ListEventBusesResponse>(req, "ListEventBuses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of event rules.
        /// </summary>
        /// <param name="req"><see cref="ListRulesRequest"/></param>
        /// <returns><see cref="ListRulesResponse"/></returns>
        public Task<ListRulesResponse> ListRules(ListRulesRequest req)
        {
            return InternalRequestAsync<ListRulesResponse>(req, "ListRules");
        }

        /// <summary>
        /// This API is used to get the list of event rules.
        /// </summary>
        /// <param name="req"><see cref="ListRulesRequest"/></param>
        /// <returns><see cref="ListRulesResponse"/></returns>
        public ListRulesResponse ListRulesSync(ListRulesRequest req)
        {
            return InternalRequestAsync<ListRulesResponse>(req, "ListRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list delivery targets.
        /// </summary>
        /// <param name="req"><see cref="ListTargetsRequest"/></param>
        /// <returns><see cref="ListTargetsResponse"/></returns>
        public Task<ListTargetsResponse> ListTargets(ListTargetsRequest req)
        {
            return InternalRequestAsync<ListTargetsResponse>(req, "ListTargets");
        }

        /// <summary>
        /// This API is used to get the list delivery targets.
        /// </summary>
        /// <param name="req"><see cref="ListTargetsRequest"/></param>
        /// <returns><see cref="ListTargetsResponse"/></returns>
        public ListTargetsResponse ListTargetsSync(ListTargetsRequest req)
        {
            return InternalRequestAsync<ListTargetsResponse>(req, "ListTargets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query logs. 
        /// </summary>
        /// <param name="req"><see cref="SearchLogRequest"/></param>
        /// <returns><see cref="SearchLogResponse"/></returns>
        public Task<SearchLogResponse> SearchLog(SearchLogRequest req)
        {
            return InternalRequestAsync<SearchLogResponse>(req, "SearchLog");
        }

        /// <summary>
        /// This API is used to query logs. 
        /// </summary>
        /// <param name="req"><see cref="SearchLogRequest"/></param>
        /// <returns><see cref="SearchLogResponse"/></returns>
        public SearchLogResponse SearchLogSync(SearchLogRequest req)
        {
            return InternalRequestAsync<SearchLogResponse>(req, "SearchLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update an event connector.
        /// </summary>
        /// <param name="req"><see cref="UpdateConnectionRequest"/></param>
        /// <returns><see cref="UpdateConnectionResponse"/></returns>
        public Task<UpdateConnectionResponse> UpdateConnection(UpdateConnectionRequest req)
        {
            return InternalRequestAsync<UpdateConnectionResponse>(req, "UpdateConnection");
        }

        /// <summary>
        /// This API is used to update an event connector.
        /// </summary>
        /// <param name="req"><see cref="UpdateConnectionRequest"/></param>
        /// <returns><see cref="UpdateConnectionResponse"/></returns>
        public UpdateConnectionResponse UpdateConnectionSync(UpdateConnectionRequest req)
        {
            return InternalRequestAsync<UpdateConnectionResponse>(req, "UpdateConnection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update an event bus.
        /// </summary>
        /// <param name="req"><see cref="UpdateEventBusRequest"/></param>
        /// <returns><see cref="UpdateEventBusResponse"/></returns>
        public Task<UpdateEventBusResponse> UpdateEventBus(UpdateEventBusRequest req)
        {
            return InternalRequestAsync<UpdateEventBusResponse>(req, "UpdateEventBus");
        }

        /// <summary>
        /// This API is used to update an event bus.
        /// </summary>
        /// <param name="req"><see cref="UpdateEventBusRequest"/></param>
        /// <returns><see cref="UpdateEventBusResponse"/></returns>
        public UpdateEventBusResponse UpdateEventBusSync(UpdateEventBusRequest req)
        {
            return InternalRequestAsync<UpdateEventBusResponse>(req, "UpdateEventBus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update an event rule.
        /// </summary>
        /// <param name="req"><see cref="UpdateRuleRequest"/></param>
        /// <returns><see cref="UpdateRuleResponse"/></returns>
        public Task<UpdateRuleResponse> UpdateRule(UpdateRuleRequest req)
        {
            return InternalRequestAsync<UpdateRuleResponse>(req, "UpdateRule");
        }

        /// <summary>
        /// This API is used to update an event rule.
        /// </summary>
        /// <param name="req"><see cref="UpdateRuleRequest"/></param>
        /// <returns><see cref="UpdateRuleResponse"/></returns>
        public UpdateRuleResponse UpdateRuleSync(UpdateRuleRequest req)
        {
            return InternalRequestAsync<UpdateRuleResponse>(req, "UpdateRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update a delivery target.
        /// </summary>
        /// <param name="req"><see cref="UpdateTargetRequest"/></param>
        /// <returns><see cref="UpdateTargetResponse"/></returns>
        public Task<UpdateTargetResponse> UpdateTarget(UpdateTargetRequest req)
        {
            return InternalRequestAsync<UpdateTargetResponse>(req, "UpdateTarget");
        }

        /// <summary>
        /// This API is used to update a delivery target.
        /// </summary>
        /// <param name="req"><see cref="UpdateTargetRequest"/></param>
        /// <returns><see cref="UpdateTargetResponse"/></returns>
        public UpdateTargetResponse UpdateTargetSync(UpdateTargetRequest req)
        {
            return InternalRequestAsync<UpdateTargetResponse>(req, "UpdateTarget")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update a transformer.
        /// </summary>
        /// <param name="req"><see cref="UpdateTransformationRequest"/></param>
        /// <returns><see cref="UpdateTransformationResponse"/></returns>
        public Task<UpdateTransformationResponse> UpdateTransformation(UpdateTransformationRequest req)
        {
            return InternalRequestAsync<UpdateTransformationResponse>(req, "UpdateTransformation");
        }

        /// <summary>
        /// This API is used to update a transformer.
        /// </summary>
        /// <param name="req"><see cref="UpdateTransformationRequest"/></param>
        /// <returns><see cref="UpdateTransformationResponse"/></returns>
        public UpdateTransformationResponse UpdateTransformationSync(UpdateTransformationRequest req)
        {
            return InternalRequestAsync<UpdateTransformationResponse>(req, "UpdateTransformation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
