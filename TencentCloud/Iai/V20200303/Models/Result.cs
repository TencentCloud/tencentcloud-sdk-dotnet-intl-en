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

    public class Result : AbstractModel
    {
        
        /// <summary>
        /// The most similar candidate identified.
        /// </summary>
        [JsonProperty("Candidates")]
        public Candidate[] Candidates{ get; set; }

        /// <summary>
        /// Face bounding box position detected.
        /// </summary>
        [JsonProperty("FaceRect")]
        public FaceRect FaceRect{ get; set; }

        /// <summary>
        /// Status return code of the detected face image.
        /// - 0 indicates normal. 
        /// -1601 indicates the image quality control requirement is not met. At this point, the Candidate content is empty.
        /// </summary>
        [JsonProperty("RetCode")]
        public long? RetCode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Candidates.", this.Candidates);
            this.SetParamObj(map, prefix + "FaceRect.", this.FaceRect);
            this.SetParamSimple(map, prefix + "RetCode", this.RetCode);
        }
    }
}

