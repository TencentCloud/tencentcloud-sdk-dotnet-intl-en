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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RWInfos : AbstractModel
    {
        
        /// <summary>
        /// Number of instances in the proxy group
        /// Note: this field may return `null`, indicating that no valid value can be found.
        /// </summary>
        [JsonProperty("InstCount")]
        public ulong? InstCount{ get; set; }

        /// <summary>
        /// Assignment mode of read/write weights
        /// Valid values: `system` (auto-assigned), `custom`
        /// Note: this field may return `null`, indicating that no valid value can be found.
        /// </summary>
        [JsonProperty("WeightMode")]
        public string WeightMode{ get; set; }

        /// <summary>
        /// Whether to remove delayed read-only instances from the proxy group
        /// Note: this field may return `null`, indicating that no valid value can be found.
        /// </summary>
        [JsonProperty("IsKickOut")]
        public bool? IsKickOut{ get; set; }

        /// <summary>
        /// The minimum number of read-only instances allowed by the proxy group
        /// Note: this field may return `null`, indicating that no valid value can be found.
        /// </summary>
        [JsonProperty("MinCount")]
        public ulong? MinCount{ get; set; }

        /// <summary>
        /// Delay threshold
        /// Note: this field may return `null`, indicating that no valid value can be found.
        /// </summary>
        [JsonProperty("MaxDelay")]
        public ulong? MaxDelay{ get; set; }

        /// <summary>
        /// Whether to enable failover
        /// Note: this field may return `null`, indicating that no valid value can be found.
        /// </summary>
        [JsonProperty("FailOver")]
        public bool? FailOver{ get; set; }

        /// <summary>
        /// Whether to automatically add newly created read-only instances to the proxy group
        /// Note: this field may return `null`, indicating that no valid value can be found.
        /// </summary>
        [JsonProperty("AutoAddRo")]
        public bool? AutoAddRo{ get; set; }

        /// <summary>
        /// Information of instances in the proxy group
        /// Note: this field may return `null`, indicating that no valid value can be found.
        /// </summary>
        [JsonProperty("RWInstInfo")]
        public RWInstanceInfo[] RWInstInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstCount", this.InstCount);
            this.SetParamSimple(map, prefix + "WeightMode", this.WeightMode);
            this.SetParamSimple(map, prefix + "IsKickOut", this.IsKickOut);
            this.SetParamSimple(map, prefix + "MinCount", this.MinCount);
            this.SetParamSimple(map, prefix + "MaxDelay", this.MaxDelay);
            this.SetParamSimple(map, prefix + "FailOver", this.FailOver);
            this.SetParamSimple(map, prefix + "AutoAddRo", this.AutoAddRo);
            this.SetParamArrayObj(map, prefix + "RWInstInfo.", this.RWInstInfo);
        }
    }
}

