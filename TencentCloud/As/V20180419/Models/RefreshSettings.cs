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
        /// Whether to enable the backend service health check for the instance. Default value: FALSE. This parameter is valid only for the scaling group bound to an application-based CLB. After this feature is enabled, if the instance fails the check after refresh, the port weight of the CLB will be always 0, and it will be marked as a refresh failure. Valid values: <li>TRUE: enable;</li> <li>FALSE: disable.</li>
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

