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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RiskCenterOverviewTrendAnalysis : AbstractModel
    {
        
        /// <summary>
        /// Date
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// Number of ports
        /// </summary>
        [JsonProperty("Port")]
        public long? Port{ get; set; }

        /// <summary>
        /// Number of vulnerabilities
        /// </summary>
        [JsonProperty("VUL")]
        public long? VUL{ get; set; }

        /// <summary>
        /// Weak Password Count
        /// </summary>
        [JsonProperty("WeakPassword")]
        public long? WeakPassword{ get; set; }

        /// <summary>
        /// Number of Websites
        /// </summary>
        [JsonProperty("Website")]
        public long? Website{ get; set; }

        /// <summary>
        /// Number of Configurations
        /// </summary>
        [JsonProperty("CFG")]
        public long? CFG{ get; set; }

        /// <summary>
        /// Mapping Risk Count
        /// </summary>
        [JsonProperty("Server")]
        public long? Server{ get; set; }

        /// <summary>
        /// Number of host risk configurations
        /// </summary>
        [JsonProperty("HostCFG")]
        public long? HostCFG{ get; set; }

        /// <summary>
        /// Number of risk configurations in the container baseline
        /// </summary>
        [JsonProperty("PodCFG")]
        public long? PodCFG{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "VUL", this.VUL);
            this.SetParamSimple(map, prefix + "WeakPassword", this.WeakPassword);
            this.SetParamSimple(map, prefix + "Website", this.Website);
            this.SetParamSimple(map, prefix + "CFG", this.CFG);
            this.SetParamSimple(map, prefix + "Server", this.Server);
            this.SetParamSimple(map, prefix + "HostCFG", this.HostCFG);
            this.SetParamSimple(map, prefix + "PodCFG", this.PodCFG);
        }
    }
}

