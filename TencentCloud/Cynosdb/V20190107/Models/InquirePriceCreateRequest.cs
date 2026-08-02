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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InquirePriceCreateRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Availability zone, each region provision best practice</p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>Number of compute nodes to purchase</p>
        /// </summary>
        [JsonProperty("GoodsNum")]
        public long? GoodsNum{ get; set; }

        /// <summary>
        /// <p>Instance purchase type, optional values: PREPAID, POSTPAID, SERVERLESS</p>
        /// </summary>
        [JsonProperty("InstancePayMode")]
        public string InstancePayMode{ get; set; }

        /// <summary>
        /// <p>Storage purchase type, optional values: PREPAID, POSTPAID</p>
        /// </summary>
        [JsonProperty("StoragePayMode")]
        public string StoragePayMode{ get; set; }

        /// <summary>
        /// <p>Instance device type. Supported values are as follows:</p><ul><li>common: refers to universal type</li><li>exclusive: refers to dedicated type</li></ul>
        /// </summary>
        [JsonProperty("DeviceType")]
        public string DeviceType{ get; set; }

        /// <summary>
        /// <p>Number of CPU cores. Required for PREPAID and POSTPAID instance types.</p>
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// <p>Memory size in GB. Required for PREPAID and POSTPAID instance types.</p>
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// <p>Ccu size. Required for the serverless type.</p>
        /// </summary>
        [JsonProperty("Ccu")]
        public float? Ccu{ get; set; }

        /// <summary>
        /// <p>Storage size. Required for PREPAID storage type</p>
        /// </summary>
        [JsonProperty("StorageLimit")]
        public long? StorageLimit{ get; set; }

        /// <summary>
        /// <p>Purchase period, required for PREPAID purchase type</p>
        /// </summary>
        [JsonProperty("TimeSpan")]
        public long? TimeSpan{ get; set; }

        /// <summary>
        /// <p>Duration unit. Optional values: m, d. Required for PREPAID purchase type.</p>
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// <p>Storage architecture type. Enumeration value: 1.0/2.0 Default value: 1.0</p>
        /// </summary>
        [JsonProperty("StorageVersion")]
        public string StorageVersion{ get; set; }

        /// <summary>
        /// <p>Whether storage spans AZs. Valid for storage architecture 2.0</p>
        /// </summary>
        [JsonProperty("IsMultiAz")]
        public bool? IsMultiAz{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "GoodsNum", this.GoodsNum);
            this.SetParamSimple(map, prefix + "InstancePayMode", this.InstancePayMode);
            this.SetParamSimple(map, prefix + "StoragePayMode", this.StoragePayMode);
            this.SetParamSimple(map, prefix + "DeviceType", this.DeviceType);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Ccu", this.Ccu);
            this.SetParamSimple(map, prefix + "StorageLimit", this.StorageLimit);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "TimeUnit", this.TimeUnit);
            this.SetParamSimple(map, prefix + "StorageVersion", this.StorageVersion);
            this.SetParamSimple(map, prefix + "IsMultiAz", this.IsMultiAz);
        }
    }
}

