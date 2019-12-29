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

namespace TencentCloud.Cam.V20190116.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListPoliciesResponse : AbstractModel
    {
        
        /// <summary>
        /// Total number of policies
        /// </summary>
        [JsonProperty("TotalNum")]
        public ulong? TotalNum{ get; set; }

        /// <summary>
        /// Policy array. Each item in the array has the fields `policyId`, `policyName`, `addTime`, `type`, `description`, and `createMode` 
        /// `policyId`: Policy ID 
        /// `policyName`: Policy name
        /// `addTime`: Time policy created
        /// `type`: 1 is custom policy; 2 is preset policy 
        /// `description`: Policy description 
        /// `createMode`: 1 indicates a policy created based on business permissions, while other values indicate that the policy syntax can be viewed and the policy can be updated using the policy syntax.
        /// </summary>
        [JsonProperty("List")]
        public StrategyInfo[] List{ get; set; }

        /// <summary>
        /// Reserved field
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("ServiceTypeList")]
        public string[] ServiceTypeList{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TotalNum", this.TotalNum);
            this.SetParamArrayObj(map, prefix + "List.", this.List);
            this.SetParamArraySimple(map, prefix + "ServiceTypeList.", this.ServiceTypeList);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

