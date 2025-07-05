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

namespace TencentCloud.Apm.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApmAgentInfo : AbstractModel
    {
        
        /// <summary>
        /// Agent download address.
        /// </summary>
        [JsonProperty("AgentDownloadURL")]
        public string AgentDownloadURL{ get; set; }

        /// <summary>
        /// Collector reporting address.
        /// </summary>
        [JsonProperty("CollectorURL")]
        public string CollectorURL{ get; set; }

        /// <summary>
        /// Token information.
        /// </summary>
        [JsonProperty("Token")]
        public string Token{ get; set; }

        /// <summary>
        /// Public network reporting address.
        /// </summary>
        [JsonProperty("PublicCollectorURL")]
        public string PublicCollectorURL{ get; set; }

        /// <summary>
        /// Self-Developed vpc report address.
        /// </summary>
        [JsonProperty("InnerCollectorURL")]
        public string InnerCollectorURL{ get; set; }

        /// <summary>
        /// Private link reporting address.
        /// </summary>
        [JsonProperty("PrivateLinkCollectorURL")]
        public string PrivateLinkCollectorURL{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AgentDownloadURL", this.AgentDownloadURL);
            this.SetParamSimple(map, prefix + "CollectorURL", this.CollectorURL);
            this.SetParamSimple(map, prefix + "Token", this.Token);
            this.SetParamSimple(map, prefix + "PublicCollectorURL", this.PublicCollectorURL);
            this.SetParamSimple(map, prefix + "InnerCollectorURL", this.InnerCollectorURL);
            this.SetParamSimple(map, prefix + "PrivateLinkCollectorURL", this.PrivateLinkCollectorURL);
        }
    }
}

