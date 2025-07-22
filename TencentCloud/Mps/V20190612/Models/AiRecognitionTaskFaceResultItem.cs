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
        /// Unique ID of a figure.
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Figure library type, indicating to which figure library the recognized figure belongs:
        /// <li>Default: Default figure library;</li>
        /// <li>UserDefine: Custom figure library.</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Name of a figure.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Result set of segments that contain a figure.
        /// </summary>
        [JsonProperty("SegmentSet")]
        public AiRecognitionTaskFaceSegmentItem[] SegmentSet{ get; set; }

        /// <summary>
        /// Gender of the person.
        /// <Li>Male: man.</li>.
        /// <Li>Female: specifies the woman.</li>.
        /// </summary>
        [JsonProperty("Gender")]
        public string Gender{ get; set; }

        /// <summary>
        /// Date of birth.
        /// </summary>
        [JsonProperty("Birthday")]
        public string Birthday{ get; set; }

        /// <summary>
        /// Occupation or position of a person.
        /// </summary>
        [JsonProperty("Profession")]
        public string Profession{ get; set; }

        /// <summary>
        /// Specifies the graduation institution of the person.
        /// </summary>
        [JsonProperty("SchoolOfGraduation")]
        public string SchoolOfGraduation{ get; set; }

        /// <summary>
        /// Description of the person.
        /// </summary>
        [JsonProperty("Abstract")]
        public string Abstract{ get; set; }

        /// <summary>
        /// Specifies the birthplace or place of origin.
        /// </summary>
        [JsonProperty("PlaceOfBirth")]
        public string PlaceOfBirth{ get; set; }

        /// <summary>
        /// Person type.
        /// <Li>Politician: specifies the official.</li>.
        /// <Li>Artist: specifies the artist.</li>.
        /// </summary>
        [JsonProperty("PersonType")]
        public string PersonType{ get; set; }

        /// <summary>
        /// Sensitivity labeling.
        /// <Li>Normal: specifies the scaling group is normal.</li>.
        /// <Li>Sensitive: specifies sensitivity.</li>.
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Specifies the screenshot link.
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

