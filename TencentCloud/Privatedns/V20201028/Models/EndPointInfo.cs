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

namespace TencentCloud.Privatedns.V20201028.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EndPointInfo : AbstractModel
    {
        
        /// <summary>
        /// Endpoint ID.
        /// </summary>
        [JsonProperty("EndPointId")]
        public string EndPointId{ get; set; }

        /// <summary>
        /// Endpoint name.
        /// </summary>
        [JsonProperty("EndPointName")]
        public string EndPointName{ get; set; }

        /// <summary>
        /// Endpoint service ID.
        /// </summary>
        [JsonProperty("EndPointServiceId")]
        public string EndPointServiceId{ get; set; }

        /// <summary>
        /// VIP list of the endpoint.
        /// </summary>
        [JsonProperty("EndPointVipSet")]
        public string[] EndPointVipSet{ get; set; }

        /// <summary>
        /// ap-guangzhou
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RegionCode")]
        public string RegionCode{ get; set; }

        /// <summary>
        /// Tag key-value pair collection.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EndPointId", this.EndPointId);
            this.SetParamSimple(map, prefix + "EndPointName", this.EndPointName);
            this.SetParamSimple(map, prefix + "EndPointServiceId", this.EndPointServiceId);
            this.SetParamArraySimple(map, prefix + "EndPointVipSet.", this.EndPointVipSet);
            this.SetParamSimple(map, prefix + "RegionCode", this.RegionCode);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

