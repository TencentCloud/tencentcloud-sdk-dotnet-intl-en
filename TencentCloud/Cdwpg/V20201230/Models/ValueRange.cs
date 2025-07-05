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

namespace TencentCloud.Cdwpg.V20201230.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ValueRange : AbstractModel
    {
        
        /// <summary>
        /// Parameter types. Valid values: enum, string, and section. Enum indicates enumeration, namely utf8, latin1, gbk. String indicates that the returned parameter value is a string. Section indicates that the returned parameter value is a value range, for example, 4-8.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Response parameter when the type is a section.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Range")]
        public Range Range{ get; set; }

        /// <summary>
        /// Response parameter when the type is an enum.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Enum")]
        public string[] Enum{ get; set; }

        /// <summary>
        /// Response parameter when the type is a string.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("String")]
        public string String{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "Range.", this.Range);
            this.SetParamArraySimple(map, prefix + "Enum.", this.Enum);
            this.SetParamSimple(map, prefix + "String", this.String);
        }
    }
}

