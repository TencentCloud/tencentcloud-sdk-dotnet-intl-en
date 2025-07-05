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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyBotStatusRequest : AbstractModel
    {
        
        /// <summary>
        /// Category
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Domain name
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Instance ID
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

        /// <summary>
        /// Whether it is the bot 4.0 version
        /// </summary>
        [JsonProperty("IsVersionFour")]
        public bool? IsVersionFour{ get; set; }

        /// <summary>
        /// Enter the bot version number, scenario-based version: 4.1.0
        /// </summary>
        [JsonProperty("BotVersion")]
        public string BotVersion{ get; set; }

        /// <summary>
        /// List of domain names on which bot detection is to be enabled or disabled in batch
        /// </summary>
        [JsonProperty("DomainList")]
        public string[] DomainList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
            this.SetParamSimple(map, prefix + "IsVersionFour", this.IsVersionFour);
            this.SetParamSimple(map, prefix + "BotVersion", this.BotVersion);
            this.SetParamArraySimple(map, prefix + "DomainList.", this.DomainList);
        }
    }
}

