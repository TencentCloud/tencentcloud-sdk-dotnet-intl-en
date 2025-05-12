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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProxyGroupRwInfo : AbstractModel
    {
        
        /// <summary>
        /// Consistency type. Valid values: `eventual` (eventual consistency), `session` (session consistency), `global` (global consistency).
        /// </summary>
        [JsonProperty("ConsistencyType")]
        public string ConsistencyType{ get; set; }

        /// <summary>
        /// Consistency timeout period
        /// </summary>
        [JsonProperty("ConsistencyTimeOut")]
        public long? ConsistencyTimeOut{ get; set; }

        /// <summary>
        /// Weight mode. Valid values: `system` (auto-assigned), `custom`.
        /// </summary>
        [JsonProperty("WeightMode")]
        public string WeightMode{ get; set; }

        /// <summary>
        /// Whether to enable failover
        /// </summary>
        [JsonProperty("FailOver")]
        public string FailOver{ get; set; }

        /// <summary>
        /// Whether to automatically add read-only instance. Valid value: `yes`, `no`.
        /// </summary>
        [JsonProperty("AutoAddRo")]
        public string AutoAddRo{ get; set; }

        /// <summary>
        /// Instance weight array
        /// </summary>
        [JsonProperty("InstanceWeights")]
        public ProxyInstanceWeight[] InstanceWeights{ get; set; }

        /// <summary>
        /// Whether to enable read-write nodes. valid values: yes, no.
        /// </summary>
        [JsonProperty("OpenRw")]
        public string OpenRw{ get; set; }

        /// <summary>
        /// Read/write attribute. Valid values: `READWRITE`, `READONLY`.
        /// </summary>
        [JsonProperty("RwType")]
        public string RwType{ get; set; }

        /// <summary>
        /// Transaction split
        /// </summary>
        [JsonProperty("TransSplit")]
        public bool? TransSplit{ get; set; }

        /// <summary>
        /// Connection mode. Valid values: `balance`, `nearby`.
        /// </summary>
        [JsonProperty("AccessMode")]
        public string AccessMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConsistencyType", this.ConsistencyType);
            this.SetParamSimple(map, prefix + "ConsistencyTimeOut", this.ConsistencyTimeOut);
            this.SetParamSimple(map, prefix + "WeightMode", this.WeightMode);
            this.SetParamSimple(map, prefix + "FailOver", this.FailOver);
            this.SetParamSimple(map, prefix + "AutoAddRo", this.AutoAddRo);
            this.SetParamArrayObj(map, prefix + "InstanceWeights.", this.InstanceWeights);
            this.SetParamSimple(map, prefix + "OpenRw", this.OpenRw);
            this.SetParamSimple(map, prefix + "RwType", this.RwType);
            this.SetParamSimple(map, prefix + "TransSplit", this.TransSplit);
            this.SetParamSimple(map, prefix + "AccessMode", this.AccessMode);
        }
    }
}

