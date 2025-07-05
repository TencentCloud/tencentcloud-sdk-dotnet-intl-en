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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ManualRewriteRequest : AbstractModel
    {
        
        /// <summary>
        /// CLB instance ID
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }

        /// <summary>
        /// Source listener ID
        /// </summary>
        [JsonProperty("SourceListenerId")]
        public string SourceListenerId{ get; set; }

        /// <summary>
        /// Target listener ID
        /// </summary>
        [JsonProperty("TargetListenerId")]
        public string TargetListenerId{ get; set; }

        /// <summary>
        /// Redirection relationship between forwarding rules
        /// </summary>
        [JsonProperty("RewriteInfos")]
        public RewriteLocationMap[] RewriteInfos{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LoadBalancerId", this.LoadBalancerId);
            this.SetParamSimple(map, prefix + "SourceListenerId", this.SourceListenerId);
            this.SetParamSimple(map, prefix + "TargetListenerId", this.TargetListenerId);
            this.SetParamArrayObj(map, prefix + "RewriteInfos.", this.RewriteInfos);
        }
    }
}

