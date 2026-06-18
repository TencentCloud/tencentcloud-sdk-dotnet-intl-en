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

    public class DescribeSkillScanResultRequest : AbstractModel
    {
        
        /// <summary>
        /// SHA256 Hash of the ZIP file
        /// Parameter format: sha256:<64-bit hex>
        /// </summary>
        [JsonProperty("ContentHash")]
        public string ContentHash{ get; set; }

        /// <summary>
        /// Specify the engine version number
        /// Value for reference: API response of CreateSkillScan
        /// </summary>
        [JsonProperty("EngineVersion")]
        public long? EngineVersion{ get; set; }

        /// <summary>
        /// Report signature address validity
        /// Unit: hr
        /// Default value: 8760 (1 year).
        /// Supplementary explanation: The returned ReportURL takes effect.
        /// </summary>
        [JsonProperty("ReportURLExpireHours")]
        public long? ReportURLExpireHours{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ContentHash", this.ContentHash);
            this.SetParamSimple(map, prefix + "EngineVersion", this.EngineVersion);
            this.SetParamSimple(map, prefix + "ReportURLExpireHours", this.ReportURLExpireHours);
        }
    }
}

