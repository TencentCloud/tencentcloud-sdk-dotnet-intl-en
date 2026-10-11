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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NodeResource : AbstractModel
    {
        
        /// <summary>
        /// <p>Configuration ID.</p>
        /// </summary>
        [JsonProperty("ResourceConfigId")]
        public ulong? ResourceConfigId{ get; set; }

        /// <summary>
        /// <p>Resource</p>
        /// </summary>
        [JsonProperty("Resource")]
        public Resource Resource{ get; set; }

        /// <summary>
        /// <p>Creation time.</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>Update time.</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>Whether the default configuration applies. Valid values: DEFAULT and BACKUP.</p>
        /// </summary>
        [JsonProperty("IsDefault")]
        public string IsDefault{ get; set; }

        /// <summary>
        /// <p>Remaining of this type.</p>
        /// </summary>
        [JsonProperty("MaxResourceNum")]
        public ulong? MaxResourceNum{ get; set; }

        /// <summary>
        /// <p>Supported committed use duration.</p>
        /// </summary>
        [JsonProperty("PrepaidUnderwritePeriods")]
        public long?[] PrepaidUnderwritePeriods{ get; set; }

        /// <summary>
        /// <p>Number of quotas.</p>
        /// </summary>
        [JsonProperty("QuotaNum")]
        public long? QuotaNum{ get; set; }

        /// <summary>
        /// <p>Quota unit.</p>
        /// </summary>
        [JsonProperty("QuotaUnit")]
        public string QuotaUnit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceConfigId", this.ResourceConfigId);
            this.SetParamObj(map, prefix + "Resource.", this.Resource);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "IsDefault", this.IsDefault);
            this.SetParamSimple(map, prefix + "MaxResourceNum", this.MaxResourceNum);
            this.SetParamArraySimple(map, prefix + "PrepaidUnderwritePeriods.", this.PrepaidUnderwritePeriods);
            this.SetParamSimple(map, prefix + "QuotaNum", this.QuotaNum);
            this.SetParamSimple(map, prefix + "QuotaUnit", this.QuotaUnit);
        }
    }
}

