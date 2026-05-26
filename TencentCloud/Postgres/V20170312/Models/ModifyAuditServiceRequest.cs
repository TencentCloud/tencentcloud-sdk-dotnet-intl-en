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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAuditServiceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Instance ID</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Log retention duration (days)</p><p>Enumeration value:</p><ul><li>7: 7 days</li><li>30: 30 days</li><li>90: 90 days</li><li>180: 180 days</li><li>365: 365 days</li><li>1095: 1095 days</li><li>1825: 1825 days</li></ul>
        /// </summary>
        [JsonProperty("LogExpireDay")]
        public ulong? LogExpireDay{ get; set; }

        /// <summary>
        /// <p>High-frequency storage duration (days)</p><p>Enumeration value:</p><ul><li>7: 7 days</li><li>30: 30 days</li><li>90: 90 days</li><li>180: 180 days</li><li>365: 365 days</li><li>1095: 1095 days</li><li>1825: 1825 days</li></ul>
        /// </summary>
        [JsonProperty("HotLogExpireDay")]
        public ulong? HotLogExpireDay{ get; set; }

        /// <summary>
        /// <p>Audit type</p><p>Enumeration value:</p><ul><li>complex: Granular audit. The audit log is more comprehensive, including object types and objects. Once enabled, it has a certain impact on performance.</li><li>simple: Fast Audit. The audit log covers most fields. When enabled, it has a smaller impact on performance.</li></ul>
        /// </summary>
        [JsonProperty("AuditType")]
        public string AuditType{ get; set; }

        /// <summary>
        /// <p>Product name</p><p>Input parameter limit: postgres</p>
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "LogExpireDay", this.LogExpireDay);
            this.SetParamSimple(map, prefix + "HotLogExpireDay", this.HotLogExpireDay);
            this.SetParamSimple(map, prefix + "AuditType", this.AuditType);
            this.SetParamSimple(map, prefix + "Product", this.Product);
        }
    }
}

