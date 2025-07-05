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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QualityScore : AbstractModel
    {
        
        /// <summary>
        /// Composite Score
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("CompositeScore")]
        public float? CompositeScore{ get; set; }

        /// <summary>
        /// Score Distribution
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ScoringDistribution")]
        public TableScoreStatisticsInfo[] ScoringDistribution{ get; set; }

        /// <summary>
        /// Total Number of Tables
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TotalTableNumber")]
        public long? TotalTableNumber{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CompositeScore", this.CompositeScore);
            this.SetParamArrayObj(map, prefix + "ScoringDistribution.", this.ScoringDistribution);
            this.SetParamSimple(map, prefix + "TotalTableNumber", this.TotalTableNumber);
        }
    }
}

