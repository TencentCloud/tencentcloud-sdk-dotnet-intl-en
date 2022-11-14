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

    public class ModifyAssetScanRequest : AbstractModel
    {
        
        /// <summary>
        /// Scan range. 1: port; 2: port + vulnerability scan
        /// </summary>
        [JsonProperty("ScanRange")]
        public long? ScanRange{ get; set; }

        /// <summary>
        /// Scan mode: 'heavy', 'medium', 'light'
        /// </summary>
        [JsonProperty("ScanDeep")]
        public string ScanDeep{ get; set; }

        /// <summary>
        /// Scan type. 1: scan now; 2: periodic scan
        /// </summary>
        [JsonProperty("RangeType")]
        public long? RangeType{ get; set; }

        /// <summary>
        /// Scheduled task time, required when RangeType is 2
        /// </summary>
        [JsonProperty("ScanPeriod")]
        public string ScanPeriod{ get; set; }

        /// <summary>
        /// Scans this field now and passes the filtered IPs
        /// </summary>
        [JsonProperty("ScanFilterIp")]
        public string[] ScanFilterIp{ get; set; }

        /// <summary>
        /// 1: all; 2: single
        /// </summary>
        [JsonProperty("ScanType")]
        public long? ScanType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ScanRange", this.ScanRange);
            this.SetParamSimple(map, prefix + "ScanDeep", this.ScanDeep);
            this.SetParamSimple(map, prefix + "RangeType", this.RangeType);
            this.SetParamSimple(map, prefix + "ScanPeriod", this.ScanPeriod);
            this.SetParamArraySimple(map, prefix + "ScanFilterIp.", this.ScanFilterIp);
            this.SetParamSimple(map, prefix + "ScanType", this.ScanType);
        }
    }
}

