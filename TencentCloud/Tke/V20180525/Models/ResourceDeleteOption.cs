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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ResourceDeleteOption : AbstractModel
    {
        
        /// <summary>
        /// Resource type, such as CBS, CLB, CVM
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// Deletion mode for CBS resources when the cluster is deleted: terminate, retain. Other resources are terminated by default.
        /// </summary>
        [JsonProperty("DeleteMode")]
        public string DeleteMode{ get; set; }

        /// <summary>
        /// Whether to skip the resources with deletion protection enabled. It is false by default. When set to true, the resources with deletion protection enabled are not cleaned up. CLB with terminal nodes also belongs to the resources with deletion protection enabled.
        /// </summary>
        [JsonProperty("SkipDeletionProtection")]
        public bool? SkipDeletionProtection{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "DeleteMode", this.DeleteMode);
            this.SetParamSimple(map, prefix + "SkipDeletionProtection", this.SkipDeletionProtection);
        }
    }
}

