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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StartInstanceRefreshRequest : AbstractModel
    {
        
        /// <summary>
        /// Scaling group ID.
        /// </summary>
        [JsonProperty("AutoScalingGroupId")]
        public string AutoScalingGroupId{ get; set; }

        /// <summary>
        /// Refresh settings.
        /// </summary>
        [JsonProperty("RefreshSettings")]
        public RefreshSettings RefreshSettings{ get; set; }

        /// <summary>
        /// Refresh mode. default value: ROLLING_UPDATE_RESET. valid values:.
        /// <Li>ROLLING_UPDATE_RESET: reinstall the system for rolling updates.</li>.
        /// <li>ROLLING_UPDATE_REPLACE: Create an instance and replace the old instance with it for rolling updates. This mode does not support the rollback API currently.</li>
        /// </summary>
        [JsonProperty("RefreshMode")]
        public string RefreshMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoScalingGroupId", this.AutoScalingGroupId);
            this.SetParamObj(map, prefix + "RefreshSettings.", this.RefreshSettings);
            this.SetParamSimple(map, prefix + "RefreshMode", this.RefreshMode);
        }
    }
}

