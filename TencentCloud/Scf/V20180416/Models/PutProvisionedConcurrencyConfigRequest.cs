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

    public class PutProvisionedConcurrencyConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// Name of the function for which to set the provisioned concurrency
        /// </summary>
        [JsonProperty("FunctionName")]
        public string FunctionName{ get; set; }

        /// <summary>
        /// Function version number. Note: the `$LATEST` version does not support provisioned concurrency
        /// </summary>
        [JsonProperty("Qualifier")]
        public string Qualifier{ get; set; }

        /// <summary>
        /// Provisioned concurrency amount. Note: there is an upper limit for the sum of provisioned concurrency amounts of all versions, which currently is the function's maximum concurrency quota minus 100
        /// </summary>
        [JsonProperty("VersionProvisionedConcurrencyNum")]
        public ulong? VersionProvisionedConcurrencyNum{ get; set; }

        /// <summary>
        /// Function namespace. Default value: `default`
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// Scheduled provisioned concurrency scaling action
        /// </summary>
        [JsonProperty("TriggerActions")]
        public TriggerAction[] TriggerActions{ get; set; }

        /// <summary>
        /// Specifies the provisioned concurrency type.
        /// `Default`: Static provisioned concurrency. 
        /// `ConcurrencyUtilizationTracking`: Scales the concurrency automatically according to the concurrency utilization.
        /// If `ConcurrencyUtilizationTracking` is passed in, 
        /// 
        /// `TrackingTarget`, `MinCapacity` and `MaxCapacity` are required, and `VersionProvisionedConcurrencyNum` must be `0`. 
        /// </summary>
        [JsonProperty("ProvisionedType")]
        public string ProvisionedType{ get; set; }

        /// <summary>
        /// The target concurrency utilization. Range: (0,1) (two decimal places)
        /// </summary>
        [JsonProperty("TrackingTarget")]
        public float? TrackingTarget{ get; set; }

        /// <summary>
        /// The minimum number of instances. It can not be smaller than `1`.
        /// </summary>
        [JsonProperty("MinCapacity")]
        public ulong? MinCapacity{ get; set; }

        /// <summary>
        /// The maximum number of instances
        /// </summary>
        [JsonProperty("MaxCapacity")]
        public ulong? MaxCapacity{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FunctionName", this.FunctionName);
            this.SetParamSimple(map, prefix + "Qualifier", this.Qualifier);
            this.SetParamSimple(map, prefix + "VersionProvisionedConcurrencyNum", this.VersionProvisionedConcurrencyNum);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamArrayObj(map, prefix + "TriggerActions.", this.TriggerActions);
            this.SetParamSimple(map, prefix + "ProvisionedType", this.ProvisionedType);
            this.SetParamSimple(map, prefix + "TrackingTarget", this.TrackingTarget);
            this.SetParamSimple(map, prefix + "MinCapacity", this.MinCapacity);
            this.SetParamSimple(map, prefix + "MaxCapacity", this.MaxCapacity);
        }
    }
}

