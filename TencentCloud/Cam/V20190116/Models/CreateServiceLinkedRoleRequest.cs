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

namespace TencentCloud.Cam.V20190116.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateServiceLinkedRoleRequest : AbstractModel
    {
        
        /// <summary>
        /// Authorized service, i.e., Tencent Cloud service entity with this role attached.
        /// </summary>
        [JsonProperty("QCSServiceName")]
        public string[] QCSServiceName{ get; set; }

        /// <summary>
        /// Custom suffix. A string you provide, which is combined with the service-provided prefix to form the complete role name.
        /// </summary>
        [JsonProperty("CustomSuffix")]
        public string CustomSuffix{ get; set; }

        /// <summary>
        /// Role description.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Tags bound to the role.
        /// </summary>
        [JsonProperty("Tags")]
        public RoleTags[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "QCSServiceName.", this.QCSServiceName);
            this.SetParamSimple(map, prefix + "CustomSuffix", this.CustomSuffix);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

