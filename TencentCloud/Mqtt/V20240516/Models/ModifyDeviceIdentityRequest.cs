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

namespace TencentCloud.Mqtt.V20240516.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDeviceIdentityRequest : AbstractModel
    {
        
        /// <summary>
        /// Tencent Cloud MQTT instance ID can be obtained from the [DescribeInstanceList](https://www.tencentcloud.com/document/api/1778/111029?from_cn_redirect=1) api or the console.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Device ID
        /// </summary>
        [JsonProperty("DeviceId")]
        public string DeviceId{ get; set; }

        /// <summary>
        /// 1:ENABLED-Available
        /// 2: DISABLED - Unavailable
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Primary signature key, Base64 encode is required.
        /// </summary>
        [JsonProperty("PrimaryKey")]
        public string PrimaryKey{ get; set; }

        /// <summary>
        /// Secondary signature key, must be Base64 encoded.
        /// </summary>
        [JsonProperty("SecondaryKey")]
        public string SecondaryKey{ get; set; }

        /// <summary>
        /// Device id spread attribute setting	
        /// </summary>
        [JsonProperty("PropagatingProperties")]
        public PropagatingProperty[] PropagatingProperties{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "DeviceId", this.DeviceId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "PrimaryKey", this.PrimaryKey);
            this.SetParamSimple(map, prefix + "SecondaryKey", this.SecondaryKey);
            this.SetParamArrayObj(map, prefix + "PropagatingProperties.", this.PropagatingProperties);
        }
    }
}

