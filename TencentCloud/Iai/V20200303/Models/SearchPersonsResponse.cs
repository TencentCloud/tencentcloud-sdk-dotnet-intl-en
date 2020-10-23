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

    public class SearchPersonsResponse : AbstractModel
    {
        
        /// <summary>
        /// Recognition result.
        /// </summary>
        [JsonProperty("Results")]
        public Result[] Results{ get; set; }

        /// <summary>
        /// Number of the persons included in searched groups. If the quality of all faces in the input image does not meet the requirement, 0 will be returned.
        /// </summary>
        [JsonProperty("PersonNum")]
        public ulong? PersonNum{ get; set; }

        /// <summary>
        /// Algorithm model version used for face recognition.
        /// Note: this field may return null, indicating that no valid values can be obtained.
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
            this.SetParamArrayObj(map, prefix + "Results.", this.Results);
            this.SetParamSimple(map, prefix + "PersonNum", this.PersonNum);
            this.SetParamSimple(map, prefix + "FaceModelVersion", this.FaceModelVersion);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

