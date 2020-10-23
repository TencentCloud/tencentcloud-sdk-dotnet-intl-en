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

namespace TencentCloud.Dayu.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSecIndexResponse : AbstractModel
    {
        
        /// <summary>
        /// Field value as follows:
        /// AttackIpCount: number of attacked IPs
        /// AttackCount: number of attacks
        /// BlockCount: number of blockings
        /// MaxMbps: attack bandwidth peak in Mbps
        /// IpNum: IP statistics
        /// </summary>
        [JsonProperty("Data")]
        public KeyValue[] Data{ get; set; }

        /// <summary>
        /// Start time of the current month
        /// </summary>
        [JsonProperty("BeginDate")]
        public string BeginDate{ get; set; }

        /// <summary>
        /// End time of the current month
        /// </summary>
        [JsonProperty("EndDate")]
        public string EndDate{ get; set; }

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
            this.SetParamArrayObj(map, prefix + "Data.", this.Data);
            this.SetParamSimple(map, prefix + "BeginDate", this.BeginDate);
            this.SetParamSimple(map, prefix + "EndDate", this.EndDate);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

