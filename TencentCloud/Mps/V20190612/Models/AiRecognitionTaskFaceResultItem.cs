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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AiRecognitionTaskFaceResultItem : AbstractModel
    {
        
        /// <summary>
        /// Unique identification ID of the figure.
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Figure library type, indicates which figure library the recognized figure comes from.
        /// <li>Default: default figure library;</li>
        /// <li>UserDefine: user-defined character library.</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Figure name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Result set of segments that contain people.
        /// </summary>
        [JsonProperty("SegmentSet")]
        public AiRecognitionTaskFaceSegmentItem[] SegmentSet{ get; set; }

        /// <summary>
        /// Gender
        /// <li>Male: man</li>
        /// <li>Female: woman.</li>
        /// </summary>
        [JsonProperty("Gender")]
        public string Gender{ get; set; }

        /// <summary>
        /// Date of birth of a person.
        /// </summary>
        [JsonProperty("Birthday")]
        public string Birthday{ get; set; }

        /// <summary>
        /// Occupation or position.
        /// </summary>
        [JsonProperty("Profession")]
        public string Profession{ get; set; }

        /// <summary>
        /// Graduation institution of the person.
        /// </summary>
        [JsonProperty("SchoolOfGraduation")]
        public string SchoolOfGraduation{ get; set; }

        /// <summary>
        /// Figure description.
        /// </summary>
        [JsonProperty("Abstract")]
        public string Abstract{ get; set; }

        /// <summary>
        /// Birthplace or place of origin of a person.
        /// </summary>
        [JsonProperty("PlaceOfBirth")]
        public string PlaceOfBirth{ get; set; }

        /// <summary>
        /// Person type:
        /// <li>Politician: official.</li>
        /// <li>Artist: artist.</li>
        /// </summary>
        [JsonProperty("PersonType")]
        public string PersonType{ get; set; }

        /// <summary>
        /// Sensitivity labeling:
        /// <li>NORMAL: Normal;</li>
        /// <li>Sensitive: sensitive.</li>
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Screenshot link
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArrayObj(map, prefix + "SegmentSet.", this.SegmentSet);
            this.SetParamSimple(map, prefix + "Gender", this.Gender);
            this.SetParamSimple(map, prefix + "Birthday", this.Birthday);
            this.SetParamSimple(map, prefix + "Profession", this.Profession);
            this.SetParamSimple(map, prefix + "SchoolOfGraduation", this.SchoolOfGraduation);
            this.SetParamSimple(map, prefix + "Abstract", this.Abstract);
            this.SetParamSimple(map, prefix + "PlaceOfBirth", this.PlaceOfBirth);
            this.SetParamSimple(map, prefix + "PersonType", this.PersonType);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "Url", this.Url);
        }
    }
}

