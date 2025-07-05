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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeGeneralResourceQuotasRequest : AbstractModel
    {
        
        /// <summary>
        /// Resource name list. Values:
        /// - `GENERAL_BUNDLE_INSTANCE`: General bundle
        /// - `STORAGE_BUNDLE_INSTANCE`:  Storage bundle 
        /// - `ENTERPRISE_BUNDLE_INSTANCE`: Enterprise bundle 
        /// - `EXCLUSIVE_BUNDLE_INSTANCE`： Dedicated bundle
        /// - `BEFAST_BUNDLE_INSTANCE`: BeFast bundle
        /// - `USER_KEY_PAIR`: Key pair
        /// - `SNAPSHOT`: Snapshot
        /// - `BLUEPRINT`: Custom image
        /// - `FREE_BLUEPRINT`: Free custom image
        /// - `DATA_DISK`: Data disk
        /// - `FIREWALL_RULE`: Firewall rules
        /// </summary>
        [JsonProperty("ResourceNames")]
        public string[] ResourceNames{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ResourceNames.", this.ResourceNames);
        }
    }
}

