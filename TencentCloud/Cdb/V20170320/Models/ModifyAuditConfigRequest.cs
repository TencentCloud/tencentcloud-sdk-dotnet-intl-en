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

    public class ModifyAuditConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID, which can be obtained through the [DescribeDBInstances](https://www.tencentcloud.comom/document/product/236/15872?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Audit log retention period. Valid values:7 - One week;30 - One month;180 - Six months;365 - One year;1095 - Three years;1825 - Five years.
        /// </summary>
        [JsonProperty("LogExpireDay")]
        public long? LogExpireDay{ get; set; }

        /// <summary>
        /// Whether to disable the audit service. Valid values: true - Disable; false - Do not disable. Default value: false.Notes:1. When the audit service is disabled, your audit logs and files will be deleted, and all audit policies for this instance will be removed.2. At least one of CloseAudit and LogExpireDay must be provided. If both are provided, CloseAudit takes priority.3. You can use this parameter to disable the audit service. Once disabled, the audit service cannot be re-enabled via this API.
        /// </summary>
        [JsonProperty("CloseAudit")]
        public bool? CloseAudit{ get; set; }

        /// <summary>
        /// High-frequency audit log retention period. Valid values:7 - One week;30 - One month;180 - Six months;365 - One year;1095 - Three years;1825 - Five years.
        /// </summary>
        [JsonProperty("HighLogExpireDay")]
        public long? HighLogExpireDay{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "LogExpireDay", this.LogExpireDay);
            this.SetParamSimple(map, prefix + "CloseAudit", this.CloseAudit);
            this.SetParamSimple(map, prefix + "HighLogExpireDay", this.HighLogExpireDay);
        }
    }
}

