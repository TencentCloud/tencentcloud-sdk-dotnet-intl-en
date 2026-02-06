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

    public class MAUIndicatorCard : AbstractModel
    {
        
        /// <summary>
        /// Growth rate (targetData - sourceData) / sourceData, returns 0 when SourceMAUNum is 0
        /// </summary>
        [JsonProperty("ComparisonRatio")]
        public string ComparisonRatio{ get; set; }

        /// <summary>
        /// 1 Increase
        /// 2 Decrease
        /// Returns 0 when SourceMAUNum is 0
        /// </summary>
        [JsonProperty("ComparisonResult")]
        public long? ComparisonResult{ get; set; }

        /// <summary>
        /// Last month's MAU data
        /// </summary>
        [JsonProperty("SourceMAUNum")]
        public long? SourceMAUNum{ get; set; }

        /// <summary>
        /// This month's MAU data
        /// </summary>
        [JsonProperty("TargetMAUNum")]
        public long? TargetMAUNum{ get; set; }

        /// <summary>
        /// Data timestamp
        /// </summary>
        [JsonProperty("FlushTime")]
        public long? FlushTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ComparisonRatio", this.ComparisonRatio);
            this.SetParamSimple(map, prefix + "ComparisonResult", this.ComparisonResult);
            this.SetParamSimple(map, prefix + "SourceMAUNum", this.SourceMAUNum);
            this.SetParamSimple(map, prefix + "TargetMAUNum", this.TargetMAUNum);
            this.SetParamSimple(map, prefix + "FlushTime", this.FlushTime);
        }
    }
}

