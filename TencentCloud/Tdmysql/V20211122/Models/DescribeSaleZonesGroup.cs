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

namespace TencentCloud.Tdmysql.V20211122.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSaleZonesGroup : AbstractModel
    {
        
        /// <summary>
        /// <p>Number of availability zones</p>
        /// </summary>
        [JsonProperty("ZoneNum")]
        public long? ZoneNum{ get; set; }

        /// <summary>
        /// <p>Availability zone combination</p>
        /// </summary>
        [JsonProperty("Zones")]
        public string[] Zones{ get; set; }

        /// <summary>
        /// <p>Supported types</p>
        /// </summary>
        [JsonProperty("SupportTypes")]
        public string[] SupportTypes{ get; set; }

        /// <summary>
        /// <p>Supported disk</p><p>Enumeration value:</p><ul><li>CLOUD_TCS: Local disk</li><li>CLOUD_HSSD: Enhanced cloud disk</li></ul>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AvailableDiskTypes")]
        public string[] AvailableDiskTypes{ get; set; }

        /// <summary>
        /// <p>Whether serverless is supported</p>
        /// </summary>
        [JsonProperty("IsSupportServerless")]
        public bool? IsSupportServerless{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneNum", this.ZoneNum);
            this.SetParamArraySimple(map, prefix + "Zones.", this.Zones);
            this.SetParamArraySimple(map, prefix + "SupportTypes.", this.SupportTypes);
            this.SetParamArraySimple(map, prefix + "AvailableDiskTypes.", this.AvailableDiskTypes);
            this.SetParamSimple(map, prefix + "IsSupportServerless", this.IsSupportServerless);
        }
    }
}

