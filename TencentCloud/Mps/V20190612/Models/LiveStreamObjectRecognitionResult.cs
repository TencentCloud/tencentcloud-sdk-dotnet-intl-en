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

    public class LiveStreamObjectRecognitionResult : AbstractModel
    {
        
        /// <summary>
        /// Name of a recognized object.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Start PTS time of a recognized segment, in seconds.
        /// </summary>
        [JsonProperty("StartPtsOffset")]
        public float? StartPtsOffset{ get; set; }

        /// <summary>
        /// End PTS time of a recognized segment, in seconds.
        /// </summary>
        [JsonProperty("EndPtsOffset")]
        public float? EndPtsOffset{ get; set; }

        /// <summary>
        /// Confidence of a recognized segment. Value range: 0-100.
        /// </summary>
        [JsonProperty("Confidence")]
        public float? Confidence{ get; set; }

        /// <summary>
        /// Zone coordinates of the recognition result. An array contains four elements: [x1, y1, x2, y2], representing the horizontal and vertical coordinates of the top-left and bottom-right corners, respectively.
        /// </summary>
        [JsonProperty("AreaCoordSet")]
        public long?[] AreaCoordSet{ get; set; }

        /// <summary>
        /// Screenshot link.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "StartPtsOffset", this.StartPtsOffset);
            this.SetParamSimple(map, prefix + "EndPtsOffset", this.EndPtsOffset);
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
            this.SetParamArraySimple(map, prefix + "AreaCoordSet.", this.AreaCoordSet);
            this.SetParamSimple(map, prefix + "Url", this.Url);
        }
    }
}

