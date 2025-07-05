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

    public class FaceAttributesInfo : AbstractModel
    {
        
        /// <summary>
        /// Gender. The gender is female for the value range [0,49] and male for the value range [50,100]. The closer the value to 0 or 100, the higher the confidence. If `NeedFaceAttributes` is not 1 or more than 5 faces are detected, this parameter will still be returned but meaningless.
        /// </summary>
        [JsonProperty("Gender")]
        public long? Gender{ get; set; }

        /// <summary>
        /// Age. Value range: [0,100]. If `NeedFaceAttributes` is not 1 or more than 5 faces are detected, this parameter will still be returned but meaningless.
        /// </summary>
        [JsonProperty("Age")]
        public long? Age{ get; set; }

        /// <summary>
        /// Expression. Value range: [0 (normal)–50 (smile)–100 (laugh)]. If `NeedFaceAttributes` is not 1 or more than 5 faces are detected, this parameter will still be returned but meaningless.
        /// </summary>
        [JsonProperty("Expression")]
        public long? Expression{ get; set; }

        /// <summary>
        /// Whether glasses are present. Valid values: true, false. If `NeedFaceAttributes` is not 1 or more than 5 faces are detected, this parameter will still be returned but meaningless.
        /// </summary>
        [JsonProperty("Glass")]
        public bool? Glass{ get; set; }

        /// <summary>
        /// Vertical offset in degrees. Value range: [-30,30]. If `NeedFaceAttributes` is not 1 or more than 5 faces are detected, this parameter will still be returned but meaningless. 
        /// We recommend selecting images in the [-10,10] range for adding faces.
        /// </summary>
        [JsonProperty("Pitch")]
        public long? Pitch{ get; set; }

        /// <summary>
        /// Horizontal offset in degrees. Value range: [-30,30]. If `NeedFaceAttributes` is not 1 or more than 5 faces are detected, this parameter will still be returned but meaningless. 
        /// We recommend selecting images in the [-10,10] range for adding faces.
        /// </summary>
        [JsonProperty("Yaw")]
        public long? Yaw{ get; set; }

        /// <summary>
        /// Horizontal rotation in degrees. Value range: [-180,180]. If `NeedFaceAttributes` is not 1 or more than 5 faces are detected, this parameter will still be returned but meaningless.  
        /// We recommend selecting images in the [-20,20] range for adding faces.
        /// </summary>
        [JsonProperty("Roll")]
        public long? Roll{ get; set; }

        /// <summary>
        /// Beauty. Value range: [0,100]. If `NeedFaceAttributes` is not 1 or more than 5 faces are detected, this parameter will still be returned but meaningless.
        /// </summary>
        [JsonProperty("Beauty")]
        public long? Beauty{ get; set; }

        /// <summary>
        /// Whether hat is present. Valid values: true, false. If `NeedFaceAttributes` is not 1 or more than 5 faces are detected, this parameter will still be returned but meaningless.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Hat")]
        public bool? Hat{ get; set; }

        /// <summary>
        /// Whether mask is present. Valid values: true, false. If `NeedFaceAttributes` is not 1 or more than 5 faces are detected, this parameter will still be returned but meaningless.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Mask")]
        public bool? Mask{ get; set; }

        /// <summary>
        /// Hair information, including length, bang, and color. If `NeedFaceAttributes` is not 1 or more than 5 faces are detected, this parameter will still be returned but meaningless.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Hair")]
        public FaceHairAttributesInfo Hair{ get; set; }

        /// <summary>
        /// Whether the eyes are open. Valid values: true, false. As long as there is more than one eye closed, `false` will be returned. If `NeedFaceAttributes` is not 1 or more than 5 faces are detected, this parameter will still be returned but meaningless.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EyeOpen")]
        public bool? EyeOpen{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Gender", this.Gender);
            this.SetParamSimple(map, prefix + "Age", this.Age);
            this.SetParamSimple(map, prefix + "Expression", this.Expression);
            this.SetParamSimple(map, prefix + "Glass", this.Glass);
            this.SetParamSimple(map, prefix + "Pitch", this.Pitch);
            this.SetParamSimple(map, prefix + "Yaw", this.Yaw);
            this.SetParamSimple(map, prefix + "Roll", this.Roll);
            this.SetParamSimple(map, prefix + "Beauty", this.Beauty);
            this.SetParamSimple(map, prefix + "Hat", this.Hat);
            this.SetParamSimple(map, prefix + "Mask", this.Mask);
            this.SetParamObj(map, prefix + "Hair.", this.Hair);
            this.SetParamSimple(map, prefix + "EyeOpen", this.EyeOpen);
        }
    }
}

