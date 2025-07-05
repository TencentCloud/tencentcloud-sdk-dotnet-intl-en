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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SetNatFwDnatRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// 0: Create new; 1: Use existing
        /// </summary>
        [JsonProperty("Mode")]
        public ulong? Mode{ get; set; }

        /// <summary>
        /// Operation type. Valid values: add, del, and modify.
        /// </summary>
        [JsonProperty("OperationType")]
        public string OperationType{ get; set; }

        /// <summary>
        /// Firewall instance ID. This field is required.
        /// </summary>
        [JsonProperty("CfwInstance")]
        public string CfwInstance{ get; set; }

        /// <summary>
        /// List of added/deleted DNAT rules
        /// </summary>
        [JsonProperty("AddOrDelDnatRules")]
        public CfwNatDnatRule[] AddOrDelDnatRules{ get; set; }

        /// <summary>
        /// Original DNAT rule before change
        /// </summary>
        [JsonProperty("OriginDnat")]
        public CfwNatDnatRule OriginDnat{ get; set; }

        /// <summary>
        /// New DNAT rule after change
        /// </summary>
        [JsonProperty("NewDnat")]
        public CfwNatDnatRule NewDnat{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "OperationType", this.OperationType);
            this.SetParamSimple(map, prefix + "CfwInstance", this.CfwInstance);
            this.SetParamArrayObj(map, prefix + "AddOrDelDnatRules.", this.AddOrDelDnatRules);
            this.SetParamObj(map, prefix + "OriginDnat.", this.OriginDnat);
            this.SetParamObj(map, prefix + "NewDnat.", this.NewDnat);
        }
    }
}

