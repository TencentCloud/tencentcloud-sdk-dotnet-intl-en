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

namespace TencentCloud.Tcsas.V20250106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeMNPAppSecretResp : AbstractModel
    {
        
        /// <summary>
        /// <p>Mini program secret key status. Valid values: 0: Not generated; 1: Active; 2: Frozen; 3: Reset.</p>
        /// </summary>
        [JsonProperty("SecretStatus")]
        public long? SecretStatus{ get; set; }

        /// <summary>
        /// <p>Public service URL that developers need to access when integrating login, payment, and subscription message features.</p>
        /// </summary>
        [JsonProperty("OpenServerURL")]
        public string OpenServerURL{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SecretStatus", this.SecretStatus);
            this.SetParamSimple(map, prefix + "OpenServerURL", this.OpenServerURL);
        }
    }
}

