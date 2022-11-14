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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyNatFwSwitchRequest : AbstractModel
    {
        
        /// <summary>
        /// Status. 0: off; 1: on
        /// </summary>
        [JsonProperty("Enable")]
        public long? Enable{ get; set; }

        /// <summary>
        /// List of firewall instance IDs. Only one of CfwInsIdList, SubnetIdList, and RouteTableIdList can be passed.
        /// </summary>
        [JsonProperty("CfwInsIdList")]
        public string[] CfwInsIdList{ get; set; }

        /// <summary>
        /// List of subnet IDs. Only one of CfwInsIdList, SubnetIdList, and RouteTableIdList can be passed.
        /// </summary>
        [JsonProperty("SubnetIdList")]
        public string[] SubnetIdList{ get; set; }

        /// <summary>
        /// List of route table IDs. Only one of CfwInsIdList, SubnetIdList, and RouteTableIdList can be passed.
        /// </summary>
        [JsonProperty("RouteTableIdList")]
        public string[] RouteTableIdList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamArraySimple(map, prefix + "CfwInsIdList.", this.CfwInsIdList);
            this.SetParamArraySimple(map, prefix + "SubnetIdList.", this.SubnetIdList);
            this.SetParamArraySimple(map, prefix + "RouteTableIdList.", this.RouteTableIdList);
        }
    }
}

