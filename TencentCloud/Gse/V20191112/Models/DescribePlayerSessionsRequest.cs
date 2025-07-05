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

    public class DescribePlayerSessionsRequest : AbstractModel
    {
        
        /// <summary>
        /// Game server session ID. It should contain 1 to 48 ASCII characters.
        /// </summary>
        [JsonProperty("GameServerSessionId")]
        public string GameServerSessionId{ get; set; }

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
        /// Player ID. It should contain 1 to 1024 ASCII characters.
        /// </summary>
        [JsonProperty("PlayerId")]
        public string PlayerId{ get; set; }

        /// <summary>
        /// Player session ID. It should contain 1 to 1024 ASCII characters.
        /// </summary>
        [JsonProperty("PlayerSessionId")]
        public string PlayerSessionId{ get; set; }

        /// <summary>
        /// Player session status. Valid values: RESERVED, ACTIVE, COMPLETED, TIMEDOUT
        /// </summary>
        [JsonProperty("PlayerSessionStatusFilter")]
        public string PlayerSessionStatusFilter{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GameServerSessionId", this.GameServerSessionId);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "NextToken", this.NextToken);
            this.SetParamSimple(map, prefix + "PlayerId", this.PlayerId);
            this.SetParamSimple(map, prefix + "PlayerSessionId", this.PlayerSessionId);
            this.SetParamSimple(map, prefix + "PlayerSessionStatusFilter", this.PlayerSessionStatusFilter);
        }
    }
}

