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

    public class DescribeBindingPolicyObjectListResponse : AbstractModel
    {
        
        /// <summary>
        /// List of bound object instances.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("List")]
        public DescribeBindingPolicyObjectListInstance[] List{ get; set; }

        /// <summary>
        /// Total number of bound object instances.
        /// </summary>
        [JsonProperty("Total")]
        public long? Total{ get; set; }

        /// <summary>
        /// Number of object instances that are not shielded.
        /// </summary>
        [JsonProperty("NoShieldedSum")]
        public long? NoShieldedSum{ get; set; }

        /// <summary>
        /// Bound instance group information. This parameter is not configured if no instance group is bound.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("InstanceGroup")]
        public DescribeBindingPolicyObjectListInstanceGroup InstanceGroup{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "List.", this.List);
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamSimple(map, prefix + "NoShieldedSum", this.NoShieldedSum);
            this.SetParamObj(map, prefix + "InstanceGroup.", this.InstanceGroup);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

