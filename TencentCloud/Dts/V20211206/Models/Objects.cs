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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Objects : AbstractModel
    {
        
        /// <summary>
        /// Sync object type. Valid value: `Partial` (default).
        /// Note: This field may return null, indicating that no valid values can be obtained.
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
        /// Advanced object type, such as function and procedure. If you need to sync advanced objects, the initialization type must include structure initialization; that is, `Options.InitType` must be `Structure` or `Full`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
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

