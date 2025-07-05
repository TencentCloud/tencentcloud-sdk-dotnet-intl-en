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

namespace TencentCloud.Tag.V20180813.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyResourceTagsRequest : AbstractModel
    {
        
        /// <summary>
        /// [Six-segment resource description](https://intl.cloud.tencent.com/document/product/598/10606?from_cn_redirect=1)
        /// </summary>
        [JsonProperty("Resource")]
        public string Resource{ get; set; }

        /// <summary>
        /// The tags to be added or modified. If the resource described by `Resource` is not associated with the input tag keys, an association will be added. If the tag keys are already associated, the values corresponding to the associated tag keys will be modified to the input values. This API must contain either `ReplaceTags` or `DeleteTag`, and these two parameters cannot include the same tag keys. This parameter can be omitted, but it cannot be an empty array.
        /// </summary>
        [JsonProperty("ReplaceTags")]
        public Tag[] ReplaceTags{ get; set; }

        /// <summary>
        /// The tags to be disassociated. This API must contain either `ReplaceTags` or `DeleteTag`, and these two parameters cannot include the same tag keys. This parameter can be omitted, but it cannot be an empty array.
        /// </summary>
        [JsonProperty("DeleteTags")]
        public TagKeyObject[] DeleteTags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Resource", this.Resource);
            this.SetParamArrayObj(map, prefix + "ReplaceTags.", this.ReplaceTags);
            this.SetParamArrayObj(map, prefix + "DeleteTags.", this.DeleteTags);
        }
    }
}

