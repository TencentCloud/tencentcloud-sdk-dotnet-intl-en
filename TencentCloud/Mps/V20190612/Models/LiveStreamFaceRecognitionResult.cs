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

    public class LiveStreamFaceRecognitionResult : AbstractModel
    {
        
        /// <summary>
        /// Unique ID of figure.
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Figure name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Figure library type, indicating to which figure library the recognized figure belongs:
        /// <li>Default: default figure library</li><li>UserDefine: custom figure library</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Start PTS time of recognized segment in seconds.
        /// </summary>
        [JsonProperty("StartPtsTime")]
        public float? StartPtsTime{ get; set; }

        /// <summary>
        /// End PTS time of recognized segment in seconds.
        /// </summary>
        [JsonProperty("EndPtsTime")]
        public float? EndPtsTime{ get; set; }

        /// <summary>
        /// Confidence of recognized segment. Value range: 0–100.
        /// </summary>
        [JsonProperty("Confidence")]
        public float? Confidence{ get; set; }

        /// <summary>
        /// Zone coordinates of recognition result. The array contains four elements: [x1,y1,x2,y2], i.e., the horizontal and vertical coordinates of the top-left and bottom-right corners.
        /// </summary>
        [JsonProperty("AreaCoordSet")]
        public long?[] AreaCoordSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "StartPtsTime", this.StartPtsTime);
            this.SetParamSimple(map, prefix + "EndPtsTime", this.EndPtsTime);
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
            this.SetParamArraySimple(map, prefix + "AreaCoordSet.", this.AreaCoordSet);
        }
    }
}

