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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CacheParameters : AbstractModel
    {
        
        /// <summary>
        /// Cache follows the origin site. Leave unset means this configuration is not set. FollowOrigin, NoCache, and CustomTime can only be configured with one Switch set to on.
        /// </summary>
        [JsonProperty("FollowOrigin")]
        public FollowOrigin FollowOrigin{ get; set; }

        /// <summary>
        /// No cache. Leave unset means not setting this configuration. Only one Switch among FollowOrigin, NoCache, and CustomTime can be configured as on.
        /// </summary>
        [JsonProperty("NoCache")]
        public NoCache NoCache{ get; set; }

        /// <summary>
        /// Custom cache time. Leave unset means this configuration is not set. Only one of FollowOrigin, NoCache, and CustomTime can be configured with the Switch set to on.
        /// </summary>
        [JsonProperty("CustomTime")]
        public CustomTime CustomTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "FollowOrigin.", this.FollowOrigin);
            this.SetParamObj(map, prefix + "NoCache.", this.NoCache);
            this.SetParamObj(map, prefix + "CustomTime.", this.CustomTime);
        }
    }
}

