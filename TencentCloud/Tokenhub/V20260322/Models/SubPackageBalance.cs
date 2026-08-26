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

namespace TencentCloud.Tokenhub.V20260322.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SubPackageBalance : AbstractModel
    {
        
        /// <summary>
        /// Dedicated limit. Units are as follows:
        /// -Package type: professional. Measurement unit: point.
        /// - Package type is lite package, and the measurement unit is token.
        /// </summary>
        [JsonProperty("ExclusiveQuota")]
        public string ExclusiveQuota{ get; set; }

        /// <summary>
        /// Used amount of the dedicated limit. The measurement units are as follows:
        /// -Package type: professional. Measurement unit: point.
        /// - Package type is lite package, and the measurement unit is token.
        /// </summary>
        [JsonProperty("ExclusiveUsed")]
        public string ExclusiveUsed{ get; set; }

        /// <summary>
        /// Remaining exclusive quota. Units are as follows:
        /// -Package type: professional. Measurement unit: point.
        /// -Package type: lite package. Measurement unit: token.
        /// </summary>
        [JsonProperty("ExclusiveRemain")]
        public string ExclusiveRemain{ get; set; }

        /// <summary>
        /// Shared credit limit. -1 means unlimited. Measurement units are as follows:
        /// -Package type is professional package, measurement unit value is point;
        /// -Package type: lite package. Measurement unit: token.
        /// </summary>
        [JsonProperty("SharedQuota")]
        public string SharedQuota{ get; set; }

        /// <summary>
        /// Used amount of the shared quota. Measurement units are as follows:
        /// -Package type is professional package, measurement unit value is point;
        /// -Package type: lite package. Measurement unit: token.
        /// </summary>
        [JsonProperty("SharedUsed")]
        public string SharedUsed{ get; set; }

        /// <summary>
        /// Remaining shared quota. Units are described as follows:
        /// -Package type is professional package, measurement unit value is point;
        /// -Package type: lite package. Measurement unit: token.
        /// </summary>
        [JsonProperty("SharedRemain")]
        public string SharedRemain{ get; set; }

        /// <summary>
        /// API Key package status. Valid values: 0 (normal), 1 (exhausted).
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ExclusiveQuota", this.ExclusiveQuota);
            this.SetParamSimple(map, prefix + "ExclusiveUsed", this.ExclusiveUsed);
            this.SetParamSimple(map, prefix + "ExclusiveRemain", this.ExclusiveRemain);
            this.SetParamSimple(map, prefix + "SharedQuota", this.SharedQuota);
            this.SetParamSimple(map, prefix + "SharedUsed", this.SharedUsed);
            this.SetParamSimple(map, prefix + "SharedRemain", this.SharedRemain);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

