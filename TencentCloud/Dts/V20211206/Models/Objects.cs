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

    public class Objects : AbstractModel
    {
        
        /// <summary>
        /// Sync object type. Valid value: `Partial` (Partial objects). Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// Sync object, which is required if `Mode` is `Partial`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Databases")]
        public Database[] Databases{ get; set; }

        /// <summary>
        /// Advanced object types, such as function and procedure. Note: If you want to migrate and synchronize advanced objects, the corresponding advanced object type should be included in this configuration. When advanced objects need to be synchronized, the initialization type must include the structure initialization type, that is, the Options.InitType value of the task is Structure or Full.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AdvancedObjects")]
        public string[] AdvancedObjects{ get; set; }

        /// <summary>
        /// A redundant field that specifies the online DDL type
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OnlineDDL")]
        public OnlineDDL OnlineDDL{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamArrayObj(map, prefix + "Databases.", this.Databases);
            this.SetParamArraySimple(map, prefix + "AdvancedObjects.", this.AdvancedObjects);
            this.SetParamObj(map, prefix + "OnlineDDL.", this.OnlineDDL);
        }
    }
}

