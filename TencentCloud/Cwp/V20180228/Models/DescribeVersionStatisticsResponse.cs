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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeVersionStatisticsResponse : AbstractModel
    {
        
        /// <summary>
        /// Number of Basic editions
        /// </summary>
        [JsonProperty("BasicVersionNum")]
        public ulong? BasicVersionNum{ get; set; }

        /// <summary>
        /// Number of Professional editions
        /// </summary>
        [JsonProperty("ProVersionNum")]
        public ulong? ProVersionNum{ get; set; }

        /// <summary>
        /// Number of Ultimate editions
        /// </summary>
        [JsonProperty("UltimateVersionNum")]
        public ulong? UltimateVersionNum{ get; set; }

        /// <summary>
        /// Number of General Discount Editions
        /// </summary>
        [JsonProperty("GeneralVersionNum")]
        public ulong? GeneralVersionNum{ get; set; }

        /// <summary>
        /// The unique request ID, generated by the server, will be returned for every request (if the request fails to reach the server for other reasons, the request will not obtain a RequestId). RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BasicVersionNum", this.BasicVersionNum);
            this.SetParamSimple(map, prefix + "ProVersionNum", this.ProVersionNum);
            this.SetParamSimple(map, prefix + "UltimateVersionNum", this.UltimateVersionNum);
            this.SetParamSimple(map, prefix + "GeneralVersionNum", this.GeneralVersionNum);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}
