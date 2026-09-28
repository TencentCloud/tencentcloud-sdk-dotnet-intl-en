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

namespace TencentCloud.Alb.V20251030.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LoadBalancerOperationLocksItem : AbstractModel
    {
        
        /// <summary>
        /// The causes for the lock. Valid when **LoadBalancerStatus** is **Abnormal**.
        /// </summary>
        [JsonProperty("LockReason")]
        public string LockReason{ get; set; }

        /// <summary>
        /// Lock type. Valid values:
        /// 
        /// - **SecurityLocked**: Security lock.
        /// 
        /// - **RelatedResourceLocked**: Related resource locked.
        /// 
        /// - **FinancialLocked**: Locked due to arrears.
        /// 
        /// - **ResidualLocked**: residual lock.
        /// </summary>
        [JsonProperty("LockType")]
        public string LockType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LockReason", this.LockReason);
            this.SetParamSimple(map, prefix + "LockType", this.LockType);
        }
    }
}

