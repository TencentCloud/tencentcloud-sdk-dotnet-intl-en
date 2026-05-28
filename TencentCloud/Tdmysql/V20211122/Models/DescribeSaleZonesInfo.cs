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

    public class DescribeSaleZonesInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>English string of Zone</p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>Zone Chinese character string</p>
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

        /// <summary>
        /// <p>Whether to sell, 1: sell; 0: do not sell</p>
        /// </summary>
        [JsonProperty("Enable")]
        public long? Enable{ get; set; }

        /// <summary>
        /// <p>Whether the default primary AZ is used. 0 means no, 1 means yes.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsDefaultMaster")]
        public long? IsDefaultMaster{ get; set; }

        /// <summary>
        /// <p>Selectable disk types in availability zones</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AvailableDiskTypes")]
        public string[] AvailableDiskTypes{ get; set; }

        /// <summary>
        /// <p>Whether it is an exclusive availability zone</p>
        /// </summary>
        [JsonProperty("SupportTypes")]
        public string[] SupportTypes{ get; set; }

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
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "ZoneName", this.ZoneName);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "IsDefaultMaster", this.IsDefaultMaster);
            this.SetParamArraySimple(map, prefix + "AvailableDiskTypes.", this.AvailableDiskTypes);
            this.SetParamArraySimple(map, prefix + "SupportTypes.", this.SupportTypes);
            this.SetParamSimple(map, prefix + "IsSupportServerless", this.IsSupportServerless);
        }
    }
}

