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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Quota : AbstractModel
    {
        
        /// <summary>
        /// Quota name. Valid values:
        /// <li> TOTAL_OPEN_CLB_QUOTA: quota of public network CLB instances in the current region</li>
        /// <li> TOTAL_INTERNAL_CLB_QUOTA: quota of private network CLB instances in the current region</li>
        /// <li> TOTAL_LISTENER_QUOTA: quota of listeners under one CLB instance</li>
        /// <li> TOTAL_LISTENER_RULE_QUOTA: quota of forwarding rules under one listener</li>
        /// <li> TOTAL_TARGET_BIND_QUOTA: quota of CVM instances can be bound under one forwarding rule</li>
        /// </summary>
        [JsonProperty("QuotaId")]
        public string QuotaId{ get; set; }

        /// <summary>
        /// Currently used quantity. If it is `null`, it is meaningless.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("QuotaCurrent")]
        public long? QuotaCurrent{ get; set; }

        /// <summary>
        /// Quota limit.
        /// </summary>
        [JsonProperty("QuotaLimit")]
        public long? QuotaLimit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "QuotaId", this.QuotaId);
            this.SetParamSimple(map, prefix + "QuotaCurrent", this.QuotaCurrent);
            this.SetParamSimple(map, prefix + "QuotaLimit", this.QuotaLimit);
        }
    }
}

