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

    public class Candidate : AbstractModel
    {
        
        /// <summary>
        /// Person ID.
        /// </summary>
        [JsonProperty("PersonId")]
        public string PersonId{ get; set; }

        /// <summary>
        /// Face ID.
        /// -Valid only in the API response of SearchFaces/SearchFacesReturnsByGroup.
        /// -Person search class interfaces use the fusion feature method for retrieval. This field is meaningless.
        /// </summary>
        [JsonProperty("FaceId")]
        public string FaceId{ get; set; }

        /// <summary>
        /// Match score of the candidate. 
        /// -In a face base library of 10,000 faces, a false acceptance rate of 1% corresponds to a score of 70 points, 0.1% corresponds to 80 points, and 0.01% corresponds to 90 points.
        /// -For a face base library of 100,000, a false acceptance rate of 1% corresponds to a score of 80 points, 0.1% corresponds to 90 points, and 0.01% corresponds to 100 points.
        /// -With a face base library of 300,000, a false acceptance rate of 1% corresponds to a score of 85, and a false acceptance rate of 0.1% corresponds to a score of 95.
        /// -Generally, a score of around 80 applies to most scenarios. It is advisable not to exceed 90. You can choose a suitable score according to the actual situation.
        /// </summary>
        [JsonProperty("Score")]
        public float? Score{ get; set; }

        /// <summary>
        /// Person name.
        /// </summary>
        [JsonProperty("PersonName")]
        public string PersonName{ get; set; }

        /// <summary>
        /// Gender of personnel.
        /// </summary>
        [JsonProperty("Gender")]
        public long? Gender{ get; set; }

        /// <summary>
        /// List of person libraries containing this person and the content of the description field.
        /// </summary>
        [JsonProperty("PersonGroupInfos")]
        public PersonGroupInfo[] PersonGroupInfos{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PersonId", this.PersonId);
            this.SetParamSimple(map, prefix + "FaceId", this.FaceId);
            this.SetParamSimple(map, prefix + "Score", this.Score);
            this.SetParamSimple(map, prefix + "PersonName", this.PersonName);
            this.SetParamSimple(map, prefix + "Gender", this.Gender);
            this.SetParamArrayObj(map, prefix + "PersonGroupInfos.", this.PersonGroupInfos);
        }
    }
}

