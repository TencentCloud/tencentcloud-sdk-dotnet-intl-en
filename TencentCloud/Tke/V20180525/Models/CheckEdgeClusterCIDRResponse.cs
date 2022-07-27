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

    public class CheckEdgeClusterCIDRResponse : AbstractModel
    {
        
        /// <summary>
        /// Return code. Valid values:
        /// -1: Internal error
        /// 0: No conflict
        /// 1: Conflict between VPC and serviceCIDR
        /// 2: Conflict between VPC and podCIDR
        /// 3: Conflict between serviceCIDR and podCIDR
        /// </summary>
        [JsonProperty("ConflictCode")]
        public long? ConflictCode{ get; set; }

        /// <summary>
        /// CIDR block conflict description
        /// </summary>
        [JsonProperty("ConflictMsg")]
        public string ConflictMsg{ get; set; }

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
            this.SetParamSimple(map, prefix + "ConflictCode", this.ConflictCode);
            this.SetParamSimple(map, prefix + "ConflictMsg", this.ConflictMsg);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

