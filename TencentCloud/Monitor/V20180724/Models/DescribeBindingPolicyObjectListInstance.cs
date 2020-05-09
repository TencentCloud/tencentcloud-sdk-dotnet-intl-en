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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBindingPolicyObjectListInstance : AbstractModel
    {
        
        /// <summary>
        /// Unique ID of the object.
        /// </summary>
        [JsonProperty("UniqueId")]
        public string UniqueId{ get; set; }

        /// <summary>
        /// Dimension set of an object instance, which is a jsonObj string.
        /// </summary>
        [JsonProperty("Dimensions")]
        public string Dimensions{ get; set; }

        /// <summary>
        /// Whether the object is shielded. The value 0 indicates that the object is not shielded. The value 1 indicates that the object is shielded.
        /// </summary>
        [JsonProperty("IsShielded")]
        public long? IsShielded{ get; set; }

        /// <summary>
        /// Region where the object resides.
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UniqueId", this.UniqueId);
            this.SetParamSimple(map, prefix + "Dimensions", this.Dimensions);
            this.SetParamSimple(map, prefix + "IsShielded", this.IsShielded);
            this.SetParamSimple(map, prefix + "Region", this.Region);
        }
    }
}

