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

namespace TencentCloud.Iai.V20200303.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FaceInfo : AbstractModel
    {
        
        /// <summary>
        /// Horizontal coordinate of the top-left corner of face frame.
        /// The face frame encompasses the facial features and is extended accordingly. If it is larger than the image, the coordinates will be negative. 
        /// If you want to capture a complete face, you can set the negative coordinates to 0 if the `completeness` score meets the requirement.
        /// </summary>
        [JsonProperty("X")]
        public long? X{ get; set; }

        /// <summary>
        /// Vertical coordinate of the top-left corner of face frame. 
        /// The face frame encompasses the facial features and is extended accordingly. If it is larger than the image, the coordinates will be negative. 
        /// If you want to capture a complete face, you can set the negative coordinates to 0 if the `completeness` score meets the requirement.
        /// </summary>
        [JsonProperty("Y")]
        public long? Y{ get; set; }

        /// <summary>
        /// Face frame width.
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// Face frame height.
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }

        /// <summary>
        /// Face attributes, including gender, age, expression, 
        /// beauty, glass, mask, hair, and pose (pitch, roll, yaw). Valid information will be returned only if `NeedFaceAttributes` is set to 1.
        /// </summary>
        [JsonProperty("FaceAttributesInfo")]
        public FaceAttributesInfo FaceAttributesInfo{ get; set; }

        /// <summary>
        /// Face quality information, including score, sharpness, brightness, and completeness. Valid information will be returned only if `NeedFaceDetection` is set to 1.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FaceQualityInfo")]
        public FaceQualityInfo FaceQualityInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "X", this.X);
            this.SetParamSimple(map, prefix + "Y", this.Y);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamObj(map, prefix + "FaceAttributesInfo.", this.FaceAttributesInfo);
            this.SetParamObj(map, prefix + "FaceQualityInfo.", this.FaceQualityInfo);
        }
    }
}

