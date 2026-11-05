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

namespace TencentCloud.Iai.V20200303.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FaceRect : AbstractModel
    {
        
        /// <summary>
        /// Top-left X-axis coordinate of the face box 
        /// -The face frame contains the facial feature locations and is expanded on this basis. If the face frame exceeds the image range, it can cause negative coordinate values. 
        /// -If you need to capture a complete face, you can set negative coordinates to 0 when the completeness meets the requirements.
        /// </summary>
        [JsonProperty("X")]
        public long? X{ get; set; }

        /// <summary>
        /// Top-left Y-axis coordinate of the face box 
        /// -The face frame contains the facial feature locations and is expanded on this basis. If the face frame exceeds the image range, it can cause negative coordinate values. 
        /// -If you need to capture a complete face, you can set negative coordinates to 0 when the completeness meets the requirements.
        /// </summary>
        [JsonProperty("Y")]
        public long? Y{ get; set; }

        /// <summary>
        /// Face width.
        /// </summary>
        [JsonProperty("Width")]
        public ulong? Width{ get; set; }

        /// <summary>
        /// Face height.
        /// </summary>
        [JsonProperty("Height")]
        public ulong? Height{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "X", this.X);
            this.SetParamSimple(map, prefix + "Y", this.Y);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
        }
    }
}

