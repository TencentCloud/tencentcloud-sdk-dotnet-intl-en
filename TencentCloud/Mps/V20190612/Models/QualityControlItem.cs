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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QualityControlItem : AbstractModel
    {
        
        /// <summary>
        /// The confidence score. Value range: 0-100.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Confidence")]
        public long? Confidence{ get; set; }

        /// <summary>
        /// The start timestamp (second) of the segment.
        /// </summary>
        [JsonProperty("StartTimeOffset")]
        public float? StartTimeOffset{ get; set; }

        /// <summary>
        /// The end timestamp (second) of the segment.
        /// </summary>
        [JsonProperty("EndTimeOffset")]
        public float? EndTimeOffset{ get; set; }

        /// <summary>
        /// The coordinates (px) of the top left and bottom right corner.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AreaCoordSet")]
        public long?[] AreaCoordSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
            this.SetParamSimple(map, prefix + "StartTimeOffset", this.StartTimeOffset);
            this.SetParamSimple(map, prefix + "EndTimeOffset", this.EndTimeOffset);
            this.SetParamArraySimple(map, prefix + "AreaCoordSet.", this.AreaCoordSet);
        }
    }
}

