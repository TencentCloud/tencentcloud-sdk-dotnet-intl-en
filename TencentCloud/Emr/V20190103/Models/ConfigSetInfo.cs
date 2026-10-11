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
        /// The capacity scheduler uses it to configure label-related settings. The value of key is consistent with the field returned by **DescribeYarnQueue**.
        /// The key value information is as follows:
        /// - labelName: label name, which is the label in label management.
        /// - capacity: capacity. The value is a **numeric string**.
        /// - maximum-capacity: maximum capacity. The value is a **numeric string**.
        /// </summary>
        [JsonProperty("LabelParams")]
        public ItemSeq[] LabelParams{ get; set; }

        /// <summary>
        /// Sets the parameters related to the configuration set. The value of key is consistent with the field returned by **DescribeYarnQueue**.
        /// ###### Fair scheduler.
        /// The key value information is as follows:
        /// - minResources: minimum resource amount. The value is a **JSON string of the YarnResource type** or **null**.
        /// - maxResources: maximum resource amount. The value is a **JSON string of the YarnResource type** or **null**.
        /// - maxChildResources: maximum resource amount that can be allocated to undeclared subqueues. The value is a **numeric string** or **null**.
        /// - maxRunningApps: maximum number of apps that can run simultaneously. The value is a **numeric string** or **null**.
        /// - weight: weight. The value is a **numeric string** or **null**.
        /// - maxAMShare: maximum share of the App Master. The value is a **numeric string** or **null**, where the numeric range is [0, 1] or -1.
        /// 
        /// ```
        /// type YarnResource struct {
        /// 	Vcores *int `json:"vcores"`
        /// 	Memory *int `json:"memory"`
        /// 	Type *string `json:"type"` // The value is `percent` or `null`. When the value is `percent`, it indicates the percentage used; otherwise, it is the absolute value used. Only maxResources and maxChildResources can be set to `percent`.
        /// }
        /// ```
        /// 
        /// ###### Capacity scheduler.
        /// The key value information is as follows:
        /// - minimum-user-limit-percent: minimum user capacity. The value is a **JSON string of the YarnResource type** or **null**, where the numeric range is [0, 100].
        /// - user-limit-factor: user resource factor. The value is a **JSON string of the YarnResource type** or **null**.
        /// - maximum-applications: maximum number of applications (Max-Applications). The value is a **numeric string** or **null**, where the number is a positive integer.
        /// - maximum-am-resource-percent: maximum AM ratio. The value is a **numeric string** or **null**, where the numeric range is [0, 1] or -1.
        /// - default-application-priority: resource pool priority. The value is a **numeric string** or **null**, where the number is a positive integer.
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

