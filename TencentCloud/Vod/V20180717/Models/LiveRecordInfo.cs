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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LiveRecordInfo : AbstractModel
    {
        
        /// <summary>
        /// Live recording stream ID.
        /// </summary>
        [JsonProperty("StreamId")]
        public string StreamId{ get; set; }

        /// <summary>
        /// Recording start time, use [ISO date format](https://www.tencentcloud.com/document/product/266/11732#iso-date-format).
        /// </summary>
        [JsonProperty("RecordStartTime")]
        public string RecordStartTime{ get; set; }

        /// <summary>
        /// Recording end time, using [ISO date format](https://www.tencentcloud.com/document/product/266/11732#iso-date-format).
        /// </summary>
        [JsonProperty("RecordEndTime")]
        public string RecordEndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StreamId", this.StreamId);
            this.SetParamSimple(map, prefix + "RecordStartTime", this.RecordStartTime);
            this.SetParamSimple(map, prefix + "RecordEndTime", this.RecordEndTime);
        }
    }
}

