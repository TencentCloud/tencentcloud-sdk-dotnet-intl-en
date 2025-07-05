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

    public class FaceShape : AbstractModel
    {
        
        /// <summary>
        /// 21 points that describe the face contour.
        /// </summary>
        [JsonProperty("FaceProfile")]
        public Point[] FaceProfile{ get; set; }

        /// <summary>
        /// 8 points that describe the left eye.
        /// </summary>
        [JsonProperty("LeftEye")]
        public Point[] LeftEye{ get; set; }

        /// <summary>
        /// 8 points that describe the right eye.
        /// </summary>
        [JsonProperty("RightEye")]
        public Point[] RightEye{ get; set; }

        /// <summary>
        /// 8 points that describe the left eyebrow.
        /// </summary>
        [JsonProperty("LeftEyeBrow")]
        public Point[] LeftEyeBrow{ get; set; }

        /// <summary>
        /// 8 points that describe the right eyebrow.
        /// </summary>
        [JsonProperty("RightEyeBrow")]
        public Point[] RightEyeBrow{ get; set; }

        /// <summary>
        /// 22 points that describe the mouth.
        /// </summary>
        [JsonProperty("Mouth")]
        public Point[] Mouth{ get; set; }

        /// <summary>
        /// 13 points that describe the nose.
        /// </summary>
        [JsonProperty("Nose")]
        public Point[] Nose{ get; set; }

        /// <summary>
        /// 1 point that describes the left pupil.
        /// </summary>
        [JsonProperty("LeftPupil")]
        public Point[] LeftPupil{ get; set; }

        /// <summary>
        /// 1 point that describes the right pupil.
        /// </summary>
        [JsonProperty("RightPupil")]
        public Point[] RightPupil{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "FaceProfile.", this.FaceProfile);
            this.SetParamArrayObj(map, prefix + "LeftEye.", this.LeftEye);
            this.SetParamArrayObj(map, prefix + "RightEye.", this.RightEye);
            this.SetParamArrayObj(map, prefix + "LeftEyeBrow.", this.LeftEyeBrow);
            this.SetParamArrayObj(map, prefix + "RightEyeBrow.", this.RightEyeBrow);
            this.SetParamArrayObj(map, prefix + "Mouth.", this.Mouth);
            this.SetParamArrayObj(map, prefix + "Nose.", this.Nose);
            this.SetParamArrayObj(map, prefix + "LeftPupil.", this.LeftPupil);
            this.SetParamArrayObj(map, prefix + "RightPupil.", this.RightPupil);
        }
    }
}

