/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Gse.V20191112.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SearchGameServerSessionsRequest : AbstractModel
    {
        
        /// <summary>
        /// Alias ID
        /// </summary>
        [JsonProperty("AliasId")]
        public string AliasId{ get; set; }

        /// <summary>
        /// Fleet ID
        /// </summary>
        [JsonProperty("FleetId")]
        public string FleetId{ get; set; }

        /// <summary>
        /// Maximum number of entries in a single query
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Pagination offset, which is used for querying the next page. It should contain 1 to 1024 ASCII characters.
        /// </summary>
        [JsonProperty("NextToken")]
        public string NextToken{ get; set; }

        /// <summary>
        /// Search filter expression. Valid values:
        /// gameServerSessionName: game session name in `String` type
        /// gameServerSessionId: game session ID in `String` type
        /// maximumSessions: maximum number of player sessions in `Number` type
        /// creationTimeMillis: creation time in milliseconds in `Number` type
        /// playerSessionCount: current number of player sessions in `Number` type
        /// hasAvailablePlayerSessions: whether there is available player session in `String` type. Valid values: true, false
        /// gameServerSessionProperties: game session attributes in `String` type
        /// 
        /// Expressions in `String` type support = and <> for judgment
        /// Expressions in `Number` type support =, <>, >, >=, <, and <= for judgment
        /// 
        /// Example:
        /// If FilterExpression takes the value:
        /// playerSessionCount>=2 AND hasAvailablePlayerSessions=true"
        /// It means searching for game sessions that have at least two players and have player sessions available.
        /// If FilterExpression takes the value:
        /// gameServerSessionProperties.K1 = 'V1' AND gameServerSessionProperties.K2 = 'V2' OR gameServerSessionProperties.K3 = 'V3'
        /// 
        /// it means
        /// searching for game sessions that meets the following game server session attributes
        /// {
        ///     "GameProperties":[
        ///         {
        ///             "Key":"K1",
        ///             "Value":"V1"
        ///         },
        ///         {
        ///             "Key":"K2",
        ///             "Value":"V2"
        ///         },
        ///         {
        ///             "Key":"K3",
        ///             "Value":"V3"
        ///         }
        ///     ]
        /// }
        /// </summary>
        [JsonProperty("FilterExpression")]
        public string FilterExpression{ get; set; }

        /// <summary>
        /// Sorting keyword
        /// Valid values:
        /// gameServerSessionName: game session name in `String` type
        /// gameServerSessionId: game session ID in `String` type
        /// maximumSessions: maximum number of player sessions in `Number` type
        /// creationTimeMillis: creation time in milliseconds in `Number` type
        /// playerSessionCount: current number of player sessions in `Number` type
        /// </summary>
        [JsonProperty("SortExpression")]
        public string SortExpression{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AliasId", this.AliasId);
            this.SetParamSimple(map, prefix + "FleetId", this.FleetId);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "NextToken", this.NextToken);
            this.SetParamSimple(map, prefix + "FilterExpression", this.FilterExpression);
            this.SetParamSimple(map, prefix + "SortExpression", this.SortExpression);
        }
    }
}

