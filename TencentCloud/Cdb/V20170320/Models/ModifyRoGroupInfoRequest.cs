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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyRoGroupInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// RO group ID.
        /// </summary>
        [JsonProperty("RoGroupId")]
        public string RoGroupId{ get; set; }

        /// <summary>
        /// RO group details.
        /// </summary>
        [JsonProperty("RoGroupInfo")]
        public RoGroupAttr RoGroupInfo{ get; set; }

        /// <summary>
        /// Weights of instances in RO group. If the weighting mode of an RO group is changed to custom mode, this parameter must be set, and a weight value needs to be set for each RO instance.
        /// </summary>
        [JsonProperty("RoWeightValues")]
        public RoWeightValue[] RoWeightValues{ get; set; }

        /// <summary>
        /// Whether to rebalance the loads of RO instances in the RO group. Supported values include `1` (yes) and `0` (no). The default value is `0`. Please note that if this value is set to `1`, connections to the RO instances in the RO group will be interrupted transiently; therefore, you should ensure that your application can reconnect to the databases.
        /// </summary>
        [JsonProperty("IsBalanceRoLoad")]
        public long? IsBalanceRoLoad{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoGroupId", this.RoGroupId);
            this.SetParamObj(map, prefix + "RoGroupInfo.", this.RoGroupInfo);
            this.SetParamArrayObj(map, prefix + "RoWeightValues.", this.RoWeightValues);
            this.SetParamSimple(map, prefix + "IsBalanceRoLoad", this.IsBalanceRoLoad);
        }
    }
}

