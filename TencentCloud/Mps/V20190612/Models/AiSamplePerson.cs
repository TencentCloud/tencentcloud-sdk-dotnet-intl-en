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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AiSamplePerson : AbstractModel
    {
        
        /// <summary>
        /// Figure ID.
        /// </summary>
        [JsonProperty("PersonId")]
        public string PersonId{ get; set; }

        /// <summary>
        /// Name of a figure.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Figure description.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Face information.
        /// </summary>
        [JsonProperty("FaceInfoSet")]
        public AiSampleFaceInfo[] FaceInfoSet{ get; set; }

        /// <summary>
        /// Figure tag.
        /// </summary>
        [JsonProperty("TagSet")]
        public string[] TagSet{ get; set; }

        /// <summary>
        /// Use case.
        /// </summary>
        [JsonProperty("UsageSet")]
        public string[] UsageSet{ get; set; }

        /// <summary>
        /// Creation time in [ISO date format](https://intl.cloud.tencent.com/document/product/266/11732?from_cn_redirect=1#iso-.E6.97.A5.E6.9C.9F.E6.A0.BC.E5.BC.8F).
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Last modified time in [ISO date format](https://intl.cloud.tencent.com/document/product/266/11732?from_cn_redirect=1#iso-.E6.97.A5.E6.9C.9F.E6.A0.BC.E5.BC.8F).
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PersonId", this.PersonId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArrayObj(map, prefix + "FaceInfoSet.", this.FaceInfoSet);
            this.SetParamArraySimple(map, prefix + "TagSet.", this.TagSet);
            this.SetParamArraySimple(map, prefix + "UsageSet.", this.UsageSet);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

