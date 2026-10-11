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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TagValueInfo : AbstractModel
    {
        
        /// <summary>
        /// Tag value ID
        /// </summary>
        [JsonProperty("TagValueId")]
        public string TagValueId{ get; set; }

        /// <summary>
        /// Tag value content. Fill in when querying. Do not pass in when writing.
        /// </summary>
        [JsonProperty("TagValue")]
        public string TagValue{ get; set; }

        /// <summary>
        /// Tag source. See web_enum_standard.proto -> TagSource: 0=not specified 1=directly bound to user 2=inherited from user group 3=both. Populated during queries. Do not pass when writing.
        /// </summary>
        [JsonProperty("Source")]
        public long? Source{ get; set; }

        /// <summary>
        /// List of user group names from the inheritance source. Empty when Source=1. Populated during queries. Do not pass when writing.
        /// </summary>
        [JsonProperty("GroupNames")]
        public string[] GroupNames{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TagValueId", this.TagValueId);
            this.SetParamSimple(map, prefix + "TagValue", this.TagValue);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamArraySimple(map, prefix + "GroupNames.", this.GroupNames);
        }
    }
}

