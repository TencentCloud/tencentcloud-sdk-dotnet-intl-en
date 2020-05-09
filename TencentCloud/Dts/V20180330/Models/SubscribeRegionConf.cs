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

namespace TencentCloud.Dts.V20180330.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SubscribeRegionConf : AbstractModel
    {
        
        /// <summary>
        /// Region name, such as Guangzhou
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RegionName")]
        public string RegionName{ get; set; }

        /// <summary>
        /// Region ID, such as ap-guangzhou
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Region name, such as South China
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// Whether it is the default region. 0: no, 1: yes
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsDefaultRegion")]
        public long? IsDefaultRegion{ get; set; }

        /// <summary>
        /// Purchasable status of current region. 1: normal, 2: beta test, 3: not purchasable
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RegionName", this.RegionName);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "IsDefaultRegion", this.IsDefaultRegion);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

