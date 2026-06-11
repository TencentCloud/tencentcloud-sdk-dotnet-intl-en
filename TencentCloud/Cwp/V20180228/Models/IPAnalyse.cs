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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IPAnalyse : AbstractModel
    {
        
        /// <summary>
        /// 0: safe
        /// 1: Suspicious
        /// 2 Malicious
        /// 3 Unknown
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Tag feature
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// Family information
        /// </summary>
        [JsonProperty("Family")]
        public string[] Family{ get; set; }

        /// <summary>
        /// profile
        /// </summary>
        [JsonProperty("Profile")]
        public string[] Profile{ get; set; }

        /// <summary>
        /// Internet service provider.
        /// </summary>
        [JsonProperty("Isp")]
        public string Isp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
            this.SetParamArraySimple(map, prefix + "Family.", this.Family);
            this.SetParamArraySimple(map, prefix + "Profile.", this.Profile);
            this.SetParamSimple(map, prefix + "Isp", this.Isp);
        }
    }
}

