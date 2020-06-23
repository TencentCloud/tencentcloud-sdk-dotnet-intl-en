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

    public class GetSimilarPersonResultResponse : AbstractModel
    {
        
        /// <summary>
        /// Duplicate check task completion progress. Value range: [0.0,100.0]. `SimilarPersons` takes effect only if this parameter value is 100.
        /// </summary>
        [JsonProperty("Progress")]
        public float? Progress{ get; set; }

        /// <summary>
        /// Temporary download link for the information file of the persons suspected to be duplicate. The validity period is 5 minutes, and the result file retention duration is 90 days.
        /// The file content is an array of `SimilarPerson` values.
        /// </summary>
        [JsonProperty("SimilarPersonsUrl")]
        public string SimilarPersonsUrl{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamSimple(map, prefix + "SimilarPersonsUrl", this.SimilarPersonsUrl);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

