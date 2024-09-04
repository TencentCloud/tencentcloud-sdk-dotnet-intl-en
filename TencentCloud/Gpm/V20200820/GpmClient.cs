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

namespace TencentCloud.Gpm.V20200820
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Gpm.V20200820.Models;

   public class GpmClient : AbstractClient{

       private const string endpoint = "gpm.tencentcloudapi.com";
       private const string version = "2020-08-20";
       private const string sdkVersion = "SDK_NET_3.0.972";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public GpmClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public GpmClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to cancel matching.
        /// </summary>
        /// <param name="req"><see cref="CancelMatchingRequest"/></param>
        /// <returns><see cref="CancelMatchingResponse"/></returns>
        public Task<CancelMatchingResponse> CancelMatching(CancelMatchingRequest req)
        {
            return InternalRequestAsync<CancelMatchingResponse>(req, "CancelMatching");
        }

        /// <summary>
        /// This API is used to cancel matching.
        /// </summary>
        /// <param name="req"><see cref="CancelMatchingRequest"/></param>
        /// <returns><see cref="CancelMatchingResponse"/></returns>
        public CancelMatchingResponse CancelMatchingSync(CancelMatchingRequest req)
        {
            return InternalRequestAsync<CancelMatchingResponse>(req, "CancelMatching")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a match.
        /// </summary>
        /// <param name="req"><see cref="CreateMatchRequest"/></param>
        /// <returns><see cref="CreateMatchResponse"/></returns>
        public Task<CreateMatchResponse> CreateMatch(CreateMatchRequest req)
        {
            return InternalRequestAsync<CreateMatchResponse>(req, "CreateMatch");
        }

        /// <summary>
        /// This API is used to create a match.
        /// </summary>
        /// <param name="req"><see cref="CreateMatchRequest"/></param>
        /// <returns><see cref="CreateMatchResponse"/></returns>
        public CreateMatchResponse CreateMatchSync(CreateMatchRequest req)
        {
            return InternalRequestAsync<CreateMatchResponse>(req, "CreateMatch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a rule.
        /// </summary>
        /// <param name="req"><see cref="CreateRuleRequest"/></param>
        /// <returns><see cref="CreateRuleResponse"/></returns>
        public Task<CreateRuleResponse> CreateRule(CreateRuleRequest req)
        {
            return InternalRequestAsync<CreateRuleResponse>(req, "CreateRule");
        }

        /// <summary>
        /// This API is used to create a rule.
        /// </summary>
        /// <param name="req"><see cref="CreateRuleRequest"/></param>
        /// <returns><see cref="CreateRuleResponse"/></returns>
        public CreateRuleResponse CreateRuleSync(CreateRuleRequest req)
        {
            return InternalRequestAsync<CreateRuleResponse>(req, "CreateRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a match.
        /// </summary>
        /// <param name="req"><see cref="DeleteMatchRequest"/></param>
        /// <returns><see cref="DeleteMatchResponse"/></returns>
        public Task<DeleteMatchResponse> DeleteMatch(DeleteMatchRequest req)
        {
            return InternalRequestAsync<DeleteMatchResponse>(req, "DeleteMatch");
        }

        /// <summary>
        /// This API is used to delete a match.
        /// </summary>
        /// <param name="req"><see cref="DeleteMatchRequest"/></param>
        /// <returns><see cref="DeleteMatchResponse"/></returns>
        public DeleteMatchResponse DeleteMatchSync(DeleteMatchRequest req)
        {
            return InternalRequestAsync<DeleteMatchResponse>(req, "DeleteMatch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteRuleRequest"/></param>
        /// <returns><see cref="DeleteRuleResponse"/></returns>
        public Task<DeleteRuleResponse> DeleteRule(DeleteRuleRequest req)
        {
            return InternalRequestAsync<DeleteRuleResponse>(req, "DeleteRule");
        }

        /// <summary>
        /// This API is used to delete a rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteRuleRequest"/></param>
        /// <returns><see cref="DeleteRuleResponse"/></returns>
        public DeleteRuleResponse DeleteRuleSync(DeleteRuleRequest req)
        {
            return InternalRequestAsync<DeleteRuleResponse>(req, "DeleteRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to view statistics.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataRequest"/></param>
        /// <returns><see cref="DescribeDataResponse"/></returns>
        public Task<DescribeDataResponse> DescribeData(DescribeDataRequest req)
        {
            return InternalRequestAsync<DescribeDataResponse>(req, "DescribeData");
        }

        /// <summary>
        /// This API is used to view statistics.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataRequest"/></param>
        /// <returns><see cref="DescribeDataResponse"/></returns>
        public DescribeDataResponse DescribeDataSync(DescribeDataRequest req)
        {
            return InternalRequestAsync<DescribeDataResponse>(req, "DescribeData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the matchmaking details.
        /// </summary>
        /// <param name="req"><see cref="DescribeMatchRequest"/></param>
        /// <returns><see cref="DescribeMatchResponse"/></returns>
        public Task<DescribeMatchResponse> DescribeMatch(DescribeMatchRequest req)
        {
            return InternalRequestAsync<DescribeMatchResponse>(req, "DescribeMatch");
        }

        /// <summary>
        /// This API is used to query the matchmaking details.
        /// </summary>
        /// <param name="req"><see cref="DescribeMatchRequest"/></param>
        /// <returns><see cref="DescribeMatchResponse"/></returns>
        public DescribeMatchResponse DescribeMatchSync(DescribeMatchRequest req)
        {
            return InternalRequestAsync<DescribeMatchResponse>(req, "DescribeMatch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the created MatchCodes and paginate the query result.
        /// </summary>
        /// <param name="req"><see cref="DescribeMatchCodesRequest"/></param>
        /// <returns><see cref="DescribeMatchCodesResponse"/></returns>
        public Task<DescribeMatchCodesResponse> DescribeMatchCodes(DescribeMatchCodesRequest req)
        {
            return InternalRequestAsync<DescribeMatchCodesResponse>(req, "DescribeMatchCodes");
        }

        /// <summary>
        /// This API is used to query the created MatchCodes and paginate the query result.
        /// </summary>
        /// <param name="req"><see cref="DescribeMatchCodesRequest"/></param>
        /// <returns><see cref="DescribeMatchCodesResponse"/></returns>
        public DescribeMatchCodesResponse DescribeMatchCodesSync(DescribeMatchCodesRequest req)
        {
            return InternalRequestAsync<DescribeMatchCodesResponse>(req, "DescribeMatchCodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the matchmaking list and paginate the query result.
        /// </summary>
        /// <param name="req"><see cref="DescribeMatchesRequest"/></param>
        /// <returns><see cref="DescribeMatchesResponse"/></returns>
        public Task<DescribeMatchesResponse> DescribeMatches(DescribeMatchesRequest req)
        {
            return InternalRequestAsync<DescribeMatchesResponse>(req, "DescribeMatches");
        }

        /// <summary>
        /// This API is used to query the matchmaking list and paginate the query result.
        /// </summary>
        /// <param name="req"><see cref="DescribeMatchesRequest"/></param>
        /// <returns><see cref="DescribeMatchesResponse"/></returns>
        public DescribeMatchesResponse DescribeMatchesSync(DescribeMatchesRequest req)
        {
            return InternalRequestAsync<DescribeMatchesResponse>(req, "DescribeMatches")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the matching progress.
        /// </summary>
        /// <param name="req"><see cref="DescribeMatchingProgressRequest"/></param>
        /// <returns><see cref="DescribeMatchingProgressResponse"/></returns>
        public Task<DescribeMatchingProgressResponse> DescribeMatchingProgress(DescribeMatchingProgressRequest req)
        {
            return InternalRequestAsync<DescribeMatchingProgressResponse>(req, "DescribeMatchingProgress");
        }

        /// <summary>
        /// This API is used to query the matching progress.
        /// </summary>
        /// <param name="req"><see cref="DescribeMatchingProgressRequest"/></param>
        /// <returns><see cref="DescribeMatchingProgressResponse"/></returns>
        public DescribeMatchingProgressResponse DescribeMatchingProgressSync(DescribeMatchingProgressRequest req)
        {
            return InternalRequestAsync<DescribeMatchingProgressResponse>(req, "DescribeMatchingProgress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the rule details.
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleRequest"/></param>
        /// <returns><see cref="DescribeRuleResponse"/></returns>
        public Task<DescribeRuleResponse> DescribeRule(DescribeRuleRequest req)
        {
            return InternalRequestAsync<DescribeRuleResponse>(req, "DescribeRule");
        }

        /// <summary>
        /// This API is used to query the rule details.
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleRequest"/></param>
        /// <returns><see cref="DescribeRuleResponse"/></returns>
        public DescribeRuleResponse DescribeRuleSync(DescribeRuleRequest req)
        {
            return InternalRequestAsync<DescribeRuleResponse>(req, "DescribeRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the rule set list and paginate the query result.
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesRequest"/></param>
        /// <returns><see cref="DescribeRulesResponse"/></returns>
        public Task<DescribeRulesResponse> DescribeRules(DescribeRulesRequest req)
        {
            return InternalRequestAsync<DescribeRulesResponse>(req, "DescribeRules");
        }

        /// <summary>
        /// This API is used to query the rule set list and paginate the query result.
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesRequest"/></param>
        /// <returns><see cref="DescribeRulesResponse"/></returns>
        public DescribeRulesResponse DescribeRulesSync(DescribeRulesRequest req)
        {
            return InternalRequestAsync<DescribeRulesResponse>(req, "DescribeRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the token of a Matchcode, which is used for verified the pushed message.
        /// </summary>
        /// <param name="req"><see cref="DescribeTokenRequest"/></param>
        /// <returns><see cref="DescribeTokenResponse"/></returns>
        public Task<DescribeTokenResponse> DescribeToken(DescribeTokenRequest req)
        {
            return InternalRequestAsync<DescribeTokenResponse>(req, "DescribeToken");
        }

        /// <summary>
        /// This API is used to query the token of a Matchcode, which is used for verified the pushed message.
        /// </summary>
        /// <param name="req"><see cref="DescribeTokenRequest"/></param>
        /// <returns><see cref="DescribeTokenResponse"/></returns>
        public DescribeTokenResponse DescribeTokenSync(DescribeTokenRequest req)
        {
            return InternalRequestAsync<DescribeTokenResponse>(req, "DescribeToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a match.
        /// </summary>
        /// <param name="req"><see cref="ModifyMatchRequest"/></param>
        /// <returns><see cref="ModifyMatchResponse"/></returns>
        public Task<ModifyMatchResponse> ModifyMatch(ModifyMatchRequest req)
        {
            return InternalRequestAsync<ModifyMatchResponse>(req, "ModifyMatch");
        }

        /// <summary>
        /// This API is used to modify a match.
        /// </summary>
        /// <param name="req"><see cref="ModifyMatchRequest"/></param>
        /// <returns><see cref="ModifyMatchResponse"/></returns>
        public ModifyMatchResponse ModifyMatchSync(ModifyMatchRequest req)
        {
            return InternalRequestAsync<ModifyMatchResponse>(req, "ModifyMatch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a rule (including description and tag).
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleRequest"/></param>
        /// <returns><see cref="ModifyRuleResponse"/></returns>
        public Task<ModifyRuleResponse> ModifyRule(ModifyRuleRequest req)
        {
            return InternalRequestAsync<ModifyRuleResponse>(req, "ModifyRule");
        }

        /// <summary>
        /// This API is used to modify a rule (including description and tag).
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleRequest"/></param>
        /// <returns><see cref="ModifyRuleResponse"/></returns>
        public ModifyRuleResponse ModifyRuleSync(ModifyRuleRequest req)
        {
            return InternalRequestAsync<ModifyRuleResponse>(req, "ModifyRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the token of a Matchcode.
        /// </summary>
        /// <param name="req"><see cref="ModifyTokenRequest"/></param>
        /// <returns><see cref="ModifyTokenResponse"/></returns>
        public Task<ModifyTokenResponse> ModifyToken(ModifyTokenRequest req)
        {
            return InternalRequestAsync<ModifyTokenResponse>(req, "ModifyToken");
        }

        /// <summary>
        /// This API is used to modify the token of a Matchcode.
        /// </summary>
        /// <param name="req"><see cref="ModifyTokenRequest"/></param>
        /// <returns><see cref="ModifyTokenResponse"/></returns>
        public ModifyTokenResponse ModifyTokenSync(ModifyTokenRequest req)
        {
            return InternalRequestAsync<ModifyTokenResponse>(req, "ModifyToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to pass in one player or multiple players to initiate match. Players within the same request will be assigned to the same game session.
        /// </summary>
        /// <param name="req"><see cref="StartMatchingRequest"/></param>
        /// <returns><see cref="StartMatchingResponse"/></returns>
        public Task<StartMatchingResponse> StartMatching(StartMatchingRequest req)
        {
            return InternalRequestAsync<StartMatchingResponse>(req, "StartMatching");
        }

        /// <summary>
        /// This API is used to pass in one player or multiple players to initiate match. Players within the same request will be assigned to the same game session.
        /// </summary>
        /// <param name="req"><see cref="StartMatchingRequest"/></param>
        /// <returns><see cref="StartMatchingResponse"/></returns>
        public StartMatchingResponse StartMatchingSync(StartMatchingRequest req)
        {
            return InternalRequestAsync<StartMatchingResponse>(req, "StartMatching")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to send a match backfill request, for which a MatchTicket will be searched to start a new match.
        /// </summary>
        /// <param name="req"><see cref="StartMatchingBackfillRequest"/></param>
        /// <returns><see cref="StartMatchingBackfillResponse"/></returns>
        public Task<StartMatchingBackfillResponse> StartMatchingBackfill(StartMatchingBackfillRequest req)
        {
            return InternalRequestAsync<StartMatchingBackfillResponse>(req, "StartMatchingBackfill");
        }

        /// <summary>
        /// This API is used to send a match backfill request, for which a MatchTicket will be searched to start a new match.
        /// </summary>
        /// <param name="req"><see cref="StartMatchingBackfillRequest"/></param>
        /// <returns><see cref="StartMatchingBackfillResponse"/></returns>
        public StartMatchingBackfillResponse StartMatchingBackfillSync(StartMatchingBackfillRequest req)
        {
            return InternalRequestAsync<StartMatchingBackfillResponse>(req, "StartMatchingBackfill")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
