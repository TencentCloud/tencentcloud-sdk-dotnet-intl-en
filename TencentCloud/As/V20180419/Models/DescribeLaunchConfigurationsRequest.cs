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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeLaunchConfigurationsRequest : AbstractModel
    {
        
        /// <summary>
        /// Queries by one or more launch configuration IDs in the format of `asc-ouy1ax38`. The maximum quantity per request is 100. This parameter does not support specifying both `LaunchConfigurationIds` and `Filters` at the same time.
        /// </summary>
        [JsonProperty("LaunchConfigurationIds")]
        public string[] LaunchConfigurationIds{ get; set; }

        /// <summary>
        /// Filters.
        /// <li> launch-configuration-id - String - Required: No - (Filter) Filter by launch configuration ID.</li>
        /// <li> launch-configuration-name - String - Required: No - (Filter) Filter by launch configuration name.</li>
        /// <li> launch-configuration-name - String - Required: No - (Filter) Fuzzy search by launch configuration name.</li>
        /// The maximum number of `Filters` in each request is 10. The upper limit for `Filter.Values` is 5. This parameter cannot specify `LaunchConfigurationIds` and `Filters` at the same time.
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Number of returned results. Default value: 20. Maximum value: 100. For more information on `Limit`, see the relevant section in the API [overview](https://intl.cloud.tencent.com/document/api/213/15688?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Offset. Default value: 0. For more information on `Offset`, see the relevant section in the API [overview](https://intl.cloud.tencent.com/document/api/213/15688?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "LaunchConfigurationIds.", this.LaunchConfigurationIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
        }
    }
}

