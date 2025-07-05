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

    public class TagResource : AbstractModel
    {
        
        /// <summary>
        /// Tag key.
        /// </summary>
        [JsonProperty("TagKey")]
        public string TagKey{ get; set; }

        /// <summary>
        /// Tag value.
        /// </summary>
        [JsonProperty("TagValue")]
        public string TagValue{ get; set; }

        /// <summary>
        /// Resource ID.
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// Tag key MD5 value.
        /// </summary>
        [JsonProperty("TagKeyMd5")]
        public string TagKeyMd5{ get; set; }

        /// <summary>
        /// Tag value MD5 value.
        /// </summary>
        [JsonProperty("TagValueMd5")]
        public string TagValueMd5{ get; set; }

        /// <summary>
        /// Resource type
        /// Note: this field may return null, indicating that no valid values found.
        /// </summary>
        [JsonProperty("ServiceType")]
        public string ServiceType{ get; set; }

        /// <summary>
        /// Tag type. Valid values: Custom: custom tag; System: system tag.Note: This field may return null, indicating that no value is obtained.
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TagKey", this.TagKey);
            this.SetParamSimple(map, prefix + "TagValue", this.TagValue);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "TagKeyMd5", this.TagKeyMd5);
            this.SetParamSimple(map, prefix + "TagValueMd5", this.TagValueMd5);
            this.SetParamSimple(map, prefix + "ServiceType", this.ServiceType);
            this.SetParamSimple(map, prefix + "Category", this.Category);
        }
    }
}

