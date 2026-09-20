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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyPersonSampleRequest : AbstractModel
    {
        
        /// <summary>
        /// Material ID.
        /// </summary>
        [JsonProperty("PersonId")]
        public string PersonId{ get; set; }

        /// <summary>
        /// <b>On-demand [application](https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1) ID. For customers who activate on-demand services after December 25, 2023, this field must be filled with the app ID when accessing resources in on-demand applications (whether the default application or a newly created application).</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// Name, with a length limit of 128 characters.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Description. Length limit: 1024 characters.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Material application scenario. Available values:
        /// 1. Recognition: used for content recognition, equivalent to Recognition.Face.
        /// 2. Review: used for inappropriate content recognition, equivalent to Review.Face.
        /// 3. All: for content recognition and inappropriate content recognition, equivalent to 1+2.
        /// </summary>
        [JsonProperty("Usages")]
        public string[] Usages{ get; set; }

        /// <summary>
        /// Facial operation information.
        /// </summary>
        [JsonProperty("FaceOperationInfo")]
        public AiSampleFaceOperation FaceOperationInfo{ get; set; }

        /// <summary>
        /// Tag operation information.
        /// </summary>
        [JsonProperty("TagOperationInfo")]
        public AiSampleTagOperation TagOperationInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PersonId", this.PersonId);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArraySimple(map, prefix + "Usages.", this.Usages);
            this.SetParamObj(map, prefix + "FaceOperationInfo.", this.FaceOperationInfo);
            this.SetParamObj(map, prefix + "TagOperationInfo.", this.TagOperationInfo);
        }
    }
}

