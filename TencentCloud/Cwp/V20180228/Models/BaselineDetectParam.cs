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

    public class BaselineDetectParam : AbstractModel
    {
        
        /// <summary>
        /// Collection of check policies
        /// </summary>
        [JsonProperty("PolicyIds")]
        public long?[] PolicyIds{ get; set; }

        /// <summary>
        /// Collection of check rules
        /// </summary>
        [JsonProperty("RuleIds")]
        public long?[] RuleIds{ get; set; }

        /// <summary>
        /// Collection of check items
        /// </summary>
        [JsonProperty("ItemIds")]
        public long?[] ItemIds{ get; set; }

        /// <summary>
        /// Collection of checked server IDs
        /// </summary>
        [JsonProperty("HostIds")]
        public string[] HostIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "PolicyIds.", this.PolicyIds);
            this.SetParamArraySimple(map, prefix + "RuleIds.", this.RuleIds);
            this.SetParamArraySimple(map, prefix + "ItemIds.", this.ItemIds);
            this.SetParamArraySimple(map, prefix + "HostIds.", this.HostIds);
        }
    }
}

