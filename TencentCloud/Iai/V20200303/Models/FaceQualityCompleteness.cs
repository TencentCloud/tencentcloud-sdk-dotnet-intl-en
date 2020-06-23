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

    public class FaceQualityCompleteness : AbstractModel
    {
        
        /// <summary>
        /// Eyebrow completeness. Value range: [0,100]. The higher the score, the higher the completeness. 
        /// Reference range: [0,80], which means incomplete.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Eyebrow")]
        public long? Eyebrow{ get; set; }

        /// <summary>
        /// Eye completeness. Value range: [0,100]. The higher the score, the higher the completeness. 
        /// Reference range: [0,80], which means incomplete.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Eye")]
        public long? Eye{ get; set; }

        /// <summary>
        /// Nose completeness. Value range: [0,100]. The higher the score, the higher the completeness. 
        /// Reference range: [0,60], which means incomplete.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Nose")]
        public long? Nose{ get; set; }

        /// <summary>
        /// Cheek completeness. Value range: [0,100]. The higher the score, the higher the completeness. 
        /// Reference range: [0,70], which means incomplete.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Cheek")]
        public long? Cheek{ get; set; }

        /// <summary>
        /// Mouth completeness. Value range: [0,100]. The higher the score, the higher the completeness. 
        /// Reference range: [0,50], which means incomplete.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Mouth")]
        public long? Mouth{ get; set; }

        /// <summary>
        /// Chin completeness. Value range: [0,100]. The higher the score, the higher the completeness. 
        /// Reference range: [0,70], which means incomplete.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Chin")]
        public long? Chin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Eyebrow", this.Eyebrow);
            this.SetParamSimple(map, prefix + "Eye", this.Eye);
            this.SetParamSimple(map, prefix + "Nose", this.Nose);
            this.SetParamSimple(map, prefix + "Cheek", this.Cheek);
            this.SetParamSimple(map, prefix + "Mouth", this.Mouth);
            this.SetParamSimple(map, prefix + "Chin", this.Chin);
        }
    }
}

