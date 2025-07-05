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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskCenterCFGRiskInputParam : AbstractModel
    {
        
        /// <summary>
        /// Check item ID
        /// </summary>
        [JsonProperty("ItemId")]
        public string ItemId{ get; set; }

        /// <summary>
        /// Whether to enable. `0`: no, `1`: yes.
        /// </summary>
        [JsonProperty("Enable")]
        public long? Enable{ get; set; }

        /// <summary>
        /// Resource type
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ItemId", this.ItemId);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
        }
    }
}

