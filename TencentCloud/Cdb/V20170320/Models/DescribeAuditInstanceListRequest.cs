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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAuditInstanceListRequest : AbstractModel
    {
        
        /// <summary>
        /// Whether audit is enabled for the instance. Valid values: 1 - Enabled; 0 - Disabled.
        /// </summary>
        [JsonProperty("AuditSwitch")]
        public long? AuditSwitch{ get; set; }

        /// <summary>
        /// Filter conditions for querying the instance list.
        /// </summary>
        [JsonProperty("Filters")]
        public AuditInstanceFilters[] Filters{ get; set; }

        /// <summary>
        /// Audit rule mode for the instance. Valid values: 1 - Rule-based audit; 0 - Full audit.
        /// </summary>
        [JsonProperty("AuditMode")]
        public long? AuditMode{ get; set; }

        /// <summary>
        /// Number of entries to return per request. Default value: 30. Maximum value: 20000.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Offset. Default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AuditSwitch", this.AuditSwitch);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "AuditMode", this.AuditMode);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
        }
    }
}

