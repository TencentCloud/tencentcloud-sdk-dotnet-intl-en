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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSubnetAssetsResponse : AbstractModel
    {
        
        /// <summary>
        /// Data list
        /// </summary>
        [JsonProperty("Data")]
        public SubnetAsset[] Data{ get; set; }

        /// <summary>
        /// Total number of results
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

        /// <summary>
        /// List of regions
        /// </summary>
        [JsonProperty("RegionList")]
        public FilterDataObject[] RegionList{ get; set; }

        /// <summary>
        /// List of VPCs
        /// </summary>
        [JsonProperty("VpcList")]
        public FilterDataObject[] VpcList{ get; set; }

        /// <summary>
        /// List of AppIds
        /// </summary>
        [JsonProperty("AppIdList")]
        public FilterDataObject[] AppIdList{ get; set; }

        /// <summary>
        /// List of availability zones
        /// </summary>
        [JsonProperty("ZoneList")]
        public FilterDataObject[] ZoneList{ get; set; }

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
            this.SetParamArrayObj(map, prefix + "Data.", this.Data);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamArrayObj(map, prefix + "RegionList.", this.RegionList);
            this.SetParamArrayObj(map, prefix + "VpcList.", this.VpcList);
            this.SetParamArrayObj(map, prefix + "AppIdList.", this.AppIdList);
            this.SetParamArrayObj(map, prefix + "ZoneList.", this.ZoneList);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

