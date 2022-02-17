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

    public class TriggerAction : AbstractModel
    {
        
        /// <summary>
        /// Scheduled action name
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TriggerName")]
        public string TriggerName{ get; set; }

        /// <summary>
        /// Target provisioned concurrency of the scheduled scaling action 
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TriggerProvisionedConcurrencyNum")]
        public ulong? TriggerProvisionedConcurrencyNum{ get; set; }

        /// <summary>
        /// Trigger time of the scheduled action in Cron expression. Seven fields are required and should be separated with a space.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TriggerCronConfig")]
        public string TriggerCronConfig{ get; set; }

        /// <summary>
        /// The provision type. Value: `Default`
        /// Note: This field may return `null`, indicating that no valid value can be found.
        /// </summary>
        [JsonProperty("ProvisionedType")]
        public string ProvisionedType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TriggerName", this.TriggerName);
            this.SetParamSimple(map, prefix + "TriggerProvisionedConcurrencyNum", this.TriggerProvisionedConcurrencyNum);
            this.SetParamSimple(map, prefix + "TriggerCronConfig", this.TriggerCronConfig);
            this.SetParamSimple(map, prefix + "ProvisionedType", this.ProvisionedType);
        }
    }
}

