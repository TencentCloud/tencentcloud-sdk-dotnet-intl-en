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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyPersonSampleRequest : AbstractModel
    {
        
        /// <summary>
        /// ID of a sample.
        /// </summary>
        [JsonProperty("PersonId")]
        public string PersonId{ get; set; }

        /// <summary>
        /// Name. Length limit: 128 characters.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Description. Length limit: 1,024 characters.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Sample usage. Valid values:
        /// 1. Recognition: used for content recognition; equivalent to `Recognition.Face`
        /// 2. Review: used for inappropriate information recognition; equivalent to `Review.Face`
        /// 3. All: used for content recognition and inappropriate information recognition; equivalent to 1+2
        /// </summary>
        [JsonProperty("Usages")]
        public string[] Usages{ get; set; }

        /// <summary>
        /// Information of operations on facial features.
        /// </summary>
        [JsonProperty("FaceOperationInfo")]
        public AiSampleFaceOperation FaceOperationInfo{ get; set; }

        /// <summary>
        /// Tag operation information.
        /// </summary>
        [JsonProperty("TagOperationInfo")]
        public AiSampleTagOperation TagOperationInfo{ get; set; }

        /// <summary>
        /// [Subapplication](https://intl.cloud.tencent.com/document/product/266/14574?from_cn_redirect=1) ID in VOD. If you need to access a resource in a subapplication, enter the subapplication ID in this field; otherwise, leave it empty.
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PersonId", this.PersonId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArraySimple(map, prefix + "Usages.", this.Usages);
            this.SetParamObj(map, prefix + "FaceOperationInfo.", this.FaceOperationInfo);
            this.SetParamObj(map, prefix + "TagOperationInfo.", this.TagOperationInfo);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
        }
    }
}

