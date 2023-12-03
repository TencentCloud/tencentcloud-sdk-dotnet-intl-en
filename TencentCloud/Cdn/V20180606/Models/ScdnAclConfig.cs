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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScdnAclConfig : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable SCDN access. Values:
        /// `on`: Enable
        /// `off`: Disable
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// This field is disused. Please use `AdvancedScriptData` instead.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ScriptData")]
        public ScdnAclGroup[] ScriptData{ get; set; }

        /// <summary>
        /// Error page configuration
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ErrorPage")]
        public ScdnErrorPage ErrorPage{ get; set; }

        /// <summary>
        /// ACL rule group, which is required when the access control is on.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("AdvancedScriptData")]
        public AdvancedScdnAclGroup[] AdvancedScriptData{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamArrayObj(map, prefix + "ScriptData.", this.ScriptData);
            this.SetParamObj(map, prefix + "ErrorPage.", this.ErrorPage);
            this.SetParamArrayObj(map, prefix + "AdvancedScriptData.", this.AdvancedScriptData);
        }
    }
}

