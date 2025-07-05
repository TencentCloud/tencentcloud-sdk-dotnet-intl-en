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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CompareObject : AbstractModel
    {
        
        /// <summary>
        /// Data comparison object mode (`all`: Entire instance; `partial`: Some objects)
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ObjectMode")]
        public string ObjectMode{ get; set; }

        /// <summary>
        /// Object list
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ObjectItems")]
        public CompareObjectItem[] ObjectItems{ get; set; }

        /// <summary>
        /// Advanced object types, such as account, index, shardkey, schema.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AdvancedObjects")]
        public string[] AdvancedObjects{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ObjectMode", this.ObjectMode);
            this.SetParamArrayObj(map, prefix + "ObjectItems.", this.ObjectItems);
            this.SetParamArraySimple(map, prefix + "AdvancedObjects.", this.AdvancedObjects);
        }
    }
}

