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

namespace TencentCloud.Scf.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UsageInfo : AbstractModel
    {
        
        /// <summary>
        /// Number of namespaces
        /// </summary>
        [JsonProperty("NamespacesCount")]
        public long? NamespacesCount{ get; set; }

        /// <summary>
        /// Namespace details
        /// </summary>
        [JsonProperty("Namespace")]
        public NamespaceUsage[] Namespace{ get; set; }

        /// <summary>
        /// Upper limit of user concurrency memory in the current region
        /// </summary>
        [JsonProperty("TotalConcurrencyMem")]
        public long? TotalConcurrencyMem{ get; set; }

        /// <summary>
        /// Quota of configured user concurrency memory in the current region
        /// </summary>
        [JsonProperty("TotalAllocatedConcurrencyMem")]
        public long? TotalAllocatedConcurrencyMem{ get; set; }

        /// <summary>
        /// Quota of account concurrency actually configured by user
        /// </summary>
        [JsonProperty("UserConcurrencyMemLimit")]
        public long? UserConcurrencyMemLimit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NamespacesCount", this.NamespacesCount);
            this.SetParamArrayObj(map, prefix + "Namespace.", this.Namespace);
            this.SetParamSimple(map, prefix + "TotalConcurrencyMem", this.TotalConcurrencyMem);
            this.SetParamSimple(map, prefix + "TotalAllocatedConcurrencyMem", this.TotalAllocatedConcurrencyMem);
            this.SetParamSimple(map, prefix + "UserConcurrencyMemLimit", this.UserConcurrencyMemLimit);
        }
    }
}

