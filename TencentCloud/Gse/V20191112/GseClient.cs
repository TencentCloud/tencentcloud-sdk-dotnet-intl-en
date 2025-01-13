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

namespace TencentCloud.Gse.V20191112
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Gse.V20191112.Models;

   public class GseClient : AbstractClient{

       private const string endpoint = "gse.tencentcloudapi.com";
       private const string version = "2019-11-12";
       private const string sdkVersion = "SDK_NET_3.0.1053";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public GseClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public GseClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to replicate server fleet.
        /// </summary>
        /// <param name="req"><see cref="CopyFleetRequest"/></param>
        /// <returns><see cref="CopyFleetResponse"/></returns>
        public Task<CopyFleetResponse> CopyFleet(CopyFleetRequest req)
        {
            return InternalRequestAsync<CopyFleetResponse>(req, "CopyFleet");
        }

        /// <summary>
        /// This API is used to replicate server fleet.
        /// </summary>
        /// <param name="req"><see cref="CopyFleetRequest"/></param>
        /// <returns><see cref="CopyFleetResponse"/></returns>
        public CopyFleetResponse CopyFleetSync(CopyFleetRequest req)
        {
            return InternalRequestAsync<CopyFleetResponse>(req, "CopyFleet")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a game server session.
        /// </summary>
        /// <param name="req"><see cref="CreateGameServerSessionRequest"/></param>
        /// <returns><see cref="CreateGameServerSessionResponse"/></returns>
        public Task<CreateGameServerSessionResponse> CreateGameServerSession(CreateGameServerSessionRequest req)
        {
            return InternalRequestAsync<CreateGameServerSessionResponse>(req, "CreateGameServerSession");
        }

        /// <summary>
        /// This API is used to create a game server session.
        /// </summary>
        /// <param name="req"><see cref="CreateGameServerSessionRequest"/></param>
        /// <returns><see cref="CreateGameServerSessionResponse"/></returns>
        public CreateGameServerSessionResponse CreateGameServerSessionSync(CreateGameServerSessionRequest req)
        {
            return InternalRequestAsync<CreateGameServerSessionResponse>(req, "CreateGameServerSession")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DeleteTimerScalingPolicy) is used to delete a scheduled scaling policy of a fleet.
        /// </summary>
        /// <param name="req"><see cref="DeleteTimerScalingPolicyRequest"/></param>
        /// <returns><see cref="DeleteTimerScalingPolicyResponse"/></returns>
        public Task<DeleteTimerScalingPolicyResponse> DeleteTimerScalingPolicy(DeleteTimerScalingPolicyRequest req)
        {
            return InternalRequestAsync<DeleteTimerScalingPolicyResponse>(req, "DeleteTimerScalingPolicy");
        }

        /// <summary>
        /// This API (DeleteTimerScalingPolicy) is used to delete a scheduled scaling policy of a fleet.
        /// </summary>
        /// <param name="req"><see cref="DeleteTimerScalingPolicyRequest"/></param>
        /// <returns><see cref="DeleteTimerScalingPolicyResponse"/></returns>
        public DeleteTimerScalingPolicyResponse DeleteTimerScalingPolicySync(DeleteTimerScalingPolicyRequest req)
        {
            return InternalRequestAsync<DeleteTimerScalingPolicyResponse>(req, "DeleteTimerScalingPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of game server session details.
        /// </summary>
        /// <param name="req"><see cref="DescribeGameServerSessionDetailsRequest"/></param>
        /// <returns><see cref="DescribeGameServerSessionDetailsResponse"/></returns>
        public Task<DescribeGameServerSessionDetailsResponse> DescribeGameServerSessionDetails(DescribeGameServerSessionDetailsRequest req)
        {
            return InternalRequestAsync<DescribeGameServerSessionDetailsResponse>(req, "DescribeGameServerSessionDetails");
        }

        /// <summary>
        /// This API is used to query the list of game server session details.
        /// </summary>
        /// <param name="req"><see cref="DescribeGameServerSessionDetailsRequest"/></param>
        /// <returns><see cref="DescribeGameServerSessionDetailsResponse"/></returns>
        public DescribeGameServerSessionDetailsResponse DescribeGameServerSessionDetailsSync(DescribeGameServerSessionDetailsRequest req)
        {
            return InternalRequestAsync<DescribeGameServerSessionDetailsResponse>(req, "DescribeGameServerSessionDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the placement of a game server session.
        /// </summary>
        /// <param name="req"><see cref="DescribeGameServerSessionPlacementRequest"/></param>
        /// <returns><see cref="DescribeGameServerSessionPlacementResponse"/></returns>
        public Task<DescribeGameServerSessionPlacementResponse> DescribeGameServerSessionPlacement(DescribeGameServerSessionPlacementRequest req)
        {
            return InternalRequestAsync<DescribeGameServerSessionPlacementResponse>(req, "DescribeGameServerSessionPlacement");
        }

        /// <summary>
        /// This API is used to query the placement of a game server session.
        /// </summary>
        /// <param name="req"><see cref="DescribeGameServerSessionPlacementRequest"/></param>
        /// <returns><see cref="DescribeGameServerSessionPlacementResponse"/></returns>
        public DescribeGameServerSessionPlacementResponse DescribeGameServerSessionPlacementSync(DescribeGameServerSessionPlacementRequest req)
        {
            return InternalRequestAsync<DescribeGameServerSessionPlacementResponse>(req, "DescribeGameServerSessionPlacement")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of game server sessions.
        /// </summary>
        /// <param name="req"><see cref="DescribeGameServerSessionsRequest"/></param>
        /// <returns><see cref="DescribeGameServerSessionsResponse"/></returns>
        public Task<DescribeGameServerSessionsResponse> DescribeGameServerSessions(DescribeGameServerSessionsRequest req)
        {
            return InternalRequestAsync<DescribeGameServerSessionsResponse>(req, "DescribeGameServerSessions");
        }

        /// <summary>
        /// This API is used to query the list of game server sessions.
        /// </summary>
        /// <param name="req"><see cref="DescribeGameServerSessionsRequest"/></param>
        /// <returns><see cref="DescribeGameServerSessionsResponse"/></returns>
        public DescribeGameServerSessionsResponse DescribeGameServerSessionsSync(DescribeGameServerSessionsRequest req)
        {
            return InternalRequestAsync<DescribeGameServerSessionsResponse>(req, "DescribeGameServerSessions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of CVM types in the specified region.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceTypesRequest"/></param>
        /// <returns><see cref="DescribeInstanceTypesResponse"/></returns>
        public Task<DescribeInstanceTypesResponse> DescribeInstanceTypes(DescribeInstanceTypesRequest req)
        {
            return InternalRequestAsync<DescribeInstanceTypesResponse>(req, "DescribeInstanceTypes");
        }

        /// <summary>
        /// This API is used to obtain the list of CVM types in the specified region.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceTypesRequest"/></param>
        /// <returns><see cref="DescribeInstanceTypesResponse"/></returns>
        public DescribeInstanceTypesResponse DescribeInstanceTypesSync(DescribeInstanceTypesRequest req)
        {
            return InternalRequestAsync<DescribeInstanceTypesResponse>(req, "DescribeInstanceTypes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of player sessions.
        /// </summary>
        /// <param name="req"><see cref="DescribePlayerSessionsRequest"/></param>
        /// <returns><see cref="DescribePlayerSessionsResponse"/></returns>
        public Task<DescribePlayerSessionsResponse> DescribePlayerSessions(DescribePlayerSessionsRequest req)
        {
            return InternalRequestAsync<DescribePlayerSessionsResponse>(req, "DescribePlayerSessions");
        }

        /// <summary>
        /// This API is used to get the list of player sessions.
        /// </summary>
        /// <param name="req"><see cref="DescribePlayerSessionsRequest"/></param>
        /// <returns><see cref="DescribePlayerSessionsResponse"/></returns>
        public DescribePlayerSessionsResponse DescribePlayerSessionsSync(DescribePlayerSessionsRequest req)
        {
            return InternalRequestAsync<DescribePlayerSessionsResponse>(req, "DescribePlayerSessions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeTimerScalingPolicies) is used to query the scheduled scaling policies of a fleet. You can query the policies by `fleetID` or the fleet name. The returned results are paged. 
        /// </summary>
        /// <param name="req"><see cref="DescribeTimerScalingPoliciesRequest"/></param>
        /// <returns><see cref="DescribeTimerScalingPoliciesResponse"/></returns>
        public Task<DescribeTimerScalingPoliciesResponse> DescribeTimerScalingPolicies(DescribeTimerScalingPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeTimerScalingPoliciesResponse>(req, "DescribeTimerScalingPolicies");
        }

        /// <summary>
        /// This API (DescribeTimerScalingPolicies) is used to query the scheduled scaling policies of a fleet. You can query the policies by `fleetID` or the fleet name. The returned results are paged. 
        /// </summary>
        /// <param name="req"><see cref="DescribeTimerScalingPoliciesRequest"/></param>
        /// <returns><see cref="DescribeTimerScalingPoliciesResponse"/></returns>
        public DescribeTimerScalingPoliciesResponse DescribeTimerScalingPoliciesSync(DescribeTimerScalingPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeTimerScalingPoliciesResponse>(req, "DescribeTimerScalingPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to terminate the game server session and the corresponding process, which is applicable to time-limited protection and no protection.
        /// </summary>
        /// <param name="req"><see cref="EndGameServerSessionAndProcessRequest"/></param>
        /// <returns><see cref="EndGameServerSessionAndProcessResponse"/></returns>
        public Task<EndGameServerSessionAndProcessResponse> EndGameServerSessionAndProcess(EndGameServerSessionAndProcessRequest req)
        {
            return InternalRequestAsync<EndGameServerSessionAndProcessResponse>(req, "EndGameServerSessionAndProcess");
        }

        /// <summary>
        /// This API is used to terminate the game server session and the corresponding process, which is applicable to time-limited protection and no protection.
        /// </summary>
        /// <param name="req"><see cref="EndGameServerSessionAndProcessRequest"/></param>
        /// <returns><see cref="EndGameServerSessionAndProcessResponse"/></returns>
        public EndGameServerSessionAndProcessResponse EndGameServerSessionAndProcessSync(EndGameServerSessionAndProcessRequest req)
        {
            return InternalRequestAsync<EndGameServerSessionAndProcessResponse>(req, "EndGameServerSessionAndProcess")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the log URL of a game server session.
        /// </summary>
        /// <param name="req"><see cref="GetGameServerSessionLogUrlRequest"/></param>
        /// <returns><see cref="GetGameServerSessionLogUrlResponse"/></returns>
        public Task<GetGameServerSessionLogUrlResponse> GetGameServerSessionLogUrl(GetGameServerSessionLogUrlRequest req)
        {
            return InternalRequestAsync<GetGameServerSessionLogUrlResponse>(req, "GetGameServerSessionLogUrl");
        }

        /// <summary>
        /// This API is used to get the log URL of a game server session.
        /// </summary>
        /// <param name="req"><see cref="GetGameServerSessionLogUrlRequest"/></param>
        /// <returns><see cref="GetGameServerSessionLogUrlResponse"/></returns>
        public GetGameServerSessionLogUrlResponse GetGameServerSessionLogUrlSync(GetGameServerSessionLogUrlRequest req)
        {
            return InternalRequestAsync<GetGameServerSessionLogUrlResponse>(req, "GetGameServerSessionLogUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the credentials required for instance login.
        /// </summary>
        /// <param name="req"><see cref="GetInstanceAccessRequest"/></param>
        /// <returns><see cref="GetInstanceAccessResponse"/></returns>
        public Task<GetInstanceAccessResponse> GetInstanceAccess(GetInstanceAccessRequest req)
        {
            return InternalRequestAsync<GetInstanceAccessResponse>(req, "GetInstanceAccess");
        }

        /// <summary>
        /// This API is used to get the credentials required for instance login.
        /// </summary>
        /// <param name="req"><see cref="GetInstanceAccessRequest"/></param>
        /// <returns><see cref="GetInstanceAccessResponse"/></returns>
        public GetInstanceAccessResponse GetInstanceAccessSync(GetInstanceAccessRequest req)
        {
            return InternalRequestAsync<GetInstanceAccessResponse>(req, "GetInstanceAccess")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to join a game server session.
        /// </summary>
        /// <param name="req"><see cref="JoinGameServerSessionRequest"/></param>
        /// <returns><see cref="JoinGameServerSessionResponse"/></returns>
        public Task<JoinGameServerSessionResponse> JoinGameServerSession(JoinGameServerSessionRequest req)
        {
            return InternalRequestAsync<JoinGameServerSessionResponse>(req, "JoinGameServerSession");
        }

        /// <summary>
        /// This API is used to join a game server session.
        /// </summary>
        /// <param name="req"><see cref="JoinGameServerSessionRequest"/></param>
        /// <returns><see cref="JoinGameServerSessionResponse"/></returns>
        public JoinGameServerSessionResponse JoinGameServerSessionSync(JoinGameServerSessionRequest req)
        {
            return InternalRequestAsync<JoinGameServerSessionResponse>(req, "JoinGameServerSession")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to join game server sessions in batch.
        /// </summary>
        /// <param name="req"><see cref="JoinGameServerSessionBatchRequest"/></param>
        /// <returns><see cref="JoinGameServerSessionBatchResponse"/></returns>
        public Task<JoinGameServerSessionBatchResponse> JoinGameServerSessionBatch(JoinGameServerSessionBatchRequest req)
        {
            return InternalRequestAsync<JoinGameServerSessionBatchResponse>(req, "JoinGameServerSessionBatch");
        }

        /// <summary>
        /// This API is used to join game server sessions in batch.
        /// </summary>
        /// <param name="req"><see cref="JoinGameServerSessionBatchRequest"/></param>
        /// <returns><see cref="JoinGameServerSessionBatchResponse"/></returns>
        public JoinGameServerSessionBatchResponse JoinGameServerSessionBatchSync(JoinGameServerSessionBatchRequest req)
        {
            return InternalRequestAsync<JoinGameServerSessionBatchResponse>(req, "JoinGameServerSessionBatch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (PutTimerScalingPolicy) is used to create or update a scheduled scaling policy for a fleet.
        /// 
        /// If the field `timerID` is filled in, the specified policy will be updated, and if `timerID` is left empty, a new policy will be created.
        /// </summary>
        /// <param name="req"><see cref="PutTimerScalingPolicyRequest"/></param>
        /// <returns><see cref="PutTimerScalingPolicyResponse"/></returns>
        public Task<PutTimerScalingPolicyResponse> PutTimerScalingPolicy(PutTimerScalingPolicyRequest req)
        {
            return InternalRequestAsync<PutTimerScalingPolicyResponse>(req, "PutTimerScalingPolicy");
        }

        /// <summary>
        /// This API (PutTimerScalingPolicy) is used to create or update a scheduled scaling policy for a fleet.
        /// 
        /// If the field `timerID` is filled in, the specified policy will be updated, and if `timerID` is left empty, a new policy will be created.
        /// </summary>
        /// <param name="req"><see cref="PutTimerScalingPolicyRequest"/></param>
        /// <returns><see cref="PutTimerScalingPolicyResponse"/></returns>
        public PutTimerScalingPolicyResponse PutTimerScalingPolicySync(PutTimerScalingPolicyRequest req)
        {
            return InternalRequestAsync<PutTimerScalingPolicyResponse>(req, "PutTimerScalingPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to search in the list of game server sessions.
        /// </summary>
        /// <param name="req"><see cref="SearchGameServerSessionsRequest"/></param>
        /// <returns><see cref="SearchGameServerSessionsResponse"/></returns>
        public Task<SearchGameServerSessionsResponse> SearchGameServerSessions(SearchGameServerSessionsRequest req)
        {
            return InternalRequestAsync<SearchGameServerSessionsResponse>(req, "SearchGameServerSessions");
        }

        /// <summary>
        /// This API is used to search in the list of game server sessions.
        /// </summary>
        /// <param name="req"><see cref="SearchGameServerSessionsRequest"/></param>
        /// <returns><see cref="SearchGameServerSessionsResponse"/></returns>
        public SearchGameServerSessionsResponse SearchGameServerSessionsSync(SearchGameServerSessionsRequest req)
        {
            return InternalRequestAsync<SearchGameServerSessionsResponse>(req, "SearchGameServerSessions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (SetServerReserved) is used to mark the exceptional instances as retained for troubleshooting.
        /// 
        /// `ReserveValue`: specifies whether to retain the instance. Valid values: `0` (do not retain), `1` (retain). Default value: `0`.
        /// </summary>
        /// <param name="req"><see cref="SetServerReservedRequest"/></param>
        /// <returns><see cref="SetServerReservedResponse"/></returns>
        public Task<SetServerReservedResponse> SetServerReserved(SetServerReservedRequest req)
        {
            return InternalRequestAsync<SetServerReservedResponse>(req, "SetServerReserved");
        }

        /// <summary>
        /// This API (SetServerReserved) is used to mark the exceptional instances as retained for troubleshooting.
        /// 
        /// `ReserveValue`: specifies whether to retain the instance. Valid values: `0` (do not retain), `1` (retain). Default value: `0`.
        /// </summary>
        /// <param name="req"><see cref="SetServerReservedRequest"/></param>
        /// <returns><see cref="SetServerReservedResponse"/></returns>
        public SetServerReservedResponse SetServerReservedSync(SetServerReservedRequest req)
        {
            return InternalRequestAsync<SetServerReservedResponse>(req, "SetServerReserved")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to start placing a game server session.
        /// </summary>
        /// <param name="req"><see cref="StartGameServerSessionPlacementRequest"/></param>
        /// <returns><see cref="StartGameServerSessionPlacementResponse"/></returns>
        public Task<StartGameServerSessionPlacementResponse> StartGameServerSessionPlacement(StartGameServerSessionPlacementRequest req)
        {
            return InternalRequestAsync<StartGameServerSessionPlacementResponse>(req, "StartGameServerSessionPlacement");
        }

        /// <summary>
        /// This API is used to start placing a game server session.
        /// </summary>
        /// <param name="req"><see cref="StartGameServerSessionPlacementRequest"/></param>
        /// <returns><see cref="StartGameServerSessionPlacementResponse"/></returns>
        public StartGameServerSessionPlacementResponse StartGameServerSessionPlacementSync(StartGameServerSessionPlacementRequest req)
        {
            return InternalRequestAsync<StartGameServerSessionPlacementResponse>(req, "StartGameServerSessionPlacement")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to stop placing a game server session.
        /// </summary>
        /// <param name="req"><see cref="StopGameServerSessionPlacementRequest"/></param>
        /// <returns><see cref="StopGameServerSessionPlacementResponse"/></returns>
        public Task<StopGameServerSessionPlacementResponse> StopGameServerSessionPlacement(StopGameServerSessionPlacementRequest req)
        {
            return InternalRequestAsync<StopGameServerSessionPlacementResponse>(req, "StopGameServerSessionPlacement");
        }

        /// <summary>
        /// This API is used to stop placing a game server session.
        /// </summary>
        /// <param name="req"><see cref="StopGameServerSessionPlacementRequest"/></param>
        /// <returns><see cref="StopGameServerSessionPlacementResponse"/></returns>
        public StopGameServerSessionPlacementResponse StopGameServerSessionPlacementSync(StopGameServerSessionPlacementRequest req)
        {
            return InternalRequestAsync<StopGameServerSessionPlacementResponse>(req, "StopGameServerSessionPlacement")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (UpdateBucketAccelerateOpt) is used to enable COS global acceleration.
        /// </summary>
        /// <param name="req"><see cref="UpdateBucketAccelerateOptRequest"/></param>
        /// <returns><see cref="UpdateBucketAccelerateOptResponse"/></returns>
        public Task<UpdateBucketAccelerateOptResponse> UpdateBucketAccelerateOpt(UpdateBucketAccelerateOptRequest req)
        {
            return InternalRequestAsync<UpdateBucketAccelerateOptResponse>(req, "UpdateBucketAccelerateOpt");
        }

        /// <summary>
        /// This API (UpdateBucketAccelerateOpt) is used to enable COS global acceleration.
        /// </summary>
        /// <param name="req"><see cref="UpdateBucketAccelerateOptRequest"/></param>
        /// <returns><see cref="UpdateBucketAccelerateOptResponse"/></returns>
        public UpdateBucketAccelerateOptResponse UpdateBucketAccelerateOptSync(UpdateBucketAccelerateOptRequest req)
        {
            return InternalRequestAsync<UpdateBucketAccelerateOptResponse>(req, "UpdateBucketAccelerateOpt")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (UpdateBucketCORSOpt) is used to configure CORS for COS.
        /// </summary>
        /// <param name="req"><see cref="UpdateBucketCORSOptRequest"/></param>
        /// <returns><see cref="UpdateBucketCORSOptResponse"/></returns>
        public Task<UpdateBucketCORSOptResponse> UpdateBucketCORSOpt(UpdateBucketCORSOptRequest req)
        {
            return InternalRequestAsync<UpdateBucketCORSOptResponse>(req, "UpdateBucketCORSOpt");
        }

        /// <summary>
        /// This API (UpdateBucketCORSOpt) is used to configure CORS for COS.
        /// </summary>
        /// <param name="req"><see cref="UpdateBucketCORSOptRequest"/></param>
        /// <returns><see cref="UpdateBucketCORSOptResponse"/></returns>
        public UpdateBucketCORSOptResponse UpdateBucketCORSOptSync(UpdateBucketCORSOptRequest req)
        {
            return InternalRequestAsync<UpdateBucketCORSOptResponse>(req, "UpdateBucketCORSOpt")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update a game server session.
        /// </summary>
        /// <param name="req"><see cref="UpdateGameServerSessionRequest"/></param>
        /// <returns><see cref="UpdateGameServerSessionResponse"/></returns>
        public Task<UpdateGameServerSessionResponse> UpdateGameServerSession(UpdateGameServerSessionRequest req)
        {
            return InternalRequestAsync<UpdateGameServerSessionResponse>(req, "UpdateGameServerSession");
        }

        /// <summary>
        /// This API is used to update a game server session.
        /// </summary>
        /// <param name="req"><see cref="UpdateGameServerSessionRequest"/></param>
        /// <returns><see cref="UpdateGameServerSessionResponse"/></returns>
        public UpdateGameServerSessionResponse UpdateGameServerSessionSync(UpdateGameServerSessionRequest req)
        {
            return InternalRequestAsync<UpdateGameServerSessionResponse>(req, "UpdateGameServerSession")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
