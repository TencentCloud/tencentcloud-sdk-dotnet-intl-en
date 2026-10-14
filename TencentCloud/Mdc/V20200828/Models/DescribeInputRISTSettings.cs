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

namespace TencentCloud.Mdc.V20200828.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInputRISTSettings : AbstractModel
    {
        
        /// <summary>
        /// RIST mode. Options: [LISTENER|CALLER]. Default value: LISTENER.
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// RIST configuration solution. Options: [MAIN|SIMPLE]. Default: MAIN.
        /// </summary>
        [JsonProperty("Profile")]
        public string Profile{ get; set; }

        /// <summary>
        /// RIST buffer size in milliseconds. Minimum value: 50 ms. Maximum value: 5000 ms. Default value: 120.
        /// </summary>
        [JsonProperty("Buffer")]
        public long? Buffer{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "Profile", this.Profile);
            this.SetParamSimple(map, prefix + "Buffer", this.Buffer);
        }
    }
}

