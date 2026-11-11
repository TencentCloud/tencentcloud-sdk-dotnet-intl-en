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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyValkeyModuleRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Specifies the instance ID. Example: crs-xjhsdj****. Log in to the <a href="https://console.cloud.tencent.com/redis">Redis console</a> and copy the instance ID from the instance list.</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Specify the extension module to be modified.</p><p>Enumeration values:</p><ul><li>ValkeyBloom: Refers to the Bloom module, which can efficiently judge whether an element exists in a collection.</li><li>ValkeyJSON: Refers to the JSON module, which allows Redis to natively support the JSON data format, facilitating the storage and manipulation of JSON Objects.</li><li>ValkeySearch: Refers to the Search module, which provides a full-text search feature, enabling efficient search operations on data stored in Redis.</li></ul>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Set the enable status of the extension module. Only support setting to ON to enable the extension module.</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

