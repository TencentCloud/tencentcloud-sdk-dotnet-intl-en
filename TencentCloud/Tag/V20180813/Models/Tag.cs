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

    public class Tag : AbstractModel
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
        /// Tag type. Valid values: Custom: custom tag; System: system tag; All: all tags. Default value: All.Note: This field may return null, indicating that no value is obtained.
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
            this.SetParamSimple(map, prefix + "Category", this.Category);
        }
    }
}

