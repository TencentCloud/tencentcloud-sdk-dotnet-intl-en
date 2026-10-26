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

namespace TencentCloud.Iss.V20230517.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BatchOperateDeviceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Device ID array (obtain from the device list API ListDevices)</p><p>For parameter values, see <a href="https://www.tencentcloud.com/document/api/1344/95871?from_cn_redirect=1">ListDevices</a></p>
        /// </summary>
        [JsonProperty("DeviceIds")]
        public string[] DeviceIds{ get; set; }

        /// <summary>
        /// <p>Operation command</p><p>Enumeration values:</p><ul><li>enable: Enable</li><li>disable: Disable</li><li>delete: Delete</li><li>sync: Synchronize device channel</li></ul>
        /// </summary>
        [JsonProperty("Cmd")]
        public string Cmd{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "DeviceIds.", this.DeviceIds);
            this.SetParamSimple(map, prefix + "Cmd", this.Cmd);
        }
    }
}

