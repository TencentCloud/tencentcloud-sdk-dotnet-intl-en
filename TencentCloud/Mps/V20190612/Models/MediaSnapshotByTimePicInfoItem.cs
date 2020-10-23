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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MediaSnapshotByTimePicInfoItem : AbstractModel
    {
        
        /// <summary>
        /// Time offset corresponding to the screenshot in the video in <font color=red>milliseconds</font>.
        /// </summary>
        [JsonProperty("TimeOffset")]
        public float? TimeOffset{ get; set; }

        /// <summary>
        /// Path to the screenshot.
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// List of watermarking template IDs if the screenshots are watermarked.
        /// </summary>
        [JsonProperty("WaterMarkDefinition")]
        public long?[] WaterMarkDefinition{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TimeOffset", this.TimeOffset);
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamArraySimple(map, prefix + "WaterMarkDefinition.", this.WaterMarkDefinition);
        }
    }
}

