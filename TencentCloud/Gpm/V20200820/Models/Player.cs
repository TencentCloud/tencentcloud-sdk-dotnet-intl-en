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

namespace TencentCloud.Gpm.V20200820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Player : AbstractModel
    {
        
        /// <summary>
        /// Player ID. It can contain up to 128 characters, supporting [a-zA-Z\d-\._]*.
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Player nickname. Up to 128 characters are allowed.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Player attribute for matching. Up to 10 attributes are supported.
        /// </summary>
        [JsonProperty("MatchAttributes")]
        public MatchAttribute[] MatchAttributes{ get; set; }

        /// <summary>
        /// Team name. A player can pass in a different team name, which can contain up to 128 characters, and support [a-zA-Z0-9-\.]*.
        /// </summary>
        [JsonProperty("Team")]
        public string Team{ get; set; }

        /// <summary>
        /// Custom player status. This parameter will be passed through. Value range: [0, 99999]
        /// </summary>
        [JsonProperty("CustomPlayerStatus")]
        public ulong? CustomPlayerStatus{ get; set; }

        /// <summary>
        /// Custom player information. Up to 1024 characters are allowed. This parameter will be passed through.
        /// </summary>
        [JsonProperty("CustomProfile")]
        public string CustomProfile{ get; set; }

        /// <summary>
        /// Number of delays in each area. Up to 20 delays are supported.
        /// </summary>
        [JsonProperty("RegionLatencies")]
        public RegionLatency[] RegionLatencies{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArrayObj(map, prefix + "MatchAttributes.", this.MatchAttributes);
            this.SetParamSimple(map, prefix + "Team", this.Team);
            this.SetParamSimple(map, prefix + "CustomPlayerStatus", this.CustomPlayerStatus);
            this.SetParamSimple(map, prefix + "CustomProfile", this.CustomProfile);
            this.SetParamArrayObj(map, prefix + "RegionLatencies.", this.RegionLatencies);
        }
    }
}

