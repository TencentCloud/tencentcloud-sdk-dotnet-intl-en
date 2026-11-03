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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DefaultDenySecurityActionParameters : AbstractModel
    {
        
        /// <summary>
        /// Default interception disposition action configuration for managed rules. Supported configuration parameters of DenyActionParameters: <li>ReturnCustomPage: whether to use a custom page.</li><li>ResponseCode: status code of the custom page.</li><li>ErrorPageId: PageId of the custom page.</li>
        /// </summary>
        [JsonProperty("ManagedRules")]
        public DenyActionParameters ManagedRules{ get; set; }

        /// <summary>
        /// Security protection rules other than managed rules (custom rules, rate limit, and Bot management function) default interception disposition action configuration. Configuration parameters supported by DenyActionParameters: <li>ReturnCustomPage: whether to use a custom page.</li><li>ResponseCode: status code of the custom page.</li><li>ErrorPageId: PageId of the custom page.</li>
        /// </summary>
        [JsonProperty("OtherModules")]
        public DenyActionParameters OtherModules{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ManagedRules.", this.ManagedRules);
            this.SetParamObj(map, prefix + "OtherModules.", this.OtherModules);
        }
    }
}

