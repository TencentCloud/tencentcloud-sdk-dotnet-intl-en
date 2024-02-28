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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RefreshSettings : AbstractModel
    {
        
        /// <summary>
        /// Rolling update settings parameters. RefreshMode is the rolling update. This parameter must be filled in.Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RollingUpdateSettings")]
        public RollingUpdateSettings RollingUpdateSettings{ get; set; }

        /// <summary>
        /// Backend service health check status for instances, defaults to FALSE. This setting takes effect only for scaling groups bound with application load balancers. When enabled, if an instance fails the check after being refreshed, its load balancer port weight remains 0 and is marked as a refresh failure. Valid values: <br><li>TRUE: Enable the check.</li> <li>FALSE: Do not enable the check.
        /// </summary>
        [JsonProperty("CheckInstanceTargetHealth")]
        public bool? CheckInstanceTargetHealth{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "RollingUpdateSettings.", this.RollingUpdateSettings);
            this.SetParamSimple(map, prefix + "CheckInstanceTargetHealth", this.CheckInstanceTargetHealth);
        }
    }
}

