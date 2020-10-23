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

    public class DescribeBindingPolicyObjectListRequest : AbstractModel
    {
        
        /// <summary>
        /// The value is fixed to monitor.
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// Policy group ID.
        /// </summary>
        [JsonProperty("GroupId")]
        public long? GroupId{ get; set; }

        /// <summary>
        /// Number of parameters that can be returned on each page. Value range: 1 - 100. Default value: 20.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Parameter offset on each page. The value starts from 0 and the default value is 0.
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Dimensions of filtering objects.
        /// </summary>
        [JsonProperty("Dimensions")]
        public DescribeBindingPolicyObjectListDimension[] Dimensions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamArrayObj(map, prefix + "Dimensions.", this.Dimensions);
        }
    }
}

