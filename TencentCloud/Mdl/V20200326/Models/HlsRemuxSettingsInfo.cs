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

namespace TencentCloud.Mdl.V20200326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HlsRemuxSettingsInfo : AbstractModel
    {
        
        /// <summary>
        /// Segment duration in ms. Value range: [1000,30000]. Default value: 4000. The value can only be a multiple of 1,000.
        /// </summary>
        [JsonProperty("SegmentDuration")]
        public ulong? SegmentDuration{ get; set; }

        /// <summary>
        /// Number of segments. Value range: [1,30]. Default value: 5.
        /// </summary>
        [JsonProperty("SegmentNumber")]
        public ulong? SegmentNumber{ get; set; }

        /// <summary>
        /// Whether to enable PDT insertion. Valid values: CLOSE/OPEN. Default value: CLOSE.
        /// </summary>
        [JsonProperty("PdtInsertion")]
        public string PdtInsertion{ get; set; }

        /// <summary>
        /// PDT duration in seconds. Value range: (0,3000]. Default value: 600.
        /// </summary>
        [JsonProperty("PdtDuration")]
        public ulong? PdtDuration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SegmentDuration", this.SegmentDuration);
            this.SetParamSimple(map, prefix + "SegmentNumber", this.SegmentNumber);
            this.SetParamSimple(map, prefix + "PdtInsertion", this.PdtInsertion);
            this.SetParamSimple(map, prefix + "PdtDuration", this.PdtDuration);
        }
    }
}

