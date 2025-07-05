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

namespace TencentCloud.Scf.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NamespaceUsage : AbstractModel
    {
        
        /// <summary>
        /// Function array
        /// </summary>
        [JsonProperty("Functions")]
        public string[] Functions{ get; set; }

        /// <summary>
        /// Namespace name
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// Number of functions in namespace
        /// </summary>
        [JsonProperty("FunctionsCount")]
        public long? FunctionsCount{ get; set; }

        /// <summary>
        /// Total memory quota of the namespace
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TotalConcurrencyMem")]
        public long? TotalConcurrencyMem{ get; set; }

        /// <summary>
        /// Concurrency usage of the namespace
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TotalAllocatedConcurrencyMem")]
        public long? TotalAllocatedConcurrencyMem{ get; set; }

        /// <summary>
        /// Provisioned concurrency usage of the namespace
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TotalAllocatedProvisionedMem")]
        public long? TotalAllocatedProvisionedMem{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Functions.", this.Functions);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "FunctionsCount", this.FunctionsCount);
            this.SetParamSimple(map, prefix + "TotalConcurrencyMem", this.TotalConcurrencyMem);
            this.SetParamSimple(map, prefix + "TotalAllocatedConcurrencyMem", this.TotalAllocatedConcurrencyMem);
            this.SetParamSimple(map, prefix + "TotalAllocatedProvisionedMem", this.TotalAllocatedProvisionedMem);
        }
    }
}

