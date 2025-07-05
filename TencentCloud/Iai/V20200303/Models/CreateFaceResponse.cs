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

    public class CreateFaceResponse : AbstractModel
    {
        
        /// <summary>
        /// Number of successfully added faces
        /// </summary>
        [JsonProperty("SucFaceNum")]
        public ulong? SucFaceNum{ get; set; }

        /// <summary>
        /// List of IDs of successfully added faces
        /// </summary>
        [JsonProperty("SucFaceIds")]
        public string[] SucFaceIds{ get; set; }

        /// <summary>
        /// Adding result for each face image. -1101: no face detected; -1102: image decoding failed; 
        /// -1601: the image quality control requirement is not met; -1604: the face similarity is not above `FaceMatchThreshold`. 
        /// Other non-zero values: algorithm service exception. 
        /// The order of `RetCode` values is the same as the order of `Images` or `Urls` in the input parameter.
        /// </summary>
        [JsonProperty("RetCode")]
        public long?[] RetCode{ get; set; }

        /// <summary>
        /// Indexes of successfully added faces. The order of indexes is the same as the order of `Images` or `Urls` in the input parameter. 
        /// For example, if there are 3 URLs in `Urls`, and the second URL fails, then the value of `SucIndexes` will be [0,2].
        /// </summary>
        [JsonProperty("SucIndexes")]
        public ulong?[] SucIndexes{ get; set; }

        /// <summary>
        /// Frame positions of successfully added faces. The order is the same as the order of `Images` or `Urls` in the input parameter.
        /// </summary>
        [JsonProperty("SucFaceRects")]
        public FaceRect[] SucFaceRects{ get; set; }

        /// <summary>
        /// Algorithm model version used for face recognition.
        /// </summary>
        [JsonProperty("FaceModelVersion")]
        public string FaceModelVersion{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SucFaceNum", this.SucFaceNum);
            this.SetParamArraySimple(map, prefix + "SucFaceIds.", this.SucFaceIds);
            this.SetParamArraySimple(map, prefix + "RetCode.", this.RetCode);
            this.SetParamArraySimple(map, prefix + "SucIndexes.", this.SucIndexes);
            this.SetParamArrayObj(map, prefix + "SucFaceRects.", this.SucFaceRects);
            this.SetParamSimple(map, prefix + "FaceModelVersion", this.FaceModelVersion);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

