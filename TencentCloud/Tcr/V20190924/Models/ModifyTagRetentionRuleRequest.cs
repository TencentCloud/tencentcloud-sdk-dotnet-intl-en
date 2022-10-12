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

namespace TencentCloud.Tcr.V20190924.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyTagRetentionRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// Primary instance ID
        /// </summary>
        [JsonProperty("RegistryId")]
        public string RegistryId{ get; set; }

        /// <summary>
        /// ID of the original namespace
        /// </summary>
        [JsonProperty("NamespaceId")]
        public long? NamespaceId{ get; set; }

        /// <summary>
        /// Retention policy
        /// </summary>
        [JsonProperty("RetentionRule")]
        public RetentionRule RetentionRule{ get; set; }

        /// <summary>
        /// Original execution cycle
        /// </summary>
        [JsonProperty("CronSetting")]
        public string CronSetting{ get; set; }

        /// <summary>
        /// Rule ID
        /// </summary>
        [JsonProperty("RetentionId")]
        public long? RetentionId{ get; set; }

        /// <summary>
        /// Whether to disable the rule
        /// </summary>
        [JsonProperty("Disabled")]
        public bool? Disabled{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RegistryId", this.RegistryId);
            this.SetParamSimple(map, prefix + "NamespaceId", this.NamespaceId);
            this.SetParamObj(map, prefix + "RetentionRule.", this.RetentionRule);
            this.SetParamSimple(map, prefix + "CronSetting", this.CronSetting);
            this.SetParamSimple(map, prefix + "RetentionId", this.RetentionId);
            this.SetParamSimple(map, prefix + "Disabled", this.Disabled);
        }
    }
}

