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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ConfigSetInfo : AbstractModel
    {
        
        /// <summary>
        /// Configuration set name.
        /// </summary>
        [JsonProperty("ConfigSet")]
        public string ConfigSet{ get; set; }

        /// <summary>
        /// The capacity scheduler will use it, where tag-related configuration is set. The key values are consistent with the fields returned by **DescribeYarnQueue**.
        /// The key values are as follows:
        /// - labelName: Tag name, that is, tags in tag management.
        /// - capacity: Capacity. The value is a **numeric string**.
        /// - maximum-capacity: Maximum capacity. The value is a **numeric string**.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LabelParams")]
        public ItemSeq[] LabelParams{ get; set; }

        /// <summary>
        /// Set parameters related to the configuration set. The key values are consistent with the fields returned by **DescribeYarnQueue**.
        /// ###### Fair scheduler.
        /// The key values are as follows:
        /// - minResources: Minimum resource amount. The value is a **JSON string of the YarnResource type** or **null**.
        /// - maxResources: Maximum resource amount. The value is a **JSON string of the YarnResource type** or **null**.
        /// - maxChildResources: Maximum resource amount for undeclared subqueues. The value is a **numeric string** or **null**.
        /// - maxRunningApps: Maximum number of apps that can run concurrently. The value is a **numeric string** or **null**.
        /// - weight: weight. The value is a **numeric string** or **null**.
        /// - maxAMShare: Maximum App Master share. The value is a **numeric string** or **null**, where the number range is [0,1] or -1.
        /// 
        /// ```
        /// type YarnResource struct {
        /// 	Vcores *int `json:"vcores"`
        /// 	Memory *int `json:"memory"`
        /// 	Type *string `json:"type"` // The value can be percent or null. When the value is percent, it indicates the percentage used; otherwise, the absolute value used is indicated. The value can be percent only for maxResources and maxChildResources.
        /// }
        /// ```
        /// 
        /// ###### Capacity scheduler.
        /// The key values are as follows:
        /// - minimum-user-limit-percent: Minimum user capacity. The value is a **JSON string of the YarnResource type** or **null**, where the number range is [0,100].
        /// - user-limit-factor: User resource factor. The value is a **JSON string of the YarnResource type** or **null**.
        /// - maximum-applications: Maximum number of applications, that is, Max-Applications. The value is a **numeric string** or **null**, where the numbers must be positive integers.
        /// - maximum-am-resource-percent: maximum AM percent. The value is a **numeric string** or **null**, where the number range is [0,1] or -1.
        /// - default-application-priority: Resource pool priority. The value is a **numeric string** or **null**, where the numbers must be positive integers.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BasicParams")]
        public Item[] BasicParams{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConfigSet", this.ConfigSet);
            this.SetParamArrayObj(map, prefix + "LabelParams.", this.LabelParams);
            this.SetParamArrayObj(map, prefix + "BasicParams.", this.BasicParams);
        }
    }
}

