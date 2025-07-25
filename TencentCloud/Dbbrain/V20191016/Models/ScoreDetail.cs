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

namespace TencentCloud.Dbbrain.V20191016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScoreDetail : AbstractModel
    {
        
        /// <summary>
        /// Deduction item types. Valid values: availability, maintainability, performance, and reliability.
        /// </summary>
        [JsonProperty("IssueType")]
        public string IssueType{ get; set; }

        /// <summary>
        /// Total scores deducted.
        /// </summary>
        [JsonProperty("ScoreLost")]
        public long? ScoreLost{ get; set; }

        /// <summary>
        /// Upper limit of the deducted scores.
        /// </summary>
        [JsonProperty("ScoreLostMax")]
        public long? ScoreLostMax{ get; set; }

        /// <summary>
        /// Deduction item list.
        /// Note: `null` may be returned for this field, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Items")]
        public ScoreItem[] Items{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IssueType", this.IssueType);
            this.SetParamSimple(map, prefix + "ScoreLost", this.ScoreLost);
            this.SetParamSimple(map, prefix + "ScoreLostMax", this.ScoreLostMax);
            this.SetParamArrayObj(map, prefix + "Items.", this.Items);
        }
    }
}

