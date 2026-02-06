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

namespace TencentCloud.Tcsas.V20250106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeMNGPaymentRetentionAnalysisRequest : AbstractModel
    {
        
        /// <summary>
        /// Start time in YYYYMMDD format
        /// </summary>
        [JsonProperty("TimeBegin")]
        public long? TimeBegin{ get; set; }

        /// <summary>
        /// Mini program appid
        /// </summary>
        [JsonProperty("MNPId")]
        public string MNPId{ get; set; }

        /// <summary>
        /// Tenant ID
        /// </summary>
        [JsonProperty("PlatformId")]
        public string PlatformId{ get; set; }

        /// <summary>
        /// Type: 0 Non-production data, 1 Production data
        /// </summary>
        [JsonProperty("DataType")]
        public long? DataType{ get; set; }

        /// <summary>
        /// End time in YYYYMMDD format
        /// </summary>
        [JsonProperty("TimeEnd")]
        public long? TimeEnd{ get; set; }

        /// <summary>
        /// 0 All, 2-Android, 3 iOS
        /// </summary>
        [JsonProperty("Platform")]
        public long? Platform{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TimeBegin", this.TimeBegin);
            this.SetParamSimple(map, prefix + "MNPId", this.MNPId);
            this.SetParamSimple(map, prefix + "PlatformId", this.PlatformId);
            this.SetParamSimple(map, prefix + "DataType", this.DataType);
            this.SetParamSimple(map, prefix + "TimeEnd", this.TimeEnd);
            this.SetParamSimple(map, prefix + "Platform", this.Platform);
        }
    }
}

