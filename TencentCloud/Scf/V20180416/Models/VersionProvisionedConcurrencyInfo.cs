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

    public class VersionProvisionedConcurrencyInfo : AbstractModel
    {
        
        /// <summary>
        /// Set provisioned concurrency amount.
        /// </summary>
        [JsonProperty("AllocatedProvisionedConcurrencyNum")]
        public ulong? AllocatedProvisionedConcurrencyNum{ get; set; }

        /// <summary>
        /// Currently available provisioned concurrency amount.
        /// </summary>
        [JsonProperty("AvailableProvisionedConcurrencyNum")]
        public ulong? AvailableProvisionedConcurrencyNum{ get; set; }

        /// <summary>
        /// Provisioned concurrency setting task status. `Done`: completed; `InProgress`: in progress; `Failed`: partially or completely failed.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Status description of provisioned concurrency setting task.
        /// </summary>
        [JsonProperty("StatusReason")]
        public string StatusReason{ get; set; }

        /// <summary>
        /// Function version number
        /// </summary>
        [JsonProperty("Qualifier")]
        public string Qualifier{ get; set; }

        /// <summary>
        /// List of scheduled provisioned concurrency scaling actions
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TriggerActions")]
        public TriggerAction[] TriggerActions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AllocatedProvisionedConcurrencyNum", this.AllocatedProvisionedConcurrencyNum);
            this.SetParamSimple(map, prefix + "AvailableProvisionedConcurrencyNum", this.AvailableProvisionedConcurrencyNum);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StatusReason", this.StatusReason);
            this.SetParamSimple(map, prefix + "Qualifier", this.Qualifier);
            this.SetParamArrayObj(map, prefix + "TriggerActions.", this.TriggerActions);
        }
    }
}

